namespace MauiApp6
{
    public partial class MainPage : ContentPage
    {
        long sladWeglowy = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void ObliczSladWeglowy(object sender, EventArgs e)
        {
            try
            {
                string czestotliwoscTransportu = wyborTransportu.SelectedItem.ToString();
                int iloscKm = int.Parse(iloscKilometrow.Text);
                int iloscm2 = int.Parse(m2.Text);
                string samochod = zasilanieSamochodu.SelectedItem.ToString();
                string ogrzewanie = ogrzewanieDomu.SelectedItem.ToString();
                string fotowoltaika = paneleFoto.SelectedItem.ToString();
                string jakaDieta = dieta.SelectedItem.ToString();
                int zuzyciePradu = int.Parse(ZuzycieKwh.Text);
                int smieci = int.Parse(miesieczneOdpady.Text);

                //transport
                switch (czestotliwoscTransportu)
                {
                    case "Bardzo często":
                        sladWeglowy += 15000;
                        break;
                    case "Czasami":
                        sladWeglowy += 9000;
                        break;
                    case "Bardzo rzadko":
                        sladWeglowy += 3000;
                        break;
                    case "Wcale":

                        break;
                }
                //samochod
                switch (samochod)
                {
                    case "Benzyna":
                        sladWeglowy += (iloscKm * 180);
                        break;
                    case "Gaz":
                        sladWeglowy += (iloscKm * 150);
                        break;
                    case "Samochód elektryczny":
                        sladWeglowy += (iloscKm * 50);
                        break;
                    case "nie mam samochodu":

                        break;

                }


                //ogrzewanie
                switch (ogrzewanie)
                {
                    case "Węgiel":
                        sladWeglowy += iloscm2 * 8750;

                        break;
                    case "Drewno":
                        sladWeglowy += iloscm2 * 1250;

                        break;
                    case "Prąd":
                        if (fotowoltaika == "tak")
                        {

                        }
                        else
                        {
                            sladWeglowy += iloscm2 * 12500;
                        }

                        break;
                    case "Gaz":
                        sladWeglowy += iloscm2 * 7500;

                        break;
                }
                //dieta
                switch (jakaDieta)
                {
                    case "Wegańska":
                        sladWeglowy += 40000;
                        break;
                    case "Wegetariańska":
                        sladWeglowy += 70000;
                        break;
                    case "Mieszana (mięso i rośliny)":
                        sladWeglowy += 150000;
                        break;
                    case "Głównie mięso":
                        sladWeglowy += 250000;
                        break;
                }

                //zuzycie pradu
                if (fotowoltaika != "tak")
                {
                    sladWeglowy += zuzyciePradu * 650;
                }
                //odpady
                sladWeglowy += smieci * 1250;

                sladWeglowy = sladWeglowy / 1000;
            }
            catch
            {
                wynik.Text = $"Wystąpił błąd";
            }
            wynik.Text = $"Twój miesieczny ślad węglowy wynosi {sladWeglowy} kg";

        }


    }

}
