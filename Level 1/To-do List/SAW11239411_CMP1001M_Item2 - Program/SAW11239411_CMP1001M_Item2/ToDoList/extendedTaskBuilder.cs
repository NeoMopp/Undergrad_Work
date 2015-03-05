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
    public partial class extendedTaskBuilder : Form
    {
        public bool editIt = false;     //To ensure that edited objects aren't lost if changed.
        extendedTask editTask;          //Temp extendedTask.
        
        public extendedTaskBuilder()
        {
            InitializeComponent();
            Program.home.Enabled = false;
        }

        //Constructor for editing extendedTasks.
        public extendedTaskBuilder(Task temp)
            : this()
        {
            editIt = true;
            editTask = (extendedTask)temp;
            taskNameText.Text =  editTask.taskName;
            taskDescriptionText.Text = editTask.taskDescription;
            taskPri.Value = editTask.taskPriority;
        }


        //Creates new Task and adds to list.
        private void taskDone_Click(object sender, EventArgs e)
        {
            string tn = taskNameText.Text;
            string td = taskDescriptionText.Text;
            int tp = Convert.ToInt32(taskPri.Value);

            Task exTas = new extendedTask(tp, tn, td);
            Program.home.add(exTas);
            
            this.Close();
        }

        //Response to Canel button.
        private void taskCancel_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        //Makes the "Home" form clickable on close
        private void extendedTaskBuilder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (editIt == true)
            {
                Program.home.add(editTask);
            }
            Program.home.Enabled = true;
        }
    }
}
