namespace Reg_Login
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnAddPhoneNum = new Button();
            btnTermsAndConditions = new Button();
            lblPhoneNum = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.No_Photo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(140, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(257, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(23, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(993, 415);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // btnAddPhoneNum
            // 
            btnAddPhoneNum.BackgroundImage = Properties.Resources.BG;
            btnAddPhoneNum.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddPhoneNum.Location = new Point(158, 240);
            btnAddPhoneNum.Name = "btnAddPhoneNum";
            btnAddPhoneNum.Size = new Size(222, 36);
            btnAddPhoneNum.TabIndex = 3;
            btnAddPhoneNum.Text = "Add Phone Number 📱";
            btnAddPhoneNum.UseVisualStyleBackColor = true;
            btnAddPhoneNum.Click += btnAddPhoneNum_Click_1;
            // 
            // btnTermsAndConditions
            // 
            btnTermsAndConditions.BackgroundImage = Properties.Resources.BG;
            btnTermsAndConditions.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTermsAndConditions.Location = new Point(158, 296);
            btnTermsAndConditions.Name = "btnTermsAndConditions";
            btnTermsAndConditions.Size = new Size(222, 32);
            btnTermsAndConditions.TabIndex = 4;
            btnTermsAndConditions.Text = "Terms and Conditions 📜";
            btnTermsAndConditions.UseVisualStyleBackColor = true;
            btnTermsAndConditions.Click += btnTermsAndConditions_Click_1;
            // 
            // lblPhoneNum
            // 
            lblPhoneNum.AutoSize = true;
            lblPhoneNum.BackColor = Color.Transparent;
            lblPhoneNum.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhoneNum.Location = new Point(420, 106);
            lblPhoneNum.Name = "lblPhoneNum";
            lblPhoneNum.Size = new Size(21, 20);
            lblPhoneNum.TabIndex = 6;
            lblPhoneNum.Text = "...";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.SteelBlue;
            btnBack.BackgroundImageLayout = ImageLayout.Center;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(36, 40);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(73, 63);
            btnBack.TabIndex = 7;
            btnBack.Text = "⬅";
            btnBack.TextAlign = ContentAlignment.TopCenter;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 476);
            Controls.Add(btnBack);
            Controls.Add(btnTermsAndConditions);
            Controls.Add(btnAddPhoneNum);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(lblPhoneNum);
            Name = "Profile";
            Text = "User Profile";
            Load += Profile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnAddPhoneNum;
        private Button btnTermsAndConditions;
        private Label lblPhoneNum;
        private Button btnBack;
    }
}