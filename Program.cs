using System;

namespace PartyPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Planning a party?");

            Party myParty = new Party();

            myParty.GetPartyType();
            myParty.WhereParty();
            myParty.Timeofparty();
            myParty.Whoiscoming();

            myParty.PrintInfo();

        }

    }
}
