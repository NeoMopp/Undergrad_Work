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
    public partial class reminderBuilder : Form
    {
        public bool editIt = false; //To ensure that edited objects aren't lost if changed.
        Reminder editRem;           //Temp Reminder

        public reminderBuilder()
        {
            InitializeComponent();
            Program.home.Enabled = false;
        }

        //Constructor to pass in Reminders to be edited.
        public reminderBuilder(Task temp)
            : this()
        {
            editIt = true;
            editRem = (Reminder) temp;
            reminderNameText.Text = editRem.taskName;
            reminderDescriptionText.Text = editRem.taskDescription;
            reminderDateTime.Value = editRem.taskEndDate;

        }
        
        //Creates object of Reminder and adds to list.
        private void reminderDone_Click(object sender, EventArgs e)
        {
            string tn = reminderNameText.Text;
            string td = reminderDescriptionText.Text;
            DateTime ted = reminderDateTime.Value.Date;

            Task rem = new Reminder(ted, tn, td);
            Program.home.add(rem);
            
            this.Close();
        }

        //Response to Canel button.
        private void reminderCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        //Sets datetime values on load.
        private void reminderBuilder_Load(object sender, EventArgs e)
        {
            reminderDateTime.Value = DateTime.Now;
        }

        //Makes the "Home" form clickable on close
        private void reminderBuilder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (editIt == true)
            {
                Program.home.add(editRem);
            }
            Program.home.Enabled = true;
        }
    }
}
