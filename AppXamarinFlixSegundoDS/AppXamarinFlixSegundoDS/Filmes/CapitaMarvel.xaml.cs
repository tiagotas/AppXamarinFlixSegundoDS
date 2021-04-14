using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXamarinFlixSegundoDS.Filmes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CapitaMarvel : ContentPage
    {
        public CapitaMarvel()
        {
            InitializeComponent();

            HtmlWebViewSource html_externo = new HtmlWebViewSource();
            html_externo.Html = @"<iframe 
                                        width='400' 
                                        height='300' 
                                        src='https://www.youtube.com/embed/_q3SH0dr17k' 
                                        title='YouTube video player' 
                                        frameborder='0' 
                                        allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' 
                                        allowfullscreen>
                                    </iframe>";

            video.Source = html_externo;

            poster.Source = ImageSource.FromResource("AppXamarinFlixSegundoDS.Posters.capitamarvel.jpg");

            lbl_sinopse.Text = "Em 1995, em Hala, capital do Império Kree localizada em um planeta de uma galáxia"
                             + "envolvendo uma mulher mais velha.Yon - Rogg, seu mentor e comandante, treina-a para" 
                             + "controlar suas habilidades, enquanto a Inteligência Suprema, que comanda artificialmente" 
                             + "os Krees, ordena que ela mantenha suas emoções sob controle.";
        }
    }
}