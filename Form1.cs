using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Einstein
{
    public partial class Form1 : Form
    {
        DashboardControl dashboardControl = new DashboardControl();
        EnrolStudentControl enrolStudentControl = new EnrolStudentControl();
        OthersControl OthersControl = new OthersControl();
        RevenueControl RevenueControl = new RevenueControl();
        TeachersControl TeachersControl = new TeachersControl();
        StudentsControl studentsControl = new StudentsControl();
        AttendanceControl attendanceControl = new AttendanceControl();
        ExpensesControl expensesControl = new ExpensesControl();

        public Form1()
        {
            InitializeComponent();


        }

        private void hideOthers(UserControl userControl)
        {
            List<UserControl> ControlList = new List<UserControl>();
            ControlList.Add(dashboardControl);
            ControlList.Add(enrolStudentControl);
            ControlList.Add(OthersControl);
            ControlList.Add(attendanceControl);
            ControlList.Add(expensesControl);
            ControlList.Add(studentsControl);
            ControlList.Add(RevenueControl);
            ControlList.Add(TeachersControl);
            for (int i = 0; i<ControlList.Count; i++)
            {
                if (userControl != ControlList[i])
                {
                    ControlList[i].Hide();
                }
                if (userControl == ControlList[i])
                {
                    WorkAreaPanel.Controls.Add(ControlList[i]);
                    ControlList[i].Location = new System.Drawing.Point(207, 38);

                    ControlList[i].TabIndex = 2;
                    ControlList[i].Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    ControlList[i].Dock = DockStyle.Fill;
                }
                
            }

        }

        private void dashboard_button_Click(object sender, EventArgs e)
        {
            
            hideOthers(dashboardControl);
            //WorkAreaPanel.Controls.Add(dashboardControl);
            //dashboardControl.Location = new System.Drawing.Point(207, 38);

            //dashboardControl.TabIndex = 2;
            //dashboardControl.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            //dashboardControl.Dock = DockStyle.Fill;            
            //dashboardControl.Show();
            //todo
            //when the dashboard button in the homepage is clicked
            dashboardControl.Show();
        }



        private void enrol_student_button_Click(object sender, EventArgs e)
        {

            hideOthers(enrolStudentControl);
            //WorkAreaPanel.Controls.Add(enrolStudentControl);
            //enrolStudentControl.Location = new System.Drawing.Point(207, 38);
            //enrolStudentControl.TabIndex = 2;
            //enrolStudentControl.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            //enrolStudentControl.Dock = DockStyle.Fill;
            enrolStudentControl.Show();
            //todo
            //when the enrol button in the homepage is clicked
        }

        private void attendance_button_Click(object sender, EventArgs e)
        {
            //todo
            //when the attendance button in the homepage is clicked
            hideOthers(attendanceControl);
            attendanceControl.Show();
        }

        private void students_button_Click(object sender, EventArgs e)
        {
            hideOthers(studentsControl);
            studentsControl.Show();
            //todo
            //when the students_button in the homepage is clicked
        }

        private void teachers_button_Click(object sender, EventArgs e)
        {
            hideOthers(TeachersControl);
            TeachersControl.Show();
            //todo
            //when the teachers button in the homepage is clicked
        }

        private void expenses_button_Click(object sender, EventArgs e)
        {
            hideOthers(expensesControl);
            expensesControl.Show();
            //todo
            //when the expenses button is clicked on the homepage
        }

        private void others_button_Click(object sender, EventArgs e)
        {
            hideOthers(OthersControl);
            OthersControl.Show();
            //todo
            //when the others button is clicked on the homepage
        }

        private void revenueButtonClick(object sender, EventArgs e)
        {
            hideOthers(RevenueControl);
            RevenueControl.Show();
        }

        private void login_button_click(object sender, EventArgs e)
        {
            //todo
            //create a user control for the log in
            //when the login button is clicked, a user control should pop up to allow the user to log in
        }

       
    }
    
}
