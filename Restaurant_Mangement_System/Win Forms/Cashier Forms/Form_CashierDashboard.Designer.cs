namespace Restaurant_Mangement_System.Win_Forms.Cashier_Forms
{
    partial class frm_CashierDashboard
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
            this.label29 = new System.Windows.Forms.Label();
            this.btn_SortCustomer = new System.Windows.Forms.Button();
            this.btn_AddCashier = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pB_Next = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.label29.Location = new System.Drawing.Point(32, 65);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(172, 32);
            this.label29.TabIndex = 31;
            this.label29.Text = "Quick Actions";
            // 
            // btn_SortCustomer
            // 
            this.btn_SortCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SortCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.btn_SortCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SortCustomer.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SortCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.btn_SortCustomer.Location = new System.Drawing.Point(38, 188);
            this.btn_SortCustomer.Name = "btn_SortCustomer";
            this.btn_SortCustomer.Size = new System.Drawing.Size(154, 42);
            this.btn_SortCustomer.TabIndex = 33;
            this.btn_SortCustomer.Text = "Sort Customers";
            this.btn_SortCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SortCustomer.UseVisualStyleBackColor = false;
            this.btn_SortCustomer.Click += new System.EventHandler(this.btn_SortCustomer_Click);
            // 
            // btn_AddCashier
            // 
            this.btn_AddCashier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddCashier.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
            this.btn_AddCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddCashier.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddCashier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
            this.btn_AddCashier.Location = new System.Drawing.Point(38, 120);
            this.btn_AddCashier.Name = "btn_AddCashier";
            this.btn_AddCashier.Size = new System.Drawing.Size(154, 42);
            this.btn_AddCashier.TabIndex = 35;
            this.btn_AddCashier.Text = "Add Customer";
            this.btn_AddCashier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_AddCashier.UseVisualStyleBackColor = false;
            this.btn_AddCashier.Click += new System.EventHandler(this.btn_AddCashier_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(585, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Next";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pB_Next
            // 
            this.pB_Next.BackColor = System.Drawing.Color.Transparent;
            this.pB_Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pB_Next.Image = global::Restaurant_Mangement_System.Properties.Resources.angle_small_right;
            this.pB_Next.Location = new System.Drawing.Point(573, 383);
            this.pB_Next.Name = "pB_Next";
            this.pB_Next.Size = new System.Drawing.Size(62, 37);
            this.pB_Next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_Next.TabIndex = 42;
            this.pB_Next.TabStop = false;
            this.pB_Next.Click += new System.EventHandler(this.pB_Next_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurant_Mangement_System.Properties.Resources.restaurants_img;
            this.pictureBox1.Location = new System.Drawing.Point(290, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.label1.Location = new System.Drawing.Point(56, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 70;
            this.label1.Text = "Exit";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Restaurant_Mangement_System.Properties.Resources.switch__1_;
            this.pictureBox2.Location = new System.Drawing.Point(38, 383);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 69;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // frm_CashierDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(636, 456);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pB_Next);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.btn_SortCustomer);
            this.Controls.Add(this.btn_AddCashier);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_CashierDashboard";
            this.Text = "Form_CashierDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pB_Next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button btn_SortCustomer;
        private System.Windows.Forms.Button btn_AddCashier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pB_Next;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}