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
    public partial class Changeemail : Form
    {
        public Changeemail()
        {
            InitializeComponent();
        }
        public static string userid;
        public static string useremail;

        private void button1_Click(object sender, EventArgs e)
        {
            if (emailtext1.Text == "" || emailtext2.Text=="")
            {
                MessageBox.Show("바꿀 이메일을 입력해주세요!");
            }
            else
            {
                string eemail = emailtext1.Text + "@" + emailtext2.Text;
                MySqlConnection conn;
                string strconn = "Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8";
                conn = new MySqlConnection(strconn);
                conn.Open();
                string strSelect1 = "update user_account set email=\'" + eemail+ "\' where id=\'" + userid + "\'";
                MySqlCommand cmd1 = new MySqlCommand(strSelect1, conn);

                if (cmd1.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("닉네임이 변경되었습니다!\r\n어플리케이션을 재시작합니다!");
                    conn.Close();
                    Application.Restart();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Changeemail_Load(object sender, EventArgs e)
        {
            loginuseremail.Text = useremail;
        }
    }
}
