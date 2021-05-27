using System;
using System.Collections.Generic;
using System.Text;

namespace PartyPlanner
{
    public class Party
    {
          

        // The Party class will manage all Properties ("states") and Methods ("behaviors")
        // related to a party. 
        // Let's practice adding Constructors, Properties, and Methods into our Party class.
        // Don't worry about calling ("running") these methods yet.

        // CONSTRUCTORS
        // Even though the default constructor exists behind the scenes for a class,
        // practice adding a default Party() constructor here:
        
        public Party()
        {

        }

        // Add a second constructor of your choosing.  Make it different than the default 
        // constructor.  
        // Add it here:
        public Party(string name, string location, string time, int numInvite)
        {
            PartyType = name;
            Address = location;            
            Time = time;
            Attendees = numInvite;
            
        }

        // PROPERTIES
        // Use getters and setters to define some Properties.  Have fun with it.
        // What Party "states" would you like to manage?
        // Be creative, but here are some ideas: Name, Date, Number of Attendees, Budget, etc.
        // Add Properties here:
        public string PartyType { get; set; }
        public string Address { get; set; }
        public string Time { get; set; }
        public int Attendees { get; set; }
        
      


        // METHODS
        // Define some Methods.  What "behaviors" would you like your Party to have?
        // What are some ways in which you want to interact with or change Party properties?
        // Have fun with it.  Here are some ideas: Print invite, Change budget, Add an attendee,
        // Show number attending, etc.
        // Add Methods here:

        public void AddAttendees()
        {
            Attendees++;

        }
        public void AddAttendees(int numbertoadd)
        {
            Attendees += numbertoadd;

        }
        public void GetPartyType()
        {
            Console.WriteLine("Tell us the type of party you want to have?");
            PartyType = Console.ReadLine();
        }


        //public void PrintInfo()
        //{
        //    Console.WriteLine("The name of your party is " + PartyType);

        //}

        public void WhereParty()
        {
            Console.WriteLine("Where is the party location?" + Address);
            Address = Console.ReadLine();
        }

        public void Timeofparty()
        {
            Console.WriteLine("What time is this party?" + Time);
            Time = Console.ReadLine();

        }

        public void Whoiscoming()
        {
            Console.WriteLine("How many people are coming?" + Attendees);
            Attendees = Convert.ToInt32(Console.ReadLine());
        }

    }
}
