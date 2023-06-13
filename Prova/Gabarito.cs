using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova
{
    public partial class Gabarito : Form
    {
        public Gabarito()
        {
            InitializeComponent();
        }

        private void bt_avaliar_Click(object sender, EventArgs e)
        {
            int acertos = 0;
            string[] gab = { "A", "B", "D", "E", "C", "A", "A", "D", "E", "B" };

            try
            {
                if (textBox1.Text == gab[0])
                {
                    acertos++;
                }
                else if (textBox2.Text == gab[1])
                {
                    acertos++;
                }
                else if (textBox3.Text == gab[2])
                {
                    acertos++;
                }
                else if (textBox4.Text == gab[3])
                {
                    acertos++;
                }
                else if (textBox5.Text == gab[4])
                {
                    acertos++;
                }
                else if (textBox6.Text == gab[5])
                {
                    acertos++;
                }
                else if (textBox7.Text == gab[6])
                {
                    acertos++;
                }
                else if (textBox8.Text == gab[7])
                {
                    acertos++;
                }
                else if (textBox9.Text == gab[8])
                {
                    acertos++;
                }
                else if (textBox10.Text == gab[9])
                {
                    acertos++;
                }
                



            } catch
            {
                label1.Text = acertos.ToString();
            }

            MessageBox.Show($"{acertos} Acertos");
        }
        
    }
}
