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
    /// This is the Date Screen Form for application
    /// </summary>
    public partial class DateForm : Form
    {
        
        public DateForm(string userName)
        {
            InitializeComponent();
            this.Text = userName;

            // Check if the user have a Dating Profile already 
            if (Program.doesHaveDateProfile)
            {
                sexComboBox.Text = Program.dprofile.Sex;
                ageMinComboBox.Text = Program.dprofile.Min_Age.ToString();
                ageMaxComboBox.Text = Program.dprofile.Max_Age.ToString();
                txRange.Text = Program.dprofile.Range.ToString();
                raceComboBox.Text = Program.dprofile.Race;
                heightMaxCmTextBox.Text = Program.dprofile.Height_Max.ToString();
                heightMinCmTextbox.Text = Program.dprofile.Height_Min.ToString();
                weightMaxTextBox.Text = Program.dprofile.Max_Weight.ToString();
                weightMinTextBox.Text = Program.dprofile.Min_Weight.ToString();
                hairComboBox.Text = Program.dprofile.Hair;
                cbInterest.Text = Program.dprofile.Interest;
            
            }
        }

        private void DateForm_Load(object sender, EventArgs e)
        {
           
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Boolean to check if the user enter all required information
            bool readyToSave = true;
            
            // Set the User NickName
            Program.dprofile.NickName = Program.nickName;           

            // Checking if the user enter sex
            if (sexComboBox.SelectedIndex == -1)
            {
                lbSexError.Visible = true;
                readyToSave = false;
            }
            else 
               Program.dprofile.Sex = sexComboBox.GetItemText(sexComboBox.SelectedItem);
            
            // Checking if the user enter min age
            try
            {
                Program.dprofile.Min_Age = int.Parse(ageMinComboBox.Text);
            }
            catch
            {
                lbAgeMinError.Visible = true;
                readyToSave = false;
            }

            // Checking if the user enter max age
            try
            {
                Program.dprofile.Max_Age = int.Parse(ageMaxComboBox.Text);
            }
            catch
            {
                lbAgeMaxError.Visible = true;
                readyToSave = false;
            }
            
            // Checking if the user enter range
            try
            {
                Program.dprofile.Range = int.Parse(txRange.Text);
                Program.profile.Distance = int.Parse(txRange.Text);
            }
            catch
            {
                lbRangeError.Visible = true;
                readyToSave = false;
            }

            // Checking if the user enter race
            if (raceComboBox.SelectedIndex == -1)
            {
                lbRaceError.Visible = true;
                readyToSave = false;
            }
            else
                Program.dprofile.Race = raceComboBox.GetItemText(raceComboBox.SelectedItem);

            // Checking if the user enter min height
            try
            {                   
                Program.dprofile.Height_Min = int.Parse(heightMinCmTextbox.Text);
            }
            catch
            {
                lbHeightMinError.Visible = true;
                readyToSave = false;
            }
            // Checking if the user specified max Height
            try
            {
               Program.dprofile.Height_Max = int.Parse(heightMaxCmTextBox.Text);  
            }
            catch
            {
                lbHeightMaxError.Visible = true;
                readyToSave = false;
            }

            // Checking if the user enter min weight
            try
            {
              Program.dprofile.Min_Weight =  int.Parse(weightMinTextBox.Text);
            }
            catch
            {
                lbWeightMinError.Visible = true;
                readyToSave = false;
            }
            // Checking if the user specified the max weight
            try
            {
                Program.dprofile.Max_Weight = int.Parse(weightMaxTextBox.Text);
            }
            catch
            {
                lbWeightMaxError.Visible = true;
                readyToSave = false;
            }

            // Checking if the user enter hair
            if (hairComboBox.SelectedIndex == -1)
            {
                lbHairError.Visible = true;
                readyToSave = false;
            }
            else
                Program.dprofile.Hair = hairComboBox.GetItemText(hairComboBox.SelectedItem);

            // Checking if the user specified the Interest
            if (cbInterest.SelectedIndex == -1)
            {
                lbErrorInterest.Visible = true;
                readyToSave = false;
            }
            else
                Program.dprofile.Interest = cbInterest.GetItemText(cbInterest.SelectedItem); 

            // We good to go 
            if (readyToSave)
            {
                //call web service  to add dating ad to Database
                MessageBox.Show("Saved Successfully");
                // This is our webService reference 
                MainProject.cloudWebRef.NoIdeasWebService service = new MainProject.cloudWebRef.NoIdeasWebService();

                if (Program.doesHaveDateProfile)
                    // Update Dating profile
                    service.UpdateDatingProfile(Program.dprofile);
                else
                // Insert new user into the db
                service.LoadDatingProfile(Program.dprofile);
               
                // MainProject.cloudWebRef.DatingProfile -- DON'T DELETE IT -- WE NEED IT TO FIX VS BUG
                
                // Indicate that the user have a dating profile 
                Program.doesHaveDateProfile = true;
                
                //send user back to the HomePage page
               // HomeForm homeForm = new HomeForm(Program.nickName);
               // homeForm.Show();
                // Close current form
                this.Close();
            }
            // Display the error message
            else
                MessageBox.Show("Please fill in all required fields");
        }

        private void lbSexError_ParentChanged(object sender, EventArgs e)
        {
            lbSexError.Visible = false;
        }

        private void ageMinComboBox_TextChanged(object sender, EventArgs e)
        {
            lbAgeMinError.Visible = false;
        }

        private void ageMaxComboBox_TextChanged(object sender, EventArgs e)
        {
            lbAgeMaxError.Visible = false;
        }

        private void rangeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbRangeError.Visible = false;
        }

        private void raceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbRaceError.Visible = false;
        }

        private void heightMinFtTextbox_TextChanged(object sender, EventArgs e)
        {
            lbHeightMinError.Visible = false;
        }

        private void heightMinInTextBox_TextChanged(object sender, EventArgs e)
        {
            lbHeightMinError.Visible = false;
        }

        private void heightMaxFtTextBox_TextChanged(object sender, EventArgs e)
        {
            lbHeightMaxError.Visible = false;
        }

        private void heightMaxInTextBox_TextChanged(object sender, EventArgs e)
        {
            lbHeightMaxError.Visible = false;
        }

        private void weightMinTextBox_TextChanged(object sender, EventArgs e)
        {
            lbWeightMinError.Visible = false;
        }

        private void weightMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            lbWeightMaxError.Visible = false;
        }

        private void hairComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbHairError.Visible = false;
        }

        private void txRange_TextChanged(object sender, EventArgs e)
        {
            lbRangeError.Visible = false;
        }

        private void cbInterest_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbErrorInterest.Visible = false;
        }

        private void sexComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbSexError.Visible = false;
        }

        private void raceComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lbRaceError.Visible = false;
        }

        private void hairComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lbHairError.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

       

      
    }
}