namespace Restaurant_Mangement_System.Win_Forms.Customer_Forms
{
    partial class frm_CustomerEdit
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
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.lbl_smallHeader = new System.Windows.Forms.Label();
            this.lbl_Edit = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.grid_NewProducts = new System.Windows.Forms.DataGridView();
            this.lbl_Order = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_Surprise = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_NewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Confirm.BackColor = System.Drawing.Color.Transparent;
            this.btn_Confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Confirm.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.btn_Confirm.Location = new System.Drawing.Point(144, 287);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(124, 53);
            this.btn_Confirm.TabIndex = 45;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.lbl_Quantity.Location = new System.Drawing.Point(462, 265);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(163, 21);
            this.lbl_Quantity.TabIndex = 44;
            this.lbl_Quantity.Text = "New Order Quantity";
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.txt_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Quantity.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.txt_Quantity.Location = new System.Drawing.Point(466, 305);
            this.txt_Quantity.Multiline = true;
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(280, 46);
            this.txt_Quantity.TabIndex = 43;
            this.txt_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Id_KeyPress);
            // 
            // lbl_smallHeader
            // 
            this.lbl_smallHeader.AutoSize = true;
            this.lbl_smallHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_smallHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.lbl_smallHeader.Location = new System.Drawing.Point(61, 159);
            this.lbl_smallHeader.Name = "lbl_smallHeader";
            this.lbl_smallHeader.Size = new System.Drawing.Size(64, 21);
            this.lbl_smallHeader.TabIndex = 42;
            this.lbl_smallHeader.Text = "New Id";
            // 
            // lbl_Edit
            // 
            this.lbl_Edit.AutoSize = true;
            this.lbl_Edit.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.lbl_Edit.Location = new System.Drawing.Point(291, 28);
            this.lbl_Edit.Name = "lbl_Edit";
            this.lbl_Edit.Size = new System.Drawing.Size(231, 45);
            this.lbl_Edit.TabIndex = 41;
            this.lbl_Edit.Text = "Edit Customer";
            // 
            // txt_Id
            // 
            this.txt_Id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.txt_Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Id.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.txt_Id.Location = new System.Drawing.Point(65, 199);
            this.txt_Id.Multiline = true;
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(280, 46);
            this.txt_Id.TabIndex = 40;
            this.txt_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Id_KeyPress);
            // 
            // grid_NewProducts
            // 
            this.grid_NewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_NewProducts.Location = new System.Drawing.Point(437, 110);
            this.grid_NewProducts.Name = "grid_NewProducts";
            this.grid_NewProducts.ReadOnly = true;
            this.grid_NewProducts.Size = new System.Drawing.Size(351, 140);
            this.grid_NewProducts.TabIndex = 46;
            // 
            // lbl_Order
            // 
            this.lbl_Order.AutoSize = true;
            this.lbl_Order.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.lbl_Order.Location = new System.Drawing.Point(539, 82);
            this.lbl_Order.Name = "lbl_Order";
            this.lbl_Order.Size = new System.Drawing.Size(146, 21);
            this.lbl_Order.TabIndex = 47;
            this.lbl_Order.Text = "Select New Order ";
            // 
            // btn_Add
            // 
            this.btn_Add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Add.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.btn_Add.Location = new System.Drawing.Point(561, 371);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(124, 53);
            this.btn_Add.TabIndex = 48;
            this.btn_Add.Text = "Add Order";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_Surprise
            // 
            this.lbl_Surprise.AutoSize = true;
            this.lbl_Surprise.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Surprise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.lbl_Surprise.Location = new System.Drawing.Point(171, 389);
            this.lbl_Surprise.Name = "lbl_Surprise";
            this.lbl_Surprise.Size = new System.Drawing.Size(64, 21);
            this.lbl_Surprise.TabIndex = 49;
            this.lbl_Surprise.Text = "New Id";
            this.lbl_Surprise.Visible = false;
            // 
            // frm_CustomerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Surprise);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_Order);
            this.Controls.Add(this.grid_NewProducts);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.lbl_smallHeader);
            this.Controls.Add(this.lbl_Edit);
            this.Controls.Add(this.txt_Id);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.Name = "frm_CustomerEdit";
            this.Text = "Form_CustomerEdit";
            this.Load += new System.EventHandler(this.frm_CustomerEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_NewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.Label lbl_smallHeader;
        private System.Windows.Forms.Label lbl_Edit;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.DataGridView grid_NewProducts;
        private System.Windows.Forms.Label lbl_Order;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_Surprise;
    }
}