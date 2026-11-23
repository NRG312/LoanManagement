using System.Text.Json.Serialization;

namespace LoanManagementApp.Models
{
    public class Category
    {
        public string Name { get; set; }
        [JsonInclude]
        public List<Loan> Loans { get; private set; } = new();
        [JsonInclude]
        public List<Rent> Rents { get; private set; } = new();
        public Category(string name)
        {
            Name = name;
        }
        public void AddRent(Rent rent)
        {
            Rents.Add(rent);
        }
        public void AddLoan(Loan loan)
        {
            Loans.Add(loan);
        }
        public void RemoveLoan(Loan loan)
        {
            Loans.Remove(loan);
        }
        public void RemoveRent(Rent rent)
        {
            Rents.Remove(rent);
        }
    }
}
