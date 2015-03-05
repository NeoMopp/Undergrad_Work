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
    public partial class Creator : Form
    {

        public bool check = false; //Boolean to make sure that Home form is unclickable.

        public Creator()
        {
            InitializeComponent();
            Program.home.Enabled = false;
        }

        //Lets user make new Reminder.
        private void reminderButton_Click(object sender, EventArgs e)
        {
            reminderBuilder newReminder = new reminderBuilder();
            newReminder.Show();
            check = true;
            this.Close();
        }
        
        //Lets user make new Appointment.
        private void appointmentButton_Click(object sender, EventArgs e)
        {
            appointmentBuilder newAppointment = new appointmentBuilder();
            newAppointment.Show();
            check = true;    
            this.Close();
        }

        //Lets user make new extendedTask.
        private void extenedTaskButton_Click(object sender, EventArgs e)
        {
            extendedTaskBuilder newExtendedTask = new extendedTaskBuilder();
            newExtendedTask.Show();
            check = true;
            this.Close();          
        }

        //Lets user make new Note.
        private void noteButton_Click(object sender, EventArgs e)
        {
            noteBuilder newNote = new noteBuilder();
            newNote.Show();
            check = true;
            this.Close();
        }

        //Makes "Home" form clickable again, only if user preemptively closes the form.
        private void Creator_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (check == false)
            {
                Program.home.Enabled = true;
            }
        }


    }
}