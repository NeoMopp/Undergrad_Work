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
    class Note : Task, IDetail
    {
        string _noteDescription;    //More indepth details about the task.

        //Constructor
        public Note(string nd, string tn, string td) 
            : base(tn, td)
        {
            _noteDescription = nd;
        }

        //Method to set or return _noteDescription.
        public string noteDescription
        {
            get
            {
                return _noteDescription;
            }

            set
            {
                _noteDescription = value;
            }
        }

        //Method to allow for an Note to be edited. Interface
        public override void editList(Task temp)
        {
            noteBuilder editNote = new noteBuilder(temp);
            editNote.Show();
        }

        //Method to show the variables within this class. Interface.
        public override string detailsShow()
        {
            return base.detailsShow() + Environment.NewLine + "Details: " + _noteDescription;
        }

    }
}
