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

            // Tarih farkýný hesapla
            TimeSpan tarihFarki = baslangicTarihi - secilenTarih;

            // Kullanýcýnýn yaþýný bul
            int kullaniciYasi = (int)(tarihFarki.Days / 365.25); // Günleri yýl bazýnda bölerek yaklaþýk yaþ hesapla



            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Lütfen bir metin girin.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            
            //Form11 geç = new Form11(girilenMetin);
            //geç.Show();
            // Tarih aralýðýna göre farklý sayfalarý aç
            if (secilenTarih >= new DateTime(secilenTarih.Year, 3, 21) && secilenTarih <= new DateTime(secilenTarih.Year, 4, 19))
            {
                string girilenMetin = textBox1.Text;
                // 16 Ocak - 12 Þubat aralýðý için bir sayfa aç
                Form13 sayfaOcakSubat = new Form13(girilenMetin); // Form1, açmak istediðiniz sayfanýn adýdýr
                sayfaOcakSubat.Show();
            }
            // Diðer tarih aralýklarý için gerekli kontrolleri ekleyebilirsiniz
            else if (secilenTarih >= new DateTime(secilenTarih.Year, 4, 20) && secilenTarih <= new DateTime(secilenTarih.Year, 5, 20))
            {
                // Diðer sayfayý aç
                string girilenMetin = textBox1.Text;
                Form2 digerSayfa = new Form2(girilenMetin); // Form2, baþka bir sayfanýn adýdýr
                digerSayfa.Show();
            }
            else if (secilenTarih >= new DateTime(secilenTarih.Year, 5, 21) && secilenTarih <= new DateTime(secilenTarih.Year, 6, 20))
            {
                // Diðer sayfayý aç
                string girilenMetin = textBox1.Text;
                Form3 digerSayfa = new Form3(girilenMetin); // Form2, baþka bir sayfanýn adýdýr
                digerSayfa.Show();
            }
            else if (secilenTarih >= new DateTime(secilenTarih.Year, 6, 21) && secilenTarih <= new DateTime(secilenTarih.Year, 7, 22))
            {
                // Diðer sayfayý aç
                string girilenMetin = textBox1.Text;
                Form4 digerSayfa = new Form4(girilenMetin); // Form2, baþka bir sayfanýn adýdýr
                digerSayfa.Show();
            }
            else if (secilenTarih >= new DateTime(secilenTarih.Year, 7, 23) && secilenTarih <= new DateTime(secilenTarih.Year, 8, 22))
            {
                // Diðer sayfayý aç
                string girilenMetin = textBox1.Text;
                Form5 digerSayfa = new Form5(girilenMetin); // Form2, baþka bir sayfanýn adýdýr
                digerSayfa.Show();
            }
            else if (secilenTarih >= new DateTime(secilenTarih.Year, 8, 23) && secilenTarih <= new DateTime(secilenTarih.Year, 9, 22))
            {
                // Diðer sayfayý aç
                string girilenMetin = textBox1.Text;
                Form6 digerSayfa = new Form6(girilenMetin); // Form2, baþka bir sayfanýn adýdýr
                digerSayfa.Show();
            }
            else if (secilenTarih >= new DateTime(secilenTarih.Year, 9, 23) && secilenTarih <= new DateTime(secilenTarih.Year, 10, 22))
            {
                // Diðer sayfayý aç
                string girilenMetin = textBox1.Text;
                Form7 digerSayfa = new Form7(girilenMetin); // Form2, baþka bir sayfanýn adýdýr
                digerSayfa.Show();
            }
            else if (secilenTarih >= new DateTime(secilenTarih.Year, 10, 23) && secilenTarih <= new DateTime(secilenTarih.Year, 11, 21))
            {
                // Diðer sayfayý aç
                string girilenMetin = textBox1.Text;
                Form8 digerSayfa = new Form8(girilenMetin); // Form2, baþka bir sayfanýn adýdýr
                digerSayfa.Show();
            }
            else if (secilenTarih >= new DateTime(secilenTarih.Year, 11, 22) && secilenTarih <= new DateTime(secilenTarih.Year, 12, 21))
            {
                // Diðer sayfayý aç
                string girilenMetin = textBox1.Text;
                Form9 digerSayfa = new Form9(girilenMetin); // Form2, baþka bir sayfanýn adýdýr
                digerSayfa.Show();
            }
            else if (secilenTarih >= new DateTime(secilenTarih.Year, 12, 22) && secilenTarih <= new DateTime(secilenTarih.Year, 1, 19))
            {
                // Diðer sayfayý aç
                string girilenMetin = textBox1.Text;
                Form10 digerSayfa = new Form10(girilenMetin); // Form2, baþka bir sayfanýn adýdýr
                digerSayfa.Show();
            }
            else if (secilenTarih >= new DateTime(secilenTarih.Year, 1, 20) && secilenTarih <= new DateTime(secilenTarih.Year, 2, 18))
            {
                string girilenMetin = textBox1.Text;

                // Diðer sayfayý aç
                Form11 digerSayfa = new Form11(girilenMetin); // Form2, baþka bir sayfanýn adýdýr
                digerSayfa.Show();
            }
            else if (secilenTarih >= new DateTime(secilenTarih.Year, 2, 19) && secilenTarih <= new DateTime(secilenTarih.Year, 3, 20))
            {
                // Diðer sayfayý aç
                string girilenMetin = textBox1.Text;
                Form12 digerSayfa = new Form12(girilenMetin); // Form2, baþka bir sayfanýn adýdýr
                digerSayfa.Show();
            }
            // Daha fazla tarih aralýðý kontrolü ekleyebilirsiniz
            else
            {
                string girilenMetin = textBox1.Text;
                // Baþka bir durum için sayfa aç
                Form13 digerSayfa2 = new Form13(girilenMetin); // Form3, baþka bir sayfanýn adýdýr
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