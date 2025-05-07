namespace Airline
{
    partial class Admin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.TabAdmin = new System.Windows.Forms.TabControl();
            this.tabDepartDateAndTime = new System.Windows.Forms.TabPage();
            this.pnlDepart = new System.Windows.Forms.Panel();
            this.btnDepartInsert = new System.Windows.Forms.Button();
            this.lblDepartTime = new System.Windows.Forms.Label();
            this.dtpDepartDate = new System.Windows.Forms.DateTimePicker();
            this.txtDepartTime = new System.Windows.Forms.TextBox();
            this.lblDepartDate = new System.Windows.Forms.Label();
            this.dgDepartDateAndTime = new System.Windows.Forms.DataGridView();
            this.tabReturnDateAndTime = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReturnInsert = new System.Windows.Forms.Button();
            this.lblReturnTime = new System.Windows.Forms.Label();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.txtReturnTime = new System.Windows.Forms.TextBox();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.dgReturnDateAndTime = new System.Windows.Forms.DataGridView();
            this.tabBookingHistory = new System.Windows.Forms.TabPage();
            this.dgBookingHistory = new System.Windows.Forms.DataGridView();
            this.tabPaymentHistory = new System.Windows.Forms.TabPage();
            this.dgPaymentHistory = new System.Windows.Forms.DataGridView();
            this.tabSeatSelected = new System.Windows.Forms.TabPage();
            this.dgSeatSelected = new System.Windows.Forms.DataGridView();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.DataGridUsers = new System.Windows.Forms.DataGridView();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.TabAdmin.SuspendLayout();
            this.tabDepartDateAndTime.SuspendLayout();
            this.pnlDepart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartDateAndTime)).BeginInit();
            this.tabReturnDateAndTime.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReturnDateAndTime)).BeginInit();
            this.tabBookingHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookingHistory)).BeginInit();
            this.tabPaymentHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPaymentHistory)).BeginInit();
            this.tabSeatSelected.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSeatSelected)).BeginInit();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Airline.Properties.Resources.panelHeader_2_bg__1_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1440, 220);
            this.panel1.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(214, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(807, 41);
            this.label3.TabIndex = 22;
            this.label3.Text = "PAMBAYANG DALUBHASAAN NG MARILAO AIRLINE";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::Airline.Properties.Resources.logofinal;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(3, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(206, 184);
            this.panel3.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(216, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(558, 27);
            this.label2.TabIndex = 20;
            this.label2.Text = "Where quality flight is a right, not a privelege.";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(214, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(807, 41);
            this.label1.TabIndex = 19;
            this.label1.Text = "PAMBAYANG DALUBHASAAN NG MARILAO AIRLINE";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.SaddleBrown;
            this.pnlHeader.BackgroundImage = global::Airline.Properties.Resources.PanelHeaderBg;
            this.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHeader.Controls.Add(this.btnExit);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1440, 70);
            this.pnlHeader.TabIndex = 24;
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
            this.btnExit.Location = new System.Drawing.Point(1388, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "x";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // TabAdmin
            // 
            this.TabAdmin.Controls.Add(this.tabDepartDateAndTime);
            this.TabAdmin.Controls.Add(this.tabReturnDateAndTime);
            this.TabAdmin.Controls.Add(this.tabBookingHistory);
            this.TabAdmin.Controls.Add(this.tabPaymentHistory);
            this.TabAdmin.Controls.Add(this.tabSeatSelected);
            this.TabAdmin.Controls.Add(this.tabUsers);
            this.TabAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabAdmin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.TabAdmin.Location = new System.Drawing.Point(0, 290);
            this.TabAdmin.Name = "TabAdmin";
            this.TabAdmin.SelectedIndex = 0;
            this.TabAdmin.Size = new System.Drawing.Size(1440, 810);
            this.TabAdmin.TabIndex = 27;
            // 
            // tabDepartDateAndTime
            // 
            this.tabDepartDateAndTime.BackgroundImage = global::Airline.Properties.Resources.PanelHeaderBg;
            this.tabDepartDateAndTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabDepartDateAndTime.Controls.Add(this.pnlDepart);
            this.tabDepartDateAndTime.Controls.Add(this.dgDepartDateAndTime);
            this.tabDepartDateAndTime.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.tabDepartDateAndTime.Location = new System.Drawing.Point(4, 34);
            this.tabDepartDateAndTime.Name = "tabDepartDateAndTime";
            this.tabDepartDateAndTime.Padding = new System.Windows.Forms.Padding(3);
            this.tabDepartDateAndTime.Size = new System.Drawing.Size(1432, 772);
            this.tabDepartDateAndTime.TabIndex = 1;
            this.tabDepartDateAndTime.Text = "Depart Date And Time";
            this.tabDepartDateAndTime.UseVisualStyleBackColor = true;
            // 
            // pnlDepart
            // 
            this.pnlDepart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDepart.BackColor = System.Drawing.Color.Goldenrod;
            this.pnlDepart.Controls.Add(this.btnDepartInsert);
            this.pnlDepart.Controls.Add(this.lblDepartTime);
            this.pnlDepart.Controls.Add(this.dtpDepartDate);
            this.pnlDepart.Controls.Add(this.txtDepartTime);
            this.pnlDepart.Controls.Add(this.lblDepartDate);
            this.pnlDepart.Location = new System.Drawing.Point(299, 70);
            this.pnlDepart.Name = "pnlDepart";
            this.pnlDepart.Size = new System.Drawing.Size(844, 145);
            this.pnlDepart.TabIndex = 76;
            // 
            // btnDepartInsert
            // 
            this.btnDepartInsert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDepartInsert.BackColor = System.Drawing.Color.Transparent;
            this.btnDepartInsert.BackgroundImage = global::Airline.Properties.Resources.ButtoncolorBig1;
            this.btnDepartInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDepartInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDepartInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartInsert.ForeColor = System.Drawing.Color.White;
            this.btnDepartInsert.Location = new System.Drawing.Point(337, 92);
            this.btnDepartInsert.Name = "btnDepartInsert";
            this.btnDepartInsert.Size = new System.Drawing.Size(150, 40);
            this.btnDepartInsert.TabIndex = 77;
            this.btnDepartInsert.Text = "Insert";
            this.btnDepartInsert.UseVisualStyleBackColor = false;
            this.btnDepartInsert.Click += new System.EventHandler(this.btnDepartInsert_Click);
            // 
            // lblDepartTime
            // 
            this.lblDepartTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDepartTime.AutoSize = true;
            this.lblDepartTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartTime.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartTime.ForeColor = System.Drawing.Color.Black;
            this.lblDepartTime.Location = new System.Drawing.Point(455, 20);
            this.lblDepartTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartTime.Name = "lblDepartTime";
            this.lblDepartTime.Size = new System.Drawing.Size(138, 24);
            this.lblDepartTime.TabIndex = 74;
            this.lblDepartTime.Text = "Depart Time";
            // 
            // dtpDepartDate
            // 
            this.dtpDepartDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDepartDate.Font = new System.Drawing.Font("Lucida Sans", 20.25F);
            this.dtpDepartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDepartDate.Location = new System.Drawing.Point(115, 47);
            this.dtpDepartDate.Name = "dtpDepartDate";
            this.dtpDepartDate.Size = new System.Drawing.Size(247, 39);
            this.dtpDepartDate.TabIndex = 71;
            // 
            // txtDepartTime
            // 
            this.txtDepartTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDepartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartTime.Location = new System.Drawing.Point(459, 47);
            this.txtDepartTime.Name = "txtDepartTime";
            this.txtDepartTime.Size = new System.Drawing.Size(247, 38);
            this.txtDepartTime.TabIndex = 72;
            // 
            // lblDepartDate
            // 
            this.lblDepartDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDepartDate.AutoSize = true;
            this.lblDepartDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartDate.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartDate.ForeColor = System.Drawing.Color.Black;
            this.lblDepartDate.Location = new System.Drawing.Point(111, 20);
            this.lblDepartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartDate.Name = "lblDepartDate";
            this.lblDepartDate.Size = new System.Drawing.Size(137, 24);
            this.lblDepartDate.TabIndex = 73;
            this.lblDepartDate.Text = "Depart Date";
            // 
            // dgDepartDateAndTime
            // 
            this.dgDepartDateAndTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgDepartDateAndTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDepartDateAndTime.Location = new System.Drawing.Point(290, 268);
            this.dgDepartDateAndTime.Name = "dgDepartDateAndTime";
            this.dgDepartDateAndTime.RowHeadersVisible = false;
            this.dgDepartDateAndTime.Size = new System.Drawing.Size(853, 434);
            this.dgDepartDateAndTime.TabIndex = 75;
            // 
            // tabReturnDateAndTime
            // 
            this.tabReturnDateAndTime.BackgroundImage = global::Airline.Properties.Resources.PanelHeaderBg;
            this.tabReturnDateAndTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabReturnDateAndTime.Controls.Add(this.panel2);
            this.tabReturnDateAndTime.Controls.Add(this.dgReturnDateAndTime);
            this.tabReturnDateAndTime.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.tabReturnDateAndTime.Location = new System.Drawing.Point(4, 34);
            this.tabReturnDateAndTime.Name = "tabReturnDateAndTime";
            this.tabReturnDateAndTime.Size = new System.Drawing.Size(1432, 772);
            this.tabReturnDateAndTime.TabIndex = 2;
            this.tabReturnDateAndTime.Text = "Return Date and Time";
            this.tabReturnDateAndTime.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.Controls.Add(this.btnReturnInsert);
            this.panel2.Controls.Add(this.lblReturnTime);
            this.panel2.Controls.Add(this.dtpReturnDate);
            this.panel2.Controls.Add(this.txtReturnTime);
            this.panel2.Controls.Add(this.lblReturnDate);
            this.panel2.Location = new System.Drawing.Point(299, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(844, 145);
            this.panel2.TabIndex = 78;
            // 
            // btnReturnInsert
            // 
            this.btnReturnInsert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReturnInsert.BackColor = System.Drawing.Color.Transparent;
            this.btnReturnInsert.BackgroundImage = global::Airline.Properties.Resources.ButtoncolorBig1;
            this.btnReturnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnInsert.ForeColor = System.Drawing.Color.White;
            this.btnReturnInsert.Location = new System.Drawing.Point(337, 92);
            this.btnReturnInsert.Name = "btnReturnInsert";
            this.btnReturnInsert.Size = new System.Drawing.Size(150, 40);
            this.btnReturnInsert.TabIndex = 77;
            this.btnReturnInsert.Text = "Insert";
            this.btnReturnInsert.UseVisualStyleBackColor = false;
            this.btnReturnInsert.Click += new System.EventHandler(this.btnReturnInsert_Click);
            // 
            // lblReturnTime
            // 
            this.lblReturnTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReturnTime.AutoSize = true;
            this.lblReturnTime.BackColor = System.Drawing.Color.Transparent;
            this.lblReturnTime.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnTime.ForeColor = System.Drawing.Color.Black;
            this.lblReturnTime.Location = new System.Drawing.Point(446, 22);
            this.lblReturnTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReturnTime.Name = "lblReturnTime";
            this.lblReturnTime.Size = new System.Drawing.Size(136, 24);
            this.lblReturnTime.TabIndex = 74;
            this.lblReturnTime.Text = "Return Time";
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpReturnDate.Font = new System.Drawing.Font("Lucida Sans", 20.25F);
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturnDate.Location = new System.Drawing.Point(117, 49);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(247, 39);
            this.dtpReturnDate.TabIndex = 71;
            // 
            // txtReturnTime
            // 
            this.txtReturnTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtReturnTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnTime.Location = new System.Drawing.Point(450, 49);
            this.txtReturnTime.Name = "txtReturnTime";
            this.txtReturnTime.Size = new System.Drawing.Size(247, 38);
            this.txtReturnTime.TabIndex = 72;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.BackColor = System.Drawing.Color.Transparent;
            this.lblReturnDate.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.ForeColor = System.Drawing.Color.Black;
            this.lblReturnDate.Location = new System.Drawing.Point(113, 22);
            this.lblReturnDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(135, 24);
            this.lblReturnDate.TabIndex = 73;
            this.lblReturnDate.Text = "Return Date";
            // 
            // dgReturnDateAndTime
            // 
            this.dgReturnDateAndTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgReturnDateAndTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReturnDateAndTime.Location = new System.Drawing.Point(290, 268);
            this.dgReturnDateAndTime.Name = "dgReturnDateAndTime";
            this.dgReturnDateAndTime.RowHeadersVisible = false;
            this.dgReturnDateAndTime.Size = new System.Drawing.Size(853, 434);
            this.dgReturnDateAndTime.TabIndex = 77;
            // 
            // tabBookingHistory
            // 
            this.tabBookingHistory.BackgroundImage = global::Airline.Properties.Resources.PanelHeaderBg;
            this.tabBookingHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabBookingHistory.Controls.Add(this.dgBookingHistory);
            this.tabBookingHistory.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.tabBookingHistory.Location = new System.Drawing.Point(4, 34);
            this.tabBookingHistory.Name = "tabBookingHistory";
            this.tabBookingHistory.Size = new System.Drawing.Size(1432, 772);
            this.tabBookingHistory.TabIndex = 5;
            this.tabBookingHistory.Text = "Booking History";
            this.tabBookingHistory.UseVisualStyleBackColor = true;
            // 
            // dgBookingHistory
            // 
            this.dgBookingHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBookingHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBookingHistory.Location = new System.Drawing.Point(0, 0);
            this.dgBookingHistory.Name = "dgBookingHistory";
            this.dgBookingHistory.RowHeadersVisible = false;
            this.dgBookingHistory.Size = new System.Drawing.Size(1432, 772);
            this.dgBookingHistory.TabIndex = 78;
            // 
            // tabPaymentHistory
            // 
            this.tabPaymentHistory.Controls.Add(this.dgPaymentHistory);
            this.tabPaymentHistory.Location = new System.Drawing.Point(4, 34);
            this.tabPaymentHistory.Name = "tabPaymentHistory";
            this.tabPaymentHistory.Size = new System.Drawing.Size(1432, 772);
            this.tabPaymentHistory.TabIndex = 7;
            this.tabPaymentHistory.Text = "Payment History";
            this.tabPaymentHistory.UseVisualStyleBackColor = true;
            // 
            // dgPaymentHistory
            // 
            this.dgPaymentHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPaymentHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPaymentHistory.Location = new System.Drawing.Point(0, 0);
            this.dgPaymentHistory.Name = "dgPaymentHistory";
            this.dgPaymentHistory.RowHeadersVisible = false;
            this.dgPaymentHistory.Size = new System.Drawing.Size(1432, 772);
            this.dgPaymentHistory.TabIndex = 79;
            // 
            // tabSeatSelected
            // 
            this.tabSeatSelected.Controls.Add(this.dgSeatSelected);
            this.tabSeatSelected.Location = new System.Drawing.Point(4, 34);
            this.tabSeatSelected.Name = "tabSeatSelected";
            this.tabSeatSelected.Size = new System.Drawing.Size(1432, 772);
            this.tabSeatSelected.TabIndex = 8;
            this.tabSeatSelected.Text = "Seat Selected";
            this.tabSeatSelected.UseVisualStyleBackColor = true;
            // 
            // dgSeatSelected
            // 
            this.dgSeatSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSeatSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSeatSelected.Location = new System.Drawing.Point(0, 0);
            this.dgSeatSelected.Name = "dgSeatSelected";
            this.dgSeatSelected.RowHeadersVisible = false;
            this.dgSeatSelected.Size = new System.Drawing.Size(1432, 772);
            this.dgSeatSelected.TabIndex = 80;
            // 
            // tabUsers
            // 
            this.tabUsers.BackgroundImage = global::Airline.Properties.Resources.PanelHeaderBg;
            this.tabUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabUsers.Controls.Add(this.DataGridUsers);
            this.tabUsers.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.tabUsers.Location = new System.Drawing.Point(4, 34);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Size = new System.Drawing.Size(1432, 772);
            this.tabUsers.TabIndex = 6;
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // DataGridUsers
            // 
            this.DataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_id,
            this.username,
            this.role,
            this.created_at});
            this.DataGridUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridUsers.Location = new System.Drawing.Point(0, 0);
            this.DataGridUsers.Name = "DataGridUsers";
            this.DataGridUsers.RowHeadersVisible = false;
            this.DataGridUsers.Size = new System.Drawing.Size(1432, 772);
            this.DataGridUsers.TabIndex = 0;
            this.DataGridUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // user_id
            // 
            this.user_id.HeaderText = "UserID";
            this.user_id.Name = "user_id";
            // 
            // username
            // 
            this.username.HeaderText = "User Name";
            this.username.Name = "username";
            // 
            // role
            // 
            this.role.HeaderText = "Role";
            this.role.Name = "role";
            // 
            // created_at
            // 
            this.created_at.HeaderText = "Created At";
            this.created_at.Name = "created_at";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 1100);
            this.Controls.Add(this.TabAdmin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.TabAdmin.ResumeLayout(false);
            this.tabDepartDateAndTime.ResumeLayout(false);
            this.pnlDepart.ResumeLayout(false);
            this.pnlDepart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartDateAndTime)).EndInit();
            this.tabReturnDateAndTime.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReturnDateAndTime)).EndInit();
            this.tabBookingHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgBookingHistory)).EndInit();
            this.tabPaymentHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPaymentHistory)).EndInit();
            this.tabSeatSelected.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSeatSelected)).EndInit();
            this.tabUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TabControl TabAdmin;
        private System.Windows.Forms.TabPage tabDepartDateAndTime;
        private System.Windows.Forms.TabPage tabReturnDateAndTime;
        private System.Windows.Forms.TabPage tabBookingHistory;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.DataGridView DataGridUsers;
        private System.Windows.Forms.Panel pnlDepart;
        private System.Windows.Forms.Button btnDepartInsert;
        private System.Windows.Forms.Label lblDepartTime;
        private System.Windows.Forms.DateTimePicker dtpDepartDate;
        private System.Windows.Forms.TextBox txtDepartTime;
        private System.Windows.Forms.Label lblDepartDate;
        private System.Windows.Forms.DataGridView dgDepartDateAndTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReturnInsert;
        private System.Windows.Forms.Label lblReturnTime;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.TextBox txtReturnTime;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.DataGridView dgReturnDateAndTime;
        private System.Windows.Forms.DataGridView dgBookingHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at;
        private System.Windows.Forms.TabPage tabPaymentHistory;
        private System.Windows.Forms.DataGridView dgPaymentHistory;
        private System.Windows.Forms.TabPage tabSeatSelected;
        private System.Windows.Forms.DataGridView dgSeatSelected;
    }
}