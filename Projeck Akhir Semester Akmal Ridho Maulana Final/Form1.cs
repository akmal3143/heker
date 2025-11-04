namespace Projeck_Akhir_Semester_Akmal_Ridho_Maulana_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs ehgj)
        {
            //Mengambil Data dari Inputan
            string nama = txtNama.Text;
            string makanan = cbBakso.SelectedItem?.ToString();
            string minuman = cbMinuman.SelectedItem?.ToString();
            string jumlahPesanan = txtJumlahPesanan.Text;
            int totalHarga = 0;

            //Validasi Input
            if (txtNama.Text == "")
            {
                MessageBox.Show("Nama Pelanggan harus diisi!");

            }
            else if (cbBakso.SelectedItem == null)
            {
                MessageBox.Show("Makanan harus dipilih!");
            }
            else if (cbMinuman.SelectedItem == null)
            {
                MessageBox.Show("Minuman harus dipilih!");
            }
            else if (txtJumlahPesanan.Text == "")
            {
                MessageBox.Show("Jumlah Pesanan harus diisi!");
            }
            else
            {
                //Hitung Total Harga
                int jumlah = int.Parse(jumlahPesanan);
                switch (makanan)
                {
                    case "Bakso Biasa - Rp 15.000":
                        totalHarga += 15000 * jumlah;
                        break;
                    case "Bakso Spesial - Rp 25.000":
                        totalHarga += 25000 * jumlah;
                        break;
                    case "Bakso Urat - Rp 20.000":
                        totalHarga += 20000 * jumlah;
                        break;
                }
                switch (minuman)
                {
                    case "Es Teh - Rp 5.000":
                        totalHarga += 5000 * jumlah;
                        break;
                    case "Es Jeruk - Rp 7.000":
                        totalHarga += 7000 * jumlah;
                        break;
                    case "Air Mineral - Rp 3.000":
                        totalHarga += 3000 * jumlah;
                        break;
                }


                //Menambahkan Baris ke DataGridView
                string[] row = { nama, makanan, minuman, jumlahPesanan, "Rp " + totalHarga.ToString() };
                dgvResi.Rows.Add(row);

                txtNama.Clear();
                cbBakso.SelectedItem = null;
                cbMinuman.SelectedItem = null;
                txtJumlahPesanan.Clear();

                //Menampilkan Total Harga di TextBoxnmb
                txtTotal.Text = totalHarga.ToString("N0");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Tambahkan Kolom ke datagritview
            dgvResi.ColumnCount = 5;
            dgvResi.Columns[0].Name = "Nama Pelanggan";
            dgvResi.Columns[1].Name = "Makanan";
            dgvResi.Columns[2].Name = "Minuman";
            dgvResi.Columns[3].Name = "Jumlah Pesanan";
            dgvResi.Columns[4].Name = "Total Harga";

            //Menambahkan Item ke ComboBox Bakso
            cbBakso.Items.Add("Bakso Biasa - Rp 15.000");
            cbBakso.Items.Add("Bakso Spesial - Rp 25.000");
            cbBakso.Items.Add("Bakso Urat - Rp 20.000");

            //Menambahkan Item ke ComboBox Minum
            cbMinuman.Items.Add("Es Teh - Rp 5.000");
            cbMinuman.Items.Add("Es Jeruk - Rp 7.000");
            cbMinuman.Items.Add("Air Mineral - Rp 3.000");


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void IbIMinuman_Click(object sender, EventArgs e)
        {

        }

        private void bntBatalkan_Click(object sender, EventArgs e)
        {
            //Menghapus Baris yang dipilih di DataGridView
            if (dgvResi.SelectedRows.Count > 0)
            {
                dgvResi.Rows.RemoveAt(dgvResi.SelectedRows[0].Index);
                txtTotal.Text = " ";
                txtKembalian.Text = " ";
                txtBayar.Text = " ";

            }
            else
            {
                MessageBox.Show("Pilih baris yang ingin dihapus!");
            }


        }

        private void BntKeluar_Click(object sender, EventArgs e)
        {
                //Konfirmasi Keluar Aplikasi
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void bntPilih_Click(object sender, EventArgs e)
        {
            //Menghitung Kembalian
            if (!string.IsNullOrEmpty(txtBayar.Text))
            {
                if (Convert.ToDouble(txtBayar.Text) < Convert.ToDouble(txtTotal.Text))
                {
                    MessageBox.Show("Uang nya kurang Bro,Nggak Boleh Utang Ya brooo");
                    return;
                }

                double kembalian = Convert.ToDouble(txtBayar.Text) - Convert.ToDouble(txtTotal.Text);
                txtKembalian.Text = $"{kembalian.ToString("N0")}";
            }
            else MessageBox.Show("Total bayar tidak terdefinisikan!");
            return;

        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {
            // reset total, kembalian, bayar ketika nama diubah
            txtTotal.Text = " ";
            txtKembalian.Text = " ";
            txtBayar.Text = " ";
        }

        private void cbBakso_SelectedIndexChanged(object sender, EventArgs e)
        {
            // reset total, kembalian, bayar ketika makanan diubah
            txtTotal.Text = " ";
            txtKembalian.Text = " ";
            txtBayar.Text = " ";
        }

        private void cbMinuman_SelectedIndexChanged(object sender, EventArgs e)
        {
            // reset total, kembalian, bayar ketika minuman diubah
            txtTotal.Text = " ";
            txtKembalian.Text = " ";
            txtBayar.Text = " ";
        }

        private void txtJumlahPesanan_TextChanged(object sender, EventArgs e)
        {
            // reset total, kembalian, bayar ketika jumlah pesanan diubah
            txtTotal.Text = " ";
            txtKembalian.Text = " ";
            txtBayar.Text = " ";
            // jumlah pesanan maksimal 
            if (int.TryParse(txtJumlahPesanan.Text, out int jumlah))
            {
                if (jumlah > 100)
                {
                    MessageBox.Show("Jumlah pesanan maksimal adalah 100.");
                    txtJumlahPesanan.Text = "100";
                }
            }
        }
    }
}
