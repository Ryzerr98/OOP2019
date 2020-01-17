using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtrowanie_pojazdów
{
    class Osobowy:IPorownaj
    {
        public int rok_produkcji;
        public string marka;
        public string model;
        public string kolor;
        public double pojemnosc_silnika;
        public string stan;
        public int przebieg;
        public string typ;
        public string rodzaj_paliwa;
        public int cena;

        public void Porownaj()
        {
            throw new NotImplementedException();
        }
    }
}
