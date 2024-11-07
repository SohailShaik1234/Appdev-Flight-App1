namespace Reg_Login
{
    partial class Staff_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff_Password));
            txtStaffPassword = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // txtStaffPassword
            // 
            txtStaffPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStaffPassword.Location = new Point(178, 190);
            txtStaffPassword.Name = "txtStaffPassword";
            txtStaffPassword.Size = new Size(454, 33);
            txtStaffPassword.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(178, 157);
            label1.Name = "label1";
            label1.Size = new Size(196, 30);
            label1.TabIndex = 1;
            label1.Text = "STAFF PASSWORD";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(328, 229);
            button1.Name = "button1";
            button1.Size = new Size(132, 56);
            button1.TabIndex = 2;
            button1.Text = "NEXT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(12, 12);
            button3.Name = "button3";
            button3.Size = new Size(52, 51);
            button3.TabIndex = 3;
            button3.TabStop = false;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Staff_Password
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 448);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtStaffPassword);
            Name = "Staff_Password";
            Text = "Staff Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStaffPassword;
        private Label label1;
        private Button button1;
        private Button button3;
    }
}