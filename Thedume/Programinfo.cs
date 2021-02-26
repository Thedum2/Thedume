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

namespace Thedume
{
    public partial class Programinfo : Form
    {
        public Programinfo()
        {
            InitializeComponent();
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]//폼 동그랗게 만들기
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect//폼 동그랗게 만들기
                                           , int nTopRect
                                           , int nRightRect
                                           , int nBottomRect
                                           , int nWidthEllipse
                                           , int nHeightEllipse);
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
        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start();
            this.Opacity = 1;
        }
        public static string engname;
        public static string korname;
        public static string proinfo;
        public static string proimg;
        public static string protag1;
        public static string protag2;
        public static string protag3;
        public static string protag4;
        public static string protag5;
        public static string prohomelink;
        public static string runwindow;
        private void Programinfo_Load(object sender, EventArgs e)
        {
            pictureBox1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox1.Width, pictureBox1.Height, 80, 80));// 동그랗게 만들기
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 90, 90));// 동그랗게 만들기

            this.Opacity = 0;
            timer1.Start();
            proengname.ForeColor = Color.Black;
            prokorname.ForeColor = Color.Black;
            proinfotext.ForeColor = Color.Black;
            exitbutton.Hide();
            exitbutton.FlatAppearance.BorderColor = Color.Black;
            exitbutton.ForeColor = Color.Black;

            button1.FlatAppearance.BorderColor = Color.Black;
            button2.FlatAppearance.BorderColor = Color.Black;

            button1.ForeColor = Color.Black;
            button2.ForeColor = Color.Black;

            label1.ForeColor = Color.Black;
            prolink.ForeColor = Color.Black;

            proengname.Text = engname;
            prokorname.Text = korname;
            proinfotext.Text = proinfo;
            button1.Text = protag1;
            button2.Text = protag2;
            try
            {
                pictureBox1.Load(proimg);
            }
            catch
            {
                pictureBox1.Image = null;
            }
            try
            {
                pictureBox2.Load(runwindow);
            }
            catch
            {
                pictureBox2.Image = null;
            }

            prolink.Text = "홈페이지 링크 : " + prohomelink;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1.0)
            {
                this.Opacity += 0.025;
            }
            else
            {
                timer1.Stop();
                timer6.Start();
                timer3.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.025;
            }
            else
            {
                timer2.Stop();
                Dispose();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int fadeSpeed = 5;
            proengname.ForeColor = Color.FromArgb(proengname.ForeColor.R + fadeSpeed, proengname.ForeColor.G + fadeSpeed, proengname.ForeColor.B + fadeSpeed);
            prokorname.ForeColor = Color.FromArgb(prokorname.ForeColor.R + fadeSpeed, prokorname.ForeColor.G + fadeSpeed, prokorname.ForeColor.B + fadeSpeed);
            button1.FlatAppearance.BorderColor = Color.FromArgb(button1.FlatAppearance.BorderColor.R + fadeSpeed, button1.FlatAppearance.BorderColor.G + fadeSpeed, button1.FlatAppearance.BorderColor.B + fadeSpeed);
            button2.FlatAppearance.BorderColor = Color.FromArgb(button2.FlatAppearance.BorderColor.R + fadeSpeed, button2.FlatAppearance.BorderColor.G + fadeSpeed, button2.FlatAppearance.BorderColor.B + fadeSpeed);
            button1.ForeColor = Color.FromArgb(button1.ForeColor.R + fadeSpeed, button1.ForeColor.G + fadeSpeed, button1.ForeColor.B + fadeSpeed);
            button2.ForeColor = Color.FromArgb(button2.ForeColor.R + fadeSpeed, button2.ForeColor.G + fadeSpeed, button2.ForeColor.B + fadeSpeed);
            label1.ForeColor = Color.FromArgb(label1.ForeColor.R + fadeSpeed, label1.ForeColor.G + fadeSpeed, label1.ForeColor.B + fadeSpeed);

            if (proengname.ForeColor.R >=255)
            {              
                proengname.ForeColor = Color.White;
                prokorname.ForeColor = Color.White;
                button1.FlatAppearance.BorderColor = Color.White;
                button2.FlatAppearance.BorderColor = Color.White;
                button1.ForeColor = Color.White;
                button2.ForeColor = Color.White;
                label1.ForeColor=Color.White;
                timer3.Stop();
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            int fadeSpeed = 15;
            proinfotext.ForeColor = Color.FromArgb(proinfotext.ForeColor.R + fadeSpeed, proinfotext.ForeColor.G + fadeSpeed, proinfotext.ForeColor.B + fadeSpeed);
            prolink.ForeColor = Color.FromArgb(prolink.ForeColor.R + 2, prolink.ForeColor.G + 2, prolink.ForeColor.B + fadeSpeed);

            if (proinfotext.ForeColor.R >= 255)
            {
                timer4.Stop();
                proinfotext.ForeColor = Color.White;
                prolink.ForeColor = Color.FromArgb(15,15,255);
                timer5.Start();
            }
        }
      
        private void timer5_Tick(object sender, EventArgs e)
        {
            exitbutton.Show();
            int fadeSpeed = 3;
            exitbutton.ForeColor = Color.FromArgb(exitbutton.ForeColor.R + fadeSpeed, exitbutton.ForeColor.G + fadeSpeed, exitbutton.ForeColor.B + fadeSpeed);
            exitbutton.FlatAppearance.BorderColor = Color.FromArgb(exitbutton.FlatAppearance.BorderColor.R + fadeSpeed, exitbutton.FlatAppearance.BorderColor.G + fadeSpeed, exitbutton.FlatAppearance.BorderColor.B + fadeSpeed);

            if (exitbutton.ForeColor.R >= 255)
            {
                timer5.Stop();
                exitbutton.ForeColor = Color.White;
                exitbutton.FlatAppearance.BorderColor = Color.White;
            }
        }

        float opacityvalue =0;
        private void timer6_Tick(object sender, EventArgs e)
        {
                timer6.Stop();
        }

        private void prolink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(prohomelink);
        }

    }
}
