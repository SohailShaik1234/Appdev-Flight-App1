namespace Reg_Login
{
    partial class User_Select
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Select));
            panel1 = new Panel();
            panel2 = new Panel();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(117, 150);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(303, 291);
            panel1.TabIndex = 9;
            panel1.Click += panel1_Click;
            panel1.Paint += panel1_Paint;
            panel1.MouseEnter += panel1_MouseEnter;
            panel1.MouseLeave += panel1_MouseLeave;
            panel1.MouseHover += panel1_MouseHover;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(519, 150);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(303, 291);
            panel2.TabIndex = 5;
            panel2.Click += panel2_Click;
            panel2.MouseEnter += panel2_MouseEnter;
            panel2.MouseLeave += panel2_MouseLeave;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(12, 14);
            button3.Name = "button3";
            button3.Size = new Size(52, 51);
            button3.TabIndex = 17;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bodoni MT Poster Compressed", 48F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.CadetBlue;
            label1.Location = new Point(330, 14);
            label1.Name = "label1";
            label1.Size = new Size(277, 74);
            label1.TabIndex = 18;
            label1.Text = "PLEASE CHOOSE";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bodoni MT Poster Compressed", 48F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.CadetBlue;
            label2.Location = new Point(198, 443);
            label2.Name = "label2";
            label2.Size = new Size(129, 74);
            label2.TabIndex = 19;
            label2.Text = "ADMIN";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Bodoni MT Poster Compressed", 48F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.CadetBlue;
            label3.Location = new Point(617, 443);
            label3.Name = "label3";
            label3.Size = new Size(118, 74);
            label3.TabIndex = 20;
            label3.Text = "USER";
            // 
            // User_Select
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(933, 519);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            DoubleBuffered = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "User_Select";
            Text = "Select User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}

