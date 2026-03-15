namespace Boutique.GUI.User
{
    partial class DonThueStaff
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
            menuStrip1 = new MenuStrip();
            khachHangToolStripMenuItem = new ToolStripMenuItem();
            donThueToolStripMenuItem = new ToolStripMenuItem();
            donThue_toolstrip_panel = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { khachHangToolStripMenuItem, donThueToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(782, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // khachHangToolStripMenuItem
            // 
            khachHangToolStripMenuItem.Name = "khachHangToolStripMenuItem";
            khachHangToolStripMenuItem.Size = new Size(124, 26);
            khachHangToolStripMenuItem.Text = "Khách Hàng";
            khachHangToolStripMenuItem.Click += khachHangToolStripMenuItem_Click;
            // 
            // donThueToolStripMenuItem
            // 
            donThueToolStripMenuItem.Name = "donThueToolStripMenuItem";
            donThueToolStripMenuItem.Size = new Size(106, 26);
            donThueToolStripMenuItem.Text = "Đơn Thuê";
            donThueToolStripMenuItem.Click += donThueToolStripMenuItem_Click;
            // 
            // donThue_toolstrip_panel
            // 
            donThue_toolstrip_panel.Dock = DockStyle.Fill;
            donThue_toolstrip_panel.Location = new Point(0, 30);
            donThue_toolstrip_panel.Name = "donThue_toolstrip_panel";
            donThue_toolstrip_panel.Size = new Size(782, 602);
            donThue_toolstrip_panel.TabIndex = 1;
            // 
            // DonThueStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(donThue_toolstrip_panel);
            Controls.Add(menuStrip1);
            Name = "DonThueStaff";
            Size = new Size(782, 632);
            Load += DonThueStaff_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem khachHangToolStripMenuItem;
        private ToolStripMenuItem donThueToolStripMenuItem;
        private Panel donThue_toolstrip_panel;
    }
}
