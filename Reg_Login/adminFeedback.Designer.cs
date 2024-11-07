namespace Reg_Login
{
    partial class adminFeedback
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
            dataGridView3 = new DataGridView();
            btnread = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightGray;
            label1.Font = new Font("Imprint MT Shadow", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-217, -151);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(438, 42);
            label1.TabIndex = 6;
            label1.Text = "Read Customer Feedback ";
            // 
            // dataGridView3
            // 
            dataGridView3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(14, 127);
            dataGridView3.Margin = new Padding(4, 3, 4, 3);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 24;
            dataGridView3.Size = new Size(937, 312);
            dataGridView3.TabIndex = 5;
            // 
            // btnread
            // 
            btnread.Anchor = AnchorStyles.Bottom;
            btnread.BackColor = SystemColors.ControlLight;
            btnread.Location = new Point(369, 468);
            btnread.Margin = new Padding(4, 3, 4, 3);
            btnread.Name = "btnread";
            btnread.Size = new Size(286, 81);
            btnread.TabIndex = 4;
            btnread.Text = "Receive Feedback";
            btnread.UseVisualStyleBackColor = false;
            btnread.Click += btnread_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.LightGray;
            label2.Font = new Font("Imprint MT Shadow", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(215, 10);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(438, 42);
            label2.TabIndex = 7;
            label2.Text = "Read Customer Feedback ";
            // 
            // adminFeedback
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 563);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView3);
            Controls.Add(btnread);
            Margin = new Padding(4, 3, 4, 3);
            Name = "adminFeedback";
            Text = "adminFeedbackview";
            Load += adminFeedbackview_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.Label label2;
    }
}