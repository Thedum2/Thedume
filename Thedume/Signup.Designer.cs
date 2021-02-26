
namespace Thedume
{
    partial class Signup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idinsert = new System.Windows.Forms.TextBox();
            this.idcheckbutton = new System.Windows.Forms.Button();
            this.passwordinsert = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordreinsert = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailidinsert = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.emailadressinsert = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.signupbutton = new System.Windows.Forms.Button();
            this.nicknameinsert = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.passwordtest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(136, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(120, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sign up";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            // 
            // idinsert
            // 
            this.idinsert.BackColor = System.Drawing.Color.Black;
            this.idinsert.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idinsert.ForeColor = System.Drawing.Color.White;
            this.idinsert.Location = new System.Drawing.Point(16, 151);
            this.idinsert.MaxLength = 15;
            this.idinsert.Name = "idinsert";
            this.idinsert.Size = new System.Drawing.Size(293, 29);
            this.idinsert.TabIndex = 3;
            // 
            // idcheckbutton
            // 
            this.idcheckbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.idcheckbutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.idcheckbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.idcheckbutton.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.idcheckbutton.ForeColor = System.Drawing.Color.White;
            this.idcheckbutton.Location = new System.Drawing.Point(238, 126);
            this.idcheckbutton.Name = "idcheckbutton";
            this.idcheckbutton.Size = new System.Drawing.Size(70, 22);
            this.idcheckbutton.TabIndex = 4;
            this.idcheckbutton.Text = "중복확인";
            this.idcheckbutton.UseVisualStyleBackColor = true;
            this.idcheckbutton.Click += new System.EventHandler(this.idcheckbutton_Click);
            // 
            // passwordinsert
            // 
            this.passwordinsert.BackColor = System.Drawing.Color.Black;
            this.passwordinsert.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordinsert.ForeColor = System.Drawing.Color.White;
            this.passwordinsert.Location = new System.Drawing.Point(16, 222);
            this.passwordinsert.MaxLength = 20;
            this.passwordinsert.Name = "passwordinsert";
            this.passwordinsert.PasswordChar = '*';
            this.passwordinsert.Size = new System.Drawing.Size(293, 29);
            this.passwordinsert.TabIndex = 6;
            this.passwordinsert.TextChanged += new System.EventHandler(this.passwordinsert_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // passwordreinsert
            // 
            this.passwordreinsert.BackColor = System.Drawing.Color.Black;
            this.passwordreinsert.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordreinsert.ForeColor = System.Drawing.Color.White;
            this.passwordreinsert.Location = new System.Drawing.Point(16, 289);
            this.passwordreinsert.Name = "passwordreinsert";
            this.passwordreinsert.PasswordChar = '*';
            this.passwordreinsert.Size = new System.Drawing.Size(293, 29);
            this.passwordreinsert.TabIndex = 8;
            this.passwordreinsert.TextChanged += new System.EventHandler(this.passwordreinsert_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password 재입력";
            // 
            // emailidinsert
            // 
            this.emailidinsert.BackColor = System.Drawing.Color.Black;
            this.emailidinsert.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailidinsert.ForeColor = System.Drawing.Color.White;
            this.emailidinsert.Location = new System.Drawing.Point(16, 424);
            this.emailidinsert.Name = "emailidinsert";
            this.emailidinsert.Size = new System.Drawing.Size(124, 29);
            this.emailidinsert.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "이메일";
            // 
            // emailadressinsert
            // 
            this.emailadressinsert.BackColor = System.Drawing.Color.Black;
            this.emailadressinsert.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailadressinsert.ForeColor = System.Drawing.Color.White;
            this.emailadressinsert.Location = new System.Drawing.Point(172, 424);
            this.emailadressinsert.Name = "emailadressinsert";
            this.emailadressinsert.Size = new System.Drawing.Size(137, 29);
            this.emailadressinsert.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(146, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "@";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(19, 479);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 16);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "개인정보 수집 동의";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // signupbutton
            // 
            this.signupbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupbutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.signupbutton.FlatAppearance.BorderSize = 2;
            this.signupbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupbutton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.signupbutton.ForeColor = System.Drawing.Color.White;
            this.signupbutton.Location = new System.Drawing.Point(18, 501);
            this.signupbutton.Name = "signupbutton";
            this.signupbutton.Size = new System.Drawing.Size(291, 34);
            this.signupbutton.TabIndex = 14;
            this.signupbutton.Text = "회원가입하기";
            this.signupbutton.UseVisualStyleBackColor = true;
            this.signupbutton.Click += new System.EventHandler(this.signupbutton_Click);
            // 
            // nicknameinsert
            // 
            this.nicknameinsert.BackColor = System.Drawing.Color.Black;
            this.nicknameinsert.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicknameinsert.ForeColor = System.Drawing.Color.White;
            this.nicknameinsert.Location = new System.Drawing.Point(16, 357);
            this.nicknameinsert.MaxLength = 10;
            this.nicknameinsert.Name = "nicknameinsert";
            this.nicknameinsert.Size = new System.Drawing.Size(293, 29);
            this.nicknameinsert.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "닉네임";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(16, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "※영문,숫자를 조합해서 6자~15자로 조합하세요";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(16, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(250, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "※영문,숫자를 조합해서 7자~20자로 조합하세요";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(16, 388);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(228, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "※한글,영문,숫자 2자~10자로 조합해주세요";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(15, 456);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(236, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "※이메일은 상업적 용도로 이용되지 않습니다.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 113);
            this.panel1.TabIndex = 22;
            // 
            // passwordtest
            // 
            this.passwordtest.AutoSize = true;
            this.passwordtest.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtest.ForeColor = System.Drawing.Color.White;
            this.passwordtest.Location = new System.Drawing.Point(16, 321);
            this.passwordtest.Name = "passwordtest";
            this.passwordtest.Size = new System.Drawing.Size(18, 16);
            this.passwordtest.TabIndex = 24;
            this.passwordtest.Text = "※";
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(326, 550);
            this.Controls.Add(this.passwordtest);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nicknameinsert);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.signupbutton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.emailadressinsert);
            this.Controls.Add(this.emailidinsert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passwordreinsert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordinsert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idcheckbutton);
            this.Controls.Add(this.idinsert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Signup";
            this.Text = "TheDumE Sign up";
            this.Load += new System.EventHandler(this.Signup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idinsert;
        private System.Windows.Forms.Button idcheckbutton;
        private System.Windows.Forms.TextBox passwordinsert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordreinsert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailidinsert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailadressinsert;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button signupbutton;
        private System.Windows.Forms.TextBox nicknameinsert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label passwordtest;
    }
}