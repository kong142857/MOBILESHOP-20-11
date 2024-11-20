using System.Data;

namespace bai_kiem_tra_20_11
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
		private bool KiemTraDangNhap(string tenDangNhap, string matKhau)
		{
			Ketnoi kn = new Ketnoi();
			string query = $"SELECT * FROM Nguoidung WHERE tendangnhap = N'{tenDangNhap}' AND matkhau = N'{matKhau}'";
			DataTable dt = kn.LayDuLieuBang(query);

			// Nếu có kết quả trả về, thông tin đăng nhập hợp lệ
			return dt != null && dt.Rows.Count > 0;
		}
		private void btnDangnhap_Click(object sender, EventArgs e)
		{
			string tenDangNhap = txtTendangnhap.Text.Trim();
			string matKhau = txtMatkhau.Text.Trim();

			if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
			{
				MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (KiemTraDangNhap(tenDangNhap, matKhau))
			{
				MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

				// Hiển thị form Đơn hàng
				Donhang formDonhang = new Donhang();
				formDonhang.Show();
				this.Hide(); // Ẩn form đăng nhập
			}
			else
			{
				MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtTendangnhap_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtMatkhau_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
