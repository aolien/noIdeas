//-----------------------------------------------------------------------
// <copyright file="PrivacyConsent.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// <summary>
//  This file contains the PrivacyConsent class.
// </summary>
//-----------------------------------------------------------------------
namespace NoIdeas.Phone
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Form for requesting the user's consent to use the location service.
    /// </summary>
    public partial class PrivacyConsent : Form
    {
        /// <summary>
        /// URL of privacy policy link.
        /// </summary>
        private string policyLink;

        /// <summary>
        /// Initializes a new instance of the PrivacyConsent class.
        /// </summary>
        /// <param name="appName">Name of this application.</param>
        /// <param name="linkName">Text shown for privacy policy link.</param>
        /// <param name="link">URL of privacy policy link.</param>
        public PrivacyConsent(string appName, string linkName, string link)
        {
            this.InitializeComponent();

            this.consentLabel.Text = "Notice: Some features of " + appName +
                " can access and use your location.  The application may not" +
                " work as intended if you disable location.  Each time " +
                appName + " requests your location, Microsoft will" +
                " collect information about your location to provide and" +
                " improve the location services.  The information is not" +
                " used to identify or contact you.";

            this.privacyPolicyLink.Text = linkName;
            this.policyLink = link;
        }

        /// <summary>
        /// Click handler for the privacy policy link.
        /// Calls the user's default handler for the privacy policy URL.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void PrivacyPolicyLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(this.policyLink, string.Empty);
        }

        /// <summary>
        /// Click handler for the "enabling location is ok" button.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void MenuItem1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Click handler for the "exit without enabling location" button.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void MenuItem2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }
    }
}