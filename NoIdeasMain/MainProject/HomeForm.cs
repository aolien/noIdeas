using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.LiveLocationWrapper;
using System.Threading;

namespace NoIdeas.Phone
{
    
    /// <summary>
    /// This is the Home Screen Form for application
    /// </summary>
    public partial class HomeForm : Form
    {
        /// <summary>
        /// An instance of the location wrapper class.
        /// </summary>
        private LocationWrapper locationWrapper;

        public HomeForm(string username)
        {
            InitializeComponent();
            this.Text = username;

            // Firts we need to get GPS coordinates 
            
            // Prepare the location API.
            this.locationWrapper = LocationWrapper.GetInstance();
            this.locationWrapper.ApplicationGuid = Program.ApplicationId;

            // Allow 5 seconds to generate each location fix.
            this.locationWrapper.AllowedTime = TimeSpan.FromSeconds(5);

            // Location fixes will be at least 1 second apart.
            this.locationWrapper.Interval = TimeSpan.FromSeconds(1);

            this.locationWrapper.LocationUpdated += new LocationUpdatedEventHandler(this.OnLocationUpdated);
            // Start it 
            this.locationWrapper.StartUpdating();


            ThreadStart start = new ThreadStart(this.UpdateGPSCoordinates);
            Thread gpsThread = new Thread(start);
            gpsThread.Start();

            Cursor.Current = Cursors.Default;

        }


        private void UpdateGPSCoordinates()
        {
           
            // This is our webService reference 
            MainProject.cloudWebRef.NoIdeasWebService service = new MainProject.cloudWebRef.NoIdeasWebService();
            
            while (true)
            {
            //txbTestThread.Text = "It's been " + count.ToString() + " so far";
                service.UpdateDatingProfile(Program.dprofile);
                Thread.Sleep(30000);
                Program.dprofile.Max_Weight++;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editprofilebutton_Click(object sender, EventArgs e)
        {
            
            // Creating the new instance of the ProfileForm
            ProfileForm profileForm = new ProfileForm();
            // Displaying the profile form
            profileForm.Show();
        }

       
       
        /// <summary>
        /// This is where users request to see there matches
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetMatches_Click(object sender, EventArgs e)
        {

           
            // Call the WebService method here 
            
            //send user to the results form
            Results resultsForm = new Results(Program.nickName);
            resultsForm.Show();

        }

        /// <summary>
        /// Delegate for asynchronous location updates posted to the UI thread.
        /// </summary>
        /// <param name="geoLocation">The updated location</param>
        private delegate void UpdateLocationDelegate(GeoLocation geoLocation);

        /// <summary>
        /// Event handler for location update events.
        /// </summary>
        /// <param name="sender">Object sending this event</param>
        /// <param name="args">Event arguments</param>
        private void OnLocationUpdated(object sender, LocationEventArgs args)
        {
            this.Invoke(
                new UpdateLocationDelegate(this.UpdateLocation),
                new object[] { args.GeoLocation });
        }

        /// <summary>
        /// Set Latitude and Longitude to the User Profile
        /// </summary>
        /// <param name="geoLocation">The updated location</param>
        private void UpdateLocation(GeoLocation geoLocation)
        {
            Program.profile.Latitude = geoLocation.Latitude;
            Program.profile.Longitude = geoLocation.Longitude;

        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createAdbutton_Click(object sender, EventArgs e)
        {
           
            DateForm dateForm = new DateForm(Program.nickName);
            dateForm.Show();
        }
        /// <summary>
        /// Exit the App - deletes the Dating Profile from the DataBase, flips the online bit in userInfo table 
        /// in DataBase and deleted the user from the active user HashSet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btExitApp_Click(object sender, EventArgs e)
        {

        }

              
    }
}