namespace Restaurant_Mangement_System.Win_Forms.Customer_Forms
{
    partial class frm_CustomerAdd
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
            this.lbl_Surprise = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_Order = new System.Windows.Forms.Label();
            this.grid_NewProducts = new System.Windows.Forms.DataGridView();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.lbl_customerName = new System.Windows.Forms.Label();
            this.lbl_Add = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_customerId = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_NewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Surprise
            // 
            this.lbl_Surprise.AutoSize = true;
            this.lbl_Surprise.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Surprise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.lbl_Surprise.Location = new System.Drawing.Point(147, 416);
            this.lbl_Surprise.Name = "lbl_Surprise";
            this.lbl_Surprise.Size = new System.Drawing.Size(64, 21);
            this.lbl_Surprise.TabIndex = 59;
            this.lbl_Surprise.Text = "New Id";
            this.lbl_Surprise.Visible = false;
            // 
            // btn_Add
            // 
            this.btn_Add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Add.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.btn_Add.Location = new System.Drawing.Point(537, 370);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(124, 53);
            this.btn_Add.TabIndex = 58;
            this.btn_Add.Text = "Add Order";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_Order
            // 
            this.lbl_Order.AutoSize = true;
            this.lbl_Order.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.lbl_Order.Location = new System.Drawing.Point(515, 81);
            this.lbl_Order.Name = "lbl_Order";
            this.lbl_Order.Size = new System.Drawing.Size(107, 21);
            this.lbl_Order.TabIndex = 57;
            this.lbl_Order.Text = "Select Order ";
            // 
            // grid_NewProducts
            // 
            this.grid_NewProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_NewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_NewProducts.Location = new System.Drawing.Point(413, 109);
            this.grid_NewProducts.Name = "grid_NewProducts";
            this.grid_NewProducts.ReadOnly = true;
            this.grid_NewProducts.Size = new System.Drawing.Size(375, 146);
            this.grid_NewProducts.TabIndex = 56;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Confirm.BackColor = System.Drawing.Color.Transparent;
            this.btn_Confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Confirm.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.btn_Confirm.Location = new System.Drawing.Point(89, 346);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(173, 53);
            this.btn_Confirm.TabIndex = 55;
            this.btn_Confirm.Text = "Add Customer";
            this.btn_Confirm.UseVisualStyleBackColor = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.lbl_Quantity.Location = new System.Drawing.Point(438, 269);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(124, 21);
            this.lbl_Quantity.TabIndex = 54;
            this.lbl_Quantity.Text = "Order Quantity";
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.txt_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Quantity.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.txt_Quantity.Location = new System.Drawing.Point(442, 304);
            this.txt_Quantity.Multiline = true;
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(280, 46);
            this.txt_Quantity.TabIndex = 53;
            this.txt_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Id_KeyPress);
            // 
            // lbl_customerName
            // 
            this.lbl_customerName.AutoSize = true;
            this.lbl_customerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.lbl_customerName.Location = new System.Drawing.Point(39, 86);
            this.lbl_customerName.Name = "lbl_customerName";
            this.lbl_customerName.Size = new System.Drawing.Size(133, 21);
            this.lbl_customerName.TabIndex = 52;
            this.lbl_customerName.Text = "Customer Name";
            // 
            // lbl_Add
            // 
            this.lbl_Add.AutoSize = true;
            this.lbl_Add.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.lbl_Add.Location = new System.Drawing.Point(267, 27);
            this.lbl_Add.Name = "lbl_Add";
            this.lbl_Add.Size = new System.Drawing.Size(236, 45);
            this.lbl_Add.TabIndex = 51;
            this.lbl_Add.Text = "Add Customer";
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Name.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.txt_Name.Location = new System.Drawing.Point(43, 121);
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(280, 46);
            this.txt_Name.TabIndex = 50;
            this.txt_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Name_KeyPress);
            // 
            // lbl_customerId
            // 
            this.lbl_customerId.AutoSize = true;
            this.lbl_customerId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.lbl_customerId.Location = new System.Drawing.Point(39, 204);
            this.lbl_customerId.Name = "lbl_customerId";
            this.lbl_customerId.Size = new System.Drawing.Size(102, 21);
            this.lbl_customerId.TabIndex = 61;
            this.lbl_customerId.Text = "Customer Id";
            // 
            // txt_Id
            // 
            this.txt_Id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.txt_Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Id.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.txt_Id.Location = new System.Drawing.Point(43, 239);
            this.txt_Id.Multiline = true;
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(280, 46);
            this.txt_Id.TabIndex = 60;
            this.txt_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Id_KeyPress);
            // 
            // frm_CustomerAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_customerId);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.lbl_Surprise);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_Order);
            this.Controls.Add(this.grid_NewProducts);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.lbl_customerName);
            this.Controls.Add(this.lbl_Add);
            this.Controls.Add(this.txt_Name);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.Name = "frm_CustomerAdd";
            this.Text = "Form_CustomerAdd";
            this.Load += new System.EventHandler(this.Form_CustomerAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_NewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Surprise;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_Order;
        private System.Windows.Forms.DataGridView grid_NewProducts;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.Label lbl_customerName;
        private System.Windows.Forms.Label lbl_Add;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_customerId;
        private System.Windows.Forms.TextBox txt_Id;
    }
}