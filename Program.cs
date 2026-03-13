using Wildways_console_app;

List<Dier> dieren = new List<Dier>();

bool running = true;

while (running)
{
    Console.WriteLine("=== WildWays ===");
    Console.WriteLine("1. Dier toevoegen");
    Console.WriteLine("2. Overzicht dieren");
    Console.WriteLine("3. Transport plannen");
    Console.WriteLine("4. Stoppen");

    string keuze = Console.ReadLine();

    if (keuze == "1")
    {
        Dier dier = new Dier();

        Console.Write("Naam: ");
        dier.Naam = Console.ReadLine();

        Console.Write("Dieet (Carnivoor/Herbivoor): ");
        dier.Dieet = Console.ReadLine();

        Console.Write("Grootte (Klein/Gemiddeld/Groot): ");
        dier.Grootte = Console.ReadLine();

        Console.Write("Locatie: ");
        dier.Locatie = Console.ReadLine();

        dieren.Add(dier);

        Console.WriteLine("Dier toegevoegd!");
    }

    else if (keuze == "2")
    {
        foreach (var dier in dieren)
        {
            Console.WriteLine($"{dier.Naam} | {dier.Grootte} | {dier.Dieet} | {dier.Locatie}");
        }
    }

    else if (keuze == "3")
    {
        List<Treinwagon> wagons = new List<Treinwagon>();

        foreach (var dier in dieren)
        {
            bool geplaatst = false;

            foreach (var wagon in wagons)
            {
                if (wagon.TotaalPunten() + dier.Punten() <= 10)
                {
                    wagon.Dieren.Add(dier);
                    geplaatst = true;
                    break;
                }
            }

            if (!geplaatst)
            {
                Treinwagon wagon = new Treinwagon();
                wagon.Dieren.Add(dier);
                wagons.Add(wagon);
            }
        }

        int nummer = 1;

        foreach (var wagon in wagons)
        {
            Console.WriteLine($"Wagon {nummer}");

            foreach (var dier in wagon.Dieren)
            { 
                Console.WriteLine($" - {dier.Naam}");
            }

            nummer++;
        }
    }

    else if (keuze == "4")
    {
        running = false;
    }

    Console.WriteLine();
}