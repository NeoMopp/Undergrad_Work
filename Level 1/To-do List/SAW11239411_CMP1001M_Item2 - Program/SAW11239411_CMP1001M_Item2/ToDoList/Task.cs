using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Base Class.

namespace ToDoList
{
    public class Task : IDetail
    {
        string _taskName;            //Task title.
        string _taskDescription;     //Task description.
        bool _taskCompleted;         //Is the task completed.

        //Constructor.
        public Task(string tn, string td) 
        {
            _taskName = tn;
            _taskDescription = td;
            _taskCompleted = false;
        }
        
        // Method set or return _taskName.
        public string taskName
        {
            get
            {
                return _taskName;
            }

            set
            {
                _taskName = value;
            }
        }

        //Method to set or return _taskDescription.
        public string taskDescription
        {
            get
            {
                return _taskDescription;
            }

            set
            {
                _taskDescription = value;
            }
        }

        public bool taskCompleted
        {
            get
            {
                return _taskCompleted;
            }

            set
            {
                _taskCompleted = value;
            }
        }

        //Method to allow for a Task to be edited. Interface
        //Shouldn't ever run.
        public virtual void editList(Task temp)
        {
            Creator editCreator = new Creator();
            editCreator.Show();
        }

        //Method to show the variables within this class. Interface.
        public virtual string detailsShow()
        {
            return "Description: " + _taskDescription;
        }
    }
}
