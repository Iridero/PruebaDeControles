using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaDeControles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(uC_EstadoCivil1.Valor);
        }

        private void uC_Rating1_RatingChanged(object sender, EventArgs e)
        {
            //txtCalificacion.Text = ((MisControles.UC_Rating.RatingEventArgs)e).Rating.ToString();
        }

        private void uC_Rating1_RatingChanged(object sender, MisControles.UC_Rating.RatingEventArgs e)
        {
            txtCalificacion.Text = e.Rating.ToString();
        }
    }
}
