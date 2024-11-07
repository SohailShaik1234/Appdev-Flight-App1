namespace Reg_Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            button1 = new Button();
            txtUser = new TextBox();
            txtPass = new TextBox();
            button3 = new Button();
            linkLabel1 = new LinkLabel();
            btnView = new Button();
            btnHide = new Button();
            linkLabel3 = new LinkLabel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.DarkSlateGray;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 5;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Candara", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(398, 256);
            button1.Name = "button1";
            button1.Size = new Size(171, 52);
            button1.TabIndex = 3;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtUser
            // 
            txtUser.Anchor = AnchorStyles.None;
            txtUser.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(263, 125);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Username/Email";
            txtUser.Size = new Size(417, 29);
            txtUser.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.Anchor = AnchorStyles.None;
            txtPass.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(263, 192);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.PlaceholderText = "Password";
            txtPass.Size = new Size(417, 29);
            txtPass.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(12, 3);
            button3.Name = "button3";
            button3.Size = new Size(52, 51);
            button3.TabIndex = 17;
            button3.TabStop = false;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(585, 224);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(95, 15);
            linkLabel1.TabIndex = 18;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot password";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnView
            // 
            btnView.Anchor = AnchorStyles.None;
            btnView.BackColor = Color.White;
            btnView.BackgroundImage = Properties.Resources.view;
            btnView.BackgroundImageLayout = ImageLayout.Stretch;
            btnView.Location = new Point(652, 192);
            btnView.Name = "btnView";
            btnView.Size = new Size(28, 29);
            btnView.TabIndex = 23;
            btnView.TabStop = false;
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // btnHide
            // 
            btnHide.Anchor = AnchorStyles.None;
            btnHide.BackColor = Color.White;
            btnHide.BackgroundImage = Properties.Resources.hide;
            btnHide.BackgroundImageLayout = ImageLayout.Stretch;
            btnHide.Location = new Point(652, 192);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(28, 29);
            btnHide.TabIndex = 26;
            btnHide.TabStop = false;
            btnHide.UseVisualStyleBackColor = false;
            btnHide.Click += btnHide_Click;
            // 
            // linkLabel3
            // 
            linkLabel3.Anchor = AnchorStyles.None;
            linkLabel3.AutoSize = true;
            linkLabel3.BackColor = Color.White;
            linkLabel3.Location = new Point(402, 315);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(162, 15);
            linkLabel3.TabIndex = 27;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "No Account? Create one here";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Malgun Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(388, 48);
            label1.Name = "label1";
            label1.Size = new Size(155, 65);
            label1.TabIndex = 32;
            label1.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(347, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 225);
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(915, 446);
            Controls.Add(label1);
            Controls.Add(linkLabel3);
            Controls.Add(btnView);
            Controls.Add(btnHide);
            Controls.Add(txtPass);
            Controls.Add(linkLabel1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(txtUser);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Login";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox txtUser;
        private TextBox txtPass;
        private Button button3;
        private LinkLabel linkLabel1;
        private Button btnView;
        private Button btnHide;
        private LinkLabel linkLabel3;
        private Label label1;
        private PictureBox pictureBox1;
    }
}