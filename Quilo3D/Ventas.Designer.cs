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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaVentas
            // 
            this.dgvListaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaVentas.Location = new System.Drawing.Point(163, 91);
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
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(163, 551);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(300, 39);
            this.comboBox1.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(488, 551);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 39);
            this.button1.TabIndex = 24;
            this.button1.Text = "Generar Reporte ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 656);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnMenuAtras);
            this.Controls.Add(this.dgvListaVentas);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaVentas;
        private System.Windows.Forms.Button btnMenuAtras;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}