namespace LoanManagementApp.Controls
{
    partial class RentControl
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
            isPaidText = new Label();
            label1 = new Label();
            DeadLineDay = new Label();
            DeadLineMonth = new Label();
            panel1 = new Panel();
            NameRent = new Label();
            Label = new Label();
            panel2 = new Panel();
            Price1 = new Label();
            TextPrice1 = new Label();
            button1 = new Button();
            panel3 = new Panel();
            Price2 = new Label();
            TextPrice2 = new Label();
            button2 = new Button();
            panel4 = new Panel();
            PriceText = new Label();
            label7 = new Label();
            DeleteRentContextMenu = new ContextMenuStrip(components);
            usuńRateToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            DeleteRentContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // isPaidText
            // 
            isPaidText.AutoSize = true;
            isPaidText.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            isPaidText.ForeColor = Color.Lime;
            isPaidText.Location = new Point(905, 4);
            isPaidText.Name = "isPaidText";
            isPaidText.Size = new Size(108, 18);
            isPaidText.TabIndex = 13;
            isPaidText.Text = "Nie Opłacone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(772, 25);
            label1.Name = "label1";
            label1.Size = new Size(124, 18);
            label1.TabIndex = 14;
            label1.Text = "Termin Zapłaty:";
            // 
            // DeadLineDay
            // 
            DeadLineDay.AutoSize = true;
            DeadLineDay.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic);
            DeadLineDay.ForeColor = SystemColors.ButtonShadow;
            DeadLineDay.Location = new Point(893, 25);
            DeadLineDay.Name = "DeadLineDay";
            DeadLineDay.Size = new Size(26, 18);
            DeadLineDay.TabIndex = 15;
            DeadLineDay.Text = "14";
            // 
            // DeadLineMonth
            // 
            DeadLineMonth.AutoSize = true;
            DeadLineMonth.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            DeadLineMonth.ForeColor = SystemColors.ButtonShadow;
            DeadLineMonth.Location = new Point(914, 25);
            DeadLineMonth.Name = "DeadLineMonth";
            DeadLineMonth.Size = new Size(99, 19);
            DeadLineMonth.TabIndex = 16;
            DeadLineMonth.Text = "Październik";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(NameRent);
            panel1.Controls.Add(Label);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(178, 42);
            panel1.TabIndex = 17;
            // 
            // NameRent
            // 
            NameRent.AutoSize = true;
            NameRent.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic);
            NameRent.ForeColor = Color.FromArgb(224, 224, 224);
            NameRent.Location = new Point(67, 16);
            NameRent.Name = "NameRent";
            NameRent.Size = new Size(36, 16);
            NameRent.TabIndex = 1;
            NameRent.Text = "Dom";
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Font = new Font("Arial Rounded MT Bold", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Label.ForeColor = Color.FromArgb(224, 224, 224);
            Label.Location = new Point(3, 4);
            Label.Name = "Label";
            Label.Size = new Size(91, 12);
            Label.TabIndex = 0;
            Label.Text = "Nazwa Czynszu";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(Price1);
            panel2.Controls.Add(TextPrice1);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(212, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(151, 42);
            panel2.TabIndex = 18;
            // 
            // Price1
            // 
            Price1.AutoSize = true;
            Price1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Price1.ForeColor = Color.FromArgb(224, 224, 224);
            Price1.Location = new Point(33, 18);
            Price1.Name = "Price1";
            Price1.Size = new Size(41, 15);
            Price1.TabIndex = 15;
            Price1.Text = "Cena1";
            // 
            // TextPrice1
            // 
            TextPrice1.AutoSize = true;
            TextPrice1.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            TextPrice1.ForeColor = Color.Lime;
            TextPrice1.Location = new Point(3, 1);
            TextPrice1.Name = "TextPrice1";
            TextPrice1.Size = new Size(90, 16);
            TextPrice1.TabIndex = 14;
            TextPrice1.Text = "Nie Opłacone";
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(99, 3);
            button1.Name = "button1";
            button1.Size = new Size(49, 33);
            button1.TabIndex = 0;
            button1.Text = "Opłać";
            button1.UseVisualStyleBackColor = false;
            button1.Click += PayPrice1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(Price2);
            panel3.Controls.Add(TextPrice2);
            panel3.Controls.Add(button2);
            panel3.Location = new Point(413, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(150, 42);
            panel3.TabIndex = 19;
            // 
            // Price2
            // 
            Price2.AutoSize = true;
            Price2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Price2.ForeColor = Color.FromArgb(224, 224, 224);
            Price2.Location = new Point(37, 18);
            Price2.Name = "Price2";
            Price2.Size = new Size(41, 15);
            Price2.TabIndex = 15;
            Price2.Text = "Cena2";
            // 
            // TextPrice2
            // 
            TextPrice2.AutoSize = true;
            TextPrice2.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            TextPrice2.ForeColor = Color.Lime;
            TextPrice2.Location = new Point(3, 1);
            TextPrice2.Name = "TextPrice2";
            TextPrice2.Size = new Size(90, 16);
            TextPrice2.TabIndex = 14;
            TextPrice2.Text = "Nie Opłacone";
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(99, 3);
            button2.Name = "button2";
            button2.Size = new Size(49, 33);
            button2.TabIndex = 0;
            button2.Text = "Opłać";
            button2.UseVisualStyleBackColor = false;
            button2.Click += PayPrice2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 64, 64);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(PriceText);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(637, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(129, 41);
            panel4.TabIndex = 20;
            // 
            // PriceText
            // 
            PriceText.AutoSize = true;
            PriceText.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic);
            PriceText.ForeColor = Color.FromArgb(224, 224, 224);
            PriceText.Location = new Point(48, 16);
            PriceText.Name = "PriceText";
            PriceText.Size = new Size(38, 16);
            PriceText.TabIndex = 1;
            PriceText.Text = "Cena";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(224, 224, 224);
            label7.Location = new Point(3, 4);
            label7.Name = "label7";
            label7.Size = new Size(83, 12);
            label7.TabIndex = 0;
            label7.Text = "Cena Czynszu";
            // 
            // DeleteRentContextMenu
            // 
            DeleteRentContextMenu.Items.AddRange(new ToolStripItem[] { usuńRateToolStripMenuItem });
            DeleteRentContextMenu.Name = "contextMenuStrip1";
            DeleteRentContextMenu.Size = new Size(141, 26);
            // 
            // usuńRateToolStripMenuItem
            // 
            usuńRateToolStripMenuItem.Name = "usuńRateToolStripMenuItem";
            usuńRateToolStripMenuItem.Size = new Size(140, 22);
            usuńRateToolStripMenuItem.Text = "Usuń Czynsz";
            usuńRateToolStripMenuItem.Click += DeleteRentButton;
            // 
            // RentControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 56, 45);
            BorderStyle = BorderStyle.FixedSingle;
            ContextMenuStrip = DeleteRentContextMenu;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(DeadLineMonth);
            Controls.Add(DeadLineDay);
            Controls.Add(label1);
            Controls.Add(isPaidText);
            Name = "RentControl";
            Size = new Size(1025, 47);
            Click += RentControl_SelectEvent;
            Paint += RentControl_Paint;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            DeleteRentContextMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label isPaidText;
        private Label label1;
        private Label DeadLineDay;
        private Label DeadLineMonth;
        private Panel panel1;
        private Label NameRent;
        private Label Label;
        private Panel panel2;
        private Label TextPrice1;
        private Button button1;
        private Label Price1;
        private Panel panel3;
        private Label Price2;
        private Label TextPrice2;
        private Button button2;
        private Panel panel4;
        private Label PriceText;
        private Label label7;
        private ContextMenuStrip DeleteRentContextMenu;
        private ToolStripMenuItem usuńRateToolStripMenuItem;
    }
}
