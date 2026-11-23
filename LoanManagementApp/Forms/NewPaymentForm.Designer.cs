namespace LoanManagementApp.Forms
{
    partial class NewPaymentForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NameRentTextBox = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            TextBoxActualLoans = new TextBox();
            panel4 = new Panel();
            label4 = new Label();
            DeadLineLoanText = new TextBox();
            panel5 = new Panel();
            panel7 = new Panel();
            IsPaidRentCheck = new CheckBox();
            label5 = new Label();
            TextBoxRentPrice = new TextBox();
            AddButton = new Button();
            CancelButton = new Button();
            RentPanel = new Panel();
            label7 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            DeadLineRentTextBox = new TextBox();
            LoanPanel = new Panel();
            label9 = new Label();
            panel9 = new Panel();
            label8 = new Label();
            NameLoanTextBox = new TextBox();
            panel6 = new Panel();
            panel8 = new Panel();
            IsPaidLoanCheck = new CheckBox();
            label6 = new Label();
            LoanPriceTextBox = new TextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            RentPanel.SuspendLayout();
            panel2.SuspendLayout();
            LoanPanel.SuspendLayout();
            panel9.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // NameRentTextBox
            // 
            NameRentTextBox.Location = new Point(116, 11);
            NameRentTextBox.Name = "NameRentTextBox";
            NameRentTextBox.Size = new Size(225, 23);
            NameRentTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 17);
            label1.Name = "label1";
            label1.Size = new Size(94, 17);
            label1.TabIndex = 1;
            label1.Text = "Nazwa Raty";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(NameRentTextBox);
            panel1.Location = new Point(0, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(349, 50);
            panel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.MenuHighlight;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(TextBoxActualLoans);
            panel3.Location = new Point(0, 107);
            panel3.Name = "panel3";
            panel3.Size = new Size(349, 50);
            panel3.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(7, 17);
            label3.Name = "label3";
            label3.Size = new Size(106, 17);
            label3.TabIndex = 1;
            label3.Text = "Aktualnie Rat";
            // 
            // TextBoxActualLoans
            // 
            TextBoxActualLoans.Location = new Point(139, 11);
            TextBoxActualLoans.Name = "TextBoxActualLoans";
            TextBoxActualLoans.Size = new Size(202, 23);
            TextBoxActualLoans.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.MenuHighlight;
            panel4.Controls.Add(label4);
            panel4.Controls.Add(DeadLineLoanText);
            panel4.Location = new Point(0, 163);
            panel4.Name = "panel4";
            panel4.Size = new Size(349, 50);
            panel4.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(7, 17);
            label4.Name = "label4";
            label4.Size = new Size(146, 17);
            label4.TabIndex = 1;
            label4.Text = "Termin Spłat(Dzień)";
            // 
            // DeadLineLoanText
            // 
            DeadLineLoanText.Location = new Point(161, 11);
            DeadLineLoanText.Name = "DeadLineLoanText";
            DeadLineLoanText.Size = new Size(180, 23);
            DeadLineLoanText.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.MenuHighlight;
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(TextBoxRentPrice);
            panel5.Location = new Point(0, 234);
            panel5.Name = "panel5";
            panel5.Size = new Size(349, 50);
            panel5.TabIndex = 4;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.Info;
            panel7.Controls.Add(IsPaidRentCheck);
            panel7.Location = new Point(224, 11);
            panel7.Name = "panel7";
            panel7.Size = new Size(122, 28);
            panel7.TabIndex = 3;
            // 
            // IsPaidRentCheck
            // 
            IsPaidRentCheck.AutoSize = true;
            IsPaidRentCheck.Location = new Point(3, 6);
            IsPaidRentCheck.Name = "IsPaidRentCheck";
            IsPaidRentCheck.Size = new Size(120, 19);
            IsPaidRentCheck.TabIndex = 2;
            IsPaidRentCheck.Text = "Opłacony miesiąc";
            IsPaidRentCheck.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(7, 17);
            label5.Name = "label5";
            label5.Size = new Size(46, 17);
            label5.TabIndex = 1;
            label5.Text = "Cena";
            // 
            // TextBoxRentPrice
            // 
            TextBoxRentPrice.Location = new Point(68, 11);
            TextBoxRentPrice.Name = "TextBoxRentPrice";
            TextBoxRentPrice.Size = new Size(72, 23);
            TextBoxRentPrice.TabIndex = 0;
            // 
            // AddButton
            // 
            AddButton.BackColor = SystemColors.ControlDark;
            AddButton.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            AddButton.Location = new Point(196, 293);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(150, 38);
            AddButton.TabIndex = 5;
            AddButton.Text = "Dodaj";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = SystemColors.ControlDark;
            CancelButton.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            CancelButton.Location = new Point(12, 293);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(150, 38);
            CancelButton.TabIndex = 6;
            CancelButton.Text = "Anuluj";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // RentPanel
            // 
            RentPanel.Controls.Add(label7);
            RentPanel.Controls.Add(panel1);
            RentPanel.Controls.Add(panel2);
            RentPanel.Controls.Add(panel5);
            RentPanel.Location = new Point(3, 3);
            RentPanel.Name = "RentPanel";
            RentPanel.Size = new Size(349, 284);
            RentPanel.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label7.Location = new Point(139, 6);
            label7.Name = "label7";
            label7.Size = new Size(79, 30);
            label7.TabIndex = 6;
            label7.Text = "Czynsz";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(DeadLineRentTextBox);
            panel2.Location = new Point(0, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(349, 50);
            panel2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(7, 17);
            label2.Name = "label2";
            label2.Size = new Size(146, 17);
            label2.TabIndex = 1;
            label2.Text = "Termin Spłat(Dzień)";
            // 
            // DeadLineRentTextBox
            // 
            DeadLineRentTextBox.Location = new Point(161, 11);
            DeadLineRentTextBox.Name = "DeadLineRentTextBox";
            DeadLineRentTextBox.Size = new Size(180, 23);
            DeadLineRentTextBox.TabIndex = 0;
            // 
            // LoanPanel
            // 
            LoanPanel.Controls.Add(label9);
            LoanPanel.Controls.Add(panel9);
            LoanPanel.Controls.Add(panel6);
            LoanPanel.Controls.Add(panel3);
            LoanPanel.Controls.Add(panel4);
            LoanPanel.Location = new Point(3, 12);
            LoanPanel.Name = "LoanPanel";
            LoanPanel.Size = new Size(349, 283);
            LoanPanel.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label9.Location = new Point(151, 5);
            label9.Name = "label9";
            label9.Size = new Size(57, 30);
            label9.TabIndex = 6;
            label9.Text = "Rata";
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.MenuHighlight;
            panel9.Controls.Add(label8);
            panel9.Controls.Add(NameLoanTextBox);
            panel9.Location = new Point(0, 51);
            panel9.Name = "panel9";
            panel9.Size = new Size(349, 50);
            panel9.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(7, 17);
            label8.Name = "label8";
            label8.Size = new Size(94, 17);
            label8.TabIndex = 1;
            label8.Text = "Nazwa Raty";
            // 
            // NameLoanTextBox
            // 
            NameLoanTextBox.Location = new Point(116, 11);
            NameLoanTextBox.Name = "NameLoanTextBox";
            NameLoanTextBox.Size = new Size(225, 23);
            NameLoanTextBox.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.MenuHighlight;
            panel6.Controls.Add(panel8);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(LoanPriceTextBox);
            panel6.Location = new Point(0, 233);
            panel6.Name = "panel6";
            panel6.Size = new Size(349, 50);
            panel6.TabIndex = 5;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.Info;
            panel8.Controls.Add(IsPaidLoanCheck);
            panel8.Location = new Point(224, 11);
            panel8.Name = "panel8";
            panel8.Size = new Size(122, 28);
            panel8.TabIndex = 3;
            // 
            // IsPaidLoanCheck
            // 
            IsPaidLoanCheck.AutoSize = true;
            IsPaidLoanCheck.Location = new Point(3, 6);
            IsPaidLoanCheck.Name = "IsPaidLoanCheck";
            IsPaidLoanCheck.Size = new Size(120, 19);
            IsPaidLoanCheck.TabIndex = 2;
            IsPaidLoanCheck.Text = "Opłacony miesiąc";
            IsPaidLoanCheck.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(7, 17);
            label6.Name = "label6";
            label6.Size = new Size(46, 17);
            label6.TabIndex = 1;
            label6.Text = "Cena";
            // 
            // LoanPriceTextBox
            // 
            LoanPriceTextBox.Location = new Point(68, 11);
            LoanPriceTextBox.Name = "LoanPriceTextBox";
            LoanPriceTextBox.Size = new Size(72, 23);
            LoanPriceTextBox.TabIndex = 0;
            // 
            // NewPaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 343);
            Controls.Add(RentPanel);
            Controls.Add(LoanPanel);
            Controls.Add(CancelButton);
            Controls.Add(AddButton);
            Name = "NewPaymentForm";
            Text = "NewLoanForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            RentPanel.ResumeLayout(false);
            RentPanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            LoanPanel.ResumeLayout(false);
            LoanPanel.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox NameRentTextBox;
        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private Label label3;
        private TextBox TextBoxActualLoans;
        private Panel panel4;
        private Label label4;
        private TextBox DeadLineLoanText;
        private Panel panel5;
        private Label label5;
        private TextBox TextBoxRentPrice;
        private Button AddButton;
        private Button CancelButton;
        private CheckBox IsPaidRentCheck;
        private Panel panel7;
        private Panel RentPanel;
        private Panel LoanPanel;
        private Label label7;
        private Panel panel2;
        private Label label2;
        private TextBox DeadLineRentTextBox;
        private Label label9;
        private Panel panel9;
        private Label label8;
        private TextBox NameLoanTextBox;
        private Panel panel6;
        private Panel panel8;
        private CheckBox IsPaidLoanCheck;
        private Label label6;
        private TextBox LoanPriceTextBox;
    }
}