using System;
using NoIdeas.Phone.Lib;

namespace NoIdeas.Client
{
    
    // This is simulator class -- you can think of it as a phone 
    class Program
    {
        static void Main(string[] args)
        {
            // THIS IS THE VISUAL STUDIO BUG
            //After apdating the web service we need to commented out the declaration of webService Profile object
            // In order to do so -- uncomment next line , right click , go to defenition in comment the whole declaration 
            // of Profile and then declare the lib : using NoIdeas.Lib;
           // NoIdeas.Client.cloudWebRef.Profile
            
            
            // This is our webService reference 
            // using it we can call all the methods of the web Service 
            cloudWebRef.NoIdeasWebService service = new cloudWebRef.NoIdeasWebService();
            // Creating the Profile the same way we will create it on the phone from profile page
            Profile profile = new Profile();
            profile.NickName = "nickname2";
            profile.Name = "firstName1";
            profile.LastName = "lastname1";
            profile.Sex = "m";
            profile.Age = 1;
            profile.Online = 1;
            profile.Race = 1;
            profile.Height_ft = 1;
            profile.Height_in = 1;
            profile.Weight = 100;
            profile.Hair = 1;
            profile.Interest1 = 1;
            profile.Interest2 = 1;
            profile.Interest3 = 1;
            // Here we need to add the distance, latitude and longitude
            profile.Distance = 100;
            profile.Latitude = 1;
            profile.Longitude = 1;
            profile.Password = "pass";
            profile.Phone = 123456;


            DatingProfile date = new DatingProfile();
            date.Sex = "m";
            date.Race = 1;
           
            
           


            // Now we going to call UpdateProfile method of the web Service which will 
            // Checks if the user has an account; If true set online in DataBase to true 
            // and adds user to the activeUser Set; else adds user information to the DataBase and 
            // to the active user Set and return true on success and false otherwise
            
          //  Console.WriteLine( service.UpdateProfile(profile));
        //    Console.WriteLine(service.GetNumberOfActiveUsers());
           // Console.WriteLine(service.EndSession(profile));
       //     Console.WriteLine(service.GetNumberOfActiveUsers());
            Console.ReadLine();
           // NoIdeas.Client.cloudWebRef.Profile
           
        }
    }
}
