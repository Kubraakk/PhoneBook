using System.Data;
using System.Data.SqlClient;

namespace gelismistelefonreh
{

    public partial class Duzenle : Form
    {
        public class RehberKaydi
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string Telefon { get; set; }
            public string Tur { get; set; }
        }
        public RehberKaydi GuncellenenBilgiler { get; private set; } = new RehberKaydi();

        public Duzenle(string column1, string column2, string column3, string column4)
        {
            InitializeComponent();
            textBoxIsım.Text = column1;
            textBoxSoyisim.Text = column2;
            maskedTextBoxTel.Text = column3;
            comboBoxTel.Text = column4;
        }


        private void Duzenle_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(233, 233, 233);
            panelDuzenle.BackColor = Color.FromArgb(233, 233, 233);
            buttonKaydet.BackColor = Color.FromArgb(76, 92, 115);
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {

            // Rehber formunu aç
            Rehber rehberForm = Application.OpenForms.OfType<Rehber>().FirstOrDefault();

            // Formdaki giriş alanlarını kontrol et
            if (!string.IsNullOrWhiteSpace(textBoxIsım.Text) &&
                !string.IsNullOrWhiteSpace(textBoxSoyisim.Text) &&
                maskedTextBoxTel.MaskCompleted && // Telefon numarasının tamamlandığından emin ol
                comboBoxTel.SelectedIndex != -1)
            {
                // Rehber formu var mı kontrol et
                if (rehberForm != null)
                {
                    // Güncellenecek bilgileri al
                    string updatedAd = textBoxIsım.Text;
                    string updatedSoyad = textBoxSoyisim.Text;
                    string cleanedPhoneNumber = new string(maskedTextBoxTel.Text.Where(char.IsDigit).ToArray());

                    if (long.TryParse(cleanedPhoneNumber, out long phoneNumber))
                    {
                        // Güncellenen bilgileri RehberKaydi sınıfına ata
                        GuncellenenBilgiler.Ad = updatedAd;
                        GuncellenenBilgiler.Soyad = updatedSoyad;
                        GuncellenenBilgiler.Telefon = phoneNumber.ToString();
                        GuncellenenBilgiler.Tur = comboBoxTel.Text;

                        // Seçilen öğeyi al
                        ListViewItem selectedItem = rehberForm.listViewRehber.SelectedItems[0];
                        string originalAd = selectedItem.SubItems[0].Text;
                        string originalSoyad = selectedItem.SubItems[1].Text;

                        // Güncellenen bilgileri ListView'da göster
                        selectedItem.SubItems[0].Text = updatedAd;
                        selectedItem.SubItems[1].Text = updatedSoyad;
                        selectedItem.SubItems[2].Text = GuncellenenBilgiler.Telefon;
                        selectedItem.SubItems[3].Text = GuncellenenBilgiler.Tur;

                        // Veritabanında güncelleme işlemini gerçekleştir



                        string updateQuery = "UPDATE TelRehber SET Ad = @Ad, Soyad = @Soyad, Tel = @Telefon, Tur = @Tur WHERE Ad = @OriginalAd AND Soyad = @OriginalSoyad";

                        using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=TelefonRehberi;Integrated Security=True;"))
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand(updateQuery, connection))
                            {
                                command.Parameters.AddWithValue("@Ad", GuncellenenBilgiler.Ad);
                                command.Parameters.AddWithValue("@Soyad", GuncellenenBilgiler.Soyad);
                                command.Parameters.AddWithValue("@Telefon", GuncellenenBilgiler.Telefon);
                                command.Parameters.AddWithValue("@Tur", GuncellenenBilgiler.Tur);
                                command.Parameters.AddWithValue("@OriginalAd", originalAd);
                                command.Parameters.AddWithValue("@OriginalSoyad", originalSoyad);

                                // Veritabanında güncelleme sorgusunu çalıştır
                                command.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Değişiklikler Kaydedildi");
                    }

                    // Giriş alanlarını temizle
                    textBoxSoyisim.Clear();
                    textBoxIsım.Clear();
                    maskedTextBoxTel.Clear();

                    // Formu kapat
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Rehber formu bulunamadı!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!");
            }
        }
    }
}



