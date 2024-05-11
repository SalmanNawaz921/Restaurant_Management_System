namespace Restaurant_Mangement_System.Win_Forms.Customer_Forms
{
    partial class frm_SortCustomers
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
            this.grid_SortedCustomers = new System.Windows.Forms.DataGridView();
            this.lbl_Edit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_SortedCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_SortedCustomers
            // 
            this.grid_SortedCustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.grid_SortedCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_SortedCustomers.Location = new System.Drawing.Point(0, 74);
            this.grid_SortedCustomers.Name = "grid_SortedCustomers";
            this.grid_SortedCustomers.Size = new System.Drawing.Size(636, 299);
            this.grid_SortedCustomers.TabIndex = 0;
            // 
            // lbl_Edit
            // 
            this.lbl_Edit.AutoSize = true;
            this.lbl_Edit.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.lbl_Edit.Location = new System.Drawing.Point(158, 9);
            this.lbl_Edit.Name = "lbl_Edit";
            this.lbl_Edit.Size = new System.Drawing.Size(334, 45);
            this.lbl_Edit.TabIndex = 42;
            this.lbl_Edit.Text = "Sorted Customer List";
            this.lbl_Edit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frm_SortCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(636, 373);
            this.Controls.Add(this.lbl_Edit);
            this.Controls.Add(this.grid_SortedCustomers);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(67)))), ((int)(((byte)(47)))));
            this.Name = "frm_SortCustomers";
            this.Text = "Form_SortCustomers";
            this.Load += new System.EventHandler(this.Form_SortCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_SortedCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_SortedCustomers;
        private System.Windows.Forms.Label lbl_Edit;
    }
}