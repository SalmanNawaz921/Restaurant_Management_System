namespace Restaurant_Mangement_System.Win_Forms.Cashier_Forms
{
    partial class frm_CashierSearch
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
            this.lbl_smallHeader = new System.Windows.Forms.Label();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Surprise
            // 
            this.lbl_Surprise.AutoSize = true;
            this.lbl_Surprise.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Surprise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.lbl_Surprise.Location = new System.Drawing.Point(105, 407);
            this.lbl_Surprise.Name = "lbl_Surprise";
            this.lbl_Surprise.Size = new System.Drawing.Size(85, 21);
            this.lbl_Surprise.TabIndex = 39;
            this.lbl_Surprise.Text = "Cashier Id";
            this.lbl_Surprise.Visible = false;
            // 
            // lbl_smallHeader
            // 
            this.lbl_smallHeader.AutoSize = true;
            this.lbl_smallHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_smallHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.lbl_smallHeader.Location = new System.Drawing.Point(28, 180);
            this.lbl_smallHeader.Name = "lbl_smallHeader";
            this.lbl_smallHeader.Size = new System.Drawing.Size(85, 21);
            this.lbl_smallHeader.TabIndex = 38;
            this.lbl_smallHeader.Text = "Cashier Id";
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.lbl_Search.Location = new System.Drawing.Point(47, 86);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(237, 45);
            this.lbl_Search.TabIndex = 37;
            this.lbl_Search.Text = "Search Cashier";
            // 
            // btn_Search
            // 
            this.btn_Search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Search.BackColor = System.Drawing.Color.Transparent;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.btn_Search.Location = new System.Drawing.Point(124, 301);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(88, 48);
            this.btn_Search.TabIndex = 36;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Id
            // 
            this.txt_Id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.txt_Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Id.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.txt_Id.Location = new System.Drawing.Point(32, 217);
            this.txt_Id.Multiline = true;
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(280, 46);
            this.txt_Id.TabIndex = 35;
            this.txt_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Id.TextChanged += new System.EventHandler(this.txt_Id_TextChanged);
            this.txt_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Id_KeyPress);
            // 
            // frm_CashierSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(340, 515);
            this.Controls.Add(this.lbl_Surprise);
            this.Controls.Add(this.lbl_smallHeader);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Id);
            this.Name = "frm_CashierSearch";
            this.Text = "Form_CashierSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Surprise;
        private System.Windows.Forms.Label lbl_smallHeader;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Id;
    }
}