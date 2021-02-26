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
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }
        public static string userid;
        public static string usernickname;
        private void Setting_Load(object sender, EventArgs e)
        {
            label1.Text = userid;
            label2.Text = usernickname;
            prolist.userid = userid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            prolist prlist = new prolist();
            prlist.StartPosition = FormStartPosition.CenterParent;
            prlist.ShowDialog();
        }

        private void Setting_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
