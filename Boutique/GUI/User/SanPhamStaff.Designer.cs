namespace Boutique.GUI
{
    partial class SanPhamStaff
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            sanPham_group = new GroupBox();
            update_btn = new Button();
            deleteAll_btn = new Button();
            maSp_txt = new TextBox();
            delete_btn = new Button();
            label1 = new Label();
            insert_btn = new Button();
            label2 = new Label();
            loaiSp_box = new ComboBox();
            label3 = new Label();
            trangThaiSP_box = new ComboBox();
            soLuongSp_txt = new TextBox();
            trangThai = new Label();
            tenSp_txt = new TextBox();
            giaTienSp_txt = new TextBox();
            label4 = new Label();
            label5 = new Label();
            showSP = new GroupBox();
            sanPhamTable = new DataGridView();
            sanPham_group.SuspendLayout();
            showSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sanPhamTable).BeginInit();
            SuspendLayout();
            // 
            // sanPham_group
            // 
            sanPham_group.Controls.Add(update_btn);
            sanPham_group.Controls.Add(deleteAll_btn);
            sanPham_group.Controls.Add(delete_btn);
            sanPham_group.Controls.Add(insert_btn);
            sanPham_group.Controls.Add(trangThaiSP_box);
            sanPham_group.Controls.Add(soLuongSp_txt);
            sanPham_group.Controls.Add(label5);
            sanPham_group.Controls.Add(label1);
            sanPham_group.Controls.Add(trangThai);
            sanPham_group.Controls.Add(giaTienSp_txt);
            sanPham_group.Controls.Add(label4);
            sanPham_group.Controls.Add(maSp_txt);
            sanPham_group.Controls.Add(label3);
            sanPham_group.Controls.Add(tenSp_txt);
            sanPham_group.Controls.Add(label2);
            sanPham_group.Controls.Add(loaiSp_box);
            sanPham_group.Dock = DockStyle.Right;
            sanPham_group.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sanPham_group.Location = new Point(554, 0);
            sanPham_group.Name = "sanPham_group";
            sanPham_group.Size = new Size(222, 632);
            sanPham_group.TabIndex = 0;
            sanPham_group.TabStop = false;
            sanPham_group.Text = "Sản Phẩm";
            // 
            // update_btn
            // 
            update_btn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            update_btn.Location = new Point(159, 425);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(57, 28);
            update_btn.TabIndex = 13;
            update_btn.Text = "Sửa";
            update_btn.UseVisualStyleBackColor = true;
            update_btn.Click += update_btn_Click;
            // 
            // deleteAll_btn
            // 
            deleteAll_btn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteAll_btn.Location = new Point(6, 469);
            deleteAll_btn.Name = "deleteAll_btn";
            deleteAll_btn.Size = new Size(213, 27);
            deleteAll_btn.TabIndex = 15;
            deleteAll_btn.Text = "Xóa tất cả";
            deleteAll_btn.UseVisualStyleBackColor = true;
            deleteAll_btn.Click += deleteAll_btn_Click;
            // 
            // maSp_txt
            // 
            maSp_txt.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maSp_txt.Location = new Point(6, 53);
            maSp_txt.Name = "maSp_txt";
            maSp_txt.Size = new Size(210, 26);
            maSp_txt.TabIndex = 4;
            // 
            // delete_btn
            // 
            delete_btn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            delete_btn.Location = new Point(84, 425);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(57, 28);
            delete_btn.TabIndex = 12;
            delete_btn.Text = "Xóa";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(102, 18);
            label1.TabIndex = 0;
            label1.Text = "Mã sản phẩm";
            // 
            // insert_btn
            // 
            insert_btn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            insert_btn.Location = new Point(6, 425);
            insert_btn.Name = "insert_btn";
            insert_btn.Size = new Size(57, 28);
            insert_btn.TabIndex = 11;
            insert_btn.Text = "Thêm";
            insert_btn.UseVisualStyleBackColor = true;
            insert_btn.Click += insert_btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 153);
            label2.Name = "label2";
            label2.Size = new Size(111, 18);
            label2.TabIndex = 1;
            label2.Text = "Loại sản phẩm";
            // 
            // loaiSp_box
            // 
            loaiSp_box.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loaiSp_box.FormattingEnabled = true;
            loaiSp_box.Location = new Point(6, 174);
            loaiSp_box.Name = "loaiSp_box";
            loaiSp_box.Size = new Size(210, 26);
            loaiSp_box.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 91);
            label3.Name = "label3";
            label3.Size = new Size(106, 18);
            label3.TabIndex = 2;
            label3.Text = "Tên sản phẩm";
            // 
            // trangThaiSP_box
            // 
            trangThaiSP_box.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            trangThaiSP_box.FormattingEnabled = true;
            trangThaiSP_box.Items.AddRange(new object[] { "Còn hàng", "Hết hàng", "Đang bảo trì" });
            trangThaiSP_box.Location = new Point(6, 384);
            trangThaiSP_box.Name = "trangThaiSP_box";
            trangThaiSP_box.Size = new Size(210, 26);
            trangThaiSP_box.TabIndex = 18;
            // 
            // soLuongSp_txt
            // 
            soLuongSp_txt.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            soLuongSp_txt.Location = new Point(6, 311);
            soLuongSp_txt.Name = "soLuongSp_txt";
            soLuongSp_txt.Size = new Size(210, 26);
            soLuongSp_txt.TabIndex = 10;
            // 
            // trangThai
            // 
            trangThai.AutoSize = true;
            trangThai.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            trangThai.Location = new Point(6, 354);
            trangThai.Name = "trangThai";
            trangThai.Size = new Size(76, 18);
            trangThai.TabIndex = 17;
            trangThai.Text = "Trạng thái";
            // 
            // tenSp_txt
            // 
            tenSp_txt.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tenSp_txt.Location = new Point(6, 112);
            tenSp_txt.Name = "tenSp_txt";
            tenSp_txt.Size = new Size(210, 26);
            tenSp_txt.TabIndex = 6;
            // 
            // giaTienSp_txt
            // 
            giaTienSp_txt.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            giaTienSp_txt.Location = new Point(6, 238);
            giaTienSp_txt.Name = "giaTienSp_txt";
            giaTienSp_txt.Size = new Size(210, 26);
            giaTienSp_txt.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 217);
            label4.Name = "label4";
            label4.Size = new Size(62, 18);
            label4.TabIndex = 3;
            label4.Text = "Giá tiền";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 284);
            label5.Name = "label5";
            label5.Size = new Size(74, 18);
            label5.TabIndex = 7;
            label5.Text = "Số lượng";
            label5.Click += label5_Click;
            // 
            // showSP
            // 
            showSP.Controls.Add(sanPhamTable);
            showSP.Dock = DockStyle.Fill;
            showSP.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showSP.Location = new Point(0, 0);
            showSP.Name = "showSP";
            showSP.Size = new Size(554, 632);
            showSP.TabIndex = 1;
            showSP.TabStop = false;
            showSP.Text = "Danh sách sản phẩm";
            // 
            // sanPhamTable
            // 
            sanPhamTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            sanPhamTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            sanPhamTable.DefaultCellStyle = dataGridViewCellStyle1;
            sanPhamTable.Dock = DockStyle.Fill;
            sanPhamTable.Location = new Point(3, 28);
            sanPhamTable.Name = "sanPhamTable";
            sanPhamTable.ReadOnly = true;
            sanPhamTable.Size = new Size(548, 601);
            sanPhamTable.TabIndex = 0;
            sanPhamTable.CellClick += sanPhamTable_CellClick;
            // 
            // SanPhamStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(showSP);
            Controls.Add(sanPham_group);
            Name = "SanPhamStaff";
            Size = new Size(776, 632);
            Load += SanPhamStaff_Load;
            sanPham_group.ResumeLayout(false);
            sanPham_group.PerformLayout();
            showSP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sanPhamTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox sanPham_group;
        private TextBox soLuongSp_txt;
        private TextBox giaTienSp_txt;
        private Label label5;
        private TextBox tenSp_txt;
        private TextBox maSp_txt;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button deleteAll_btn;
        private Button update_btn;
        private Button delete_btn;
        private Button insert_btn;
        private ComboBox loaiSp_box;
        private GroupBox showSP;
        private DataGridView sanPhamTable;
        private ComboBox trangThaiSP_box;
        private Label trangThai;
    }
}
