namespace Reg_Login
{
    partial class ForgotPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPass));
            label1 = new Label();
            txtEmail = new TextBox();
            txtSecurityAnswer = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtNewPassword = new TextBox();
            button1 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Elephant", 11.9999981F);
            label1.Location = new Point(94, 71);
            label1.Name = "label1";
            label1.Size = new Size(108, 21);
            label1.TabIndex = 0;
            label1.Text = "Enter Email";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.Location = new Point(239, 63);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(235, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtSecurityAnswer
            // 
            txtSecurityAnswer.Anchor = AnchorStyles.None;
            txtSecurityAnswer.Location = new Point(239, 100);
            txtSecurityAnswer.Name = "txtSecurityAnswer";
            txtSecurityAnswer.Size = new Size(235, 23);
            txtSecurityAnswer.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Window;
            label2.Font = new Font("Elephant", 11.9999981F);
            label2.Location = new Point(1, 100);
            label2.Name = "label2";
            label2.Size = new Size(220, 21);
            label2.TabIndex = 2;
            label2.Text = "Enter Sequrity question #1";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Window;
            label3.Font = new Font("Elephant", 11.9999981F);
            label3.Location = new Point(40, 133);
            label3.Name = "label3";
            label3.Size = new Size(173, 21);
            label3.TabIndex = 4;
            label3.Text = "Enter new Password";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Anchor = AnchorStyles.None;
            txtNewPassword.Location = new Point(239, 137);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(235, 23);
            txtNewPassword.TabIndex = 5;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.DarkSlateGray;
            button1.FlatAppearance.BorderSize = 5;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(172, 189);
            button1.Name = "button1";
            button1.Size = new Size(177, 48);
            button1.TabIndex = 6;
            button1.Text = "Reset Password";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Window;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(3, 3);
            button3.Name = "button3";
            button3.Size = new Size(33, 34);
            button3.TabIndex = 18;
            button3.TabStop = false;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNewPassword);
            panel1.Controls.Add(txtSecurityAnswer);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(41, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(541, 240);
            panel1.TabIndex = 19;
            // 
            // ForgotPass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(763, 431);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "ForgotPass";
            Text = "Forgot Password";
            Load += ForgotPass_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private TextBox txtSecurityAnswer;
        private Label label2;
        private Label label3;
        private TextBox txtNewPassword;
        private Button button1;
        private Button button3;
        private Panel panel1;
    }
}