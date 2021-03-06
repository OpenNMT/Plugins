﻿using System;
using System.Windows.Forms;

namespace OpenNMT
{
    
        
    public partial class OpenNMTConfDialog : Form
    {

        public OpenNMTTranslationOptions Options
        {
            get;
            set;
        }
       
        public OpenNMTConfDialog(OpenNMTTranslationOptions options, Sdl.LanguagePlatform.Core.LanguagePair[] languagePairs)
        {
            string sSourceCulture = languagePairs[0].SourceCultureName.ToLower();
            string sTargetCulture = languagePairs[0].TargetCultureName.ToLower();
            Options = options;
            InitializeComponent();

        }

        private void OpenNMTConfDialog_Load(object sender, EventArgs e)
        {

            if (Options.framework == "lua")
                this.rButtonLua.Checked = true;
            else
                this.rButtonWizard.Checked = true;

            if (Options.featurePosition == "start")
                this.rButtonFeatBeg.Checked = true;
            else if (Options.featurePosition == "end")
                this.rButtonFeatEnd.Checked = true;
            else
                this.rButtonFeatTok.Checked = true;

            this.address_txtbox.Text = Options.serverAddress;
            this.port_txtbox.Text = Options.port;
            this.textBoxCustomer.Text = Options.client;
            this.textBoxSubject.Text = Options.subject;
            this.textBoxOtherFeatures.Text = Options.otherFeatures;
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {


            if (this.rButtonLua.Checked)
                Options.framework = "lua";
            else
                Options.framework = "wizard";

            if (this.rButtonFeatBeg.Checked)
                Options.featurePosition = "start";
            else if (this.rButtonFeatEnd.Checked)
                Options.featurePosition = "end";
            else
                Options.featurePosition = "token";

            Options.serverAddress = this.address_txtbox.Text.Trim();
            Options.port = this.port_txtbox.Text.Trim();
            Options.client = this.textBoxCustomer.Text.Trim();
            Options.subject = this.textBoxSubject.Text.Trim();
            Options.otherFeatures = this.textBoxOtherFeatures.Text.Trim();
            this.DialogResult = DialogResult.OK;

        }
       
        private void Cancel_btn_Click(object sender, EventArgs e)
        {            
            this.DialogResult = DialogResult.Cancel;
        }


        //No need for this, we can do the check properly
        /* 
        private void ServerPort_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //makes sure that textBox1 is a number
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar)) e.Handled = true;
        }
        */


        private void ServerPort_label_Click(object sender, EventArgs e)
        {

        }

        private void ErrorMsgLabel_Click(object sender, EventArgs e)
        {

        }

        private void ServerUrl_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void toolTipOtherFeatures_Popup(object sender, PopupEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxFeats_Enter(object sender, EventArgs e)
        {

        }
    }
}
    