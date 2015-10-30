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
namespace Management_conference
{
    public partial class Form1 : Form
    {
        Logic.System MainSystem = new Logic.System();
        
        public Form1()
        {
            InitializeComponent();
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Conference> SearchResults = new List<Conference>();
            listBox1.Items.Clear();
            SearchResults.Clear();
            SearchResults = MainSystem.searchConference(textBox1.Text);
            if (SearchResults.Count > 0)
            {
                listBox1.Items.Clear();

                for (int i = 0; i < SearchResults.Count(); i++)
                {
                    listBox1.Items.Add(SearchResults[i].toString());
                    
                }
            }
            else
            {
                MessageBox.Show("No Conference matches your Search");
            }
        }
    }
}
