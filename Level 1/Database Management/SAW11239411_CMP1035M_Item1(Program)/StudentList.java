public class StudentList
{
    protected StudentData header, tail;
    public int i = 0; //counter for the number of students in the list
    public boolean complete = true; //used to break a loop while ordering list
    public int x = 0; //used as a counter to check if list is ordered
    
    public StudentList()
    {
        tail = null;
        header = tail;
    }
    
    public void addStudent(StudentData NewStudent)//adds new student to list
    {
        if(header == tail)
        {
            header = NewStudent;
            i++;
        }
        
        else
        {
            StudentData student = header;
            while (student.getNext() != null)
            {
                student = student.getNext();
            }
            
            student.setNext(NewStudent);
            NewStudent.setPrevious(student);
            i++;
        }
    }
    
    public void searchForStudent(int student_id)//Searches for student
    {
        StudentData u = header;
        while (u.getNext() != null)
        {
            if (student_id == u.student.StudentID)
            {
                User.message("found");
                break;
            }
            
            else
            u= u.getNext();
        }
        if (student_id == u.student.StudentID)
        {
            u.getStudent();
        }
        if (u.getNext() == null)
        {
            User.message("Student doesn't exist");
        }
    }
    
    public void deleteStudent(int student_id)//Searches for student to delete for list
    {
        StudentData Next = null;
        StudentData Previous = null;
        StudentData u = header;
        while (u.getNext() != null)
        {
            if (student_id == u.student.StudentID)//checking to see if nodes are equal
            {
               Next = u.getNext();
               Previous = u.getPrevious();
               Previous.setNext(Next);
               Next.setPrevious(Previous);
               i--;
               u = null;
            }
            
            else
            u = u.getNext();
        }
        if (student_id == u.student.StudentID)//checking to see if nodes are equal
        {
            Next = u.getNext();
            Previous = u.getPrevious();
            Previous.setNext(Next);
            Next.setPrevious(Previous);
            i--;
        }
        if (u.getNext() == null)
        {
            User.message("Student doesn't exist");
        }
    }
    
    public void orderList()//recursive ordering of list 
    {
        orderList(header);
        complete = true;
        x = 0;
    }
    
    private void orderList(StudentData u)
    {
        while (complete = true)
        {
            while (u.getNext() != null)
            {
                StudentData v = u.getNext();
                StudentData t = v.getNext();
                if (u.student.StudentID > v.student.StudentID)//see if data is in the right place, swaps if not
                {
                    u.setPrevious(v);
                    u.setNext(t);
                    v.setNext(u);
                    v.setPrevious(u.getPrevious());
                    t.setPrevious(u);
                    x= 0;
                }
                if (u.student.StudentID < v.student.StudentID)
                {
                    orderList(v);
                    x++;
                }
            }
            if (x == i)//if statement to check if the list is ordered
            {
                complete = false;
            }
            else
            orderList(header);      
        }   
    }
                
}
