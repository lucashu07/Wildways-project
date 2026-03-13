using System;

namespace Wildways_console_app
{
    internal class Dier
    {
        public string Naam { get; set; }

        public string Dieet { get; set; }  

        public string Grootte { get; set; } 

        public string Locatie { get; set; }

        public int Punten()
        {
            if (Grootte == "Klein")
                return 1;

            if (Grootte == "Gemiddeld")
                return 3;

            if (Grootte == "Groot")
                return 5;

            return 0;
        }
    }
}