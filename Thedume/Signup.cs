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
using System.Text.RegularExpressions;

namespace Thedume
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }
        Boolean idcheck,hangeulcheck,idfinalcheck,pwcheck1,pwcheck2;
        private void idhangeul(string idid)
        {
            hangeulcheck = false;
            string checkstring = idid;
            hangeulcheck = Regex.IsMatch(idid, @"^[a-zA-Z0-9]+$");
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }


        private void passwordreinsert_TextChanged(object sender, EventArgs e)
        {
            if ((passwordreinsert.Text == "") && (passwordinsert.Text == ""))
                passwordtest.Text = "";
            else if (passwordinsert.Text == passwordreinsert.Text)
            {
                passwordtest.Text = "비밀번호가 일치합니다!";
                passwordtest.ForeColor = Color.Green;
            }
            else
            {
                passwordtest.Text = "비밀번호가 일치하지 않습니다!";
                passwordtest.ForeColor = Color.Red;
            }
        }

        private void passwordinsert_TextChanged(object sender, EventArgs e)
        {
            if ((passwordreinsert.Text == "") && (passwordinsert.Text == ""))
                passwordtest.Text = "";
            else if (passwordinsert.Text == passwordreinsert.Text)
            {
                passwordtest.Text = "비밀번호가 일치합니다!";
                passwordtest.ForeColor = Color.Green;
            }
            else
            {
                passwordtest.Text = "비밀번호가 일치하지 않습니다!";
                passwordtest.ForeColor = Color.Red;
            }
        }


        private void signupbutton_Click(object sender, EventArgs e)
        {
            if(idinsert.Text==""||passwordinsert.Text==""||passwordreinsert.Text==""||nicknameinsert.Text==""||emailadressinsert.Text==""||emailidinsert.Text=="")
            {
                MessageBox.Show("모든 칸을 채워주세요","경고!");
                goto exit;
            }
            pwcheck1 = false;
            pwcheck2 = false;
            string pwstring1 = passwordinsert.Text;
            string pwstring2 = passwordreinsert.Text;
            pwcheck1 = Regex.IsMatch(pwstring1, @"^[a-zA-Z0-9~`!@#$%^&*()]+$");
            pwcheck2 = Regex.IsMatch(pwstring2, @"^[a-zA-Z0-9~`!@#$%^&*()]+$");

            if(pwcheck1==true && pwcheck2==true && idfinalcheck==true&&checkBox1.Checked==true&& (passwordreinsert.Text == passwordinsert.Text))
            {
                string useremail = emailidinsert.Text + "@" + emailadressinsert.Text;
                MySqlConnection conn;
                string strconn = "Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8";
                conn = new MySqlConnection(strconn);
                conn.Open();
                string strSelect1 ="INSERT INTO `user_account` (`id`, `password`, `nickname`, `email`) VALUES("+"\'"+idinsert.Text+"\',\'"+passwordinsert.Text+ "\',\'"+nicknameinsert.Text+ "\',\'"+useremail+"\'"+")";

                MySqlCommand cmd1 = new MySqlCommand(strSelect1, conn);

                try//예외 처리
                {
                    if (cmd1.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("회원가입이 완료되었습니다.\r\n가입을 축하합니다!");
                        Dispose();
                    }
                    else
                    {
                        MessageBox.Show("정보를 다시 한번 확인해 주세요!");
                    }
                }
                catch
                {
                    MessageBox.Show("오류발생! 재시작 바람!");
                }
            }
            else
            {
                MessageBox.Show("====다음 정보를 확인해 주세요====\r\n1.개인정보 수집 동의 여부\r\n2.비밀번호에는 영문과 숫자,특수기호(~`!@#$%^&*())\r\n외에는 들어갈 수 없습니다.\r\n3.아이디 중복확인 여부\r\n4.비밀번호와 비밀번호 재입력 칸이 같은지 확인!","회원가입 불가!");
            }
        exit:;
        }

        private void idcheckbutton_Click(object sender, EventArgs e)
        {

            idhangeul(idinsert.Text);

            if (hangeulcheck == false)
            {
                MessageBox.Show("영문과 숫자만 입력하실 수 있습니다");
                idinsert.Text = "";
                idinsert.Focus();
                goto pass;
            }
         


            idcheck = false;
            idfinalcheck = false;

            MySqlConnection conn;
            string strconn = "Server=coco74591.cafe24.com;Port=3306;Database=coco74591;Uid=coco74591;Pwd=thedume2@;Character Set=utf8";
            conn = new MySqlConnection(strconn);
            conn.Open();
            string strSelect1 = "SELECT id from user_account";
            MySqlCommand cmd1 = new MySqlCommand(strSelect1, conn);
            MySqlDataReader rdr1 = cmd1.ExecuteReader();



            while (rdr1.Read())
            {
                if (idinsert.Text == rdr1["id"].ToString())
                    idcheck = true;     
            }

            if (idcheck == true)
            { 
                MessageBox.Show("이 아이디는 이미 누가 사용하고 있네요!");
                idfinalcheck = false;
                idinsert.Text = "";
                idinsert.Focus();
            }
            else
            {
                MessageBox.Show("멋진 아이디네요!\r\n이 아이디를 사용하실 수 있습니다!");
                idinsert.ReadOnly = true;
                idinsert.BackColor = Color.Silver;
                idfinalcheck = true;
            }
        pass:;
        }
    }
}
