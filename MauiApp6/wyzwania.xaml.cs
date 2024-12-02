namespace MauiApp6;

public partial class wyzwania : ContentPage
{

    public string[] wyzwaniaTablica =
    [
        "Wykorzystuj r�cznie napinane torebki zamiast plastikowych.",
        "Unikaj zakup�w w du�ych ilo�ciami - kupuj tylko to, czego potrzebujesz.",
        "Wykorzystuj w�asne sztu�ka i naczynia zamiast plastikowych.",
        "Unikaj zakup�w w sklepach z wielkimi ilo�ciami jedzenia na porcje.",
        "Wykorzystuj worek na �mieci zamiast plastikowych work�w.",
        "Wykorzystuj r�czniki z bawe�ny lub lnu zamiast plastikowych.",
        "Unikaj napoj�w w plastikowych butelkach - wybieraj naczynia ceramiczne.",
        "Wykorzystuj szczerbatki z bawe�ny zamiast plastikowych chusteczek.",
        "Unikaj kosmetyk�w w plastikowych tubach - wybieraj produkty bezpo�rednio z puszki.",
        "Wykorzystuj woreczki na �mieci zamiast work�w na �mieci.",
        "Unikaj produkt�w w opakowaniach jednorazowego u�ytku.",
        "Wybieraj produkty w wi�kszych opakowaniach do podzielania si�.",
        "Unikaj napoj�w w plastikowych butelkach - wybieraj naczynia ceramiczne lub szklane.",
        "Wybieraj produkty w naturalnych materia�ach zamiast plastiku.",
        "Unikaj zakup�w w sklepach z wielkimi ilo�ciami jedzenia na porcje.",
        "Wykorzystuj r�cznie napinane torebki zamiast plastikowych.",
        "Unikaj u�ywania plastikowych folii do pakowania dokument�w.",
        "Wykorzystuj d�ugie szczerbatki z bawe�ny zamiast plastikowych chusteczek.",
        "Unikaj napoj�w w plastikowych butelkach - wybieraj naczynia ceramiczne lub szklane.",
        "Wykorzystuj woreczki na �mieci zamiast work�w na �mieci.",
        "Unikaj zakup�w w sklepach z wielkimi ilo�ciami jedzenia na porcje podczas podr�y.",
        "Wykorzystuj r�cznie napinane torebki zamiast plastikowych.",
        "Unikaj napoj�w w plastikowych butelkach - wybieraj naczynia ceramiczne lub szklane.",
        "Wykorzystuj woreczki na �mieci zamiast work�w na �mieci.",
        "Unikaj u�ywania plastikowych folii do pakowania rzeczy w baga�u.",
        "Wykorzystuj materia�y biodegradowalne do produkcji opakowa�.",
        "Unikaj zakup�w produkt�w z nadmiern� ilo�ci� opakowa�.",
        "Wykorzystuj us�ugi podzielania si� rzeczami z s�siadami zamiast zakup�w wielogodzinnych.",
        "Unikaj zakup�w w sklepach z wielkimi ilo�ciami jedzenia na porcje.",
        "Wykorzystuj aplikacje do podzielania si� rzeczami i us�ugami z s�siadami zamiast zakup�w wielogodzinnych.",
    ];

    private const int DaysInArray = 365;
    private int currentIndex = 0;
    private DateTime lastUpdateTime = DateTime.Now.AddDays(-1);

    private async void UpdateRandomText()
    {
        if (DateTime.Now - lastUpdateTime < TimeSpan.FromDays(1))
        {
            await Task.Delay(1000 * 60 * 60 * 24);
            return;
        }

        lastUpdateTime = DateTime.Now;
        currentIndex = (currentIndex + 1) % wyzwaniaTablica.Length;

        wyzwanie.Text = wyzwaniaTablica[currentIndex];

        Device.BeginInvokeOnMainThread(() =>
        {
            UpdateRandomText();
        });
    }

    public wyzwania()
    {
        InitializeComponent();
        UpdateRandomText();
    }
}