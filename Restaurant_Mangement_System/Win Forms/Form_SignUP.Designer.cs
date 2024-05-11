namespace Restaurant_Mangement_System
{
    partial class frm_signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_signup));
            this.lil_login = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_signUp = new System.Windows.Forms.Button();
            this.lbl_header = new System.Windows.Forms.Label();
            this.txt_role = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_role = new System.Windows.Forms.Label();
            this.pB_Eye = new System.Windows.Forms.PictureBox();
            this.img_Header = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Eye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Header)).BeginInit();
            this.SuspendLayout();
            // 
            // lil_login
            // 
            this.lil_login.AutoSize = true;
            this.lil_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lil_login.Location = new System.Drawing.Point(252, 628);
            this.lil_login.Name = "lil_login";
            this.lil_login.Size = new System.Drawing.Size(48, 20);
            this.lil_login.TabIndex = 21;
            this.lil_login.TabStop = true;
            this.lil_login.Text = "Login";
            this.lil_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lil_login_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 628);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Already have an account?";
            // 
            // btn_signUp
            // 
            this.btn_signUp.BackColor = System.Drawing.Color.Transparent;
            this.btn_signUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_signUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signUp.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_signUp.Location = new System.Drawing.Point(105, 562);
            this.btn_signUp.Name = "btn_signUp";
            this.btn_signUp.Size = new System.Drawing.Size(159, 48);
            this.btn_signUp.TabIndex = 19;
            this.btn_signUp.Text = "Sign UP";
            this.btn_signUp.UseVisualStyleBackColor = false;
            this.btn_signUp.Click += new System.EventHandler(this.btn_signUp_Click);
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Segoe UI", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.Location = new System.Drawing.Point(53, 114);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(291, 86);
            this.lbl_header.TabIndex = 12;
            this.lbl_header.Text = "SIGN UP";
            // 
            // txt_role
            // 
            this.txt_role.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.txt_role.Location = new System.Drawing.Point(58, 480);
            this.txt_role.Multiline = true;
            this.txt_role.Name = "txt_role";
            this.txt_role.Size = new System.Drawing.Size(261, 50);
            this.txt_role.TabIndex = 33;
            this.txt_role.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.txt_pass.Location = new System.Drawing.Point(58, 369);
            this.txt_pass.Multiline = true;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.ShortcutsEnabled = false;
            this.txt_pass.Size = new System.Drawing.Size(261, 50);
            this.txt_pass.TabIndex = 32;
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_name.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.txt_name.ForeColor = System.Drawing.Color.Black;
            this.txt_name.Location = new System.Drawing.Point(58, 252);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(261, 50);
            this.txt_name.TabIndex = 31;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(62, 210);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(110, 30);
            this.lbl_name.TabIndex = 35;
            this.lbl_name.Text = "Username";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.Location = new System.Drawing.Point(58, 331);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(105, 30);
            this.lbl_pass.TabIndex = 36;
            this.lbl_pass.Text = "Password";
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_role.Location = new System.Drawing.Point(62, 447);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(56, 30);
            this.lbl_role.TabIndex = 37;
            this.lbl_role.Text = "Role";
            // 
            // pB_Eye
            // 
            this.pB_Eye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pB_Eye.Image = global::Restaurant_Mangement_System.Properties.Resources.hidden;
            this.pB_Eye.Location = new System.Drawing.Point(275, 379);
            this.pB_Eye.Name = "pB_Eye";
            this.pB_Eye.Size = new System.Drawing.Size(33, 29);
            this.pB_Eye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_Eye.TabIndex = 38;
            this.pB_Eye.TabStop = false;
            this.pB_Eye.Click += new System.EventHandler(this.pB_Eye_Click);
            // 
            // img_Header
            // 
            this.img_Header.BackColor = System.Drawing.Color.Transparent;
            this.img_Header.Image = global::Restaurant_Mangement_System.Properties.Resources.RMS_LOGO;
            this.img_Header.Location = new System.Drawing.Point(-2, -1);
            this.img_Header.Name = "img_Header";
            this.img_Header.Size = new System.Drawing.Size(395, 112);
            this.img_Header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Header.TabIndex = 23;
            this.img_Header.TabStop = false;
            // 
            // frm_signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(388, 665);
            this.Controls.Add(this.pB_Eye);
            this.Controls.Add(this.img_Header);
            this.Controls.Add(this.lbl_role);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_role);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lil_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_signUp);
            this.Controls.Add(this.lbl_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_signup";
            this.Load += new System.EventHandler(this.frm_signup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pB_Eye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Header)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lil_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_signUp;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.TextBox txt_role;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.PictureBox img_Header;
        private System.Windows.Forms.PictureBox pB_Eye;
    }
}

