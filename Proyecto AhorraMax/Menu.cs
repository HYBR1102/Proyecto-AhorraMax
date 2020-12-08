using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_AhorraMax
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Productos = new Productos();
            Productos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Proveedores = new Proveedores();
            Proveedores.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Reportes = new Reportes();
            Reportes.Show(); 
        }
    }
}
