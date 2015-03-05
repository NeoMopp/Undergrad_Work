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
    public partial class Home : Form
    {
        List<Task> todoList;
        public Home()
        {
            InitializeComponent();
            todoList = new List<Task>();
        }

        //Allows for new Task to be added to the list via the menu. Will generate an error if List is full.
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (todoList.Count <= 4)
            {
                Creator newCreator = new Creator();
                newCreator.Show();
            }

            else
            {
                MessageBox.Show("You cannot have more than 5 concurrent tasks.");
            }
        }

        //Method that adds new Task to the list.
        public void add(Task temp)
        {
            todoList.Add(temp);
            this.complete();
        }

        //Detects if use has highlighted a different tasks and responds accordingly.
        private void taskNameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal1.Visible = false;

            int x = taskNameBox.SelectedIndex;
            taskDescription.Text = todoList.ElementAt(x).detailsShow();
        }
       
        //Removes item from list.
        private void itemDelete_Click(object sender, EventArgs e)
        {
            int del = taskNameBox.SelectedIndex;
            todoList.RemoveAt(del);
            this.complete();
        }

        //Runs method to edit an item in the List.
        private void itemEdit_Click(object sender, EventArgs e)
        {
            int edi = taskNameBox.SelectedIndex;
            Task temp = todoList[edi];
            todoList.RemoveAt(edi);
            this.complete();

            temp.editList(temp);
        }

        //Closes the program when the Exit button is pressed.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Marks a task as complete for the user. - Doesn't remove it from the list.
        private void taskComplete_Click(object sender, EventArgs e)
        {
            int comp = taskNameBox.SelectedIndex;
            todoList.ElementAt(comp).taskCompleted = true;
            this.complete();
            if (todoList.ElementAt(comp) is Appointment)
            {
                Appointment temp = (Appointment)todoList.ElementAt(comp);
                temp.stopTimer();
            }

        }

        //Method that puts information into the taskNameBox.
        public void complete()
        {
            taskNameBox.Items.Clear();
            taskDescription.Clear();

            foreach (Task l in todoList)
            {
                if (l.taskCompleted == true)
                {
                    taskNameBox.Items.Add(l.taskName + "        Complete");
                }

                else
                {
                    taskNameBox.Items.Add(l.taskName);
                }
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There are Four types of Task that can be added to the list." + Environment.NewLine + "Note:Basic Details of a Task." + Environment.NewLine + "Task: Basic Details and a priority rating." 
                + Environment.NewLine + "Reminder: Basic details and date."+ Environment.NewLine + "Appointment: Basic Details and a timer function. " + Environment.NewLine + "You can only have five Tasks.");
        }

       
    }
}
