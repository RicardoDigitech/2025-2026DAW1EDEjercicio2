using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025_2026_DAW_1_ED_Ejercicio_2_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblUna_MouseEnter(object sender, EventArgs e)
        {
            txtNumero.Text = txtNumero.Text + lblUna.Text;
        }

        private void lblDos_MouseEnter(object sender, EventArgs e)
        {
            txtNumero.Text = txtNumero.Text + lblDos.Text;
        }

        private void lblTres_MouseEnter(object sender, EventArgs e)
        {
            txtNumero.Text = txtNumero.Text + lblTres.Text;
        }

        private void lblCuatro_MouseEnter(object sender, EventArgs e)
        {
            txtNumero.Text = txtNumero.Text + lblCuatro.Text;
        }

        private void lblCinco_MouseEnter(object sender, EventArgs e)
        {
            txtNumero.Text = txtNumero.Text + lblCinco.Text;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //txtNumero.Text = "";
            txtNumero.Clear();
        }
    }
}
