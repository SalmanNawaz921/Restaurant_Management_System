namespace Restaurant_Mangement_System.Win_Forms
{
    partial class frm_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Dashboard));
            this.label29 = new System.Windows.Forms.Label();
            this.btn_FindCashier = new System.Windows.Forms.Button();
            this.btn_AddItem = new System.Windows.Forms.Button();
            this.btn_AddCashier = new System.Windows.Forms.Button();
            this.btn_UpdateStock = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pB_Next = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.label29.Location = new System.Drawing.Point(32, 57);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(172, 32);
            this.label29.TabIndex = 21;
            this.label29.Text = "Quick Actions";
            // 
            // btn_FindCashier
            // 
            this.btn_FindCashier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_FindCashier.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.btn_FindCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FindCashier.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FindCashier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.btn_FindCashier.Location = new System.Drawing.Point(38, 242);
            this.btn_FindCashier.Name = "btn_FindCashier";
            this.btn_FindCashier.Size = new System.Drawing.Size(154, 42);
            this.btn_FindCashier.TabIndex = 23;
            this.btn_FindCashier.Text = "Find Cashier";
            this.btn_FindCashier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_FindCashier.UseVisualStyleBackColor = false;
            this.btn_FindCashier.Click += new System.EventHandler(this.btn_EditCashier_Click);
            // 
            // btn_AddItem
            // 
            this.btn_AddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.btn_AddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddItem.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.btn_AddItem.Location = new System.Drawing.Point(38, 182);
            this.btn_AddItem.Name = "btn_AddItem";
            this.btn_AddItem.Size = new System.Drawing.Size(154, 42);
            this.btn_AddItem.TabIndex = 24;
            this.btn_AddItem.Text = "New Product";
            this.btn_AddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_AddItem.UseVisualStyleBackColor = false;
            this.btn_AddItem.Click += new System.EventHandler(this.btn_AddItem_Click);
            // 
            // btn_AddCashier
            // 
            this.btn_AddCashier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddCashier.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
            this.btn_AddCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddCashier.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddCashier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
            this.btn_AddCashier.Location = new System.Drawing.Point(38, 112);
            this.btn_AddCashier.Name = "btn_AddCashier";
            this.btn_AddCashier.Size = new System.Drawing.Size(154, 42);
            this.btn_AddCashier.TabIndex = 25;
            this.btn_AddCashier.Text = "Add Cashier";
            this.btn_AddCashier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_AddCashier.UseVisualStyleBackColor = false;
            this.btn_AddCashier.Click += new System.EventHandler(this.btn_FireCashier_Click);
            // 
            // btn_UpdateStock
            // 
            this.btn_UpdateStock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_UpdateStock.BackColor = System.Drawing.Color.Transparent;
            this.btn_UpdateStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UpdateStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateStock.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_UpdateStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_UpdateStock.Location = new System.Drawing.Point(38, 301);
            this.btn_UpdateStock.Name = "btn_UpdateStock";
            this.btn_UpdateStock.Size = new System.Drawing.Size(154, 42);
            this.btn_UpdateStock.TabIndex = 30;
            this.btn_UpdateStock.Text = "Search Product";
            this.btn_UpdateStock.UseVisualStyleBackColor = false;
            this.btn_UpdateStock.Click += new System.EventHandler(this.btn_UpdateStock_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.label5.Location = new System.Drawing.Point(588, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 66;
            this.label5.Text = "Next";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.label1.Location = new System.Drawing.Point(35, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 68;
            this.label1.Text = "Exit";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Restaurant_Mangement_System.Properties.Resources.switch__1_;
            this.pictureBox2.Location = new System.Drawing.Point(17, 385);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 67;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pB_Next
            // 
            this.pB_Next.BackColor = System.Drawing.Color.Transparent;
            this.pB_Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pB_Next.Image = global::Restaurant_Mangement_System.Properties.Resources.angle_small_right;
            this.pB_Next.Location = new System.Drawing.Point(578, 385);
            this.pB_Next.Name = "pB_Next";
            this.pB_Next.Size = new System.Drawing.Size(62, 37);
            this.pB_Next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_Next.TabIndex = 65;
            this.pB_Next.TabStop = false;
            this.pB_Next.Click += new System.EventHandler(this.pB_Next_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(295, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(652, 439);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pB_Next);
            this.Controls.Add(this.btn_UpdateStock);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.btn_FindCashier);
            this.Controls.Add(this.btn_AddItem);
            this.Controls.Add(this.btn_AddCashier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Dashboard";
            this.Text = "Form_Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button btn_FindCashier;
        private System.Windows.Forms.Button btn_AddItem;
        private System.Windows.Forms.Button btn_AddCashier;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_UpdateStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pB_Next;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}