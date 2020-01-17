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
    public partial class Form2_Motocykl : Form
    {
        public int x = 0;
        public int y = 2020;
        public string mar = "Domyślny";
        public string mod = "Domyślny";
        public string st = "Domyślny";
        public double poj = 0.0;
        public double poj1 = 50.0;
        public int przeb = 0;
        public int przeb2 = 1000000;
        public int cena = 0;
        public int cena2 = 1000000;
        public string pal = "Domyślny";
        public Form2_Motocykl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
                poj = 0;
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
            try
            {
                mod = Interaction.InputBox("Podaj model samochodu");
            }
            catch
            {
                mod = "Domyślny";
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
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
                przeb2 = 1000000;
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

        private void button6_Click_1(object sender, EventArgs e)
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

        private void button8_Click_1(object sender, EventArgs e)
        {
            try
            {
                mod = Interaction.InputBox("Podaj model ");
            }
            catch
            {
                mod = "Domyślny";
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            mar = comboBox1.Text;
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            st = comboBox2.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
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

        private void button2_Click_1(object sender, EventArgs e)
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

        private void button3_Click_1(object sender, EventArgs e)
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

        private void button4_Click_1(object sender, EventArgs e)
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

        private void button5_Click_1(object sender, EventArgs e)
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
            List<Motocykl> motocykl = new List<Motocykl>();
            motocykl.Add(new Motocykl { marka = "Suzuki",model = "VL 800 Volusia - Boulevard C50",rok_produkcji = 2011,przebieg = 11220, pojemność=0.805, stan = "Używany", rodzaj_paliwa ="Benzyna", cena= 26900  });
            motocykl.Add(new Motocykl { marka = "Suzuki", model = "GSR", przebieg = 47500, pojemność = 0.6, rodzaj_paliwa = "Benzyna", rok_produkcji = 2006, stan = "Używany", cena = 10950 });
            motocykl.Add(new Motocykl { marka = "Suzuki", model = "SV", rok_produkcji = 2001, pojemność = 0.65, stan = "Używany", przebieg = 78000, rodzaj_paliwa = "Benzyna", cena = 5900 });
            motocykl.Add(new Motocykl { marka = "Yamaha", model = "Drag Star", pojemność = 1.1, przebieg = 13948, rodzaj_paliwa = "Benzyna", rok_produkcji = 2003, stan = "Używany", cena = 19000 });
            motocykl.Add(new Motocykl { marka = "Honda", model = "CB", pojemność = 1, przebieg = 23460, rodzaj_paliwa = "Benzyna", rok_produkcji = 2014, stan = "Używany", cena = 22900 });
            motocykl.Add(new Motocykl { marka = "BMW", model = "R", pojemność = 1.2, rodzaj_paliwa = "Benzyna", przebieg = 105000, stan = "Używany", rok_produkcji = 2009, cena = 27000 });
            bool czy = true;

            foreach (var i in motocykl)
            {
                bool c = ((mar == "Domyślny" || mar == i.marka) & (mod == "Domyślny" || mod == i.model) & (st == "Domyślny" || st == i.stan) & (pal == "Domyślny" || pal == i.rodzaj_paliwa) & (poj <= i.pojemność & poj1 >= i.pojemność) &
                    (przeb <= i.przebieg & przeb2 >= i.przebieg) & (cena <= i.cena & cena2 >= i.cena) & (x <= i.rok_produkcji & y >= i.rok_produkcji));
                if (c)
                {
                    MessageBox.Show("Marka- " + i.marka + "   Model- " + i.model + "   Stan- " + i.stan + "   Rok Produkcji- " + i.rok_produkcji + "   Rodzaj Paliwa- " + i.rodzaj_paliwa + "   Przebieg- " + i.przebieg + "   Pojemność silnika- " + i.pojemność+ "   Cena- "+ i.cena);
                    czy = false;
                }
            }
            if(czy)
            {
                MessageBox.Show("Brak pojazdów spełniających kryteria wyszukiwania");
            }
        }
    }
}
