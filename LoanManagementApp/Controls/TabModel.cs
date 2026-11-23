using LoanManagementApp.Models;
namespace LoanManagementApp.Controls
{
    public partial class TabModel : UserControl
    {
        public event EventHandler? isSelected;
        public event EventHandler? DeleteRequest;
        public Category category { get; private set; }
        private bool _isSelected = false;
        public TabModel(Category category)
        {
            InitializeComponent();
            //
            this.category = category;
            NameTab.Text = category.Name;
            RefreshNumberOfPayments();
            //event right mouse click
            this.MouseDown += TabMouseDown;
        }
        private void TabMouseDown(object? sender, MouseEventArgs e)
        {
            if (_isSelected) return;

            if (e.Button == MouseButtons.Right)
            {
                isSelected?.Invoke(this, EventArgs.Empty);
                SetSelectTab(true);
            }
        }
        private void SelectTabEventClick(object sender, EventArgs e)
        {
            if (_isSelected) return;

            isSelected?.Invoke(this, EventArgs.Empty);
            SetSelectTab(true);
        }

        public void SetSelectTab(bool select)
        {
            _isSelected = select;
            BackColor = select ? ColorTranslator.FromHtml("#26374A") : ColorTranslator.FromHtml("#252525");
            Invalidate();
        }
        public void RefreshNumberOfPayments()
        {
            int payments = category.Loans.Count + category.Rents.Count;
            NumberOfLoans.Text = payments.ToString();
        }

        private void DeleteTabButton(object sender, EventArgs e)
        {
            DeleteRequest?.Invoke(this, EventArgs.Empty);
        }

        private void TabModel_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor;
            borderColor = _isSelected ? ColorTranslator.FromHtml("#5799DC") : ColorTranslator.FromHtml("#252525");

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
