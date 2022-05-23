using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Co2BesparelseWindows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Beregn_Click(object sender, RoutedEventArgs e)
        {
            // Disse variabler indeholder de adresser brugeren taster ind, 
            // og angiver den valgte transportform
            string startadresse = Hjem.Text;
            string slutadresse = Arbejde.Text;
            bool benzinBil = Benzin.IsChecked ?? false;
            bool dieselBil = Diesel.IsChecked ?? false;
            bool tog = Tog.IsChecked ?? false;

            // Skriv din kode her. Start med at indsætte nøgleværdierne
            // fra opgaven
            string koordinatNogle = ""; //Nøgleværdien findes på smartlearning
            string afstandNogle = ""; //Nøgleværdien findes på smartlearning

            Afstandsberegner minAfstand = new(afstandNogle);
            Koordinatberegner mitStartkoordinat = new(koordinatNogle);
            Koordinatberegner mitSlutkoordinat = new(koordinatNogle);

            var startKoordinat = await mitStartkoordinat.HentKoordinaterForAdresse(startadresse);
            var slutKoordinat = await mitSlutkoordinat.HentKoordinaterForAdresse(slutadresse);
            double rejseAfstandIMeter = await minAfstand.BeregnAfstandIMeter(startKoordinat, slutKoordinat);
            double rejseAfstandIKilometer = rejseAfstandIMeter / 1000;
            double Co2BesparelseIKilogram;

            if (benzinBil is true)
            {
                Co2BesparelseIKilogram = 2 * 174 * rejseAfstandIKilometer / 1000;
            }
            else if (dieselBil is true)
            {
                Co2BesparelseIKilogram = 2 * 168 * rejseAfstandIKilometer / 1000;
            }
            else
            {
                Co2BesparelseIKilogram = 2 * 36 * rejseAfstandIKilometer / 1000;
            }

            MessageBox.Show($"Du kan spare {Co2BesparelseIKilogram:f2} kg CO2 ved ikke at foretage den rejse (tur/retur)", "Besparelse");
        }
    }
}
