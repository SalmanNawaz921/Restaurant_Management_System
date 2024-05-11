namespace Restaurant_Mangement_System.Win_Forms.Cashier_Forms
{
    partial class frm_CashierMenu
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
            this.grid_Products = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pB_Next = new System.Windows.Forms.PictureBox();
            this.pB_Back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Back)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_Products
            // 
            this.grid_Products.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.grid_Products.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Products.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.grid_Products.Location = new System.Drawing.Point(-3, 53);
            this.grid_Products.Name = "grid_Products";
            this.grid_Products.Size = new System.Drawing.Size(667, 324);
            this.grid_Products.TabIndex = 35;
            this.grid_Products.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Products_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.panel1.Location = new System.Drawing.Point(-3, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 37);
            this.panel1.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.label5.Location = new System.Drawing.Point(600, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 68;
            this.label5.Text = "Next";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.label1.Location = new System.Drawing.Point(29, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 67;
            this.label1.Text = "Back";
            // 
            // pB_Next
            // 
            this.pB_Next.BackColor = System.Drawing.Color.Transparent;
            this.pB_Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pB_Next.Image = global::Restaurant_Mangement_System.Properties.Resources.angle_small_right;
            this.pB_Next.Location = new System.Drawing.Point(588, 383);
            this.pB_Next.Name = "pB_Next";
            this.pB_Next.Size = new System.Drawing.Size(62, 37);
            this.pB_Next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_Next.TabIndex = 66;
            this.pB_Next.TabStop = false;
            this.pB_Next.Click += new System.EventHandler(this.pB_Next_Click);
            // 
            // pB_Back
            // 
            this.pB_Back.BackColor = System.Drawing.Color.Transparent;
            this.pB_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pB_Back.Image = global::Restaurant_Mangement_System.Properties.Resources.angle_small_left;
            this.pB_Back.Location = new System.Drawing.Point(12, 383);
            this.pB_Back.Name = "pB_Back";
            this.pB_Back.Size = new System.Drawing.Size(62, 37);
            this.pB_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_Back.TabIndex = 65;
            this.pB_Back.TabStop = false;
            this.pB_Back.Click += new System.EventHandler(this.pB_Back_Click);
            // 
            // frm_CashierMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(668, 451);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pB_Next);
            this.Controls.Add(this.pB_Back);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grid_Products);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_CashierMenu";
            this.Text = "Form_CashierMenu";
            this.Load += new System.EventHandler(this.Form_CashierMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_Products;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pB_Next;
        private System.Windows.Forms.PictureBox pB_Back;
    }
}