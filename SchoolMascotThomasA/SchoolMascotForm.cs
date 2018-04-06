/*
 * Created by: Thomas Aubin
 * Created on: 5 April, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #7 - School Mascot
 * This program has a menu bar with menu items that change two labels according the school, their school name and Mascot
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMascotThomasA
{
    public partial class frmSchoolMascot : Form
    {
        public frmSchoolMascot()
        {
            InitializeComponent();
        }

        private void mniImmaculata_Click(object sender, EventArgs e)
        {
            // Update School name and mascot name
            lblSchoolName.Text = "Immaculata High School";
            lblSchoolMascot.Text = "Saints";
        }

        private void mniAdrian_Click(object sender, EventArgs e)
        {
            // Update School name and mascot name
            lblSchoolName.Text = "Adrian High School";
            lblSchoolMascot.Text = "Blackhawks";
        }

        private void mniBellevueWest_Click(object sender, EventArgs e)
        {
            // Update School name and mascot name
            lblSchoolName.Text = "Bellevue West";
            lblSchoolMascot.Text = "Thunderbirds";
        }

        private void mniCloverPark_Click(object sender, EventArgs e)
        {
            // Update School name and mascot name
            lblSchoolName.Text = "Clover Park";
            lblSchoolMascot.Text = "Warriors";
        }
    }
}