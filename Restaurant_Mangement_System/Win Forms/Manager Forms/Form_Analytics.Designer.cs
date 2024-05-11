namespace Restaurant_Mangement_System.Win_Forms
{
    partial class frm_Analytics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Analytics));
            this.pnl_Analytics = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.lbl_progressBar = new System.Windows.Forms.Label();
            this.pnl_hotItems = new System.Windows.Forms.Panel();
            this.lbl_Items = new System.Windows.Forms.Label();
            this.lbl_hotItems = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_revenue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_Info = new System.Windows.Forms.Panel();
            this.lbl_ProductNo = new System.Windows.Forms.Label();
            this.lbl_CashierNo = new System.Windows.Forms.Label();
            this.v = new System.Windows.Forms.Label();
            this.lbl_Cashiers = new System.Windows.Forms.Label();
            this.lbl_info = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.img_Products = new System.Windows.Forms.PictureBox();
            this.img_Cashiers = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pB_Back = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pB_Next = new System.Windows.Forms.PictureBox();
            this.pnl_Analytics.SuspendLayout();
            this.pnl_hotItems.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pnl_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Cashiers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Next)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Analytics
            // 
            this.pnl_Analytics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.pnl_Analytics.Controls.Add(this.panel14);
            this.pnl_Analytics.Controls.Add(this.panel13);
            this.pnl_Analytics.Controls.Add(this.label23);
            this.pnl_Analytics.Controls.Add(this.label22);
            this.pnl_Analytics.Controls.Add(this.circularProgressBar1);
            this.pnl_Analytics.Controls.Add(this.lbl_progressBar);
            this.pnl_Analytics.Location = new System.Drawing.Point(16, 24);
            this.pnl_Analytics.Name = "pnl_Analytics";
            this.pnl_Analytics.Size = new System.Drawing.Size(204, 272);
            this.pnl_Analytics.TabIndex = 0;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.panel14.Location = new System.Drawing.Point(118, 224);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(12, 12);
            this.panel14.TabIndex = 37;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.panel13.Location = new System.Drawing.Point(36, 224);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(12, 12);
            this.panel13.TabIndex = 36;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.label23.Location = new System.Drawing.Point(135, 222);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(52, 17);
            this.label23.TabIndex = 34;
            this.label23.Text = "Unsold";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.label22.Location = new System.Drawing.Point(53, 222);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(36, 17);
            this.label22.TabIndex = 35;
            this.label22.Text = "Sold";
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("circularProgressBar1.AnimationFunction")));
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.75F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.White;
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(40, 59);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.circularProgressBar1.OuterMargin = -26;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.circularProgressBar1.ProgressWidth = 5;
            this.circularProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.circularProgressBar1.Size = new System.Drawing.Size(129, 136);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 33;
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(5, 8, 0, 0);
            this.circularProgressBar1.Value = 100;
            // 
            // lbl_progressBar
            // 
            this.lbl_progressBar.AutoSize = true;
            this.lbl_progressBar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.lbl_progressBar.Location = new System.Drawing.Point(18, 3);
            this.lbl_progressBar.Name = "lbl_progressBar";
            this.lbl_progressBar.Size = new System.Drawing.Size(167, 37);
            this.lbl_progressBar.TabIndex = 32;
            this.lbl_progressBar.Text = "Sale Record";
            // 
            // pnl_hotItems
            // 
            this.pnl_hotItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.pnl_hotItems.Controls.Add(this.lbl_Items);
            this.pnl_hotItems.Controls.Add(this.lbl_hotItems);
            this.pnl_hotItems.Location = new System.Drawing.Point(243, 34);
            this.pnl_hotItems.Name = "pnl_hotItems";
            this.pnl_hotItems.Size = new System.Drawing.Size(166, 193);
            this.pnl_hotItems.TabIndex = 38;
            // 
            // lbl_Items
            // 
            this.lbl_Items.AutoSize = true;
            this.lbl_Items.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Items.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.lbl_Items.Location = new System.Drawing.Point(48, 59);
            this.lbl_Items.Name = "lbl_Items";
            this.lbl_Items.Size = new System.Drawing.Size(67, 24);
            this.lbl_Items.TabIndex = 33;
            this.lbl_Items.Text = "Burger";
            // 
            // lbl_hotItems
            // 
            this.lbl_hotItems.AutoSize = true;
            this.lbl_hotItems.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hotItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.lbl_hotItems.Location = new System.Drawing.Point(9, 7);
            this.lbl_hotItems.Name = "lbl_hotItems";
            this.lbl_hotItems.Size = new System.Drawing.Size(149, 30);
            this.lbl_hotItems.TabIndex = 32;
            this.lbl_hotItems.Text = "Popular Items";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.panel6.Controls.Add(this.pictureBox3);
            this.panel6.Controls.Add(this.lbl_revenue);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(134, 333);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(217, 83);
            this.panel6.TabIndex = 39;
            // 
            // lbl_revenue
            // 
            this.lbl_revenue.AutoSize = true;
            this.lbl_revenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbl_revenue.ForeColor = System.Drawing.Color.White;
            this.lbl_revenue.Location = new System.Drawing.Point(86, 21);
            this.lbl_revenue.Name = "lbl_revenue";
            this.lbl_revenue.Size = new System.Drawing.Size(80, 22);
            this.lbl_revenue.TabIndex = 1;
            this.lbl_revenue.Text = "$ 13,034";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.label5.Location = new System.Drawing.Point(87, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Today Revenue";
            // 
            // pnl_Info
            // 
            this.pnl_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.pnl_Info.Controls.Add(this.lbl_ProductNo);
            this.pnl_Info.Controls.Add(this.lbl_CashierNo);
            this.pnl_Info.Controls.Add(this.img_Products);
            this.pnl_Info.Controls.Add(this.img_Cashiers);
            this.pnl_Info.Controls.Add(this.v);
            this.pnl_Info.Controls.Add(this.lbl_Cashiers);
            this.pnl_Info.Controls.Add(this.lbl_info);
            this.pnl_Info.Location = new System.Drawing.Point(425, 40);
            this.pnl_Info.Name = "pnl_Info";
            this.pnl_Info.Size = new System.Drawing.Size(231, 187);
            this.pnl_Info.TabIndex = 38;            // 
            // lbl_ProductNo
            // 
            this.lbl_ProductNo.AutoSize = true;
            this.lbl_ProductNo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.lbl_ProductNo.Location = new System.Drawing.Point(184, 130);
            this.lbl_ProductNo.Name = "lbl_ProductNo";
            this.lbl_ProductNo.Size = new System.Drawing.Size(34, 25);
            this.lbl_ProductNo.TabIndex = 38;
            this.lbl_ProductNo.Text = "20";
            // 
            // lbl_CashierNo
            // 
            this.lbl_CashierNo.AutoSize = true;
            this.lbl_CashierNo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CashierNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.lbl_CashierNo.Location = new System.Drawing.Point(186, 71);
            this.lbl_CashierNo.Name = "lbl_CashierNo";
            this.lbl_CashierNo.Size = new System.Drawing.Size(34, 25);
            this.lbl_CashierNo.TabIndex = 37;
            this.lbl_CashierNo.Text = "19";
            // 
            // v
            // 
            this.v.AutoSize = true;
            this.v.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.v.Location = new System.Drawing.Point(75, 130);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(92, 25);
            this.v.TabIndex = 34;
            this.v.Text = "Products";
            // 
            // lbl_Cashiers
            // 
            this.lbl_Cashiers.AutoSize = true;
            this.lbl_Cashiers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cashiers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.lbl_Cashiers.Location = new System.Drawing.Point(79, 71);
            this.lbl_Cashiers.Name = "lbl_Cashiers";
            this.lbl_Cashiers.Size = new System.Drawing.Size(84, 25);
            this.lbl_Cashiers.TabIndex = 33;
            this.lbl_Cashiers.Text = "Cashiers";
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.lbl_info.Location = new System.Drawing.Point(21, 8);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(191, 32);
            this.lbl_info.TabIndex = 32;
            this.lbl_info.Text = "Restaurant Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.label1.Location = new System.Drawing.Point(423, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "No Branches Yet";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(391, 248);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // img_Products
            // 
            this.img_Products.BackColor = System.Drawing.Color.Transparent;
            this.img_Products.Image = global::Restaurant_Mangement_System.Properties.Resources.dairy_products;
            this.img_Products.Location = new System.Drawing.Point(6, 127);
            this.img_Products.Name = "img_Products";
            this.img_Products.Size = new System.Drawing.Size(52, 33);
            this.img_Products.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Products.TabIndex = 36;
            this.img_Products.TabStop = false;
            // 
            // img_Cashiers
            // 
            this.img_Cashiers.BackColor = System.Drawing.Color.Transparent;
            this.img_Cashiers.Image = global::Restaurant_Mangement_System.Properties.Resources.employee;
            this.img_Cashiers.Location = new System.Drawing.Point(6, 65);
            this.img_Cashiers.Name = "img_Cashiers";
            this.img_Cashiers.Size = new System.Drawing.Size(48, 38);
            this.img_Cashiers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Cashiers.TabIndex = 35;
            this.img_Cashiers.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(20, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "Back";
            // 
            // pB_Back
            // 
            this.pB_Back.BackColor = System.Drawing.Color.Transparent;
            this.pB_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pB_Back.Image = global::Restaurant_Mangement_System.Properties.Resources.angle_small_left;
            this.pB_Back.Location = new System.Drawing.Point(12, 379);
            this.pB_Back.Name = "pB_Back";
            this.pB_Back.Size = new System.Drawing.Size(62, 37);
            this.pB_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_Back.TabIndex = 48;
            this.pB_Back.TabStop = false;
            this.pB_Back.Click += new System.EventHandler(this.pB_Back_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(617, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Next";
            // 
            // pB_Next
            // 
            this.pB_Next.BackColor = System.Drawing.Color.Transparent;
            this.pB_Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pB_Next.Image = global::Restaurant_Mangement_System.Properties.Resources.angle_small_right;
            this.pB_Next.Location = new System.Drawing.Point(605, 378);
            this.pB_Next.Name = "pB_Next";
            this.pB_Next.Size = new System.Drawing.Size(62, 37);
            this.pB_Next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_Next.TabIndex = 50;
            this.pB_Next.TabStop = false;
            this.pB_Next.Click += new System.EventHandler(this.pB_Next_Click);
            // 
            // frm_Analytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(668, 451);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pB_Next);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pB_Back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnl_Info);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pnl_hotItems);
            this.Controls.Add(this.pnl_Analytics);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Analytics";
            this.Text = "Form_Analytics";
            this.Load += new System.EventHandler(this.frm_Analytics_Load);
            this.pnl_Analytics.ResumeLayout(false);
            this.pnl_Analytics.PerformLayout();
            this.pnl_hotItems.ResumeLayout(false);
            this.pnl_hotItems.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.pnl_Info.ResumeLayout(false);
            this.pnl_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Cashiers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Next)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Analytics;
        private System.Windows.Forms.Label lbl_progressBar;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel pnl_hotItems;
        private System.Windows.Forms.Label lbl_hotItems;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_revenue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Items;
        private System.Windows.Forms.Panel pnl_Info;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Label v;
        private System.Windows.Forms.Label lbl_Cashiers;
        private System.Windows.Forms.PictureBox img_Products;
        private System.Windows.Forms.PictureBox img_Cashiers;
        private System.Windows.Forms.Label lbl_CashierNo;
        private System.Windows.Forms.Label lbl_ProductNo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pB_Back;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pB_Next;
    }
}