
namespace BarcodeClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_add_barcode = new System.Windows.Forms.Button();
            this.btn_reload = new System.Windows.Forms.Button();
            this.dgv_barcodes = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_get_all = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_barcodes)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add_barcode
            // 
            this.btn_add_barcode.Location = new System.Drawing.Point(13, 13);
            this.btn_add_barcode.Name = "btn_add_barcode";
            this.btn_add_barcode.Size = new System.Drawing.Size(156, 29);
            this.btn_add_barcode.TabIndex = 1;
            this.btn_add_barcode.Text = "New Barcode";
            this.btn_add_barcode.UseVisualStyleBackColor = true;
            this.btn_add_barcode.Click += new System.EventHandler(this.btn_add_barcode_Click);
            // 
            // btn_reload
            // 
            this.btn_reload.Location = new System.Drawing.Point(549, 13);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(136, 29);
            this.btn_reload.TabIndex = 2;
            this.btn_reload.Text = "Get My Barcodes";
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // dgv_barcodes
            // 
            this.dgv_barcodes.AllowUserToAddRows = false;
            this.dgv_barcodes.AllowUserToDeleteRows = false;
            this.dgv_barcodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_barcodes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.details,
            this.code,
            this.user_id});
            this.dgv_barcodes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_barcodes.Location = new System.Drawing.Point(0, 58);
            this.dgv_barcodes.Name = "dgv_barcodes";
            this.dgv_barcodes.ReadOnly = true;
            this.dgv_barcodes.RowHeadersWidth = 51;
            this.dgv_barcodes.RowTemplate.Height = 29;
            this.dgv_barcodes.Size = new System.Drawing.Size(703, 392);
            this.dgv_barcodes.TabIndex = 3;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 75;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 150;
            // 
            // details
            // 
            this.details.HeaderText = "Details";
            this.details.MinimumWidth = 6;
            this.details.Name = "details";
            this.details.ReadOnly = true;
            this.details.Width = 300;
            // 
            // code
            // 
            this.code.HeaderText = "Code";
            this.code.MinimumWidth = 6;
            this.code.Name = "code";
            this.code.ReadOnly = true;
            this.code.Width = 125;
            // 
            // user_id
            // 
            this.user_id.HeaderText = "User ID";
            this.user_id.MinimumWidth = 6;
            this.user_id.Name = "user_id";
            this.user_id.ReadOnly = true;
            this.user_id.Visible = false;
            this.user_id.Width = 125;
            // 
            // btn_get_all
            // 
            this.btn_get_all.Location = new System.Drawing.Point(386, 13);
            this.btn_get_all.Name = "btn_get_all";
            this.btn_get_all.Size = new System.Drawing.Size(157, 29);
            this.btn_get_all.TabIndex = 4;
            this.btn_get_all.Text = "Get All Barcodes";
            this.btn_get_all.UseVisualStyleBackColor = true;
            this.btn_get_all.Click += new System.EventHandler(this.btn_get_all_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.btn_get_all);
            this.Controls.Add(this.dgv_barcodes);
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.btn_add_barcode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_barcodes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_add_barcode;
        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.DataGridView dgv_barcodes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn details;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.Button btn_get_all;
    }
}

