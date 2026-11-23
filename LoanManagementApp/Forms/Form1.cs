using LoanManagementApp.Controls;
using LoanManagementApp.Interfaces;
using LoanManagementApp.Managers;
using LoanManagementApp.Models;
using System.Runtime.InteropServices;
namespace LoanManagementApp.Forms
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        //
        private LoanManager loanManager = new LoanManager();
        private MonthChanger monthChanger = new MonthChanger();
        private SaveTimer saveTimer = new SaveTimer();
        private ISelectablePayment? _SelectedPaymentControl;
        private TabModel? _SelectedTabControl;
        //
        private bool exitRequested;
        public Form1()
        {
            InitializeComponent();
            //
            monthChanger.StartTimer();
            saveTimer.StartTimer();
            InitEventsTimer();
            //
        }
        private void InitEventsTimer()
        {
            saveTimer.SaveAction += SaveProject;
        }
        //Load method
        private void LoadProject(object sender, EventArgs e)//On Form Open
        {
            SaveData.Load();
            if (SaveData.categories?.Count == 0 || SaveData.categories == null) return;

            for (int i = 0; i < SaveData.categories?.Count; i++)
            {
                CreateTabControl(SaveData.categories[i]);
                loanManager.AddNewCategory(SaveData.categories[i]);
            }
        }
        //Save method
        private void Form_OnClosing(object sender, FormClosingEventArgs e)
        {
            if (!exitRequested)
            {
                e.Cancel = true;
                Hide();
                notifyIcon.Visible = true;
                return;
            }
            SaveProject();
        }
        private void SaveProject()
        {
            List<Category> categories = loanManager.GetCategories();
            SaveData.Save("Categories.json", categories);
        }
        //Create new Tab method
        private void CreateTabControl(Category category)
        {
            TabModel newTab = new TabModel(category);
            flowLayoutPanelTabs.Controls.Add(newTab);
            newTab.isSelected += TabControl_Selected;
            newTab.DeleteRequest += RemoveTabModelEvent;
        }
        //Show Forms to create Tab,Payment
        private void AddNewPaymentButton(object sender, EventArgs e)
        {
            if (_SelectedTabControl == null)
            {
                MessageBox.Show("Brak zaznaczonej zakładki!");
                return;
            }
            if (sender == AddLoanButton)
            {
                OpenNewFormPayment(NewPaymentForm.TypeOfPayment.Loan);
            }
            else if (sender == AddRentButton)
            {
                OpenNewFormPayment(NewPaymentForm.TypeOfPayment.Rent);
            }
        }
        private void OpenNewFormPayment(NewPaymentForm.TypeOfPayment payment)
        {
            NewPaymentForm paymentForm = new NewPaymentForm(payment);

            if (paymentForm.ShowDialog(this) != DialogResult.OK) return;

            if (paymentForm.CreatedLoan != null)
            {
                InitNewPayment(paymentForm, NewPaymentForm.TypeOfPayment.Loan);
            }
            else if (paymentForm.CreatedRent != null)
            {
                InitNewPayment(paymentForm, NewPaymentForm.TypeOfPayment.Rent);
            }
        }
        private void InitNewPayment(NewPaymentForm paymentForm, NewPaymentForm.TypeOfPayment typeOfPayment)
        {
            if (typeOfPayment == NewPaymentForm.TypeOfPayment.Loan)
            {
                //Add loan to current selected Tab
                _SelectedTabControl.category.AddLoan(paymentForm.CreatedLoan);
            }
            else if (typeOfPayment == NewPaymentForm.TypeOfPayment.Rent)
            {
                //Add Rent to current selected Tab
                _SelectedTabControl.category.AddRent(paymentForm.CreatedRent);
            }
            //RefreshUI
            _SelectedTabControl.RefreshNumberOfPayments();
            //Create new Prefab
            ShowLoans(_SelectedTabControl.category);
        }
        //Tab
        private void AddTabButton(object sender, EventArgs e)
        {
            NewTabForm tabForm = new NewTabForm();
            tabForm.ShowDialog();
            if (string.IsNullOrWhiteSpace(tabForm.nameTabBox))
            {
                MessageBox.Show("Brak Nazwy dla zakładki!");
                return;
            }
            Category newCategory = new Category(tabForm.nameTabBox);
            //Add new Category to LoanManager
            loanManager.AddNewCategory(newCategory);
            //Create new tab control
            CreateTabControl(newCategory);
        }
        //Remove Loan && Tab functions
        private void RemovePaymentEvent(object? sender, EventArgs e)
        {
            if (sender is not ISelectablePayment control) return;

            if (control is LoanControl loanControl)
            {
                _SelectedTabControl.category.RemoveLoan(loanControl?.loan);
            }
            else if (control is RentControl rentControl)
            {
                _SelectedTabControl.category.RemoveRent(rentControl?.rent);
            }
            _SelectedTabControl.RefreshNumberOfPayments();

            control.UnSubscribeEvents();
            control.RemoveFromLayout();

            if (_SelectedPaymentControl == control)
            {
                _SelectedPaymentControl = null;
            }
        }
        private void RemoveTabModelEvent(object? sender, EventArgs e)
        {
            if (sender is not TabModel tab) return;

            loanManager.RemoveCategory(tab.category);

            LoansLayoutPanel.Controls.Clear();
            RentsLayoutPanel.Controls.Clear();
            _SelectedTabControl = null;
            _SelectedPaymentControl = null;

            flowLayoutPanelTabs.Controls.Remove(tab);
            tab.Dispose();
        }
        //
        //Selecting Function
        private void PaymentControl_Selected(object? sender, EventArgs e)
        {
            if (sender is not ISelectablePayment control)
                return;
            //
            if (_SelectedPaymentControl != null)
            {
                _SelectedPaymentControl.SetSelect(false);
                _SelectedPaymentControl = null;
            }
            _SelectedPaymentControl = control;
            _SelectedPaymentControl.SetSelect(true);
        }
        private void TabControl_Selected(object? sender, EventArgs e)
        {
            if (sender is not TabModel) return;

            if (_SelectedTabControl != null)
            {
                _SelectedTabControl.SetSelectTab(false);
            }
            if (_SelectedPaymentControl != null)
            {
                _SelectedPaymentControl.SetSelect(false);
                _SelectedPaymentControl = null;
            }
            _SelectedTabControl = (TabModel)sender;
            ShowLoans(_SelectedTabControl.category);
        }
        //Paid Event from each Loan Control
        private void PaidPaymentEvent(IPayAble payment)
        {
            if (payment == null) return;

            payment.MarkAsPaid();
        }
        //Show Loans from selected Tab
        private void ShowLoans(Category category)
        {
            LoansLayoutPanel.Controls.Clear();
            for (int i = 0; i < category.Loans.Count; i++)
            {
                LoanControl loanControl = new LoanControl(category.Loans[i], monthChanger);
                LoansLayoutPanel.Controls.Add(loanControl);
                //Give events from loancontrol
                loanControl.Selected += PaymentControl_Selected;
                loanControl.DeleteRequest += RemovePaymentEvent;
                loanControl.isPaidRequest += PaidPaymentEvent;
            }
            //
            RentsLayoutPanel.Controls.Clear();
            for (int i = 0; i < category.Rents.Count; i++)
            {
                RentControl rentControl = new RentControl(category.Rents[i], monthChanger);
                RentsLayoutPanel.Controls.Add(rentControl);
                //Give events from Rentcontrol
                rentControl.Selected += PaymentControl_Selected;
                rentControl.DeleteRequest += RemovePaymentEvent;
                rentControl.isPaidRequest += PaidPaymentEvent;
            }
        }

        //NotifyIcon Events
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitRequested = true;
            Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            Activate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.FromArgb(65, 65, 65), 1))
            {
                e.Graphics.DrawRectangle(
                    pen,
                    0, 0,
                    this.Width - 1,
                    this.Height - 1
                );
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0xA1, 0x2, 0);
            }
        }

        //Rents System
        //Exit Program Request

        //zrobilem wszystko moze jeszcze to na dole zrob i koniec
        //komunikaty jak sie zbliza rata zeby sie wyswietlalo w prawym dolnym rogu systemu


        //dopisz przebiegi systemow do loanmanager

        //przebieg nowego systemu
        //klikam nowa zakladka -> addtabButton otwiera newTabForm -> dodaje dane do tabcontrol(nie wiem czy tam category nowego nie bedzie albo tutaj kiedy showdialog sie wylaczy)
        // -> form1 bedzie trzymal liste category -> przy zapisie bedzie wysylana lista category -> odczyt category i pod nie tworzone loany
    }
}
