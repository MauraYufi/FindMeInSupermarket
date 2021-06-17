using DocumentFormat.OpenXml.Drawing.Diagrams;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindMeInSupermarket
{
    public partial class Form1 : Form
    {
        public enum Mode { Insert, Delete}
        Mode mode;
        public Form1()
        {
            InitializeComponent();
            mode = Mode.Insert;
        }

        public Form1(string keyw)
        {
            InitializeComponent();
            btnUpdate.Text = keyw;
            mode = Mode.Delete;
            label1.Text = "Cari Barang Yang akan dihapus";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void tbKeywoard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnCari.PerformClick();
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using (DataTable dt = new DataTable("TB_Produk"))
                    {
                        using (SqlCommand cmd = new SqlCommand("select *from TB_Produk where Kategori like @Kategori or Merk like @Merk", cn))
                        {
                            cmd.Parameters.AddWithValue("Kategori", string.Format("%{0}%", tbKeywoard.Text));
                            cmd.Parameters.AddWithValue("Merk", string.Format("%{0}%", tbKeywoard.Text));
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (mode == Mode.Delete)
            {
                string selected_kategori = dataGridView1.CurrentRow.Cells["Kategori"].Value.ToString();
                string selected_merk = dataGridView1.CurrentRow.Cells["Merk"].Value.ToString();
                string selected_ukuran = dataGridView1.CurrentRow.Cells["Ukuran"].Value.ToString();
                string selected_harga = dataGridView1.CurrentRow.Cells["Harga"].Value.ToString();
                string selected_diskon = dataGridView1.CurrentRow.Cells["Diskon"].Value.ToString();
                string selected_lokasi = dataGridView1.CurrentRow.Cells["Lokasi"].Value.ToString();

                string delete_row = "delete from TB_Produk where Kategori = '" + selected_kategori + "' AND Merk = '" + selected_merk + "' AND Ukuran = '" + selected_ukuran + "' AND Harga = '" + selected_harga + "' AND Diskon = '" + selected_diskon + "' AND Lokasi = '" + selected_lokasi + "'";
                int count = execute(delete_row);

                if (count > 0)
                {
                    MessageBox.Show("Berhasil Dihapus");
                }
                else
                    MessageBox.Show("Gagal");
            }
            else
            {
                LoginForm logForm = new LoginForm();
                logForm.ShowDialog();
            }
        }

        public static int execute(string query)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                int count;
                SqlCommand cmd = new SqlCommand(query, cn) ;
                count = cmd.ExecuteNonQuery();
                return count;
            }
        }
    }
}
