using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Management_conference.Gui;
namespace Management_conference.Logic
{
    public class Conference
    {
        //getters and setters in c#
       public int id{get; set; }
       public string name { get; set; }
       public User owner { get; set; }
       public DateTime StartDate { get; set; }
       public List<User> Participant { get; set; }
       public List<string> skills { get; set; }

        public Conference(int id, string name, User owner, DateTime StartDate, List<User> Participant, List<string> skills)
        {
            this.id = id;
            this.name = name;
            this.owner = owner;
            this.Participant = Participant;
            this.StartDate = StartDate;
            this.skills = skills;
        }
     //Checks the inputed word conference against the conference attributes
        public Boolean SearchTerms(String word)
        {
            Boolean isFound = false;
            if (this.id.ToString() == word || this.name == word)
            {
                isFound = true;
                return isFound;
            }
            if (skills.Contains(word))
            {
                isFound = true;
                return isFound;
            }
            if (owner.name == word)
            {
                isFound = true;
                return isFound;
            }
            return isFound;
        }

        public override String ToString()
        {
            string theString;
            theString = "owner = " +this.owner.name + " Conference Name = " + this.name +" Skills: ";
            for (int i = 0; i < skills.Count; i++)
            {
                theString += skills[i].ToString() + ", ";
            }
            theString += "\n";
                return theString;
        }
      
    }
}
