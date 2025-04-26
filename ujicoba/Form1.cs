using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ujicoba
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

        private void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;password=;database=kasir;";
            using var conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                MessageBox.Show("Koneksi ke database berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Tambahkan logika lain di sini jika perlu
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal terkoneksi ke database:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Button10_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
