namespace Thedume
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.linkid = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.board = new System.Windows.Forms.Panel();
            this.Proimg = new System.Windows.Forms.PictureBox();
            this.linknickname = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.exitbutton = new System.Windows.Forms.Button();
            this.settingbutton = new System.Windows.Forms.Button();
            this.informationbutton = new System.Windows.Forms.Button();
            this.Installbutton = new System.Windows.Forms.Button();
            this.Dashboardbutton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Proimg)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.linkid);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1138, 32);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "55:55:55";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(920, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 32);
            this.button2.TabIndex = 22;
            this.button2.Text = "런쳐 시작!";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(634, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "접속 아이디 :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkid
            // 
            this.linkid.BackColor = System.Drawing.Color.Transparent;
            this.linkid.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.linkid.ForeColor = System.Drawing.Color.White;
            this.linkid.Location = new System.Drawing.Point(731, 1);
            this.linkid.Name = "linkid";
            this.linkid.Size = new System.Drawing.Size(185, 29);
            this.linkid.TabIndex = 20;
            this.linkid.Text = "asdf74591";
            this.linkid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1029, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "로그아웃!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 20;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // board
            // 
            this.board.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.board.BackColor = System.Drawing.Color.Gray;
            this.board.Location = new System.Drawing.Point(230, 32);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(905, 664);
            this.board.TabIndex = 8;
            // 
            // Proimg
            // 
            this.Proimg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Proimg.Image = ((System.Drawing.Image)(resources.GetObject("Proimg.Image")));
            this.Proimg.Location = new System.Drawing.Point(38, 432);
            this.Proimg.Name = "Proimg";
            this.Proimg.Size = new System.Drawing.Size(110, 110);
            this.Proimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Proimg.TabIndex = 9;
            this.Proimg.TabStop = false;
            // 
            // linknickname
            // 
            this.linknickname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linknickname.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linknickname.ForeColor = System.Drawing.Color.White;
            this.linknickname.Location = new System.Drawing.Point(6, 545);
            this.linknickname.Name = "linknickname";
            this.linknickname.Size = new System.Drawing.Size(177, 23);
            this.linknickname.TabIndex = 10;
            this.linknickname.Text = "Usernickname";
            this.linknickname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.exitbutton);
            this.panel2.Controls.Add(this.settingbutton);
            this.panel2.Controls.Add(this.informationbutton);
            this.panel2.Controls.Add(this.Installbutton);
            this.panel2.Controls.Add(this.Dashboardbutton);
            this.panel2.Controls.Add(this.Proimg);
            this.panel2.Controls.Add(this.linknickname);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 667);
            this.panel2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 634);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "asdf74591@gmail.com";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 611);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Made by DDE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(38, 23);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitbutton.FlatAppearance.BorderSize = 0;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.exitbutton.ForeColor = System.Drawing.Color.White;
            this.exitbutton.Location = new System.Drawing.Point(10, 345);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(168, 48);
            this.exitbutton.TabIndex = 18;
            this.exitbutton.Text = "종료하기";
            this.exitbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            this.exitbutton.MouseLeave += new System.EventHandler(this.exitbutton_MouseLeave);
            this.exitbutton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.exitbutton_MouseMove);
            // 
            // settingbutton
            // 
            this.settingbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.settingbutton.FlatAppearance.BorderSize = 0;
            this.settingbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.settingbutton.ForeColor = System.Drawing.Color.White;
            this.settingbutton.Location = new System.Drawing.Point(10, 129);
            this.settingbutton.Name = "settingbutton";
            this.settingbutton.Size = new System.Drawing.Size(168, 48);
            this.settingbutton.TabIndex = 17;
            this.settingbutton.Text = "런쳐 시작하기!";
            this.settingbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingbutton.UseVisualStyleBackColor = false;
            this.settingbutton.Click += new System.EventHandler(this.settingbutton_Click);
            this.settingbutton.MouseLeave += new System.EventHandler(this.settingbutton_MouseLeave);
            this.settingbutton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.settingbutton_MouseMove);
            // 
            // informationbutton
            // 
            this.informationbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.informationbutton.FlatAppearance.BorderSize = 0;
            this.informationbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.informationbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.informationbutton.ForeColor = System.Drawing.Color.White;
            this.informationbutton.Location = new System.Drawing.Point(10, 291);
            this.informationbutton.Name = "informationbutton";
            this.informationbutton.Size = new System.Drawing.Size(168, 48);
            this.informationbutton.TabIndex = 15;
            this.informationbutton.Text = "라이브러리";
            this.informationbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.informationbutton.UseVisualStyleBackColor = false;
            this.informationbutton.Click += new System.EventHandler(this.informationbutton_Click);
            this.informationbutton.MouseLeave += new System.EventHandler(this.informationbutton_MouseLeave);
            // 
            // Installbutton
            // 
            this.Installbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Installbutton.FlatAppearance.BorderSize = 0;
            this.Installbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Installbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Installbutton.ForeColor = System.Drawing.Color.White;
            this.Installbutton.Location = new System.Drawing.Point(10, 237);
            this.Installbutton.Name = "Installbutton";
            this.Installbutton.Size = new System.Drawing.Size(168, 48);
            this.Installbutton.TabIndex = 13;
            this.Installbutton.Text = "설치하기";
            this.Installbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Installbutton.UseVisualStyleBackColor = false;
            this.Installbutton.Click += new System.EventHandler(this.Installbutton_Click);
            this.Installbutton.MouseLeave += new System.EventHandler(this.Installbutton_MouseLeave);
            this.Installbutton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Installbutton_MouseMove);
            // 
            // Dashboardbutton
            // 
            this.Dashboardbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Dashboardbutton.FlatAppearance.BorderSize = 0;
            this.Dashboardbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboardbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Dashboardbutton.ForeColor = System.Drawing.Color.White;
            this.Dashboardbutton.Location = new System.Drawing.Point(10, 183);
            this.Dashboardbutton.Name = "Dashboardbutton";
            this.Dashboardbutton.Size = new System.Drawing.Size(168, 48);
            this.Dashboardbutton.TabIndex = 12;
            this.Dashboardbutton.Text = "인기순위";
            this.Dashboardbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboardbutton.UseVisualStyleBackColor = false;
            this.Dashboardbutton.Click += new System.EventHandler(this.Dashboardbutton_Click);
            this.Dashboardbutton.MouseLeave += new System.EventHandler(this.Dashboardbutton_MouseLeave);
            this.Dashboardbutton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dashboardbutton_MouseMove);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(230, 664);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1138, 699);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.board);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1138, 699);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TheDumE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Proimg)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Panel board;
        private System.Windows.Forms.PictureBox Proimg;
        private System.Windows.Forms.Label linknickname;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button informationbutton;
        private System.Windows.Forms.Button Installbutton;
        private System.Windows.Forms.Button Dashboardbutton;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label linkid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button settingbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

