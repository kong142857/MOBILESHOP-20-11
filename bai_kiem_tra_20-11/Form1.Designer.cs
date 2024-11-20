namespace bai_kiem_tra_20_11
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
			btnDangnhap = new Button();
			lblTendangnhap = new Label();
			txtTendangnhap = new TextBox();
			lblMatkhau = new Label();
			txtMatkhau = new TextBox();
			SuspendLayout();
			// 
			// btnDangnhap
			// 
			btnDangnhap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnDangnhap.Location = new Point(113, 166);
			btnDangnhap.Name = "btnDangnhap";
			btnDangnhap.Size = new Size(118, 36);
			btnDangnhap.TabIndex = 0;
			btnDangnhap.Text = "Đăng nhập";
			btnDangnhap.UseVisualStyleBackColor = true;
			btnDangnhap.Click += btnDangnhap_Click;
			// 
			// lblTendangnhap
			// 
			lblTendangnhap.AutoSize = true;
			lblTendangnhap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblTendangnhap.Location = new Point(67, 50);
			lblTendangnhap.Name = "lblTendangnhap";
			lblTendangnhap.Size = new Size(114, 21);
			lblTendangnhap.TabIndex = 1;
			lblTendangnhap.Text = "Tên đăng nhập:";
			// 
			// txtTendangnhap
			// 
			txtTendangnhap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtTendangnhap.Location = new Point(197, 47);
			txtTendangnhap.Name = "txtTendangnhap";
			txtTendangnhap.Size = new Size(100, 29);
			txtTendangnhap.TabIndex = 2;
			txtTendangnhap.TextChanged += txtTendangnhap_TextChanged;
			// 
			// lblMatkhau
			// 
			lblMatkhau.AutoSize = true;
			lblMatkhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblMatkhau.Location = new Point(100, 103);
			lblMatkhau.Name = "lblMatkhau";
			lblMatkhau.Size = new Size(78, 21);
			lblMatkhau.TabIndex = 3;
			lblMatkhau.Text = "Mật khẩu:";
			// 
			// txtMatkhau
			// 
			txtMatkhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtMatkhau.Location = new Point(197, 100);
			txtMatkhau.Name = "txtMatkhau";
			txtMatkhau.Size = new Size(100, 29);
			txtMatkhau.TabIndex = 4;
			txtMatkhau.TextChanged += txtMatkhau_TextChanged;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(366, 241);
			Controls.Add(txtMatkhau);
			Controls.Add(lblMatkhau);
			Controls.Add(txtTendangnhap);
			Controls.Add(lblTendangnhap);
			Controls.Add(btnDangnhap);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnDangnhap;
		private Label lblTendangnhap;
		private TextBox txtTendangnhap;
		private Label lblMatkhau;
		private TextBox txtMatkhau;
	}
}
