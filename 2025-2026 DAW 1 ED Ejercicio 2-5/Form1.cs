using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025_2026_DAW_1_ED_Ejercicio_2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblResultado.Text = btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblResultado.Text = btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblResultado.Text = btn3.Text;
        }
    }
}
