using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtrowanie_pojazdów
{
    class Ciężarowy:IPorownaj
    {
        public string marka;
        public int rok_produkcji;
        public string rodzaj_paliwa;
        public int przebieg;
        public string kraj_pochodzenia;
        public string stan;
        public  int moc;
        public string liczba_osi;
        public int cena;

        public void Porownaj()
        {
            throw new NotImplementedException();
        }
    }
}
