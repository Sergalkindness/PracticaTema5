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
            int numPalabras = 0;
            double coste;
            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente?
            if (cbUrgente.Checked)
                tipoTelegrama = 'u';
            //Obtengo el número de palabras que forma el telegrama
            numPalabras = textoTelegrama.Length;
            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
                if (numPalabras <= 10)
                    coste = 25;
                else
                    coste = 0.5 * numPalabras;
            else
            //Si el telegrama es urgente
            if (tipoTelegrama == 'u')
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);
            else
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
