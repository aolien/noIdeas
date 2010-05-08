using System;
using NoIdeas.Phone.Lib;
using System.Collections;
using System.Collections.Generic;

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

            profile.NickName = "Second one";
            profile.Distance = 90;
         //  NoIdeas.Client.cloudWebRef.MatchedResults[]
            // NoIdeas.Client.cloudWebRef.DatingProfile
         
            List<MatchedResults> test = service.RunAndFindMatches(profile, null);
          //  NoIdeas.Phone.Lib.MatchedResults[]
           
           // NoIdeas.Client.cloudWebRef.MatchedResults[]
            foreach(MatchedResults match in test){
                Console.WriteLine(match.Name);
            }
            Console.WriteLine(service.GetNumberOfActiveUsers());

            //Console.WriteLine(service.Url);
           // service.Url = "http://noideaswebservice.cloudapp.net/NoIdeasWebService.asmx";
           // Console.WriteLine(service.Url);
           // Console.WriteLine(service.LoginCheck("test1", "pass"));
           // Console.WriteLine(service.GetUserProfile("kot").Interest);
            
            
            
            
            Console.ReadLine();
            
           


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
