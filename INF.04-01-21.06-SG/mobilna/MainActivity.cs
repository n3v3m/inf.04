using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace mobilna
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            EditText EmailEditText = FindViewById<EditText>(Resource.Id.emailEdit);
            EditText PasswordEditText = FindViewById<EditText>(Resource.Id.passwordEdit);
            EditText RepeatPasswordEditText = FindViewById<EditText>(Resource.Id.passwordEdit2);
            Button ButtonConfirm = FindViewById<Button>(Resource.Id.button);
            TextView messageTextView = FindViewById<TextView>(Resource.Id.message);
    
            ButtonConfirm.Click += (sender, e) =>
            {

                if (EmailEditText.Text.Contains("@"))
                {
                    if (PasswordEditText.Text == RepeatPasswordEditText.Text)
                    {
                        messageTextView.Text = "Witaj "+ EmailEditText.Text;
                    }
                    else
                    {
                        messageTextView.Text = "Hasła się różnią"; 
                    }
                }
                else
                {
                    messageTextView.Text = "Nieprawidłowy adres e - mail";
                }
            };
        }

    }
}