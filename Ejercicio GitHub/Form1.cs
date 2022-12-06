using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_GitHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = ' ';
            int numPalabras = 0;
            double coste;
            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente?
            if (cbUrgente.Checked)
                tipoTelegrama = 'u';
            else tipoTelegrama = 'o';
            //Obtengo el número de palabras que forma el telegrama
            int i = 0, c = 1;
            while (i < textoTelegrama.Length)
            {
                if (textoTelegrama[i] == ' ')
                {
                    c++;
                }
                i++;
            }
            numPalabras = c;
            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
                if (numPalabras <= 10)
                    coste = 2.5;
                else
                    coste = 2.5 + 0.5 * (numPalabras - 10);

            //Si el telegrama es urgente
            if (tipoTelegrama == 'u')
            {
                if (numPalabras <= 10)
                {
                    coste = 5;
                    txtPrecio.Text = coste.ToString() + " euros";
                }
                else
                {
                    coste = 5 + 0.75 * (numPalabras - 10);
                    txtPrecio.Text = coste.ToString() + " euros";
                }
            }
        }
    }
}
