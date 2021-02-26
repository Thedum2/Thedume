using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thedume
{
    public partial class Loading : Form
    {
      
        public Loading()
        {
            InitializeComponent();
        }
        private void Loading_Load(object sender, EventArgs e)
        {
            label1.Text = "로딩중";
            timer4.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {


            label1.Text += ".";

            if (label1.Text == "로딩중...")
            {
                label1.Text = "로딩중";
                this.Dispose();
            }
        }
    }
}
