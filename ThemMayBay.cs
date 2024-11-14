using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSanbay
{
    public partial class ThemMayBay : Form
    {
        private string connectionString = "Data Source=.;Initial Catalog=SanBay;Integrated Security=True";

        public ThemMayBay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTenMayBay.Text) ||
         !int.TryParse(txtNamSX.Text, out int namSX) ||
         !int.TryParse(txtSoGioBay.Text, out int soGioBay))
    {
                MessageBox.Show("Vui lòng điền đầy đủ và đúng định dạng các trường thông tin.\n- 'Năm sản xuất' và 'Số giờ bay' phải là số nguyên.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO MayBay (TenMayBay, NamSX, SoGioBay) VALUES (@TenMayBay, @NamSX, @SoGioBay)", conn))
                    {
                        cmd.Parameters.AddWithValue("@TenMayBay", txtTenMayBay.Text);
                        cmd.Parameters.AddWithValue("@NamSX", namSX);
                        cmd.Parameters.AddWithValue("@SoGioBay", soGioBay);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Đã thêm máy bay thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm máy bay: " + ex.Message);
            };
        }
    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ThemMayBay_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
