namespace LoanManagementApp.Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            flowLayoutPanelTabs = new FlowLayoutPanel();
            button3 = new Button();
            notifyIcon = new NotifyIcon(components);
            NotifyIconMenuStrip = new ContextMenuStrip(components);
            openToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            RentsLayoutPanel = new FlowLayoutPanel();
            LoansLayoutPanel = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panelTitleBar = new Panel();
            label5 = new Label();
            MinimizeButton = new Button();
            MaximizeButton = new Button();
            CloseButton = new Button();
            AddRentButton = new Button();
            AddLoanButton = new Button();
            NotifyIconMenuStrip.SuspendLayout();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelTabs
            // 
            flowLayoutPanelTabs.BackColor = Color.FromArgb(34, 34, 34);
            flowLayoutPanelTabs.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanelTabs.Location = new Point(12, 80);
            flowLayoutPanelTabs.Name = "flowLayoutPanelTabs";
            flowLayoutPanelTabs.Size = new Size(182, 538);
            flowLayoutPanelTabs.TabIndex = 9;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(35, 35, 35);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button3.ForeColor = Color.FromArgb(224, 224, 224);
            button3.Location = new Point(12, 44);
            button3.Name = "button3";
            button3.Size = new Size(182, 30);
            button3.TabIndex = 10;
            button3.Text = "Dodaj zakładke";
            button3.UseVisualStyleBackColor = false;
            button3.Click += AddTabButton;
            // 
            // notifyIcon
            // 
            notifyIcon.ContextMenuStrip = NotifyIconMenuStrip;
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "LoanManager";
            notifyIcon.Visible = true;
            // 
            // NotifyIconMenuStrip
            // 
            NotifyIconMenuStrip.Items.AddRange(new ToolStripItem[] { openToolStripMenuItem, exitToolStripMenuItem });
            NotifyIconMenuStrip.Name = "NotifyIconMenuStrip";
            NotifyIconMenuStrip.Size = new Size(104, 48);
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(103, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(103, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // RentsLayoutPanel
            // 
            RentsLayoutPanel.AutoScroll = true;
            RentsLayoutPanel.BackColor = Color.FromArgb(34, 34, 34);
            RentsLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
            RentsLayoutPanel.Location = new Point(202, 80);
            RentsLayoutPanel.Name = "RentsLayoutPanel";
            RentsLayoutPanel.Size = new Size(1052, 250);
            RentsLayoutPanel.TabIndex = 11;
            // 
            // LoansLayoutPanel
            // 
            LoansLayoutPanel.AutoScroll = true;
            LoansLayoutPanel.BackColor = Color.FromArgb(34, 34, 34);
            LoansLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
            LoansLayoutPanel.Location = new Point(202, 368);
            LoansLayoutPanel.Name = "LoansLayoutPanel";
            LoansLayoutPanel.Size = new Size(1052, 250);
            LoansLayoutPanel.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(202, 56);
            label1.Name = "label1";
            label1.Size = new Size(72, 21);
            label1.TabIndex = 13;
            label1.Text = "Czynsze";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(202, 344);
            label2.Name = "label2";
            label2.Size = new Size(46, 21);
            label2.TabIndex = 14;
            label2.Text = "Raty";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = SystemColors.ButtonShadow;
            label3.Location = new Point(427, 56);
            label3.Name = "label3";
            label3.Size = new Size(119, 21);
            label3.TabIndex = 15;
            label3.Text = "Gosia(Kwota)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.ForeColor = SystemColors.ButtonShadow;
            label4.Location = new Point(639, 56);
            label4.Name = "label4";
            label4.Size = new Size(112, 21);
            label4.TabIndex = 16;
            label4.Text = "Arek(Kwota)";
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(18, 18, 18);
            panelTitleBar.BorderStyle = BorderStyle.FixedSingle;
            panelTitleBar.Controls.Add(label5);
            panelTitleBar.Controls.Add(MinimizeButton);
            panelTitleBar.Controls.Add(MaximizeButton);
            panelTitleBar.Controls.Add(CloseButton);
            panelTitleBar.Location = new Point(-4, -6);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1277, 39);
            panelTitleBar.TabIndex = 17;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(15, 14);
            label5.Name = "label5";
            label5.Size = new Size(118, 17);
            label5.TabIndex = 3;
            label5.Text = "LoanManagement";
            // 
            // MinimizeButton
            // 
            MinimizeButton.FlatAppearance.BorderSize = 0;
            MinimizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 69, 69);
            MinimizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 56, 56);
            MinimizeButton.FlatStyle = FlatStyle.Flat;
            MinimizeButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            MinimizeButton.ForeColor = Color.FromArgb(204, 204, 204);
            MinimizeButton.Location = new Point(1147, 3);
            MinimizeButton.Name = "MinimizeButton";
            MinimizeButton.Size = new Size(36, 35);
            MinimizeButton.TabIndex = 2;
            MinimizeButton.Text = "−";
            MinimizeButton.UseVisualStyleBackColor = true;
            MinimizeButton.Click += MinimizeButton_Click;
            // 
            // MaximizeButton
            // 
            MaximizeButton.FlatAppearance.BorderSize = 0;
            MaximizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 69, 69);
            MaximizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 56, 56);
            MaximizeButton.FlatStyle = FlatStyle.Flat;
            MaximizeButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            MaximizeButton.ForeColor = Color.FromArgb(204, 204, 204);
            MaximizeButton.Location = new Point(1189, 3);
            MaximizeButton.Name = "MaximizeButton";
            MaximizeButton.Size = new Size(36, 35);
            MaximizeButton.TabIndex = 1;
            MaximizeButton.Text = "□";
            MaximizeButton.TextAlign = ContentAlignment.TopRight;
            MaximizeButton.UseVisualStyleBackColor = true;
            MaximizeButton.Click += MaximizeButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 69, 69);
            CloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 56, 56);
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            CloseButton.ForeColor = Color.FromArgb(204, 204, 204);
            CloseButton.Location = new Point(1231, 3);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(36, 35);
            CloseButton.TabIndex = 0;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // AddRentButton
            // 
            AddRentButton.BackColor = Color.FromArgb(35, 35, 35);
            AddRentButton.FlatStyle = FlatStyle.Flat;
            AddRentButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            AddRentButton.ForeColor = Color.FromArgb(224, 224, 224);
            AddRentButton.Location = new Point(1107, 45);
            AddRentButton.Name = "AddRentButton";
            AddRentButton.Size = new Size(147, 33);
            AddRentButton.TabIndex = 18;
            AddRentButton.Text = "Dodaj Czynsz";
            AddRentButton.UseVisualStyleBackColor = false;
            AddRentButton.Click += AddNewPaymentButton;
            // 
            // AddLoanButton
            // 
            AddLoanButton.BackColor = Color.FromArgb(35, 35, 35);
            AddLoanButton.FlatStyle = FlatStyle.Flat;
            AddLoanButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            AddLoanButton.ForeColor = Color.FromArgb(224, 224, 224);
            AddLoanButton.Location = new Point(1107, 333);
            AddLoanButton.Name = "AddLoanButton";
            AddLoanButton.Size = new Size(147, 33);
            AddLoanButton.TabIndex = 19;
            AddLoanButton.Text = "Dodaj Rate";
            AddLoanButton.UseVisualStyleBackColor = false;
            AddLoanButton.Click += AddNewPaymentButton;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 22, 22);
            ClientSize = new Size(1268, 630);
            Controls.Add(AddLoanButton);
            Controls.Add(AddRentButton);
            Controls.Add(panelTitleBar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LoansLayoutPanel);
            Controls.Add(RentsLayoutPanel);
            Controls.Add(button3);
            Controls.Add(flowLayoutPanelTabs);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "LoanApp";
            FormClosing += Form_OnClosing;
            Load += LoadProject;
            Paint += Form1_Paint;
            NotifyIconMenuStrip.ResumeLayout(false);
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanelTabs;
        private Button button3;
        private NotifyIcon notifyIcon;
        private ContextMenuStrip NotifyIconMenuStrip;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private FlowLayoutPanel RentsLayoutPanel;
        private FlowLayoutPanel LoansLayoutPanel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panelTitleBar;
        private Button MinimizeButton;
        private Button MaximizeButton;
        private Button CloseButton;
        private Label label5;
        private Button AddRentButton;
        private Button AddLoanButton;
    }
}
