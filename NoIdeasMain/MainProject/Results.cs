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
    public partial class Results : Form
    {
        public Results(string username)
        {
            InitializeComponent();

            //initialize the webservice
           // MainProject.cloudWebRef.NoIdeasWebService service = new MainProject.cloudWebRef.NoIdeasWebService();

           

            //get all of the matches from the DB
            //List<MatchedResults> matches = service.FindMatches(username, lon, lat);
            
            //foreach (MatchedResults curMatch in matches)
            //{
            //    resultslistbox.Items.Add(curMatch.Name);

            //}
        }

        private void Homebutton_Click(object sender, EventArgs e)
        {
            //closing this form should just show the home form
            this.Close();
            //// Creating the new instance of the HomeForm
            //HomeForm homeForm = new HomeForm();
            //// Displaying the home form
            //homeForm.Show();
        }

        private void resultslistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //just creating this now so i can get to the text form
            MatchedResults match = new MatchedResults();
            //set up the text form
            Text textForm = new Text(match);
            textForm.Show();
            this.Close();
        }

    

        
    }
}