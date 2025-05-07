namespace Airline
{
    partial class BookingSummary
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
            this.btnProceed = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Where = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFlightClass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtNumInfants = new System.Windows.Forms.TextBox();
            this.txtNumChildren = new System.Windows.Forms.TextBox();
            this.txtNumAdults = new System.Windows.Forms.TextBox();
            this.txtTripType = new System.Windows.Forms.TextBox();
            this.txtReturnDateAndTime = new System.Windows.Forms.TextBox();
            this.txtDepartDateAndTime = new System.Windows.Forms.TextBox();
            this.txtFlightNum = new System.Windows.Forms.TextBox();
            this.txtFlightLoc = new System.Windows.Forms.TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDepart = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPickedSeats = new System.Windows.Forms.TextBox();
            this.txtReturnFlightNum = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProceed
            // 
            this.btnProceed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProceed.BackgroundImage = global::Airline.Properties.Resources.ButtoncolorBig1;
            this.btnProceed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProceed.ForeColor = System.Drawing.Color.White;
            this.btnProceed.Location = new System.Drawing.Point(789, 868);
            this.btnProceed.Margin = new System.Windows.Forms.Padding(2);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(134, 45);
            this.btnProceed.TabIndex = 50;
            this.btnProceed.Text = "PROCEED";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Airline.Properties.Resources.AirplaneBG;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.Where);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1433, 220);
            this.panel2.TabIndex = 55;
            // 
            // Where
            // 
            this.Where.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Where.AutoSize = true;
            this.Where.BackColor = System.Drawing.Color.Transparent;
            this.Where.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Where.ForeColor = System.Drawing.Color.Black;
            this.Where.Location = new System.Drawing.Point(67, 70);
            this.Where.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Where.Name = "Where";
            this.Where.Size = new System.Drawing.Size(504, 37);
            this.Where.TabIndex = 23;
            this.Where.Text = "Here is your booking summary.";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.SaddleBrown;
            this.pnlHeader.BackgroundImage = global::Airline.Properties.Resources.PanelHeaderBg;
            this.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHeader.Controls.Add(this.btnExit);
            this.pnlHeader.Controls.Add(this.Search);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1433, 70);
            this.pnlHeader.TabIndex = 54;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnExit.BackgroundImage = global::Airline.Properties.Resources.ButtonSmall;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Gold;
            this.btnExit.Location = new System.Drawing.Point(1381, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "x";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.AutoSize = true;
            this.Search.BackColor = System.Drawing.Color.Transparent;
            this.Search.Font = new System.Drawing.Font("Britannic Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.Gold;
            this.Search.Location = new System.Drawing.Point(42, 9);
            this.Search.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(332, 44);
            this.Search.TabIndex = 22;
            this.Search.Text = "BookingSummary";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Britannic Bold", 16F);
            this.label8.Location = new System.Drawing.Point(309, 433);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(130, 25);
            this.label8.TabIndex = 75;
            this.label8.Text = "Flight Class:";
            // 
            // txtFlightClass
            // 
            this.txtFlightClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFlightClass.BackColor = System.Drawing.Color.White;
            this.txtFlightClass.Enabled = false;
            this.txtFlightClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlightClass.Location = new System.Drawing.Point(584, 423);
            this.txtFlightClass.Name = "txtFlightClass";
            this.txtFlightClass.ReadOnly = true;
            this.txtFlightClass.Size = new System.Drawing.Size(550, 38);
            this.txtFlightClass.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Britannic Bold", 16F);
            this.label7.Location = new System.Drawing.Point(309, 389);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(154, 25);
            this.label7.TabIndex = 73;
            this.label7.Text = "Flight Number:";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotalPrice.BackColor = System.Drawing.Color.White;
            this.txtTotalPrice.Enabled = false;
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(584, 775);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(550, 38);
            this.txtTotalPrice.TabIndex = 72;
            // 
            // txtNumInfants
            // 
            this.txtNumInfants.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumInfants.BackColor = System.Drawing.Color.White;
            this.txtNumInfants.Enabled = false;
            this.txtNumInfants.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumInfants.Location = new System.Drawing.Point(584, 687);
            this.txtNumInfants.Name = "txtNumInfants";
            this.txtNumInfants.ReadOnly = true;
            this.txtNumInfants.Size = new System.Drawing.Size(550, 38);
            this.txtNumInfants.TabIndex = 71;
            // 
            // txtNumChildren
            // 
            this.txtNumChildren.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumChildren.BackColor = System.Drawing.Color.White;
            this.txtNumChildren.Enabled = false;
            this.txtNumChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumChildren.Location = new System.Drawing.Point(584, 643);
            this.txtNumChildren.Name = "txtNumChildren";
            this.txtNumChildren.ReadOnly = true;
            this.txtNumChildren.Size = new System.Drawing.Size(550, 38);
            this.txtNumChildren.TabIndex = 70;
            // 
            // txtNumAdults
            // 
            this.txtNumAdults.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumAdults.BackColor = System.Drawing.Color.White;
            this.txtNumAdults.Enabled = false;
            this.txtNumAdults.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumAdults.Location = new System.Drawing.Point(584, 599);
            this.txtNumAdults.Name = "txtNumAdults";
            this.txtNumAdults.ReadOnly = true;
            this.txtNumAdults.Size = new System.Drawing.Size(550, 38);
            this.txtNumAdults.TabIndex = 69;
            // 
            // txtTripType
            // 
            this.txtTripType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTripType.BackColor = System.Drawing.Color.White;
            this.txtTripType.Enabled = false;
            this.txtTripType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTripType.Location = new System.Drawing.Point(584, 555);
            this.txtTripType.Name = "txtTripType";
            this.txtTripType.ReadOnly = true;
            this.txtTripType.Size = new System.Drawing.Size(550, 38);
            this.txtTripType.TabIndex = 68;
            // 
            // txtReturnDateAndTime
            // 
            this.txtReturnDateAndTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtReturnDateAndTime.BackColor = System.Drawing.Color.White;
            this.txtReturnDateAndTime.Enabled = false;
            this.txtReturnDateAndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnDateAndTime.Location = new System.Drawing.Point(584, 511);
            this.txtReturnDateAndTime.Name = "txtReturnDateAndTime";
            this.txtReturnDateAndTime.ReadOnly = true;
            this.txtReturnDateAndTime.Size = new System.Drawing.Size(550, 38);
            this.txtReturnDateAndTime.TabIndex = 67;
            // 
            // txtDepartDateAndTime
            // 
            this.txtDepartDateAndTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDepartDateAndTime.BackColor = System.Drawing.Color.White;
            this.txtDepartDateAndTime.Enabled = false;
            this.txtDepartDateAndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartDateAndTime.Location = new System.Drawing.Point(584, 467);
            this.txtDepartDateAndTime.Name = "txtDepartDateAndTime";
            this.txtDepartDateAndTime.ReadOnly = true;
            this.txtDepartDateAndTime.Size = new System.Drawing.Size(550, 38);
            this.txtDepartDateAndTime.TabIndex = 66;
            // 
            // txtFlightNum
            // 
            this.txtFlightNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFlightNum.BackColor = System.Drawing.Color.White;
            this.txtFlightNum.Enabled = false;
            this.txtFlightNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlightNum.Location = new System.Drawing.Point(584, 379);
            this.txtFlightNum.Name = "txtFlightNum";
            this.txtFlightNum.ReadOnly = true;
            this.txtFlightNum.Size = new System.Drawing.Size(550, 38);
            this.txtFlightNum.TabIndex = 65;
            // 
            // txtFlightLoc
            // 
            this.txtFlightLoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFlightLoc.BackColor = System.Drawing.Color.White;
            this.txtFlightLoc.Enabled = false;
            this.txtFlightLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlightLoc.Location = new System.Drawing.Point(584, 335);
            this.txtFlightLoc.Name = "txtFlightLoc";
            this.txtFlightLoc.ReadOnly = true;
            this.txtFlightLoc.Size = new System.Drawing.Size(550, 38);
            this.txtFlightLoc.TabIndex = 64;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Britannic Bold", 16F);
            this.lblTotalPrice.Location = new System.Drawing.Point(309, 785);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(3);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalPrice.Size = new System.Drawing.Size(123, 25);
            this.lblTotalPrice.TabIndex = 63;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 16F);
            this.label5.Location = new System.Drawing.Point(309, 697);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 62;
            this.label5.Text = "Infant/s:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 16F);
            this.label4.Location = new System.Drawing.Point(309, 653);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(157, 25);
            this.label4.TabIndex = 61;
            this.label4.Text = "Child/Children:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 16F);
            this.label3.Location = new System.Drawing.Point(309, 609);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 60;
            this.label3.Text = "Adult/s:";
            // 
            // lblDepart
            // 
            this.lblDepart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDepart.AutoSize = true;
            this.lblDepart.Font = new System.Drawing.Font("Britannic Bold", 16F);
            this.lblDepart.Location = new System.Drawing.Point(309, 477);
            this.lblDepart.Margin = new System.Windows.Forms.Padding(3);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDepart.Size = new System.Drawing.Size(230, 25);
            this.lblDepart.TabIndex = 59;
            this.lblDepart.Text = "Depart Date and Time:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 16F);
            this.label2.Location = new System.Drawing.Point(309, 521);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(230, 25);
            this.label2.TabIndex = 58;
            this.label2.Text = "Return Date and Time:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 16F);
            this.label1.Location = new System.Drawing.Point(309, 345);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 57;
            this.label1.Text = "Flight Location:";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Britannic Bold", 16F);
            this.lblName.Location = new System.Drawing.Point(309, 565);
            this.lblName.Margin = new System.Windows.Forms.Padding(3);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblName.Size = new System.Drawing.Size(107, 25);
            this.lblName.TabIndex = 56;
            this.lblName.Text = "Trip Type:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Britannic Bold", 16F);
            this.label9.Location = new System.Drawing.Point(309, 741);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(151, 25);
            this.label9.TabIndex = 76;
            this.label9.Text = "Picked Seat/s:";
            // 
            // txtPickedSeats
            // 
            this.txtPickedSeats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPickedSeats.BackColor = System.Drawing.Color.White;
            this.txtPickedSeats.Enabled = false;
            this.txtPickedSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPickedSeats.Location = new System.Drawing.Point(584, 731);
            this.txtPickedSeats.Name = "txtPickedSeats";
            this.txtPickedSeats.ReadOnly = true;
            this.txtPickedSeats.Size = new System.Drawing.Size(550, 38);
            this.txtPickedSeats.TabIndex = 77;
            // 
            // txtReturnFlightNum
            // 
            this.txtReturnFlightNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtReturnFlightNum.BackColor = System.Drawing.Color.White;
            this.txtReturnFlightNum.Enabled = false;
            this.txtReturnFlightNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnFlightNum.Location = new System.Drawing.Point(859, 379);
            this.txtReturnFlightNum.Name = "txtReturnFlightNum";
            this.txtReturnFlightNum.ReadOnly = true;
            this.txtReturnFlightNum.Size = new System.Drawing.Size(275, 38);
            this.txtReturnFlightNum.TabIndex = 78;
            // 
            // BookingSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 966);
            this.Controls.Add(this.txtReturnFlightNum);
            this.Controls.Add(this.txtPickedSeats);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFlightClass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.txtNumInfants);
            this.Controls.Add(this.txtNumChildren);
            this.Controls.Add(this.txtNumAdults);
            this.Controls.Add(this.txtTripType);
            this.Controls.Add(this.txtReturnDateAndTime);
            this.Controls.Add(this.txtDepartDateAndTime);
            this.Controls.Add(this.txtFlightNum);
            this.Controls.Add(this.txtFlightLoc);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnProceed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookingSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingSummary";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BookingSummary_Load_1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Where;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFlightClass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtNumInfants;
        private System.Windows.Forms.TextBox txtNumChildren;
        private System.Windows.Forms.TextBox txtNumAdults;
        private System.Windows.Forms.TextBox txtTripType;
        private System.Windows.Forms.TextBox txtReturnDateAndTime;
        private System.Windows.Forms.TextBox txtDepartDateAndTime;
        private System.Windows.Forms.TextBox txtFlightNum;
        private System.Windows.Forms.TextBox txtFlightLoc;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPickedSeats;
        private System.Windows.Forms.TextBox txtReturnFlightNum;
    }
}