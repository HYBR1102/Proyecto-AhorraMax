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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
            grpProducto.Enabled = false;
            cboDepartamento.SelectedIndex = 0;

            string tabla = cboDepartamento.Text;

            conexion.conectar();
            dtgProductos.DataSource = conexion.ejecutarQuery($"SELECT * FROM [{tabla}]").Tables[0];
            conexion.cerrar();
        }

        Conexion conexion = new Conexion();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (grpProducto.Enabled == false)
            {
                grpProducto.Enabled = true;
                txtNombre.Enabled = false;
                txtPrecioDeVenta.Enabled = false;
                txtPrecioDeCompra.Enabled = false;
                txtProveedor.Enabled = false;
                txtCantidad.Enabled = false;
                txtStock.Enabled = false;
            }
            else
            {
                string tabla = cboDepartamento.Text;
                string codigo = txtCodigo.Text;

                conexion.conectar();
                dtgProductos.DataSource = conexion.ejecutarQuery($"SELECT * FROM [{tabla}] WHERE Código = \"{codigo}\"").Tables[0];
                conexion.cerrar();

                //Limpieza
                //cboDepartamento.SelectedIndex = 0;
                txtCodigo.Clear();
                txtNombre.Enabled = true;
                txtPrecioDeVenta.Enabled = true;
                txtPrecioDeCompra.Enabled = true;
                txtProveedor.Enabled = true;
                txtCantidad.Enabled = true;
                txtStock.Enabled = true;
                grpProducto.Enabled = false;
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if(grpProducto.Enabled == false)
            {
                grpProducto.Enabled = true;
            }
            else
            {
                string tabla = cboDepartamento.Text;
                string codigo = txtCodigo.Text;
                string nombre = txtNombre.Text;
                double precioDeVenta = double.Parse(txtPrecioDeVenta.Text);
                double precioDeCompra = double.Parse(txtPrecioDeCompra.Text);
                string proveedor = txtProveedor.Text;
                int cantidad = int.Parse(txtCantidad.Text);
                int stock = int.Parse(txtStock.Text);

                conexion.conectar();
                conexion.ejecutarInstruccion($"INSERT INTO [{tabla}] " +
                    $"(Código, Nombre, [Precio de venta], [Precio de compra], Proveedor, Stock, Cantidad) " +
                    $"VALUES ('{codigo}', '{nombre}', {precioDeVenta}, {precioDeCompra}, '{proveedor}', {stock}, {cantidad})");
                dtgProductos.DataSource = conexion.ejecutarQuery($"SELECT * FROM [{tabla}]").Tables[0];
                conexion.cerrar();

                //Limpieza
                //cboDepartamento.SelectedIndex = 0;
                txtCodigo.Clear();
                txtNombre.Clear();
                txtPrecioDeVenta.Clear();
                txtPrecioDeCompra.Clear();
                txtProveedor.Clear();
                txtCantidad.Clear();
                txtStock.Clear();
                grpProducto.Enabled = false;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tabla = cboDepartamento.Text;

            conexion.conectar();
            dtgProductos.DataSource = conexion.ejecutarQuery($"SELECT * FROM [{tabla}]").Tables[0];
            conexion.cerrar();
        }
    }
}
