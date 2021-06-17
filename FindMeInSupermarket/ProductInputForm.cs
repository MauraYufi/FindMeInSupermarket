using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindMeInSupermarket
{
    public partial class ProductInputForm : Form
    {
        Produk produk;
        public ProductInputForm()
        {
            InitializeComponent();
        }

        private void TambahProduk()
        {
            if (tbKategori.Text != "" && tbMerk.Text != "" && tbUkuran.Text != "" && tbHarga.Text != "" && tbDiskon.Text != "" && tbLokasi.Text != "")
            {
                using (var db = new ProdukModel())
                {
                    produk = new Produk
                    {
                        Kategori = tbKategori.Text,
                        Merk = tbMerk.Text,
                        Ukuran = tbUkuran.Text,
                        Harga = tbHarga.Text,
                        Diskon = tbDiskon.Text,
                        Lokasi = tbLokasi.Text,
                    };
                    db.Produks.Add(produk);
                    db.SaveChanges();
                    string pesan = "Produk Ditambahkan!! Tambah produk lagi?";
                    string jud = "Konfirmasi";
                    MessageBoxButtons button = MessageBoxButtons.YesNo;
                    DialogResult res = MessageBox.Show(pesan, jud, button);
                    if (res == DialogResult.No)
                        this.Close();
                    else
                    {
                        this.Hide();
                        ProductInputForm prodForm2 = new ProductInputForm();
                        prodForm2.ShowDialog();
                        this.Close();
                    }
                }
            }
            else
                MessageBox.Show("Detil produk harus diisi");
        }

        private void ProductInputForm_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        { 
            TambahProduk();

        }
    }
}
