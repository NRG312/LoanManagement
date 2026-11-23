using LoanManagementApp.Models;
using System.Globalization;
using LoanManagementApp.Interfaces;
using LoanManagementApp.Managers;
namespace LoanManagementApp.Controls
{
    public partial class LoanControl : UserControl, ISelectablePayment
    {
        public Loan? loan;
        private MonthChanger monthChanger;
        public event EventHandler? Selected;
        public event EventHandler? DeleteRequest;
        public event Action<IPayAble> isPaidRequest;
        private bool _isSelected = false;
        public LoanControl(Loan loan, MonthChanger monthChanger)
        {
            InitializeComponent();
            InitLoanControl(loan, monthChanger);
            CheckLoanState();
            InitMonthPayment();
        }
        private void InitLoanControl(Loan loan, MonthChanger monthChanger)
        {
            //MonthChanger
            this.monthChanger = monthChanger;
            monthChanger.onMonthChanged += ChangeStateNewMonth;
            //
            this.loan = loan;
            NameLoan.Text = loan.Name;
            ActualLoans.Text = loan.ActualAmount.ToString();
            PriceText.Text = loan.Price.ToString();
            DeadLineDay.Text = loan.DeadLine.ToString();
            //Event right click mouse
            this.MouseDown += LoanControlMouseDown;
        }
        //Selecting through right click mouse
        private void LoanControlMouseDown(object? sender, MouseEventArgs e)
        {
            if (_isSelected) return;

            if (e.Button == MouseButtons.Right)
            {
                Selected?.Invoke(this, EventArgs.Empty);
            }
        }
        //After Remove Loan Interface function
        public void UnSubscribeEvents()
        {
            Selected = null;
            DeleteRequest = null;
            isPaidRequest = null;
        }
        public void RemoveFromLayout()
        {
            Parent?.Controls.Remove(this);
            Dispose();
        }
        //Selecting System
        public void SetSelect(bool select)
        {
            if (_isSelected && select) return;

            SetSelectLoanControl(select);
        }
        public void SetSelectLoanControl(bool select)
        {
            _isSelected = select;
            if (_isSelected)
            {
                BackColor = ColorTranslator.FromHtml("#26374A");
            }
            else
            {
                BackColor = loan.Status == Loan.LoanStatus.Paid ? ColorTranslator.FromHtml("#20382D") : ColorTranslator.FromHtml("#3A2224");
            }

            Invalidate();
        }
        private void LoanControl_SelectEvent(object sender, EventArgs e)
        {
            if (_isSelected) return;
            Selected?.Invoke(this, EventArgs.Empty);
        }
        //
        private void InitMonthPayment()
        {
            if (loan.Status == Loan.LoanStatus.UnPaid)
            {
                string monthName = CultureInfo.GetCultureInfo("pl-PL").DateTimeFormat.GetMonthName(monthChanger.actualMonth);
                DeadLineMonth.Text = monthName;
            }
            else
            {
                string monthName = CultureInfo.GetCultureInfo("pl-PL").DateTimeFormat.GetMonthName(monthChanger.actualMonth + 1);
                DeadLineMonth.Text = monthName;
            }
        }
        //
        private void PayButton(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AmountLoansToPay.Text))
            {
                MessageBox.Show("Uzupełnij pole z ilością rat do zapłaty.");
                return;
            }

            //Change actual amount after pay
            int value = int.Parse(AmountLoansToPay.Text);
            int toPay = loan.ActualAmount - value;
            loan.ChangeActualAmount(toPay);
            RefreshText();

            //Event Payment && Month Changer
            isPaidRequest?.Invoke(loan);
            CheckLoanState();
            InitMonthPayment();

            //Check if actual amount == 0
            if (loan.ActualAmount == 0)
            {
                DeleteRequest?.Invoke(this, EventArgs.Empty);
            }
        }
        //
        private void DeleteLoanButton(object sender, EventArgs e)
        {
            DeleteRequest?.Invoke(this, EventArgs.Empty);
        }
        //Check Paid State From Loan
        public void CheckLoanState()
        {
            if (loan.Status == Loan.LoanStatus.Paid)
            {
                isPaidText.Text = "Opłacone";
                //
                if (_isSelected) return;
                isPaidText.ForeColor = ColorTranslator.FromHtml("#69C995");
                BackColor = ColorTranslator.FromHtml("#20382D");
            }
            else if (loan.Status == Loan.LoanStatus.UnPaid)
            {
                isPaidText.Text = "Nie Opłacone";
                //
                if (_isSelected) return;
                isPaidText.ForeColor = ColorTranslator.FromHtml("#F07178");
                BackColor = ColorTranslator.FromHtml("#3A2224");
            }
        }

        private void RefreshText()
        {
            ActualLoans.Text = loan.ActualAmount.ToString();
            AmountLoansToPay.Clear();
        }
        //After new month refresh state
        private void ChangeStateNewMonth(object? sender, OnMonthChangedEvent e)
        {
            loan.Status = Loan.LoanStatus.UnPaid;
            CheckLoanState();
        }

        private void LoanControl_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor;
            if (_isSelected)
            {
                borderColor = ColorTranslator.FromHtml("#5799DC");
            }
            else
            {
                borderColor = loan.Status == Loan.LoanStatus.Paid ? ColorTranslator.FromHtml("#20382D") : ColorTranslator.FromHtml("#3A2224");
            }

            using (Pen pen = new Pen(borderColor, 2))
            {
                e.Graphics.DrawRectangle(
                    pen,
                    0, 0,
                    Width - 2,
                    Height - 2
                );
            }
        }
    }
}
