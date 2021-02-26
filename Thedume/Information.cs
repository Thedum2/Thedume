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
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }
        public static string userid;
        int infopagenumber = 1;
        int lastpagenumber;
        private void inforbuttonclear()
        {
            topbutton1.ForeColor = Color.White;
            topbutton1.FlatAppearance.BorderColor = Color.White;
            topbutton1.BackColor = Color.Black;

            topbutton2.ForeColor = Color.White;
            topbutton2.FlatAppearance.BorderColor = Color.White;
            topbutton2.BackColor = Color.Black;

            topbutton3.ForeColor = Color.White;
            topbutton3.FlatAppearance.BorderColor = Color.White;
            topbutton3.BackColor = Color.Black;

            topbutton4.ForeColor = Color.White;
            topbutton4.FlatAppearance.BorderColor = Color.White;
            topbutton4.BackColor = Color.Black;

            topbutton5.ForeColor = Color.White;
            topbutton5.FlatAppearance.BorderColor = Color.White;
            topbutton5.BackColor = Color.Black;

            topbutton6.ForeColor = Color.White;
            topbutton6.FlatAppearance.BorderColor = Color.White;
            topbutton6.BackColor = Color.Black;

            topbutton7.ForeColor = Color.White;
            topbutton7.FlatAppearance.BorderColor = Color.White;
            topbutton7.BackColor = Color.Black;
        }
        private void inforbuttonclick(Button inforb)
        {
            inforb.BackColor = Color.Silver;
            inforb.ForeColor = Color.Black;
        }
        private void proshow()
        {
            infoproeng1.Show();
            infoproeng2.Show();
            infoproeng3.Show();
            infoproeng4.Show();
            infoproeng5.Show();
            infoproeng6.Show();
            infoproeng7.Show();
            infoproeng8.Show();
            infoproeng9.Show();
            infoproeng10.Show();
            infoproeng11.Show();
            infoproeng12.Show();
            infoproeng13.Show();
            infoproeng14.Show();

            infoproins1.Show();
            infoproins2.Show();
            infoproins3.Show();
            infoproins4.Show();
            infoproins5.Show();
            infoproins6.Show();
            infoproins7.Show();
            infoproins8.Show();
            infoproins9.Show();
            infoproins10.Show();
            infoproins11.Show();
            infoproins12.Show();
            infoproins13.Show();
            infoproins14.Show();

            infoprodel1.Show();
            infoprodel2.Show();
            infoprodel3.Show();
            infoprodel4.Show();
            infoprodel5.Show();
            infoprodel6.Show();
            infoprodel7.Show();
            infoprodel8.Show();
            infoprodel9.Show();
            infoprodel10.Show();
            infoprodel11.Show();
            infoprodel12.Show();
            infoprodel13.Show();
            infoprodel14.Show();

        }
        private void userload()
        {
            MySqlConnection conn;
            string strconn = "Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8";
            conn = new MySqlConnection(strconn);
            conn.Open();

            string strSelect1 = "SELECT * from user_account";
            MySqlCommand cmd1 = new MySqlCommand(strSelect1, conn);
            MySqlDataReader rdr1 = cmd1.ExecuteReader();

            while (rdr1.Read())
            {
                if (rdr1["id"].ToString() == userid)
                {
                    loginuserid.Text = rdr1["id"].ToString();
                    loginusernickname.Text = rdr1["nickname"].ToString();
                    loginuseremail.Text = rdr1["email"].ToString();
                }
            }
        }
        private void userproload()
        {
            Button[] prolbl = new Button[] { infoproeng1, infoproeng2, infoproeng3, infoproeng4, infoproeng5, infoproeng6, infoproeng7, infoproeng8, infoproeng9, infoproeng10, infoproeng11, infoproeng12, infoproeng13, infoproeng14 };
            Button[] proins = new Button[] { infoproins1, infoproins2, infoproins3, infoproins4, infoproins5, infoproins6, infoproins7, infoproins8, infoproins9, infoproins10, infoproins11, infoproins12, infoproins13, infoproins14 };
            Button[] prodel = new Button[] { infoprodel1, infoprodel2, infoprodel3, infoprodel4, infoprodel5, infoprodel6, infoprodel7, infoprodel8, infoprodel9, infoprodel10, infoprodel11, infoprodel12, infoprodel13, infoprodel14 };

            int coun =0;
            MySqlConnection conn;
            string strconn = "Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8";
            conn = new MySqlConnection(strconn);
            conn.Open();

            string strSelect1 = "SELECT * from user_account where id=" + "\'" + loginuserid.Text +"\'";
            MySqlCommand cmd1 = new MySqlCommand(strSelect1, conn);
            MySqlDataReader rdr1 = cmd1.ExecuteReader();
            rdr1.Read();


            proshow();

            for (int a=1;a<=50;a++)
            {
                if(rdr1["librarypro"+a].ToString()!="")
                {
                    coun++;
                }
            }

            if(coun<=14)
            {
                lastpagenumber = 1;
                pronum.Text = infopagenumber.ToString();
                lastnum.Text = lastpagenumber.ToString();

                for (int b = 1; b <= coun; b++)
                {
                    prolbl[b-1].Text = rdr1["librarypro" + b].ToString();                   
                }
                for (int c = 1; c <= 14-coun; c++)
                {
                    prolbl[14-c].Hide();
                    proins[14 - c].Hide();
                    prodel[14 - c].Hide();
                }

            }
            else if(coun%14==0)
            {

                pronum.Text = infopagenumber.ToString();
                lastpagenumber = coun / 14;
                lastnum.Text = lastpagenumber.ToString();

                for (int b = 1; b <= 14; b++)
                {
                    prolbl[b - 1].Text = rdr1["librarypro" + ((14 * (infopagenumber - 1)) + b).ToString()].ToString();
                }


            }
            else
            {
                pronum.Text = infopagenumber.ToString();
                lastpagenumber = coun / 14 + 1;
                lastnum.Text = lastpagenumber.ToString();

                for (int b =1; b <= 14; b++)
                {
                    if (rdr1["librarypro" + ((14 * (infopagenumber - 1)) + b).ToString()].ToString() == "")
                    {
                        prolbl[b-1].Hide();
                        proins[b-1].Hide();
                        prodel[b-1].Hide();
                    }

                    prolbl[b - 1].Text = rdr1["librarypro" + ((14*(infopagenumber-1))+b).ToString()].ToString();
                }


            }


        }
        private void userproload2(string tag159)
        {
            Button[] prolbl = new Button[] { infoproeng1, infoproeng2, infoproeng3, infoproeng4, infoproeng5, infoproeng6, infoproeng7, infoproeng8, infoproeng9, infoproeng10, infoproeng11, infoproeng12, infoproeng13, infoproeng14 };
            Button[] proins = new Button[] { infoproins1, infoproins2, infoproins3, infoproins4, infoproins5, infoproins6, infoproins7, infoproins8, infoproins9, infoproins10, infoproins11, infoproins12, infoproins13, infoproins14 };
            Button[] prodel = new Button[] { infoprodel1, infoprodel2, infoprodel3, infoprodel4, infoprodel5, infoprodel6, infoprodel7, infoprodel8, infoprodel9, infoprodel10, infoprodel11, infoprodel12, infoprodel13, infoprodel14 };
            string[] protag = new string[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            string[] libtag = new string[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };

            int coun = 0;
            MySqlConnection conn;
            string strconn = "Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8";
            conn = new MySqlConnection(strconn);
            conn.Open();

            string strSelect1 = "SELECT * from user_account where id=" + "\'" + loginuserid.Text + "\'";
            MySqlCommand cmd1 = new MySqlCommand(strSelect1, conn);
            MySqlDataReader rdr1 = cmd1.ExecuteReader();

            rdr1.Read();
            proshow();
            for (int a = 1; a <= 50; a++)
            {
                if (rdr1["librarypro" + a].ToString() != "")
                {
                    protag[a - 1] = rdr1["librarypro" + a].ToString();
                }
            }
            rdr1.Close();


            
             string strSelect2 = "SELECT * from program_info";
             MySqlCommand cmd2 = new MySqlCommand(strSelect2, conn);
             MySqlDataReader rdr2 = cmd2.ExecuteReader();

            int fornum = 0;

                 while (rdr2.Read())
                 {
                     for (int e = 1; e <= 50; e++)
                     { 
                         if ((rdr2["name_eng"].ToString() == protag[e-1]) && (rdr2["program_tag1"].ToString()==tag159))
                           {
                                libtag[fornum] = rdr2["name_eng"].ToString();
                                 coun++;
                                     fornum++;
                            }
                     }

                   }

             rdr2.Close();
            
                     if (coun <= 14)
                     {
                         lastpagenumber = 1;
                         pronum.Text = infopagenumber.ToString();
                         lastnum.Text = lastpagenumber.ToString();

                         for (int b = 1; b <= coun; b++)
                         {
                             prolbl[b - 1].Text = libtag[b - 1];
                         }
                         for (int c = 1; c <= 14 - coun; c++)
                         {
                             prolbl[14 - c].Hide();
                             proins[14 - c].Hide();
                             prodel[14 - c].Hide();
                         }

                     }
                     else if (coun % 14 == 0)
                     {

                         pronum.Text = infopagenumber.ToString();
                         lastpagenumber = coun / 14;
                         lastnum.Text = lastpagenumber.ToString();

                         for (int b = 1; b <= 14; b++)
                         {
                             prolbl[b - 1].Text = libtag[(14 * (infopagenumber - 1)) + b - 1];
                         }
                     }
                     else
                     {
                         pronum.Text = infopagenumber.ToString();
                         lastpagenumber = coun / 14 + 1;
                         lastnum.Text = lastpagenumber.ToString();

                         for (int b = 1; b <= 14; b++)
                         {
                             if (libtag[(14 * (infopagenumber - 1)) + b - 1] == "")
                             {
                                 prolbl[b - 1].Hide();
                                 proins[b - 1].Hide();
                                 prodel[b - 1].Hide();
                             }
                             prolbl[b - 1].Text = libtag[(14 * (infopagenumber - 1)) + b - 1];
                         }
                     }
               

        }
        private void userproins(Button btn)
        {
            MySqlConnection conn;
            string strconn = "Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8";
            conn = new MySqlConnection(strconn);
            conn.Open();

            string strSelect1 = "SELECT * from program_info where name_eng=" + "\'" + btn.Text + "\'";
            MySqlCommand cmd1 = new MySqlCommand(strSelect1, conn);
            MySqlDataReader rdr1 = cmd1.ExecuteReader();


            while (rdr1.Read())
            {
                if (rdr1["name_eng"].ToString() == btn.Text)
                {
                    System.Diagnostics.Process.Start(rdr1["download_link"].ToString());
                }
            }
            rdr1.Close();
        }
        private void userprodel(Button btn)
        {
            int libnum=0;

            MySqlConnection conn;
            string strconn = "Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8";
            conn = new MySqlConnection(strconn);
            conn.Open();

            string strSelect1 = "SELECT * from user_account where id=" + "\'" + loginuserid.Text + "\'";

            MySqlCommand cmd1 = new MySqlCommand(strSelect1, conn);

            MySqlDataReader rdr1 = cmd1.ExecuteReader();
            rdr1.Read();
            for(int a=1;a<=50;a++)
            {
                if (rdr1["librarypro" + a].ToString()==btn.Text)
                {
                    libnum = a;
                }
            }
            rdr1.Close();



            try
            {
                string strSelect2 = "UPDATE user_account set librarypro" + libnum + "= '' where id=" + "\'" + userid + "\'";
                MySqlCommand cmd2 = new MySqlCommand(strSelect2, conn);

                if (cmd2.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("라이브러리에서 삭제되었습니다!");
                }

                for (int b = libnum; b <= 49; b++)
                {
                    MySqlCommand cmd4 = new MySqlCommand(strSelect1, conn);
                    MySqlDataReader rdr2 = cmd4.ExecuteReader();
                    rdr2.Read();
                    string strSelect3 = "UPDATE user_account set librarypro" + b + "= \'" + rdr2["librarypro" + (b + 1)].ToString() + "\' where id=" + "\'" + userid + "\'";
                    rdr2.Close();
                    MySqlCommand cmd3 = new MySqlCommand(strSelect3, conn);
                    cmd3.ExecuteNonQuery();
                }
                infopagenumber = 1;
                userproload();

            }
            catch
            {
                MessageBox.Show("오류발생! 재시작 바람!");
            }
            
        }
        private void Information_Load(object sender, EventArgs e)
        {
            userload();
            inforbuttonclear();
            inforbuttonclick(topbutton1);
            infopagenumber=1;
            userproload();          
        }


        private void topbutton1_Click(object sender, EventArgs e)
        {
            inforbuttonclear();
            inforbuttonclick(topbutton1);
            infopagenumber = 1;
            userproload();

        }

        private void topbutton2_Click(object sender, EventArgs e)
        {
            inforbuttonclear();
            inforbuttonclick(topbutton2);

            infopagenumber = 1;
            userproload2("게임");

        }

        private void topbutton3_Click(object sender, EventArgs e)
        {
            inforbuttonclear();
            inforbuttonclick(topbutton3);

            infopagenumber = 1;
            userproload2("유틸백신");
        }

        private void topbutton4_Click(object sender, EventArgs e)
        {
            inforbuttonclear();
            inforbuttonclick(topbutton4);

            infopagenumber = 1;
            userproload2("사무오피스");
        }

        private void topbutton5_Click(object sender, EventArgs e)
        {
            inforbuttonclear();
            inforbuttonclick(topbutton5);

            infopagenumber = 1;
            userproload2("멀티미디어");
        }

        private void topbutton6_Click(object sender, EventArgs e)
        {
            inforbuttonclear();
            inforbuttonclick(topbutton6);

            infopagenumber = 1;
            userproload2("개발도구");
        }

        private void topbutton7_Click(object sender, EventArgs e)
        {
            inforbuttonclear();
            inforbuttonclick(topbutton7);

            infopagenumber = 1;
            userproload2("기타");
        }

        private void button55_Click(object sender, EventArgs e)
        {
            if (topbutton1.BackColor == Color.Silver)
            {
                if (int.Parse(pronum.Text) < int.Parse(lastnum.Text))
                {
                    infopagenumber++;
                    userproload();
                }
            }
            if (topbutton2.BackColor == Color.Silver)
            {
                if (int.Parse(pronum.Text) < int.Parse(lastnum.Text))
                {
                    infopagenumber++;
                    userproload2("게임");
                }
            }
            if (topbutton3.BackColor == Color.Silver)
            {
                if (int.Parse(pronum.Text) < int.Parse(lastnum.Text))
                {
                    infopagenumber++;
                    userproload2("유틸백신");
                }
            }
            if (topbutton4.BackColor == Color.Silver)
            {
                if (int.Parse(pronum.Text) < int.Parse(lastnum.Text))
                {
                    infopagenumber++;
                    userproload2("사무오피스");
                }
            }
            if (topbutton5.BackColor == Color.Silver)
            {
                if (int.Parse(pronum.Text) < int.Parse(lastnum.Text))
                {
                    infopagenumber++;
                    userproload2("멀티미디어");
                }
            }
            if (topbutton6.BackColor == Color.Silver)
            {
                if (int.Parse(pronum.Text) < int.Parse(lastnum.Text))
                {
                    infopagenumber++;
                    userproload2("개발도구");
                }
            }
            if (topbutton7.BackColor == Color.Silver)
            {
                if (int.Parse(pronum.Text) < int.Parse(lastnum.Text))
                {
                    infopagenumber++;
                    userproload2("기타");
                }
            }

        }

        private void button54_Click(object sender, EventArgs e)
        {
            if (int.Parse(pronum.Text)>1)
            {
                infopagenumber--;
                userproload();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            userload();
            inforbuttonclear();
            inforbuttonclick(topbutton1);
            infopagenumber = 1;
            userproload();

        }

        private void infoproins1_Click(object sender, EventArgs e)
        {
            userproins(infoproeng1);
        }

        private void infoproins2_Click(object sender, EventArgs e)
        {
            userproins(infoproeng2);
        }

        private void infoproins3_Click(object sender, EventArgs e)
        {
            userproins(infoproeng3);
        }

        private void infoproins4_Click(object sender, EventArgs e)
        {
            userproins(infoproeng4);
        }

        private void infoproins5_Click(object sender, EventArgs e)
        {
       userproins(infoproeng5);
        }

        private void infoproins6_Click(object sender, EventArgs e)
        {
            userproins(infoproeng6);
        }

        private void infoproins7_Click(object sender, EventArgs e)
        {
            userproins(infoproeng7);
        }

        private void infoproins8_Click(object sender, EventArgs e)
        {
            userproins(infoproeng8);
        }

        private void infoproins9_Click(object sender, EventArgs e)
        {
            userproins(infoproeng9);
        }

        private void infoproins10_Click(object sender, EventArgs e)
        {
            userproins(infoproeng10);
        }

        private void infoproins11_Click(object sender, EventArgs e)
        {
            userproins(infoproeng11);
        }

        private void infoproins12_Click(object sender, EventArgs e)
        {
            userproins(infoproeng12);
        }

        private void infoproins13_Click(object sender, EventArgs e)
        {
            userproins(infoproeng13);
        }

        private void infoproins14_Click(object sender, EventArgs e)
        {
            userproins(infoproeng14);
        }

        private void infoprodel1_Click(object sender, EventArgs e)
        {
            userprodel(infoproeng1);

        }

        private void infoprodel2_Click(object sender, EventArgs e)
        {
            userprodel(infoproeng2);
        }

        private void infoprodel3_Click(object sender, EventArgs e)
        {
            userprodel(infoproeng3);
        }

        private void infoprodel4_Click(object sender, EventArgs e)
        {
            userprodel(infoproeng4);
        }

        private void infoprodel5_Click(object sender, EventArgs e)
        {
            userprodel(infoproeng5);
        }

        private void infoprodel6_Click(object sender, EventArgs e)
        {
            userprodel(infoproeng6);
        }

        private void infoprodel7_Click(object sender, EventArgs e)
        {
            userprodel(infoproeng7);
        }

        private void infoprodel8_Click(object sender, EventArgs e)
        {
            userprodel(infoproeng8);
        }

        private void infoprodel9_Click(object sender, EventArgs e)
        {
            userprodel(infoproeng9);
        }

        private void infoprodel10_Click(object sender, EventArgs e)
        {
            userprodel(infoproeng10);
        }

        private void infoprodel11_Click(object sender, EventArgs e)
        {
            userprodel(infoproeng11);
        }

        private void infoprodel12_Click(object sender, EventArgs e)
        {
            userprodel(infoproeng12);
        }

        private void infoprodel13_Click(object sender, EventArgs e)
        {
            userprodel(infoproeng13);
        }

        private void infoprodel14_Click(object sender, EventArgs e)
        {
            userprodel(infoproeng14);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Changeemail.userid = loginuserid.Text;
            Changeemail.useremail = loginuseremail.Text;
            Changeemail chem = new Changeemail();
            chem.StartPosition = FormStartPosition.CenterParent;
            chem.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Changenickname.userid = loginuserid.Text;
            Changenickname.usernick = loginusernickname.Text;
            Changenickname chnick = new Changenickname();
            chnick.StartPosition = FormStartPosition.CenterParent;
            chnick.ShowDialog();
        }
    }
}
