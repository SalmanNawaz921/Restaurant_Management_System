namespace Restaurant_Mangement_System
{
    partial class frm_login
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
            this.lil_signUP = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_header = new System.Windows.Forms.Label();
            this.img_Header = new System.Windows.Forms.PictureBox();
            this.pB_Eye = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_Header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Eye)).BeginInit();
            this.SuspendLayout();
            // 
            // lil_signUP
            // 
            this.lil_signUP.AutoSize = true;
            this.lil_signUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lil_signUP.LinkColor = System.Drawing.Color.LimeGreen;
            this.lil_signUP.Location = new System.Drawing.Point(233, 609);
            this.lil_signUP.Name = "lil_signUP";
            this.lil_signUP.Size = new System.Drawing.Size(66, 20);
            this.lil_signUP.TabIndex = 29;
            this.lil_signUP.TabStop = true;
            this.lil_signUP.Text = "Sign Up";
            this.lil_signUP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lil_signUP_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 609);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Don\'t have an account?";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.Fuchsia;
            this.btn_login.Location = new System.Drawing.Point(105, 539);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(159, 48);
            this.btn_login.TabIndex = 27;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(65, 445);
            this.txt_pass.Multiline = true;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(261, 50);
            this.txt_pass.TabIndex = 26;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(65, 312);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(261, 50);
            this.txt_name.TabIndex = 25;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.Location = new System.Drawing.Point(68, 383);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(157, 45);
            this.lbl_pass.TabIndex = 24;
            this.lbl_pass.Text = "Password";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(68, 254);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(107, 45);
            this.lbl_name.TabIndex = 23;
            this.lbl_name.Text = "Name";
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Segoe UI", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.Location = new System.Drawing.Point(77, 158);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(235, 86);
            this.lbl_header.TabIndex = 31;
            this.lbl_header.Text = "LOGIN";
            // 
            // img_Header
            // 
            this.img_Header.BackColor = System.Drawing.Color.Transparent;
            this.img_Header.Image = global::Restaurant_Mangement_System.Properties.Resources.RMS_LOGO;
            this.img_Header.Location = new System.Drawing.Point(22, 12);
            this.img_Header.Name = "img_Header";
            this.img_Header.Size = new System.Drawing.Size(324, 151);
            this.img_Header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Header.TabIndex = 23;
            this.img_Header.TabStop = false;
            // 
            // pB_Eye
            // 
            this.pB_Eye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pB_Eye.Image = global::Restaurant_Mangement_System.Properties.Resources.hidden;
            this.pB_Eye.Location = new System.Drawing.Point(284, 455);
            this.pB_Eye.Name = "pB_Eye";
            this.pB_Eye.Size = new System.Drawing.Size(33, 29);
            this.pB_Eye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_Eye.TabIndex = 39;
            this.pB_Eye.TabStop = false;
            this.pB_Eye.Click += new System.EventHandler(this.pB_Eye_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(388, 665);
            this.Controls.Add(this.pB_Eye);
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.img_Header);
            this.Controls.Add(this.lil_signUP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_name);
            this.Name = "frm_login";
            this.Text = "Form_Login";
            ((System.ComponentModel.ISupportInitialize)(this.img_Header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Eye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lil_signUP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.PictureBox img_Header;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.PictureBox pB_Eye;
    }
}