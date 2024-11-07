namespace Reg_Login
{
    partial class Create_Account
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create_Account));
            txtCreatePass = new TextBox();
            txtCreateUser = new TextBox();
            button1 = new Button();
            txtCreateMail = new TextBox();
            button3 = new Button();
            txtPasswordConfirm = new TextBox();
            txtID = new TextBox();
            lblidCheck = new Label();
            btnView = new Button();
            btnHide = new Button();
            btnConfirmView = new Button();
            btnConfirmHide = new Button();
            txtSecQuestion = new TextBox();
            linkLabel1 = new LinkLabel();
            chkTnC = new CheckBox();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtCreatePass
            // 
            txtCreatePass.Anchor = AnchorStyles.None;
            txtCreatePass.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCreatePass.Location = new Point(239, 282);
            txtCreatePass.Name = "txtCreatePass";
            txtCreatePass.PasswordChar = '*';
            txtCreatePass.PlaceholderText = "Password";
            txtCreatePass.Size = new Size(417, 29);
            txtCreatePass.TabIndex = 4;
            txtCreatePass.TextChanged += txtCreatePass_TextChanged;
            // 
            // txtCreateUser
            // 
            txtCreateUser.Anchor = AnchorStyles.None;
            txtCreateUser.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCreateUser.Location = new Point(239, 231);
            txtCreateUser.Name = "txtCreateUser";
            txtCreateUser.PlaceholderText = "Username";
            txtCreateUser.Size = new Size(417, 29);
            txtCreateUser.TabIndex = 3;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.DarkSlateGray;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 5;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Candara", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(318, 469);
            button1.Name = "button1";
            button1.Size = new Size(247, 47);
            button1.TabIndex = 7;
            button1.Text = "Create Account";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtCreateMail
            // 
            txtCreateMail.Anchor = AnchorStyles.None;
            txtCreateMail.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCreateMail.Location = new Point(240, 184);
            txtCreateMail.Name = "txtCreateMail";
            txtCreateMail.PlaceholderText = "Email";
            txtCreateMail.Size = new Size(417, 29);
            txtCreateMail.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(12, 9);
            button3.Name = "button3";
            button3.Size = new Size(52, 51);
            button3.TabIndex = 0;
            button3.TabStop = false;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtPasswordConfirm
            // 
            txtPasswordConfirm.Anchor = AnchorStyles.None;
            txtPasswordConfirm.Enabled = false;
            txtPasswordConfirm.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPasswordConfirm.Location = new Point(239, 335);
            txtPasswordConfirm.Name = "txtPasswordConfirm";
            txtPasswordConfirm.PasswordChar = '*';
            txtPasswordConfirm.PlaceholderText = "Confirm Password";
            txtPasswordConfirm.Size = new Size(417, 29);
            txtPasswordConfirm.TabIndex = 5;
            txtPasswordConfirm.TextChanged += txtPasswordConfirm_TextChanged;
            // 
            // txtID
            // 
            txtID.Anchor = AnchorStyles.None;
            txtID.BackColor = Color.White;
            txtID.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.Location = new Point(239, 137);
            txtID.MaxLength = 13;
            txtID.Name = "txtID";
            txtID.PlaceholderText = "ID Number";
            txtID.Size = new Size(417, 29);
            txtID.TabIndex = 1;
            txtID.TextChanged += txtID_TextChanged;
            txtID.KeyPress += txtID_KeyPress;
            // 
            // lblidCheck
            // 
            lblidCheck.Anchor = AnchorStyles.None;
            lblidCheck.AutoSize = true;
            lblidCheck.BackColor = Color.Transparent;
            lblidCheck.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblidCheck.Location = new Point(600, 135);
            lblidCheck.Name = "lblidCheck";
            lblidCheck.Size = new Size(0, 30);
            lblidCheck.TabIndex = 21;
            // 
            // btnView
            // 
            btnView.Anchor = AnchorStyles.None;
            btnView.BackColor = Color.White;
            btnView.BackgroundImage = Properties.Resources.view;
            btnView.BackgroundImageLayout = ImageLayout.Stretch;
            btnView.Location = new Point(627, 282);
            btnView.Name = "btnView";
            btnView.Size = new Size(29, 29);
            btnView.TabIndex = 0;
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
            btnHide.Location = new Point(627, 282);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(29, 29);
            btnHide.TabIndex = 0;
            btnHide.TabStop = false;
            btnHide.UseVisualStyleBackColor = false;
            btnHide.Click += btnHide_Click;
            // 
            // btnConfirmView
            // 
            btnConfirmView.Anchor = AnchorStyles.None;
            btnConfirmView.BackColor = Color.White;
            btnConfirmView.BackgroundImage = Properties.Resources.view;
            btnConfirmView.BackgroundImageLayout = ImageLayout.Stretch;
            btnConfirmView.Location = new Point(627, 335);
            btnConfirmView.Name = "btnConfirmView";
            btnConfirmView.Size = new Size(29, 28);
            btnConfirmView.TabIndex = 0;
            btnConfirmView.TabStop = false;
            btnConfirmView.UseVisualStyleBackColor = false;
            btnConfirmView.Click += btnConfirmView_Click;
            // 
            // btnConfirmHide
            // 
            btnConfirmHide.Anchor = AnchorStyles.None;
            btnConfirmHide.BackColor = Color.White;
            btnConfirmHide.BackgroundImage = Properties.Resources.hide;
            btnConfirmHide.BackgroundImageLayout = ImageLayout.Stretch;
            btnConfirmHide.Location = new Point(627, 335);
            btnConfirmHide.Name = "btnConfirmHide";
            btnConfirmHide.Size = new Size(29, 29);
            btnConfirmHide.TabIndex = 0;
            btnConfirmHide.TabStop = false;
            btnConfirmHide.UseVisualStyleBackColor = false;
            btnConfirmHide.Click += btnConfirmHide_Click;
            // 
            // txtSecQuestion
            // 
            txtSecQuestion.Anchor = AnchorStyles.None;
            txtSecQuestion.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSecQuestion.Location = new Point(240, 389);
            txtSecQuestion.Name = "txtSecQuestion";
            txtSecQuestion.PlaceholderText = "Favourite Color";
            txtSecQuestion.Size = new Size(417, 29);
            txtSecQuestion.TabIndex = 6;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(378, 421);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(122, 15);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Terms and Conditions";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // chkTnC
            // 
            chkTnC.Anchor = AnchorStyles.None;
            chkTnC.AutoSize = true;
            chkTnC.Location = new Point(506, 421);
            chkTnC.Name = "chkTnC";
            chkTnC.Size = new Size(15, 14);
            chkTnC.TabIndex = 0;
            chkTnC.TabStop = false;
            chkTnC.UseVisualStyleBackColor = true;
            // 
            // linkLabel2
            // 
            linkLabel2.Anchor = AnchorStyles.None;
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.Location = new Point(660, 395);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(12, 15);
            linkLabel2.TabIndex = 30;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "?";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.Anchor = AnchorStyles.None;
            linkLabel3.AutoSize = true;
            linkLabel3.BackColor = Color.White;
            linkLabel3.Location = new Point(348, 519);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(177, 15);
            linkLabel3.TabIndex = 0;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Already have an Account? Login";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Malgun Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(258, 69);
            label1.Name = "label1";
            label1.Size = new Size(377, 65);
            label1.TabIndex = 31;
            label1.Text = "Create Account";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(321, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 225);
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // Create_Account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(857, 541);
            Controls.Add(txtID);
            Controls.Add(txtCreateMail);
            Controls.Add(linkLabel2);
            Controls.Add(txtCreateUser);
            Controls.Add(label1);
            Controls.Add(btnView);
            Controls.Add(btnConfirmView);
            Controls.Add(linkLabel3);
            Controls.Add(chkTnC);
            Controls.Add(linkLabel1);
            Controls.Add(txtSecQuestion);
            Controls.Add(lblidCheck);
            Controls.Add(txtPasswordConfirm);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(txtCreatePass);
            Controls.Add(btnHide);
            Controls.Add(btnConfirmHide);
            Controls.Add(pictureBox1);
            Name = "Create_Account";
            Text = "Create Account";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCreatePass;
        private TextBox txtCreateUser;
        private Button button1;
        private TextBox txtCreateMail;
        private Button button3;
        private TextBox txtID;
        private Label lblidCheck;
        private Button btnView;
        private Button btnHide;
        private Button btnConfirmView;
        private Button btnConfirmHide;
        private TextBox txtSecQuestion;
        private LinkLabel linkLabel1;
        private CheckBox chkTnC;
        public TextBox txtPasswordConfirm;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
