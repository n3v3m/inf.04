using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string haslo = " ";

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void danepracownika_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void combobox_stanowisko_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button_generuj_Click(object sender, EventArgs e)
        {
            int ileznakow;
            if (int.TryParse(input_ileznakow.Text, out ileznakow))
            {

                string maleLitery = "abcdefghijklmnopqrstuvwxyz";
                string wielkieLitery = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                string cyfry = "0123456789";
                string znakiSpecjalne = "!@#$%^&*()_+-=";
                haslo = "";
                Random rnd = new Random();

                if (checkBox_cyfry.Checked)
                {
                    haslo = haslo + cyfry[rnd.Next(cyfry.Length)];
                }

                if (checkBox_znakiSpecjalne.Checked)
                {
                    haslo = haslo + znakiSpecjalne[rnd.Next(znakiSpecjalne.Length)];
                }

                if (haslo.Length > ileznakow) { haslo = haslo.Substring(0, ileznakow); }

                string litery = maleLitery;

                if (checkBox_litery.Checked)
                {
                    litery = litery + wielkieLitery;
                }

                while (haslo.Length < ileznakow)
                {
                    haslo = haslo + litery[rnd.Next(litery.Length)];
                }

                haslo = new string(haslo.OrderBy(c => rnd.Next()).ToArray());
                MessageBox.Show($"{haslo}");
            }
        }

        private void button_zatwierdz_Click_1(object sender, EventArgs e)
        {
            string imie = input_imie.Text;
            string nazwisko = input_nazwisko.Text;
            string stanowisko = "";
            if (combobox_stanowisko.SelectedIndex != -1)
            {
                stanowisko = combobox_stanowisko.SelectedItem.ToString();
            }
            MessageBox.Show($"Dane pracownika: {imie} {nazwisko} {stanowisko} " +
                $"Has�o: {haslo} ");
        }
    }
}