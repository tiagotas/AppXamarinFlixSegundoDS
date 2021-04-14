using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXamarinFlixSegundoDS.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Aventura : ContentPage
    {
        public Aventura()
        {
            InitializeComponent();

            logo.Source = ImageSource.FromResource("AppXamarinFlixSegundoDS.Img.xamarin.png");

            btnCapitaMarvel.Source = ImageSource.FromResource("AppXamarinFlixSegundoDS.Posters.capitamarvel.jpg");
            btnAlladin.Source = ImageSource.FromResource("AppXamarinFlixSegundoDS.Posters.alladin.jpg");
            btnDumbo.Source = ImageSource.FromResource("AppXamarinFlixSegundoDS.Posters.dumbo.jpg");
            btnPanteraNegra.Source = ImageSource.FromResource("AppXamarinFlixSegundoDS.Posters.panteranegra.jpg");
            btnShazan.Source = ImageSource.FromResource("AppXamarinFlixSegundoDS.Posters.shazam.jpg");
            btnVef.Source = ImageSource.FromResource("AppXamarinFlixSegundoDS.Posters.vef.jpg");
        }

        private void btnCapitaMarvel_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Filmes.CapitaMarvel());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops!", ex.Message, "Ok :(");
            }
        }
    }
}