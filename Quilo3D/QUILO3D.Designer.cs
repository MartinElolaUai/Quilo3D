﻿namespace Quilo3D
{
    partial class QUILO3D
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(295, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(475, 371);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(15, 149);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(172, 20);
            this.textBox4.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Peso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Material";
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(15, 187);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(172, 21);
            this.cmbMaterial.TabIndex = 10;
            // 
            // cmbImpresorasDisponibles
            // 
            this.cmbImpresorasDisponibles.FormattingEnabled = true;
            this.cmbImpresorasDisponibles.Location = new System.Drawing.Point(15, 408);
            this.cmbImpresorasDisponibles.Name = "cmbImpresorasDisponibles";
            this.cmbImpresorasDisponibles.Size = new System.Drawing.Size(172, 21);
            this.cmbImpresorasDisponibles.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 390);
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
            // 
            // btnGestorImpresora
            // 
            this.btnGestorImpresora.Location = new System.Drawing.Point(12, 12);
            this.btnGestorImpresora.Name = "btnGestorImpresora";
            this.btnGestorImpresora.Size = new System.Drawing.Size(201, 30);
            this.btnGestorImpresora.TabIndex = 14;
            this.btnGestorImpresora.Text = "Gestor Impresoras";
            this.btnGestorImpresora.UseVisualStyleBackColor = true;
            this.btnGestorImpresora.Click += new System.EventHandler(this.btnGestorImpresora_Click);
            // 
            // btnGestorMaterial
            // 
            this.btnGestorMaterial.Location = new System.Drawing.Point(232, 12);
            this.btnGestorMaterial.Name = "btnGestorMaterial";
            this.btnGestorMaterial.Size = new System.Drawing.Size(201, 30);
            this.btnGestorMaterial.TabIndex = 15;
            this.btnGestorMaterial.Text = "Gestor Material";
            this.btnGestorMaterial.UseVisualStyleBackColor = true;
            this.btnGestorMaterial.Click += new System.EventHandler(this.btnGestorMaterial_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(455, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(201, 30);
            this.button4.TabIndex = 16;
            this.button4.Text = "Gestor Cliente";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // QUILO3D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 501);
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
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "QUILO3D";
            this.Text = "QUILO3D";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
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
    }
}