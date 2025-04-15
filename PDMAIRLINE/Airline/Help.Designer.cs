namespace Airline
{
    partial class Help
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblHelp = new System.Windows.Forms.Label();
            this.lblLogIn = new System.Windows.Forms.Label();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.lblLearnMore = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(142, 254);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(447, 37);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(592, 253);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(65, 39);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "🔎";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // listBoxResults
            // 
            this.listBoxResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxResults.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.ItemHeight = 22;
            this.listBoxResults.Location = new System.Drawing.Point(142, 322);
            this.listBoxResults.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(532, 132);
            this.listBoxResults.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Airline.Properties.Resources.panelHeader_2_bg__1_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pnlHeader);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, -14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 222);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(149, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(627, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "PDM AIRLINE HELP CENTER";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Airline.Properties.Resources.PDM_AIRLINE_HELP_CENTER_LOGO_removebg_preview__3__removebg_preview_removebg_preview__1_;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(28, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 102);
            this.panel2.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.SaddleBrown;
            this.pnlHeader.BackgroundImage = global::Airline.Properties.Resources.PanelHeaderBg;
            this.pnlHeader.Controls.Add(this.lblHelp);
            this.pnlHeader.Controls.Add(this.lblLogIn);
            this.pnlHeader.Controls.Add(this.lblSignUp);
            this.pnlHeader.Controls.Add(this.lblLearnMore);
            this.pnlHeader.Controls.Add(this.btnExit);
            this.pnlHeader.Location = new System.Drawing.Point(-4, 13);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(900, 60);
            this.pnlHeader.TabIndex = 16;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnExit.BackgroundImage = global::Airline.Properties.Resources.ButtonSmall;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Gold;
            this.btnExit.Location = new System.Drawing.Point(905, 11);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 38);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "x";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.BackColor = System.Drawing.Color.Transparent;
            this.lblHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblHelp.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.lblHelp.ForeColor = System.Drawing.Color.Gold;
            this.lblHelp.Location = new System.Drawing.Point(776, 22);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(39, 17);
            this.lblHelp.TabIndex = 21;
            this.lblHelp.Text = "HELP";
            // 
            // lblLogIn
            // 
            this.lblLogIn.AutoSize = true;
            this.lblLogIn.BackColor = System.Drawing.Color.Transparent;
            this.lblLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblLogIn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.lblLogIn.ForeColor = System.Drawing.Color.Gold;
            this.lblLogIn.Location = new System.Drawing.Point(453, 22);
            this.lblLogIn.Name = "lblLogIn";
            this.lblLogIn.Size = new System.Drawing.Size(56, 17);
            this.lblLogIn.TabIndex = 22;
            this.lblLogIn.Text = "LOG IN";
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.BackColor = System.Drawing.Color.Transparent;
            this.lblSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSignUp.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.lblSignUp.ForeColor = System.Drawing.Color.Gold;
            this.lblSignUp.Location = new System.Drawing.Point(546, 22);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(62, 17);
            this.lblSignUp.TabIndex = 23;
            this.lblSignUp.Text = "SIGN UP";
            // 
            // lblLearnMore
            // 
            this.lblLearnMore.AutoSize = true;
            this.lblLearnMore.BackColor = System.Drawing.Color.Transparent;
            this.lblLearnMore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblLearnMore.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.lblLearnMore.ForeColor = System.Drawing.Color.Gold;
            this.lblLearnMore.Location = new System.Drawing.Point(650, 22);
            this.lblLearnMore.Name = "lblLearnMore";
            this.lblLearnMore.Size = new System.Drawing.Size(93, 17);
            this.lblLearnMore.TabIndex = 20;
            this.lblLearnMore.Text = "LEARN MORE";
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(832, 556);
            this.Controls.Add(this.listBoxResults);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Help";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Help_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label lblLogIn;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Label lblLearnMore;
    }
}