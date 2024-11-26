using System;
using System.Windows.Forms;
using System.Data;

public class DataGridViewConBotonEliminar : DataGridView
{
        public DataGridViewConBotonEliminar()
        {
            if (!this.DesignMode)
            {
                this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.AllowUserToAddRows = false;
                this.MultiSelect = false;
                AgregarBotonAccion();
        }
        }

        public void AsignarDatos(object datos)
        {
            this.DataSource = null;
            this.DataSource = datos;
        }

        private void AgregarBotonAccion()
        {
            if (!this.Columns.Contains("btnAccion"))
            {
                DataGridViewButtonColumn btnAccion = new DataGridViewButtonColumn
                {
                    HeaderText = "Acciones",
                    Text = "Eliminar",
                    Name = "btnEliminar",
                    UseColumnTextForButtonValue = true,
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        BackColor = System.Drawing.Color.IndianRed,
                        ForeColor = System.Drawing.Color.White,
                        Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold)
                    }
                };
                this.Columns.Add(btnAccion);
            }
        }

}


