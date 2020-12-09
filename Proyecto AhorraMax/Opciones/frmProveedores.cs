using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_AhorraMax.Menu
{
    public partial class frmProveedores : Form
    {
        Conexion conexion = new Conexion();
        public frmProveedores()
        {
            InitializeComponent();
            grpProveedor.Enabled = false;

            conexion.conectar();
            dtgProveedores.DataSource = conexion.ejecutarQuery($"SELECT * FROM Proveedores").Tables[0];
            conexion.cerrar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (grpProveedor.Enabled == false)
            {
                grpProveedor.Enabled = true;
                txtProveedores.Enabled = false;
                txtDireccion.Enabled = false;
                txtRFC.Enabled = false;
            }
            else
            {
                string clave = txtClave.Text;

                conexion.conectar();
                dtgProveedores.DataSource = conexion.ejecutarQuery($"SELECT * FROM Proveedores WHERE Clave = \"{clave}\"").Tables[0];
                conexion.cerrar();

                //Limpieza
                txtClave.Clear();
                txtProveedores.Enabled = true;
                txtDireccion.Enabled = true;
                txtRFC.Enabled = true;
                grpProveedor.Enabled = false;
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (grpProveedor.Enabled == false)
            {
                grpProveedor.Enabled = true;
            }
            else
            { 
                string clave = txtClave.Text;
                string proveedores = txtProveedores.Text;
                string direccion = txtDireccion.Text;
                string rfc = txtRFC.Text;

                conexion.conectar();
                conexion.ejecutarInstruccion($"INSERT INTO Proveedores " +
                    $"(Clave, Proveedores, Dirección, RFC) " +
                    $"VALUES ('{clave}', '{proveedores}', '{direccion}', '{rfc}')");
                dtgProveedores.DataSource = conexion.ejecutarQuery($"SELECT * FROM Proveedores").Tables[0];
                conexion.cerrar();

                //Limpieza
                txtClave.Clear();
                txtProveedores.Clear();
                txtDireccion.Clear();
                txtRFC.Clear();
                grpProveedor.Enabled = false;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
