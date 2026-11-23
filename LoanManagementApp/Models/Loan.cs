using LoanManagementApp.Interfaces;

namespace LoanManagementApp.Models
{
    public class Loan: IPayAble
    {
        public enum LoanStatus
        {
            UnPaid,
            Paid
        }
        public LoanStatus Status { get; set; }
        public string Name { get; }
        public int ActualAmount { get; set; }
        public float Price { get; }
        public int DeadLine { get; }
        public Loan(string name, int actualAmount, float price, int deadLine, LoanStatus status)
        {
            Name = name;
            ActualAmount = actualAmount;
            Price = price;
            DeadLine = deadLine;
            Status = status;
        }
        public void ChangeActualAmount(int value)
        {
            ActualAmount = value;
        }
        public void MarkAsPaid()
        {
            Status = LoanStatus.Paid;
        }
        public void MarkAsUnPaid()
        {
            Status = LoanStatus.UnPaid;
        }
    }
}
