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
            this.label1 = new System.Windows.Forms.Label();
            this.CmbTrip = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbLoc1 = new System.Windows.Forms.ComboBox();
            this.CmbLoc2 = new System.Windows.Forms.ComboBox();
            this.DTPDepart = new System.Windows.Forms.DateTimePicker();
            this.DTPReturn = new System.Windows.Forms.DateTimePicker();
            this.CmbAdults = new System.Windows.Forms.ComboBox();
            this.CmbChildren = new System.Windows.Forms.ComboBox();
            this.CmbInfant = new System.Windows.Forms.ComboBox();
            this.txtPromo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblDepartDate = new System.Windows.Forms.Label();
            this.LblReturnDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LblXFrom = new System.Windows.Forms.Label();
            this.LblXTo = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.numericUpDownAdults = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownChildren = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownInfants = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.LblReturnTime = new System.Windows.Forms.Label();
            this.CmbDepartTime = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Where = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChildren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInfants)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(256, 411);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 32);
            this.label2.TabIndex = 24;
            this.label2.Text = "Flight";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(594, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 39);
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
            this.CmbTrip.Location = new System.Drawing.Point(848, 408);
            this.CmbTrip.Name = "CmbTrip";
            this.CmbTrip.Size = new System.Drawing.Size(201, 40);
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
            this.label3.Location = new System.Drawing.Point(643, 412);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 32);
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
            this.CmbLoc1.Location = new System.Drawing.Point(205, 526);
            this.CmbLoc1.Name = "CmbLoc1";
            this.CmbLoc1.Size = new System.Drawing.Size(247, 40);
            this.CmbLoc1.TabIndex = 30;
            this.CmbLoc1.SelectedIndexChanged += new System.EventHandler(this.CmbLoc1_SelectedIndexChanged);
            // 
            // CmbLoc2
            // 
            this.CmbLoc2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CmbLoc2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbLoc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbLoc2.Font = new System.Drawing.Font("Lucida Sans", 20.25F);
            this.CmbLoc2.FormattingEnabled = true;
            this.CmbLoc2.Location = new System.Drawing.Point(500, 526);
            this.CmbLoc2.Name = "CmbLoc2";
            this.CmbLoc2.Size = new System.Drawing.Size(247, 40);
            this.CmbLoc2.TabIndex = 31;
            this.CmbLoc2.SelectedIndexChanged += new System.EventHandler(this.CmbLoc2_SelectedIndexChanged);
            // 
            // DTPDepart
            // 
            this.DTPDepart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DTPDepart.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPDepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPDepart.Location = new System.Drawing.Point(774, 530);
            this.DTPDepart.Name = "DTPDepart";
            this.DTPDepart.Size = new System.Drawing.Size(359, 31);
            this.DTPDepart.TabIndex = 32;
            this.DTPDepart.ValueChanged += new System.EventHandler(this.DTPDepart_ValueChanged);
            // 
            // DTPReturn
            // 
            this.DTPReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DTPReturn.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPReturn.Location = new System.Drawing.Point(1139, 530);
            this.DTPReturn.Name = "DTPReturn";
            this.DTPReturn.Size = new System.Drawing.Size(359, 31);
            this.DTPReturn.TabIndex = 33;
            this.DTPReturn.ValueChanged += new System.EventHandler(this.DTPReturn_ValueChanged);
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
            this.CmbAdults.Location = new System.Drawing.Point(205, 630);
            this.CmbAdults.Name = "CmbAdults";
            this.CmbAdults.Size = new System.Drawing.Size(247, 40);
            this.CmbAdults.TabIndex = 34;
            this.CmbAdults.Text = "1";
            this.CmbAdults.SelectedIndexChanged += new System.EventHandler(this.CmbAdults_SelectedIndexChanged);
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
            this.CmbChildren.Location = new System.Drawing.Point(500, 630);
            this.CmbChildren.Name = "CmbChildren";
            this.CmbChildren.Size = new System.Drawing.Size(247, 40);
            this.CmbChildren.TabIndex = 35;
            this.CmbChildren.Text = "0";
            // 
            // CmbInfant
            // 
            this.CmbInfant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CmbInfant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbInfant.Font = new System.Drawing.Font("Lucida Sans", 20.25F);
            this.CmbInfant.FormattingEnabled = true;
            this.CmbInfant.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.CmbInfant.Location = new System.Drawing.Point(205, 750);
            this.CmbInfant.Name = "CmbInfant";
            this.CmbInfant.Size = new System.Drawing.Size(247, 40);
            this.CmbInfant.TabIndex = 36;
            this.CmbInfant.Text = "0";
            this.CmbInfant.SelectedIndexChanged += new System.EventHandler(this.Pet_SelectedIndexChanged);
            // 
            // txtPromo
            // 
            this.txtPromo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromo.Location = new System.Drawing.Point(490, 746);
            this.txtPromo.Name = "txtPromo";
            this.txtPromo.Size = new System.Drawing.Size(247, 38);
            this.txtPromo.TabIndex = 37;
            this.txtPromo.TextChanged += new System.EventHandler(this.Promo_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(197, 499);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
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
            this.label5.Location = new System.Drawing.Point(496, 499);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 24);
            this.label5.TabIndex = 39;
            this.label5.Text = "To";
            // 
            // LblDepartDate
            // 
            this.LblDepartDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblDepartDate.AutoSize = true;
            this.LblDepartDate.BackColor = System.Drawing.Color.Transparent;
            this.LblDepartDate.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDepartDate.ForeColor = System.Drawing.Color.Black;
            this.LblDepartDate.Location = new System.Drawing.Point(770, 499);
            this.LblDepartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDepartDate.Name = "LblDepartDate";
            this.LblDepartDate.Size = new System.Drawing.Size(137, 24);
            this.LblDepartDate.TabIndex = 40;
            this.LblDepartDate.Text = "Depart Date";
            // 
            // LblReturnDate
            // 
            this.LblReturnDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblReturnDate.AutoSize = true;
            this.LblReturnDate.BackColor = System.Drawing.Color.Transparent;
            this.LblReturnDate.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReturnDate.ForeColor = System.Drawing.Color.Black;
            this.LblReturnDate.Location = new System.Drawing.Point(1135, 499);
            this.LblReturnDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblReturnDate.Name = "LblReturnDate";
            this.LblReturnDate.Size = new System.Drawing.Size(135, 24);
            this.LblReturnDate.TabIndex = 41;
            this.LblReturnDate.Text = "Return Date";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(197, 603);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 24);
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
            this.label9.Location = new System.Drawing.Point(496, 603);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 24);
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
            this.label10.Location = new System.Drawing.Point(210, 719);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 24);
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
            this.label11.Location = new System.Drawing.Point(486, 719);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 24);
            this.label11.TabIndex = 45;
            this.label11.Text = "Promo";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(202, 673);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
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
            this.label7.Location = new System.Drawing.Point(497, 673);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 18);
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
            this.label12.Location = new System.Drawing.Point(211, 789);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 18);
            this.label12.TabIndex = 49;
            this.label12.Text = "under 2 years";
            // 
            // LblXFrom
            // 
            this.LblXFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblXFrom.AutoSize = true;
            this.LblXFrom.BackColor = System.Drawing.Color.Transparent;
            this.LblXFrom.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblXFrom.ForeColor = System.Drawing.Color.Black;
            this.LblXFrom.Location = new System.Drawing.Point(408, 534);
            this.LblXFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblXFrom.Name = "LblXFrom";
            this.LblXFrom.Size = new System.Drawing.Size(23, 24);
            this.LblXFrom.TabIndex = 50;
            this.LblXFrom.Text = "X";
            this.LblXFrom.Click += new System.EventHandler(this.LblXFrom_Click);
            // 
            // LblXTo
            // 
            this.LblXTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblXTo.AutoSize = true;
            this.LblXTo.BackColor = System.Drawing.Color.Transparent;
            this.LblXTo.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblXTo.ForeColor = System.Drawing.Color.Black;
            this.LblXTo.Location = new System.Drawing.Point(703, 534);
            this.LblXTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblXTo.Name = "LblXTo";
            this.LblXTo.Size = new System.Drawing.Size(23, 24);
            this.LblXTo.TabIndex = 51;
            this.LblXTo.Text = "X";
            this.LblXTo.Click += new System.EventHandler(this.LblXTo_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.BtnSearch.Location = new System.Drawing.Point(1251, 745);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(247, 38);
            this.BtnSearch.TabIndex = 52;
            this.BtnSearch.Text = "Search flights";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // numericUpDownAdults
            // 
            this.numericUpDownAdults.Location = new System.Drawing.Point(0, 0);
            this.numericUpDownAdults.Name = "numericUpDownAdults";
            this.numericUpDownAdults.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownAdults.TabIndex = 0;
            // 
            // numericUpDownChildren
            // 
            this.numericUpDownChildren.Location = new System.Drawing.Point(0, 0);
            this.numericUpDownChildren.Name = "numericUpDownChildren";
            this.numericUpDownChildren.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownChildren.TabIndex = 0;
            // 
            // numericUpDownInfants
            // 
            this.numericUpDownInfants.Location = new System.Drawing.Point(0, 0);
            this.numericUpDownInfants.Name = "numericUpDownInfants";
            this.numericUpDownInfants.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownInfants.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(770, 603);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 24);
            this.label13.TabIndex = 60;
            this.label13.Text = "Depart Time";
            // 
            // LblReturnTime
            // 
            this.LblReturnTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblReturnTime.AutoSize = true;
            this.LblReturnTime.BackColor = System.Drawing.Color.Transparent;
            this.LblReturnTime.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReturnTime.ForeColor = System.Drawing.Color.Black;
            this.LblReturnTime.Location = new System.Drawing.Point(1135, 603);
            this.LblReturnTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblReturnTime.Name = "LblReturnTime";
            this.LblReturnTime.Size = new System.Drawing.Size(136, 24);
            this.LblReturnTime.TabIndex = 61;
            this.LblReturnTime.Text = "Return Time";
            // 
            // CmbDepartTime
            // 
            this.CmbDepartTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CmbDepartTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbDepartTime.Font = new System.Drawing.Font("Lucida Sans", 20.25F);
            this.CmbDepartTime.FormattingEnabled = true;
            this.CmbDepartTime.Items.AddRange(new object[] {
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
            this.CmbDepartTime.Location = new System.Drawing.Point(774, 630);
            this.CmbDepartTime.Name = "CmbDepartTime";
            this.CmbDepartTime.Size = new System.Drawing.Size(247, 40);
            this.CmbDepartTime.TabIndex = 62;
            this.CmbDepartTime.Text = "0";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Lucida Sans", 20.25F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
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
            this.comboBox2.Location = new System.Drawing.Point(1139, 630);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(247, 40);
            this.comboBox2.TabIndex = 63;
            this.comboBox2.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(201, 402);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Airline.Properties.Resources.AirplaneBG;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Where);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1691, 220);
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
            this.Where.Location = new System.Drawing.Point(67, 70);
            this.Where.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Where.Name = "Where";
            this.Where.Size = new System.Drawing.Size(504, 37);
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
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1691, 70);
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
            this.Search.Size = new System.Drawing.Size(254, 44);
            this.Search.TabIndex = 22;
            this.Search.Text = "Search Flight";
            // 
            // SearchFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1691, 955);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.CmbDepartTime);
            this.Controls.Add(this.LblReturnTime);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.LblXTo);
            this.Controls.Add(this.LblXFrom);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LblReturnDate);
            this.Controls.Add(this.LblDepartDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPromo);
            this.Controls.Add(this.CmbInfant);
            this.Controls.Add(this.CmbChildren);
            this.Controls.Add(this.CmbAdults);
            this.Controls.Add(this.DTPReturn);
            this.Controls.Add(this.DTPDepart);
            this.Controls.Add(this.CmbLoc2);
            this.Controls.Add(this.CmbLoc1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbTrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchFlight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchFlight";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SearchFlight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChildren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInfants)).EndInit();
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
        private System.Windows.Forms.ComboBox CmbLoc2;
        private System.Windows.Forms.DateTimePicker DTPDepart;
        private System.Windows.Forms.DateTimePicker DTPReturn;
        private System.Windows.Forms.ComboBox CmbAdults;
        private System.Windows.Forms.ComboBox CmbChildren;
        private System.Windows.Forms.ComboBox CmbInfant;
        private System.Windows.Forms.TextBox txtPromo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblDepartDate;
        private System.Windows.Forms.Label LblReturnDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LblXFrom;
        private System.Windows.Forms.Label LblXTo;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label LblReturnTime;
        private System.Windows.Forms.ComboBox CmbDepartTime;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

