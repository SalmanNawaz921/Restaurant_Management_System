using Restaurant_Mangement_System.Properties;

namespace Restaurant_Mangement_System.Win_Forms.Cashier_Forms
{
    partial class frm_Cashier
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
            this.lbl_pnlHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Manager = new System.Windows.Forms.Label();
            this.lbl_personName = new System.Windows.Forms.Label();
            this.btn_List = new System.Windows.Forms.Button();
            this.lbl_Menu = new System.Windows.Forms.Label();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.btn_Analytics = new System.Windows.Forms.Button();
            this.pnl_User = new System.Windows.Forms.Panel();
            this.pnl_Nav = new System.Windows.Forms.Panel();
            this.btn_Customers = new System.Windows.Forms.Button();
            this.lbl_header = new System.Windows.Forms.Label();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.pnl_Info = new System.Windows.Forms.Panel();
            this.lbl_Logout = new System.Windows.Forms.Label();
            this.img_Logout = new System.Windows.Forms.PictureBox();
            this.img_Home = new System.Windows.Forms.PictureBox();
            this.img_Analytics = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.img_Customers = new System.Windows.Forms.PictureBox();
            this.img_List = new System.Windows.Forms.PictureBox();
            this.img_Header = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnl_User.SuspendLayout();
            this.pnl_Nav.SuspendLayout();
            this.pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Analytics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Customers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Header)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_pnlHeader
            // 
            this.lbl_pnlHeader.AutoSize = true;
            this.lbl_pnlHeader.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pnlHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.lbl_pnlHeader.Location = new System.Drawing.Point(21, 17);
            this.lbl_pnlHeader.Name = "lbl_pnlHeader";
            this.lbl_pnlHeader.Size = new System.Drawing.Size(184, 45);
            this.lbl_pnlHeader.TabIndex = 31;
            this.lbl_pnlHeader.Text = "Dashboard";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.lbl_pnlHeader);
            this.panel1.Location = new System.Drawing.Point(195, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 74);
            this.panel1.TabIndex = 34;
            // 
            // lbl_Manager
            // 
            this.lbl_Manager.AutoSize = true;
            this.lbl_Manager.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Manager.ForeColor = System.Drawing.Color.White;
            this.lbl_Manager.Location = new System.Drawing.Point(77, 44);
            this.lbl_Manager.Name = "lbl_Manager";
            this.lbl_Manager.Size = new System.Drawing.Size(45, 13);
            this.lbl_Manager.TabIndex = 30;
            this.lbl_Manager.Text = "Cashier";
            // 
            // lbl_personName
            // 
            this.lbl_personName.AutoSize = true;
            this.lbl_personName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_personName.ForeColor = System.Drawing.Color.White;
            this.lbl_personName.Location = new System.Drawing.Point(75, 12);
            this.lbl_personName.Name = "lbl_personName";
            this.lbl_personName.Size = new System.Drawing.Size(0, 30);
            this.lbl_personName.TabIndex = 29;
            this.lbl_personName.Visible = false;
            // 
            // btn_List
            // 
            this.btn_List.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.btn_List.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_List.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_List.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.btn_List.Location = new System.Drawing.Point(0, 178);
            this.btn_List.Name = "btn_List";
            this.btn_List.Size = new System.Drawing.Size(187, 56);
            this.btn_List.TabIndex = 0;
            this.btn_List.Text = "Menu List";
            this.btn_List.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_List.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_List.UseVisualStyleBackColor = false;
            this.btn_List.Click += new System.EventHandler(this.btn_List_Click);
            // 
            // lbl_Menu
            // 
            this.lbl_Menu.AutoSize = true;
            this.lbl_Menu.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Menu.ForeColor = System.Drawing.Color.White;
            this.lbl_Menu.Location = new System.Drawing.Point(6, 72);
            this.lbl_Menu.Name = "lbl_Menu";
            this.lbl_Menu.Size = new System.Drawing.Size(76, 30);
            this.lbl_Menu.TabIndex = 28;
            this.lbl_Menu.Text = "MENU";
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.btn_Dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Dashboard.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.btn_Dashboard.Location = new System.Drawing.Point(2, 120);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Size = new System.Drawing.Size(187, 56);
            this.btn_Dashboard.TabIndex = 31;
            this.btn_Dashboard.Text = "Dashboard";
            this.btn_Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_Dashboard.UseVisualStyleBackColor = false;
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
            // 
            // btn_Analytics
            // 
            this.btn_Analytics.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Analytics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.btn_Analytics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Analytics.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Analytics.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Analytics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.btn_Analytics.Location = new System.Drawing.Point(3, 302);
            this.btn_Analytics.Name = "btn_Analytics";
            this.btn_Analytics.Size = new System.Drawing.Size(187, 56);
            this.btn_Analytics.TabIndex = 29;
            this.btn_Analytics.Text = "Analytics";
            this.btn_Analytics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Analytics.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_Analytics.UseVisualStyleBackColor = false;
            this.btn_Analytics.Click += new System.EventHandler(this.btn_Analytics_Click);
            // 
            // pnl_User
            // 
            this.pnl_User.Controls.Add(this.lbl_Manager);
            this.pnl_User.Controls.Add(this.lbl_personName);
            this.pnl_User.Controls.Add(this.pictureBox2);
            this.pnl_User.Controls.Add(this.lbl_Menu);
            this.pnl_User.Location = new System.Drawing.Point(3, 5);
            this.pnl_User.Name = "pnl_User";
            this.pnl_User.Size = new System.Drawing.Size(184, 111);
            this.pnl_User.TabIndex = 28;
            // 
            // pnl_Nav
            // 
            this.pnl_Nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.pnl_Nav.Controls.Add(this.lbl_Logout);
            this.pnl_Nav.Controls.Add(this.img_Logout);
            this.pnl_Nav.Controls.Add(this.img_Home);
            this.pnl_Nav.Controls.Add(this.btn_Dashboard);
            this.pnl_Nav.Controls.Add(this.img_Analytics);
            this.pnl_Nav.Controls.Add(this.btn_Analytics);
            this.pnl_Nav.Controls.Add(this.pnl_User);
            this.pnl_Nav.Controls.Add(this.img_Customers);
            this.pnl_Nav.Controls.Add(this.btn_Customers);
            this.pnl_Nav.Controls.Add(this.img_List);
            this.pnl_Nav.Controls.Add(this.btn_List);
            this.pnl_Nav.Location = new System.Drawing.Point(4, 142);
            this.pnl_Nav.Name = "pnl_Nav";
            this.pnl_Nav.Size = new System.Drawing.Size(190, 528);
            this.pnl_Nav.TabIndex = 36;
            // 
            // btn_Customers
            // 
            this.btn_Customers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Customers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.btn_Customers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Customers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Customers.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.btn_Customers.Location = new System.Drawing.Point(3, 240);
            this.btn_Customers.Name = "btn_Customers";
            this.btn_Customers.Size = new System.Drawing.Size(187, 56);
            this.btn_Customers.TabIndex = 26;
            this.btn_Customers.Text = "Customers";
            this.btn_Customers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Customers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_Customers.UseVisualStyleBackColor = false;
            this.btn_Customers.Click += new System.EventHandler(this.btn_Customers_Click);
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Gill Sans MT", 39.75F);
            this.lbl_header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.lbl_header.Location = new System.Drawing.Point(233, 30);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(557, 74);
            this.lbl_header.TabIndex = 24;
            this.lbl_header.Text = "TASTE YOUR DREAMS";
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.pnl_Header.Controls.Add(this.lbl_header);
            this.pnl_Header.Controls.Add(this.img_Header);
            this.pnl_Header.Location = new System.Drawing.Point(1, 4);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(864, 137);
            this.pnl_Header.TabIndex = 35;
            // 
            // pnl_Info
            // 
            this.pnl_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.pnl_Info.Location = new System.Drawing.Point(197, 219);
            this.pnl_Info.Name = "pnl_Info";
            this.pnl_Info.Size = new System.Drawing.Size(668, 451);
            this.pnl_Info.TabIndex = 37;
            // 
            // lbl_Logout
            // 
            this.lbl_Logout.AutoSize = true;
            this.lbl_Logout.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Logout.ForeColor = System.Drawing.Color.White;
            this.lbl_Logout.Location = new System.Drawing.Point(51, 499);
            this.lbl_Logout.Name = "lbl_Logout";
            this.lbl_Logout.Size = new System.Drawing.Size(42, 13);
            this.lbl_Logout.TabIndex = 31;
            this.lbl_Logout.Text = "logout";
            // 
            // img_Logout
            // 
            this.img_Logout.BackColor = System.Drawing.Color.Transparent;
            this.img_Logout.Image = global::Restaurant_Mangement_System.Properties.Resources.logout;
            this.img_Logout.Location = new System.Drawing.Point(3, 488);
            this.img_Logout.Name = "img_Logout";
            this.img_Logout.Size = new System.Drawing.Size(52, 33);
            this.img_Logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Logout.TabIndex = 33;
            this.img_Logout.TabStop = false;
            this.img_Logout.Click += new System.EventHandler(this.img_Logout_Click);
            // 
            // img_Home
            // 
            this.img_Home.BackColor = System.Drawing.Color.Transparent;
            this.img_Home.Image = global::Restaurant_Mangement_System.Properties.Resources.home;
            this.img_Home.Location = new System.Drawing.Point(137, 130);
            this.img_Home.Name = "img_Home";
            this.img_Home.Size = new System.Drawing.Size(52, 33);
            this.img_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Home.TabIndex = 32;
            this.img_Home.TabStop = false;
            // 
            // img_Analytics
            // 
            this.img_Analytics.BackColor = System.Drawing.Color.Transparent;
            this.img_Analytics.Image = global::Restaurant_Mangement_System.Properties.Resources.data_analytics;
            this.img_Analytics.Location = new System.Drawing.Point(138, 311);
            this.img_Analytics.Name = "img_Analytics";
            this.img_Analytics.Size = new System.Drawing.Size(52, 33);
            this.img_Analytics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Analytics.TabIndex = 30;
            this.img_Analytics.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Restaurant_Mangement_System.Properties.Resources.avatar;
            this.pictureBox2.Location = new System.Drawing.Point(19, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // img_Customers
            // 
            this.img_Customers.BackColor = System.Drawing.Color.Transparent;
            this.img_Customers.Image = global::Restaurant_Mangement_System.Properties.Resources.customers;
            this.img_Customers.Location = new System.Drawing.Point(138, 249);
            this.img_Customers.Name = "img_Customers";
            this.img_Customers.Size = new System.Drawing.Size(52, 33);
            this.img_Customers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Customers.TabIndex = 27;
            this.img_Customers.TabStop = false;
            // 
            // img_List
            // 
            this.img_List.BackColor = System.Drawing.Color.Transparent;
            this.img_List.Image = global::Restaurant_Mangement_System.Properties.Resources.clipboard;
            this.img_List.Location = new System.Drawing.Point(135, 188);
            this.img_List.Name = "img_List";
            this.img_List.Size = new System.Drawing.Size(52, 33);
            this.img_List.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_List.TabIndex = 25;
            this.img_List.TabStop = false;
            this.img_List.Click += new System.EventHandler(this.img_Customers_Click);
            // 
            // img_Header
            // 
            this.img_Header.BackColor = System.Drawing.Color.Transparent;
            this.img_Header.Image = global::Restaurant_Mangement_System.Properties.Resources.RMS_LOGO;
            this.img_Header.Location = new System.Drawing.Point(12, -1);
            this.img_Header.Name = "img_Header";
            this.img_Header.Size = new System.Drawing.Size(171, 133);
            this.img_Header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Header.TabIndex = 23;
            this.img_Header.TabStop = false;
            // 
            // frm_Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(866, 675);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Nav);
            this.Controls.Add(this.pnl_Header);
            this.Controls.Add(this.pnl_Info);
            this.Name = "frm_Cashier";
            this.Text = "Form_Cashier";
            this.Load += new System.EventHandler(this.frm_Cashier_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_User.ResumeLayout(false);
            this.pnl_User.PerformLayout();
            this.pnl_Nav.ResumeLayout(false);
            this.pnl_Nav.PerformLayout();
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Analytics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Customers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Header)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox img_Header;
        private System.Windows.Forms.PictureBox img_Customers;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox img_Home;
        private System.Windows.Forms.PictureBox img_Analytics;
        private System.Windows.Forms.Label lbl_pnlHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Manager;
        private System.Windows.Forms.Label lbl_personName;
        private System.Windows.Forms.Button btn_List;
        private System.Windows.Forms.Label lbl_Menu;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.Button btn_Analytics;
        private System.Windows.Forms.Panel pnl_User;
        private System.Windows.Forms.PictureBox img_List;
        private System.Windows.Forms.Panel pnl_Nav;
        private System.Windows.Forms.Button btn_Customers;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Panel pnl_Info;
        private System.Windows.Forms.PictureBox img_Logout;
        private System.Windows.Forms.Label lbl_Logout;
    }
}

