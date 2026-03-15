namespace Boutique.GUI.User
{
    partial class ThanhToan
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
            thanhToanList = new DataGridView();
            inHoaDon_btn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)thanhToanList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(inHoaDon_btn);
            panel1.Controls.Add(thanhToanList);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(830, 653);
            panel1.TabIndex = 0;
            // 
            // thanhToanList
            // 
            thanhToanList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            thanhToanList.Dock = DockStyle.Fill;
            thanhToanList.Location = new Point(0, 0);
            thanhToanList.Name = "thanhToanList";
            thanhToanList.ReadOnly = true;
            thanhToanList.Size = new Size(830, 653);
            thanhToanList.TabIndex = 0;
            // 
            // inHoaDon_btn
            // 
            inHoaDon_btn.Dock = DockStyle.Bottom;
            inHoaDon_btn.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inHoaDon_btn.Location = new Point(0, 618);
            inHoaDon_btn.Name = "inHoaDon_btn";
            inHoaDon_btn.Size = new Size(830, 35);
            inHoaDon_btn.TabIndex = 0;
            inHoaDon_btn.Text = "Hóa Đơn";
            inHoaDon_btn.UseVisualStyleBackColor = true;
            inHoaDon_btn.Click += inHoaDon_btn_Click;
            // 
            // ThanhToan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ThanhToan";
            Size = new Size(830, 653);
            Load += ThanhToan_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)thanhToanList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView thanhToanList;
        private Button inHoaDon_btn;
    }
}
