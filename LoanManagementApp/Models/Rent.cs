using LoanManagementApp.Interfaces;

namespace LoanManagementApp.Models
{
    public class Rent: IPayAble
    {
        public enum RentStatus
        {
            UnPaid,
            Paid
        }
        public RentStatus Status { get; set; }
        public string Name { get; }
        public int DeadLine { get; }
        public float Price { get; }

        public Rent(string name,int deadLine, float price, RentStatus status)
        {
            Name = name;
            DeadLine = deadLine;
            Price = price;
            Status = status;
        }
        public void MarkAsPaid()
        {
            Status = RentStatus.Paid;
        }
        public void MarkAsUnPaid()
        {
            Status = RentStatus.UnPaid;
        }
    }
}
