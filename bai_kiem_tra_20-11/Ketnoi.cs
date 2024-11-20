using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_kiem_tra_20_11
{
	internal class Ketnoi
	{
		private string connectionString = "Data Source=DESKTOP-8UQ3FN3;Initial Catalog=YourDatabaseName;User ID=sa;Password=123456;Connect Timeout=30";


		public SqlConnection getKetNoi()
		{
			return new SqlConnection(connectionString);
		}
		public DataTable LayDuLieuBang(string query)
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						SqlDataAdapter da = new SqlDataAdapter(cmd);
						DataTable dt = new DataTable();
						da.Fill(dt);
						return dt;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message);
				return null;
			}
		}
		public bool TestConnection()
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					MessageBox.Show("Kết nối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}
	} 
}
