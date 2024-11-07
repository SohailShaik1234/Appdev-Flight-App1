namespace Reg_Login
{
    partial class Book_Flights
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book_Flights));
            btnBack = new Button();
            panel1 = new Panel();
            lblTotalPrice = new Label();
            button2 = new Button();
            label11 = new Label();
            linkLabel1 = new LinkLabel();
            label14 = new Label();
            lblFlightPrice = new Label();
            lblCurrentUsername = new Label();
            label2 = new Label();
            cmbFrom = new ComboBox();
            panel2 = new Panel();
            label9 = new Label();
            cmbClass = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            NUDInfants = new NumericUpDown();
            NUDChildren = new NumericUpDown();
            NUDAdults = new NumericUpDown();
            label4 = new Label();
            DTDepart = new DateTimePicker();
            cmbTo = new ComboBox();
            label3 = new Label();
            label6 = new Label();
            lblFrom = new Label();
            lblTo = new Label();
            lblTotalTime = new Label();
            lblFlightID = new Label();
            label100 = new Label();
            lblFromTime = new Label();
            lblToTime = new Label();
            label16 = new Label();
            lblDepartureDate = new Label();
            lblFlightClass = new Label();
            label21 = new Label();
            dgFlight = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUDInfants).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDChildren).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDAdults).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgFlight).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DarkSlateGray;
            btnBack.BackgroundImageLayout = ImageLayout.Zoom;
            btnBack.FlatAppearance.BorderSize = 5;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(10, 61);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(183, 84);
            btnBack.TabIndex = 1;
            btnBack.Text = "⬅";
            btnBack.TextAlign = ContentAlignment.TopCenter;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lblTotalPrice);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(lblFlightPrice);
            panel1.Controls.Add(lblCurrentUsername);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 778);
            panel1.TabIndex = 5;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Century Gothic", 14F, FontStyle.Bold | FontStyle.Italic);
            lblTotalPrice.ForeColor = Color.White;
            lblTotalPrice.Location = new Point(43, 579);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(21, 23);
            lblTotalPrice.TabIndex = 25;
            lblTotalPrice.Text = "0";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(52, 45);
            button2.TabIndex = 34;
            button2.Text = "👤";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic);
            label11.ForeColor = Color.White;
            label11.Location = new Point(3, 558);
            label11.Name = "label11";
            label11.Size = new Size(139, 21);
            label11.TabIndex = 24;
            label11.Text = "Total Flight Price:";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(0, 0, 192);
            linkLabel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(3, 647);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(41, 16);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Help?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic);
            label14.ForeColor = Color.White;
            label14.Location = new Point(3, 480);
            label14.Name = "label14";
            label14.Size = new Size(197, 21);
            label14.TabIndex = 23;
            label14.Text = "Flight Price (per person):";
            // 
            // lblFlightPrice
            // 
            lblFlightPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblFlightPrice.AutoSize = true;
            lblFlightPrice.Font = new Font("Century Gothic", 14F, FontStyle.Bold | FontStyle.Italic);
            lblFlightPrice.ForeColor = Color.White;
            lblFlightPrice.Location = new Point(43, 501);
            lblFlightPrice.Name = "lblFlightPrice";
            lblFlightPrice.Size = new Size(21, 23);
            lblFlightPrice.TabIndex = 18;
            lblFlightPrice.Text = "0";
            // 
            // lblCurrentUsername
            // 
            lblCurrentUsername.AutoSize = true;
            lblCurrentUsername.ForeColor = Color.White;
            lblCurrentUsername.Location = new Point(61, 0);
            lblCurrentUsername.Name = "lblCurrentUsername";
            lblCurrentUsername.Size = new Size(104, 16);
            lblCurrentUsername.TabIndex = 26;
            lblCurrentUsername.Text = "john@gmail.com";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(42, 17);
            label2.Name = "label2";
            label2.Size = new Size(52, 19);
            label2.TabIndex = 13;
            label2.Text = "From:";
            // 
            // cmbFrom
            // 
            cmbFrom.Anchor = AnchorStyles.Top;
            cmbFrom.BackColor = Color.White;
            cmbFrom.FlatStyle = FlatStyle.Flat;
            cmbFrom.ForeColor = Color.Black;
            cmbFrom.FormattingEnabled = true;
            cmbFrom.Items.AddRange(new object[] { "Durban King Shaka International Airport", "Cape Town International Airport", "Johannesburg O.R. Tambo International Airport", "Port Elizabeth Chief Dawid Stuurman International Airport" });
            cmbFrom.Location = new Point(42, 36);
            cmbFrom.Name = "cmbFrom";
            cmbFrom.Size = new Size(268, 24);
            cmbFrom.TabIndex = 12;
            cmbFrom.SelectedIndexChanged += cmbFrom_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(cmbClass);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(NUDInfants);
            panel2.Controls.Add(NUDChildren);
            panel2.Controls.Add(NUDAdults);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(DTDepart);
            panel2.Controls.Add(cmbTo);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(cmbFrom);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(219, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(981, 140);
            panel2.TabIndex = 14;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(774, 17);
            label9.Name = "label9";
            label9.Size = new Size(48, 19);
            label9.TabIndex = 27;
            label9.Text = "Class";
            // 
            // cmbClass
            // 
            cmbClass.Anchor = AnchorStyles.Top;
            cmbClass.BackColor = Color.White;
            cmbClass.FlatStyle = FlatStyle.Flat;
            cmbClass.ForeColor = Color.Black;
            cmbClass.FormattingEnabled = true;
            cmbClass.Items.AddRange(new object[] { "Economy", "Business", "First Class" });
            cmbClass.Location = new Point(774, 36);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new Size(144, 24);
            cmbClass.TabIndex = 26;
            cmbClass.SelectedIndexChanged += cmbClass_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(645, 83);
            label8.Name = "label8";
            label8.Size = new Size(58, 19);
            label8.TabIndex = 25;
            label8.Text = "Infants";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(424, 83);
            label7.Name = "label7";
            label7.Size = new Size(75, 19);
            label7.TabIndex = 24;
            label7.Text = "Children";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(204, 83);
            label5.Name = "label5";
            label5.Size = new Size(56, 19);
            label5.TabIndex = 23;
            label5.Text = "Adults";
            // 
            // NUDInfants
            // 
            NUDInfants.Anchor = AnchorStyles.None;
            NUDInfants.Location = new Point(645, 103);
            NUDInfants.Name = "NUDInfants";
            NUDInfants.Size = new Size(120, 22);
            NUDInfants.TabIndex = 22;
            // 
            // NUDChildren
            // 
            NUDChildren.Anchor = AnchorStyles.None;
            NUDChildren.Location = new Point(424, 103);
            NUDChildren.Name = "NUDChildren";
            NUDChildren.Size = new Size(120, 22);
            NUDChildren.TabIndex = 21;
            // 
            // NUDAdults
            // 
            NUDAdults.Anchor = AnchorStyles.None;
            NUDAdults.Location = new Point(204, 103);
            NUDAdults.Name = "NUDAdults";
            NUDAdults.Size = new Size(120, 22);
            NUDAdults.TabIndex = 20;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(608, 17);
            label4.Name = "label4";
            label4.Size = new Size(65, 19);
            label4.TabIndex = 16;
            label4.Text = "Depart:";
            // 
            // DTDepart
            // 
            DTDepart.Anchor = AnchorStyles.Top;
            DTDepart.CustomFormat = "dd/MM/yyyy";
            DTDepart.Format = DateTimePickerFormat.Custom;
            DTDepart.Location = new Point(608, 36);
            DTDepart.Name = "DTDepart";
            DTDepart.Size = new Size(144, 22);
            DTDepart.TabIndex = 15;
            DTDepart.ValueChanged += DTDepart_ValueChanged;
            // 
            // cmbTo
            // 
            cmbTo.Anchor = AnchorStyles.Top;
            cmbTo.BackColor = Color.White;
            cmbTo.FlatStyle = FlatStyle.Flat;
            cmbTo.ForeColor = Color.Black;
            cmbTo.FormattingEnabled = true;
            cmbTo.Items.AddRange(new object[] { "Durban King Shaka International Airport", "Cape Town International Airport", "Johannesburg O.R. Tambo International Airport", "Port Elizabeth Chief Dawid Stuurman International Airport" });
            cmbTo.Location = new Point(325, 36);
            cmbTo.Name = "cmbTo";
            cmbTo.Size = new Size(268, 24);
            cmbTo.TabIndex = 14;
            cmbTo.SelectedIndexChanged += cmbTo_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(325, 17);
            label3.Name = "label3";
            label3.Size = new Size(30, 19);
            label3.TabIndex = 15;
            label3.Text = "To:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Century Gothic", 18F, FontStyle.Bold | FontStyle.Underline);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(221, 257);
            label6.Name = "label6";
            label6.Size = new Size(294, 28);
            label6.TabIndex = 15;
            label6.Text = "Current Flight Selected : ";
            // 
            // lblFrom
            // 
            lblFrom.Anchor = AnchorStyles.Left;
            lblFrom.AutoSize = true;
            lblFrom.BackColor = Color.White;
            lblFrom.Font = new Font("Century Gothic", 16F, FontStyle.Bold | FontStyle.Italic);
            lblFrom.ForeColor = Color.Black;
            lblFrom.Location = new Point(325, 333);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(21, 27);
            lblFrom.TabIndex = 16;
            lblFrom.Text = "-";
            // 
            // lblTo
            // 
            lblTo.Anchor = AnchorStyles.Left;
            lblTo.AutoSize = true;
            lblTo.BackColor = Color.White;
            lblTo.Font = new Font("Century Gothic", 16F, FontStyle.Bold | FontStyle.Italic);
            lblTo.ForeColor = Color.Black;
            lblTo.Location = new Point(325, 372);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(21, 27);
            lblTo.TabIndex = 17;
            lblTo.Text = "-";
            // 
            // lblTotalTime
            // 
            lblTotalTime.Anchor = AnchorStyles.Left;
            lblTotalTime.AutoSize = true;
            lblTotalTime.BackColor = Color.White;
            lblTotalTime.Font = new Font("Century Gothic", 16F, FontStyle.Bold | FontStyle.Italic);
            lblTotalTime.ForeColor = Color.Black;
            lblTotalTime.Location = new Point(325, 516);
            lblTotalTime.Name = "lblTotalTime";
            lblTotalTime.Size = new Size(96, 27);
            lblTotalTime.TabIndex = 19;
            lblTotalTime.Text = "00:00:00";
            // 
            // lblFlightID
            // 
            lblFlightID.Anchor = AnchorStyles.Left;
            lblFlightID.AutoSize = true;
            lblFlightID.BackColor = Color.White;
            lblFlightID.Font = new Font("Century Gothic", 16F, FontStyle.Bold | FontStyle.Italic);
            lblFlightID.ForeColor = Color.Black;
            lblFlightID.Location = new Point(325, 295);
            lblFlightID.Name = "lblFlightID";
            lblFlightID.Size = new Size(48, 27);
            lblFlightID.TabIndex = 20;
            lblFlightID.Text = "000";
            // 
            // label100
            // 
            label100.Anchor = AnchorStyles.Left;
            label100.AutoSize = true;
            label100.BackColor = Color.White;
            label100.Font = new Font("Century Gothic", 16F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            label100.ForeColor = Color.Black;
            label100.Location = new Point(224, 295);
            label100.Name = "label100";
            label100.Size = new Size(95, 27);
            label100.TabIndex = 25;
            label100.Text = "FlightID:";
            // 
            // lblFromTime
            // 
            lblFromTime.Anchor = AnchorStyles.Left;
            lblFromTime.AutoSize = true;
            lblFromTime.BackColor = Color.White;
            lblFromTime.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            lblFromTime.ForeColor = Color.Black;
            lblFromTime.Location = new Point(325, 449);
            lblFromTime.Name = "lblFromTime";
            lblFromTime.Size = new Size(64, 18);
            lblFromTime.TabIndex = 28;
            lblFromTime.Text = "00:00:00";
            // 
            // lblToTime
            // 
            lblToTime.Anchor = AnchorStyles.Left;
            lblToTime.AutoSize = true;
            lblToTime.BackColor = Color.White;
            lblToTime.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            lblToTime.ForeColor = Color.Black;
            lblToTime.Location = new Point(325, 482);
            lblToTime.Name = "lblToTime";
            lblToTime.Size = new Size(64, 18);
            lblToTime.TabIndex = 29;
            lblToTime.Text = "00:00:00";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Left;
            label16.AutoSize = true;
            label16.BackColor = Color.White;
            label16.Font = new Font("Century Gothic", 16F, FontStyle.Bold);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(224, 333);
            label16.Name = "label16";
            label16.Size = new Size(71, 26);
            label16.TabIndex = 30;
            label16.Text = "From:";
            // 
            // lblDepartureDate
            // 
            lblDepartureDate.Anchor = AnchorStyles.Left;
            lblDepartureDate.AutoSize = true;
            lblDepartureDate.BackColor = Color.White;
            lblDepartureDate.Font = new Font("Century Gothic", 16F, FontStyle.Bold | FontStyle.Italic);
            lblDepartureDate.ForeColor = Color.Black;
            lblDepartureDate.Location = new Point(325, 557);
            lblDepartureDate.Name = "lblDepartureDate";
            lblDepartureDate.Size = new Size(128, 27);
            lblDepartureDate.TabIndex = 31;
            lblDepartureDate.Text = "00/00/0000";
            // 
            // lblFlightClass
            // 
            lblFlightClass.Anchor = AnchorStyles.Left;
            lblFlightClass.AutoSize = true;
            lblFlightClass.BackColor = Color.White;
            lblFlightClass.Font = new Font("Century Gothic", 16F, FontStyle.Bold | FontStyle.Italic);
            lblFlightClass.ForeColor = Color.Black;
            lblFlightClass.Location = new Point(325, 409);
            lblFlightClass.Name = "lblFlightClass";
            lblFlightClass.Size = new Size(21, 27);
            lblFlightClass.TabIndex = 32;
            lblFlightClass.Text = "-";
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Left;
            label21.AutoSize = true;
            label21.BackColor = Color.White;
            label21.Font = new Font("Century Gothic", 16F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            label21.ForeColor = Color.Black;
            label21.Location = new Point(224, 409);
            label21.Name = "label21";
            label21.Size = new Size(75, 27);
            label21.TabIndex = 33;
            label21.Text = "Class:";
            // 
            // dgFlight
            // 
            dgFlight.AllowUserToAddRows = false;
            dgFlight.AllowUserToDeleteRows = false;
            dgFlight.AllowUserToResizeColumns = false;
            dgFlight.AllowUserToResizeRows = false;
            dgFlight.BackgroundColor = Color.LightCyan;
            dgFlight.BorderStyle = BorderStyle.None;
            dgFlight.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Gray;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgFlight.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgFlight.ColumnHeadersHeight = 30;
            dgFlight.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgFlight.DefaultCellStyle = dataGridViewCellStyle2;
            dgFlight.Dock = DockStyle.Top;
            dgFlight.GridColor = Color.FromArgb(224, 224, 224);
            dgFlight.Location = new Point(219, 140);
            dgFlight.Name = "dgFlight";
            dgFlight.ReadOnly = true;
            dgFlight.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgFlight.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgFlight.RowHeadersVisible = false;
            dgFlight.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgFlight.Size = new Size(981, 114);
            dgFlight.TabIndex = 35;
            dgFlight.CellClick += dgFlight_CellClick;
            dgFlight.CellDoubleClick += dgFlight_CellDoubleClick_1;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "From Location";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "To Location";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "Flight Class";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 95;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Departure Date";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 120;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Century Gothic", 16F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(224, 372);
            label1.Name = "label1";
            label1.Size = new Size(41, 26);
            label1.TabIndex = 36;
            label1.Text = "To:";
            // 
            // Book_Flights
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1200, 778);
            Controls.Add(label1);
            Controls.Add(dgFlight);
            Controls.Add(label21);
            Controls.Add(lblFlightClass);
            Controls.Add(lblDepartureDate);
            Controls.Add(label16);
            Controls.Add(lblToTime);
            Controls.Add(lblFromTime);
            Controls.Add(label100);
            Controls.Add(lblFlightID);
            Controls.Add(lblTotalTime);
            Controls.Add(lblTo);
            Controls.Add(lblFrom);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            Name = "Book_Flights";
            Text = "Book Flights";
            Load += Book_Flights_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUDInfants).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDChildren).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDAdults).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgFlight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBack;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Label label4;
        public ComboBox cmbFrom;
        public ComboBox cmbTo;
        private LinkLabel linkLabel1;
        private Label label6;
        private Label lblFrom;
        private Label lblTo;
        private Label lblFlightPrice;
        private Label lblTotalTime;
        private Label label100;
        private Label label14;
        private Label lblCurrentUsername;
        private Label lblFromTime;
        private Label lblToTime;
        private Label label16;
        private Label lblDepartureDate;
        private Label lblFlightClass;
        public DateTimePicker DTDepart;
        private Label label21;
        public Label lblFlightID;
        private Button button2;
        private Label label8;
        private Label label7;
        private Label label5;
        private NumericUpDown NUDInfants;
        private NumericUpDown NUDChildren;
        private NumericUpDown NUDAdults;
        private Label label9;
        public ComboBox cmbClass;
        private Label lblTotalPrice;
        private Label label11;
        private DataGridView dgFlight;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label1;
    }
}