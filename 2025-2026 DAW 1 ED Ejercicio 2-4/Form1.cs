using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025_2026_DAW_1_ED_Ejercicio_2_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtClave.MaxLength = 10;
            txtClave.PasswordChar = '*';
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtClave.Text);
        }
    }
}
