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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
            grpProducto.Enabled = false;
        }

        Conexion conexion = new Conexion();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(grpProducto.Enabled == false)
            {
                grpProducto.Enabled = true;
                txtNombre.Enabled = false;
                txtPrecioDeVenta.Enabled = false;
                txtPrecioDeCompra.Enabled = false;
                txtProveedor.Enabled = false;
                txtCantidad.Enabled = false;
                txtStock.Enabled = false;

                conexion.conectar();
                dtgProductos.DataSource = conexion.ejecutarQuery("SELECT * FROM Abarrotes WHERE Codigo = \""+ txtCodigo.Text + "\"");
            }
            else
            {

            }
            
        }
    }
}
