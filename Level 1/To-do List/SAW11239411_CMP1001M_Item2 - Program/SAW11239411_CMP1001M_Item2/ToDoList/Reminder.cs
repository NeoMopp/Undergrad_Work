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
    class Reminder : Task, IDetail
    {
        DateTime _taskEndDate;      //The day on which said task will expire and be removed from list.

        //Constructor.
        public Reminder(DateTime ted, string tn, string td) 
            : base(tn, td)
        {
            _taskEndDate = ted;
        }
        
        //Method to set or return _taskEndDate.
        public DateTime taskEndDate
        {
            get
            {
                return _taskEndDate;

            }

            set
            {
                _taskEndDate = value;
            }
        }


        //Method to allow for a Reminder to be edited. Interface
        public override void editList(Task temp)
        {
           reminderBuilder editReminder = new reminderBuilder(temp);
           editReminder.Show();
        }

        //Method to show the variables within this class. Interface.
        public override string detailsShow()
        {
            Program.home.cal1.Visible = true;
            Program.home.cal1.TodayDate = _taskEndDate;
            return base.detailsShow();
        }
    }
}
