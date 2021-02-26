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
    public partial class Install : Form
    {

        public Install()
        {
            InitializeComponent();

            panel1addbutton.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1addbutton.Width, panel1addbutton.Height, 7, 7));// 동그랗게 만들기
            panel1installbutton.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1installbutton.Width, panel1installbutton.Height, 7, 7));// 동그랗게 만들기
            panel1infobutton.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1infobutton.Width, panel1infobutton.Height, 7, 7));// 동그랗게 만들기
            programpanel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, programpanel1.Width, programpanel1.Height, 10, 10));// 동그랗게 만들기
            panel1picture.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1picture.Width, panel1picture.Height, 50, 50));// 동그랗게 만들기            

            panel2addbutton.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2addbutton.Width, panel2addbutton.Height, 7, 7));// 동그랗게 만들기
            panel2installbutton.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2installbutton.Width, panel2installbutton.Height, 7, 7));// 동그랗게 만들기
            panel2infobutton.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2infobutton.Width, panel2infobutton.Height, 7, 7));// 동그랗게 만들기
            programpanel2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, programpanel2.Width, programpanel2.Height, 10, 10));// 동그랗게 만들기
            panel2picture.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2picture.Width, panel2picture.Height, 50, 50));// 동그랗게 만들기            

            panel3addbutton.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3addbutton.Width, panel3addbutton.Height, 7, 7));// 동그랗게 만들기
            panel3installbutton.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3installbutton.Width, panel3installbutton.Height, 7, 7));// 동그랗게 만들기
            panel3infobutton.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3infobutton.Width, panel3infobutton.Height, 7, 7));// 동그랗게 만들기
            programpanel3.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, programpanel3.Width, programpanel3.Height, 10, 10));// 동그랗게 만들기
            panel3picture.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3picture.Width, panel3picture.Height, 50, 50));// 동그랗게 만들기            

            panel4addbutton.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4addbutton.Width, panel4addbutton.Height, 7, 7));// 동그랗게 만들기
            panel4installbutton.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4installbutton.Width, panel4installbutton.Height, 7, 7));// 동그랗게 만들기
            panel4infobutton.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4infobutton.Width, panel4infobutton.Height, 7, 7));// 동그랗게 만들기
            programpanel4.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, programpanel4.Width, programpanel4.Height, 10, 10));// 동그랗게 만들기
            panel4picture.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4picture.Width, panel4picture.Height, 50, 50));// 동그랗게 만들기            

            panel5addbutton.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5addbutton.Width, panel5addbutton.Height, 7, 7));// 동그랗게 만들기
            panel5installbutton.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5installbutton.Width, panel5installbutton.Height, 7, 7));// 동그랗게 만들기
            panel5infobutton.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5infobutton.Width, panel5infobutton.Height, 7, 7));// 동그랗게 만들기
            programpanel5.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, programpanel5.Width, programpanel5.Height, 10, 10));// 동그랗게 만들기
            panel5picture.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5picture.Width, panel5picture.Height, 50, 50));// 동그랗게 만들기            

            panel6addbutton.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel6addbutton.Width, panel6addbutton.Height, 7, 7));// 동그랗게 만들기
            panel6installbutton.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel6installbutton.Width, panel6installbutton.Height, 7, 7));// 동그랗게 만들기
            panel6infobutton.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel6infobutton.Width, panel6infobutton.Height, 7, 7));// 동그랗게 만들기
            programpanel6.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, programpanel6.Width, programpanel6.Height, 10, 10));// 동그랗게 만들기
            panel6picture.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel6picture.Width, panel6picture.Height, 50, 50));// 동그랗게 만들기            

        }


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]//폼 동그랗게 만들기
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect//폼 동그랗게 만들기
                                            , int nTopRect
                                            , int nRightRect
                                            , int nBottomRect
                                            , int nWidthEllipse
                                            , int nHeightEllipse);

        int useraddnumber = 0;
        public static string userinfo;
        private static DateTime Delay(int MS)
        {
            // Thread 와 Timer보다 효율 적으로 사용할 수 있음.
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }
            return DateTime.Now;
        }
        private void topbuttonclear()
        {
            topbutton1.FlatAppearance.BorderSize = 0;
            topbutton1.BackColor = Color.FromArgb(64, 64, 64);
            topbutton2.FlatAppearance.BorderSize = 0;
            topbutton2.BackColor = Color.FromArgb(64, 64, 64);
            topbutton3.FlatAppearance.BorderSize = 0;
            topbutton3.BackColor = Color.FromArgb(64, 64, 64);
            topbutton4.FlatAppearance.BorderSize = 0;
            topbutton4.BackColor = Color.FromArgb(64, 64, 64);
            topbutton5.FlatAppearance.BorderSize = 0;
            topbutton5.BackColor = Color.FromArgb(64, 64, 64);
            topbutton6.FlatAppearance.BorderSize = 0;
            topbutton6.BackColor = Color.FromArgb(64, 64, 64);
            topbutton7.FlatAppearance.BorderSize = 0;
            topbutton7.BackColor = Color.FromArgb(64, 64, 64);
        }
        private void middlebuttonclear()
        {
            middlebutton1.FlatAppearance.BorderSize = 0;
            middlebutton1.BackColor = Color.White;
            middlebutton2.FlatAppearance.BorderSize = 0;
            middlebutton2.BackColor = Color.White;
            middlebutton3.FlatAppearance.BorderSize = 0;
            middlebutton3.BackColor = Color.White;
            middlebutton4.FlatAppearance.BorderSize = 0;
            middlebutton4.BackColor = Color.White;
            middlebutton5.FlatAppearance.BorderSize = 0;
            middlebutton5.BackColor = Color.White;
            middlebutton6.FlatAppearance.BorderSize = 0;
            middlebutton6.BackColor = Color.White;
            middlebutton7.FlatAppearance.BorderSize = 0;
            middlebutton7.BackColor = Color.White;
            middlebutton8.FlatAppearance.BorderSize = 0;
            middlebutton8.BackColor = Color.White;
        }
        private void middlebuttonhide()
        {
            middlebutton1.Hide();
            middlebutton2.Hide();
            middlebutton3.Hide();
            middlebutton4.Hide();
            middlebutton5.Hide();
            middlebutton6.Hide();
            middlebutton7.Hide();
            middlebutton8.Hide();
        }

        private void middlebuttonshow()
        {
            middlebutton1.Show();
            middlebutton2.Show();
            middlebutton3.Show();
            middlebutton4.Show();
            middlebutton5.Show();
            middlebutton6.Show();
            middlebutton7.Show();
            middlebutton8.Show();
        }


        int pagenumber = 1;
        private void allinstall(string sqlcmd,string sqlselectcmd)
        {
                Loading loadfrm = new Loading();
                loadfrm.StartPosition = FormStartPosition.CenterParent;
                loadfrm.ShowDialog();


                Label[] englabel = new Label[] { panel1engname, panel2engname, panel3engname, panel4engname, panel5engname, panel6engname };
                Label[] korlabel = new Label[] { panel1korname, panel2korname, panel3korname, panel4korname, panel5korname, panel6korname };
                Button[] tagbutton1 = new Button[] { panel1tag1, panel2tag1, panel3tag1, panel4tag1, panel5tag1, panel6tag1 };
                Button[] tagbutton2 = new Button[] { panel1tag2, panel2tag2, panel3tag2, panel4tag2, panel5tag2, panel6tag2 };
                PictureBox[] proimg = new PictureBox[] { panel1picture, panel2picture, panel3picture, panel4picture, panel5picture, panel6picture };

                MySqlConnection conn;
                string strconn = sqlcmd;
                conn = new MySqlConnection(strconn);
                conn.Open();
            string strSelect1 = "SELECT COUNT(*) FROM program_info";
            MySqlCommand cmd1 = new MySqlCommand(strSelect1, conn);
            MySqlDataReader rdr1 = cmd1.ExecuteReader();
            rdr1.Read();

            if (int.Parse(rdr1["COUNT(*)"].ToString()) % 6 == 0)
                label3.Text = "Page" + (int.Parse(rdr1["COUNT(*)"].ToString()) / 6).ToString();
            else
                label3.Text = "Page" + (int.Parse(rdr1["COUNT(*)"].ToString()) / 6 + 1).ToString();

            label1.Text = "Page"+pagenumber.ToString();
            rdr1.Close();

            int sqlLIMIT = pagenumber * 6;
            string strSelect2 = sqlselectcmd + " LIMIT " + sqlLIMIT.ToString() + "," + 6;
            cmd1 = new MySqlCommand(strSelect2, conn);
            rdr1 = cmd1.ExecuteReader();
            for (int i=0;i<6;i++)
            {
                try
                {
                    rdr1.Read();
                }
                catch
                {
                    break;
                }
                englabel[i].Text = rdr1["name_eng"].ToString();
                korlabel[i].Text = rdr1["name_kor"].ToString();
                tagbutton1[i].Text = rdr1["program_tag1"].ToString();
                tagbutton2[i].Text = rdr1["program_tag2"].ToString();
                try
                {
                    proimg[i].Load(rdr1["image_link"].ToString());
                }
                catch
                {
                    proimg[i].Image = Bitmap.FromFile("libmain.png");
                }
            }
            rdr1.Close();
        }
        private void panelinstall(Label inslabel)
        {
            int downcnt=0;
            Loading loadfrm = new Loading();
            loadfrm.StartPosition = FormStartPosition.CenterParent;
            loadfrm.ShowDialog();

            MySqlConnection conn;
            string strconn = "Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8";
            conn = new MySqlConnection(strconn);
            conn.Open();

            string strSelect1 = "SELECT * from program_info where verification='1' where=\'"+ inslabel.Text+"\'";
            MySqlCommand cmd1 = new MySqlCommand(strSelect1, conn);
            MySqlDataReader rdr1 = cmd1.ExecuteReader();

            rdr1.Read();
            

                if (rdr1["name_eng"].ToString() == inslabel.Text)
                {
                    downcnt = int.Parse(rdr1["download_count"].ToString());
                    System.Diagnostics.Process.Start(rdr1["download_link"].ToString());
                }

            
            rdr1.Close();

            downcnt++;
            string strSelect2 = "update program_info set download_count="+"\'"+downcnt.ToString()+"\' where name_eng=\'"+inslabel.Text+"\'";
            MySqlCommand cmd2 = new MySqlCommand(strSelect2, conn);
           
            cmd2.ExecuteNonQuery();

        }
        public void addlib()
        {
            MySqlConnection conn;
            string strconn = "Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8";
            conn = new MySqlConnection(strconn);
            conn.Open();

            string strSelect1 = "SELECT * FROM user_account where id="+"\'"+ userinfo + "\'";
            MySqlCommand cmd1 = new MySqlCommand(strSelect1, conn);
            MySqlDataReader rdr = cmd1.ExecuteReader();
            rdr.Read();
            for (int i=1;i<=50;i++)
            {
                if(rdr["librarypro"+i].ToString()=="")
                {
                    useraddnumber = i;

                    break;
                }
            }
            rdr.Close();

        }
        public void addprogram(Label label)
        {
            MySqlConnection conn;
            string strconn = "Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8";
            conn = new MySqlConnection(strconn);
            conn.Open();

            string strSelect1 = "update user_account set librarypro" + useraddnumber.ToString() + "=" + "\'" + label.Text + "\'" + "where id=" + "\'" + userinfo + "\'";
            MySqlCommand cmd1 = new MySqlCommand(strSelect1, conn);

            if (cmd1.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("라이브러리에 추가되었습니다!");
            }

        }


        public void panelinfo(Label inslabel)
        { 
            MySqlConnection conn;
            string strconn = "Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8";
            conn = new MySqlConnection(strconn);
            conn.Open();

            string strSelect1 = "SELECT * from program_info where verification='1'";
            MySqlCommand cmd1 = new MySqlCommand(strSelect1, conn);
            MySqlDataReader rdr1 = cmd1.ExecuteReader();

            while (rdr1.Read())
            {

                if (rdr1["name_eng"].ToString() == inslabel.Text)
                {
                    Programinfo infofrm = new Programinfo();
                    infofrm.StartPosition = FormStartPosition.CenterParent;

                    Programinfo.engname = rdr1["name_eng"].ToString();
                    Programinfo.korname = rdr1["name_kor"].ToString();
                    Programinfo.proinfo = rdr1["pro_info"].ToString();
                    Programinfo.proimg = rdr1["image_link"].ToString();
                    Programinfo.protag1 = rdr1["program_tag1"].ToString();
                    Programinfo.protag2 = rdr1["program_tag2"].ToString();
                    Programinfo.prohomelink = rdr1["homepage_link"].ToString();
                    Programinfo.runwindow = rdr1["runwindow"].ToString();
                    infofrm.ShowDialog();
                }
            }
        }

        private void Install_Load(object sender, EventArgs e)
        {
            topbuttonclear();
            topbutton1.FlatAppearance.BorderSize = 2;
            topbutton1.BackColor = Color.Teal;

            middlebuttonclear();
            middlebutton1.FlatAppearance.BorderSize = 1;
            middlebutton1.BackColor = Color.FromArgb(255, 192, 192);


            programpanel1.Hide();
            programpanel2.Hide();
            programpanel3.Hide();
            programpanel4.Hide();
            programpanel5.Hide();
            programpanel6.Hide();

            middlebutton1.Text = "전체";
            middlebutton2.Hide();
            middlebutton3.Hide();
            middlebutton4.Hide();
            middlebutton5.Hide();
            middlebutton6.Hide();
            middlebutton7.Hide();
            middlebutton8.Hide();

            pagenumber = 1;
            label2.Text = "전체";
            allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' ORDER BY download_count desc");


            programpanel1.Show();
            programpanel2.Show();
            programpanel3.Show();
            programpanel4.Show();
            programpanel5.Show();
            programpanel6.Show();
   
        }

        private void searchbutton_MouseMove(object sender, MouseEventArgs e)
        {
            searchbutton.Image = Bitmap.FromFile("search2.png");
        }

        private void searchbutton_MouseLeave(object sender, EventArgs e)
        {
            searchbutton.Image = Bitmap.FromFile("search1.png");
        }

        private void topbutton1_Click(object sender, EventArgs e)
        {
            topbuttonclear();
            topbutton1.FlatAppearance.BorderSize = 2;
            topbutton1.BackColor = Color.Teal;

            middlebuttonclear();
            middlebutton1.FlatAppearance.BorderSize = 1;
            middlebutton1.BackColor = Color.FromArgb(255, 192, 192);

            middlebutton1.Text = "전체";
            middlebutton2.Hide();
            middlebutton3.Hide();
            middlebutton4.Hide();
            middlebutton5.Hide();
            middlebutton6.Hide();
            middlebutton7.Hide();
            middlebutton8.Hide();

            pagenumber = 1;
            label2.Text = "전체";
            allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' ORDER BY download_count desc");
        }

        private void topbutton2_Click(object sender, EventArgs e)
        {
            pagenumber = 1;
            label2.Text = "게임-전체";
            allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='게임' ORDER BY download_count desc");


            topbuttonclear();
            topbutton2.FlatAppearance.BorderSize = 2;
            topbutton2.BackColor = Color.Teal;

            middlebuttonclear();
            middlebuttonshow();
            middlebutton1.Text = "전체";
            middlebutton2.Text = "RPG";
            middlebutton3.Text = "FPS";
            middlebutton4.Text = "MOBA";
            middlebutton5.Text = "RTS";
            middlebutton6.Text = "Sports";
            middlebutton7.Text = "Casual";
            middlebutton8.Text = "기타";
            middlebutton1.FlatAppearance.BorderSize = 1;
            middlebutton1.BackColor = Color.FromArgb(255, 192, 192);


        }

        private void topbutton3_Click(object sender, EventArgs e)
        {
            pagenumber = 1;
            label2.Text = "유틸/백신-전체";
            allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='유틸백신' ORDER BY download_count desc");

            topbuttonclear();
            topbutton3.FlatAppearance.BorderSize = 2;
            topbutton3.BackColor = Color.Teal;

            middlebuttonclear();
            middlebuttonshow();
            middlebutton1.Text = "전체";
            middlebutton2.Text = "백신";
            middlebutton3.Text = "압축";
            middlebutton4.Text = "컴퓨터관리";
            middlebutton5.Text = "백업/복구";
            middlebutton6.Text = "편리기능";
            middlebutton7.Text = "브라우저";
            middlebutton8.Text = "기타";
            middlebutton1.FlatAppearance.BorderSize = 1;
            middlebutton1.BackColor = Color.FromArgb(255, 192, 192);

        }

        private void topbutton4_Click(object sender, EventArgs e)
        {
            pagenumber = 1;
            label2.Text = "사무/오피스-전체";
            allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='사무오피스' ORDER BY download_count desc");

            topbuttonclear();
            topbutton4.FlatAppearance.BorderSize = 2;
            topbutton4.BackColor = Color.Teal;

            middlebuttonclear();
            middlebuttonshow();
            middlebutton1.Text = "전체";
            middlebutton2.Text = "문서 편집";
            middlebutton3.Text = "문서 뷰어";
            middlebutton4.Text = "업무";
            middlebutton5.Text= "기타";
            middlebutton6.Hide();
            middlebutton7.Hide();
            middlebutton8.Hide();
            middlebutton1.FlatAppearance.BorderSize = 1;
            middlebutton1.BackColor = Color.FromArgb(255, 192, 192);
        }

        private void topbutton5_Click(object sender, EventArgs e)
        {
            pagenumber = 1;
            label2.Text = "멀티미디어-전체";
            allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='멀티미디어' ORDER BY download_count desc");

            topbuttonclear();
            topbutton5.FlatAppearance.BorderSize = 2;
            topbutton5.BackColor = Color.Teal;

            middlebuttonclear();
            middlebuttonshow();
            middlebutton1.Text = "전체";
            middlebutton2.Text = "동영상";
            middlebutton3.Text = "오디오";
            middlebutton4.Text = "이미지";
            middlebutton5.Text = "폰트";
            middlebutton6.Text = "메신져";
            middlebutton7.Text = "스트리밍";
            middlebutton8.Text = "기타";
            middlebutton1.FlatAppearance.BorderSize = 1;
            middlebutton1.BackColor = Color.FromArgb(255, 192, 192);
        }

        private void topbutton7_Click(object sender, EventArgs e)
        {
            pagenumber = 1;
            label2.Text = "기타-전체";
            allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='기타' ORDER BY download_count desc");

            topbuttonclear();
            topbutton7.FlatAppearance.BorderSize = 2;
            topbutton7.BackColor = Color.Teal;

            middlebuttonclear();
            middlebuttonshow();
            middlebutton1.Text = "전체";
            middlebutton2.Hide();
            middlebutton3.Hide();
            middlebutton4.Hide();
            middlebutton5.Hide();
            middlebutton6.Hide();
            middlebutton7.Hide();
            middlebutton8.Hide();

            middlebutton1.FlatAppearance.BorderSize = 1;
            middlebutton1.BackColor = Color.FromArgb(255, 192, 192);
        }
        private void topbutton6_Click(object sender, EventArgs e)
        {
            pagenumber = 1;
            label2.Text = "개발도구-전체";
            allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='개발도구' ORDER BY download_count desc");

            topbuttonclear();
            topbutton6.FlatAppearance.BorderSize = 2;
            topbutton6.BackColor = Color.Teal;

            middlebuttonclear();
            middlebuttonshow();
            middlebutton1.Text = "전체";
            middlebutton2.Hide();
            middlebutton3.Hide();
            middlebutton4.Hide();
            middlebutton5.Hide();
            middlebutton6.Hide();
            middlebutton7.Hide();
            middlebutton8.Hide();

            middlebutton1.FlatAppearance.BorderSize = 1;
            middlebutton1.BackColor = Color.FromArgb(255, 192, 192);
        }
        private void middlebutton1_Click(object sender, EventArgs e)
        {

            middlebuttonclear();
            middlebutton1.FlatAppearance.BorderSize = 1;
            middlebutton1.BackColor = Color.FromArgb(255, 192, 192);

            if(label2.Text=="게임-전체")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='게임' ORDER BY download_count desc");
            }
            if (label2.Text == "유틸/백신-전체")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='유틸백신' ORDER BY download_count desc");
            }
            if (label2.Text == "사무/오피스-전체")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='사무오피스' ORDER BY download_count desc");
            }
            if (label2.Text == "멀티미디어-전체")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='멀티미디어' ORDER BY download_count desc");
            }
            if (label2.Text == "개발도구-전체")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='개발도구' ORDER BY download_count desc");
            }
            if (label2.Text == "기타-전체")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='기타' ORDER BY download_count desc");
            }
        }
        private void middlebutton2_Click(object sender, EventArgs e)
        {
            middlebuttonclear();
            middlebutton2.FlatAppearance.BorderSize = 1;
            middlebutton2.BackColor = Color.FromArgb(255, 224, 192);

            if(middlebutton2.Text=="RPG")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='RPG' ORDER BY download_count desc");
                label2.Text = "게임-RPG";
            }
            if (middlebutton2.Text == "백신")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='백신' ORDER BY download_count desc");
                label2.Text = "유틸/백신-백신";
            }
            if (middlebutton2.Text == "문서 편집")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='문서편집' ORDER BY download_count desc");
                label2.Text = "사무/오피스-문서 편집";
            }
            if (middlebutton2.Text == "동영상")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='동영상' ORDER BY download_count desc");
                label2.Text = "멀티미디어-동영상";
            }
        }
        private void middlebutton3_Click(object sender, EventArgs e)
        {
            middlebuttonclear();
            middlebutton3.FlatAppearance.BorderSize = 1;
            middlebutton3.BackColor = Color.FromArgb(255, 255, 192);
            if (middlebutton3.Text == "FPS")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='FPS' ORDER BY download_count desc");
                label2.Text = "게임-FPS";
            }
            if (middlebutton3.Text == "압축")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='압축' ORDER BY download_count desc");
                label2.Text = "유틸/백신-압축";
            }
            if (middlebutton3.Text == "문서 뷰어")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='문서뷰어' ORDER BY download_count desc");
                label2.Text = "사무/오피스-문서 뷰어";
            }
            if (middlebutton3.Text == "오디오")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='오디오' ORDER BY download_count desc");
                label2.Text = "멀티미디어-오디오";
            }
        }
        private void middlebutton4_Click(object sender, EventArgs e)
        {
            middlebuttonclear();
            middlebutton4.FlatAppearance.BorderSize = 1;
            middlebutton4.BackColor = Color.FromArgb(192, 255, 192);
            if (middlebutton4.Text == "MOBA")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='MOBA' ORDER BY download_count desc");
                label2.Text = "게임-MOBA";
            }
            if (middlebutton4.Text == "컴퓨터관리")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='컴퓨터관리' ORDER BY download_count desc");
                label2.Text = "유틸/백신-컴퓨터관리";
            }
            if (middlebutton4.Text == "업무")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='업무' ORDER BY download_count desc");
                label2.Text = "사무/오피스-업무";
            }
            if (middlebutton4.Text == "이미지")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='이미지' ORDER BY download_count desc");
                label2.Text = "멀티미디어-이미지";
            }
        }
        private void middlebutton5_Click(object sender, EventArgs e)
        {
            middlebuttonclear();
            middlebutton5.FlatAppearance.BorderSize = 1;
            middlebutton5.BackColor = Color.FromArgb(192, 255, 255);
            if (middlebutton5.Text == "RTS")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='RTS' ORDER BY download_count desc");

                label2.Text = "게임-RTS";
            }
            if (middlebutton5.Text == "백업/복구")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='백업복구' ORDER BY download_count desc");

                label2.Text = "유틸/백신-백업/복구";
            }
            if (middlebutton5.Text == "기타")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='기타' and program_tag1='사무오피스' ORDER BY download_count desc");

                label2.Text = "사무/오피스-기타";
            }
            if (middlebutton5.Text == "폰트")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='폰트' ORDER BY download_count desc");

                label2.Text = "멀티미디어-폰트";
            }
        }
        private void middlebutton6_Click(object sender, EventArgs e)
        {
            middlebuttonclear();
            middlebutton6.FlatAppearance.BorderSize = 1;
            middlebutton6.BackColor = Color.FromArgb(192, 192, 255);
            if (middlebutton6.Text == "Sports")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='SPORTS' ORDER BY download_count desc");

                label2.Text = "게임-Sports";
            }
            if (middlebutton6.Text == "편리기능")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='편리기능' ORDER BY download_count desc");
                label2.Text = "유틸/백신-편리기능";
            }
            if (middlebutton6.Text == "메신져")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='메신져' ORDER BY download_count desc");
                label2.Text = "멀티미디어-메신져";
            }

        }
        private void middlebutton7_Click(object sender, EventArgs e)
        {
            middlebuttonclear();
            middlebutton7.FlatAppearance.BorderSize = 1;
            middlebutton7.BackColor = Color.FromArgb(255, 192, 255);
            if (middlebutton7.Text == "Casual")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='CASUAL' ORDER BY download_count desc");
                label2.Text = "게임-Casual";
            }
            if (middlebutton7.Text == "브라우저")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='브라우저' ORDER BY download_count desc");
                label2.Text = "유틸/백신-브라우저";
            }
            if (middlebutton7.Text == "스트리밍")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='스트리밍' ORDER BY download_count desc");
                label2.Text = "멀티미디어-스트리밍";
            }
        }
        private void middlebutton8_Click(object sender, EventArgs e)
        {
            middlebuttonclear();
            middlebutton8.FlatAppearance.BorderSize = 1;
            middlebutton8.BackColor = Color.Silver;

            if (middlebutton8.Text == "기타" && topbutton2.BackColor==Color.Teal)
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='게임' and 'program_tag2='Casual' and  ORDER BY download_count desc");
                label2.Text = "게임-기타";
            }
            if (middlebutton8.Text == "기타" && topbutton3.BackColor == Color.Teal)
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='유틸백신' and program_tag2='기타' ORDER BY download_count desc");
                label2.Text = "유틸/백신-기타";
            }
            if (middlebutton8.Text == "기타" && topbutton5.BackColor == Color.Teal)
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='멀티미디어' and program_tag2='기타' ORDER BY download_count desc");
                label2.Text = "멀티미디어-기타";
            }

        }
        private void gotonext_Click(object sender, EventArgs e)
        {

            if (label2.Text == "전체")
            {
                if (label3.Text != "page" + pagenumber)
                {
                    pagenumber++;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' ORDER BY download_count desc");
                }
            }

            if (label2.Text == "게임-전체")
            {
                if (label3.Text != "page" + pagenumber)
                {
                    pagenumber++;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='게임' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "게임-RPG")
            {
                if (label3.Text != "page" + pagenumber)
                {
                    pagenumber++;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='RPG' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "게임-FPS")
            {
                if (label3.Text != "page" + pagenumber)
                {
                    pagenumber++;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='FPS' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "게임-MOBA")
            {
                if (label3.Text != "page" + pagenumber)
                {
                    pagenumber++;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='MOBA' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "게임-RTS")
            {
                if (label3.Text != "page" + pagenumber)
                {
                    pagenumber++;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='RTS' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "게임-Sports")
            {
                if (label3.Text != "page" + pagenumber)
                {
                    pagenumber++;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='Sports' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "게임-Casual")
            {
                if (label3.Text != "page" + pagenumber)
                {
                    pagenumber++;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='Casual' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "게임-기타")
            {
                if (label3.Text != "page" + pagenumber)
                {
                    pagenumber++;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='게임' and program_tag2='기타' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "유틸/백신-전체")
            {
                if (label3.Text != "page" + pagenumber)
                {
                    pagenumber++;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='유틸백신' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "유틸/백신-백신")
            {
                if (label3.Text != "page" + pagenumber)
                {
                    pagenumber++;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='백신' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "유틸/백신-압축")
            {
                if (label3.Text != "page" + pagenumber)
                {
                    pagenumber++;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='압축' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "유틸/백신-컴퓨터관리")
            {
                if (label3.Text != "page" + pagenumber)
                {
                    pagenumber++;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='컴퓨터관리' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "유틸/백신-백업/복구")
            {
                if (label3.Text != "page" + pagenumber)
                {
                    pagenumber++;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='백업복구' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "유틸/백신-편리기능")
            {
                if (label3.Text != "page" + pagenumber)
                {
                    pagenumber++;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='편리기능' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "유틸/백신-브라우저")
            {
                if (label3.Text != "page" + pagenumber)
                {
                    pagenumber++;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='브라우저' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "유틸/백신-기타")
            {
                if (label3.Text != "page" + pagenumber)
                {
                    pagenumber++;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='유틸백신' and program_tag2='기타' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "사무/오피스-전체")
            {
                if (label3.Text != "page" + pagenumber)
                {
                    pagenumber++;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='사무오피스' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "사무/오피스-문서 편집")
            {
                if (label3.Text != "page" + pagenumber)
                {
                    pagenumber++;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='문서편집' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "사무/오피스-문서 뷰어")
            {
                if (label3.Text != "page" + pagenumber)
                {
                    pagenumber++;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='문서뷰어' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "사무/오피스-업무")
            {
                if (label3.Text != "page" + pagenumber)
                {
                    pagenumber++;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='업무' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "사무/오피스-기타")
            {
                if (label3.Text != "page" + pagenumber)
                {
                    pagenumber++;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='사무오피스' and program_tag2='기타' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "멀티미디어-전체")
            {
                if (label3.Text != "page" + pagenumber)
                {
                    pagenumber++;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='멀티미디어' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "멀티미디어-동영상")
            {
                if (label3.Text != "page" + pagenumber)
                {
                    pagenumber++;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='동영상' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "멀티미디어-오디오")
            {
                if (label3.Text != "page" + pagenumber)
                {
                    pagenumber++;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='오디오' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "멀티미디어-이미지")
            {
                if (label3.Text != "page" + pagenumber)
                {
                    pagenumber++;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='이미지' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "멀티미디어-폰트")
            {
                if (label3.Text != "page" + pagenumber)
                {
                    pagenumber++;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='폰트' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "멀티미디어-메신져")
            {
                if (label3.Text != "page" + pagenumber)
                {
                    pagenumber++;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='메신져' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "멀티미디어-스트리밍")
            {
                if (label3.Text != "page" + pagenumber)
                {
                    pagenumber++;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='스트리밍' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "멀티미디어-기타")
            {
                if (label3.Text != "page" + pagenumber)
                {
                    pagenumber++;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='멀티미디어' and program_tag2='기타' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "개발도구-전체")
            {
                if (label3.Text != "page" + pagenumber)
                {
                    pagenumber++;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='개발도구' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "기타-전체")
            {
                if (label3.Text != "page" + pagenumber)
                {
                    pagenumber++;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='기타' ORDER BY download_count desc");
                }
            }



        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
        }

        private void gotofirst_Click(object sender, EventArgs e)
        {
            if (label2.Text == "전체")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' ORDER BY download_count desc");
            }
            if (label2.Text == "게임-전체")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='게임' ORDER BY download_count desc");
            }
            if (label2.Text == "게임-RPG")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='RPG' ORDER BY download_count desc");
            }
            if (label2.Text == "게임-FPS")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='FPS' ORDER BY download_count desc");
            }
            if (label2.Text == "게임-MOBA")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='MOBA' ORDER BY download_count desc");
            }
            if (label2.Text == "게임-RTS")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='RTS' ORDER BY download_count desc");
            }
            if (label2.Text == "게임-Sports")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='Sports' ORDER BY download_count desc");
            }
            if (label2.Text == "게임-Casual")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='Casual' ORDER BY download_count desc");
            }
            if (label2.Text == "게임-기타")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='게임' and program_tag2='기타' ORDER BY download_count desc");
            }
            if (label2.Text == "유틸/백신-전체")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='유틸백신' ORDER BY download_count desc");
            }
            if (label2.Text == "유틸/백신-백신")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='백신' ORDER BY download_count desc");
            }
            if (label2.Text == "유틸/백신-압축")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='압축' ORDER BY download_count desc");
            }
            if (label2.Text == "유틸/백신-컴퓨터관리")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='컴퓨터관리' ORDER BY download_count desc");
            }
            if (label2.Text == "유틸/백신-백업/복구")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='백업복구' ORDER BY download_count desc");
            }
            if (label2.Text == "유틸/백신-편리기능")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='편리기능' ORDER BY download_count desc");
            }
            if (label2.Text == "유틸/백신-브라우저")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='브라우저' ORDER BY download_count desc");
            }
            if (label2.Text == "유틸/백신-기타")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='유틸백신' and program_tag2='기타' ORDER BY download_count desc");
            }
            if (label2.Text == "사무/오피스-전체")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='사무오피스' ORDER BY download_count desc");
            }
            if (label2.Text == "사무/오피스-문서 편집")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='문서편집' ORDER BY download_count desc");
            }
            if (label2.Text == "사무/오피스-문서 뷰어")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='문서뷰어' ORDER BY download_count desc");
            }
            if (label2.Text == "사무/오피스-업무")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='업무' ORDER BY download_count desc");
            }
            if (label2.Text == "사무/오피스-기타")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='사무오피스' and program_tag2='기타' ORDER BY download_count desc");
            }
            if (label2.Text == "멀티미디어-전체")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='멀티미디어' ORDER BY download_count desc");
            }
            if (label2.Text == "멀티미디어-동영상")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='동영상' ORDER BY download_count desc");
            }
            if (label2.Text == "멀티미디어-오디오")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='오디오' ORDER BY download_count desc");
            }
            if (label2.Text == "멀티미디어-이미지")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='이미지' ORDER BY download_count desc");
            }
            if (label2.Text == "멀티미디어-폰트")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='폰트' ORDER BY download_count desc");
            }
            if (label2.Text == "멀티미디어-메신져")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='메신져' ORDER BY download_count desc");
            }
            if (label2.Text == "멀티미디어-스트리밍")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='스트리밍' ORDER BY download_count desc");
            }
            if (label2.Text == "멀티미디어-기타")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='멀티미디어' and program_tag2='기타' ORDER BY download_count desc");
            }
            if (label2.Text == "개발도구-전체")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='개발도구' ORDER BY download_count desc");
            }
            if (label2.Text == "기타-전체")
            {
                pagenumber = 1;
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='기타' ORDER BY download_count desc");
            }
        }


        private void gotolast_Click(object sender, EventArgs e)
        {
            if (label2.Text == "전체")
            {
                string gotolastchar = label3.Text;
                gotolastchar = gotolastchar.Substring(4);
                pagenumber = int.Parse(gotolastchar);
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' ORDER BY download_count desc");
            }
            if (label2.Text == "게임-전체")
            {
                string gotolastchar = label3.Text;
                gotolastchar = gotolastchar.Substring(4);
                pagenumber = int.Parse(gotolastchar);
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='게임' ORDER BY download_count desc");
            }
            if (label2.Text == "게임-RPG")
            {
                string gotolastchar = label3.Text;
                gotolastchar = gotolastchar.Substring(4);
                pagenumber = int.Parse(gotolastchar);
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='RPG' ORDER BY download_count desc");
            }
            if (label2.Text == "게임-FPS")
            {
                string gotolastchar = label3.Text;
                gotolastchar = gotolastchar.Substring(4);
                pagenumber = int.Parse(gotolastchar);
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='FPS' ORDER BY download_count desc");
            }
            if (label2.Text == "게임-MOBA")
            {
                string gotolastchar = label3.Text;
                gotolastchar = gotolastchar.Substring(4);
                pagenumber = int.Parse(gotolastchar);
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='MOBA' ORDER BY download_count desc");
            }
            if (label2.Text == "게임-RTS")
            {
                string gotolastchar = label3.Text;
                gotolastchar = gotolastchar.Substring(4);
                pagenumber = int.Parse(gotolastchar);
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='RTS' ORDER BY download_count desc");
            }
            if (label2.Text == "게임-Sports")
            {
                string gotolastchar = label3.Text;
                gotolastchar = gotolastchar.Substring(4);
                pagenumber = int.Parse(gotolastchar);
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='Sports' ORDER BY download_count desc");
            }
            if (label2.Text == "게임-Casual")
            {
                string gotolastchar = label3.Text;
                gotolastchar = gotolastchar.Substring(4);
                pagenumber = int.Parse(gotolastchar);
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='Casual' ORDER BY download_count desc");
            }
            if (label2.Text == "게임-기타")
            {
                string gotolastchar = label3.Text;
                gotolastchar = gotolastchar.Substring(4);
                pagenumber = int.Parse(gotolastchar);
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='게임' and program_tag2='기타' ORDER BY download_count desc");
            }
            if (label2.Text == "유틸/백신-전체")
            {
                string gotolastchar = label3.Text;
                gotolastchar = gotolastchar.Substring(4);
                pagenumber = int.Parse(gotolastchar);
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='유틸백신' ORDER BY download_count desc");
            }
            if (label2.Text == "유틸/백신-백신")
            {
                string gotolastchar = label3.Text;
                gotolastchar = gotolastchar.Substring(4);
                pagenumber = int.Parse(gotolastchar);
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='백신' ORDER BY download_count desc");
            }
            if (label2.Text == "유틸/백신-압축")
            {
                string gotolastchar = label3.Text;
                gotolastchar = gotolastchar.Substring(4);
                pagenumber = int.Parse(gotolastchar);
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='압축' ORDER BY download_count desc");
            }
            if (label2.Text == "유틸/백신-컴퓨터관리")
            {
                string gotolastchar = label3.Text;
                gotolastchar = gotolastchar.Substring(4);
                pagenumber = int.Parse(gotolastchar);
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='컴퓨터관리' ORDER BY download_count desc");
            }
            if (label2.Text == "유틸/백신-백업/복구")
            {
                string gotolastchar = label3.Text;
                gotolastchar = gotolastchar.Substring(4);
                pagenumber = int.Parse(gotolastchar);
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='백업복구' ORDER BY download_count desc");
            }
            if (label2.Text == "유틸/백신-편리기능")
            {
                string gotolastchar = label3.Text;
                gotolastchar = gotolastchar.Substring(4);
                pagenumber = int.Parse(gotolastchar);
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='편리기능' ORDER BY download_count desc");
            }
            if (label2.Text == "유틸/백신-브라우저")
            {
                string gotolastchar = label3.Text;
                gotolastchar = gotolastchar.Substring(4);
                pagenumber = int.Parse(gotolastchar);
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='브라우저' ORDER BY download_count desc");
            }
            if (label2.Text == "유틸/백신-기타")
            {
                string gotolastchar = label3.Text;
                gotolastchar = gotolastchar.Substring(4);
                pagenumber = int.Parse(gotolastchar);
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='유틸백신' and program_tag2='기타' ORDER BY download_count desc");
            }
            if (label2.Text == "사무/오피스-전체")
            {
                string gotolastchar = label3.Text;
                gotolastchar = gotolastchar.Substring(4);
                pagenumber = int.Parse(gotolastchar);
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='사무오피스' ORDER BY download_count desc");
            }
            if (label2.Text == "사무/오피스-문서 편집")
            {
                string gotolastchar = label3.Text;
                gotolastchar = gotolastchar.Substring(4);
                pagenumber = int.Parse(gotolastchar);
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='문서편집' ORDER BY download_count desc");
            }
            if (label2.Text == "사무/오피스-문서 뷰어")
            {
                string gotolastchar = label3.Text;
                gotolastchar = gotolastchar.Substring(4);
                pagenumber = int.Parse(gotolastchar);
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='문서뷰어' ORDER BY download_count desc");
            }
            if (label2.Text == "사무/오피스-업무")
            {
                string gotolastchar = label3.Text;
                gotolastchar = gotolastchar.Substring(4);
                pagenumber = int.Parse(gotolastchar);
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='업무' ORDER BY download_count desc");
            }
            if (label2.Text == "사무/오피스-기타")
            {
                string gotolastchar = label3.Text;
                gotolastchar = gotolastchar.Substring(4);
                pagenumber = int.Parse(gotolastchar);
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='사무오피스' and program_tag2='기타' ORDER BY download_count desc");
            }
            if (label2.Text == "멀티미디어-전체")
            {
                string gotolastchar = label3.Text;
                gotolastchar = gotolastchar.Substring(4);
                pagenumber = int.Parse(gotolastchar);
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='멀티미디어' ORDER BY download_count desc");
            }
            if (label2.Text == "멀티미디어-동영상")
            {
                string gotolastchar = label3.Text;
                gotolastchar = gotolastchar.Substring(4);
                pagenumber = int.Parse(gotolastchar);
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='동영상' ORDER BY download_count desc");
            }
            if (label2.Text == "멀티미디어-오디오")
            {
                string gotolastchar = label3.Text;
                gotolastchar = gotolastchar.Substring(4);
                pagenumber = int.Parse(gotolastchar);
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='오디오' ORDER BY download_count desc");
            }
            if (label2.Text == "멀티미디어-이미지")
            {
                string gotolastchar = label3.Text;
                gotolastchar = gotolastchar.Substring(4);
                pagenumber = int.Parse(gotolastchar);
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='이미지' ORDER BY download_count desc");
            }
            if (label2.Text == "멀티미디어-폰트")
            {
                string gotolastchar = label3.Text;
                gotolastchar = gotolastchar.Substring(4);
                pagenumber = int.Parse(gotolastchar);
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='폰트' ORDER BY download_count desc");
            }
            if (label2.Text == "멀티미디어-메신져")
            {
                string gotolastchar = label3.Text;
                gotolastchar = gotolastchar.Substring(4);
                pagenumber = int.Parse(gotolastchar);
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='메신져' ORDER BY download_count desc");
            }
            if (label2.Text == "멀티미디어-스트리밍")
            {
                string gotolastchar = label3.Text;
                gotolastchar = gotolastchar.Substring(4);
                pagenumber = int.Parse(gotolastchar);
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='스트리밍' ORDER BY download_count desc");
            }
            if (label2.Text == "멀티미디어-기타")
            {
                string gotolastchar = label3.Text;
                gotolastchar = gotolastchar.Substring(4);
                pagenumber = int.Parse(gotolastchar);
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='멀티미디어' and program_tag2='기타' ORDER BY download_count desc");
            }
            if (label2.Text == "개발도구-전체")
            {
                string gotolastchar = label3.Text;
                gotolastchar = gotolastchar.Substring(4);
                pagenumber = int.Parse(gotolastchar);
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='개발도구' ORDER BY download_count desc");
            }
            if (label2.Text == "기타-전체")
            {
                string gotolastchar = label3.Text;
                gotolastchar = gotolastchar.Substring(4);
                pagenumber = int.Parse(gotolastchar);
                allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='기타' ORDER BY download_count desc");
            }
        }
    
        private void gotoprevious_Click(object sender, EventArgs e)
        {
            if (label2.Text == "전체")
            {
                if (label1.Text != "page1" )
                {
                    pagenumber--;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "전체")
            {
                if (label1.Text != "page1")
                {
                    pagenumber--;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' ORDER BY download_count desc");
                }
            }

            if (label2.Text == "게임-전체")
            {
                if (label1.Text != "page1")
                {
                    pagenumber--;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='게임' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "게임-RPG")
            {
                if (label1.Text != "page1")
                {
                    pagenumber--;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='RPG' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "게임-FPS")
            {
                if (label1.Text != "page1")
                {
                    pagenumber--;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='FPS' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "게임-MOBA")
            {
                if (label1.Text != "page1")
                {
                    pagenumber--;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='MOBA' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "게임-RTS")
            {
                if (label1.Text != "page1")
                {
                    pagenumber--;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='RTS' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "게임-Sports")
            {
                if (label1.Text != "page1")
                {
                    pagenumber--;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='Sports' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "게임-Casual")
            {
                if (label1.Text != "page1")
                {
                    pagenumber--;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='Casual' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "게임-기타")
            {
                if (label1.Text != "page1")
                {
                    pagenumber--;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='게임' and program_tag2='기타' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "유틸/백신-전체")
            {
                if (label1.Text != "page1")
                {
                    pagenumber--;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='유틸백신' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "유틸/백신-백신")
            {
                if (label1.Text != "page1")
                {
                    pagenumber--;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='백신' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "유틸/백신-압축")
            {
                if (label1.Text != "page1")
                {
                    pagenumber--;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='압축' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "유틸/백신-컴퓨터관리")
            {
                if (label1.Text != "page1")
                {
                    pagenumber--;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='컴퓨터관리' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "유틸/백신-백업/복구")
            {
                if (label1.Text != "page1")
                {
                    pagenumber--;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='백업복구' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "유틸/백신-편리기능")
            {
                if (label1.Text != "page1")
                {
                    pagenumber--;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='편리기능' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "유틸/백신-브라우저")
            {
                if (label1.Text != "page1")
                {
                    pagenumber--;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='브라우저' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "유틸/백신-기타")
            {
                if (label1.Text != "page1")
                {
                    pagenumber--;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='유틸백신' and program_tag2='기타' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "사무/오피스-전체")
            {
                if (label1.Text != "page1")
                {
                    pagenumber--;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='사무오피스' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "사무/오피스-문서 편집")
            {
                if (label1.Text != "page1")
                {
                    pagenumber--;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='문서편집' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "사무/오피스-문서 뷰어")
            {
                if (label1.Text != "page1")
                {
                    pagenumber--;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='문서뷰어' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "사무/오피스-업무")
            {
                if (label1.Text != "page1")
                {
                    pagenumber--;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='업무' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "사무/오피스-기타")
            {
                if (label1.Text != "page1")
                {
                    pagenumber--;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='사무오피스' and program_tag2='기타' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "멀티미디어-전체")
            {
                if (label1.Text != "page1")
                {
                    pagenumber--;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='멀티미디어' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "멀티미디어-동영상")
            {
                if (label1.Text != "page1")
                {
                    pagenumber--;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='동영상' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "멀티미디어-오디오")
            {
                if (label1.Text != "page1")
                {
                    pagenumber--;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='오디오' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "멀티미디어-이미지")
            {
                if (label1.Text != "page1")
                {
                    pagenumber--;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='이미지' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "멀티미디어-폰트")
            {
                if (label1.Text != "page1")
                {
                    pagenumber--;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='폰트' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "멀티미디어-메신져")
            {
                if (label1.Text != "page1")
                {
                    pagenumber--;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='메신져' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "멀티미디어-스트리밍")
            {
                if (label1.Text != "page1")
                {
                    pagenumber--;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag2='스트리밍' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "멀티미디어-기타")
            {
                if (label1.Text != "page1")
                {
                    pagenumber--;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='멀티미디어' and program_tag2='기타' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "개발도구-전체")
            {
                if (label1.Text != "page1")
                {
                    pagenumber--;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='개발도구' ORDER BY download_count desc");
                }
            }
            if (label2.Text == "기타-전체")
            {
                if (label1.Text != "page1")
                {
                    pagenumber--;
                    allinstall("Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8", "SELECT * from program_info where verification='1' and program_tag1='기타' ORDER BY download_count desc");
                }
            }
        }
   
        private void panel1installbutton_Click(object sender, EventArgs e)
        {
            panelinstall(panel1engname);
        }

        private void panel2installbutton_Click(object sender, EventArgs e)
        {
            panelinstall(panel2engname);
        }

        private void panel3installbutton_Click(object sender, EventArgs e)
        {
            panelinstall(panel3engname);
        }

        private void panel4installbutton_Click(object sender, EventArgs e)
        {
            panelinstall(panel4engname);
        }

        private void panel5installbutton_Click(object sender, EventArgs e)
        {
            panelinstall(panel5engname);
        }

        private void panel6installbutton_Click(object sender, EventArgs e)
        {
            panelinstall(panel6engname);
        }

        private void panel1infobutton_Click(object sender, EventArgs e)
        {
            panelinfo(panel1engname);
        }

        private void panel2infobutton_Click(object sender, EventArgs e)
        {
            panelinfo(panel2engname);
        }

        private void panel3infobutton_Click(object sender, EventArgs e)
        {
            panelinfo(panel3engname);
        }

        private void panel4infobutton_Click(object sender, EventArgs e)
        {
            panelinfo(panel4engname);
        }

        private void panel5infobutton_Click(object sender, EventArgs e)
        {
            panelinfo(panel5engname);
        }

        private void panel6infobutton_Click(object sender, EventArgs e)
        {
            panelinfo(panel6engname);
        }

        private void sortbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1addbutton_Click(object sender, EventArgs e)
        {
            if (userinfo == "Guestuser")
            {
                MessageBox.Show("게스트로는 이용 할 수 없습니다!");
                goto exitgogo;
            }
            MySqlConnection conn;
            string strconn = "Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8";
            conn = new MySqlConnection(strconn);
            conn.Open();

            string strSelect1 = "SELECT * FROM user_account where id=" + "\'" + userinfo + "\'";
            MySqlCommand cmd1 = new MySqlCommand(strSelect1, conn);
            MySqlDataReader rdr = cmd1.ExecuteReader();
            rdr.Read();
            
            for (int i = 1; i <= 50; i++)
            {
                if (panel1engname.Text == rdr["librarypro" + i].ToString())
                {
                    MessageBox.Show(rdr["librarypro" + i].ToString() + "\r\n는 이미 라이브러리에 추가된 프로그램입니다!");
                    goto exit;
                }
            }
            rdr.Close();
          addlib();
          addprogram(panel1engname);
        exit:;
        exitgogo:;
        }

        private void panel2addbutton_Click(object sender, EventArgs e)
        {
            if (userinfo == "Guestuser")
            {
                MessageBox.Show("게스트로는 이용 할 수 없습니다!");
                goto exitgogo;
            }
            MySqlConnection conn;
            string strconn = "Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8";
            conn = new MySqlConnection(strconn);
            conn.Open();

            string strSelect1 = "SELECT * FROM user_account where id=" + "\'" + userinfo + "\'";
            MySqlCommand cmd1 = new MySqlCommand(strSelect1, conn);
            MySqlDataReader rdr = cmd1.ExecuteReader();
            rdr.Read();

            for (int i = 1; i <= 50; i++)
            {
                if (panel2engname.Text == rdr["librarypro" + i].ToString())
                {
                    MessageBox.Show(rdr["librarypro" + i].ToString() + "\r\n는 이미 라이브러리에 추가된 프로그램입니다!");
                    goto exit;
                }
            }
            rdr.Close();
            addlib();
            addprogram(panel2engname);
        exit:;
        exitgogo:;
        }

        private void panel3addbutton_Click(object sender, EventArgs e)
        {
            if (userinfo == "Guestuser")
            {
                MessageBox.Show("게스트로는 이용 할 수 없습니다!");
                goto exitgogo;
            }
            MySqlConnection conn;
            string strconn = "Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8";
            conn = new MySqlConnection(strconn);
            conn.Open();

            string strSelect1 = "SELECT * FROM user_account where id=" + "\'" + userinfo + "\'";
            MySqlCommand cmd1 = new MySqlCommand(strSelect1, conn);
            MySqlDataReader rdr = cmd1.ExecuteReader();
            rdr.Read();
            for (int i = 1; i <= 50; i++)
            {
                if (panel3engname.Text == rdr["librarypro" + i].ToString())
                {
                    MessageBox.Show(rdr["librarypro" + i].ToString() + "\r\n는 이미 추가된 프로그램입니다!");
                    goto exit;
                }
            }
            rdr.Close();
            addlib();
            addprogram(panel3engname);
        exit:;
        exitgogo:;
        }

        private void panel4addbutton_Click(object sender, EventArgs e)
        {
            if (userinfo == "Guestuser")
            {
                MessageBox.Show("게스트로는 이용 할 수 없습니다!");
                goto exitgogo;
            }
            MySqlConnection conn;
            string strconn = "Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8";
            conn = new MySqlConnection(strconn);
            conn.Open();

            string strSelect1 = "SELECT * FROM user_account where id=" + "\'" + userinfo + "\'";
            MySqlCommand cmd1 = new MySqlCommand(strSelect1, conn);
            MySqlDataReader rdr = cmd1.ExecuteReader();
            rdr.Read();
            for (int i = 1; i <= 50; i++)
            {
                if (panel4engname.Text == rdr["librarypro" + i].ToString())
                {
                    MessageBox.Show(rdr["librarypro" + i].ToString() + "\r\n는 이미 추가된 프로그램입니다!");
                    goto exit;
                }
            }
            rdr.Close();
            addlib();
            addprogram(panel4engname);
        exit:;
        exitgogo:;
        }

        private void panel5addbutton_Click(object sender, EventArgs e)
        {
            if (userinfo == "Guestuser")
            {
                MessageBox.Show("게스트로는 이용 할 수 없습니다!");
                goto exitgogo;
            }
            MySqlConnection conn;
            string strconn = "Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8";
            conn = new MySqlConnection(strconn);
            conn.Open();

            string strSelect1 = "SELECT * FROM user_account where id=" + "\'" + userinfo + "\'";
            MySqlCommand cmd1 = new MySqlCommand(strSelect1, conn);
            MySqlDataReader rdr = cmd1.ExecuteReader();
            rdr.Read();
            for (int i = 1; i <= 50; i++)
            {
                if (panel5engname.Text == rdr["librarypro" + i].ToString())
                {
                    MessageBox.Show(rdr["librarypro" + i].ToString() + "\r\n는 이미 추가된 프로그램입니다!");
                    goto exit;
                }
            }
            rdr.Close();
            addlib();
            addprogram(panel5engname);
        exit:;
        exitgogo:;
        }

        private void panel6addbutton_Click(object sender, EventArgs e)
        {
            if (userinfo == "Guestuser")
            {
                MessageBox.Show("게스트로는 이용 할 수 없습니다!");
                goto exitgogo;
            }
            MySqlConnection conn;
            string strconn = "Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8";
            conn = new MySqlConnection(strconn);
            conn.Open();

            string strSelect1 = "SELECT * FROM user_account where id=" + "\'" + userinfo + "\'";
            MySqlCommand cmd1 = new MySqlCommand(strSelect1, conn);
            MySqlDataReader rdr = cmd1.ExecuteReader();
            rdr.Read();
            for (int i = 1; i <= 50; i++)
            {
                if (panel6engname.Text == rdr["librarypro" + i].ToString())
                {
                    MessageBox.Show(rdr["librarypro" + i].ToString() + "\r\n는 이미 추가된 프로그램입니다!");
                    goto exit;
                }
            }
            rdr.Close();
            addlib();
            addprogram(panel6engname);
        exit:;
        exitgogo:;
        }

        private void programpanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void programpanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1picture_MouseHover(object sender, EventArgs e)
        {

        }
    }   
}

