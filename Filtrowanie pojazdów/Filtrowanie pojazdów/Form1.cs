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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2_Osobowy O = new Form2_Osobowy();
            O.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2_Motocykl M = new Form2_Motocykl();
            M.ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2_Ciezarowy C = new Form2_Ciezarowy();
            C.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2_Dostawczy D = new Form2_Dostawczy();
            D.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2_Rolniczy R = new Form2_Rolniczy();
            R.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
