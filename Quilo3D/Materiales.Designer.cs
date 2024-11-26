namespace Quilo3D
{
    partial class Materiales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnModificarMaterial = new System.Windows.Forms.Button();
            this.btnAgregarMaterial = new System.Windows.Forms.Button();
            this.cmbTipoMaterial = new System.Windows.Forms.ComboBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.btnGenerarXml = new System.Windows.Forms.Button();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            this.btnFiltrarLista = new System.Windows.Forms.Button();
            this.btnMenuAtras = new System.Windows.Forms.Button();
            this.dgvListaMateriales = new DataGridViewConBotonEliminar();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtPesoKg = new Quilo3D.ValidatingTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMateriales)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificarMaterial
            // 
            this.btnModificarMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnModificarMaterial.Font = new System.Drawing.Font("Impact", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMaterial.Location = new System.Drawing.Point(106, 535);
            this.btnModificarMaterial.Name = "btnModificarMaterial";
            this.btnModificarMaterial.Size = new System.Drawing.Size(254, 57);
            this.btnModificarMaterial.TabIndex = 20;
            this.btnModificarMaterial.Text = "Modificar Material";
            this.btnModificarMaterial.UseVisualStyleBackColor = false;
            this.btnModificarMaterial.Click += new System.EventHandler(this.btnModificarMaterial_Click);
            // 
            // btnAgregarMaterial
            // 
            this.btnAgregarMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregarMaterial.Font = new System.Drawing.Font("Impact", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMaterial.Location = new System.Drawing.Point(106, 426);
            this.btnAgregarMaterial.Name = "btnAgregarMaterial";
            this.btnAgregarMaterial.Size = new System.Drawing.Size(254, 57);
            this.btnAgregarMaterial.TabIndex = 18;
            this.btnAgregarMaterial.Text = "Agregar Material";
            this.btnAgregarMaterial.UseVisualStyleBackColor = false;
            this.btnAgregarMaterial.Click += new System.EventHandler(this.btnAgregarMaterial_Click);
            // 
            // cmbTipoMaterial
            // 
            this.cmbTipoMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoMaterial.FormattingEnabled = true;
            this.cmbTipoMaterial.Items.AddRange(new object[] {
            "PLA",
            "PLA+",
            "PETG",
            "ABS",
            "PLA FLEX"});
            this.cmbTipoMaterial.Location = new System.Drawing.Point(73, 336);
            this.cmbTipoMaterial.Name = "cmbTipoMaterial";
            this.cmbTipoMaterial.Size = new System.Drawing.Size(323, 46);
            this.cmbTipoMaterial.TabIndex = 16;
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Location = new System.Drawing.Point(73, 143);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(323, 53);
            this.txtColor.TabIndex = 11;
            // 
            // btnGenerarXml
            // 
            this.btnGenerarXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarXml.Location = new System.Drawing.Point(993, 589);
            this.btnGenerarXml.Name = "btnGenerarXml";
            this.btnGenerarXml.Size = new System.Drawing.Size(144, 36);
            this.btnGenerarXml.TabIndex = 25;
            this.btnGenerarXml.Text = "Exportar XML";
            this.btnGenerarXml.UseVisualStyleBackColor = true;
            this.btnGenerarXml.Click += new System.EventHandler(this.btnGenerarXml_Click);
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLimpiarFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(993, 101);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(144, 36);
            this.btnLimpiarFiltro.TabIndex = 31;
            this.btnLimpiarFiltro.Text = "Limpiar filtro";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltro.Click += new System.EventHandler(this.btnLimpiarFiltro_Click);
            // 
            // btnFiltrarLista
            // 
            this.btnFiltrarLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnFiltrarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarLista.Location = new System.Drawing.Point(843, 101);
            this.btnFiltrarLista.Name = "btnFiltrarLista";
            this.btnFiltrarLista.Size = new System.Drawing.Size(144, 36);
            this.btnFiltrarLista.TabIndex = 32;
            this.btnFiltrarLista.Text = "Filtrar";
            this.btnFiltrarLista.UseVisualStyleBackColor = false;
            this.btnFiltrarLista.Click += new System.EventHandler(this.btnFiltrarLista_Click);
            // 
            // btnMenuAtras
            // 
            this.btnMenuAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuAtras.FlatAppearance.BorderSize = 0;
            this.btnMenuAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMenuAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMenuAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuAtras.Location = new System.Drawing.Point(1168, 12);
            this.btnMenuAtras.Name = "btnMenuAtras";
            this.btnMenuAtras.Size = new System.Drawing.Size(100, 106);
            this.btnMenuAtras.TabIndex = 33;
            this.btnMenuAtras.UseVisualStyleBackColor = false;
            this.btnMenuAtras.Click += new System.EventHandler(this.btnMenuAtras_Click_1);
            // 
            // dgvListaMateriales
            // 
            this.dgvListaMateriales.AllowUserToAddRows = false;
            this.dgvListaMateriales.AllowUserToDeleteRows = false;
            this.dgvListaMateriales.AllowUserToOrderColumns = true;
            this.dgvListaMateriales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaMateriales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn1});
            this.dgvListaMateriales.Location = new System.Drawing.Point(420, 143);
            this.dgvListaMateriales.MultiSelect = false;
            this.dgvListaMateriales.Name = "dgvListaMateriales";
            this.dgvListaMateriales.ReadOnly = true;
            this.dgvListaMateriales.Size = new System.Drawing.Size(717, 437);
            this.dgvListaMateriales.TabIndex = 34;
            this.dgvListaMateriales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaMateriales_CellClick);
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewButtonColumn1.HeaderText = "Acciones";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Text = "Eliminar";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // txtPesoKg
            // 
            this.txtPesoKg.BackColor = System.Drawing.Color.LightCoral;
            this.txtPesoKg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesoKg.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoKg.Location = new System.Drawing.Point(73, 241);
            this.txtPesoKg.Name = "txtPesoKg";
            this.txtPesoKg.Size = new System.Drawing.Size(323, 53);
            this.txtPesoKg.TabIndex = 35;
            this.txtPesoKg.ValidationPattern = "^\\d+$";
            // 
            // Materiales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quilo3D.Properties.Resources.TemplateQUILO3D_Materiales;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1293, 656);
            this.Controls.Add(this.txtPesoKg);
            this.Controls.Add(this.dgvListaMateriales);
            this.Controls.Add(this.btnMenuAtras);
            this.Controls.Add(this.btnFiltrarLista);
            this.Controls.Add(this.btnLimpiarFiltro);
            this.Controls.Add(this.btnGenerarXml);
            this.Controls.Add(this.btnModificarMaterial);
            this.Controls.Add(this.btnAgregarMaterial);
            this.Controls.Add(this.cmbTipoMaterial);
            this.Controls.Add(this.txtColor);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Materiales";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Materiales";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMateriales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificarMaterial;
        private System.Windows.Forms.Button btnAgregarMaterial;
        private System.Windows.Forms.ComboBox cmbTipoMaterial;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Button btnGenerarXml;
        private System.Windows.Forms.Button btnLimpiarFiltro;
        private System.Windows.Forms.Button btnFiltrarLista;
        private System.Windows.Forms.Button btnMenuAtras;
        private DataGridViewConBotonEliminar dgvListaMateriales;
        private ValidatingTextBox txtPesoKg;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
    }
}