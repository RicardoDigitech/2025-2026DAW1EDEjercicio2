using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025_2026_DAW_1_ED_Ejercicio_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSoloLectura_Click(object sender, EventArgs e)
        {
            txtNombre.ReadOnly = true;
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            txtApellidos.Enabled = false;
        }

        private void btnMayusculas_Click(object sender, EventArgs e)
        {
            txtNotas.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
