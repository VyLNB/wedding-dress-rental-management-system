
namespace Boutique.GUI.Admin.All_User_Control
{
    partial class UC_Report
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
            this.Load += new System.EventHandler(this.UC_Report_Load);

            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabctrlBaocao = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabpageTinhtrangsp = new System.Windows.Forms.TabPage();
            this.tabpageDoanhthu = new System.Windows.Forms.TabPage();
            this.DataGridViewDoanhthu = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblTongDoanhthu = new System.Windows.Forms.Label();
            this.btnThongke = new Guna.UI2.WinForms.Guna2Button();
            this.lblEndDoanhthu = new System.Windows.Forms.Label();
            this.lblStartDoanhthu = new System.Windows.Forms.Label();
            this.dtpkStartDoanhthu = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpkEndDoanhthu = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tabctrlBaocao.SuspendLayout();
            this.tabpageDoanhthu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDoanhthu)).BeginInit();
            this.SuspendLayout();
            // 
            // tabctrlBaocao
            // 
            this.tabctrlBaocao.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabctrlBaocao.Controls.Add(this.tabpageTinhtrangsp);
            this.tabctrlBaocao.Controls.Add(this.tabpageDoanhthu);
            this.tabctrlBaocao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabctrlBaocao.ItemSize = new System.Drawing.Size(180, 40);
            this.tabctrlBaocao.Location = new System.Drawing.Point(0, 0);
            this.tabctrlBaocao.Name = "tabctrlBaocao";
            this.tabctrlBaocao.SelectedIndex = 0;
            this.tabctrlBaocao.Size = new System.Drawing.Size(1882, 852);
            this.tabctrlBaocao.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabctrlBaocao.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabctrlBaocao.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabctrlBaocao.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabctrlBaocao.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabctrlBaocao.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabctrlBaocao.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabctrlBaocao.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabctrlBaocao.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabctrlBaocao.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabctrlBaocao.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabctrlBaocao.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tabctrlBaocao.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabctrlBaocao.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabctrlBaocao.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tabctrlBaocao.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tabctrlBaocao.TabIndex = 1;
            this.tabctrlBaocao.TabMenuBackColor = System.Drawing.Color.Silver;
            this.tabctrlBaocao.SelectedIndexChanged += new System.EventHandler(this.tabctrlBaocao_SelectedIndexChanged);
            // 
            // tabpageTinhtrangsp
            // 
            //this.tabpageTinhtrangsp.Location = new System.Drawing.Point(184, 4);
            //this.tabpageTinhtrangsp.Name = "tabpageTinhtrangsp";
            //this.tabpageTinhtrangsp.Padding = new System.Windows.Forms.Padding(3);
            //this.tabpageTinhtrangsp.Size = new System.Drawing.Size(1694, 844);
            //this.tabpageTinhtrangsp.TabIndex = 0;
            //this.tabpageTinhtrangsp.Text = "Tình trạng sp";
            //this.tabpageTinhtrangsp.UseVisualStyleBackColor = true;
            // 
            // tabpageDoanhthu
            // 
            this.tabpageDoanhthu.Controls.Add(this.DataGridViewDoanhthu);
            this.tabpageDoanhthu.Controls.Add(this.lblTongDoanhthu);
            this.tabpageDoanhthu.Controls.Add(this.btnThongke);
            this.tabpageDoanhthu.Controls.Add(this.lblEndDoanhthu);
            this.tabpageDoanhthu.Controls.Add(this.lblStartDoanhthu);
            this.tabpageDoanhthu.Controls.Add(this.dtpkStartDoanhthu);
            this.tabpageDoanhthu.Controls.Add(this.dtpkEndDoanhthu);
            this.tabpageDoanhthu.Location = new System.Drawing.Point(184, 4);
            this.tabpageDoanhthu.Name = "tabpageDoanhthu";
            this.tabpageDoanhthu.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageDoanhthu.Size = new System.Drawing.Size(1694, 844);
            this.tabpageDoanhthu.TabIndex = 1;
            this.tabpageDoanhthu.Text = "Doanh thu";
            this.tabpageDoanhthu.UseVisualStyleBackColor = true;
            // 
            // DataGridViewDoanhthu
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.DataGridViewDoanhthu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewDoanhthu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridViewDoanhthu.ColumnHeadersHeight = 4;
            this.DataGridViewDoanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewDoanhthu.DefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridViewDoanhthu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewDoanhthu.Location = new System.Drawing.Point(59, 276);
            this.DataGridViewDoanhthu.Name = "DataGridViewDoanhthu";
            this.DataGridViewDoanhthu.RowHeadersVisible = false;
            this.DataGridViewDoanhthu.RowHeadersWidth = 82;
            this.DataGridViewDoanhthu.RowTemplate.Height = 33;
            this.DataGridViewDoanhthu.Size = new System.Drawing.Size(987, 484);
            this.DataGridViewDoanhthu.TabIndex = 6;
            this.DataGridViewDoanhthu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewDoanhthu.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewDoanhthu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewDoanhthu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewDoanhthu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewDoanhthu.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewDoanhthu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewDoanhthu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewDoanhthu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewDoanhthu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DataGridViewDoanhthu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewDoanhthu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewDoanhthu.ThemeStyle.HeaderStyle.Height = 4;
            this.DataGridViewDoanhthu.ThemeStyle.ReadOnly = false;
            this.DataGridViewDoanhthu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewDoanhthu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewDoanhthu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DataGridViewDoanhthu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewDoanhthu.ThemeStyle.RowsStyle.Height = 33;
            this.DataGridViewDoanhthu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewDoanhthu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // lblTongDoanhthu
            // 
            this.lblTongDoanhthu.AutoSize = true;
            this.lblTongDoanhthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongDoanhthu.Location = new System.Drawing.Point(61, 182);
            this.lblTongDoanhthu.Name = "lblTongDoanhthu";
            this.lblTongDoanhthu.Size = new System.Drawing.Size(336, 51);
            this.lblTongDoanhthu.TabIndex = 5;
            this.lblTongDoanhthu.Text = "Tổng doanh thu";
            // 
            // btnThongke
            // 
            this.btnThongke.BorderRadius = 18;
            this.btnThongke.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongke.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongke.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongke.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongke.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThongke.ForeColor = System.Drawing.Color.White;
            this.btnThongke.Location = new System.Drawing.Point(866, 68);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(180, 45);
            this.btnThongke.TabIndex = 4;
            this.btnThongke.Text = "Thống kê";
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // lblEndDoanhthu
            // 
            this.lblEndDoanhthu.AutoSize = true;
            this.lblEndDoanhthu.Location = new System.Drawing.Point(65, 100);
            this.lblEndDoanhthu.Name = "lblEndDoanhthu";
            this.lblEndDoanhthu.Size = new System.Drawing.Size(144, 25);
            this.lblEndDoanhthu.TabIndex = 3;
            this.lblEndDoanhthu.Text = "Ngày kết thúc";
            // 
            // lblStartDoanhthu
            // 
            this.lblStartDoanhthu.AutoSize = true;
            this.lblStartDoanhthu.Location = new System.Drawing.Point(65, 47);
            this.lblStartDoanhthu.Name = "lblStartDoanhthu";
            this.lblStartDoanhthu.Size = new System.Drawing.Size(140, 25);
            this.lblStartDoanhthu.TabIndex = 2;
            this.lblStartDoanhthu.Text = "Ngày bắt đầu";
            // 
            // dtpkStartDoanhthu
            // 
            this.dtpkStartDoanhthu.Checked = true;
            this.dtpkStartDoanhthu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpkStartDoanhthu.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpkStartDoanhthu.Location = new System.Drawing.Point(294, 47);
            this.dtpkStartDoanhthu.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpkStartDoanhthu.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpkStartDoanhthu.Name = "dtpkStartDoanhthu";
            this.dtpkStartDoanhthu.Size = new System.Drawing.Size(445, 36);
            this.dtpkStartDoanhthu.TabIndex = 1;
            this.dtpkStartDoanhthu.Value = new System.DateTime(2025, 5, 2, 16, 46, 45, 801);
            // 
            // dtpkEndDoanhthu
            // 
            this.dtpkEndDoanhthu.Checked = true;
            this.dtpkEndDoanhthu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpkEndDoanhthu.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpkEndDoanhthu.Location = new System.Drawing.Point(294, 109);
            this.dtpkEndDoanhthu.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpkEndDoanhthu.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpkEndDoanhthu.Name = "dtpkEndDoanhthu";
            this.dtpkEndDoanhthu.Size = new System.Drawing.Size(445, 36);
            this.dtpkEndDoanhthu.TabIndex = 0;
            this.dtpkEndDoanhthu.Value = new System.DateTime(2025, 5, 2, 16, 44, 4, 582);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabctrlBaocao);
            this.Name = "UC_Report";
            this.Size = new System.Drawing.Size(1882, 852);
            this.tabctrlBaocao.ResumeLayout(false);
            this.tabpageDoanhthu.ResumeLayout(false);
            this.tabpageDoanhthu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDoanhthu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TabControl tabctrlBaocao;
        private System.Windows.Forms.TabPage tabpageTinhtrangsp;
        private System.Windows.Forms.TabPage tabpageDoanhthu;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpkStartDoanhthu;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpkEndDoanhthu;
        private Guna.UI2.WinForms.Guna2Button btnThongke;
        private System.Windows.Forms.Label lblEndDoanhthu;
        private System.Windows.Forms.Label lblStartDoanhthu;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewDoanhthu;
        private System.Windows.Forms.Label lblTongDoanhthu;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
