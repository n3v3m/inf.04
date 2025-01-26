namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void funkcjaZatwierdz(object sender, EventArgs e)
        {
            if (email.Text.Contains("@"))
            {
                if (haslo.Text == repeatHaslo.Text)
                {
                    komunikat.Text = "Witaj " + email.Text;
                }
                else
                {
                    komunikat.Text = "Hasła się różnią";
                }
            }
            else
            {
                komunikat.Text = "Nieprawidłowy adres e - mail";
            }

        }



    }

}
