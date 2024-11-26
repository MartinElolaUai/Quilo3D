using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quilo3D
{
    public partial class DateRange : UserControl
    {

        private DateTimePicker dtpInicio;
        private DateTimePicker dtpFin;
        private Label lblInicio;
        private Label lblFin;
        private Button btnFiltrar;

        public event EventHandler FiltrarClick;

        public DateRange()
        {
            InitializeComponent();

            lblInicio = new Label { Text = "Inicio:", AutoSize = true, Top = 10, Left = 10 };
            dtpInicio = new DateTimePicker { Top = 10, Left = 60, Width = 120 };

            lblFin = new Label { Text = "Fin:", AutoSize = true, Top = 40, Left = 10 };
            dtpFin = new DateTimePicker { Top = 40, Left = 60, Width = 120 };

            btnFiltrar = new Button { Text = "Filtrar", Top = 70, Left = 10, Width = 170 };

            btnFiltrar.Click += BtnFiltrar_Click;

            this.Controls.Add(lblInicio);
            this.Controls.Add(dtpInicio);
            this.Controls.Add(lblFin);
            this.Controls.Add(dtpFin);
            this.Controls.Add(btnFiltrar);

            this.Height = 110;
            this.Width = 200;
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            FiltrarClick?.Invoke(this, EventArgs.Empty);
        }

        public DateTime FechaInicio => dtpInicio.Value;
        public DateTime FechaFin => dtpFin.Value;

    }


}
