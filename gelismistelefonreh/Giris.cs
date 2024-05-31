using System.Data.SqlClient;

namespace gelismistelefonreh
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        int x;
        int max = 5;
        private void txtBxPassword_TextChanged(object sender, EventArgs e)
        {
            int deger = txtBxPassword.TextLength;
            if (deger == 0)
            {
                deger++;
                x = (int)deger * 100 / max;
            }
            else
            {
                x = (int)deger * 100 / max;
            }
            progressBarSifre.Value = x;

        }
        private void buttonGiris_Click(object sender, EventArgs e)
        {
            Rehber rehber_form = new Rehber();
            if (txtBxPassword.Text == "12345")
            {
                rehber_form.ShowDialog();
                labelFail.Text = "";
                txtBxPassword.Clear();
            }
            else
            {
                labelFail.Text = "        Þifre Yanlýþ!\nLütfen Tekrar Deneyiniz";
                txtBxPassword.Clear();
            }
        }

    }
}
