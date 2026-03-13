using Wildways_console_app;

class Treinwagon
{
    public List<Dier> Dieren = new List<Dier>();

    public int TotaalPunten()
    {
        int totaal = 0;

        foreach (var dier in Dieren)
        {
            totaal += dier.Punten();
        }

        return totaal;
    }
}