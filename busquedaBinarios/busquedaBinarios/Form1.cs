using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace busquedaBinarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Vector miVector;

        private void btnCrear_Click(object sender, EventArgs e)
        {
            miVector = new Vector(Convert.ToInt32(txtTamañoVector.Text));
            txtTamañoVector.Text = "";

        }

        private void btnLlenar_Click(object sender, EventArgs e)
        {
            miVector.llenarMiVector(Convert.ToInt32(txtLimite.Text));
            txtLimite.Text = "";
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            miVector.ordenar();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtResultados.Text = miVector.mostrar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int busqueda = miVector.busquedaBinaria(Convert.ToInt32(txtBuscar.Text));

            if (busqueda == -1)
                txtResultados.Text += Environment.NewLine + "-1";
            else
                txtResultados.Text += Environment.NewLine + "El numero esta en la posicion: " + busqueda;
        }
    }
}
