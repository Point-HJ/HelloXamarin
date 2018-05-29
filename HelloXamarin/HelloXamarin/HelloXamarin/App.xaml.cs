using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace HelloXamarin
{
	public partial class App : Application
	{
        private Label arvauksenTulosLabel;
        private Entry syötekenttä;

        private int oikeaLuku;
        public App ()
		{
			InitializeComponent();

            Random rnd = new Random();
            oikeaLuku = rnd.Next(1, 21);

            Button arvaaNappi = new Button();
            arvaaNappi.Text = "Arvaa";
            arvaaNappi.Clicked += ArvaaNappi_Clicked;

            syötekenttä = new Entry
            {
                Keyboard = Keyboard.Numeric,
                Text = ""
            };

            arvauksenTulosLabel = new Label();
            arvauksenTulosLabel.Text = "";

            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    //VerticalOptions = LayoutOptions.Center,
                    Children =
                    {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Arvaa luku -peli",
                            TextColor = Color.Aquamarine,
                        },
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Sovellusverio 1.10",
                            TextColor = Color.SteelBlue,
                        },
                        syötekenttä,
                        arvaaNappi, 
                        arvauksenTulosLabel

                    }
                }
            };
		}

        private void ArvaaNappi_Clicked(object sender, EventArgs e)
        {
            int arvaus = int.Parse(syötekenttä.Text);
            if (arvaus < oikeaLuku)
            {
                arvauksenTulosLabel.Text = "Luku on suurempi.";
            }
            else if (arvaus > oikeaLuku)
            {
                arvauksenTulosLabel.Text = "Luku on pienempi.";
            }
            else if (arvaus == oikeaLuku)
            {
                arvauksenTulosLabel.Text = "Jee! Täsmälleen oikea luku!";
            }
        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
