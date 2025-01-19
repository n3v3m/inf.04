namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int liczbaPolubien = 0;

        public MainPage(){
            InitializeComponent();
        }

        private void dodajPolubienie(object sender, EventArgs e){
            liczbaPolubien++;

            licznik.Text = $"{liczbaPolubien} polubień";

            SemanticScreenReader.Announce(licznik.Text);
        }

        private void usunPolubienie(object sender, EventArgs e){
            if (liczbaPolubien == 0){ 

            }
            else
            {
                liczbaPolubien--;
            }

            licznik.Text = $"{liczbaPolubien} polubień";

            SemanticScreenReader.Announce(licznik.Text);
        }
    }
}
