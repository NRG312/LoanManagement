
namespace LoanManagementApp.Forms
{
    public partial class NewTabForm : Form
    {
        public string? nameTabBox { get; private set; }
        public NewTabForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTabBoxText.Text))
            {
                MessageBox.Show("Uzupełnij Wszystkie pola!");
                return;
            }

            nameTabBox = NameTabBoxText.Text;
            Close();
        }
    }
}
