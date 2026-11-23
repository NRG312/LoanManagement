namespace LoanManagementApp.Forms
{
    partial class NewTabForm
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
            label1 = new Label();
            NameTabBoxText = new TextBox();
            CancelButton = new Button();
            AddButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(37, 28);
            label1.Name = "label1";
            label1.Size = new Size(141, 22);
            label1.TabIndex = 0;
            label1.Text = "Nazwa Zakładki";
            // 
            // NameTabBoxText
            // 
            NameTabBoxText.BackColor = SystemColors.ScrollBar;
            NameTabBoxText.Location = new Point(37, 53);
            NameTabBoxText.Name = "NameTabBoxText";
            NameTabBoxText.Size = new Size(289, 23);
            NameTabBoxText.TabIndex = 1;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = SystemColors.ButtonShadow;
            CancelButton.Location = new Point(12, 159);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(166, 46);
            CancelButton.TabIndex = 2;
            CancelButton.Text = "Anuluj";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = SystemColors.ButtonShadow;
            AddButton.Location = new Point(184, 159);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(173, 46);
            AddButton.TabIndex = 3;
            AddButton.Text = "Dodaj";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // NewTabForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 208);
            Controls.Add(AddButton);
            Controls.Add(CancelButton);
            Controls.Add(NameTabBoxText);
            Controls.Add(label1);
            Name = "NewTabForm";
            Text = "NewTabForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NameTabBoxText;
        private Button CancelButton;
        private Button AddButton;
    }
}