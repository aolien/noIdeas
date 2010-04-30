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
        MainProject.cloudWebRef.NoIdeasWebService service = new MainProject.cloudWebRef.NoIdeasWebService();
        /// <summary>
        /// Creates the form
        /// </summary>
        public ProfileForm()
        {
            InitializeComponent();
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
            // Closing the form 
            this.Close();

        }
        /// <summary>
        /// Handler for the Save button
        /// </summary>
        /// <param name="sender">Unused</param>
        /// <param name="e">Unused</param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Boolean to check if the user enter all required information
            bool readyToSave = true;
            
            Profile profile = new Profile();
            // Checking if the user enter Nick Name
            if (txtbNickName.Text == String.Empty)
            {
                lbNickError.Visible = true;
                readyToSave = false;
            }
            else
            {
                profile.NickName = txtbNickName.Text;
            }
            // Check if the user enter the Sex
            if (!rdbtnFemale.Checked && !rdbtnMale.Checked)
            {
                lbSexError.Visible = true;
                readyToSave = false;
            }
            else if (rdbtnFemale.Checked && !rdbtnMale.Checked)
            {
                //this means its a female
                profile.Sex = "f";

            }
            else if (!rdbtnFemale.Checked && rdbtnMale.Checked)
            {
                //this means its a male
                profile.Sex = "m";

            }
            else
            {
                //user is stupid and checked both boxes
            }
            // Check if the user enter the Age and if it's integer 
            try
            {
                int.Parse(txtbxAge.Text);
                profile.Age = Convert.ToInt32(txtbxAge.Text);
            }
            catch
            {
                lbAgeError.Visible = true;
                readyToSave = false;
            }
            if (raceComboBox.SelectedIndex == -1)
            {

                lbRaceError.Visible = true;

                readyToSave = false;

            }
            else
            {
                //can we just synch the index values?
                profile.Race = raceComboBox.SelectedIndex;
            }

            // Checking if the user enter height

            try
            {

                int.Parse(heightFtTextbox.Text);
                profile.Height_ft = Convert.ToInt32(heightFtTextbox.Text);

                int.Parse(heightInTextBox.Text);
                profile.Height_in = Convert.ToInt32(heightInTextBox.Text);
            }

            catch
            {

                lbHeightError.Visible = true;

                readyToSave = false;

            }
            //check to see if user entered weight
            try
            {

                int.Parse(weightTextBox.Text);
                profile.Weight = Convert.ToInt32(weightTextBox.Text);
            }

            catch
            {

                lbWeightError.Visible = true;

                readyToSave = false;

            }
            //still need to add interests
            // We good to go 
            if (readyToSave)
            {
                //call the web service to add profile to DB
                //service.UpdateProfile(profile);
                MessageBox.Show("Saved Successfully");
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

        private void lbNickError_ParentChanged(object sender, EventArgs e)
        {

        }
    }
}