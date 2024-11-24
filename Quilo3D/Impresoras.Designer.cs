namespace Quilo3D
{
    partial class Impresoras
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregarImpresora = new System.Windows.Forms.Button();
            this.dgvListaImpresoras = new System.Windows.Forms.DataGridView();
            this.txtConsumoElectrico = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnMenuAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaImpresoras)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnModificar.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(106, 415);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(254, 53);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "Modificar Impresora";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEliminar.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(106, 490);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(254, 56);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar Impresora";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregarImpresora
            // 
            this.btnAgregarImpresora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregarImpresora.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarImpresora.Location = new System.Drawing.Point(106, 337);
            this.btnAgregarImpresora.Name = "btnAgregarImpresora";
            this.btnAgregarImpresora.Size = new System.Drawing.Size(254, 57);
            this.btnAgregarImpresora.TabIndex = 18;
            this.btnAgregarImpresora.Text = "Agregar Impresora";
            this.btnAgregarImpresora.UseVisualStyleBackColor = false;
            this.btnAgregarImpresora.Click += new System.EventHandler(this.btnAgregarImpresora_Click);
            // 
            // dgvListaImpresoras
            // 
            this.dgvListaImpresoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaImpresoras.Location = new System.Drawing.Point(418, 143);
            this.dgvListaImpresoras.Name = "dgvListaImpresoras";
            this.dgvListaImpresoras.Size = new System.Drawing.Size(745, 403);
            this.dgvListaImpresoras.TabIndex = 17;
            // 
            // txtConsumoElectrico
            // 
            this.txtConsumoElectrico.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsumoElectrico.Location = new System.Drawing.Point(72, 241);
            this.txtConsumoElectrico.Name = "txtConsumoElectrico";
            this.txtConsumoElectrico.Size = new System.Drawing.Size(323, 53);
            this.txtConsumoElectrico.TabIndex = 14;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(72, 143);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(323, 53);
            this.txtDescripcion.TabIndex = 11;
            // 
            // btnMenuAtras
            // 
            this.btnMenuAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuAtras.FlatAppearance.BorderSize = 0;
            this.btnMenuAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMenuAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMenuAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuAtras.Location = new System.Drawing.Point(1170, 12);
            this.btnMenuAtras.Name = "btnMenuAtras";
            this.btnMenuAtras.Size = new System.Drawing.Size(100, 106);
            this.btnMenuAtras.TabIndex = 21;
            this.btnMenuAtras.UseVisualStyleBackColor = false;
            this.btnMenuAtras.Click += new System.EventHandler(this.btnMenuAtras_Click);
            // 
            // Impresoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quilo3D.Properties.Resources.TemplateQUILO3D_Impresoras;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1293, 656);
            this.Controls.Add(this.btnMenuAtras);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregarImpresora);
            this.Controls.Add(this.dgvListaImpresoras);
            this.Controls.Add(this.txtConsumoElectrico);
            this.Controls.Add(this.txtDescripcion);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Impresoras";
            this.Text = "Impresoras";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaImpresoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregarImpresora;
        private System.Windows.Forms.DataGridView dgvListaImpresoras;
        private System.Windows.Forms.TextBox txtConsumoElectrico;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnMenuAtras;
    }
}