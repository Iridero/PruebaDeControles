using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MisControles
{
    public partial class UC_Rating : UserControl
    {
        public event EventHandler<RatingEventArgs> RatingChanged;
        public UC_Rating()
        {
            InitializeComponent();
        }

        private void Star_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            int pos = (int)label.Tag;
            for (int i = 0; i < 5; i++)
            {
                stars[i].Text = "☆";
            }
            for (int i = 0; i < pos; i++)
            {
                stars[i].Text = "★";
            }

            RatingChanged?.Invoke(this, new RatingEventArgs { Rating = pos });

        }
        Label[] stars = new Label[5];
        private void UC_Rating_Load(object sender, EventArgs e)
        {
            stars[0] = lbl1;
            stars[1] = lbl2;
            stars[2] = lbl3;
            stars[3] = lbl4;
            stars[4] = lbl5;
            for (int i = 0; i < 5; i++)
            {
                stars[i].Tag = i+1;
            }
        }
        public class RatingEventArgs : EventArgs
        {
            public int Rating { get; set; }
        }
    }
}
