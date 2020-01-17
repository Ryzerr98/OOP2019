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
    public partial class Form2_Dostawczy : Form
    {
        public Form2_Dostawczy()
        {
            InitializeComponent();
        }
        public int x = 0;
        public int y = 2020;
        public string mar = "Domyślny";
        public string st = "Domyślny";
        public string kr = "Domyślny";
        public double poj = 0;
        public double poj1 = 50000;
        public int przeb = 0;
        public int przeb2 = 1000000;
        public int cena = 0;
        public int cena2 = 1000000;
        public string pal = "Domyślny";

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mar = comboBox1.Text;
        }

        private void label7_Click(object sender, EventArgs e)
        {

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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                przeb2 = int.Parse(Interaction.InputBox("Przebieg max"));
            }
            catch
            {
                przeb2 = 1000000;
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                kr = Interaction.InputBox("Podaj kraj pochodzenia");
            }
            catch
            {
                kr = "Domyślny";
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

        private void button6_Click(object sender, EventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                cena2 = int.Parse(Interaction.InputBox("Cena max"));
            }
            catch
            {
                cena2 = 1000000;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                poj = Convert.ToDouble(Interaction.InputBox("Podaj pojemność min"));
            }
            catch
            {
                poj = 0;
            }
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void button8_Click(object sender, EventArgs e)
        {
            List<Dostawczy> dost = new List<Dostawczy>();
            dost.Add(new Dostawczy { marka = "Volkswagen", kraj_pochodzenia = "Polska", pojemnosc = 2, paliwo = "Diesel", przebieg = 212000, cena = 65000, rok_produkcji = 2016, stan = "Używany" });
            dost.Add(new Dostawczy { marka = "Iveco", cena = 78500, stan = "Używany", rok_produkcji = 2017, przebieg = 87000, paliwo = "Diesel", pojemnosc = 2.3, kraj_pochodzenia = "Niemcy" });
            dost.Add(new Dostawczy { marka = "Ford", cena = 77600, stan = "Nowy", kraj_pochodzenia = "Polska", pojemnosc = 1.5, paliwo = "Diesel", przebieg = 0, rok_produkcji = 2019 });
            dost.Add(new Dostawczy { marka = "Mercedes-Benz", rok_produkcji = 2013, przebieg = 173350, paliwo = "Diesel", pojemnosc = 2.2, kraj_pochodzenia = "Niemcy", stan = "Używany", cena = 57900 });
            dost.Add(new Dostawczy { marka = "Fiat", cena = 61999, stan = "Używany", kraj_pochodzenia = "Francja", pojemnosc = 2.5, paliwo = "Diesel", przebieg = 187000, rok_produkcji = 2016 });
            dost.Add(new Dostawczy { marka = "Peugeot", rok_produkcji = 2014, przebieg = 12600, paliwo = "Diesel", pojemnosc = 2, kraj_pochodzenia = " Polska", stan = "Używany", cena = 29900 });


            bool czy = true;
            foreach (var i in dost)
            {
                bool c = ((mar == "Domyślny" || mar == i.marka) & (st == "Domyślny" || st == i.stan) & (pal == "Domyślny" || pal == i.paliwo) & (poj <= i.pojemnosc & poj1 >= i.pojemnosc) &
                    (przeb <= i.przebieg & przeb2 >= i.przebieg) & (cena <= i.cena & cena2 >= i.cena) & (x <= i.rok_produkcji & y >= i.rok_produkcji) & (kr == "Domyślny" || kr == i.kraj_pochodzenia));
                if (c)
                {
                    MessageBox.Show("Marka- " + i.marka + "   Stan- " + i.stan + "   Rok Produkcji- " + i.rok_produkcji + "   Rodzaj Paliwa- " + i.paliwo+ "   Przebieg- " + i.przebieg + "   Pojemność Silnika- " + i.pojemnosc +  "   Kraj Pochodzenia- " + i.kraj_pochodzenia + "   Cena- " + i.cena);
                    czy = false;
                }
            }
            if(czy)
            {
                MessageBox.Show("Brak pojazdów pasujących do kryteriów");
            }
        }
    }
}
