namespace OpenNMT
{   
    partial class OpenNMTConfDialog
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
            this.Save_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.ErrorMsgLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.address_txtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.port_txtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(12, 251);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(119, 23);
            this.Save_btn.TabIndex = 6;
            this.Save_btn.Text = "Save Settings";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_btn.Location = new System.Drawing.Point(175, 251);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(125, 23);
            this.Cancel_btn.TabIndex = 7;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // ErrorMsgLabel
            // 
            this.ErrorMsgLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ErrorMsgLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorMsgLabel.Location = new System.Drawing.Point(15, 292);
            this.ErrorMsgLabel.Name = "ErrorMsgLabel";
            this.ErrorMsgLabel.Size = new System.Drawing.Size(309, 62);
            this.ErrorMsgLabel.TabIndex = 6;
            this.ErrorMsgLabel.Click += new System.EventHandler(this.ErrorMsgLabel_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 357);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Log Messages";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Server Address";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // address_txtbox
            // 
            this.address_txtbox.AccessibleName = "server_address";
            this.address_txtbox.Location = new System.Drawing.Point(95, 12);
            this.address_txtbox.Name = "address_txtbox";
            this.address_txtbox.Size = new System.Drawing.Size(205, 20);
            this.address_txtbox.TabIndex = 14;
            this.address_txtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Server Port";
            // 
            // port_txtbox
            // 
            this.port_txtbox.AccessibleName = "server_port";
            this.port_txtbox.Location = new System.Drawing.Point(95, 45);
            this.port_txtbox.Name = "port_txtbox";
            this.port_txtbox.Size = new System.Drawing.Size(86, 20);
            this.port_txtbox.TabIndex = 16;
            // 
            // OpenNMTConfDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 400);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.port_txtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.address_txtbox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.ErrorMsgLabel);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.Cancel_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OpenNMTConfDialog";
            this.Text = "OpenNMT Configuration";
            this.Load += new System.EventHandler(this.OpenNMTConfDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Button Save_btn;

        private System.Windows.Forms.Label ErrorMsgLabel;
        
        
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox address_txtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox port_txtbox;
    }
}