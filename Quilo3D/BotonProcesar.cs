using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quilo3D
{
    public partial class BotonProcesar : Button
    {

        private string textoOriginal;
        private bool enProceso;

        public BotonProcesar()
        {
            InitializeComponent();
            this.Text = "Procesar";
            this.BackColor = Color.LightBlue;
            this.FlatStyle = FlatStyle.Flat;
            this.Font = new Font("Impact", 25F, FontStyle.Bold);
        }

        public bool EnProceso
        {
            get => enProceso;
            private set
            {
                enProceso = value;
                this.Enabled = !enProceso; 
            }
        }

        public async void StartLoading(string textoCarga = "Cargando...")
        {
            if (EnProceso) return;

            textoOriginal = this.Text;
            this.Text = textoCarga;

            EnProceso = true;

            Thread.Sleep(1500);

            StopLoading();
        }

        public void StopLoading(string textoExito = "Completado", bool exitoso = true)
        {
            if (!EnProceso) return;

            this.Text = exitoso ? textoExito : "Error";
            this.BackColor = exitoso ? Color.LightGreen : Color.IndianRed;

            Task.Delay(2000).ContinueWith(t =>
            {
                this.Invoke((Action)(() =>
                {
                    this.Text = textoOriginal;
                    this.BackColor = Color.LightBlue;
                    EnProceso = false;
                }));
            });
        }

    }
}
