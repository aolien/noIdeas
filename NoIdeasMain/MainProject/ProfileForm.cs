using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NoIdeas.Phone.Lib;


namespace NoIdeas.Phone
{
    /// <summary>
    /// This is the Profile form where user can changed his personal information
    /// </summary>
    public partial class ProfileForm : Form
    {

      
        // Boolean to check if the user enter all required information
        bool readyToGo = false;
        
 
        /// <summary>
        /// Creates the form
        /// </summary>
        public ProfileForm()
        {
            InitializeComponent();
            // If the user has a profile load from the Data Base
            if (Program.doesHaveProfile)
            {
                FillOutProfilePage(Program.nickName);
            }

        }

        private void FillOutProfilePage(string nickName)
        {
            // This is our webService reference 
            MainProject.cloudWebRef.NoIdeasWebService service = new MainProject.cloudWebRef.NoIdeasWebService();
            // Get profile form DB
           Program.profile = service.GetUserProfile(nickName);
           // NoIdeas.Phone.Lib.Profile
           txtbNickName.Text = Program.profile.NickName;
           txPass.Text = Program.profile.Password;
           txtbxFN.Text = Program.profile.FirstName;
           txtbxLN.Text = Program.profile.LastName;
           txPhone.Text = Program.profile.Phone.ToString();
           if (Program.profile.Sex == "f")
               rdbtnFemale.Checked = true;
           else
               rdbtnMale.Checked = true;
           raceComboBox.Text = Program.profile.Race;
           hairComboBox.Text = Program.profile.Hair;
           cbInterest.Text = Program.profile.Interest;
           txtbxAge.Text = Program.profile.Age.ToString();
           heightCmTextbox.Text = Program.profile.Height.ToString();
           weightTextBox.Text = Program.profile.Weight.ToString();
           txtbNickName.ReadOnly = true;

        }
        
