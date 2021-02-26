using System;
using System.IO;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
           
        }
        private Point mousePoint;//마우스포인터 변수
        public static Bitmap ChangeOpacity(Image img, float opacityvalue)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height); // Determining Width and Height of Source Image
            Graphics graphics = Graphics.FromImage(bmp);
            ColorMatrix colormatrix = new ColorMatrix();
            colormatrix.Matrix33 = opacityvalue;
            ImageAttributes imgAttribute = new ImageAttributes();
            imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            graphics.DrawImage(img, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imgAttribute);
            graphics.Dispose();   // Releasing all resource used by graphics
            return bmp;
        }
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
        private void Login_Load(object sender, EventArgs e)
        {
            using (StreamReader sw = new StreamReader("ddeid.txt"))
            {
                textBox1.Text = sw.ReadLine();
            }
            using (StreamReader sw = new StreamReader("ddepw.txt"))
            {
                textBox2.Text = sw.ReadLine();
            }
            launcher.Hide();
            welcomelabel.Hide();
            finallogion.Hide();
            launcher.Hide();
            relogin.Hide();
            textBox1.Focus();
            signup.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, signup.Width, signup.Height, 20, 20));// 동그랗게 만들기
            forgetpassword.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, forgetpassword.Width, forgetpassword.Height, 20, 20));//동그랗게 만들기
            loginbutton.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, loginbutton.Width, loginbutton.Height, 20, 20));// 동그랗게 만들기
            guestlogin.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, guestlogin.Width, guestlogin.Height, 20, 20));// 동그랗게 만들기
            pictureBox3.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox3.Width, pictureBox3.Height, 20, 20));// 동그랗게 만들기
           finallogion.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, finallogion.Width, finallogion.Height, 20, 20));// 동그랗게 만들기
            launcher.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, launcher.Width, launcher.Height, 20, 20));// 동그랗게 만들기
            relogin.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, relogin.Width, relogin.Height, 20, 20));// 동그랗게 만들기

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));// 동그랗게 만들기
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]//폼 동그랗게 만들기
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect//폼 동그랗게 만들기
                                             , int nTopRect
                                             , int nRightRect
                                             , int nBottomRect
                                             , int nWidthEllipse
                                             , int nHeightEllipse);

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }//창 이동

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            checkBox1.Hide();
            loginbutton.Text = "로그인중..........";
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("계정ID와P/W를 제대로 입력해주세요");
                goto loginexit;
            }

            MySqlConnection conn;
            string strconn = "Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8";
            conn = new MySqlConnection(strconn);


            try
            {
                conn.Open();
                string strSelect = "SELECT * from user_account where id=\"" + textBox1.Text + "\"";
                MySqlCommand cmd = new MySqlCommand(strSelect, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();         
                    if (rdr["password"].ToString() == textBox2.Text)
                    {
                        welcomelabel.Text = rdr["nickname"].ToString() + " 님, 반갑습니다!";
                        timer1.Start();
                        Main.linktextid = textBox1.Text;
                        Main.linktextnickname = rdr["nickname"].ToString();
                         Library.userid= textBox1.Text;
                         Library.usernickname = rdr["nickname"].ToString();
                    if (checkBox1.Checked == true)
                    {
                        using (StreamWriter sw = new StreamWriter("ddeid.txt"))
                        {
                            sw.WriteLine(textBox1.Text);
                        }
                        using (StreamWriter sw = new StreamWriter("ddepw.txt"))
                        {
                            sw.WriteLine(textBox2.Text);
                        }
                    }
                }
                    else
                    {
                        MessageBox.Show("비밀번호를 다시 확인해주세요");
                        textBox1.Focus();
                    }
                
            }        
            catch
            {
                MessageBox.Show("계정ID와P/W를 제대로 입력해주세요");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();
            } 
        

        
          
        loginexit:;
        loginbutton.Text = "로그인";

        }


        float opacityvalue1 = (float)1;
        float opacityvalue2 = (float)1;
        private void timer1_Tick(object sender, EventArgs e)//로그인시 FADE OUT
        {
            opacityvalue1 -= (float)0.08;
            opacityvalue2 -= (float)0.08;
            pictureBox3.Image = ChangeOpacity(Image.FromFile("profileimg.png"), opacityvalue2);
            pictureBox2.Image = ChangeOpacity(Image.FromFile("newlogintwo.png"), opacityvalue1);

            int fadingSpeed = 5;//White -- 35,35,35
            int fadingSpeed2 = 5;//89,89,89 -- 35,35,35
            int fadingSpeed3 = 5;//Black -- 35,35,35
            int fadingSpeed4 = 5;//White -- 89,89,89
            int fadingSpeed5 = 5;//35,35,35 -- 89,89,89


            textBox1.BackColor = Color.FromArgb(textBox1.BackColor.R - fadingSpeed, textBox1.BackColor.G - fadingSpeed, textBox1.BackColor.B - fadingSpeed);
            textBox2.BackColor = Color.FromArgb(textBox2.BackColor.R - fadingSpeed, textBox2.BackColor.G - fadingSpeed, textBox2.BackColor.B - fadingSpeed);
            label1.ForeColor = Color.FromArgb(label1.ForeColor.R - fadingSpeed, label1.ForeColor.G - fadingSpeed, label1.ForeColor.B - fadingSpeed);
            label2.ForeColor = Color.FromArgb(label2.ForeColor.R - fadingSpeed, label2.ForeColor.G - fadingSpeed, label2.ForeColor.B - fadingSpeed);
            label3.ForeColor = Color.FromArgb(label3.ForeColor.R - fadingSpeed, label3.ForeColor.G - fadingSpeed, label3.ForeColor.B - fadingSpeed);
            label4.ForeColor = Color.FromArgb(label4.ForeColor.R - fadingSpeed, label4.ForeColor.G - fadingSpeed, label4.ForeColor.B - fadingSpeed);

            signup.BackColor = Color.FromArgb(signup.BackColor.R - fadingSpeed2, signup.BackColor.G - fadingSpeed2, signup.BackColor.B - fadingSpeed2);
            forgetpassword.BackColor = Color.FromArgb(forgetpassword.BackColor.R - fadingSpeed2, forgetpassword.BackColor.G - fadingSpeed2, forgetpassword.BackColor.B - fadingSpeed);

            signup.ForeColor= Color.FromArgb(signup.ForeColor.R + fadingSpeed3, signup.ForeColor.G + fadingSpeed3, signup.ForeColor.B + fadingSpeed3);
            forgetpassword.ForeColor = Color.FromArgb(forgetpassword.ForeColor.R + fadingSpeed3, forgetpassword.ForeColor.G + fadingSpeed3, forgetpassword.ForeColor.B + fadingSpeed3);
            textBox1.ForeColor = Color.FromArgb(textBox1.ForeColor.R + fadingSpeed3, textBox1.ForeColor.G + fadingSpeed3, textBox1.ForeColor.B + fadingSpeed3);
            textBox2.ForeColor = Color.FromArgb(textBox2.ForeColor.R + fadingSpeed3, textBox2.ForeColor.G + fadingSpeed3, textBox2.ForeColor.B + fadingSpeed3);


            loginbutton.ForeColor= Color.FromArgb(loginbutton.ForeColor.R - fadingSpeed, loginbutton.ForeColor.G - fadingSpeed, loginbutton.ForeColor.B - fadingSpeed);
            guestlogin.ForeColor = Color.FromArgb(guestlogin.ForeColor.R - fadingSpeed, guestlogin.ForeColor.G - fadingSpeed, guestlogin.ForeColor.B - fadingSpeed);
            label5.ForeColor = Color.FromArgb(label5.ForeColor.R - fadingSpeed, label5.ForeColor.G - fadingSpeed, label5.ForeColor.B - fadingSpeed);

            loginbutton.BackColor = Color.FromArgb(loginbutton.BackColor.R + fadingSpeed, loginbutton.BackColor.G + fadingSpeed, loginbutton.BackColor.B + fadingSpeed);
            guestlogin.BackColor = Color.FromArgb(guestlogin.BackColor.R + fadingSpeed, guestlogin.BackColor.G + fadingSpeed, guestlogin.BackColor.B + fadingSpeed);

            if (35>= textBox1.BackColor.R)
            {
                textBox1.BackColor = Color.FromArgb(35, 35, 35);
                textBox2.BackColor = Color.FromArgb(35, 35, 35);
                label1.ForeColor = Color.FromArgb(35, 35, 35);
                label2.ForeColor = Color.FromArgb(35, 35, 35);
                label3.ForeColor = Color.FromArgb(35, 35, 35);
                label4.ForeColor = Color.FromArgb(35, 35, 35);

                fadingSpeed = 0;
            }

            if (35 >= signup.BackColor.R)
            {
                signup.BackColor = Color.FromArgb(35, 35, 35);
                forgetpassword.BackColor = Color.FromArgb(35, 35, 35);

                fadingSpeed2 = 0;
            }

            if (35 <= signup.BackColor.R)
            {
                signup.ForeColor = Color.FromArgb(35, 35, 35);
                forgetpassword.ForeColor = Color.FromArgb(35, 35, 35);
                textBox1.ForeColor = Color.FromArgb(35, 35, 35);
                textBox2.ForeColor = Color.FromArgb(35, 35, 35);

                fadingSpeed3 = 0;
            }

            if (89 >= loginbutton.ForeColor.R)
            {
                loginbutton.ForeColor = Color.FromArgb(89,89,89);
                guestlogin.ForeColor = Color.FromArgb(89, 89, 89);
                label5.ForeColor = Color.FromArgb(89, 89, 89);

                fadingSpeed4 = 0;
            }

            if (89 <= loginbutton.ForeColor.R)
            {
                loginbutton.BackColor = Color.FromArgb(89, 89, 89);
                guestlogin.BackColor = Color.FromArgb(89, 89, 89);

                fadingSpeed5 = 0;
            }
            if(fadingSpeed==0&& fadingSpeed2 == 0 && fadingSpeed3 == 0 && fadingSpeed4 == 0 && fadingSpeed5 == 0 && opacityvalue1 <= 0 && opacityvalue2 <= 0)
            {
                label1.Hide();
                label2.Hide();
                label3.Hide();
                label4.Hide();
                label5.Hide();
                textBox1.Hide();
                textBox2.Hide();
                signup.Hide();
                forgetpassword.Hide();
                loginbutton.Hide();
                guestlogin.Hide();
                pictureBox2.Hide();
                timer1.Stop();
                Delay(1000);
                timer2.Start();
            }

        }

        int loginanimation = -1;
        private void timer2_Tick(object sender, EventArgs e)//로그인후 로디이이미지
        {
            loginanimation+=2;
            if (loginanimation<=9)
            pictureBox1.Image = Image.FromFile("loginanimation\\newlogin160"+loginanimation+".jpg");
            if (loginanimation >=10)
                pictureBox1.Image = Image.FromFile("loginanimation\\newlogin16" + loginanimation+".jpg");
            if (loginanimation == 59)
                timer2.Stop();        
            Delay(1000);
            timer3.Start();
        }

        float opacityvalue3 = (float)0;
        private void timer3_Tick(object sender, EventArgs e)//로그인 후 이미지
        {
            opacityvalue3 += (float)0.03;
            pictureBox3.Location = new Point(405, 138);
            pictureBox3.Show();
            pictureBox3.Image = ChangeOpacity(Image.FromFile("profileimg.png"), opacityvalue3);

            if (opacityvalue3 >= (float)1)
            {
                timer3.Stop();
                timer4.Start();
                welcomelabel.Show();
                finallogion.Show();
                launcher.Show();
                relogin.Show();
            }
        }

        int fadingSpeed6 = 5;//35,35,35 -- White(255,255,255)
        int fadingSpeed7 = 5;//35,35,35 -- 192,192,192

        private void timer4_Tick(object sender, EventArgs e)
        {
            welcomelabel.ForeColor = Color.FromArgb(welcomelabel.ForeColor.R + fadingSpeed6, welcomelabel.ForeColor.G + fadingSpeed6, welcomelabel.ForeColor.B + fadingSpeed6);

            finallogion.BackColor = Color.FromArgb(finallogion.BackColor.R + fadingSpeed7, finallogion.BackColor.G + fadingSpeed7, finallogion.BackColor.B + fadingSpeed7);
            launcher.BackColor = Color.FromArgb(launcher.BackColor.R + fadingSpeed7, launcher.BackColor.G + fadingSpeed7, launcher.BackColor.B + fadingSpeed7);

            relogin.BackColor = Color.FromArgb(relogin.BackColor.R + fadingSpeed7, relogin.BackColor.G + fadingSpeed7, relogin.BackColor.B + fadingSpeed7);

            if (welcomelabel.ForeColor.R>=255)
            {
                welcomelabel.ForeColor = Color.FromArgb(255,255,255);
                fadingSpeed6 = 0;
            }

            if (finallogion.BackColor.R >=192)
            {
                finallogion.BackColor = Color.FromArgb(192,192,192);
                relogin.BackColor = Color.FromArgb(192, 192, 192);
                launcher.BackColor = Color.FromArgb(192, 192, 192);

                fadingSpeed7 = 0;
            }
            if(fadingSpeed6==0&&fadingSpeed7==0)
            {
                timer4.Stop();

            }
        }

        private void relogin_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void finallogion_Click(object sender, EventArgs e)
        {
            Main mainfrm = new Main();
            mainfrm.Show();
            this.Hide();
             }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox4.Image = Bitmap.FromFile("loginexit2.png");
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Bitmap.FromFile("loginexit.png");

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            Signup signfrm = new Signup();
            signfrm.StartPosition = FormStartPosition.CenterParent;
            signfrm.ShowDialog();
        }

        private void forgetpassword_Click(object sender, EventArgs e)
        {

        }

        private void launcher_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="Guestuser")
            {
                MessageBox.Show("게스트로는 이용할 수 없습니다!");
                goto exit;
            }
            Library libfrm = new Library();
            libfrm.Show();
            this.Hide();
        exit:;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void welcomelabel_Click(object sender, EventArgs e)
        {

        }

        private void guestlogin_Click(object sender, EventArgs e)
        {
            textBox1.Hide();
            textBox2.Hide();
            textBox1.Text = "Guestuser";
            textBox2.Text = "codingsibal";
            checkBox1.Hide();
            loginbutton.Text = "로그인중..........";

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("계정ID와P/W를 제대로 입력해주세요");
                goto loginexit;
            }

            MySqlConnection conn;
            string strconn = "Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8";
            conn = new MySqlConnection(strconn);


            try
            {
                conn.Open();
                string strSelect = "SELECT * from user_account where id=\"" + textBox1.Text + "\"";
                MySqlCommand cmd = new MySqlCommand(strSelect, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                if (rdr["password"].ToString() == textBox2.Text)
                {
                    welcomelabel.Text = rdr["nickname"].ToString() + " 님, 반갑습니다!";
                    timer1.Start();
                    Main.linktextid = textBox1.Text;
                    Main.linktextnickname = rdr["nickname"].ToString();
                    Library.userid = textBox1.Text;
                    Library.usernickname = rdr["nickname"].ToString();
                   
                    
                }
                else
                {
                    MessageBox.Show("비밀번호를 다시 확인해주세요");
                    textBox1.Focus();
                }

            }
            catch
            {
                MessageBox.Show("계정ID와P/W를 제대로 입력해주세요");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();
            }




        loginexit:;
            loginbutton.Text = "로그인";
        }
    }
}
