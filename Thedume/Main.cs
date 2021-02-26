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


namespace Thedume
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
 
        }
        public static string linktextid;
        public static string linktextnickname;


        private Point mousePoint;//마우스포인터 변수

        Boolean dasbutton = false,insbutton=false,infbutton=false,setbutton=false,exibutton=false;//버튼 색 

        Dashboard daspanel = new Dashboard();
        Install inspanel = new Install();
        Library libpanel = new Library();
        Information infpanel = new Information();
        Setting setpanel = new Setting();
       
        private void buttonclear()//버튼 색 변수 초기화
        {
            dasbutton = false;
             insbutton = false;
                infbutton = false;
                exibutton = false;

            Dashboardbutton.BackColor = Color.FromArgb(64, 64, 64);
            Dashboardbutton.FlatAppearance.BorderSize = 0;
            Installbutton.BackColor = Color.FromArgb(64, 64, 64);
            Installbutton.FlatAppearance.BorderSize = 0;
            informationbutton.BackColor = Color.FromArgb(64, 64, 64);
            informationbutton.FlatAppearance.BorderSize = 0;
            settingbutton.BackColor = Color.FromArgb(64, 64, 64);
            settingbutton.FlatAppearance.BorderSize = 0;
            exitbutton.BackColor = Color.FromArgb(64, 64, 64);
            exitbutton.FlatAppearance.BorderSize = 0;


        }
        protected override void WndProc(ref Message m)
        {
            const int RESIZE_HANDLE_SIZE = 10;
            switch (m.Msg)
            {
                case 0x0084/*NCHITTEST*/ :
                    base.WndProc(ref m);            
                    if ((int)m.Result == 0x01/*HTCLIENT*/)

                    {
                        Point screenPoint = new Point(m.LParam.ToInt32());
                        Point clientPoint = this.PointToClient(screenPoint);
                        if (clientPoint.Y <= RESIZE_HANDLE_SIZE)
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)13/*HTTOPLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)12/*HTTOP*/ ;
                            else
                                m.Result = (IntPtr)14/*HTTOPRIGHT*/ ;
                        }
                        else if (clientPoint.Y <= (Size.Height - RESIZE_HANDLE_SIZE))
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)10/*HTLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)2/*HTCAPTION*/ ;
                            else
                                m.Result = (IntPtr)11/*HTRIGHT*/ ;
                        }
                        else
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)16/*HTBOTTOMLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)15/*HTBOTTOM*/ ;
                            else
                                m.Result = (IntPtr)17/*HTBOTTOMRIGHT*/ ;
                        }
                    }
                    return;
            }
            base.WndProc(ref m);
        } //창 크기 조절
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- use 0x20000
                return cp;
            }
        } //창 크기 조절
        private void Formhide()//패널 안의 폼 숨기기
        {
            daspanel.Hide();
            inspanel.Hide();
            libpanel.Hide();
            infpanel.Hide();
            setpanel.Hide();
        }
        private void Main_Load(object sender, EventArgs e)
        {

            timer2.Start();
            timer3.Start();
            this.Opacity = 0.1;
            Proimg.BringToFront();

            linkid.Text = linktextid;
            linknickname.Text = linktextnickname;

            Information.userid = linkid.Text;
            Install.userinfo = linkid.Text;
            //프로필이미지 원형
            // // 소스이미지 가져오기
            var src = (Bitmap)Bitmap.FromFile("profileimg.png");

            // 소스이미지 크기와 동일한 타겟이미지 생성
            Bitmap tgt = new Bitmap(src.Width, src.Height);

            // 타겟이미지의 Graphics 객체 얻기        
            using (Graphics g = Graphics.FromImage(tgt))
            {
                // 배경색을 설정
                var rect = new Rectangle(0, 0, tgt.Width, tgt.Height);
                using (Brush br = new SolidBrush(Color.FromArgb(64,64,64)))
                {
                    g.FillRectangle(br, 0, 0, tgt.Width, tgt.Height);
                }

                // 원모양으로 Clip
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(0, 0, tgt.Width, tgt.Height);
                g.SetClip(path);

                // 소스이미지를 원모양으로 잘라 타겟이미지에 출력
                g.DrawImage(src, 0, 0);
            }

            // PictureBox에 이미지 출력
            Proimg.Image = tgt;




        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }//종료시 모든 프로세스 종료
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }//창 이동
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }//창 이동
        private void timer1_Tick(object sender, EventArgs e)//폼 종료시 타이머
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.025;
            }
            else
            {
                timer1.Stop();
                Application.Exit();
            }
        }
         private void timer2_Tick(object sender, EventArgs e)//폼 실행시 타이머
        {
            if (this.Opacity < 1.0)
            {
                this.Opacity += 0.025;
            }
            else
            {
                timer2.Stop();
            }
        }
        private void timer3_Tick(object sender, EventArgs e)//시계 타이머
        {
            label1.Text = System.DateTime.Now.ToString("hh:mm:ss");
        }
        private void Dashboardbutton_MouseMove(object sender, MouseEventArgs e)
        {
            Dashboardbutton.BackColor = Color.Teal;
            Dashboardbutton.FlatAppearance.BorderSize = 1;
        }//마우스호버 색 지정
        private void Dashboardbutton_MouseLeave(object sender, EventArgs e)
        {
            if (dasbutton == false)
            {
                Dashboardbutton.BackColor = Color.FromArgb(64, 64, 64);
                Dashboardbutton.FlatAppearance.BorderSize = 0;
            } 
        }//컨트롤 바깥으로 나갔을때
        private void Installbutton_MouseMove(object sender, MouseEventArgs e)
        {
            Installbutton.BackColor = Color.Teal;
            Installbutton.FlatAppearance.BorderSize = 1;
        }//마우스호버 색 지정
        private void Installbutton_MouseLeave(object sender, EventArgs e)
        {
            if (insbutton == false)
            {
                Installbutton.BackColor = Color.FromArgb(64, 64, 64);
                Installbutton.FlatAppearance.BorderSize = 0;
            }
        }//컨트롤 바깥으로 나갔을때

     
        private void informationbutton_MouseLeave(object sender, EventArgs e)
        {
            if (infbutton == false)
            {
                informationbutton.BackColor = Color.FromArgb(64, 64, 64);
                informationbutton.FlatAppearance.BorderSize = 0;
            }

        }//컨트롤 바깥으로 나갔을때
        private void settingbutton_MouseMove(object sender, MouseEventArgs e)
        {
            settingbutton.BackColor = Color.Teal;
            settingbutton.FlatAppearance.BorderSize = 1;
        }//마우스호버 색 지정
        private void settingbutton_MouseLeave(object sender, EventArgs e)
        {
            if (setbutton == false)
            {
                settingbutton.BackColor = Color.FromArgb(64, 64, 64);
                settingbutton.FlatAppearance.BorderSize = 0;
            }
        }//컨트롤 바깥으로 나갔을때
        private void exitbutton_MouseMove(object sender, MouseEventArgs e)
        {
            exitbutton.BackColor = Color.Teal;
            exitbutton.FlatAppearance.BorderSize = 1;
        }//마우스호버 색 지정
        private void exitbutton_MouseLeave(object sender, EventArgs e)
        {
            if (exibutton == false)
            {
                exitbutton.BackColor = Color.FromArgb(64, 64, 64);
                exitbutton.FlatAppearance.BorderSize = 0;
            }
        }//컨트롤 바깥으로 나갔을때
        private void Dashboardbutton_Click(object sender, EventArgs e)
        {
            buttonclear();
            Dashboardbutton.BackColor = Color.Teal;
            Dashboardbutton.FlatAppearance.BorderSize = 1;
            dasbutton = true;

            board.Controls.Clear();
            daspanel.TopLevel = false;
            board.Controls.Add(daspanel);
            Formhide();
            daspanel.Show();
            daspanel.Dock = DockStyle.Fill;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (linkid.Text == "Guestuser")
            {
                MessageBox.Show("게스트로는 이용 할 수 없습니다!");
                goto exit;
            }
            this.Dispose();

            Library libfrm = new Library();
            this.Hide();
            libfrm.Show();
        exit:;
        }

        private void Installbutton_Click(object sender, EventArgs e)
        {
            buttonclear();
            Installbutton.BackColor = Color.Teal;
            Installbutton.FlatAppearance.BorderSize = 1;
            insbutton = true;

            board.Controls.Clear();
            inspanel.TopLevel = false;
            board.Controls.Add(inspanel);
            Formhide();
            inspanel.Show();
            inspanel.Dock = DockStyle.Fill;
        }
    
        private void informationbutton_Click(object sender, EventArgs e)
        {
            if(linkid.Text=="Guestuser")
            {
                MessageBox.Show("게스트로는 이용 할 수 없습니다!");
                goto exit;
            }
            buttonclear();
            informationbutton.BackColor = Color.Teal;
            informationbutton.FlatAppearance.BorderSize = 1;        
            infbutton = true;

            board.Controls.Clear();
            infpanel.TopLevel = false;
            board.Controls.Add(infpanel);
            Formhide();
            infpanel.Show();
            infpanel.Dock = DockStyle.Fill;
        exit:;
        }
       
        private void settingbutton_Click(object sender, EventArgs e)
        {
            if (linkid.Text == "Guestuser")
            {
                MessageBox.Show("게스트로는 이용 할 수 없습니다!");
                goto exit;
            }
            buttonclear();
            settingbutton.BackColor = Color.Teal;
            settingbutton.FlatAppearance.BorderSize = 1;   
            setbutton = true;

            board.Controls.Clear();
            setpanel.TopLevel = false;
            board.Controls.Add(setpanel);
            Formhide();
            setpanel.Show();
            setpanel.Dock = DockStyle.Fill;

            Library libfrm = new Library();
            this.Hide();
            libfrm.Show();
        exit:;
        }
        private void exitbutton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
