namespace kt2
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
            groupBox1 = new GroupBox();
            tbSoLuong = new TextBox();
            label1 = new Label();
            dataGridViewSanPham = new DataGridView();
            groupBox2 = new GroupBox();
            tbTongGia = new TextBox();
            label2 = new Label();
            btnThanhToan = new Button();
            dataGridViewGioHang = new DataGridView();
            groupBox3 = new GroupBox();
            btnXoa = new Button();
            btnThem = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSanPham).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGioHang).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbSoLuong);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dataGridViewSanPham);
            groupBox1.Location = new Point(9, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(295, 297);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách sản phẩm ";
            // 
            // tbSoLuong
            // 
            tbSoLuong.Location = new Point(91, 234);
            tbSoLuong.Name = "tbSoLuong";
            tbSoLuong.Size = new Size(125, 27);
            tbSoLuong.TabIndex = 2;
            tbSoLuong.TextChanged += tbSoLuong_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 234);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 1;
            label1.Text = "Số lượng:";
            // 
            // dataGridViewSanPham
            // 
            dataGridViewSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSanPham.Location = new Point(6, 26);
            dataGridViewSanPham.Name = "dataGridViewSanPham";
            dataGridViewSanPham.RowHeadersWidth = 51;
            dataGridViewSanPham.Size = new Size(283, 188);
            dataGridViewSanPham.TabIndex = 0;
            dataGridViewSanPham.CellContentClick += dataGridViewSanPham_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbTongGia);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnThanhToan);
            groupBox2.Controls.Add(dataGridViewGioHang);
            groupBox2.Location = new Point(310, 14);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(478, 424);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Giỏ hàng";
            // 
            // tbTongGia
            // 
            tbTongGia.Location = new Point(319, 234);
            tbTongGia.Name = "tbTongGia";
            tbTongGia.Size = new Size(125, 27);
            tbTongGia.TabIndex = 3;
            tbTongGia.TextChanged += tbTongGia_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 237);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 3;
            label2.Text = "Tổng giá:";
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(209, 342);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(94, 29);
            btnThanhToan.TabIndex = 2;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // dataGridViewGioHang
            // 
            dataGridViewGioHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGioHang.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridViewGioHang.Location = new Point(6, 26);
            dataGridViewGioHang.Name = "dataGridViewGioHang";
            dataGridViewGioHang.RowHeadersWidth = 51;
            dataGridViewGioHang.Size = new Size(466, 188);
            dataGridViewGioHang.TabIndex = 1;
            dataGridViewGioHang.CellContentClick += dataGridViewGioHang_CellContentClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(btnThem);
            groupBox3.Location = new Point(9, 317);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(295, 121);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(154, 39);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(22, 39);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // Column1
            // 
            Column1.HeaderText = "TenSanPham";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "SoLuong";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Gia";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSanPham).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGioHang).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dataGridViewSanPham;
        private DataGridView dataGridViewGioHang;
        private Button btnXoa;
        private Button btnThem;
        private TextBox tbSoLuong;
        private Label label1;
        private TextBox tbTongGia;
        private Label label2;
        private Button btnThanhToan;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}
