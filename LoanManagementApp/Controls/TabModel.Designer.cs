namespace LoanManagementApp.Controls
{
    partial class TabModel
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
            NameTab = new Label();
            DeleteTabMenu = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            NumberOfLoans = new Label();
            DeleteTabMenu.SuspendLayout();
            SuspendLayout();
            // 
            // NameTab
            // 
            NameTab.AutoSize = true;
            NameTab.ContextMenuStrip = DeleteTabMenu;
            NameTab.Font = new Font("Arial Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            NameTab.ForeColor = SystemColors.ButtonFace;
            NameTab.Location = new Point(6, 8);
            NameTab.Name = "NameTab";
            NameTab.Size = new Size(122, 18);
            NameTab.TabIndex = 0;
            NameTab.Text = "Nazwa Zakładki";
            // 
            // DeleteTabMenu
            // 
            DeleteTabMenu.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            DeleteTabMenu.Name = "DeleteMenu";
            DeleteTabMenu.Size = new Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(107, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += DeleteTabButton;
            // 
            // NumberOfLoans
            // 
            NumberOfLoans.AutoSize = true;
            NumberOfLoans.ContextMenuStrip = DeleteTabMenu;
            NumberOfLoans.Font = new Font("Arial Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            NumberOfLoans.ForeColor = SystemColors.ButtonFace;
            NumberOfLoans.Location = new Point(146, 8);
            NumberOfLoans.Name = "NumberOfLoans";
            NumberOfLoans.Size = new Size(17, 18);
            NumberOfLoans.TabIndex = 1;
            NumberOfLoans.Text = "0";
            // 
            // TabModel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 37, 37);
            BorderStyle = BorderStyle.FixedSingle;
            ContextMenuStrip = DeleteTabMenu;
            Controls.Add(NumberOfLoans);
            Controls.Add(NameTab);
            Name = "TabModel";
            Size = new Size(175, 34);
            Click += SelectTabEventClick;
            Paint += TabModel_Paint;
            DeleteTabMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameTab;
        private Label NumberOfLoans;
        private ContextMenuStrip DeleteTabMenu;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}
