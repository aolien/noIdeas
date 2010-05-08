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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.Text = Program.Name;
            this.Show();
            // Display the privacy statement only once
            if (Program.isFirstTime)
            {
                // -
                // Get user's consent to use the location API.
                // -
                PrivacyConsent consentForm = new PrivacyConsent(
                    Program.Name,
                    "Privacy Statement",
                    Program.PrivacyStatementUrl);
                if (consentForm.ShowDialog() != DialogResult.OK)
                {
                    this.Exit();
                }
            }
        }
        
        
        /// <summary>
        /// New User so it will send them to the profile page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newUserButton_Click(object sender, EventArgs e)
        {
            
            //send to the Profile page
            // Creating the new instance of the ProfileForm
            ProfileForm profileForm = new ProfileForm();
                             
            // Displaying the profile form
            profileForm.Show();
            // Hide the current form
            this.Hide();


        }
        /// <summary>
        /// this will check if teh username and password are valid.
        /// If they are vaild it sends user to home form
        /// Otherwise report invaild and make user reenter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void signinbutton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            //this should be false by default but putting it here as true to test rest of app
            bool userVerified = true;

            // This is our webService reference 
            MainProject.cloudWebRef.NoIdeasWebService service =new MainProject.cloudWebRef.NoIdeasWebService();
           // check if the user specified the valid credentials
           userVerified = service.LoginCheck(usernametextbox.Text,passwordtextbox.Text);

            //if check was successful sent user to home form
            if (userVerified)
            {
                // Set true that user have an existing profile in DB
                Program.doesHaveProfile = true;
                Program.isFirstTime = false;
                // Set the user nickName
                Program.nickName = usernametextbox.Text;
                HomeForm home = new HomeForm(usernametextbox.Text);
                home.Show();
                // Hide the current form
                this.Hide();
            }
            //otherwise report invalid 
            else
            {
                Cursor.Current = Cursors.Default;
                errorTextBox.Visible = true;
            }
        }


        /// <summary>
        /// Common exit routine.
        /// </summary>
        private void Exit()
        {
            // Process all the events in all message queues.
            Application.DoEvents();

           
            // Hide the form so user doesn't see the form.
            this.Hide();

            // Dispose all the managed resources.
            this.Dispose(true);

            // Its advisable to close the form as well.
            this.Close();

            // Exit the application.
            Application.Exit();
        }
        
            
        
    }
}