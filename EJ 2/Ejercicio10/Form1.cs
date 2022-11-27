using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void txt_TextChanged(object sender, EventArgs e)
       {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void sender_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = ' ';
            int numPalabras = 1;
            double coste = 0;
            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente?
            if (cbUrgente.Checked)
                tipoTelegrama = 'u';
            else
                tipoTelegrama = 'o';
            //Obtengo el número de palabras que forma el telegrama
            char c;
            for (int i = 1; i <= textoTelegrama.Length; i++)
            {
                c = textoTelegrama[i - 1];
                if (i == 0 || i == textoTelegrama.Length)
                {
                    if (c == ' ')
                        continue;
                }
                if (c == ' ')
                    numPalabras++;
            }
            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
                if (numPalabras <= 10)
                    coste = 2.5;
                else
                    coste = 2.5 + 0.5 * (numPalabras - 10);
            else
            //Si el telegrama es urgente
            if (tipoTelegrama == 'u')
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);

            if (textoTelegrama.Length == 0)
                coste = 0;
            txtPrecio.Text = coste.ToString() + " euros";
        }

        private void cbUrgente_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
//Los telegramas pueden ser ordinarios o urgentes. SI
//El coste de un telegrama ordinario son 2,5 euros, hasta un máximo de 10 palabras.
//A partir de ahí, cada palabra adicional tiene un coste de 0,50€.
//El coste de un telegrama urgente son 5 euros, hasta un máximo de 10 palabras.
//A partir de ahí, cada palabra adicional tiene un coste de 0,75€.
