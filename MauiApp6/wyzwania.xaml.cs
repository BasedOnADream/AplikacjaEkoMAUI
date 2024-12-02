namespace MauiApp6;

public partial class wyzwania : ContentPage
{

    public string[] wyzwaniaTablica =
    [
        "Wykorzystuj rêcznie napinane torebki zamiast plastikowych.",
        "Unikaj zakupów w du¿ych iloœciami - kupuj tylko to, czego potrzebujesz.",
        "Wykorzystuj w³asne sztuæka i naczynia zamiast plastikowych.",
        "Unikaj zakupów w sklepach z wielkimi iloœciami jedzenia na porcje.",
        "Wykorzystuj worek na œmieci zamiast plastikowych worków.",
        "Wykorzystuj rêczniki z bawe³ny lub lnu zamiast plastikowych.",
        "Unikaj napojów w plastikowych butelkach - wybieraj naczynia ceramiczne.",
        "Wykorzystuj szczerbatki z bawe³ny zamiast plastikowych chusteczek.",
        "Unikaj kosmetyków w plastikowych tubach - wybieraj produkty bezpoœrednio z puszki.",
        "Wykorzystuj woreczki na œmieci zamiast worków na œmieci.",
        "Unikaj produktów w opakowaniach jednorazowego u¿ytku.",
        "Wybieraj produkty w wiêkszych opakowaniach do podzielania siê.",
        "Unikaj napojów w plastikowych butelkach - wybieraj naczynia ceramiczne lub szklane.",
        "Wybieraj produkty w naturalnych materia³ach zamiast plastiku.",
        "Unikaj zakupów w sklepach z wielkimi iloœciami jedzenia na porcje.",
        "Wykorzystuj rêcznie napinane torebki zamiast plastikowych.",
        "Unikaj u¿ywania plastikowych folii do pakowania dokumentów.",
        "Wykorzystuj d³ugie szczerbatki z bawe³ny zamiast plastikowych chusteczek.",
        "Unikaj napojów w plastikowych butelkach - wybieraj naczynia ceramiczne lub szklane.",
        "Wykorzystuj woreczki na œmieci zamiast worków na œmieci.",
        "Unikaj zakupów w sklepach z wielkimi iloœciami jedzenia na porcje podczas podró¿y.",
        "Wykorzystuj rêcznie napinane torebki zamiast plastikowych.",
        "Unikaj napojów w plastikowych butelkach - wybieraj naczynia ceramiczne lub szklane.",
        "Wykorzystuj woreczki na œmieci zamiast worków na œmieci.",
        "Unikaj u¿ywania plastikowych folii do pakowania rzeczy w baga¿u.",
        "Wykorzystuj materia³y biodegradowalne do produkcji opakowañ.",
        "Unikaj zakupów produktów z nadmiern¹ iloœci¹ opakowañ.",
        "Wykorzystuj us³ugi podzielania siê rzeczami z s¹siadami zamiast zakupów wielogodzinnych.",
        "Unikaj zakupów w sklepach z wielkimi iloœciami jedzenia na porcje.",
        "Wykorzystuj aplikacje do podzielania siê rzeczami i us³ugami z s¹siadami zamiast zakupów wielogodzinnych.",
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