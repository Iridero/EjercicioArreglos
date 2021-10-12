using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioArreglos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Button[] teclado;
        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicialice aqui para almacenar 10 botones

            // Asigne cada boton (b0 - b9) a su posicion correspondiente
            // en el vector
        }
        Ejercicio ej = new Ejercicio();
        private void btnDiasSemana_Click(object sender, EventArgs e)
        {
            lstDiasSemana.DataSource = ej.DiasSemana;
        }

        private void btnTerminanS_Click(object sender, EventArgs e)
        {
            txtTerminanS.Text = ej.TerminanEn('s').ToString();
        }
    }
}
