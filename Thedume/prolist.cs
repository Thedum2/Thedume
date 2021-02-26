using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Thedume
{
    public partial class prolist : Form
    {
        public prolist()
        {
            InitializeComponent();
        }
        public static string userid;
        private void loaddel(string idid)
        {
                MySqlConnection conn;
                string strconn = "Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8";
                conn = new MySqlConnection(strconn);
                conn.Open();         

                try
                {
                    string strSelect2 = "UPDATE user_account set lanpro" + idid + "= '' where id=" + "\'" + userid + "\'";
                    MySqlCommand cmd2 = new MySqlCommand(strSelect2, conn);

                    if (cmd2.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("목록에서 삭제되었습니다!");
                    }


                }
                catch
                {
                    MessageBox.Show("오류발생! 재시작 바람!");
                }

            
        }
        private void load(string idid)
        {
            string loadname;

            PictureBox[] pic = new PictureBox[] { pro1, pro2, pro3, pro4, pro5, pro6, pro7, pro8, pro9, pro10, pro11, pro12, pro13, pro14, pro15 };
            Button[] btn = new Button[] { nm1, nm2, nm3, nm4, nm5, nm6, nm7, nm8, nm9, nm10, nm11, nm12, nm13, nm14, nm15 };
            MySqlConnection conn;
            string strconn = "Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8";
            conn = new MySqlConnection(strconn);
            conn.Open();

            string strSelect1 = "Select * from user_account where id=" + "\'" + idid + "\'";
            MySqlCommand cmd1 = new MySqlCommand(strSelect1, conn);
            MySqlDataReader rdr1 = cmd1.ExecuteReader();
            rdr1.Read();

            for (int i = 1; i <= 15; i++)
            {
                if (rdr1["lanpro" + i].ToString() != "")
                {
                    loadname = rdr1["lanpro" + i].ToString();
                    Icon icn = Icon.ExtractAssociatedIcon(loadname); //Image Save Image img = Image.FromHbitmap(icn.ToBitmap().GetHbitmap());
                    pic[i - 1].Image = Image.FromHbitmap(icn.ToBitmap().GetHbitmap());
                    btn[i - 1].Text = loadname;
                }
            }
        }
        private void prolist_Load(object sender, EventArgs e)
        {
            pro1.Image = null;
            pro2.Image = null;
            pro3.Image = null;
            pro4.Image = null;
            pro5.Image = null;
            pro6.Image = null;
            pro7.Image = null;
            pro8.Image = null;
            pro9.Image = null;
            pro10.Image = null;
            pro11.Image = null;
            pro12.Image = null;
            pro13.Image = null;
            pro14.Image = null;
            pro15.Image = null;
            load(userid);

        }

        private void infoprodel1_Click(object sender, EventArgs e)
        {
            loaddel("1");
            nm1.Text = "Program_engname";
            pro1.Image = null;


        }

        private void button8_Click(object sender, EventArgs e)
        {
            loaddel("2");
            nm2.Text = "Program_engname";
            pro2.Image = null;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            loaddel("3"); 
            nm3.Text = "Program_engname";
            pro3.Image = null;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            loaddel("4");
            nm4.Text = "Program_engname";
            pro4.Image = null;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            loaddel("5");
            nm5.Text = "Program_engname";
            pro5.Image = null;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            loaddel("6");
            nm6.Text = "Program_engname";
            pro6.Image = null;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            loaddel("7");
            nm7.Text = "Program_engname";
            pro7.Image = null;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            loaddel("8");
            nm8.Text = "Program_engname";
            pro8.Image = null;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            loaddel("9");
            nm9.Text = "Program_engname";
            pro9.Image = null;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            loaddel("10");
            nm10.Text = "Program_engname";
            pro10.Image = null;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            loaddel("11");
            nm11.Text = "Program_engname";
            pro11.Image = null;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            loaddel("12");
            nm12.Text = "Program_engname";
            pro12.Image = null;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            loaddel("13");
            nm13.Text = "Program_engname";
            pro13.Image = null;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            loaddel("14");
            nm14.Text = "Program_engname";
            pro14.Image = null;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            loaddel("15");

            nm15.Text = "Program_engname";
            pro15.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("적용하겠습니다. 프로그램이 재시작됩니다.");
            Application.Restart();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            load(userid);
        }
    }
}
