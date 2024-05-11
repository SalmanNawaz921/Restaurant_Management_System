namespace Restaurant_Mangement_System.Win_Forms.Cashier_Forms
{
    partial class frm_CashierAdd
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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.txt_Salary = new System.Windows.Forms.TextBox();
            this.lbl_smallHeader = new System.Windows.Forms.Label();
            this.lbl_Add = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.lbl_Name.Location = new System.Drawing.Point(27, 131);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(116, 21);
            this.lbl_Name.TabIndex = 55;
            this.lbl_Name.Text = "Cashier Name";
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Name.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.txt_Name.Location = new System.Drawing.Point(31, 171);
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(280, 46);
            this.txt_Name.TabIndex = 54;
            this.txt_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Name_KeyPress);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Confirm.BackColor = System.Drawing.Color.Transparent;
            this.btn_Confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Confirm.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.btn_Confirm.Location = new System.Drawing.Point(95, 600);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(124, 53);
            this.btn_Confirm.TabIndex = 53;
            this.btn_Confirm.Text = "Add";
            this.btn_Confirm.UseVisualStyleBackColor = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.lbl_Quantity.Location = new System.Drawing.Point(29, 373);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(118, 21);
            this.lbl_Quantity.TabIndex = 52;
            this.lbl_Quantity.Text = "Cashier Salary";
            // 
            // txt_Salary
            // 
            this.txt_Salary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.txt_Salary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Salary.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Salary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.txt_Salary.Location = new System.Drawing.Point(33, 413);
            this.txt_Salary.Multiline = true;
            this.txt_Salary.Name = "txt_Salary";
            this.txt_Salary.Size = new System.Drawing.Size(280, 46);
            this.txt_Salary.TabIndex = 51;
            this.txt_Salary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Id_KeyPress);
            // 
            // lbl_smallHeader
            // 
            this.lbl_smallHeader.AutoSize = true;
            this.lbl_smallHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_smallHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.lbl_smallHeader.Location = new System.Drawing.Point(27, 253);
            this.lbl_smallHeader.Name = "lbl_smallHeader";
            this.lbl_smallHeader.Size = new System.Drawing.Size(85, 21);
            this.lbl_smallHeader.TabIndex = 50;
            this.lbl_smallHeader.Text = "Cashier Id";
            // 
            // lbl_Add
            // 
            this.lbl_Add.AutoSize = true;
            this.lbl_Add.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.lbl_Add.Location = new System.Drawing.Point(60, 44);
            this.lbl_Add.Name = "lbl_Add";
            this.lbl_Add.Size = new System.Drawing.Size(201, 45);
            this.lbl_Add.TabIndex = 49;
            this.lbl_Add.Text = "Add Cashier";
            // 
            // txt_Id
            // 
            this.txt_Id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.txt_Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Id.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.txt_Id.Location = new System.Drawing.Point(31, 293);
            this.txt_Id.Multiline = true;
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(280, 46);
            this.txt_Id.TabIndex = 48;
            this.txt_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Id_KeyPress);
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.lbl_Pass.Location = new System.Drawing.Point(27, 489);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(142, 21);
            this.lbl_Pass.TabIndex = 57;
            this.lbl_Pass.Text = "Cashier Password";
            // 
            // txt_Pass
            // 
            this.txt_Pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.txt_Pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Pass.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.txt_Pass.Location = new System.Drawing.Point(31, 529);
            this.txt_Pass.Multiline = true;
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(280, 46);
            this.txt_Pass.TabIndex = 56;
            this.txt_Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_CashierAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(337, 683);
            this.Controls.Add(this.lbl_Pass);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.txt_Salary);
            this.Controls.Add(this.lbl_smallHeader);
            this.Controls.Add(this.lbl_Add);
            this.Controls.Add(this.txt_Id);
            this.Name = "frm_CashierAdd";
            this.Text = "Form_CashierAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.TextBox txt_Salary;
        private System.Windows.Forms.Label lbl_smallHeader;
        private System.Windows.Forms.Label lbl_Add;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.TextBox txt_Pass;
    }
}