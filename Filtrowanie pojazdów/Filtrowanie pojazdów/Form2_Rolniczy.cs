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
    public partial class Form2_Rolniczy : Form
    {
        public Form2_Rolniczy()
        {
            InitializeComponent();
        }
        public string mar = "Domyślny";
        public string kr = "Domyślny";
        public string st = "Domyślny";
        public int x = 0;
        public int y = 2020;
        public int cena = 0;
        public int cena2 = 1000000;
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mar = comboBox1.Text;
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            st = comboBox2.Text;
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
                cena2 = 1000000;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Rolniczy> rol = new List<Rolniczy>();
            rol.Add(new Rolniczy { marka = "Claas", cena = 328000, stan = "Używany", kraj_pochodzenia = "Polska", rok_produkcji = 2008 });
            rol.Add(new Rolniczy { marka = "Ursus", rok_produkcji = 1983, kraj_pochodzenia = "Polska", stan = "Używany", cena = 25900 });
            rol.Add(new Rolniczy { marka = "Massey Ferguson", cena = 111000, stan = "Używany", kraj_pochodzenia = "Wielka Brytania", rok_produkcji = 2005 });
            rol.Add(new Rolniczy { marka = "John Deere", rok_produkcji = 1988, kraj_pochodzenia = "Niemcy", stan = "Używany", cena = 59000 });
            rol.Add(new Rolniczy { marka = "Class", cena = 248000, stan = "Używany", kraj_pochodzenia = "Polska", rok_produkcji = 2002 });
            rol.Add(new Rolniczy { marka = "Inne", rok_produkcji = 2009, kraj_pochodzenia = "Niemcy", stan = "Używany", cena = 106000 });
            rol.Add(new Rolniczy { marka = "Inne", rok_produkcji = 2004, cena = 24000, stan="Używany", kraj_pochodzenia="Polska"});
            rol.Add(new Rolniczy { marka = "John Deere", kraj_pochodzenia = "Norwegia", stan = "Używany", cena = 235000, rok_produkcji = 2012 });
            rol.Add(new Rolniczy { marka = "Deutz-Fahr", cena = 42900, rok_produkcji = 1985, stan = "Używany", kraj_pochodzenia = "Niemcy" });

            bool czy = true;
            foreach (var i in rol)
            {
                bool c = ((mar == "Domyślny" || mar == i.marka) & (st == "Domyślny" || st == i.stan) & (kr == "Domyślny" || kr == i.kraj_pochodzenia) &
                     (cena <= i.cena & cena2 >= i.cena) & (x <= i.rok_produkcji & y >= i.rok_produkcji));
                if (c)
                {
                    MessageBox.Show("Marka- " + i.marka + "   Stan- " + i.stan + "   Rok Produkcji- " + i.rok_produkcji +  "   Kraj Pochodzenia- " + i.kraj_pochodzenia + "   Cena- " + i.cena);
                    czy = false;
                }
                if(czy)
                {
                    MessageBox.Show("Brak pojazdów spełniających kryteria");
                }
            }
        }

        
    }
    
}
