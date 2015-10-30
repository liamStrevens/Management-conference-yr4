using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_conference.Logic
{
    class Conference
    {
        int id;
        string name;
        User owner;
        DateTime StartDate;
        List<User> Participant;
        List<string> skills;
        public Conference(int id, string name, User owner, DateTime StartDate, List<User> Participant, List<string> skills)
        {
            this.id = id;
            this.name = name;
            this.owner = owner;
            this.Participant = Participant;
            this.StartDate = StartDate;
            this.skills = skills;

        }
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
            if (owner.getName() == word)
            {
                isFound = true;
                return isFound;
            }
            return isFound;
        }
        public String toString(){
            string theString;
            theString = "owner = " +this.owner.getName() + " Conference Name = " + this.name +" Skills: ";
            for (int i = 0; i < skills.Count; i++)
            {
                theString += skills[i].ToString() + ", ";
            }
            theString += "\n";
                return theString;
        
        

        }
    }
}
