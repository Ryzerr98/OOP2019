using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtrowanie_pojazdów
{
    class Rolniczy:IPorownaj
    {
        public string stan;
        public string marka;
        public int rok_produkcji;
        public string kraj_pochodzenia;
        public int cena;
        public void Porownaj()
        {
            throw new NotImplementedException();
        }
    }
}
