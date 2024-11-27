namespace Quilo3D
{
    partial class Pedidos
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
            this.dgvListaProductos = new System.Windows.Forms.DataGridView();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.cmbImpresorasDisponibles = new System.Windows.Forms.ComboBox();
            this.txtTiempoImpresion = new System.Windows.Forms.TextBox();
            this.txtCostoImpresion = new System.Windows.Forms.TextBox();
            this.txtValorImpresion = new System.Windows.Forms.TextBox();
            this.btnMenuAtras = new System.Windows.Forms.Button();
            this.cmbSeleccionarCliente = new System.Windows.Forms.ComboBox();
            this.txtDescripcionVenta = new System.Windows.Forms.TextBox();
            this.btnGenerarXml = new System.Windows.Forms.Button();
            this.txtPesoProducto = new Quilo3D.ValidatingTextBox();
            this.btnProcesarPedido = new Quilo3D.BotonProcesar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaProductos
            // 
            this.dgvListaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProductos.Location = new System.Drawing.Point(464, 119);
            this.dgvListaProductos.Name = "dgvListaProductos";
            this.dgvListaProductos.Size = new System.Drawing.Size(745, 381);
            this.dgvListaProductos.TabIndex = 0;
            this.dgvListaProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaProductos_CellClick);
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(73, 383);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(323, 39);
            this.cmbMaterial.TabIndex = 10;
            // 
            // cmbImpresorasDisponibles
            // 
            this.cmbImpresorasDisponibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImpresorasDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbImpresorasDisponibles.FormattingEnabled = true;
            this.cmbImpresorasDisponibles.Location = new System.Drawing.Point(73, 461);
            this.cmbImpresorasDisponibles.Name = "cmbImpresorasDisponibles";
            this.cmbImpresorasDisponibles.Size = new System.Drawing.Size(320, 39);
            this.cmbImpresorasDisponibles.TabIndex = 11;
            // 
            // txtTiempoImpresion
            // 
            this.txtTiempoImpresion.Enabled = false;
            this.txtTiempoImpresion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempoImpresion.Location = new System.Drawing.Point(464, 579);
            this.txtTiempoImpresion.Name = "txtTiempoImpresion";
            this.txtTiempoImpresion.Size = new System.Drawing.Size(211, 30);
            this.txtTiempoImpresion.TabIndex = 17;
            // 
            // txtCostoImpresion
            // 
            this.txtCostoImpresion.Enabled = false;
            this.txtCostoImpresion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoImpresion.Location = new System.Drawing.Point(997, 579);
            this.txtCostoImpresion.Name = "txtCostoImpresion";
            this.txtCostoImpresion.Size = new System.Drawing.Size(212, 30);
            this.txtCostoImpresion.TabIndex = 18;
            // 
            // txtValorImpresion
            // 
            this.txtValorImpresion.Enabled = false;
            this.txtValorImpresion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorImpresion.Location = new System.Drawing.Point(731, 579);
            this.txtValorImpresion.Name = "txtValorImpresion";
            this.txtValorImpresion.Size = new System.Drawing.Size(211, 30);
            this.txtValorImpresion.TabIndex = 21;
            // 
            // btnMenuAtras
            // 
            this.btnMenuAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuAtras.FlatAppearance.BorderSize = 0;
            this.btnMenuAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMenuAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMenuAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuAtras.Location = new System.Drawing.Point(1181, 12);
            this.btnMenuAtras.Name = "btnMenuAtras";
            this.btnMenuAtras.Size = new System.Drawing.Size(100, 106);
            this.btnMenuAtras.TabIndex = 23;
            this.btnMenuAtras.UseVisualStyleBackColor = false;
            this.btnMenuAtras.Click += new System.EventHandler(this.btnMenuAtras_Click);
            // 
            // cmbSeleccionarCliente
            // 
            this.cmbSeleccionarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSeleccionarCliente.FormattingEnabled = true;
            this.cmbSeleccionarCliente.Location = new System.Drawing.Point(73, 119);
            this.cmbSeleccionarCliente.Name = "cmbSeleccionarCliente";
            this.cmbSeleccionarCliente.Size = new System.Drawing.Size(320, 39);
            this.cmbSeleccionarCliente.TabIndex = 24;
            // 
            // txtDescripcionVenta
            // 
            this.txtDescripcionVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionVenta.Location = new System.Drawing.Point(73, 198);
            this.txtDescripcionVenta.Name = "txtDescripcionVenta";
            this.txtDescripcionVenta.Size = new System.Drawing.Size(323, 53);
            this.txtDescripcionVenta.TabIndex = 26;
            // 
            // btnGenerarXml
            // 
            this.btnGenerarXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarXml.Location = new System.Drawing.Point(1065, 506);
            this.btnGenerarXml.Name = "btnGenerarXml";
            this.btnGenerarXml.Size = new System.Drawing.Size(144, 36);
            this.btnGenerarXml.TabIndex = 27;
            this.btnGenerarXml.Text = "Exportar XML";
            this.btnGenerarXml.UseVisualStyleBackColor = true;
            this.btnGenerarXml.Click += new System.EventHandler(this.btnGenerarXml_Click);
            // 
            // txtPesoProducto
            // 
            this.txtPesoProducto.BackColor = System.Drawing.Color.LightCoral;
            this.txtPesoProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoProducto.Location = new System.Drawing.Point(73, 291);
            this.txtPesoProducto.Name = "txtPesoProducto";
            this.txtPesoProducto.Size = new System.Drawing.Size(320, 53);
            this.txtPesoProducto.TabIndex = 29;
            this.txtPesoProducto.ValidationPattern = "^\\d+$";
            // 
            // btnProcesarPedido
            // 
            this.btnProcesarPedido.BackColor = System.Drawing.Color.LightBlue;
            this.btnProcesarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesarPedido.Font = new System.Drawing.Font("Impact", 25F, System.Drawing.FontStyle.Bold);
            this.btnProcesarPedido.Location = new System.Drawing.Point(73, 552);
            this.btnProcesarPedido.Name = "btnProcesarPedido";
            this.btnProcesarPedido.Size = new System.Drawing.Size(320, 57);
            this.btnProcesarPedido.TabIndex = 28;
            this.btnProcesarPedido.Text = "Procesar pedido";
            this.btnProcesarPedido.UseVisualStyleBackColor = false;
            this.btnProcesarPedido.Click += new System.EventHandler(this.btnProcesarPedido_Click);
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quilo3D.Properties.Resources.TrabajoQUILO3D_Pedidos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1293, 656);
            this.Controls.Add(this.txtPesoProducto);
            this.Controls.Add(this.btnProcesarPedido);
            this.Controls.Add(this.btnGenerarXml);
            this.Controls.Add(this.txtDescripcionVenta);
            this.Controls.Add(this.cmbSeleccionarCliente);
            this.Controls.Add(this.btnMenuAtras);
            this.Controls.Add(this.txtValorImpresion);
            this.Controls.Add(this.txtCostoImpresion);
            this.Controls.Add(this.txtTiempoImpresion);
            this.Controls.Add(this.cmbImpresorasDisponibles);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.dgvListaProductos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Pedidos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUILO3D";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaProductos;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.ComboBox cmbImpresorasDisponibles;
        private System.Windows.Forms.TextBox txtTiempoImpresion;
        private System.Windows.Forms.TextBox txtCostoImpresion;
        private System.Windows.Forms.TextBox txtValorImpresion;
        private System.Windows.Forms.Button btnMenuAtras;
        private System.Windows.Forms.ComboBox cmbSeleccionarCliente;
        private System.Windows.Forms.TextBox txtDescripcionVenta;
        private System.Windows.Forms.Button btnGenerarXml;
        private BotonProcesar btnProcesarPedido;
        private ValidatingTextBox txtPesoProducto;
    }
}