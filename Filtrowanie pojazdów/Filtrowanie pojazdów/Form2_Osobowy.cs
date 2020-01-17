using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filtrowanie_pojazdów
{
    public partial class Form2_Osobowy : Form
    {
        public Form2_Osobowy()
        {
            InitializeComponent();
        }

        public int x = 0;
        public int y = 2020;
        public string mar = "Domyślny";
        public string mod = "Domyślny";
        public string st = "Domyślny";
        public string typ1 = "Domyślny";
        public double poj = 0.0;
        public double poj1 = 50.0;
        public int przeb = 0;
        public int przeb2 = 1000000;
        public string kol = "Domyślny";
        public int cena = 0;
        public int cena2 = 1000000;
        public string pal = "Domyślny";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mar = comboBox1.Text; 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                poj = Convert.ToDouble(Interaction.InputBox("Podaj pojemność min"));
            }
            catch
            {
                poj=0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                poj1 = Convert.ToDouble(Interaction.InputBox("Podaj pojemność max"));
            }
            catch
            {
                poj1 = 100;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            mod = Interaction.InputBox("Podaj model samochodu");
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            typ1 = comboBox4.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            kol = Interaction.InputBox("Podaj kolor");
        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                cena = int.Parse(Interaction.InputBox("Cena min"));
            }
            catch
            {
                cena = 0;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                cena2 = int.Parse(Interaction.InputBox("Cena max"));
            }
            catch
            {
                cena2 = 10000000;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                przeb2 = int.Parse(Interaction.InputBox("Przebieg max"));
            }
            catch
            {
                przeb2 = 10000000;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                przeb = int.Parse(Interaction.InputBox("Przebieg min"));
            }
            catch
            {
                przeb = 0;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            pal = comboBox3.Text;
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            st = comboBox2.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                x = int.Parse(Interaction.InputBox("Podaj rok produkcji od"));
            }
            catch
            {
                x = 0;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                y = int.Parse(Interaction.InputBox("Podaj rok produkcji do"));
            }
            catch
            {
                y = 2020;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<Osobowy> Osobówka1 = new List<Osobowy>();
            Osobówka1.Add(new Osobowy { kolor = "Srebrny", marka = "Toyota", pojemnosc_silnika = 1.6, model = "Yaris", przebieg = 198000, rodzaj_paliwa = "Benzyna", rok_produkcji = 2008, stan = "Używany", typ = "Kompakt", cena = 12000 });
            Osobówka1.Add(new Osobowy { kolor = "Czarny", marka = "Audi", pojemnosc_silnika = 2.0, model = "A3", przebieg = 110000, rodzaj_paliwa = "Diesel", rok_produkcji = 2010, stan = "Używany", typ = "Auto Miejskie", cena = 17700 });
            Osobówka1.Add(new Osobowy { kolor = "Srebrny", marka = "Seat", pojemnosc_silnika = 1.6, model = "Ibiza ", przebieg = 228000, rodzaj_paliwa = "Benzyna", rok_produkcji = 2001, stan = "Używany", typ = "Kompakt", cena = 7000 });
            Osobówka1.Add(new Osobowy { kolor = "Granatowy", marka = "Ford", pojemnosc_silnika = 1.5, model = "Fiesta", przebieg = 258000, rodzaj_paliwa = "Benzyna", rok_produkcji = 2001, stan = "Używany", typ = "Auta Miejskie", cena = 5500 });
            bool cz = true;
            foreach (var i in Osobówka1)
            {
                bool c = ((mar == "Domyślny" || mar == i.marka) & (mod == "Domyślny" || mod == i.model) & (st == "Domyślny" || st == i.stan) & (typ1 == "Domyślny" || typ1 == i.typ) & (kol == "Domyślny" || kol == i.kolor) & (pal == "Domyślny" || pal == i.rodzaj_paliwa) & (poj <= i.pojemnosc_silnika & poj1 >= i.pojemnosc_silnika) &
                    (przeb <= i.przebieg & przeb2 >= i.przebieg) & (cena <= i.cena & cena2 >= i.cena) & (x <= i.rok_produkcji & y >= i.rok_produkcji));
                if (c)
                {
                    MessageBox.Show("Marka- " + i.marka + "   Model- " + i.model + "   Stan- " + i.stan + "   Typ- " + i.typ + "   Rok Produkcji- " + i.rok_produkcji + "   Rodzaj Paliwa- " + i.rodzaj_paliwa + "   Przebieg- " + i.przebieg + "   Pojemność silnika- " + i.pojemnosc_silnika + "   Kolor- " + i.kolor);
                    cz = false;
                }
            }
            if(cz)
            {
                MessageBox.Show("Brak pojazdów spełniających kryteria");
            }
     
        }

        
    }
}
