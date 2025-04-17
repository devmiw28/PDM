namespace Airline
{
    partial class SearchFlight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchFlight));
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Where = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbTrip = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbLoc1 = new System.Windows.Forms.ComboBox();
            this.Loc2 = new System.Windows.Forms.ComboBox();
            this.DTPDepart = new System.Windows.Forms.DateTimePicker();
            this.DTPReturn = new System.Windows.Forms.DateTimePicker();
            this.CmbAdults = new System.Windows.Forms.ComboBox();
            this.CmbChildren = new System.Windows.Forms.ComboBox();
            this.CmbInfant = new System.Windows.Forms.ComboBox();
            this.Promo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblDepart = new System.Windows.Forms.Label();
            this.LblReturn = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnSwitch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.PnlInfant = new System.Windows.Forms.Panel();
            this.lblInfant = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(81, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 39);
            this.label2.TabIndex = 24;
            this.label2.Text = "Flight";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 369);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 62);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Airline.Properties.Resources.AirplaneBG;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Where);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 86);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1733, 271);
            this.panel1.TabIndex = 25;
            // 
            // Where
            // 
            this.Where.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Where.AutoSize = true;
            this.Where.BackColor = System.Drawing.Color.Transparent;
            this.Where.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Where.ForeColor = System.Drawing.Color.Black;
            this.Where.Location = new System.Drawing.Point(89, 86);
            this.Where.Name = "Where";
            this.Where.Size = new System.Drawing.Size(632, 45);
            this.Where.TabIndex = 23;
            this.Where.Text = "Hi, where would you like to go?";
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
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1733, 86);
            this.pnlHeader.TabIndex = 16;
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
            this.btnExit.Location = new System.Drawing.Point(1664, 15);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(53, 49);
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
            this.Search.Location = new System.Drawing.Point(88, 16);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(314, 56);
            this.Search.TabIndex = 22;
            this.Search.Text = "Search Flight";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(532, 372);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 52);
            this.label1.TabIndex = 27;
            this.label1.Text = "|";
            // 
            // CmbTrip
            // 
            this.CmbTrip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CmbTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbTrip.Font = new System.Drawing.Font("Lucida Sans", 20.25F);
            this.CmbTrip.FormattingEnabled = true;
            this.CmbTrip.Items.AddRange(new object[] {
            "Round-trip",
            "One-way"});
            this.CmbTrip.Location = new System.Drawing.Point(871, 377);
            this.CmbTrip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbTrip.Name = "CmbTrip";
            this.CmbTrip.Size = new System.Drawing.Size(267, 47);
            this.CmbTrip.TabIndex = 28;
            this.CmbTrip.Text = "Round-trip";
            this.CmbTrip.SelectedIndexChanged += new System.EventHandler(this.CbTrip_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(597, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 39);
            this.label3.TabIndex = 29;
            this.label3.Text = "Trip Selection";
            // 
            // CmbLoc1
            // 
            this.CmbLoc1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CmbLoc1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbLoc1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbLoc1.Font = new System.Drawing.Font("Lucida Sans", 20.25F);
            this.CmbLoc1.FormattingEnabled = true;
            this.CmbLoc1.Items.AddRange(new object[] {
            "Marilao MRL"});
            this.CmbLoc1.Location = new System.Drawing.Point(13, 522);
            this.CmbLoc1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbLoc1.Name = "CmbLoc1";
            this.CmbLoc1.Size = new System.Drawing.Size(328, 47);
            this.CmbLoc1.TabIndex = 30;
            // 
            // Loc2
            // 
            this.Loc2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Loc2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Loc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loc2.Font = new System.Drawing.Font("Lucida Sans", 20.25F);
            this.Loc2.FormattingEnabled = true;
            this.Loc2.Items.AddRange(new object[] {
            "Cebu   CEB",
            "Davao   DVO",
            "Iloilo   ILO",
            "Palawan   PPS"});
            this.Loc2.Location = new System.Drawing.Point(407, 522);
            this.Loc2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Loc2.Name = "Loc2";
            this.Loc2.Size = new System.Drawing.Size(328, 47);
            this.Loc2.TabIndex = 31;
            // 
            // DTPDepart
            // 
            this.DTPDepart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DTPDepart.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPDepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPDepart.Location = new System.Drawing.Point(772, 527);
            this.DTPDepart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DTPDepart.Name = "DTPDepart";
            this.DTPDepart.Size = new System.Drawing.Size(477, 37);
            this.DTPDepart.TabIndex = 32;
            // 
            // DTPReturn
            // 
            this.DTPReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DTPReturn.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPReturn.Location = new System.Drawing.Point(1259, 527);
            this.DTPReturn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DTPReturn.Name = "DTPReturn";
            this.DTPReturn.Size = new System.Drawing.Size(477, 37);
            this.DTPReturn.TabIndex = 33;
            // 
            // CmbAdults
            // 
            this.CmbAdults.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CmbAdults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbAdults.Font = new System.Drawing.Font("Lucida Sans", 20.25F);
            this.CmbAdults.FormattingEnabled = true;
            this.CmbAdults.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.CmbAdults.Location = new System.Drawing.Point(13, 650);
            this.CmbAdults.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbAdults.Name = "CmbAdults";
            this.CmbAdults.Size = new System.Drawing.Size(328, 47);
            this.CmbAdults.TabIndex = 34;
            this.CmbAdults.Text = "1";
            // 
            // CmbChildren
            // 
            this.CmbChildren.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CmbChildren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbChildren.Font = new System.Drawing.Font("Lucida Sans", 20.25F);
            this.CmbChildren.FormattingEnabled = true;
            this.CmbChildren.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19"});
            this.CmbChildren.Location = new System.Drawing.Point(407, 650);
            this.CmbChildren.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbChildren.Name = "CmbChildren";
            this.CmbChildren.Size = new System.Drawing.Size(328, 47);
            this.CmbChildren.TabIndex = 35;
            this.CmbChildren.Text = "0";
            // 
            // CmbInfant
            // 
            this.CmbInfant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CmbInfant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbInfant.Font = new System.Drawing.Font("Lucida Sans", 20.25F);
            this.CmbInfant.FormattingEnabled = true;
            this.CmbInfant.Location = new System.Drawing.Point(772, 650);
            this.CmbInfant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbInfant.Name = "CmbInfant";
            this.CmbInfant.Size = new System.Drawing.Size(328, 47);
            this.CmbInfant.TabIndex = 36;
            this.CmbInfant.Text = "0";
            this.CmbInfant.SelectedIndexChanged += new System.EventHandler(this.Pet_SelectedIndexChanged);
            // 
            // Promo
            // 
            this.Promo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Promo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Promo.Location = new System.Drawing.Point(1140, 650);
            this.Promo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Promo.Name = "Promo";
            this.Promo.Size = new System.Drawing.Size(328, 46);
            this.Promo.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 489);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 32);
            this.label4.TabIndex = 38;
            this.label4.Text = "From";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(401, 489);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 32);
            this.label5.TabIndex = 39;
            this.label5.Text = "To";
            // 
            // LblDepart
            // 
            this.LblDepart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblDepart.AutoSize = true;
            this.LblDepart.BackColor = System.Drawing.Color.Transparent;
            this.LblDepart.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDepart.ForeColor = System.Drawing.Color.Black;
            this.LblDepart.Location = new System.Drawing.Point(767, 489);
            this.LblDepart.Name = "LblDepart";
            this.LblDepart.Size = new System.Drawing.Size(105, 32);
            this.LblDepart.TabIndex = 40;
            this.LblDepart.Text = "Depart";
            // 
            // LblReturn
            // 
            this.LblReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblReturn.AutoSize = true;
            this.LblReturn.BackColor = System.Drawing.Color.Transparent;
            this.LblReturn.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReturn.ForeColor = System.Drawing.Color.Black;
            this.LblReturn.Location = new System.Drawing.Point(1253, 489);
            this.LblReturn.Name = "LblReturn";
            this.LblReturn.Size = new System.Drawing.Size(105, 32);
            this.LblReturn.TabIndex = 41;
            this.LblReturn.Text = "Return";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 617);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 32);
            this.label8.TabIndex = 42;
            this.label8.Text = "Adults";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(401, 617);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 32);
            this.label9.TabIndex = 43;
            this.label9.Text = "Children";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(767, 617);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 32);
            this.label10.TabIndex = 44;
            this.label10.Text = "Infant";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(1135, 617);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(226, 32);
            this.label11.TabIndex = 45;
            this.label11.Text = "Niggahahaahha";
            // 
            // BtnSwitch
            // 
            this.BtnSwitch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSwitch.Location = new System.Drawing.Point(351, 522);
            this.BtnSwitch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSwitch.Name = "BtnSwitch";
            this.BtnSwitch.Size = new System.Drawing.Size(48, 53);
            this.BtnSwitch.TabIndex = 46;
            this.BtnSwitch.Text = "⇆";
            this.BtnSwitch.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(9, 703);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 23);
            this.label6.TabIndex = 47;
            this.label6.Text = "18+ years";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(403, 703);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 23);
            this.label7.TabIndex = 48;
            this.label7.Text = "2 -17 years";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(768, 703);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 23);
            this.label12.TabIndex = 49;
            this.label12.Text = "under 2 years";
            // 
            // PnlInfant
            // 
            this.PnlInfant.BackColor = System.Drawing.Color.DimGray;
            this.PnlInfant.Location = new System.Drawing.Point(772, 741);
            this.PnlInfant.Name = "PnlInfant";
            this.PnlInfant.Size = new System.Drawing.Size(200, 100);
            this.PnlInfant.TabIndex = 50;
            // 
            // lblInfant
            // 
            this.lblInfant.AutoSize = true;
            this.lblInfant.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblInfant.Location = new System.Drawing.Point(776, 654);
            this.lblInfant.Name = "lblInfant";
            this.lblInfant.Size = new System.Drawing.Size(344, 39);
            this.lblInfant.TabIndex = 51;
            this.lblInfant.Text = "              ajdkljalkfjsdlk";
            this.lblInfant.Click += new System.EventHandler(this.label13_Click);
            // 
            // SearchFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1733, 923);
            this.Controls.Add(this.lblInfant);
            this.Controls.Add(this.PnlInfant);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnSwitch);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LblReturn);
            this.Controls.Add(this.LblDepart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Promo);
            this.Controls.Add(this.CmbInfant);
            this.Controls.Add(this.CmbChildren);
            this.Controls.Add(this.CmbAdults);
            this.Controls.Add(this.DTPReturn);
            this.Controls.Add(this.DTPDepart);
            this.Controls.Add(this.Loc2);
            this.Controls.Add(this.CmbLoc1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbTrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SearchFlight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchFlight";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SearchFlight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Where;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbTrip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbLoc1;
        private System.Windows.Forms.ComboBox Loc2;
        private System.Windows.Forms.DateTimePicker DTPDepart;
        private System.Windows.Forms.DateTimePicker DTPReturn;
        private System.Windows.Forms.ComboBox CmbAdults;
        private System.Windows.Forms.ComboBox CmbChildren;
        private System.Windows.Forms.ComboBox CmbInfant;
        private System.Windows.Forms.TextBox Promo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblDepart;
        private System.Windows.Forms.Label LblReturn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnSwitch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel PnlInfant;
        private System.Windows.Forms.Label lblInfant;
    }
}