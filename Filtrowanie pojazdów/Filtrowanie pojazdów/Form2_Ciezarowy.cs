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
    public partial class Form2_Ciezarowy : Form
    {
        public Form2_Ciezarowy()
        {
            InitializeComponent();
        }
        public int x = 0;
        public int y = 2020;
        public string mar = "Domyślny";
        public string st = "Domyślny";
        public string kr = "Domyślny";
        public int poj = 0;
        public int poj1 = 50000;
        public int przeb = 0;
        public int przeb2 = 1000000;
        public int cena = 0;
        public int cena2 = 1000000;
        public string pal = "Domyślny";
        public string os = "Domyślny";
        

        
       
       
       
        
       

        private void button1_Click(object sender, EventArgs e)
        {
            kr = Interaction.InputBox("Podaj kraj pochodzenia");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mar = comboBox1.Text;
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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            pal = comboBox3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                poj = int.Parse(Interaction.InputBox("Podaj moc min"));
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
                poj1 = int.Parse(Interaction.InputBox("Podaj moc max"));
            }
            catch
            {
                poj1 = 10000;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            st = comboBox2.Text;
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

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            os = comboBox4.Text;
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

        private void button8_Click(object sender, EventArgs e)
        {
            List<Ciężarowy> ciezarowy = new List<Ciężarowy>();
            ciezarowy.Add(new Ciężarowy { marka = "MAN", kraj_pochodzenia = "Polska", rok_produkcji = 2007, rodzaj_paliwa = "Diesel", stan = "Używany", moc = 400, liczba_osi = "2", przebieg = 550000, cena = 70000 });
            ciezarowy.Add(new Ciężarowy { marka = "Scania", kraj_pochodzenia = "Niemcy", liczba_osi = "2", moc = 410, przebieg = 792000 , rodzaj_paliwa = "Diesel", rok_produkcji = 2015, stan = "Używany", cena = 89000 });
            ciezarowy.Add(new Ciężarowy { marka = "Volvo", stan = "Używany", rok_produkcji = 2015, rodzaj_paliwa = "Diesel", przebieg = 645000, liczba_osi = "2", kraj_pochodzenia = "Francja", moc= 460 , cena = 117000 });
            ciezarowy.Add(new Ciężarowy { marka = "Mercedes-Benz", stan = "Używany", moc = 320, kraj_pochodzenia = "Niemcy", liczba_osi = "3", przebieg = 515000, rodzaj_paliwa = "Diesel", rok_produkcji = 2005, cena = 99999 });
            ciezarowy.Add(new Ciężarowy { marka = "Volvo", stan = "Używany", kraj_pochodzenia = "Francja", liczba_osi = "4", przebieg = 531200, rodzaj_paliwa = "Diesel", moc = 450, rok_produkcji = 2010, cena = 103000 });
            ciezarowy.Add(new Ciężarowy { marka = "Scania", stan = "Używamy", kraj_pochodzenia = "Włochy", liczba_osi = "2", przebieg = 944000, moc = 620, rodzaj_paliwa = "Diesel", rok_produkcji = 2010, cena = 149800 });
            ciezarowy.Add(new Ciężarowy { marka = "Renault", stan = "Używany", kraj_pochodzenia = "Francja", liczba_osi = "3", moc = 210, przebieg = 152000, rodzaj_paliwa = "Diesel", rok_produkcji = 2002, cena = 55000 });

            bool czy = true;
            foreach (var i in ciezarowy)
            {
                bool c = ((mar == "Domyślny" || mar == i.marka) & (st == "Domyślny" || st == i.stan)  & (pal == "Domyślny" || pal == i.rodzaj_paliwa) & (poj <= i.moc & poj1 >= i.moc) & (kr == "Domyślny" || kr == i.kraj_pochodzenia) &
                    (przeb <= i.przebieg & przeb2 >= i.przebieg) & (cena <= i.cena & cena2 >= i.cena) & (x <= i.rok_produkcji & y >= i.rok_produkcji)& ((os == "Domyślny" || os == i.liczba_osi)));
                if (c)
                {
                    MessageBox.Show("Marka- " + i.marka  + "   Stan- " + i.stan +  "   Rok Produkcji- " + i.rok_produkcji + "   Rodzaj Paliwa- " + i.rodzaj_paliwa + "   Przebieg- " + i.przebieg + "   Moc silnika- " + i.moc+ "   Liczba osi- " + i.liczba_osi+ "   Kraj Pochodzenia- "+ i.kraj_pochodzenia+ "   Cena- "+ i.cena );
                    czy = false;
                }
            }
            if(czy)
            {
                MessageBox.Show("Brak pojazdów spełniających podane kryteria.");
            }
        }
    }
}
