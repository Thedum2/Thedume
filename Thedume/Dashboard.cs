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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            panela.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panela.Width, panela.Height, 20, 20));// 동그랗게 만들기
            panelb.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelb.Width, panelb.Height, 20, 20));// 동그랗게 만들기
            panelc.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelc.Width, panelc.Height, 20, 20));// 동그랗게 만들기
            paneld.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, paneld.Width, paneld.Height, 20, 20));// 동그랗게 만들기
            panele.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panele.Width, panele.Height, 20, 20));// 동그랗게 만들기
            panelf.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelf.Width, panelf.Height, 20, 20));// 동그랗게 만들기
            panelg.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelg.Width, panelg.Height, 20, 20));// 동그랗게 만들기
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));// 동그랗게 만들기


        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]//폼 동그랗게 만들기
    private static extern IntPtr CreateRoundRectRgn(int nLeftRect//폼 동그랗게 만들기
                                             , int nTopRect
                                             , int nRightRect
                                             , int nBottomRect
                                             , int nWidthEllipse
                                             , int nHeightEllipse);
   private void dashload(string han,Label eng,Label kor,PictureBox pic)
        {

            MySqlConnection conn;
            string strconn = "Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8";
            conn = new MySqlConnection(strconn);
            conn.Open();

            string strSelect1 = "SELECT * FROM program_info where program_tag1="+"\'"+han+"\'" +"order by download_count desc";
            MySqlCommand cmd1 = new MySqlCommand(strSelect1, conn);
            MySqlDataReader rdr = cmd1.ExecuteReader();
            rdr.Read();
            eng.Text = rdr["name_eng"].ToString();
            kor.Text = rdr["name_kor"].ToString();
            try
            {
                pic.Load(rdr["image_link"].ToString());
            }
            catch
            {

            }
            rdr.Close();
        }
        private void alldashload(Label eng, Label kor, PictureBox pic)
        {

            MySqlConnection conn;
            string strconn = "Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8";
            conn = new MySqlConnection(strconn);
            conn.Open();

            string strSelect1 = "SELECT * FROM program_info order by download_count desc";
            MySqlCommand cmd1 = new MySqlCommand(strSelect1, conn);
            MySqlDataReader rdr = cmd1.ExecuteReader();
            rdr.Read();
            eng.Text = rdr["name_eng"].ToString();
            kor.Text = rdr["name_kor"].ToString();
            try
            {
                pic.Load(rdr["image_link"].ToString());
            }
            catch
            {

            }
            rdr.Close();
        }
        private void alldashdownloadcount()
        {
            Label[] downeng = new Label[] { downeng1, downeng2, downeng3, downeng4, downeng5, downeng6, downeng7, downeng8, downeng9, downeng10, downeng11, downeng12, downeng13, downeng14 };
            Label[] downcnt = new Label[] { downcount1, downcount2, downcount3, downcount4, downcount5, downcount6, downcount7, downcount8, downcount9, downcount10, downcount11, downcount12, downcount13, downcount14 };
            MySqlConnection conn;
            string strconn = "Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8";
            conn = new MySqlConnection(strconn);
            conn.Open();

            string strSelect1 = "SELECT * FROM program_info order by download_count desc";
            MySqlCommand cmd1 = new MySqlCommand(strSelect1, conn);
            MySqlDataReader rdr = cmd1.ExecuteReader();

            for(int a=0;a<14;a++)
            {
                rdr.Read();
                downeng[a].Text = rdr["name_eng"].ToString();
                downcnt[a].Text = rdr["download_count"].ToString();
            }
            

            rdr.Close();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            alldashload(panelaeng, panelakor, panelapic);
            dashload("게임",panelbeng,panelbkor,panelbpic);
            dashload("유틸백신", panelceng, panelckor, panelcpic);
            dashload("사무오피스", paneldeng, paneldkor, paneldpic);
            dashload("멀티미디어", paneleeng, panelekor, panelepic);
            dashload("개발도구", panelfeng, panelfkor, panelfpic);
            dashload("기타", panelgeng, panelgkor, panelgpic);
            alldashdownloadcount();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            alldashload(panelaeng, panelakor, panelapic);
            dashload("게임", panelbeng, panelbkor, panelbpic);
            dashload("유틸백신", panelceng, panelckor, panelcpic);
            dashload("사무오피스", paneldeng, paneldkor, paneldpic);
            dashload("멀티미디어", paneleeng, panelekor, panelepic);
            dashload("개발도구", panelfeng, panelfkor, panelfpic);
            dashload("기타", panelgeng, panelgkor, panelgpic);
            alldashdownloadcount();
        }
    }
}
