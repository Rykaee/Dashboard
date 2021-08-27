namespace dashboard
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel3 = new System.Windows.Forms.Panel();
            this.datetimelabel = new System.Windows.Forms.Label();
            this.pictPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.logpanel = new System.Windows.Forms.Panel();
            this.letsgoButton = new System.Windows.Forms.Button();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.usernTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.usernameLab = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.loggedPanel = new System.Windows.Forms.Panel();
            this.gamerPanel = new System.Windows.Forms.Panel();
            this.listofNews = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bgImg = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.pictPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.logpanel.SuspendLayout();
            this.loggedPanel.SuspendLayout();
            this.gamerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bgImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(133)))), ((int)(((byte)(175)))));
            this.panel3.Controls.Add(this.datetimelabel);
            this.panel3.Controls.Add(this.pictPanel);
            this.panel3.Controls.Add(this.loginButton);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1102, 64);
            this.panel3.TabIndex = 0;
            // 
            // datetimelabel
            // 
            this.datetimelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datetimelabel.AutoSize = true;
            this.datetimelabel.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(224)))), ((int)(((byte)(229)))));
            this.datetimelabel.Location = new System.Drawing.Point(777, 13);
            this.datetimelabel.Name = "datetimelabel";
            this.datetimelabel.Size = new System.Drawing.Size(213, 33);
            this.datetimelabel.TabIndex = 3;
            this.datetimelabel.Text = "date and time";
            this.datetimelabel.Visible = false;
            // 
            // pictPanel
            // 
            this.pictPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictPanel.Controls.Add(this.pictureBox1);
            this.pictPanel.Location = new System.Drawing.Point(996, 3);
            this.pictPanel.Name = "pictPanel";
            this.pictPanel.Size = new System.Drawing.Size(94, 55);
            this.pictPanel.TabIndex = 2;
            this.pictPanel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // loginButton
            // 
            this.loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(133)))), ((int)(((byte)(175)))));
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(224)))), ((int)(((byte)(229)))));
            this.loginButton.Location = new System.Drawing.Point(980, 12);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(98, 40);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(224)))), ((int)(((byte)(229)))));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 43);
            this.label5.TabIndex = 0;
            this.label5.Text = "Admin Dash";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(68)))), ((int)(((byte)(114)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 536);
            this.panel4.TabIndex = 1;
            // 
            // logpanel
            // 
            this.logpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(183)))), ((int)(((byte)(189)))));
            this.logpanel.Controls.Add(this.letsgoButton);
            this.logpanel.Controls.Add(this.passTextBox);
            this.logpanel.Controls.Add(this.usernTextBox);
            this.logpanel.Controls.Add(this.label7);
            this.logpanel.Controls.Add(this.usernameLab);
            this.logpanel.Controls.Add(this.label6);
            this.logpanel.Location = new System.Drawing.Point(400, 174);
            this.logpanel.Name = "logpanel";
            this.logpanel.Size = new System.Drawing.Size(409, 268);
            this.logpanel.TabIndex = 2;
            this.logpanel.Visible = false;
            // 
            // letsgoButton
            // 
            this.letsgoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(183)))), ((int)(((byte)(189)))));
            this.letsgoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letsgoButton.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letsgoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(224)))), ((int)(((byte)(229)))));
            this.letsgoButton.Location = new System.Drawing.Point(301, 219);
            this.letsgoButton.Name = "letsgoButton";
            this.letsgoButton.Size = new System.Drawing.Size(95, 33);
            this.letsgoButton.TabIndex = 6;
            this.letsgoButton.Text = "Lets go!";
            this.letsgoButton.UseVisualStyleBackColor = true;
            this.letsgoButton.Click += new System.EventHandler(this.letsgoButton_Click);
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(149, 152);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '*';
            this.passTextBox.Size = new System.Drawing.Size(131, 20);
            this.passTextBox.TabIndex = 5;
            // 
            // usernTextBox
            // 
            this.usernTextBox.Location = new System.Drawing.Point(149, 109);
            this.usernTextBox.Name = "usernTextBox";
            this.usernTextBox.Size = new System.Drawing.Size(131, 20);
            this.usernTextBox.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(224)))), ((int)(((byte)(229)))));
            this.label7.Location = new System.Drawing.Point(21, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 26);
            this.label7.TabIndex = 3;
            this.label7.Text = "Password";
            // 
            // usernameLab
            // 
            this.usernameLab.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usernameLab.AutoSize = true;
            this.usernameLab.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(224)))), ((int)(((byte)(229)))));
            this.usernameLab.Location = new System.Drawing.Point(21, 103);
            this.usernameLab.Name = "usernameLab";
            this.usernameLab.Size = new System.Drawing.Size(114, 26);
            this.usernameLab.TabIndex = 2;
            this.usernameLab.Text = "Username";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(224)))), ((int)(((byte)(229)))));
            this.label6.Location = new System.Drawing.Point(141, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 43);
            this.label6.TabIndex = 1;
            this.label6.Text = "Login";
            // 
            // loggedPanel
            // 
            this.loggedPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loggedPanel.AutoSize = true;
            this.loggedPanel.Controls.Add(this.gamerPanel);
            this.loggedPanel.Controls.Add(this.label8);
            this.loggedPanel.Controls.Add(this.bgImg);
            this.loggedPanel.Location = new System.Drawing.Point(199, 64);
            this.loggedPanel.Name = "loggedPanel";
            this.loggedPanel.Size = new System.Drawing.Size(903, 569);
            this.loggedPanel.TabIndex = 3;
            this.loggedPanel.Visible = false;
            // 
            // gamerPanel
            // 
            this.gamerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gamerPanel.AutoSize = true;
            this.gamerPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gamerPanel.BackColor = System.Drawing.Color.Transparent;
            this.gamerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gamerPanel.Controls.Add(this.listofNews);
            this.gamerPanel.Controls.Add(this.label9);
            this.gamerPanel.ForeColor = System.Drawing.Color.Transparent;
            this.gamerPanel.Location = new System.Drawing.Point(201, 123);
            this.gamerPanel.Name = "gamerPanel";
            this.gamerPanel.Size = new System.Drawing.Size(463, 285);
            this.gamerPanel.TabIndex = 2;
            this.gamerPanel.Visible = false;
            // 
            // listofNews
            // 
            this.listofNews.HideSelection = false;
            this.listofNews.Location = new System.Drawing.Point(3, 46);
            this.listofNews.Name = "listofNews";
            this.listofNews.Size = new System.Drawing.Size(457, 236);
            this.listofNews.TabIndex = 1;
            this.listofNews.UseCompatibleStateImageBehavior = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(190, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 33);
            this.label9.TabIndex = 0;
            this.label9.Text = "News";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(127, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(626, 83);
            this.label8.TabIndex = 1;
            this.label8.Text = "Welcome Gamer!";
            // 
            // bgImg
            // 
            this.bgImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgImg.Image = ((System.Drawing.Image)(resources.GetObject("bgImg.Image")));
            this.bgImg.Location = new System.Drawing.Point(0, 0);
            this.bgImg.Name = "bgImg";
            this.bgImg.Size = new System.Drawing.Size(903, 569);
            this.bgImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bgImg.TabIndex = 0;
            this.bgImg.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1102, 600);
            this.Controls.Add(this.loggedPanel);
            this.Controls.Add(this.logpanel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pictPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.logpanel.ResumeLayout(false);
            this.logpanel.PerformLayout();
            this.loggedPanel.ResumeLayout(false);
            this.loggedPanel.PerformLayout();
            this.gamerPanel.ResumeLayout(false);
            this.gamerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bgImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel logpanel;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.TextBox usernTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label usernameLab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button letsgoButton;
        private System.Windows.Forms.Panel loggedPanel;
        private System.Windows.Forms.PictureBox bgImg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pictPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel gamerPanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label datetimelabel;
        private System.Windows.Forms.ListView listofNews;
    }
}

