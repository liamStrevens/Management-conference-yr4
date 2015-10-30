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
using Management_conference;
namespace Management_conference.Gui
{
    public partial class ConferenceForm : Form
    {
        Conference thisConference;
        public ConferenceForm(Conference selectedConf)
        {
            thisConference = selectedConf;
            InitializeComponent();
            
        
        }
        
    }
}
