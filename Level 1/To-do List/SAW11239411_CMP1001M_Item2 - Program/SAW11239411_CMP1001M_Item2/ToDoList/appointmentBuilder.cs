using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class appointmentBuilder : Form
    {
        public bool editIt = false; //To ensure that edited objects aren't lost if changed
        Appointment editApp;        //Temp Appointment.

        public appointmentBuilder()
        {
            InitializeComponent();
            Program.home.Enabled = false;
        }

        //Custom constructor for passing in a Task to edit.
        public appointmentBuilder(Task temp)
            : this()
        {
            editIt = true;
            editApp = (Appointment) temp;
            TimeSpan ttemp = editApp.appointmentTime;           
            appointmentNameText.Text = editApp.taskName;
            appointmentDescriptionText.Text = editApp.taskDescription;
            appointmentLocationText.Text = editApp.location;
            appointmentDateTimeDate.Value = editApp.taskEndDate;
            appointmentDateTimeTime.Value = Convert.ToDateTime(ttemp);
            
        }

        //Creates object of Appointment and adds to list.
        private void appointmentDone_Click(object sender, EventArgs e)
        {
            string tn = appointmentNameText.Text;
            string td = appointmentDescriptionText.Text;
            string l = appointmentLocationText.Text;
            DateTime ted = appointmentDateTimeDate.Value.Date;
            TimeSpan at = appointmentDateTimeTime.Value.TimeOfDay;

            Task app = new Appointment(l, at, ted, tn, td);
            Program.home.add(app);
            editApp = (Appointment)app;
            editApp.timerStart();

            this.Close();
        }

        //Response to Canel button.
        private void appointmentCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //When loaded values are set for date time boxes.
        private void appointmentBuilder_Load(object sender, EventArgs e)
        {
            appointmentDateTimeTime.Value = DateTime.Now;
            appointmentDateTimeDate.Value = DateTime.Now;
        }

        //Makes the "Home" form clickable on close.
        private void appointmentBuilder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (editIt == true)
            {
                Program.home.add(editApp);
            }
            Program.home.Enabled = true;
        }
    }
}
