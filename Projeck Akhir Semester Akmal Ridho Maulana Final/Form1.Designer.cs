namespace Projeck_Akhir_Semester_Akmal_Ridho_Maulana_Final
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            IbIMinuman = new Label();
            bntPesan = new Button();
            bntBatalkan = new Button();
            txtJumlahPesanan = new TextBox();
            cbMinuman = new ComboBox();
            cbBakso = new ComboBox();
            txtNama = new TextBox();
            IbIPorsi = new Label();
            label5 = new Label();
            IbIBakso = new Label();
            IbINama = new Label();
            IbIJudul2 = new Label();
            IbIjudul = new Label();
            BntKeluar = new Button();
            groupBox2 = new GroupBox();
            dgvResi = new DataGridView();
            txtTotal = new Label();
            label8 = new Label();
            label9 = new Label();
            txtBayar = new TextBox();
            bntPilih = new Button();
            txtKembalian = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResi).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(896, 549);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(249, 203, 144);
            pictureBox2.Location = new Point(457, 116);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(436, 182);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(IbIMinuman);
            groupBox1.Controls.Add(bntPesan);
            groupBox1.Controls.Add(bntBatalkan);
            groupBox1.Controls.Add(txtJumlahPesanan);
            groupBox1.Controls.Add(cbMinuman);
            groupBox1.Controls.Add(cbBakso);
            groupBox1.Controls.Add(txtNama);
            groupBox1.Controls.Add(IbIPorsi);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(IbIBakso);
            groupBox1.Controls.Add(IbINama);
            groupBox1.Controls.Add(IbIJudul2);
            groupBox1.Location = new Point(28, 104);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(402, 346);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // IbIMinuman
            // 
            IbIMinuman.AutoSize = true;
            IbIMinuman.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IbIMinuman.Location = new Point(16, 173);
            IbIMinuman.Name = "IbIMinuman";
            IbIMinuman.Size = new Size(93, 25);
            IbIMinuman.TabIndex = 16;
            IbIMinuman.Text = "Minuman";
            IbIMinuman.Click += IbIMinuman_Click;
            // 
            // bntPesan
            // 
            bntPesan.BackColor = Color.FromArgb(146, 187, 112);
            bntPesan.BackgroundImageLayout = ImageLayout.Zoom;
            bntPesan.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntPesan.ForeColor = SystemColors.ButtonHighlight;
            bntPesan.Location = new Point(115, 272);
            bntPesan.Name = "bntPesan";
            bntPesan.Size = new Size(111, 38);
            bntPesan.TabIndex = 15;
            bntPesan.Text = "Pesan";
            bntPesan.UseVisualStyleBackColor = false;
            bntPesan.Click += button5_Click;
            // 
            // bntBatalkan
            // 
            bntBatalkan.BackColor = Color.FromArgb(249, 208, 94);
            bntBatalkan.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntBatalkan.ForeColor = Color.Black;
            bntBatalkan.Location = new Point(260, 272);
            bntBatalkan.Name = "bntBatalkan";
            bntBatalkan.Size = new Size(116, 38);
            bntBatalkan.TabIndex = 14;
            bntBatalkan.Text = "Batalkan";
            bntBatalkan.UseVisualStyleBackColor = false;
            bntBatalkan.Click += bntBatalkan_Click;
            // 
            // txtJumlahPesanan
            // 
            txtJumlahPesanan.Location = new Point(125, 212);
            txtJumlahPesanan.Name = "txtJumlahPesanan";
            txtJumlahPesanan.Size = new Size(261, 27);
            txtJumlahPesanan.TabIndex = 13;
            txtJumlahPesanan.TextChanged += txtJumlahPesanan_TextChanged;
            // 
            // cbMinuman
            // 
            cbMinuman.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMinuman.FormattingEnabled = true;
            cbMinuman.Location = new Point(125, 170);
            cbMinuman.Name = "cbMinuman";
            cbMinuman.Size = new Size(261, 28);
            cbMinuman.TabIndex = 12;
            cbMinuman.SelectedIndexChanged += cbMinuman_SelectedIndexChanged;
            // 
            // cbBakso
            // 
            cbBakso.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBakso.FormattingEnabled = true;
            cbBakso.Location = new Point(125, 125);
            cbBakso.Name = "cbBakso";
            cbBakso.Size = new Size(261, 28);
            cbBakso.TabIndex = 11;
            cbBakso.SelectedIndexChanged += cbBakso_SelectedIndexChanged;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(125, 78);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(261, 27);
            txtNama.TabIndex = 5;
            txtNama.TextChanged += txtNama_TextChanged;
            // 
            // IbIPorsi
            // 
            IbIPorsi.AutoSize = true;
            IbIPorsi.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IbIPorsi.Location = new Point(16, 214);
            IbIPorsi.Name = "IbIPorsi";
            IbIPorsi.Size = new Size(53, 25);
            IbIPorsi.TabIndex = 4;
            IbIPorsi.Text = "Porsi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 178);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 3;
            // 
            // IbIBakso
            // 
            IbIBakso.AutoSize = true;
            IbIBakso.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IbIBakso.Location = new Point(16, 128);
            IbIBakso.Name = "IbIBakso";
            IbIBakso.Size = new Size(63, 25);
            IbIBakso.TabIndex = 2;
            IbIBakso.Text = "Bakso";
            // 
            // IbINama
            // 
            IbINama.AutoSize = true;
            IbINama.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IbINama.Location = new Point(16, 80);
            IbINama.Name = "IbINama";
            IbINama.Size = new Size(62, 25);
            IbINama.TabIndex = 1;
            IbINama.Text = "Nama";
            // 
            // IbIJudul2
            // 
            IbIJudul2.AutoSize = true;
            IbIJudul2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IbIJudul2.Location = new Point(115, 23);
            IbIJudul2.Name = "IbIJudul2";
            IbIJudul2.Size = new Size(169, 31);
            IbIJudul2.TabIndex = 0;
            IbIJudul2.Text = "Menu Pesanan";
            // 
            // IbIjudul
            // 
            IbIjudul.AutoSize = true;
            IbIjudul.BackColor = SystemColors.ButtonHighlight;
            IbIjudul.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IbIjudul.ForeColor = Color.FromArgb(1, 72, 142);
            IbIjudul.Location = new Point(213, 22);
            IbIjudul.Name = "IbIjudul";
            IbIjudul.Size = new Size(491, 54);
            IbIjudul.TabIndex = 5;
            IbIjudul.Text = "Warung Bakso Kang soni";
            // 
            // BntKeluar
            // 
            BntKeluar.BackColor = Color.FromArgb(215, 100, 66);
            BntKeluar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BntKeluar.ForeColor = Color.White;
            BntKeluar.Location = new Point(137, 490);
            BntKeluar.Name = "BntKeluar";
            BntKeluar.Size = new Size(152, 43);
            BntKeluar.TabIndex = 7;
            BntKeluar.Text = "Keluar";
            BntKeluar.UseVisualStyleBackColor = false;
            BntKeluar.Click += BntKeluar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvResi);
            groupBox2.Location = new Point(461, 316);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(432, 182);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // dgvResi
            // 
            dgvResi.BackgroundColor = Color.White;
            dgvResi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResi.Location = new Point(0, 0);
            dgvResi.Name = "dgvResi";
            dgvResi.RowHeadersWidth = 51;
            dgvResi.Size = new Size(432, 182);
            dgvResi.TabIndex = 0;
            // 
            // txtTotal
            // 
            txtTotal.AutoSize = true;
            txtTotal.BackColor = Color.FromArgb(248, 202, 142);
            txtTotal.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(543, 127);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(0, 46);
            txtTotal.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(249, 203, 144);
            label8.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(470, 127);
            label8.Name = "label8";
            label8.Size = new Size(81, 46);
            label8.TabIndex = 12;
            label8.Text = "Rp :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(248, 202, 142);
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(470, 183);
            label9.Name = "label9";
            label9.Size = new Size(112, 25);
            label9.TabIndex = 13;
            label9.Text = "Kembalian :";
            label9.Click += label9_Click;
            // 
            // txtBayar
            // 
            txtBayar.Location = new Point(565, 220);
            txtBayar.Name = "txtBayar";
            txtBayar.Size = new Size(307, 27);
            txtBayar.TabIndex = 14;
            // 
            // bntPilih
            // 
            bntPilih.BackColor = Color.FromArgb(199, 218, 162);
            bntPilih.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntPilih.Location = new Point(626, 253);
            bntPilih.Name = "bntPilih";
            bntPilih.Size = new Size(109, 35);
            bntPilih.TabIndex = 15;
            bntPilih.Text = "Bayar";
            bntPilih.UseVisualStyleBackColor = false;
            bntPilih.Click += bntPilih_Click;
            // 
            // txtKembalian
            // 
            txtKembalian.AutoSize = true;
            txtKembalian.BackColor = Color.FromArgb(248, 202, 142);
            txtKembalian.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtKembalian.Location = new Point(588, 182);
            txtKembalian.Name = "txtKembalian";
            txtKembalian.Size = new Size(0, 25);
            txtKembalian.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(248, 202, 142);
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(470, 222);
            label11.Name = "label11";
            label11.Size = new Size(61, 25);
            label11.TabIndex = 17;
            label11.Text = "Bayar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(920, 573);
            Controls.Add(label11);
            Controls.Add(txtKembalian);
            Controls.Add(bntPilih);
            Controls.Add(txtBayar);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtTotal);
            Controls.Add(groupBox2);
            Controls.Add(BntKeluar);
            Controls.Add(IbIjudul);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
        private Label IbIjudul;
        private Button BntKeluar;
        private GroupBox groupBox2;
        private DataGridView dgvResi;
        private Button bntPesan;
        private Button bntBatalkan;
        private TextBox txtJumlahPesanan;
        private ComboBox cbMinuman;
        private ComboBox cbBakso;
        private TextBox txtNama;
        private Label IbIPorsi;
        private Label label5;
        private Label IbIBakso;
        private Label IbINama;
        private Label IbIJudul2;
        private Label txtTotal;
        private Label label8;
        private Label label9;
        private TextBox txtBayar;
        private Button bntPilih;
        private Label txtKembalian;
        private Label label11;
        private Label IbIMinuman;
    }
}
