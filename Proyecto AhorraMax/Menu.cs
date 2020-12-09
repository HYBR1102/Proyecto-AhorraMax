using Proyecto_AhorraMax.Menu;
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
            Form frmProductos = new frmProductos();
            frmProductos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frmProveedores = new frmProveedores();
            frmProveedores.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Reportes = new Reportes();
            Reportes.Show(); 
        }
    }
}
