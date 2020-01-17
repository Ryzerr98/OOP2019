using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtrowanie_pojazdów
{
    class Dostawczy : IPorownaj
    {
        public string marka;
        public int rok_produkcji;
        public int cena;
        public string stan;
        public string kraj_pochodzenia;
        public double pojemnosc;
        public string paliwo;
        public int przebieg;
        public void Porownaj()
        {
            throw new NotImplementedException();
        }
    }
}
