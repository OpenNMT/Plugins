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
            this.components = new System.ComponentModel.Container();
            this.Save_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxCon = new System.Windows.Forms.GroupBox();
            this.port_txtbox = new System.Windows.Forms.TextBox();
            this.address_txtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxFeats = new System.Windows.Forms.GroupBox();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCustomer = new System.Windows.Forms.TextBox();
            this.labelClientName = new System.Windows.Forms.Label();
            this.textBoxOtherFeatures = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxCon.SuspendLayout();
            this.groupBoxFeats.SuspendLayout();
            this.SuspendLayout();
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(212, 318);
            this.Save_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(107, 28);
            this.Save_btn.TabIndex = 6;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_btn.Location = new System.Drawing.Point(345, 318);
            this.Cancel_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(107, 28);
            this.Cancel_btn.TabIndex = 7;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(443, 287);
            this.tabControl1.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBoxCon);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(435, 258);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBoxFeats);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(435, 258);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced";
            // 
            // groupBoxCon
            // 
            this.groupBoxCon.Controls.Add(this.port_txtbox);
            this.groupBoxCon.Controls.Add(this.address_txtbox);
            this.groupBoxCon.Controls.Add(this.label4);
            this.groupBoxCon.Controls.Add(this.label3);
            this.groupBoxCon.Location = new System.Drawing.Point(6, 6);
            this.groupBoxCon.Name = "groupBoxCon";
            this.groupBoxCon.Size = new System.Drawing.Size(413, 134);
            this.groupBoxCon.TabIndex = 24;
            this.groupBoxCon.TabStop = false;
            this.groupBoxCon.Text = "Connection";
            // 
            // port_txtbox
            // 
            this.port_txtbox.AccessibleName = "server_port";
            this.port_txtbox.Location = new System.Drawing.Point(118, 61);
            this.port_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.port_txtbox.Name = "port_txtbox";
            this.port_txtbox.Size = new System.Drawing.Size(113, 22);
            this.port_txtbox.TabIndex = 16;
            // 
            // address_txtbox
            // 
            this.address_txtbox.AccessibleName = "server_address";
            this.address_txtbox.Location = new System.Drawing.Point(118, 31);
            this.address_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.address_txtbox.Name = "address_txtbox";
            this.address_txtbox.Size = new System.Drawing.Size(254, 22);
            this.address_txtbox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Server Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Server Address";
            // 
            // groupBoxFeats
            // 
            this.groupBoxFeats.Controls.Add(this.textBoxOtherFeatures);
            this.groupBoxFeats.Controls.Add(this.label2);
            this.groupBoxFeats.Controls.Add(this.textBoxSubject);
            this.groupBoxFeats.Controls.Add(this.label1);
            this.groupBoxFeats.Controls.Add(this.textBoxCustomer);
            this.groupBoxFeats.Controls.Add(this.labelClientName);
            this.groupBoxFeats.Location = new System.Drawing.Point(6, 6);
            this.groupBoxFeats.Name = "groupBoxFeats";
            this.groupBoxFeats.Size = new System.Drawing.Size(413, 145);
            this.groupBoxFeats.TabIndex = 23;
            this.groupBoxFeats.TabStop = false;
            this.groupBoxFeats.Text = "Source Features";
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.AccessibleName = "server_port";
            this.textBoxSubject.Location = new System.Drawing.Point(144, 58);
            this.textBoxSubject.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(221, 22);
            this.textBoxSubject.TabIndex = 20;
            this.toolTip1.SetToolTip(this.textBoxSubject, "Warning! Only use valid values in these text boxes or the system may not be able " +
        "to translate.");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Subject";
            this.toolTip2.SetToolTip(this.label1, "Warning! Only use valid values in these text boxes or the system may not be able " +
        "to translate.");
            // 
            // textBoxCustomer
            // 
            this.textBoxCustomer.AccessibleName = "server_port";
            this.textBoxCustomer.Location = new System.Drawing.Point(144, 28);
            this.textBoxCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCustomer.Name = "textBoxCustomer";
            this.textBoxCustomer.Size = new System.Drawing.Size(221, 22);
            this.textBoxCustomer.TabIndex = 18;
            this.toolTip1.SetToolTip(this.textBoxCustomer, "Warning! Only use valid values in these text boxes or the system may not be able " +
        "to translate.");
            // 
            // labelClientName
            // 
            this.labelClientName.AutoSize = true;
            this.labelClientName.Location = new System.Drawing.Point(7, 28);
            this.labelClientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(43, 17);
            this.labelClientName.TabIndex = 19;
            this.labelClientName.Text = "Client";
            this.toolTip2.SetToolTip(this.labelClientName, "Warning! Only use valid values in these text boxes or the system may not be able " +
        "to translate.");
            // 
            // textBoxOtherFeatures
            // 
            this.textBoxOtherFeatures.AccessibleName = "features";
            this.textBoxOtherFeatures.Location = new System.Drawing.Point(144, 88);
            this.textBoxOtherFeatures.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOtherFeatures.Name = "textBoxOtherFeatures";
            this.textBoxOtherFeatures.Size = new System.Drawing.Size(221, 22);
            this.textBoxOtherFeatures.TabIndex = 23;
            this.toolTip1.SetToolTip(this.textBoxOtherFeatures, "Type the values in the correct order, separated by a semicolon (;)");
            this.textBoxOtherFeatures.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Other";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // OpenNMTConfDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 374);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.Cancel_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OpenNMTConfDialog";
            this.Text = "OpenNMT Configuration";
            this.Load += new System.EventHandler(this.OpenNMTConfDialog_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBoxCon.ResumeLayout(false);
            this.groupBoxCon.PerformLayout();
            this.groupBoxFeats.ResumeLayout(false);
            this.groupBoxFeats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBoxCon;
        private System.Windows.Forms.TextBox port_txtbox;
        private System.Windows.Forms.TextBox address_txtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBoxFeats;
        private System.Windows.Forms.TextBox textBoxOtherFeatures;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCustomer;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}