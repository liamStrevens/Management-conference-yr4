using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Management_conference.Logic;
using Management_conference.Gui;
namespace Management_conference.Gui
{
    public partial class SearchForm : Form
    {
        Logic.System MainSystem = new Logic.System();
        List<Conference> SearchResults = new List<Conference>();
        Conference currentCon;
        public SearchForm()
        {
            InitializeComponent();
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();
            SearchResults.Clear();
            SearchResults = MainSystem.searchConference(textBox1.Text);
            if (SearchResults.Count > 0)
            {
                listBox1.Items.Clear();
                SearchResults = SearchResults.Distinct().ToList();
                for (int i = 0; i < SearchResults.Count(); i++)
                {
                    listBox1.Items.Add(SearchResults[i].ToString());
                    
                }
            }
            else
            {
                MessageBox.Show("No Conference matches your Search");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Boolean validConf = false;
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please Choose a conference to enter");
            }
            else 
            {
                validConf = MainSystem.validateConference(SearchResults[listBox1.SelectedIndex]);
                if (validConf)
                {
                   currentCon = SearchResults[listBox1.SelectedIndex];
                   currentCon.Participant.Add(MainSystem.LoggedIn);
                   currentCon.Participant = currentCon.Participant.Distinct().ToList();
                   ConferenceForm startConference = new ConferenceForm(currentCon);
                   
                    startConference.Show();
                    
                }
                else
                {
                    MessageBox.Show("You do not have the skills to enter this conference");
                }
            }
        }
       
    }
}
