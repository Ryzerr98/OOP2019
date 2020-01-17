using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtrowanie_pojazdów
{
    class Motocykl:IPorownaj
    {
        public string marka;
        public string model;
        public string rodzaj_paliwa;
        public int rok_produkcji;
        public int przebieg;
        public int cena;
        public double pojemność;
        public string stan;

        public void Porownaj()
        {
            throw new NotImplementedException();
        }
    }
}
