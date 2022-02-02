using System;
using System.Windows.Forms;

namespace MisControles
{
    public enum OrientacionesEstado { Horizontal, Vertical }
    public partial class UC_EstadoCivil : UserControl
    {
        private OrientacionesEstado orientacion;

        public OrientacionesEstado Orientacion
        {
            get { return orientacion; }
            set
            {
                if (value==OrientacionesEstado.Horizontal)
                {
                    flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
                }
                else
                {
                    flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
                }
                orientacion = value;
            }
        }

        public event EventHandler EstadoCambiado;
        public string Valor { get; private set; }
        public UC_EstadoCivil()
        {
            InitializeComponent();
        }

        private void EstadoChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            if (radio.Checked)
            {
                Valor = radio.Text;
                EstadoCambiado?.Invoke(this, null);
            }
        }
    }
}
