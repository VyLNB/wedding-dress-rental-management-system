namespace Boutique.GUI.User
{
    partial class KhachHangToolstrip_item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHangToolstrip_item));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            khachHangInfo = new Panel();
            updateKH_btn = new Button();
            deleteKH_btn = new Button();
            insertKH_btn = new Button();
            diaChiKH_txt = new TextBox();
            label4 = new Label();
            tenKhachHang = new Label();
            tenKhachHang_txt = new TextBox();
            label3 = new Label();
            soDienThoaiKH_txt = new TextBox();
            label2 = new Label();
            emailKH_txt = new TextBox();
            khachHangSearch_panel = new Panel();
            deleteAll_btn = new Button();
            searchKH_btn = new Button();
            maKH_txt = new TextBox();
            label1 = new Label();
            showKH = new Panel();
            khachHangList = new DataGridView();
            khachHangInfo.SuspendLayout();
            khachHangSearch_panel.SuspendLayout();
            showKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)khachHangList).BeginInit();
            SuspendLayout();
            // 
            // khachHangInfo
            // 
            khachHangInfo.BackColor = SystemColors.Control;
            khachHangInfo.Controls.Add(updateKH_btn);
            khachHangInfo.Controls.Add(deleteKH_btn);
            khachHangInfo.Controls.Add(insertKH_btn);
            khachHangInfo.Controls.Add(diaChiKH_txt);
            khachHangInfo.Controls.Add(label4);
            khachHangInfo.Controls.Add(tenKhachHang);
            khachHangInfo.Controls.Add(tenKhachHang_txt);
            khachHangInfo.Controls.Add(label3);
            khachHangInfo.Controls.Add(soDienThoaiKH_txt);
            khachHangInfo.Controls.Add(label2);
            khachHangInfo.Controls.Add(emailKH_txt);
            khachHangInfo.Dock = DockStyle.Top;
            khachHangInfo.Location = new Point(0, 0);
            khachHangInfo.Name = "khachHangInfo";
            khachHangInfo.Size = new Size(782, 109);
            khachHangInfo.TabIndex = 0;
            // 
            // updateKH_btn
            // 
            updateKH_btn.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateKH_btn.Location = new Point(755, 86);
            updateKH_btn.Name = "updateKH_btn";
            updateKH_btn.Size = new Size(75, 23);
            updateKH_btn.TabIndex = 10;
            updateKH_btn.Text = "Sửa";
            updateKH_btn.UseVisualStyleBackColor = true;
            updateKH_btn.Click += updateKH_btn_Click;
            // 
            // deleteKH_btn
            // 
            deleteKH_btn.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteKH_btn.Location = new Point(755, 45);
            deleteKH_btn.Name = "deleteKH_btn";
            deleteKH_btn.Size = new Size(75, 23);
            deleteKH_btn.TabIndex = 9;
            deleteKH_btn.Text = "Xóa";
            deleteKH_btn.UseVisualStyleBackColor = true;
            deleteKH_btn.Click += deleteKH_btn_Click;
            // 
            // insertKH_btn
            // 
            insertKH_btn.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            insertKH_btn.Location = new Point(755, 9);
            insertKH_btn.Name = "insertKH_btn";
            insertKH_btn.Size = new Size(75, 23);
            insertKH_btn.TabIndex = 1;
            insertKH_btn.Text = "Thêm";
            insertKH_btn.UseVisualStyleBackColor = true;
            insertKH_btn.Click += insertKH_btn_Click;
            // 
            // diaChiKH_txt
            // 
            diaChiKH_txt.Location = new Point(210, 83);
            diaChiKH_txt.Name = "diaChiKH_txt";
            diaChiKH_txt.Size = new Size(478, 23);
            diaChiKH_txt.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(112, 83);
            label4.Name = "label4";
            label4.Size = new Size(57, 18);
            label4.TabIndex = 6;
            label4.Text = "Địa chỉ";
            // 
            // tenKhachHang
            // 
            tenKhachHang.AutoSize = true;
            tenKhachHang.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tenKhachHang.Location = new Point(87, 9);
            tenKhachHang.Name = "tenKhachHang";
            tenKhachHang.Size = new Size(117, 18);
            tenKhachHang.TabIndex = 0;
            tenKhachHang.Text = "Tên khách hàng";
            // 
            // tenKhachHang_txt
            // 
            tenKhachHang_txt.Location = new Point(210, 9);
            tenKhachHang_txt.Name = "tenKhachHang_txt";
            tenKhachHang_txt.Size = new Size(478, 23);
            tenKhachHang_txt.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(104, 45);
            label3.Name = "label3";
            label3.Size = new Size(100, 18);
            label3.TabIndex = 4;
            label3.Text = "Số điện thoại";
            // 
            // soDienThoaiKH_txt
            // 
            soDienThoaiKH_txt.Location = new Point(210, 45);
            soDienThoaiKH_txt.Name = "soDienThoaiKH_txt";
            soDienThoaiKH_txt.Size = new Size(212, 23);
            soDienThoaiKH_txt.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(445, 45);
            label2.Name = "label2";
            label2.Size = new Size(48, 18);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // emailKH_txt
            // 
            emailKH_txt.Location = new Point(499, 45);
            emailKH_txt.Name = "emailKH_txt";
            emailKH_txt.Size = new Size(189, 23);
            emailKH_txt.TabIndex = 4;
            // 
            // khachHangSearch_panel
            // 
            khachHangSearch_panel.Controls.Add(deleteAll_btn);
            khachHangSearch_panel.Controls.Add(searchKH_btn);
            khachHangSearch_panel.Controls.Add(maKH_txt);
            khachHangSearch_panel.Controls.Add(label1);
            khachHangSearch_panel.Dock = DockStyle.Top;
            khachHangSearch_panel.Location = new Point(0, 109);
            khachHangSearch_panel.Name = "khachHangSearch_panel";
            khachHangSearch_panel.Size = new Size(782, 83);
            khachHangSearch_panel.TabIndex = 1;
            // 
            // deleteAll_btn
            // 
            deleteAll_btn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteAll_btn.Location = new Point(600, 55);
            deleteAll_btn.Name = "deleteAll_btn";
            deleteAll_btn.Size = new Size(88, 28);
            deleteAll_btn.TabIndex = 8;
            deleteAll_btn.Text = "Xóa tất cả";
            deleteAll_btn.UseVisualStyleBackColor = true;
            deleteAll_btn.Click += deleteAll_btn_Click;
            // 
            // searchKH_btn
            // 
            searchKH_btn.BackColor = SystemColors.Control;
            searchKH_btn.FlatAppearance.BorderColor = SystemColors.Control;
            searchKH_btn.FlatAppearance.BorderSize = 0;
            searchKH_btn.FlatStyle = FlatStyle.Flat;
            searchKH_btn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchKH_btn.Image = (Image)resources.GetObject("searchKH_btn.Image");
            searchKH_btn.Location = new Point(618, 17);
            searchKH_btn.Name = "searchKH_btn";
            searchKH_btn.Size = new Size(70, 37);
            searchKH_btn.TabIndex = 7;
            searchKH_btn.UseVisualStyleBackColor = false;
            // 
            // maKH_txt
            // 
            maKH_txt.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maKH_txt.Location = new Point(365, 23);
            maKH_txt.Name = "maKH_txt";
            maKH_txt.Size = new Size(247, 26);
            maKH_txt.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(210, 23);
            label1.Name = "label1";
            label1.Size = new Size(135, 22);
            label1.TabIndex = 0;
            label1.Text = "Mã khách hàng";
            // 
            // showKH
            // 
            showKH.Controls.Add(khachHangList);
            showKH.Dock = DockStyle.Fill;
            showKH.Location = new Point(0, 192);
            showKH.Name = "showKH";
            showKH.Size = new Size(782, 410);
            showKH.TabIndex = 2;
            // 
            // khachHangList
            // 
            khachHangList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            khachHangList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            khachHangList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            khachHangList.DefaultCellStyle = dataGridViewCellStyle2;
            khachHangList.Dock = DockStyle.Fill;
            khachHangList.Location = new Point(0, 0);
            khachHangList.Name = "khachHangList";
            khachHangList.Size = new Size(782, 410);
            khachHangList.TabIndex = 0;
            khachHangList.CellClick += khachHangList_CellClick;
            // 
            // KhachHangToolstrip_item
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(showKH);
            Controls.Add(khachHangSearch_panel);
            Controls.Add(khachHangInfo);
            Name = "KhachHangToolstrip_item";
            Size = new Size(782, 602);
            Load += KhachHangToolstrip_item_Load;
            khachHangInfo.ResumeLayout(false);
            khachHangInfo.PerformLayout();
            khachHangSearch_panel.ResumeLayout(false);
            khachHangSearch_panel.PerformLayout();
            showKH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)khachHangList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel khachHangInfo;
        private Panel khachHangSearch_panel;
        private Button searchKH_btn;
        private TextBox maKH_txt;
        private Label label1;
        private Panel showKH;
        private DataGridView khachHangList;
        private Label tenKhachHang;
        private TextBox tenKhachHang_txt;
        private TextBox diaChiKH_txt;
        private Label label4;
        private TextBox soDienThoaiKH_txt;
        private Label label3;
        private TextBox emailKH_txt;
        private Label label2;
        private Button updateKH_btn;
        private Button deleteKH_btn;
        private Button insertKH_btn;
        private Button deleteAll_btn;
    }
}
