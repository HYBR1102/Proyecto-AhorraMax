namespace Proyecto_AhorraMax
{
    partial class Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.grpProducto = new System.Windows.Forms.GroupBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.lblPrecioDeCompra = new System.Windows.Forms.Label();
            this.lblPrecioDeVenta = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtPrecioDeCompra = new System.Windows.Forms.TextBox();
            this.txtPrecioDeVenta = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.dtgProductos = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grpAcciones = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.grpProductos = new System.Windows.Forms.GroupBox();
            this.grpProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).BeginInit();
            this.grpAcciones.SuspendLayout();
            this.grpProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Items.AddRange(new object[] {
            "Abarrotes",
            "Bebidas",
            "Botanas",
            "Cafetería",
            "Carnicería",
            "Comedor",
            "Condimentos",
            "Dulcería",
            "Frutería",
            "Granos, semillas y derivados",
            "Lácteos",
            "Panadería",
            "Pastas",
            "Pastelería",
            "Pescadería",
            "Salchichonería",
            "Tortillería",
            "Verduras",
            "Vinos y licores"});
            this.cboDepartamento.Location = new System.Drawing.Point(86, 19);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(121, 21);
            this.cboDepartamento.TabIndex = 0;
            this.cboDepartamento.SelectedIndexChanged += new System.EventHandler(this.cboDepartamento_SelectedIndexChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(107, 46);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(6, 27);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(74, 13);
            this.lblDepartamento.TabIndex = 2;
            this.lblDepartamento.Text = "Departamento";
            // 
            // grpProducto
            // 
            this.grpProducto.Controls.Add(this.lblStock);
            this.grpProducto.Controls.Add(this.lblCantidad);
            this.grpProducto.Controls.Add(this.lblProveedor);
            this.grpProducto.Controls.Add(this.txtStock);
            this.grpProducto.Controls.Add(this.txtCantidad);
            this.grpProducto.Controls.Add(this.txtProveedor);
            this.grpProducto.Controls.Add(this.lblPrecioDeCompra);
            this.grpProducto.Controls.Add(this.lblPrecioDeVenta);
            this.grpProducto.Controls.Add(this.lblNombre);
            this.grpProducto.Controls.Add(this.txtPrecioDeCompra);
            this.grpProducto.Controls.Add(this.txtPrecioDeVenta);
            this.grpProducto.Controls.Add(this.txtNombre);
            this.grpProducto.Controls.Add(this.lblCodigo);
            this.grpProducto.Controls.Add(this.lblDepartamento);
            this.grpProducto.Controls.Add(this.cboDepartamento);
            this.grpProducto.Controls.Add(this.txtCodigo);
            this.grpProducto.Location = new System.Drawing.Point(12, 12);
            this.grpProducto.Name = "grpProducto";
            this.grpProducto.Size = new System.Drawing.Size(220, 235);
            this.grpProducto.TabIndex = 3;
            this.grpProducto.TabStop = false;
            this.grpProducto.Text = "Producto";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(6, 209);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(35, 13);
            this.lblStock.TabIndex = 16;
            this.lblStock.Text = "Stock";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(6, 183);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 15;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(6, 157);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(56, 13);
            this.lblProveedor.TabIndex = 14;
            this.lblProveedor.Text = "Proveedor";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(107, 202);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 20);
            this.txtStock.TabIndex = 13;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(107, 176);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 12;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(107, 150);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtProveedor.TabIndex = 11;
            // 
            // lblPrecioDeCompra
            // 
            this.lblPrecioDeCompra.AutoSize = true;
            this.lblPrecioDeCompra.Location = new System.Drawing.Point(6, 131);
            this.lblPrecioDeCompra.Name = "lblPrecioDeCompra";
            this.lblPrecioDeCompra.Size = new System.Drawing.Size(90, 13);
            this.lblPrecioDeCompra.TabIndex = 10;
            this.lblPrecioDeCompra.Text = "Precio de compra";
            // 
            // lblPrecioDeVenta
            // 
            this.lblPrecioDeVenta.AutoSize = true;
            this.lblPrecioDeVenta.Location = new System.Drawing.Point(6, 105);
            this.lblPrecioDeVenta.Name = "lblPrecioDeVenta";
            this.lblPrecioDeVenta.Size = new System.Drawing.Size(82, 13);
            this.lblPrecioDeVenta.TabIndex = 9;
            this.lblPrecioDeVenta.Text = "Precio de venta";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 79);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre";
            // 
            // txtPrecioDeCompra
            // 
            this.txtPrecioDeCompra.Location = new System.Drawing.Point(107, 124);
            this.txtPrecioDeCompra.Name = "txtPrecioDeCompra";
            this.txtPrecioDeCompra.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioDeCompra.TabIndex = 7;
            // 
            // txtPrecioDeVenta
            // 
            this.txtPrecioDeVenta.Location = new System.Drawing.Point(107, 98);
            this.txtPrecioDeVenta.Name = "txtPrecioDeVenta";
            this.txtPrecioDeVenta.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioDeVenta.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(107, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 53);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Código";
            // 
            // dtgProductos
            // 
            this.dtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductos.Location = new System.Drawing.Point(6, 19);
            this.dtgProductos.Name = "dtgProductos";
            this.dtgProductos.Size = new System.Drawing.Size(538, 401);
            this.dtgProductos.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(6, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(201, 36);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grpAcciones
            // 
            this.grpAcciones.Controls.Add(this.btnEliminar);
            this.grpAcciones.Controls.Add(this.btnActualizar);
            this.grpAcciones.Controls.Add(this.btnInsertar);
            this.grpAcciones.Controls.Add(this.btnBuscar);
            this.grpAcciones.Location = new System.Drawing.Point(12, 253);
            this.grpAcciones.Name = "grpAcciones";
            this.grpAcciones.Size = new System.Drawing.Size(220, 185);
            this.grpAcciones.TabIndex = 17;
            this.grpAcciones.TabStop = false;
            this.grpAcciones.Text = "Acciones";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(6, 145);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(201, 36);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(6, 103);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(201, 36);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(6, 61);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(201, 36);
            this.btnInsertar.TabIndex = 4;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // grpProductos
            // 
            this.grpProductos.Controls.Add(this.dtgProductos);
            this.grpProductos.Location = new System.Drawing.Point(238, 12);
            this.grpProductos.Name = "grpProductos";
            this.grpProductos.Size = new System.Drawing.Size(550, 426);
            this.grpProductos.TabIndex = 18;
            this.grpProductos.TabStop = false;
            this.grpProductos.Text = "Productos";
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpProductos);
            this.Controls.Add(this.grpAcciones);
            this.Controls.Add(this.grpProducto);
            this.Name = "Productos";
            this.Text = "Productos";
            this.grpProducto.ResumeLayout(false);
            this.grpProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).EndInit();
            this.grpAcciones.ResumeLayout(false);
            this.grpProductos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.GroupBox grpProducto;
        private System.Windows.Forms.DataGridView dtgProductos;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label lblPrecioDeCompra;
        private System.Windows.Forms.Label lblPrecioDeVenta;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtPrecioDeCompra;
        private System.Windows.Forms.TextBox txtPrecioDeVenta;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox grpAcciones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.GroupBox grpProductos;
    }
}