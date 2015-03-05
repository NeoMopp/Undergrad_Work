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
    public partial class noteBuilder : Form
    {
        public bool editIt = false;     //To ensure that edited objects aren't lost if changed.
        Note editNote;                  //Temp Note.
        
        public noteBuilder()
        {
            InitializeComponent();
            Program.home.Enabled = false;
        }

        //Constructor to edit a Note.
        public noteBuilder(Task temp)
            : this()
        {
            editIt = true;
            editNote = (Note)temp;
            noteNameText.Text = editNote.taskName;
            noteDescriptionText.Text = editNote.taskDescription;
            noteDetailsText.Text = editNote.noteDescription;
        }

        //Response to Canel button.
        private void noteCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Creates new Note and adds to list.
        private void noteDone_Click(object sender, EventArgs e)
        {
            string tn = noteNameText.Text;
            string td = noteDescriptionText.Text;
            string nd = noteDetailsText.Text;

            Task not = new Note(nd, tn, td);
            Program.home.add(not);         
            
            this.Close();

        }

        //Makes the "Home" form clickable on close
        private void noteBuilder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (editIt == true)
            {
                Program.home.add(editNote);
            }
            Program.home.Enabled = true;
        }

        
    }
}
