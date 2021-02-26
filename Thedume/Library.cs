using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using MySql.Data.MySqlClient;

namespace Thedume
{
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 0, 0));// 동그랗게 만들기

        }
        Setting set = new Setting();
        string fname,filename;

        public static string userid, usernickname;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]//폼 동그랗게 만들기
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect//폼 동그랗게 만들기
                                         , int nTopRect
                                         , int nRightRect
                                         , int nBottomRect
                                         , int nWidthEllipse
                                         , int nHeightEllipse);


        private void doublesl(string name)
        {
            filename = "";
            string[] result = name.Split(new string[] { "\\" }, StringSplitOptions.None);
            for (int i = 0; i < result.Length; i++)
            {
                filename += result[i].Trim() + "\\\\";
            }
         filename=   filename.Substring(0, filename.Length - 2);
        }
        private void libadd(int num)
        {

            OpenFileDialog ofd = new OpenFileDialog(); ofd.Filter = "모든 파일 (*.*) | *.*";
            DialogResult dr = ofd.ShowDialog();
            try
            {
                if (dr == DialogResult.OK)
                {
                    fname = ofd.FileName;

                }
                else if (dr == DialogResult.Cancel)
                {
                    MessageBox.Show("프로그램을 선택해 주세요");
                }
            }
            catch
            {

            }
            


            PictureBox[] pic = new PictureBox[] { pro1, pro2, pro3, pro4, pro5, pro6, pro7, pro8, pro9, pro10, pro11, pro12, pro13, pro14, pro15 };
            MySqlConnection conn;
            string strconn = "Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8";
            conn = new MySqlConnection(strconn);
            conn.Open();
            doublesl(fname);
            string strSelect1 = "update user_account set lanpro" + num + "=" + "\'" + filename + "\'" + "where id=" + "\'" + button1.Text + "\'";
            MySqlCommand cmd1 = new MySqlCommand(strSelect1, conn);

            if (cmd1.ExecuteNonQuery() == 1)
            {
                Icon icn = Icon.ExtractAssociatedIcon(fname); //Image Save Image img = Image.FromHbitmap(icn.ToBitmap().GetHbitmap());
                pic[num - 1].Image = Image.FromHbitmap(icn.ToBitmap().GetHbitmap());
            }
        }
    private void libprostart(int num)
        {
            MySqlConnection conn;
            string strconn = "Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8";
            conn = new MySqlConnection(strconn);
            conn.Open();
            string strSelect1 = "SELECT * from user_account where id=" + "\'" + button1.Text + "\'";
            MySqlCommand cmd1 = new MySqlCommand(strSelect1, conn);
            MySqlDataReader rdr1 = cmd1.ExecuteReader();
            rdr1.Read();
            if (rdr1["lanpro"+ num.ToString()].ToString() == "")
            {
                libadd(num);

            }
            else
            {
                System.Diagnostics.Process.Start(rdr1["lanpro"+ num.ToString()].ToString());
            }
            rdr1.Close();

        }
        private void pro1_Click(object sender, EventArgs e)
        {
            libprostart(1);
        }

        private void pro2_Click(object sender, EventArgs e)
        {
            libprostart(2);

        }

        private void pro3_Click(object sender, EventArgs e)
        {
            libprostart(3);

        }

        private void pro4_Click(object sender, EventArgs e)
        {
            libprostart(4);

        }

        private void pro5_Click(object sender, EventArgs e)
        {
            libprostart(5);

        }

        private void pro6_Click(object sender, EventArgs e)
        {
            libprostart(6);

        }

        private void pro7_Click(object sender, EventArgs e)
        {
            libprostart(7);

        }

        private void pro8_Click(object sender, EventArgs e)
        {
            libprostart(8);

        }

        private void pro9_Click(object sender, EventArgs e)
        {
            libprostart(9);

        }

        private void pro10_Click(object sender, EventArgs e)
        {
            libprostart(10);
        }

        private void pro11_Click(object sender, EventArgs e)
        {
            libprostart(11);

        }

        private void pro12_Click(object sender, EventArgs e)
        {
            libprostart(12);

        }

        private void pro13_Click(object sender, EventArgs e)
        {
            libprostart(13);

        }

        private void pro14_Click(object sender, EventArgs e)
        {
            libprostart(14);

        }

        private void pro15_Click(object sender, EventArgs e)
        {
            libprostart(14);

        }

        private void pro16_Click(object sender, EventArgs e)
        {
            set.StartPosition = FormStartPosition.CenterParent;
            set.ShowDialog();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Library_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void changebutton_Click(object sender, EventArgs e)
        {

        }


        private void Library_Load(object sender, EventArgs e)
        {
            button1.Text = userid;
            button2.Text = usernickname;
            Setting.userid = button1.Text;
            Setting.usernickname = button2.Text;
            string loadname;

            PictureBox[] pic = new PictureBox[] { pro1, pro2, pro3, pro4, pro5, pro6, pro7, pro8, pro9, pro10, pro11, pro12, pro13, pro14, pro15 };
            MySqlConnection conn;
            string strconn = "Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8";
            conn = new MySqlConnection(strconn);
            conn.Open();

            string strSelect1 = "Select * from user_account where id="+"\'"+button1.Text+"\'";
            MySqlCommand cmd1 = new MySqlCommand(strSelect1, conn);
            MySqlDataReader rdr1 = cmd1.ExecuteReader();
            rdr1.Read();
            
            for(int i=1;i<=15;i++)
            {
                if (rdr1["lanpro"+i].ToString()!="")
                {
                    loadname = rdr1["lanpro" + i].ToString();
                    Icon icn = Icon.ExtractAssociatedIcon(loadname); //Image Save Image img = Image.FromHbitmap(icn.ToBitmap().GetHbitmap());
                    pic[i - 1].Image = Image.FromHbitmap(icn.ToBitmap().GetHbitmap());
                }
            }
            
        }
        

    }
}
