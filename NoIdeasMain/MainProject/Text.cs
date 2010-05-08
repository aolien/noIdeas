using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NoIdeas.Phone.Lib;
using Microsoft.WindowsMobile.PocketOutlook;


namespace NoIdeas.Phone
{
    public partial class Text : Form
    {
        
        private MatchedResults classMatch;

        public Text(MatchedResults match)
        {
            classMatch = match;
            InitializeComponent();
        }

        private void sendbutton_Click(object sender, EventArgs e)
        {
            //send text to classMatch.Phone
            SmsMessage msg = new SmsMessage(classMatch.Phone.ToString(),messageTB.Text);
            msg.Send();
            //after sending the text close this form
            this.Close();
        }
    }
}