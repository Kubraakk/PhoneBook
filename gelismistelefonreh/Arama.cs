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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using WindowsFormsButton = System.Windows.Forms.Button;
using VisualStylesButton = System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using GelismisTelefonRehberi;
using System.Data.Common;

namespace gelismistelefonreh
{
    public partial class Arama : Form
    {
        public Arama()
        {
            InitializeComponent();
        }

        private void Arama_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(233, 233, 233);
            panelArama.BackColor = Color.FromArgb(233, 233, 233);
            panelKaydet.BackColor = Color.FromArgb(233, 233, 233);
            buttonEkle.BackColor = Color.FromArgb(76, 92, 115);
            menuStripArama.BackColor = Color.FromArgb(76, 92, 115);
            maskedTextBoxTel.Clear();
            btn1.Click += numaraButton_Click;
            btn2.Click += numaraButton_Click;
            btn3.Click += numaraButton_Click;
            btn4.Click += numaraButton_Click;
            btn5.Click += numaraButton_Click;
            btn6.Click += numaraButton_Click;
            btn7.Click += numaraButton_Click;
            btn8.Click += numaraButton_Click;
            btn9.Click += numaraButton_Click;
            btn0.Click += numaraButton_Click;

        }

        Favoriler favorilerForm = new Favoriler();
        private void buttonEkle_Click(object sender, EventArgs e)
        {
            Rehber rehberForm = Application.OpenForms.OfType<Rehber>().FirstOrDefault();  //Kisi ekleme fonksiyonu 

            string maskedText = maskedTextBoxTel2.Text;
            string cleanedText = new string(maskedText.Where(char.IsDigit).ToArray());

            string column1 = textBoxİsim.Text;
            string column2 = textBoxSoyisim.Text;
            string column3 = cleanedText;
            string column4 = comboBoxTel2.Text;
            string item2 = textBoxİsim.Text + ' ' + textBoxSoyisim.Text + ' ' + cleanedText + ' ' + comboBoxTel2.SelectedItem.ToString();
            bool itemAlreadyExists = false;

            foreach (ListViewItem item in rehberForm.listViewRehber.Items)
            {
                if (item.SubItems[0].Text == column1 &&
                    item.SubItems[1].Text == column2 &&
                    item.SubItems[2].Text == column3 &&
                    item.SubItems[3].Text == column4)
                {
                    itemAlreadyExists = true;
                    break;
                }
            }

            if (!itemAlreadyExists)
            {
                ListViewItem newItem = new ListViewItem(new[] { column1, column2, column3, column4 }) { ImageIndex = 1 };
                rehberForm.listViewRehber.Items.Add(newItem);
                // Veritabanına ekleme işlemi
                string insertQuery = "INSERT INTO TelRehber (Ad, Soyad, Tel, Tur) VALUES (@Ad, @Soyad, @Telefon, @Tur)";

                using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=TelefonRehberi;Integrated Security=True;"))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Ad", column1);
                        command.Parameters.AddWithValue("@Soyad", column2);
                        command.Parameters.AddWithValue("@Telefon", column3);
                        command.Parameters.AddWithValue("@Tur", column4);

                        // Veritabanına ekleme sorgusunu çalıştır
                        command.ExecuteNonQuery();
                    }
                }

                if (rdbfavoriekle.Checked)
                {

                    string checkQuery = "SELECT COUNT(*) FROM Favori WHERE kisiID = (SELECT tel_id FROM TelRehber WHERE Ad = @Ad AND Soyad = @Soyad AND Tel = @Telefon AND Tur = @Tur)";

                    using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=TelefonRehberi;Integrated Security=True;"))
                    {
                        connection.Open();

                        using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                        {
                            checkCommand.Parameters.AddWithValue("@Ad", column1);
                            checkCommand.Parameters.AddWithValue("@Soyad", column2);
                            checkCommand.Parameters.AddWithValue("@Telefon", column3);
                            checkCommand.Parameters.AddWithValue("@Tur", column4);

                            int existingCount = (int)checkCommand.ExecuteScalar();

                            if (existingCount == 0)
                            {
                                // Kişi favoriye ekli değil, ekleme işlemi gerçekleştir
                                string insertquery = "INSERT INTO Favori (kisiID) VALUES ((SELECT tel_id FROM TelRehber WHERE Ad = @Ad AND Soyad = @Soyad AND Tel = @Telefon AND Tur = @Tur))";

                                using (SqlCommand insertCommand = new SqlCommand(insertquery, connection))
                                {
                                    insertCommand.Parameters.AddWithValue("@Ad", column1);
                                    insertCommand.Parameters.AddWithValue("@Soyad", column2);
                                    insertCommand.Parameters.AddWithValue("@Telefon", column3);
                                    insertCommand.Parameters.AddWithValue("@Tur", column4);

                                    insertCommand.ExecuteNonQuery();

                                    MessageBox.Show("Kişi Favorilere ve Rehbere Eklendi!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Kişi zaten favorilerde kayıtlı!");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Kişi Rehbere Eklendi!");
                }

            }
            else
            {
                MessageBox.Show("Kişi Zaten Rehbere Kayıtlı!");
            }



            textBoxİsim.Clear();
            textBoxSoyisim.Clear();
            maskedTextBoxTel2.Clear();
            maskedTextBoxTel.Clear();
            comboBoxTel2.SelectedIndex = -1;
            rdbfavoriekle.Checked = false;

        }




        private void buttonArama_Click(object sender, EventArgs e)
        {
            string originalText = maskedTextBoxTel.Text;

            maskedTextBoxTel2.Text = originalText;
            
            string cleanedPhoneNumber = new string(maskedTextBoxTel.Text.Where(char.IsDigit).ToArray());

            string Ad = "";
            string Soyad = "";
            string Tur = "";


            string selectQuery = "SELECT ad, soyad, tur FROM TelRehber WHERE Tel = @Tel";


            SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=TelefonRehberi;Integrated Security=True;");
            connection.Open();

  
            using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
            {
                cmd.Parameters.Add("@Tel", SqlDbType.BigInt).Value = long.Parse(cleanedPhoneNumber);


                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Ad = reader["ad"].ToString();
                        Soyad = reader["soyad"].ToString();
                        Tur = reader["tur"].ToString();
                    }
                }
            }


            textBoxİsim.Text = Ad;
            textBoxSoyisim.Text = Soyad;
            maskedTextBoxTel2.Text = cleanedPhoneNumber.ToString();
            comboBoxTel2.Text = Tur;
        }

    
        private void numaraButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button numaraButon = (System.Windows.Forms.Button)sender;

            // Mevcut metni al
            string currentText = maskedTextBoxTel.Text;

            // Mevcut metinden sadece sayıları al
            string onlyNumbers = new string(currentText.Where(char.IsDigit).ToArray());

            // Butonun üzerindeki sayıyı metnin sonuna ekle
            maskedTextBoxTel.Text = $"({onlyNumbers}{numaraButon.Text})";

            // İmleci bir sağa taşı
            maskedTextBoxTel.SelectionStart = maskedTextBoxTel.Text.Length - 1;
            maskedTextBoxTel.SelectionLength = 0;


        }
      
        private void sonArananlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SonArananlar sonArananlar_form = new SonArananlar (
                textBoxİsim.Text, 
                textBoxSoyisim.Text, 
                maskedTextBoxTel2.Text, 
                comboBoxTel2.Text  
                );
            sonArananlar_form.Show();
        }
    }
}

