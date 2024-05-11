namespace Restaurant_Mangement_System
{
    partial class frm_ProductEdit
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
            this.lbl_smallHeader = new System.Windows.Forms.Label();
            this.lbl_Edit = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_smallHeader
            // 
            this.lbl_smallHeader.AutoSize = true;
            this.lbl_smallHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_smallHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.lbl_smallHeader.Location = new System.Drawing.Point(28, 154);
            this.lbl_smallHeader.Name = "lbl_smallHeader";
            this.lbl_smallHeader.Size = new System.Drawing.Size(87, 21);
            this.lbl_smallHeader.TabIndex = 36;
            this.lbl_smallHeader.Text = "New Price";
            // 
            // lbl_Edit
            // 
            this.lbl_Edit.AutoSize = true;
            this.lbl_Edit.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.lbl_Edit.Location = new System.Drawing.Point(61, 68);
            this.lbl_Edit.Name = "lbl_Edit";
            this.lbl_Edit.Size = new System.Drawing.Size(206, 45);
            this.lbl_Edit.TabIndex = 35;
            this.lbl_Edit.Text = "Edit Product";
            // 
            // txt_Price
            // 
            this.txt_Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.txt_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Price.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.txt_Price.Location = new System.Drawing.Point(32, 194);
            this.txt_Price.Multiline = true;
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(280, 46);
            this.txt_Price.TabIndex = 34;
            this.txt_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Price_KeyPress_1);
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.lbl_Quantity.Location = new System.Drawing.Point(28, 290);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(116, 21);
            this.lbl_Quantity.TabIndex = 38;
            this.lbl_Quantity.Text = "New Quantity";
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.txt_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Quantity.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.txt_Quantity.Location = new System.Drawing.Point(32, 330);
            this.txt_Quantity.Multiline = true;
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(280, 46);
            this.txt_Quantity.TabIndex = 37;
            this.txt_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Price_KeyPress_1);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Confirm.BackColor = System.Drawing.Color.Transparent;
            this.btn_Confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Confirm.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.btn_Confirm.Location = new System.Drawing.Point(112, 409);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(124, 53);
            this.btn_Confirm.TabIndex = 39;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // frm_ProductEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(340, 515);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.lbl_smallHeader);
            this.Controls.Add(this.lbl_Edit);
            this.Controls.Add(this.txt_Price);
            this.Name = "frm_ProductEdit";
            this.Text = "Form_ProductEdit";
            this.Load += new System.EventHandler(this.frm_ProductEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_smallHeader;
        private System.Windows.Forms.Label lbl_Edit;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.Button btn_Confirm;
    }
}