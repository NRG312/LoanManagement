using LoanManagementApp.Interfaces;
using LoanManagementApp.Managers;
using LoanManagementApp.Models;
using System.Globalization;

namespace LoanManagementApp.Controls
{
    public partial class RentControl : UserControl, ISelectablePayment
    {
        private bool PaidPrice1 = false;
        private bool PaidPrice2 = false;
        private bool _isSelected = false;
        public Rent rent { get; private set; }
        public event Action<IPayAble>? isPaidRequest;
        public event EventHandler? DeleteRequest;
        public event EventHandler? Selected;
        private MonthChanger monthChanger;
        public RentControl(Rent rent, MonthChanger monthChanger)
        {
            InitializeComponent();
            InitRentControl(rent, monthChanger);
            CheckStatusOfPayments();
            RefreshMonthPayment();
        }
        private void InitRentControl(Rent rent, MonthChanger monthChanger)
        {
            //MonthChanger
            this.monthChanger = monthChanger;
            monthChanger.onMonthChanged += ChangeStateNewMonth;
            //Init Variables
            this.rent = rent;
            DeadLineDay.Text = rent.DeadLine.ToString();
            PriceText.Text = rent.Price.ToString();
            NameRent.Text = rent.Name;
            Price1.Text = (rent.Price / 2).ToString();
            Price2.Text = (rent.Price / 2).ToString();
            //Event right click mouse
            this.MouseDown += RentControlMouseDown;
        }
        //Selecting through right click mouse
        private void RentControlMouseDown(object? sender, MouseEventArgs e)
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

            SetSelectRentControl(select);
        }
        public void SetSelectRentControl(bool select)
        {
            _isSelected = select;
            if (_isSelected)
            {
                BackColor = ColorTranslator.FromHtml("#26374A");
            }
            else
            {
                BackColor = rent.Status == Rent.RentStatus.Paid ? ColorTranslator.FromHtml("#20382D") : ColorTranslator.FromHtml("#3A2224");
            }
            Invalidate();
        }
        private void RentControl_SelectEvent(object sender, EventArgs e)
        {
            if (_isSelected) return;
            Selected?.Invoke(this, EventArgs.Empty);
        }
        //
        //Pay Gosia Price
        private void PayPrice1(object sender, EventArgs e)
        {
            if (PaidPrice1) return;
            PaidPrice1 = true;
            ChangeTextToPaid(TextPrice1);
            CheckPaidRent();
        }
        //Pay Arek Price
        private void PayPrice2(object sender, EventArgs e)
        {
            if (PaidPrice2) return;
            PaidPrice2 = true;
            ChangeTextToPaid(TextPrice2);
            CheckPaidRent();
        }
        private void ChangeTextToPaid(Label text)
        {
            text.Text = "Opłacone";
            text.ForeColor = ColorTranslator.FromHtml("#69C995");
        }
        //
        //Check status of payments Arek & Gosia
        private void CheckStatusOfPayments()
        {
            if (rent.Status == Rent.RentStatus.Paid)
            {
                PaidPrice1 = true;
                PaidPrice2 = true;
                TextPrice1.Text = "Opłacone";
                TextPrice1.ForeColor = ColorTranslator.FromHtml("#69C995");
                TextPrice2.Text = "Opłacone";
                TextPrice2.ForeColor = ColorTranslator.FromHtml("#69C995");
                //
                isPaidText.Text = "Opłacone";
                if (_isSelected) return;
                isPaidText.ForeColor = ColorTranslator.FromHtml("#69C995");
                BackColor = ColorTranslator.FromHtml("#20382D");
            }
            else
            {
                PaidPrice1 = false;
                PaidPrice2 = false;
                TextPrice1.Text = "Nie Opłacone";
                TextPrice1.ForeColor = ColorTranslator.FromHtml("#F07178");
                TextPrice2.Text = "Nie Opłacone";
                TextPrice2.ForeColor = ColorTranslator.FromHtml("#F07178");
                //
                isPaidText.Text = "Nie Opłacone";
                if (_isSelected) return;
                isPaidText.ForeColor = ColorTranslator.FromHtml("#F07178");
                BackColor = ColorTranslator.FromHtml("#3A2224");
            }
        }
        private void CheckPaidRent()
        {
            if (PaidPrice1 && PaidPrice2)
            {
                isPaidRequest?.Invoke(rent);
                RefreshMonthPayment();
                CheckStatusOfPayments();
            }
        }
        private void ChangeRentStateToUnPaid()
        {
            CheckStatusOfPayments();
            RefreshMonthPayment();
        }
        private void DeleteRentButton(object sender, EventArgs e)
        {
            DeleteRequest?.Invoke(this, EventArgs.Empty);
        }

        private void RefreshMonthPayment()
        {
            if (rent.Status == Rent.RentStatus.UnPaid)
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

        //After new month refresh state
        private void ChangeStateNewMonth(object? sender, OnMonthChangedEvent e)
        {
            rent.Status = Rent.RentStatus.UnPaid;
            ChangeRentStateToUnPaid();
        }

        private void RentControl_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor;
            if (_isSelected)
            {
                borderColor = ColorTranslator.FromHtml("#5799DC");
            }
            else
            {
                borderColor = rent.Status == Rent.RentStatus.Paid ? ColorTranslator.FromHtml("#20382D") : ColorTranslator.FromHtml("#3A2224");
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
