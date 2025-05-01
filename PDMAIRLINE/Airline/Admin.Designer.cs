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
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.tabDepartDate = new System.Windows.Forms.TabPage();
            this.tabReturnDate = new System.Windows.Forms.TabPage();
            this.tabDepartTime = new System.Windows.Forms.TabPage();
            this.tabReturnTime = new System.Windows.Forms.TabPage();
            this.tabPromoCode = new System.Windows.Forms.TabPage();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.DataGridUsers = new System.Windows.Forms.DataGridView();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.TabAdmin.SuspendLayout();
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
            this.TabAdmin.Controls.Add(this.tabDashboard);
            this.TabAdmin.Controls.Add(this.tabDepartDate);
            this.TabAdmin.Controls.Add(this.tabReturnDate);
            this.TabAdmin.Controls.Add(this.tabDepartTime);
            this.TabAdmin.Controls.Add(this.tabReturnTime);
            this.TabAdmin.Controls.Add(this.tabPromoCode);
            this.TabAdmin.Controls.Add(this.tabUsers);
            this.TabAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabAdmin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.TabAdmin.Location = new System.Drawing.Point(0, 290);
            this.TabAdmin.Name = "TabAdmin";
            this.TabAdmin.SelectedIndex = 0;
            this.TabAdmin.Size = new System.Drawing.Size(1440, 810);
            this.TabAdmin.TabIndex = 27;
            // 
            // tabDashboard
            // 
            this.tabDashboard.BackgroundImage = global::Airline.Properties.Resources.PanelHeaderBg;
            this.tabDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabDashboard.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.tabDashboard.Location = new System.Drawing.Point(4, 34);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabDashboard.Size = new System.Drawing.Size(1432, 772);
            this.tabDashboard.TabIndex = 0;
            this.tabDashboard.Text = "Dashboard";
            this.tabDashboard.UseVisualStyleBackColor = true;
            // 
            // tabDepartDate
            // 
            this.tabDepartDate.BackgroundImage = global::Airline.Properties.Resources.PanelHeaderBg;
            this.tabDepartDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabDepartDate.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.tabDepartDate.Location = new System.Drawing.Point(4, 34);
            this.tabDepartDate.Name = "tabDepartDate";
            this.tabDepartDate.Padding = new System.Windows.Forms.Padding(3);
            this.tabDepartDate.Size = new System.Drawing.Size(1432, 772);
            this.tabDepartDate.TabIndex = 1;
            this.tabDepartDate.Text = "Depart Date";
            this.tabDepartDate.UseVisualStyleBackColor = true;
            // 
            // tabReturnDate
            // 
            this.tabReturnDate.BackgroundImage = global::Airline.Properties.Resources.PanelHeaderBg;
            this.tabReturnDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabReturnDate.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.tabReturnDate.Location = new System.Drawing.Point(4, 34);
            this.tabReturnDate.Name = "tabReturnDate";
            this.tabReturnDate.Size = new System.Drawing.Size(1432, 772);
            this.tabReturnDate.TabIndex = 2;
            this.tabReturnDate.Text = "Return Date";
            this.tabReturnDate.UseVisualStyleBackColor = true;
            // 
            // tabDepartTime
            // 
            this.tabDepartTime.BackgroundImage = global::Airline.Properties.Resources.PanelHeaderBg;
            this.tabDepartTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabDepartTime.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.tabDepartTime.Location = new System.Drawing.Point(4, 34);
            this.tabDepartTime.Name = "tabDepartTime";
            this.tabDepartTime.Size = new System.Drawing.Size(1432, 772);
            this.tabDepartTime.TabIndex = 3;
            this.tabDepartTime.Text = "Depart Time";
            this.tabDepartTime.UseVisualStyleBackColor = true;
            // 
            // tabReturnTime
            // 
            this.tabReturnTime.BackgroundImage = global::Airline.Properties.Resources.PanelHeaderBg;
            this.tabReturnTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabReturnTime.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.tabReturnTime.Location = new System.Drawing.Point(4, 34);
            this.tabReturnTime.Name = "tabReturnTime";
            this.tabReturnTime.Size = new System.Drawing.Size(1432, 772);
            this.tabReturnTime.TabIndex = 4;
            this.tabReturnTime.Text = "Return Time";
            this.tabReturnTime.UseVisualStyleBackColor = true;
            // 
            // tabPromoCode
            // 
            this.tabPromoCode.BackgroundImage = global::Airline.Properties.Resources.PanelHeaderBg;
            this.tabPromoCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPromoCode.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.tabPromoCode.Location = new System.Drawing.Point(4, 34);
            this.tabPromoCode.Name = "tabPromoCode";
            this.tabPromoCode.Size = new System.Drawing.Size(1432, 772);
            this.tabPromoCode.TabIndex = 5;
            this.tabPromoCode.Text = "Promo Code";
            this.tabPromoCode.UseVisualStyleBackColor = true;
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
            this.email,
            this.role,
            this.created_at});
            this.DataGridUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridUsers.Location = new System.Drawing.Point(0, 0);
            this.DataGridUsers.Name = "DataGridUsers";
            this.DataGridUsers.Size = new System.Drawing.Size(1432, 772);
            this.DataGridUsers.TabIndex = 0;
            this.DataGridUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // user_id
            // 
            this.user_id.HeaderText = "UserID";
            this.user_id.Name = "user_id";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
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
        private System.Windows.Forms.TabPage tabDashboard;
        private System.Windows.Forms.TabPage tabDepartDate;
        private System.Windows.Forms.TabPage tabReturnDate;
        private System.Windows.Forms.TabPage tabDepartTime;
        private System.Windows.Forms.TabPage tabReturnTime;
        private System.Windows.Forms.TabPage tabPromoCode;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.DataGridView DataGridUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at;
    }
}