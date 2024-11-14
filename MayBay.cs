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
    public partial class MayBay : Form
    {
        private string connectionString = "Data Source=.;Initial Catalog=SanBay;Integrated Security=True";

        public MayBay()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM MayBay ORDER BY TenMayBay ASC";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewMayBay.DataSource = dataTable;
            }
        }
        private void MayBay_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemMayBay themForm = new ThemMayBay();
            themForm.FormClosed += (s, args) => LoadData();
            themForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dataGridViewMayBay.SelectedRows.Count > 0)
            {
                int maMB = (int)dataGridViewMayBay.SelectedRows[0].Cells["MaMB"].Value;
                string tenMayBay = dataGridViewMayBay.SelectedRows[0].Cells["TenMayBay"].Value.ToString();
                int namSX = (int)dataGridViewMayBay.SelectedRows[0].Cells["NamSX"].Value;
                int soGioBay = (int)dataGridViewMayBay.SelectedRows[0].Cells["SoGioBay"].Value;

                SuaMayBay suaForm = new SuaMayBay(maMB, tenMayBay, namSX, soGioBay);
                suaForm.FormClosed += (s, args) => LoadData();
                suaForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một máy bay để sửa.");
            }
        }
    }
}
