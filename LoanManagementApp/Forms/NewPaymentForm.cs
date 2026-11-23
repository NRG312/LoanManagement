using LoanManagementApp.Models;
namespace LoanManagementApp.Forms
{
    public partial class NewPaymentForm : Form
    {
        public enum TypeOfPayment
        {
            Rent,
            Loan
        }
        public TypeOfPayment typeOfPayment;
        public Loan? CreatedLoan { get; private set; }
        public Rent? CreatedRent { get; private set; }
        public NewPaymentForm(TypeOfPayment payment)
        {
            InitializeComponent();
            CheckTypeOfPayment(payment);
        }
        private void CheckTypeOfPayment(TypeOfPayment payment)
        {
            if (payment == TypeOfPayment.Loan)
            {
                typeOfPayment = TypeOfPayment.Loan;
                LoanPanel.Visible = true;
                RentPanel.Visible = false;
            }
            else if(payment == TypeOfPayment.Rent)
            {
                typeOfPayment = TypeOfPayment.Rent;
                LoanPanel.Visible = false;
                RentPanel.Visible = true;
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (typeOfPayment == TypeOfPayment.Loan)
            {
                CreateLoan();
            }
            else if (typeOfPayment == TypeOfPayment.Rent)
            {
                CreateRent();
            }
        }
        private void CreateLoan()
        {
            if (string.IsNullOrWhiteSpace(NameLoanTextBox.Text) || string.IsNullOrWhiteSpace(TextBoxActualLoans.Text) ||
                string.IsNullOrWhiteSpace(DeadLineLoanText.Text) || string.IsNullOrWhiteSpace(LoanPriceTextBox.Text))
            {
                MessageBox.Show("Uzupełnij Wszystkie Pola!");
                return;
            }
            if (!int.TryParse(TextBoxActualLoans.Text, out int actualAmount))
            {
                MessageBox.Show("Wprowadź poprawna liczbe w polu aktualnych rat.");
                return;
            }
            if (!float.TryParse(LoanPriceTextBox.Text, out float price))
            {
                MessageBox.Show("Wprowadź poprawna liczbe w polu ceny.");
                return;
            }
            if (!int.TryParse(DeadLineLoanText.Text, out int deadLine))
            {
                MessageBox.Show("Wprowadź poprawną date w terminie spłat.");
                return;
            }
            if (deadLine > 31 || deadLine < 1)
            {
                MessageBox.Show("Wprowadź poprawną date => 1 <> 31");
                return;
            }
            CreatedLoan = new Loan(NameLoanTextBox.Text, actualAmount, price, deadLine, IsPaidLoanCheck.Checked ? Loan.LoanStatus.Paid : Loan.LoanStatus.UnPaid);
            DialogResult = DialogResult.OK;
            Close();
        }
        private void CreateRent()
        {
            if (string.IsNullOrWhiteSpace(NameRentTextBox.Text) || string.IsNullOrWhiteSpace(DeadLineRentTextBox.Text) ||
                string.IsNullOrWhiteSpace(TextBoxRentPrice.Text))
            {
                MessageBox.Show("Uzupełnij Wszystkie Pola!");
                return;
            }
            if (!float.TryParse(TextBoxRentPrice.Text, out float price))
            {
                MessageBox.Show("Wprowadź poprawna liczbe w polu ceny.");
                return;
            }
            if (!int.TryParse(DeadLineRentTextBox.Text, out int deadLine))
            {
                MessageBox.Show("Wprowadź poprawną date w terminie spłat.");
                return;
            }
            if (deadLine > 31 || deadLine < 1)
            {
                MessageBox.Show("Wprowadź poprawną date => 1 <> 31");
                return;
            }
            CreatedRent = new Rent(NameRentTextBox.Text, deadLine,price , IsPaidRentCheck.Checked ? Rent.RentStatus.Paid : Rent.RentStatus.UnPaid);
            DialogResult = DialogResult.OK;
            Close();
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
