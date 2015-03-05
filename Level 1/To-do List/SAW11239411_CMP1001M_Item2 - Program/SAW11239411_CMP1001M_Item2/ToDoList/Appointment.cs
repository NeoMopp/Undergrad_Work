using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;


namespace ToDoList
{
    class Appointment : Reminder, IDetail
    {
        string _location;               //Where the appointment will take place.
        TimeSpan _appointmentTime;      //The time at which the appointment will take place.
        System.Timers.Timer _timer;          //Timer to alert user when the Task is over.

        public Appointment(string l, TimeSpan at, DateTime ted, string tn, string td) //Constructor.
            : base(ted, tn, td)
        {
            _location = l;
            _appointmentTime = at;
        }

        //Method to set or return _location.
        public string location
        {
            get
            {
                return _location;
            }

            set
            {
                _location = value;
            }
        }

        //Method to set or return _appointmentTime.
        public TimeSpan appointmentTime
        {
            get
            {
                return _appointmentTime;
            }

            set
            {
                _appointmentTime = value;
            }
        }

        //Method to allow for an Appointment to be edited. Interface.
        public override void editList(Task temp) 
        {
            appointmentBuilder editAppointment = new appointmentBuilder(temp);
            editAppointment.Show();
        }

        //Method to show the variables within this class. Interface.
        public override string detailsShow()
        {
            TimeSpan finish = this.end();

            return base.detailsShow() + Environment.NewLine + "Location: " + _location + "Days:" + finish.Days.ToString() + "Hours:" + finish.Hours.ToString() + "Mins:" + finish.Minutes.ToString() + "Left:";
        }

        //Starts a timer to alert use that the task is finished.
        public void timerStart()
        {
            TimeSpan end = this.end();
            double x = end.TotalMilliseconds;
            _timer = new System.Timers.Timer(x);

            _timer.Elapsed += new ElapsedEventHandler(_timer_Elapsed);
            _timer.Enabled = true;
            
        }

        //The even of the timer ending.
        public void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            MessageBox.Show("Appointment:"+ base.taskName + "has concluded");
            base.taskCompleted = true;
            Program.home.complete();
        }

        //Method to stop the timer in the case that user completes it early.
        public void stopTimer()
        {
            _timer.Enabled = false;
        }

        //Method to calculate how long is left till task is over.
        private TimeSpan end()
        {
            DateTime now = DateTime.Now;
            DateTime finish = base.taskEndDate;
            finish = finish.AddHours(_appointmentTime.Hours);
            finish = finish.AddMinutes(_appointmentTime.Minutes);
            finish = finish.AddMilliseconds(_appointmentTime.Milliseconds);

            //Calculating the milliseconds left till task ends.
            int daysLeft = finish.Day - now.Day;
            int hoursLeft = finish.Hour - now.Hour;
            int minsLeft = finish.Minute - now.Minute;
            int secLeft = finish.Second - now.Second;
            int milLeft = finish.Millisecond - now.Millisecond;

            TimeSpan end = new TimeSpan(daysLeft, hoursLeft, minsLeft, secLeft, minsLeft);
            return end;
        }

    }
}

