namespace Airline
{
    partial class Payment
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlPayment = new System.Windows.Forms.Panel();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.pnlCredit = new System.Windows.Forms.Panel();
            this.txtCardNum = new System.Windows.Forms.TextBox();
            this.lblCCV = new System.Windows.Forms.Label();
            this.lblCardNum = new System.Windows.Forms.Label();
            this.txtCCVNum = new System.Windows.Forms.TextBox();
            this.rdbEWallet = new System.Windows.Forms.RadioButton();
            this.pnlEWallet = new System.Windows.Forms.Panel();
            this.chkPayMaya = new System.Windows.Forms.CheckBox();
            this.chkGcash = new System.Windows.Forms.CheckBox();
            this.rdbCredit = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Where = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.pnlPayment.SuspendLayout();
            this.pnlCredit.SuspendLayout();
            this.pnlEWallet.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel5.BackgroundImage = global::Airline.Properties.Resources.PanelHeaderBg;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(607, 50);
            this.panel5.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "E-WALLET OR CREDIT CARD";
            // 
            // pnlPayment
            // 
            this.pnlPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPayment.Controls.Add(this.lblTotalPrice);
            this.pnlPayment.Controls.Add(this.txtTotalPrice);
            this.pnlPayment.Controls.Add(this.pnlEWallet);
            this.pnlPayment.Controls.Add(this.pnlCredit);
            this.pnlPayment.Controls.Add(this.rdbEWallet);
            this.pnlPayment.Controls.Add(this.rdbCredit);
            this.pnlPayment.Controls.Add(this.panel5);
            this.pnlPayment.Location = new System.Drawing.Point(280, 387);
            this.pnlPayment.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.Size = new System.Drawing.Size(607, 312);
            this.pnlPayment.TabIndex = 32;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTotalPrice.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTotalPrice.Location = new System.Drawing.Point(283, 270);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(111, 25);
            this.lblTotalPrice.TabIndex = 54;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(398, 275);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(167, 20);
            this.txtTotalPrice.TabIndex = 54;
            // 
            // pnlCredit
            // 
            this.pnlCredit.Controls.Add(this.txtCardNum);
            this.pnlCredit.Controls.Add(this.lblCCV);
            this.pnlCredit.Controls.Add(this.lblCardNum);
            this.pnlCredit.Controls.Add(this.txtCCVNum);
            this.pnlCredit.Location = new System.Drawing.Point(284, 124);
            this.pnlCredit.Name = "pnlCredit";
            this.pnlCredit.Size = new System.Drawing.Size(307, 108);
            this.pnlCredit.TabIndex = 54;
            // 
            // txtCardNum
            // 
            this.txtCardNum.Location = new System.Drawing.Point(144, 24);
            this.txtCardNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtCardNum.Name = "txtCardNum";
            this.txtCardNum.Size = new System.Drawing.Size(137, 20);
            this.txtCardNum.TabIndex = 39;
            // 
            // lblCCV
            // 
            this.lblCCV.AutoSize = true;
            this.lblCCV.BackColor = System.Drawing.Color.Transparent;
            this.lblCCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCCV.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblCCV.Location = new System.Drawing.Point(6, 58);
            this.lblCCV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCCV.Name = "lblCCV";
            this.lblCCV.Size = new System.Drawing.Size(61, 25);
            this.lblCCV.TabIndex = 45;
            this.lblCCV.Text = "CVV:";
            // 
            // lblCardNum
            // 
            this.lblCardNum.AutoSize = true;
            this.lblCardNum.BackColor = System.Drawing.Color.Transparent;
            this.lblCardNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCardNum.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblCardNum.Location = new System.Drawing.Point(6, 18);
            this.lblCardNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCardNum.Name = "lblCardNum";
            this.lblCardNum.Size = new System.Drawing.Size(135, 25);
            this.lblCardNum.TabIndex = 38;
            this.lblCardNum.Text = "Card Number:";
            // 
            // txtCCVNum
            // 
            this.txtCCVNum.Location = new System.Drawing.Point(144, 64);
            this.txtCCVNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtCCVNum.Name = "txtCCVNum";
            this.txtCCVNum.Size = new System.Drawing.Size(137, 20);
            this.txtCCVNum.TabIndex = 41;
            // 
            // rdbEWallet
            // 
            this.rdbEWallet.AutoSize = true;
            this.rdbEWallet.Checked = true;
            this.rdbEWallet.ForeColor = System.Drawing.Color.SaddleBrown;
            this.rdbEWallet.Location = new System.Drawing.Point(21, 73);
            this.rdbEWallet.Margin = new System.Windows.Forms.Padding(2);
            this.rdbEWallet.Name = "rdbEWallet";
            this.rdbEWallet.Size = new System.Drawing.Size(65, 17);
            this.rdbEWallet.TabIndex = 46;
            this.rdbEWallet.TabStop = true;
            this.rdbEWallet.Text = "E-Wallet";
            this.rdbEWallet.UseVisualStyleBackColor = true;
            this.rdbEWallet.CheckedChanged += new System.EventHandler(this.rdbEWallet_CheckedChanged);
            // 
            // pnlEWallet
            // 
            this.pnlEWallet.Controls.Add(this.chkPayMaya);
            this.pnlEWallet.Controls.Add(this.chkGcash);
            this.pnlEWallet.Location = new System.Drawing.Point(21, 124);
            this.pnlEWallet.Name = "pnlEWallet";
            this.pnlEWallet.Size = new System.Drawing.Size(175, 108);
            this.pnlEWallet.TabIndex = 53;
            // 
            // chkPayMaya
            // 
            this.chkPayMaya.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkPayMaya.AutoSize = true;
            this.chkPayMaya.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.chkPayMaya.ForeColor = System.Drawing.Color.SaddleBrown;
            this.chkPayMaya.Location = new System.Drawing.Point(18, 58);
            this.chkPayMaya.Name = "chkPayMaya";
            this.chkPayMaya.Size = new System.Drawing.Size(114, 29);
            this.chkPayMaya.TabIndex = 52;
            this.chkPayMaya.Text = "PayMaya";
            this.chkPayMaya.UseVisualStyleBackColor = true;
            this.chkPayMaya.CheckedChanged += new System.EventHandler(this.chkPayMaya_CheckedChanged);
            // 
            // chkGcash
            // 
            this.chkGcash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkGcash.AutoSize = true;
            this.chkGcash.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.chkGcash.ForeColor = System.Drawing.Color.SaddleBrown;
            this.chkGcash.Location = new System.Drawing.Point(18, 8);
            this.chkGcash.Name = "chkGcash";
            this.chkGcash.Size = new System.Drawing.Size(88, 29);
            this.chkGcash.TabIndex = 51;
            this.chkGcash.Text = "Gcash";
            this.chkGcash.UseVisualStyleBackColor = true;
            this.chkGcash.CheckedChanged += new System.EventHandler(this.chkGcash_CheckedChanged);
            // 
            // rdbCredit
            // 
            this.rdbCredit.AutoSize = true;
            this.rdbCredit.ForeColor = System.Drawing.Color.SaddleBrown;
            this.rdbCredit.Location = new System.Drawing.Point(284, 73);
            this.rdbCredit.Margin = new System.Windows.Forms.Padding(2);
            this.rdbCredit.Name = "rdbCredit";
            this.rdbCredit.Size = new System.Drawing.Size(52, 17);
            this.rdbCredit.TabIndex = 37;
            this.rdbCredit.Text = "Credit";
            this.rdbCredit.UseVisualStyleBackColor = true;
            this.rdbCredit.CheckedChanged += new System.EventHandler(this.rdbCredit_CheckedChanged);
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
            this.panel2.Size = new System.Drawing.Size(1691, 220);
            this.panel2.TabIndex = 53;
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
            this.Where.Size = new System.Drawing.Size(688, 37);
            this.Where.TabIndex = 23;
            this.Where.Text = "What payment method do you want to use?";
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
            this.pnlHeader.Size = new System.Drawing.Size(1691, 70);
            this.pnlHeader.TabIndex = 52;
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
            this.btnExit.Location = new System.Drawing.Point(1639, 12);
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
            this.Search.Location = new System.Drawing.Point(66, 13);
            this.Search.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(172, 44);
            this.Search.TabIndex = 22;
            this.Search.Text = "Payment";
            // 
            // btnPay
            // 
            this.btnPay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPay.BackgroundImage = global::Airline.Properties.Resources.ButtoncolorBig1;
            this.btnPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPay.Location = new System.Drawing.Point(787, 837);
            this.btnPay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(134, 45);
            this.btnPay.TabIndex = 54;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.txtPhoneNum);
            this.panel1.Controls.Add(this.lblPhoneNum);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(916, 387);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 239);
            this.panel1.TabIndex = 51;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(169, 154);
            this.txtPhoneNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(167, 20);
            this.txtPhoneNum.TabIndex = 52;
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPhoneNum.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblPhoneNum.Location = new System.Drawing.Point(16, 149);
            this.lblPhoneNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(149, 25);
            this.lblPhoneNum.TabIndex = 53;
            this.lblPhoneNum.Text = "Phone Number:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(86, 104);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 20);
            this.txtEmail.TabIndex = 51;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblEmail.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblEmail.Location = new System.Drawing.Point(16, 99);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(66, 25);
            this.lblEmail.TabIndex = 51;
            this.lblEmail.Text = "Email:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel3.BackgroundImage = global::Airline.Properties.Resources.PanelHeaderBg;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(352, 50);
            this.panel3.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(16, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 29);
            this.label7.TabIndex = 32;
            this.label7.Text = "Personal Information";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1691, 955);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlPayment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pnlPayment.ResumeLayout(false);
            this.pnlPayment.PerformLayout();
            this.pnlCredit.ResumeLayout(false);
            this.pnlCredit.PerformLayout();
            this.pnlEWallet.ResumeLayout(false);
            this.pnlEWallet.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlPayment;
        private System.Windows.Forms.TextBox txtCCVNum;
        private System.Windows.Forms.TextBox txtCardNum;
        private System.Windows.Forms.Label lblCardNum;
        private System.Windows.Forms.RadioButton rdbCredit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Where;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.RadioButton rdbEWallet;
        private System.Windows.Forms.Label lblCCV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkPayMaya;
        private System.Windows.Forms.CheckBox chkGcash;
        private System.Windows.Forms.Panel pnlCredit;
        private System.Windows.Forms.Panel pnlEWallet;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txtTotalPrice;
    }
}