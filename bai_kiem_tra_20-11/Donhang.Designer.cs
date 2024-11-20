namespace bai_kiem_tra_20_11
{
	partial class Donhang
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			panel1 = new Panel();
			panel2 = new Panel();
			panel3 = new Panel();
			panel4 = new Panel();
			dataGridView1 = new DataGridView();
			btnTimkiem = new Button();
			txtTimkiem = new TextBox();
			btnThem = new Button();
			btnSua = new Button();
			btnXoa = new Button();
			lblDonhang = new Label();
			lblMadonghang = new Label();
			txtMadonhang = new TextBox();
			lblMakhachhang = new Label();
			txtMakhachhang = new TextBox();
			lblMasanpham = new Label();
			txtMasanpham = new TextBox();
			lblSoluong = new Label();
			txtSoluong = new TextBox();
			lblNgaymua = new Label();
			txtNgaymua = new TextBox();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			panel3.SuspendLayout();
			panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(txtNgaymua);
			panel1.Controls.Add(lblNgaymua);
			panel1.Controls.Add(txtSoluong);
			panel1.Controls.Add(lblSoluong);
			panel1.Controls.Add(txtMasanpham);
			panel1.Controls.Add(lblMasanpham);
			panel1.Controls.Add(txtMakhachhang);
			panel1.Controls.Add(lblMakhachhang);
			panel1.Controls.Add(txtMadonhang);
			panel1.Controls.Add(lblMadonghang);
			panel1.Location = new Point(27, 78);
			panel1.Name = "panel1";
			panel1.Size = new Size(300, 292);
			panel1.TabIndex = 0;
			// 
			// panel2
			// 
			panel2.Controls.Add(lblDonhang);
			panel2.Location = new Point(27, 10);
			panel2.Name = "panel2";
			panel2.Size = new Size(748, 62);
			panel2.TabIndex = 1;
			// 
			// panel3
			// 
			panel3.Controls.Add(btnXoa);
			panel3.Controls.Add(btnSua);
			panel3.Controls.Add(btnThem);
			panel3.Location = new Point(27, 376);
			panel3.Name = "panel3";
			panel3.Size = new Size(300, 51);
			panel3.TabIndex = 2;
			// 
			// panel4
			// 
			panel4.Controls.Add(txtTimkiem);
			panel4.Controls.Add(btnTimkiem);
			panel4.Controls.Add(dataGridView1);
			panel4.Location = new Point(333, 78);
			panel4.Name = "panel4";
			panel4.Size = new Size(442, 349);
			panel4.TabIndex = 3;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(15, 65);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(414, 152);
			dataGridView1.TabIndex = 0;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// btnTimkiem
			// 
			btnTimkiem.Location = new Point(354, 26);
			btnTimkiem.Name = "btnTimkiem";
			btnTimkiem.Size = new Size(75, 23);
			btnTimkiem.TabIndex = 1;
			btnTimkiem.Text = "Tìm kiếm";
			btnTimkiem.UseVisualStyleBackColor = true;
			btnTimkiem.Click += btnTimkiem_Click;
			// 
			// txtTimkiem
			// 
			txtTimkiem.Location = new Point(15, 26);
			txtTimkiem.Name = "txtTimkiem";
			txtTimkiem.Size = new Size(333, 23);
			txtTimkiem.TabIndex = 2;
			// 
			// btnThem
			// 
			btnThem.Location = new Point(14, 14);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(75, 23);
			btnThem.TabIndex = 0;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// btnSua
			// 
			btnSua.Location = new Point(113, 14);
			btnSua.Name = "btnSua";
			btnSua.Size = new Size(75, 23);
			btnSua.TabIndex = 1;
			btnSua.Text = "Sửa";
			btnSua.UseVisualStyleBackColor = true;
			btnSua.Click += btnSua_Click;
			// 
			// btnXoa
			// 
			btnXoa.Location = new Point(208, 14);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(75, 23);
			btnXoa.TabIndex = 2;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// lblDonhang
			// 
			lblDonhang.AutoSize = true;
			lblDonhang.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblDonhang.Location = new Point(306, 15);
			lblDonhang.Name = "lblDonhang";
			lblDonhang.Size = new Size(110, 30);
			lblDonhang.TabIndex = 0;
			lblDonhang.Text = "Đơn hàng";
			// 
			// lblMadonghang
			// 
			lblMadonghang.AutoSize = true;
			lblMadonghang.Location = new Point(23, 45);
			lblMadonghang.Name = "lblMadonghang";
			lblMadonghang.Size = new Size(81, 15);
			lblMadonghang.TabIndex = 0;
			lblMadonghang.Text = "Mã đơn hàng:";
			// 
			// txtMadonhang
			// 
			txtMadonhang.Location = new Point(114, 42);
			txtMadonhang.Name = "txtMadonhang";
			txtMadonhang.Size = new Size(169, 23);
			txtMadonhang.TabIndex = 1;
			txtMadonhang.TextChanged += txtMadonhang_TextChanged;
			// 
			// lblMakhachhang
			// 
			lblMakhachhang.AutoSize = true;
			lblMakhachhang.Location = new Point(12, 89);
			lblMakhachhang.Name = "lblMakhachhang";
			lblMakhachhang.Size = new Size(92, 15);
			lblMakhachhang.TabIndex = 2;
			lblMakhachhang.Text = "Mã khách hàng:";
			// 
			// txtMakhachhang
			// 
			txtMakhachhang.Location = new Point(114, 86);
			txtMakhachhang.Name = "txtMakhachhang";
			txtMakhachhang.Size = new Size(169, 23);
			txtMakhachhang.TabIndex = 3;
			txtMakhachhang.TextChanged += txtMakhachhang_TextChanged;
			// 
			// lblMasanpham
			// 
			lblMasanpham.AutoSize = true;
			lblMasanpham.Location = new Point(22, 132);
			lblMasanpham.Name = "lblMasanpham";
			lblMasanpham.Size = new Size(82, 15);
			lblMasanpham.TabIndex = 4;
			lblMasanpham.Text = "Mã sản phẩm:";
			// 
			// txtMasanpham
			// 
			txtMasanpham.Location = new Point(114, 129);
			txtMasanpham.Name = "txtMasanpham";
			txtMasanpham.Size = new Size(169, 23);
			txtMasanpham.TabIndex = 5;
			txtMasanpham.TextChanged += txtMasanpham_TextChanged;
			// 
			// lblSoluong
			// 
			lblSoluong.AutoSize = true;
			lblSoluong.Location = new Point(47, 179);
			lblSoluong.Name = "lblSoluong";
			lblSoluong.Size = new Size(57, 15);
			lblSoluong.TabIndex = 6;
			lblSoluong.Text = "Số lượng:";
			// 
			// txtSoluong
			// 
			txtSoluong.Location = new Point(114, 176);
			txtSoluong.Name = "txtSoluong";
			txtSoluong.Size = new Size(169, 23);
			txtSoluong.TabIndex = 7;
			txtSoluong.TextChanged += txtSoluong_TextChanged;
			// 
			// lblNgaymua
			// 
			lblNgaymua.AutoSize = true;
			lblNgaymua.Location = new Point(39, 229);
			lblNgaymua.Name = "lblNgaymua";
			lblNgaymua.Size = new Size(65, 15);
			lblNgaymua.TabIndex = 8;
			lblNgaymua.Text = "Ngày mua:";
			// 
			// txtNgaymua
			// 
			txtNgaymua.Location = new Point(114, 226);
			txtNgaymua.Name = "txtNgaymua";
			txtNgaymua.Size = new Size(169, 23);
			txtNgaymua.TabIndex = 9;
			txtNgaymua.TextChanged += txtNgaymua_TextChanged;
			// 
			// Donhang
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(809, 444);
			Controls.Add(panel4);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Name = "Donhang";
			Text = "Donhang";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel3.ResumeLayout(false);
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel panel2;
		private Panel panel3;
		private Panel panel4;
		private Button btnTimkiem;
		private DataGridView dataGridView1;
		private Button btnXoa;
		private Button btnSua;
		private Button btnThem;
		private TextBox txtTimkiem;
		private TextBox txtMadonhang;
		private Label lblMadonghang;
		private Label lblDonhang;
		private Label lblNgaymua;
		private TextBox txtSoluong;
		private Label lblSoluong;
		private TextBox txtMasanpham;
		private Label lblMasanpham;
		private TextBox txtMakhachhang;
		private Label lblMakhachhang;
		private TextBox txtNgaymua;
	}
}