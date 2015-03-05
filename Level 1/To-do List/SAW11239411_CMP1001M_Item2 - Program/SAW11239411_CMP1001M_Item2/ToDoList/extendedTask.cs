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
    class extendedTask : Task, IDetail
    {
        int _taskPriority;      //The importance of said task.


        //Consrtuctor.
        public extendedTask(int tp, string tn, string td) 
            : base(tn, td)
        {
            _taskPriority = tp;
        }

        
        //Method to set or return _taskPriority.
        public int taskPriority
        {
            get
            {
                return _taskPriority;
            }

            set
            {
                _taskPriority = value;
            }
        }

        //Method to allow for an extendedTask to be edited. Interface
        public override void editList(Task temp)
        {
            extendedTaskBuilder editTask = new extendedTaskBuilder(temp);
            editTask.Show();
        }

        //Method to show the variables within this class. Interface.
        public override string detailsShow()
        {
            return base.detailsShow() + Environment.NewLine + "Priority: " + _taskPriority;
        }

    }
}
