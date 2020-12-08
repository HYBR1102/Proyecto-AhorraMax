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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ReporteGeneral = new Form24();
            ReporteGeneral.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ReporteDepartamentos = new Form25();
            ReporteDepartamentos.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form ReporteProveedores = new Form45();
            ReporteProveedores.Show();
        }
    }
}
