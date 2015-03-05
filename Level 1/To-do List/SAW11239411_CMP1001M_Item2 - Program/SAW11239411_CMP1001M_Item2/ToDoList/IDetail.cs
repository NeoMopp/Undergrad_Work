using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoList
{
    interface IDetail
    {
        void editList(Task temp);   //Interface for editing list.
        string detailsShow();       //Interface for outputting information about the task.
    }
}
