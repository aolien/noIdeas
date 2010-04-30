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
        public DateForm()
        {
            InitializeComponent();
        }

        private void DateForm_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Boolean to check if the user enter all required information
            bool readyToSave = true;

            // Checking if the user enter sex
            if (sexComboBox.SelectedIndex == -1)
            {
                lbSexError.Visible = true;
                readyToSave = false;
            }

            // Checking if the user enter min age
            try
            {
                int.Parse(ageMinComboBox.Text);
            }
            catch
            {
                lbAgeMinError.Visible = true;
                readyToSave = false;
            }

            // Checking if the user enter max age
            try
            {
                int.Parse(ageMaxComboBox.Text);
            }
            catch
            {
                lbAgeMaxError.Visible = true;
                readyToSave = false;
            }
            
            // Checking if the user enter range
            if (rangeComboBox.SelectedIndex == -1)
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

            // Checking if the user enter min/max height
            try
            {                 
                int.Parse(heightMinFtTextbox.Text);
                int.Parse(heightMinInTextBox.Text);
            }
            catch
            {
                lbHeightMinError.Visible = true;
                readyToSave = false;
            }
            try
            {
                int.Parse(heightMaxFtTextBox.Text);
                int.Parse(heightMaxInTextBox.Text);
            }
            catch
            {
                lbHeightMaxError.Visible = true;
                readyToSave = false;
            }

            // Checking if the user enter min/max weight
            try
            {
                int.Parse(weightMinTextBox.Text);
                int.Parse(weightMinTextBox.Text);
            }
            catch
            {
                lbWeightMinError.Visible = true;
                readyToSave = false;
            }
            try
            {
                int.Parse(weightMaxTextBox.Text);
                int.Parse(weightMaxTextBox.Text);
            }
            catch
            {
                lbWeightMaxError.Visible = true;
                readyToSave = false;
            }

            // Checking if the user enter race
            if (hairComboBox.SelectedIndex == -1)
            {
                lbHairError.Visible = true;
                readyToSave = false;
            }

            // We good to go 
            if (readyToSave)
            {
                MessageBox.Show("Saved Successfully");
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

      
    }
}