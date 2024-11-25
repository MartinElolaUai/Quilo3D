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
            this.txtDescripcionProducto = new System.Windows.Forms.TextBox();
            this.txtPesoProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.cmbImpresorasDisponibles = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnProcesarPedido = new System.Windows.Forms.Button();
            this.btnGestorImpresora = new System.Windows.Forms.Button();
            this.btnGestorMaterial = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtTiempoImpresion = new System.Windows.Forms.TextBox();
            this.txtCostoImpresion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorImpresion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaProductos
            // 
            this.dgvListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProductos.Location = new System.Drawing.Point(268, 96);
            this.dgvListaProductos.Name = "dgvListaProductos";
            this.dgvListaProductos.Size = new System.Drawing.Size(499, 371);
            this.dgvListaProductos.TabIndex = 0;
            // 
            // txtDescripcionProducto
            // 
            this.txtDescripcionProducto.Location = new System.Drawing.Point(15, 112);
            this.txtDescripcionProducto.Name = "txtDescripcionProducto";
            this.txtDescripcionProducto.Size = new System.Drawing.Size(172, 20);
            this.txtDescripcionProducto.TabIndex = 2;
            // 
            // txtPesoProducto
            // 
            this.txtPesoProducto.Location = new System.Drawing.Point(15, 149);
            this.txtPesoProducto.Name = "txtPesoProducto";
            this.txtPesoProducto.Size = new System.Drawing.Size(172, 20);
            this.txtPesoProducto.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Peso (kg)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Material";
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(15, 201);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(172, 21);
            this.cmbMaterial.TabIndex = 10;
            // 
            // cmbImpresorasDisponibles
            // 
            this.cmbImpresorasDisponibles.FormattingEnabled = true;
            this.cmbImpresorasDisponibles.Location = new System.Drawing.Point(15, 250);
            this.cmbImpresorasDisponibles.Name = "cmbImpresorasDisponibles";
            this.cmbImpresorasDisponibles.Size = new System.Drawing.Size(172, 21);
            this.cmbImpresorasDisponibles.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Seleccionar Impresora";
            // 
            // btnProcesarPedido
            // 
            this.btnProcesarPedido.Location = new System.Drawing.Point(15, 447);
            this.btnProcesarPedido.Name = "btnProcesarPedido";
            this.btnProcesarPedido.Size = new System.Drawing.Size(172, 32);
            this.btnProcesarPedido.TabIndex = 13;
            this.btnProcesarPedido.Text = "Procesar pedido";
            this.btnProcesarPedido.UseVisualStyleBackColor = true;
            this.btnProcesarPedido.Click += new System.EventHandler(this.btnProcesarPedido_Click_1);
            // 
            // btnGestorImpresora
            // 
            this.btnGestorImpresora.Location = new System.Drawing.Point(96, 12);
            this.btnGestorImpresora.Name = "btnGestorImpresora";
            this.btnGestorImpresora.Size = new System.Drawing.Size(201, 30);
            this.btnGestorImpresora.TabIndex = 14;
            this.btnGestorImpresora.Text = "Gestor Impresoras";
            this.btnGestorImpresora.UseVisualStyleBackColor = true;
            this.btnGestorImpresora.Click += new System.EventHandler(this.btnGestorImpresora_Click);
            // 
            // btnGestorMaterial
            // 
            this.btnGestorMaterial.Location = new System.Drawing.Point(316, 12);
            this.btnGestorMaterial.Name = "btnGestorMaterial";
            this.btnGestorMaterial.Size = new System.Drawing.Size(201, 30);
            this.btnGestorMaterial.TabIndex = 15;
            this.btnGestorMaterial.Text = "Gestor Material";
            this.btnGestorMaterial.UseVisualStyleBackColor = true;
            this.btnGestorMaterial.Click += new System.EventHandler(this.btnGestorMaterial_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(539, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(201, 30);
            this.button4.TabIndex = 16;
            this.button4.Text = "Gestor Cliente";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtTiempoImpresion
            // 
            this.txtTiempoImpresion.Enabled = false;
            this.txtTiempoImpresion.Location = new System.Drawing.Point(15, 398);
            this.txtTiempoImpresion.Name = "txtTiempoImpresion";
            this.txtTiempoImpresion.Size = new System.Drawing.Size(172, 20);
            this.txtTiempoImpresion.TabIndex = 17;
            // 
            // txtCostoImpresion
            // 
            this.txtCostoImpresion.Enabled = false;
            this.txtCostoImpresion.Location = new System.Drawing.Point(15, 311);
            this.txtCostoImpresion.Name = "txtCostoImpresion";
            this.txtCostoImpresion.Size = new System.Drawing.Size(172, 20);
            this.txtCostoImpresion.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Costo impresión";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Tiempo de impresión";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Valor impresión";
            // 
            // txtValorImpresion
            // 
            this.txtValorImpresion.Enabled = false;
            this.txtValorImpresion.Location = new System.Drawing.Point(15, 350);
            this.txtValorImpresion.Name = "txtValorImpresion";
            this.txtValorImpresion.Size = new System.Drawing.Size(172, 20);
            this.txtValorImpresion.TabIndex = 21;
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 501);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtValorImpresion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCostoImpresion);
            this.Controls.Add(this.txtTiempoImpresion);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnGestorMaterial);
            this.Controls.Add(this.btnGestorImpresora);
            this.Controls.Add(this.btnProcesarPedido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbImpresorasDisponibles);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesoProducto);
            this.Controls.Add(this.txtDescripcionProducto);
            this.Controls.Add(this.dgvListaProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Pedidos";
            this.Text = "QUILO3D";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaProductos;
        private System.Windows.Forms.TextBox txtDescripcionProducto;
        private System.Windows.Forms.TextBox txtPesoProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.ComboBox cmbImpresorasDisponibles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnProcesarPedido;
        private System.Windows.Forms.Button btnGestorImpresora;
        private System.Windows.Forms.Button btnGestorMaterial;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtTiempoImpresion;
        private System.Windows.Forms.TextBox txtCostoImpresion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValorImpresion;
    }
}