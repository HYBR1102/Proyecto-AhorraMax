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
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void proveedoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.proveedoresBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this._Supermercado_AhorraMaxfull3_1DataSet);

        }

        private void Form22_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_Supermercado_AhorraMaxfull3_1DataSet.Proveedores' Puede moverla o quitarla según sea necesario.
            //this.proveedoresTableAdapter.Fill(this._Supermercado_AhorraMaxfull3_1DataSet.Proveedores);

        }
    }
}
