using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Einstein
{
    public partial class DashboardControl : UserControl
    {
        public DashboardControl()
        {
            InitializeComponent();
            FormOneStudentsLabel.Text = "256";
            //All these are students with status active 
            //FormOneStudentsLabel = the number of form one students to be gotten from database
            //FormTwoStudentsLabel = the number of form two students to be gotten from database
            //FormThreeStudentsLabel = the number of form three students to be gotten from database
            //VacationStudentsLabel = the number of vacation classes students
            //PreSHSStudentsLabel = the number of PreSHS students
            //GeneralScienceLabel = the number of students offering General Science Programme
            //GeneralArtsLabel = the number of students offering General Arts Programme
            //BusinessLabel = the number of students offering Business Programme
            //HomeEconomicsLabel = the number of students offering Home Economics Programme
            //VisualArtsLabel = the number of students offering Visual Arts Programme
            //OtherProgrammesLabel = the number of students offering Other programmes other than what has been listed above

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }
    }
}
