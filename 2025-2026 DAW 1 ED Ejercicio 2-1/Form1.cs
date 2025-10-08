using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025_2026_DAW_1_ED_Ejercicio_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblA.Text = "Sí";
            lblB.Text = "Sí";
            lblC.Text = "Sí";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn1.Text = "No";
            btn2.Text = "No";
            btn3.Text = "No";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblA.Text = "A";
            lblB.Text = "B";
            lblC.Text = "C";
        }
    }
}
