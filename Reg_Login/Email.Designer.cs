namespace Reg_Login
{
    partial class Email
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            from = new TextBox();
            pass = new TextBox();
            to = new TextBox();
            subj = new TextBox();
            content = new RichTextBox();
            send = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "From Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(264, 15);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 67);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 2;
            label3.Text = "To Email Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 114);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 3;
            label4.Text = "Subject";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 167);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 4;
            label5.Text = "Content";
            // 
            // from
            // 
            from.Location = new Point(37, 35);
            from.Margin = new Padding(4, 3, 4, 3);
            from.Name = "from";
            from.Size = new Size(158, 23);
            from.TabIndex = 5;
            // 
            // pass
            // 
            pass.Location = new Point(267, 33);
            pass.Margin = new Padding(4, 3, 4, 3);
            pass.Name = "pass";
            pass.Size = new Size(154, 23);
            pass.TabIndex = 6;
            // 
            // to
            // 
            to.Location = new Point(37, 87);
            to.Margin = new Padding(4, 3, 4, 3);
            to.Name = "to";
            to.Size = new Size(158, 23);
            to.TabIndex = 7;
            // 
            // subj
            // 
            subj.Location = new Point(44, 134);
            subj.Margin = new Padding(4, 3, 4, 3);
            subj.Name = "subj";
            subj.Size = new Size(224, 23);
            subj.TabIndex = 8;
            // 
            // content
            // 
            content.Location = new Point(44, 201);
            content.Margin = new Padding(4, 3, 4, 3);
            content.Name = "content";
            content.Size = new Size(415, 159);
            content.TabIndex = 9;
            content.Text = "";
            // 
            // send
            // 
            send.Location = new Point(323, 82);
            send.Margin = new Padding(4, 3, 4, 3);
            send.Name = "send";
            send.Size = new Size(99, 100);
            send.TabIndex = 10;
            send.Text = "Send";
            send.UseVisualStyleBackColor = true;
            send.Click += send_Click;
            // 
            // Email
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 374);
            Controls.Add(send);
            Controls.Add(content);
            Controls.Add(subj);
            Controls.Add(to);
            Controls.Add(pass);
            Controls.Add(from);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Email";
            Text = "Send Email";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.TextBox subj;
        private System.Windows.Forms.RichTextBox content;
        private System.Windows.Forms.Button send;
    }
}

