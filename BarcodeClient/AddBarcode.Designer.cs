
namespace BarcodeClient
{
    partial class AddBarcode
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_user_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_details = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_serial_port = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(324, 351);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(94, 29);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(65, 351);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(94, 29);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Save";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "UserId";
            this.label2.Visible = false;
            // 
            // txt_user_id
            // 
            this.txt_user_id.Location = new System.Drawing.Point(185, 276);
            this.txt_user_id.Name = "txt_user_id";
            this.txt_user_id.Size = new System.Drawing.Size(233, 27);
            this.txt_user_id.TabIndex = 5;
            this.txt_user_id.Text = "5";
            this.txt_user_id.Visible = false;
            this.txt_user_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_code_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Details";
            // 
            // txt_details
            // 
            this.txt_details.Location = new System.Drawing.Point(185, 184);
            this.txt_details.Name = "txt_details";
            this.txt_details.Size = new System.Drawing.Size(233, 27);
            this.txt_details.TabIndex = 3;
            this.txt_details.Text = "tmp details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(185, 132);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(233, 27);
            this.txt_name.TabIndex = 2;
            this.txt_name.Text = "tmp name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "ID";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(185, 88);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(233, 27);
            this.txt_id.TabIndex = 1;
            // 
            // txt_code
            // 
            this.txt_code.Location = new System.Drawing.Point(185, 232);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(233, 27);
            this.txt_code.TabIndex = 4;
            this.txt_code.Text = "446677";
            this.txt_code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_code_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Code";
            // 
            // btn_serial_port
            // 
            this.btn_serial_port.Location = new System.Drawing.Point(65, 12);
            this.btn_serial_port.Name = "btn_serial_port";
            this.btn_serial_port.Size = new System.Drawing.Size(353, 29);
            this.btn_serial_port.TabIndex = 8;
            this.btn_serial_port.Text = "Read From Serial";
            this.btn_serial_port.UseVisualStyleBackColor = true;
            this.btn_serial_port.Click += new System.EventHandler(this.btn_serial_port_Click);
            // 
            // AddBarcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 425);
            this.Controls.Add(this.btn_serial_port);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.txt_user_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_details);
            this.Name = "AddBarcode";
            this.Text = "AddBarcode";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddBarcode_FormClosed);
            this.Load += new System.EventHandler(this.AddBarcode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_user_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_details;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_serial_port;
    }
}