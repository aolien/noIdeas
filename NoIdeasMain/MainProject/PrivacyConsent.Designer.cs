//-----------------------------------------------------------------------
// <copyright file="PrivacyConsent.Designer.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// <summary>
//  This file contains the PrivacyConsent class.
// </summary>
//-----------------------------------------------------------------------
namespace NoIdeas.Phone
{
    /// <summary>
    /// Windows Form Designer related portions of the PrivacyConsent class.
    /// </summary>
    public partial class PrivacyConsent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Main menu for this form.
        /// </summary>
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// First item ("ok") on main menu.
        /// </summary>
        private System.Windows.Forms.MenuItem menuItem1;

        /// <summary>
        /// Second item ("exit") on main menu.
        /// </summary>
        private System.Windows.Forms.MenuItem menuItem2;

        /// <summary>
        /// Label for displaying the consent information.
        /// </summary>
        private System.Windows.Forms.Label consentLabel;

        /// <summary>
        /// Link to the privacy policy.
        /// </summary>
        private System.Windows.Forms.LinkLabel privacyPolicyLink;

        /// <summary>
        /// Label for displaying consent question to the user.
        /// </summary>
        private System.Windows.Forms.Label question;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.consentLabel = new System.Windows.Forms.Label();
            this.privacyPolicyLink = new System.Windows.Forms.LinkLabel();
            this.question = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.menuItem2);
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "Enable";
            this.menuItem1.Click += new System.EventHandler(this.MenuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Exit";
            this.menuItem2.Click += new System.EventHandler(this.MenuItem2_Click);
            // 
            // consentLabel
            // 
            this.consentLabel.Location = new System.Drawing.Point(4, 4);
            this.consentLabel.Name = "consentLabel";
            this.consentLabel.Size = new System.Drawing.Size(233, 142);
            this.consentLabel.Text = "Consent text goes here.";
            // 
            // privacyPolicyLink
            // 
            this.privacyPolicyLink.Location = new System.Drawing.Point(4, 150);
            this.privacyPolicyLink.Name = "privacyPolicyLink";
            this.privacyPolicyLink.Size = new System.Drawing.Size(233, 21);
            this.privacyPolicyLink.TabIndex = 1;
            this.privacyPolicyLink.Text = "Link to privacy policy goes here";
            this.privacyPolicyLink.Click += new System.EventHandler(this.PrivacyPolicyLink_Click);
            // 
            // question
            // 
            this.question.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.question.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.question.Location = new System.Drawing.Point(0, 248);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(240, 20);
            this.question.Text = "Do you want to enable location?";
            this.question.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PrivacyConsent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.ControlBox = false;
            this.Controls.Add(this.question);
            this.Controls.Add(this.privacyPolicyLink);
            this.Controls.Add(this.consentLabel);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "PrivacyConsent";
            this.Text = "Privacy Consent";
            this.ResumeLayout(false);

        }

        #endregion
    }
}