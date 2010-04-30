using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NoIdeas.Phone
{
    
    /// <summary>
    /// This is the Home Screen Form for application
    /// </summary>
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();

            //datingAdLink.BackColor = Color.Transparent;
            
            //chattingpicpanel.BackColor = ((System.Drawing.Image)(resources.GetObject("chattingpic.Image")));

            //datingAdLink.Parent = panel1;
            

            //datingAdLink.Location = New Point(0, 0);

            
            //dinnerAdLink.Parent = chattingpic;
        }
        /// <summary>
        /// Handler for the Edit profile link
        /// </summary>
        /// <param name="sender">Unused</param>
        /// <param name="e">Unused</param>
        private void linkProfile_Click(object sender, EventArgs e)
        {
            // Creating the new instance of the ProfileForm
            ProfileForm profileForm = new ProfileForm();
            // Displaying the profile form
            profileForm.Show();
        }

        private void label1_ParentChanged(object sender, EventArgs e)
        {

        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void datingAdLink_Click(object sender, EventArgs e)
        {
            //open up the dating advertisment properties page
            DateForm dateForm = new DateForm();
            dateForm.Show();
        }

        private void studyAdLink_Click(object sender, EventArgs e)
        {
            //open up the study advertisment properties page
        }

        private void dinnerAdLink_Click(object sender, EventArgs e)
        {
            //open up the dinner advertisment properties page
        }

        private void datingAdCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            //this should activate/deactivate dating ad
            
        }

        private void studyAdCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            //this should activate/deactivate study ad
        }

        private void dinnerAdCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            //this should activate/deactivate dinner ad
        }

        private void editprofilebutton_Click(object sender, EventArgs e)
        {
            // Creating the new instance of the ProfileForm
            ProfileForm profileForm = new ProfileForm();
            // Displaying the profile form
            profileForm.Show();
        }

        private void finddatebutton_Click(object sender, EventArgs e)
        {
            DateForm dateForm = new DateForm();
            dateForm.Show();
        }

        private void signinbutton_Click(object sender, EventArgs e)
        {
            bool readyToSignIn = true;

            // Checking if the user enter user name/password
            if((usernametextbox.TextLength != 0) & (passwordtextbox.TextLength != 0))
            {
                
            }
            else
            {

                readyToSignIn = false;
            }

            // We good to go 
            if (readyToSignIn)
            {
                signinbutton.Visible = false;
                editprofilebutton.Visible = true;
                finddatebutton.Visible = true;                
            }
            // Display the error message
            else
                MessageBox.Show("Please enter valid User Name/Password");
        }

              
    }
}