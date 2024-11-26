namespace Quilo3D
{
    partial class Ventas
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
            this.dgvListaVentas = new System.Windows.Forms.DataGridView();
            this.btnMenuAtras = new System.Windows.Forms.Button();
            this.cmbTipoReporte = new System.Windows.Forms.ComboBox();
            this.btnGenerarXml = new System.Windows.Forms.Button();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaVentas
            // 
            this.dgvListaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaVentas.Location = new System.Drawing.Point(46, 54);
            this.dgvListaVentas.Name = "dgvListaVentas";
            this.dgvListaVentas.Size = new System.Drawing.Size(717, 437);
            this.dgvListaVentas.TabIndex = 0;
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
            this.btnMenuAtras.TabIndex = 22;
            this.btnMenuAtras.UseVisualStyleBackColor = false;
            this.btnMenuAtras.Click += new System.EventHandler(this.btnMenuAtras_Click);
            // 
            // cmbTipoReporte
            // 
            this.cmbTipoReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoReporte.FormattingEnabled = true;
            this.cmbTipoReporte.Items.AddRange(new object[] {
            "(1) Producto más vendido",
            "(2) Cliente con más compras",
            "(3) Productos de más de $10000",
            "(4) Productos hechos con Ender 3 NEO",
            "(5) Productos vendidos por fecha "});
            this.cmbTipoReporte.Location = new System.Drawing.Point(46, 514);
            this.cmbTipoReporte.Name = "cmbTipoReporte";
            this.cmbTipoReporte.Size = new System.Drawing.Size(717, 39);
            this.cmbTipoReporte.TabIndex = 23;
            // 
            // btnGenerarXml
            // 
            this.btnGenerarXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarXml.Location = new System.Drawing.Point(46, 585);
            this.btnGenerarXml.Name = "btnGenerarXml";
            this.btnGenerarXml.Size = new System.Drawing.Size(234, 39);
            this.btnGenerarXml.TabIndex = 24;
            this.btnGenerarXml.Text = "Exportar XML";
            this.btnGenerarXml.UseVisualStyleBackColor = true;
            this.btnGenerarXml.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Location = new System.Drawing.Point(46, 559);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaVenta.TabIndex = 25;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 656);
            this.Controls.Add(this.dtpFechaVenta);
            this.Controls.Add(this.btnGenerarXml);
            this.Controls.Add(this.cmbTipoReporte);
            this.Controls.Add(this.btnMenuAtras);
            this.Controls.Add(this.dgvListaVentas);
            this.Name = "Ventas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaVentas;
        private System.Windows.Forms.Button btnMenuAtras;
        private System.Windows.Forms.ComboBox cmbTipoReporte;
        private System.Windows.Forms.Button btnGenerarXml;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
    }
}