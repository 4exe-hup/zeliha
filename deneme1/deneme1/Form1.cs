namespace deneme1
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

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime secilenTarih = dateTimePicker1.Value;

            DateTime baslangicTarihi = new DateTime(2023, 1, 1);

            // Tarih fark�n� hesapla
            TimeSpan tarihFarki = baslangicTarihi - secilenTarih;

            // Kullan�c�n�n ya��n� bul
            int kullaniciYasi = (int)(tarihFarki.Days / 365.25); // G�nleri y�l baz�nda b�lerek yakla��k ya� hesapla



            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("L�tfen bir metin girin.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            
            //Form11 ge� = new Form11(girilenMetin);
            //ge�.Show();
            // Tarih aral���na g�re farkl� sayfalar� a�
            if (secilenTarih >= new DateTime(secilenTarih.Year, 3, 21) && secilenTarih <= new DateTime(secilenTarih.Year, 4, 19))
            {
                string girilenMetin = textBox1.Text;
                // 16 Ocak - 12 �ubat aral��� i�in bir sayfa a�
                Form13 sayfaOcakSubat = new Form13(girilenMetin); // Form1, a�mak istedi�iniz sayfan�n ad�d�r
                sayfaOcakSubat.Show();
            }
            // Di�er tarih aral�klar� i�in gerekli kontrolleri ekleyebilirsiniz
            else if (secilenTarih >= new DateTime(secilenTarih.Year, 4, 20) && secilenTarih <= new DateTime(secilenTarih.Year, 5, 20))
            {
                // Di�er sayfay� a�
                string girilenMetin = textBox1.Text;
                Form2 digerSayfa = new Form2(girilenMetin); // Form2, ba�ka bir sayfan�n ad�d�r
                digerSayfa.Show();
            }
            else if (secilenTarih >= new DateTime(secilenTarih.Year, 5, 21) && secilenTarih <= new DateTime(secilenTarih.Year, 6, 20))
            {
                // Di�er sayfay� a�
                string girilenMetin = textBox1.Text;
                Form3 digerSayfa = new Form3(girilenMetin); // Form2, ba�ka bir sayfan�n ad�d�r
                digerSayfa.Show();
            }
            else if (secilenTarih >= new DateTime(secilenTarih.Year, 6, 21) && secilenTarih <= new DateTime(secilenTarih.Year, 7, 22))
            {
                // Di�er sayfay� a�
                string girilenMetin = textBox1.Text;
                Form4 digerSayfa = new Form4(girilenMetin); // Form2, ba�ka bir sayfan�n ad�d�r
                digerSayfa.Show();
            }
            else if (secilenTarih >= new DateTime(secilenTarih.Year, 7, 23) && secilenTarih <= new DateTime(secilenTarih.Year, 8, 22))
            {
                // Di�er sayfay� a�
                string girilenMetin = textBox1.Text;
                Form5 digerSayfa = new Form5(girilenMetin); // Form2, ba�ka bir sayfan�n ad�d�r
                digerSayfa.Show();
            }
            else if (secilenTarih >= new DateTime(secilenTarih.Year, 8, 23) && secilenTarih <= new DateTime(secilenTarih.Year, 9, 22))
            {
                // Di�er sayfay� a�
                string girilenMetin = textBox1.Text;
                Form6 digerSayfa = new Form6(girilenMetin); // Form2, ba�ka bir sayfan�n ad�d�r
                digerSayfa.Show();
            }
            else if (secilenTarih >= new DateTime(secilenTarih.Year, 9, 23) && secilenTarih <= new DateTime(secilenTarih.Year, 10, 22))
            {
                // Di�er sayfay� a�
                string girilenMetin = textBox1.Text;
                Form7 digerSayfa = new Form7(girilenMetin); // Form2, ba�ka bir sayfan�n ad�d�r
                digerSayfa.Show();
            }
            else if (secilenTarih >= new DateTime(secilenTarih.Year, 10, 23) && secilenTarih <= new DateTime(secilenTarih.Year, 11, 21))
            {
                // Di�er sayfay� a�
                string girilenMetin = textBox1.Text;
                Form8 digerSayfa = new Form8(girilenMetin); // Form2, ba�ka bir sayfan�n ad�d�r
                digerSayfa.Show();
            }
            else if (secilenTarih >= new DateTime(secilenTarih.Year, 11, 22) && secilenTarih <= new DateTime(secilenTarih.Year, 12, 21))
            {
                // Di�er sayfay� a�
                string girilenMetin = textBox1.Text;
                Form9 digerSayfa = new Form9(girilenMetin); // Form2, ba�ka bir sayfan�n ad�d�r
                digerSayfa.Show();
            }
            else if (secilenTarih >= new DateTime(secilenTarih.Year, 12, 22) && secilenTarih <= new DateTime(secilenTarih.Year, 1, 19))
            {
                // Di�er sayfay� a�
                string girilenMetin = textBox1.Text;
                Form10 digerSayfa = new Form10(girilenMetin); // Form2, ba�ka bir sayfan�n ad�d�r
                digerSayfa.Show();
            }
            else if (secilenTarih >= new DateTime(secilenTarih.Year, 1, 20) && secilenTarih <= new DateTime(secilenTarih.Year, 2, 18))
            {
                string girilenMetin = textBox1.Text;

                // Di�er sayfay� a�
                Form11 digerSayfa = new Form11(girilenMetin); // Form2, ba�ka bir sayfan�n ad�d�r
                digerSayfa.Show();
            }
            else if (secilenTarih >= new DateTime(secilenTarih.Year, 2, 19) && secilenTarih <= new DateTime(secilenTarih.Year, 3, 20))
            {
                // Di�er sayfay� a�
                string girilenMetin = textBox1.Text;
                Form12 digerSayfa = new Form12(girilenMetin); // Form2, ba�ka bir sayfan�n ad�d�r
                digerSayfa.Show();
            }
            // Daha fazla tarih aral��� kontrol� ekleyebilirsiniz
            else
            {
                string girilenMetin = textBox1.Text;
                // Ba�ka bir durum i�in sayfa a�
                Form13 digerSayfa2 = new Form13(girilenMetin); // Form3, ba�ka bir sayfan�n ad�d�r
                digerSayfa2.Show();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}