        /// <summary>
        /// Handler for loading the form
        /// </summary>
        /// <param name="sender">Unused</param>
        /// <param name="e">Unused</param>
        private void ProfileForm_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Handler for Close button Click 
        /// </summary>
        /// <param name="sender">Unused</param>
        /// <param name="e">Unused</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (readyToGo || Program.doesHaveProfile)
            {
                this.Close();
            }
            else
            {
                Program.isFirstTime = false;
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            //close the current form
            this.Hide();

        }
        /// <summary>
        /// Handler for the Save button
        /// </summary>
        /// <param name="sender">Unused</param>
        /// <param name="e">Unused</param>
        private void btnSave_Click(object sender, EventArgs e)
        {

            readyToGo = true;

            Program.profile.Online = 0;

            // Checking if the user enter Nick Name
            if (string.IsNullOrEmpty(txtbNickName.Text))
            {
                lbNickError.Visible = true;
                readyToGo = false;
            }
            else
            {
                Program.profile.NickName = txtbNickName.Text;
                Program.nickName = txtbNickName.Text;
            }
            // Check if the user enter the Sex
            if (!rdbtnFemale.Checked && !rdbtnMale.Checked)
            {
                lbSexError.Visible = true;
                readyToGo = false;
            }
            else if (rdbtnFemale.Checked && !rdbtnMale.Checked)
            {
                //this means its a female
                Program.profile.Sex = "f";
            }
            else if (!rdbtnFemale.Checked && rdbtnMale.Checked)
            {
                //this means its a male
                Program.profile.Sex = "m";
            }
            // User checked both male and female --error
            else
            {
                lbSexError.Visible = true;
            }
            // Check if the user enter the Age and if it's integer 
            try
            {
                Program.profile.Age = int.Parse(txtbxAge.Text);
            }
            catch
            {
                lbAgeError.Visible = true;
                readyToGo = false;
            }
            // Check if the user specified Race
            if (raceComboBox.SelectedIndex == -1)
            {
                lbRaceError.Visible = true;
                readyToGo = false;
            }
            else
            {
                Program.profile.Race = raceComboBox.GetItemText(raceComboBox.SelectedItem);
            }

            // Checking if the user enter height
            try
            {
                Program.profile.Height = int.Parse(heightCmTextbox.Text);
            }

            catch
            {
                lbHeightError.Visible = true;
                readyToGo = false;
            }
            //check to see if user entered weight
            try
            {
                Program.profile.Weight = int.Parse(weightTextBox.Text);
            }

            catch
            {
                lbWeightError.Visible = true;
                readyToGo = false;
            }
            // Get the First Name
            if (txtbxFN.Text != string.Empty)
                Program.profile.FirstName = txtbxFN.Text;

            // Get Last name 
            if (txtbxLN.Text != string.Empty)
                Program.profile.LastName = txtbxLN.Text;

            // Get hair type
            if (hairComboBox.SelectedIndex == -1)
            {
                lbHairError.Visible = true;
                readyToGo = false;
            }
            else
                Program.profile.Hair = hairComboBox.GetItemText(hairComboBox.SelectedItem);

            // Get interest
            if (cbInterest.SelectedIndex == -1)
            {
                lbErrorInterest.Visible = true;
                readyToGo = false;
            }
            else
                Program.profile.Interest = cbInterest.GetItemText(cbInterest.SelectedItem);

            // Get Phone
            try
            {
                Program.profile.Phone = int.Parse(txPhone.Text);
            }

            catch (Exception ex)
            {
                lbErrorPhone.Visible = true;
                readyToGo = false;
            }

            // Get Password
            if (string.IsNullOrEmpty(txPass.Text))
            {
                lbErrorPassword.Visible = true;
                readyToGo = false;
            }
            else
                Program.profile.Password = txPass.Text;


            // We good to go 
            if (readyToGo)
            {
                // This is our webService reference 
                MainProject.cloudWebRef.NoIdeasWebService service = new MainProject.cloudWebRef.NoIdeasWebService();
                if (Program.doesHaveProfile)
                    // Update Profile 
                    service.UpdateProfile(Program.profile);
                else
                    // Insert new user into the db
                    service.InsertNewUser(Program.profile);

                Program.doesHaveProfile = true;
               // MainProject.cloudWebRef.Profile -- DON'T DELETE -- WE NEED IT TO FIX VS BUG
                
                MessageBox.Show("Saved Successfully");
                // Check if we need to create the HomeForm
                if (Program.doesHaveProfile)
                    this.Close();
                // This is the first time we are going to the Home Form -- create it 
                else
                {
                    HomeForm homeform = new HomeForm(Program.nickName);
                    homeform.Show();
                    this.Close();
                }
            }
            // Display the error message

            else
            {
                MessageBox.Show("Please fill in all required fields");
            }
        }
        /// <summary>
        /// Handler 
        /// </summary>
        /// <param name="sender">Unused</param>
        /// <param name="e">Unused</param>
        private void txtbxNickName_TextChanged(object sender, EventArgs e)
        {
            lbNickError.Visible = false;
        }
        /// <summary>
        /// Handler
        /// </summary>
        /// <param name="sender">Unused</param>
        /// <param name="e">Unused</param>
        private void txtbxAge_TextChanged(object sender, EventArgs e)
        {
            lbAgeError.Visible = false;
        }
        /// <summary>
        /// Handler
        /// </summary>
        /// <param name="sender">Unused</param>
        /// <param name="e">Unused</param>
        private void rdbtMale_Checked(object sender, EventArgs e)
        {
            lbSexError.Visible = false;
        }
        /// <summary>
        /// Handler
        /// </summary>
        /// <param name="sender">Unused</param>
        /// <param name="e">Unused</param>
        private void rdbtFemale_Checked(object sender, EventArgs e)
        {
            lbSexError.Visible = false;
        }

        private void txPass_TextChanged(object sender, EventArgs e)
        {
            lbErrorPassword.Visible = false;
        }

        private void txPhone_TextChanged(object sender, EventArgs e)
        {
            lbErrorPhone.Visible = false;
        }

        private void raceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbRaceError.Visible = false;
        }

        private void hairComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbHairError.Visible = false;
        }

        private void heightCmTextbox_TextChanged(object sender, EventArgs e)
        {
            lbErrorHeight.Visible = false;
        }

        private void weightTextBox_TextChanged(object sender, EventArgs e)
        {
            lbErrorWeight.Visible = false;
        }

        private void cbInterest_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbErrorInterest.Visible = false;
        }  
    }
}