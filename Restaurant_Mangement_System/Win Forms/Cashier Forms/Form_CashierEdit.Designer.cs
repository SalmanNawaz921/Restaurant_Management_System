namespace Restaurant_Mangement_System.Win_Forms.Cashier_Forms
{
    partial class frm_CashierEdit
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
            this.lbl_Salary = new System.Windows.Forms.Label();
            this.txt_Salary = new System.Windows.Forms.TextBox();
            this.lbl_smallHeader = new System.Windows.Forms.Label();
            this.lbl_Edit = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
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
            this.btn_Confirm.Location = new System.Drawing.Point(98, 509);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(124, 53);
            this.btn_Confirm.TabIndex = 45;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // lbl_Salary
            // 
            this.lbl_Salary.AutoSize = true;
            this.lbl_Salary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Salary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.lbl_Salary.Location = new System.Drawing.Point(28, 265);
            this.lbl_Salary.Name = "lbl_Salary";
            this.lbl_Salary.Size = new System.Drawing.Size(97, 21);
            this.lbl_Salary.TabIndex = 44;
            this.lbl_Salary.Text = "New Salary";
            // 
            // txt_Salary
            // 
            this.txt_Salary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.txt_Salary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Salary.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Salary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.txt_Salary.Location = new System.Drawing.Point(32, 305);
            this.txt_Salary.Multiline = true;
            this.txt_Salary.Name = "txt_Salary";
            this.txt_Salary.Size = new System.Drawing.Size(280, 46);
            this.txt_Salary.TabIndex = 43;
            this.txt_Salary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Salary_KeyPress);
            // 
            // lbl_smallHeader
            // 
            this.lbl_smallHeader.AutoSize = true;
            this.lbl_smallHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_smallHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.lbl_smallHeader.Location = new System.Drawing.Point(28, 146);
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
            this.lbl_Edit.Location = new System.Drawing.Point(61, 60);
            this.lbl_Edit.Name = "lbl_Edit";
            this.lbl_Edit.Size = new System.Drawing.Size(196, 45);
            this.lbl_Edit.TabIndex = 41;
            this.lbl_Edit.Text = "Edit Cashier";
            // 
            // txt_Id
            // 
            this.txt_Id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.txt_Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Id.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.txt_Id.Location = new System.Drawing.Point(32, 186);
            this.txt_Id.Multiline = true;
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(280, 46);
            this.txt_Id.TabIndex = 40;
            this.txt_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Salary_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.label1.Location = new System.Drawing.Point(28, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 47;
            this.label1.Text = "New Password";
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.txt_Password.Location = new System.Drawing.Point(32, 427);
            this.txt_Password.Multiline = true;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(280, 46);
            this.txt_Password.TabIndex = 46;
            this.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_CashierEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(340, 588);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.lbl_Salary);
            this.Controls.Add(this.txt_Salary);
            this.Controls.Add(this.lbl_smallHeader);
            this.Controls.Add(this.lbl_Edit);
            this.Controls.Add(this.txt_Id);
            this.Name = "frm_CashierEdit";
            this.Text = "Form_CashierEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Label lbl_Salary;
        private System.Windows.Forms.TextBox txt_Salary;
        private System.Windows.Forms.Label lbl_smallHeader;
        private System.Windows.Forms.Label lbl_Edit;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Password;
    }
}