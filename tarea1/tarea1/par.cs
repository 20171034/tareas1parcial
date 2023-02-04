using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea1
{
    public partial class par : Form
    {
        public par()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void resultadobutton_Click(object sender, EventArgs e)
        {
            int num;
            num = Convert.ToInt32(NumerotextBox1.Text);
            if (num>0)
            {
                resultadotextBox.Text ="Es positivo";
            }
            else if (num<0)
            {
                resultadotextBox.Text = "es Negativo";
            }
            else
            {
                resultadotextBox.Text = "neutro";
            }

           
        }

        private void limpiarbutton1_Click(object sender, EventArgs e)
        {
            limpiarcontroles();
        }
        private void limpiarcontroles()
        {
            resultadotextBox.Clear();
            impartextBox1.Clear();
            NumerotextBox1.Clear();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            num = Convert.ToInt32(NumerotextBox1.Text);

            if (num % 2 == 0)
            {
                impartextBox1.Text = "Par";
            }
            else
            {
                impartextBox1.Text = "Impar";
            }
        }
    }
    }
