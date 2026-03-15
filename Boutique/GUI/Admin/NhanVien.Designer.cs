namespace Boutique.GUI.Admin
{
    partial class NhanVien
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
            panel1 = new Panel();
            panel2 = new Panel();
            nhanVienList = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nhanVienList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(860, 44);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(nhanVienList);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(860, 454);
            panel2.TabIndex = 1;
            // 
            // nhanVienList
            // 
            nhanVienList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            nhanVienList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            nhanVienList.Dock = DockStyle.Fill;
            nhanVienList.Location = new Point(0, 0);
            nhanVienList.Name = "nhanVienList";
            nhanVienList.Size = new Size(860, 454);
            nhanVienList.TabIndex = 0;
            // 
            // NhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "NhanVien";
            Size = new Size(860, 498);
            Load += NhanVien_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nhanVienList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView nhanVienList;
    }
}
