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
using System.Windows.Shapes;
using Vakantieverhuur.LIB.Entities;
using Vakantieverhuur.LIB.Services;

namespace Vakantieverhuur.WPF
{
    /// <summary>
    /// Interaction logic for winVerhuur.xaml
    /// </summary>
    public partial class winVerhuur : Window
    {
        public winVerhuur()
        {
            InitializeComponent();
        }

        public string situatie = "";
        public Verblijf verblijf;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            vulWoningGegevens();
        }

        private void vulWoningGegevens()
        {
            if (verblijf is Vakantiehuis)
            {
                chkPersoonlijkSanitair.Visibility = Visibility.Hidden;
                chkVaatwas.Visibility = Visibility.Visible;
                chkWasmachine.Visibility = Visibility.Visible;
                chkHoutkachel.Visibility = Visibility.Visible;

                chkVaatwas.IsChecked = ((Vakantiehuis)verblijf).Vaatwas;
                chkWasmachine.IsChecked = ((Vakantiehuis)verblijf).Wasmachine;
                chkHoutkachel.IsChecked = ((Vakantiehuis)verblijf).Houtkachel;
                chkPersoonlijkSanitair.IsChecked = false;

            }
            else
            {
                chkPersoonlijkSanitair.Visibility = Visibility.Visible;
                chkVaatwas.Visibility = Visibility.Hidden;
                chkWasmachine.Visibility = Visibility.Hidden;
                chkHoutkachel.Visibility = Visibility.Hidden;

                chkVaatwas.IsChecked = false;
                chkWasmachine.IsChecked = false;
                chkHoutkachel.IsChecked = false;
                chkPersoonlijkSanitair.IsChecked = ((Caravan)verblijf).PersoonlijkSanitair;

            }
            txtHuisNaam.Text = verblijf.HuisNaam;
            txtStraatEnNummer.Text = verblijf.StraatEnNummer;
            txtPostnummer.Text = verblijf.Postnummer.ToString();
            txtGemeente.Text = verblijf.Gemeente;
            txtBasisPrijs.Text = verblijf.BasisPrijs.ToString();
            txtVerminderdePrijs.Text = verblijf.VerminderdePrijs.ToString();
            txtDagenVoorVermindering.Text = verblijf.DagenVoorVermindering.ToString();
            txtWaarborg.Text = verblijf.Waarborg.ToString();
            txtMaxPersonen.Text = verblijf.MaxPersonen.ToString();
            chkMicrogolf.IsChecked = verblijf.Microgolf;
            chkTV.IsChecked = verblijf.TV;
            chkPersoonlijkSanitair.IsChecked = false;

        }
    }
}
