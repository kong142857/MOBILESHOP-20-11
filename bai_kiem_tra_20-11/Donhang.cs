using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai_kiem_tra_20_11
{
	public partial class Donhang : Form
	{
		public Donhang()
		{
			InitializeComponent();
		}
		private void LoadDonHang()
		{
			Ketnoi kn = new Ketnoi();
			string query = "SELECT * FROM Donhang";
			DataTable dt = kn.LayDuLieuBang(query);
			dataGridView1.DataSource = dt;
		}

		private void Donhang_Load(object sender, EventArgs e)
		{
			LoadDonHang();
		}
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				txtMadonhang.Text = dataGridView1.Rows[e.RowIndex].Cells["idDH"].Value.ToString();
				txtMasanpham.Text = dataGridView1.Rows[e.RowIndex].Cells["idSP"].Value.ToString();
				txtMakhachhang.Text = dataGridView1.Rows[e.RowIndex].Cells["idKH"].Value.ToString();
				txtSoluong.Text = dataGridView1.Rows[e.RowIndex].Cells["Soluong"].Value.ToString();
				txtNgaymua.Text = dataGridView1.Rows[e.RowIndex].Cells["ngaymua"].Value.ToString();
			}
		}

		private void btnTimkiem_Click(object sender, EventArgs e)
		{
			Ketnoi kn = new Ketnoi();
			string query = $"SELECT * FROM Donhang WHERE idDH LIKE N'%{txtMadonhang.Text}%'";
			DataTable dt = kn.LayDuLieuBang(query);
			if (dt != null && dt.Rows.Count > 0)
			{
				dataGridView1.DataSource = dt;
			}
			else
			{
				MessageBox.Show("Không tìm thấy đơn hàng!");
			}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			Ketnoi kn = new Ketnoi();
			string query = $"INSERT INTO Donhang(idDH, idSP, idKH, Soluong, ngaymua) " +
						   $"VALUES (N'{txtMadonhang.Text}', N'{txtMasanpham.Text}', N'{txtMakhachhang.Text}', {txtSoluong.Text}, '{txtNgaymua.Text}')";
			if (kn.LayDuLieuBang(query) != null)
			{
				MessageBox.Show("Thêm đơn hàng thành công!");
				LoadDonHang();
			}
			else
			{
				MessageBox.Show("Lỗi khi thêm đơn hàng!");
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			Ketnoi kn = new Ketnoi();
			string query = $"UPDATE Donhang SET idSP = N'{txtMasanpham.Text}', idKH = N'{txtMakhachhang.Text}', " +
						   $"Soluong = {txtSoluong.Text}, ngaymua = '{txtNgaymua.Text}' WHERE idDH = N'{txtMadonhang.Text}'";
			if (kn.LayDuLieuBang(query) != null)
			{
				MessageBox.Show("Cập nhật đơn hàng thành công!");
				LoadDonHang();
			}
			else
			{
				MessageBox.Show("Lỗi khi cập nhật đơn hàng!");
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			Ketnoi kn = new Ketnoi();
			string query = $"DELETE FROM Donhang WHERE idDH = N'{txtMadonhang.Text}'";
			if (kn.LayDuLieuBang(query) != null)
			{
				MessageBox.Show("Xóa đơn hàng thành công!");
				LoadDonHang();
			}
			else
			{
				MessageBox.Show("Lỗi khi xóa đơn hàng!");
			}
		}
		private void Donhang_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
		private void txtMadonhang_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtMakhachhang_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtMasanpham_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtSoluong_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtNgaymua_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
