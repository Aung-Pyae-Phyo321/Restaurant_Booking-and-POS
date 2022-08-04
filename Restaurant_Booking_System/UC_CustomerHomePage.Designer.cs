namespace Restaurant_Booking_System
{
    partial class UC_CustomerHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CustomerHomePage));
            this.btnReview = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ReviewDtGrid = new System.Windows.Forms.DataGridView();
            this.txtReview = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblWelcome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ReviewDtGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReview
            // 
            this.btnReview.AutoRoundedCorners = true;
            this.btnReview.BorderRadius = 25;
            this.btnReview.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReview.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReview.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReview.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReview.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReview.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(111)))), ((int)(((byte)(5)))));
            this.btnReview.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(62)))), ((int)(((byte)(5)))));
            this.btnReview.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReview.ForeColor = System.Drawing.Color.White;
            this.btnReview.Image = ((System.Drawing.Image)(resources.GetObject("btnReview.Image")));
            this.btnReview.Location = new System.Drawing.Point(748, 432);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(153, 53);
            this.btnReview.TabIndex = 0;
            this.btnReview.Text = "&Review";
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // ReviewDtGrid
            // 
            this.ReviewDtGrid.AllowUserToAddRows = false;
            this.ReviewDtGrid.AllowUserToDeleteRows = false;
            this.ReviewDtGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReviewDtGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ReviewDtGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ReviewDtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReviewDtGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ReviewDtGrid.Location = new System.Drawing.Point(51, 117);
            this.ReviewDtGrid.Name = "ReviewDtGrid";
            this.ReviewDtGrid.ReadOnly = true;
            this.ReviewDtGrid.RowHeadersWidth = 51;
            this.ReviewDtGrid.RowTemplate.Height = 24;
            this.ReviewDtGrid.Size = new System.Drawing.Size(859, 274);
            this.ReviewDtGrid.TabIndex = 1;
            // 
            // txtReview
            // 
            this.txtReview.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtReview.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReview.DefaultText = "";
            this.txtReview.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtReview.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtReview.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReview.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReview.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReview.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReview.ForeColor = System.Drawing.Color.Gray;
            this.txtReview.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReview.Location = new System.Drawing.Point(51, 418);
            this.txtReview.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtReview.Name = "txtReview";
            this.txtReview.PasswordChar = '\0';
            this.txtReview.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtReview.PlaceholderText = "Enter Your Review";
            this.txtReview.SelectedText = "";
            this.txtReview.Size = new System.Drawing.Size(668, 67);
            this.txtReview.TabIndex = 2;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = false;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(51, 58);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(235, 38);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Welcome ";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackgroundImage = global::Restaurant_Booking_System.Properties.Resources.pngwing_com;
            this.guna2Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 585);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(969, 100);
            this.guna2Panel2.TabIndex = 10;
            // 
            // UC_CustomerHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.txtReview);
            this.Controls.Add(this.ReviewDtGrid);
            this.Controls.Add(this.btnReview);
            this.Name = "UC_CustomerHomePage";
            this.Size = new System.Drawing.Size(969, 685);
            this.Load += new System.EventHandler(this.UC_CustomerHomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReviewDtGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnReview;
        private System.Windows.Forms.DataGridView ReviewDtGrid;
        private Guna.UI2.WinForms.Guna2TextBox txtReview;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWelcome;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}
