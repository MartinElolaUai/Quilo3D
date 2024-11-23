namespace Quilo3D
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.txtContraseniaUsuario = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblContraseniaUsuario = new System.Windows.Forms.Label();
            this.logoQuilo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoQuilo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnIniciarSesion.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.Location = new System.Drawing.Point(68, 254);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(212, 33);
            this.btnIniciarSesion.TabIndex = 0;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // txtContraseniaUsuario
            // 
            this.txtContraseniaUsuario.Location = new System.Drawing.Point(69, 210);
            this.txtContraseniaUsuario.Name = "txtContraseniaUsuario";
            this.txtContraseniaUsuario.Size = new System.Drawing.Size(211, 20);
            this.txtContraseniaUsuario.TabIndex = 1;
            this.txtContraseniaUsuario.UseSystemPasswordChar = true;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(70, 160);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(211, 20);
            this.txtNombreUsuario.TabIndex = 2;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreUsuario.Location = new System.Drawing.Point(72, 142);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(45, 15);
            this.lblNombreUsuario.TabIndex = 3;
            this.lblNombreUsuario.Text = "Usuario";
            // 
            // lblContraseniaUsuario
            // 
            this.lblContraseniaUsuario.AutoSize = true;
            this.lblContraseniaUsuario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblContraseniaUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblContraseniaUsuario.Location = new System.Drawing.Point(72, 192);
            this.lblContraseniaUsuario.Name = "lblContraseniaUsuario";
            this.lblContraseniaUsuario.Size = new System.Drawing.Size(63, 15);
            this.lblContraseniaUsuario.TabIndex = 4;
            this.lblContraseniaUsuario.Text = "Contraseña";
            // 
            // logoQuilo
            // 
            this.logoQuilo.Image = global::Quilo3D.Properties.Resources._1;
            this.logoQuilo.InitialImage = null;
            this.logoQuilo.Location = new System.Drawing.Point(85, 2);
            this.logoQuilo.Name = "logoQuilo";
            this.logoQuilo.Size = new System.Drawing.Size(180, 127);
            this.logoQuilo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoQuilo.TabIndex = 5;
            this.logoQuilo.TabStop = false;
            this.logoQuilo.Click += new System.EventHandler(this.logoQuilo_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(353, 323);
            this.Controls.Add(this.logoQuilo);
            this.Controls.Add(this.lblContraseniaUsuario);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.txtContraseniaUsuario);
            this.Controls.Add(this.btnIniciarSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoQuilo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.TextBox txtContraseniaUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblContraseniaUsuario;
        private System.Windows.Forms.PictureBox logoQuilo;
    }
}

