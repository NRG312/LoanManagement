namespace LoanManagementApp.Controls
{
    partial class LoanControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Label = new Label();
            NameLoan = new Label();
            button1 = new Button();
            label4 = new Label();
            PriceText = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            ActualLoans = new Label();
            panel5 = new Panel();
            label5 = new Label();
            panel6 = new Panel();
            AmountLoansToPay = new TextBox();
            label7 = new Label();
            isPaidText = new Label();
            label1 = new Label();
            DeadLineDay = new Label();
            DeleteLoanContextMenu = new ContextMenuStrip(components);
            usuńRateToolStripMenuItem = new ToolStripMenuItem();
            DeadLineMonth = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            DeleteLoanContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Font = new Font("Arial Rounded MT Bold", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Label.ForeColor = Color.FromArgb(224, 224, 224);
            Label.Location = new Point(3, 4);
            Label.Name = "Label";
            Label.Size = new Size(70, 12);
            Label.TabIndex = 0;
            Label.Text = "Nazwa Raty";
            // 
            // NameLoan
            // 
            NameLoan.AutoSize = true;
            NameLoan.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic);
            NameLoan.ForeColor = Color.FromArgb(224, 224, 224);
            NameLoan.Location = new Point(45, 18);
            NameLoan.Name = "NameLoan";
            NameLoan.Size = new Size(80, 16);
            NameLoan.TabIndex = 1;
            NameLoan.Text = "Opłata Ford";
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(713, 3);
            button1.Name = "button1";
            button1.Size = new Size(49, 40);
            button1.TabIndex = 4;
            button1.Text = "Opłać Rate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += PayButton;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(3, 5);
            label4.Name = "label4";
            label4.Size = new Size(67, 14);
            label4.TabIndex = 5;
            label4.Text = "Cena Raty";
            // 
            // PriceText
            // 
            PriceText.AutoSize = true;
            PriceText.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            PriceText.ForeColor = Color.FromArgb(224, 224, 224);
            PriceText.Location = new Point(32, 22);
            PriceText.Name = "PriceText";
            PriceText.Size = new Size(38, 18);
            PriceText.TabIndex = 6;
            PriceText.Text = "120";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(NameLoan);
            panel1.Controls.Add(Label);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(178, 42);
            panel1.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(PriceText);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(233, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(101, 42);
            panel3.TabIndex = 9;
            // 
            // ActualLoans
            // 
            ActualLoans.AutoSize = true;
            ActualLoans.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            ActualLoans.ForeColor = Color.FromArgb(224, 224, 224);
            ActualLoans.Location = new Point(40, 21);
            ActualLoans.Name = "ActualLoans";
            ActualLoans.Size = new Size(26, 18);
            ActualLoans.TabIndex = 2;
            ActualLoans.Text = "64";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(64, 64, 64);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label5);
            panel5.Controls.Add(ActualLoans);
            panel5.Location = new Point(340, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(102, 41);
            panel5.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(3, 4);
            label5.Name = "label5";
            label5.Size = new Size(63, 14);
            label5.TabIndex = 5;
            label5.Text = "Suma Rat";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(64, 64, 64);
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(AmountLoansToPay);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(611, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(96, 42);
            panel6.TabIndex = 11;
            // 
            // AmountLoansToPay
            // 
            AmountLoansToPay.BackColor = Color.Silver;
            AmountLoansToPay.Location = new Point(15, 14);
            AmountLoansToPay.Name = "AmountLoansToPay";
            AmountLoansToPay.Size = new Size(69, 23);
            AmountLoansToPay.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label7.ForeColor = Color.FromArgb(224, 224, 224);
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(81, 13);
            label7.TabIndex = 5;
            label7.Text = "Wybierz ilość";
            // 
            // isPaidText
            // 
            isPaidText.AutoSize = true;
            isPaidText.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            isPaidText.ForeColor = Color.FromArgb(105, 201, 149);
            isPaidText.Location = new Point(903, 1);
            isPaidText.Name = "isPaidText";
            isPaidText.Size = new Size(108, 18);
            isPaidText.TabIndex = 12;
            isPaidText.Text = "Nie Opłacone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(768, 24);
            label1.Name = "label1";
            label1.Size = new Size(124, 18);
            label1.TabIndex = 13;
            label1.Text = "Termin Zapłaty:";
            // 
            // DeadLineDay
            // 
            DeadLineDay.AutoSize = true;
            DeadLineDay.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic);
            DeadLineDay.ForeColor = SystemColors.ButtonShadow;
            DeadLineDay.Location = new Point(889, 24);
            DeadLineDay.Name = "DeadLineDay";
            DeadLineDay.Size = new Size(26, 18);
            DeadLineDay.TabIndex = 14;
            DeadLineDay.Text = "14";
            // 
            // DeleteLoanContextMenu
            // 
            DeleteLoanContextMenu.Items.AddRange(new ToolStripItem[] { usuńRateToolStripMenuItem });
            DeleteLoanContextMenu.Name = "DeleteLoanContextMenu";
            DeleteLoanContextMenu.Size = new Size(128, 26);
            // 
            // usuńRateToolStripMenuItem
            // 
            usuńRateToolStripMenuItem.Name = "usuńRateToolStripMenuItem";
            usuńRateToolStripMenuItem.Size = new Size(127, 22);
            usuńRateToolStripMenuItem.Text = "Usuń Rate";
            usuńRateToolStripMenuItem.Click += DeleteLoanButton;
            // 
            // DeadLineMonth
            // 
            DeadLineMonth.AutoSize = true;
            DeadLineMonth.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            DeadLineMonth.ForeColor = SystemColors.ButtonShadow;
            DeadLineMonth.Location = new Point(912, 24);
            DeadLineMonth.Name = "DeadLineMonth";
            DeadLineMonth.Size = new Size(99, 19);
            DeadLineMonth.TabIndex = 15;
            DeadLineMonth.Text = "Październik";
            // 
            // LoanControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 56, 45);
            BorderStyle = BorderStyle.FixedSingle;
            ContextMenuStrip = DeleteLoanContextMenu;
            Controls.Add(DeadLineMonth);
            Controls.Add(DeadLineDay);
            Controls.Add(label1);
            Controls.Add(isPaidText);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(button1);
            Name = "LoanControl";
            Size = new Size(1025, 47);
            Click += LoanControl_SelectEvent;
            Paint += LoanControl_Paint;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            DeleteLoanContextMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label;
        private Label NameLoan;
        private Button button1;
        private Label label4;
        private Label PriceText;
        private Panel panel1;
        private Panel panel3;
        private Label ActualLoans;
        private Panel panel5;
        private Label label5;
        private Panel panel6;
        private TextBox AmountLoansToPay;
        private Label label7;
        private Label isPaidText;
        private Label label1;
        private Label DeadLineDay;
        private ContextMenuStrip DeleteLoanContextMenu;
        private ToolStripMenuItem usuńRateToolStripMenuItem;
        private Label DeadLineMonth;
    }
}
