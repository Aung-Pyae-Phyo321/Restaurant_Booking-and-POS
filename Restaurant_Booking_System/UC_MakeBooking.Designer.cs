namespace Restaurant_Booking_System
{
    partial class UC_MakeBooking
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.lblBooking = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtBookNow = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dateTimeConfirm = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cboServiceTypeID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.lblServicePrice = new System.Windows.Forms.Label();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTotaluser = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTotalUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnRemove = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnBookNow = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblServiceQuantity = new System.Windows.Forms.Label();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.picBox = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBookingID
            // 
            this.lblBookingID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBookingID.ForeColor = System.Drawing.Color.Black;
            this.lblBookingID.Location = new System.Drawing.Point(209, 27);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(193, 28);
            this.lblBookingID.TabIndex = 31;
            // 
            // lblBooking
            // 
            this.lblBooking.BackColor = System.Drawing.Color.Transparent;
            this.lblBooking.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooking.ForeColor = System.Drawing.Color.Black;
            this.lblBooking.Location = new System.Drawing.Point(112, 27);
            this.lblBooking.Name = "lblBooking";
            this.lblBooking.Size = new System.Drawing.Size(91, 23);
            this.lblBooking.TabIndex = 30;
            this.lblBooking.Text = "Booking ID";
            // 
            // txtBookNow
            // 
            this.txtBookNow.BackColor = System.Drawing.Color.Transparent;
            this.txtBookNow.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookNow.ForeColor = System.Drawing.Color.Black;
            this.txtBookNow.Location = new System.Drawing.Point(578, 24);
            this.txtBookNow.Name = "txtBookNow";
            this.txtBookNow.Size = new System.Drawing.Size(112, 23);
            this.txtBookNow.TabIndex = 34;
            this.txtBookNow.Text = "Booking Here";
            // 
            // dateTimeConfirm
            // 
            this.dateTimeConfirm.AutoRoundedCorners = true;
            this.dateTimeConfirm.BorderRadius = 14;
            this.dateTimeConfirm.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.dateTimeConfirm.Checked = true;
            this.dateTimeConfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(111)))), ((int)(((byte)(5)))));
            this.dateTimeConfirm.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.dateTimeConfirm.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimeConfirm.Location = new System.Drawing.Point(707, 19);
            this.dateTimeConfirm.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimeConfirm.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimeConfirm.Name = "dateTimeConfirm";
            this.dateTimeConfirm.Size = new System.Drawing.Size(256, 31);
            this.dateTimeConfirm.TabIndex = 35;
            this.dateTimeConfirm.Value = new System.DateTime(2022, 7, 28, 20, 27, 47, 515);
            // 
            // cboServiceTypeID
            // 
            this.cboServiceTypeID.BackColor = System.Drawing.Color.Transparent;
            this.cboServiceTypeID.BorderColor = System.Drawing.Color.OrangeRed;
            this.cboServiceTypeID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboServiceTypeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServiceTypeID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboServiceTypeID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboServiceTypeID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboServiceTypeID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cboServiceTypeID.ItemHeight = 30;
            this.cboServiceTypeID.Items.AddRange(new object[] {
            "Dinner"});
            this.cboServiceTypeID.Location = new System.Drawing.Point(296, 79);
            this.cboServiceTypeID.Name = "cboServiceTypeID";
            this.cboServiceTypeID.Size = new System.Drawing.Size(246, 36);
            this.cboServiceTypeID.TabIndex = 37;
            this.cboServiceTypeID.SelectedIndexChanged += new System.EventHandler(this.cboServiceTypeID_SelectedIndexChanged);
            // 
            // lblServiceType
            // 
            this.lblServiceType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblServiceType.ForeColor = System.Drawing.Color.Black;
            this.lblServiceType.Location = new System.Drawing.Point(296, 203);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(246, 33);
            this.lblServiceType.TabIndex = 39;
            this.lblServiceType.Click += new System.EventHandler(this.lblServiceType_Click);
            // 
            // lblServicePrice
            // 
            this.lblServicePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblServicePrice.ForeColor = System.Drawing.Color.Black;
            this.lblServicePrice.Location = new System.Drawing.Point(296, 149);
            this.lblServicePrice.Name = "lblServicePrice";
            this.lblServicePrice.Size = new System.Drawing.Size(246, 31);
            this.lblServicePrice.TabIndex = 41;
            this.lblServicePrice.Click += new System.EventHandler(this.lblServicePrice_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(111, 92);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(132, 23);
            this.guna2HtmlLabel1.TabIndex = 42;
            this.guna2HtmlLabel1.Text = "Choose Service";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(112, 213);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(107, 23);
            this.guna2HtmlLabel2.TabIndex = 43;
            this.guna2HtmlLabel2.Text = "Service Type";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(112, 157);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(108, 23);
            this.guna2HtmlLabel3.TabIndex = 44;
            this.guna2HtmlLabel3.Text = "Service Price";
            // 
            // lblTotaluser
            // 
            this.lblTotaluser.BackColor = System.Drawing.Color.Transparent;
            this.lblTotaluser.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotaluser.ForeColor = System.Drawing.Color.Black;
            this.lblTotaluser.Location = new System.Drawing.Point(119, 271);
            this.lblTotaluser.Name = "lblTotaluser";
            this.lblTotaluser.Size = new System.Drawing.Size(84, 23);
            this.lblTotaluser.TabIndex = 45;
            this.lblTotaluser.Text = "Total User";
            // 
            // txtTotalUser
            // 
            this.txtTotalUser.BorderColor = System.Drawing.Color.Black;
            this.txtTotalUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalUser.DefaultText = "";
            this.txtTotalUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalUser.Location = new System.Drawing.Point(296, 266);
            this.txtTotalUser.Name = "txtTotalUser";
            this.txtTotalUser.PasswordChar = '\0';
            this.txtTotalUser.PlaceholderText = "";
            this.txtTotalUser.SelectedText = "";
            this.txtTotalUser.Size = new System.Drawing.Size(246, 28);
            this.txtTotalUser.TabIndex = 47;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoRoundedCorners = true;
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BorderRadius = 21;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(111)))), ((int)(((byte)(5)))));
            this.btnAdd.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(62)))), ((int)(((byte)(5)))));
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(110, 342);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 44);
            this.btnAdd.TabIndex = 48;
            this.btnAdd.Text = "&Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.AutoRoundedCorners = true;
            this.btnRemove.BackColor = System.Drawing.Color.White;
            this.btnRemove.BorderRadius = 21;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemove.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(111)))), ((int)(((byte)(5)))));
            this.btnRemove.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(62)))), ((int)(((byte)(5)))));
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(419, 342);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(133, 44);
            this.btnRemove.TabIndex = 49;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnBookNow
            // 
            this.btnBookNow.AutoRoundedCorners = true;
            this.btnBookNow.BackColor = System.Drawing.Color.White;
            this.btnBookNow.BorderRadius = 21;
            this.btnBookNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookNow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBookNow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBookNow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBookNow.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBookNow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBookNow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(111)))), ((int)(((byte)(5)))));
            this.btnBookNow.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(62)))), ((int)(((byte)(5)))));
            this.btnBookNow.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookNow.ForeColor = System.Drawing.Color.White;
            this.btnBookNow.Location = new System.Drawing.Point(941, 452);
            this.btnBookNow.Name = "btnBookNow";
            this.btnBookNow.Size = new System.Drawing.Size(133, 44);
            this.btnBookNow.TabIndex = 50;
            this.btnBookNow.Text = "&Book Now";
            this.btnBookNow.Click += new System.EventHandler(this.btnBookNow_Click);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalAmount.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Black;
            this.lblTotalAmount.Location = new System.Drawing.Point(296, 411);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(246, 28);
            this.lblTotalAmount.TabIndex = 51;
            // 
            // lblServiceQuantity
            // 
            this.lblServiceQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblServiceQuantity.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceQuantity.ForeColor = System.Drawing.Color.Black;
            this.lblServiceQuantity.Location = new System.Drawing.Point(306, 468);
            this.lblServiceQuantity.Name = "lblServiceQuantity";
            this.lblServiceQuantity.Size = new System.Drawing.Size(246, 28);
            this.lblServiceQuantity.TabIndex = 52;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(128, 416);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(115, 23);
            this.guna2HtmlLabel4.TabIndex = 53;
            this.guna2HtmlLabel4.Text = "Total Amount";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(104, 473);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(186, 23);
            this.guna2HtmlLabel5.TabIndex = 54;
            this.guna2HtmlLabel5.Text = "Total Service Quantity";
            // 
            // dataGridView
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridView.Location = new System.Drawing.Point(24, 535);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1168, 184);
            this.dataGridView.TabIndex = 56;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.dataGridView.ThemeStyle.ReadOnly = false;
            this.dataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // picBox
            // 
            this.picBox.ImageRotate = 0F;
            this.picBox.Location = new System.Drawing.Point(614, 79);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(448, 360);
            this.picBox.TabIndex = 57;
            this.picBox.TabStop = false;
            // 
            // UC_MakeBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.lblServiceQuantity);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.btnBookNow);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTotalUser);
            this.Controls.Add(this.lblTotaluser);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.lblServicePrice);
            this.Controls.Add(this.lblServiceType);
            this.Controls.Add(this.cboServiceTypeID);
            this.Controls.Add(this.dateTimeConfirm);
            this.Controls.Add(this.txtBookNow);
            this.Controls.Add(this.lblBookingID);
            this.Controls.Add(this.lblBooking);
            this.Name = "UC_MakeBooking";
            this.Size = new System.Drawing.Size(1212, 801);
            this.Load += new System.EventHandler(this.UC_MakeBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBookingID;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBooking;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtBookNow;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimeConfirm;
        private Guna.UI2.WinForms.Guna2ComboBox cboServiceTypeID;
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.Label lblServicePrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotaluser;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalUser;
        private Guna.UI2.WinForms.Guna2GradientButton btnAdd;
        private Guna.UI2.WinForms.Guna2GradientButton btnRemove;
        private Guna.UI2.WinForms.Guna2GradientButton btnBookNow;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblServiceQuantity;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView;
        private Guna.UI2.WinForms.Guna2PictureBox picBox;
    }
}
