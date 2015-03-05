public class StudentData
{
    public Student  student = new Student();
    public StudentData next;
    public StudentData previous;

    public StudentData() //creates new student
    {
       student.newStudent();
       next = null;
       previous = null;

    }
    
    public void addModuleToStudent() //allows for a module to be added 
    {
        student.newModule();
    }
    
    public void addGradeToStudentModule() // allows for grade to be added
    {
        student.newResult();
    }
    
    public void modifyStudent() // allows user to modify student value
    {
        User.message("Choose a field to modify");
        User.message("Option 1: StudentID, Option 2: First Name, Option 3: Surname, Option 4: Middle Inital, Option 5: Telephone Number");
        int option = User.inputInt("Choose Option");
       //if statement to determine users choice
        if (option == 1)
        {
            student.changeStudentID();
        }
        
        if (option == 2)
        {
            student.changeFirstName();
        }
        if (option == 3)
        {
            student.changeSurname();
        }
        if (option == 4)
        {
            student.changeMiddleInitial();
        }
        if (option == 5)
        {
            student.changeTelephoneNumber();
        }
    }
    
    public Student getStudent()//returns student
    {
        return student;
    }
    
    public StudentData getNext() //returns the next Student in list
    {
        return next;
    }
    
    public void setNext(StudentData newNext) //sets next Student in list
    {
        next = newNext;
    }
    
    public StudentData getPrevious() //returns previous Student in list
    {
        return previous;
    }
    
    public void setPrevious(StudentData newPrevious) //sets previous student in list
    {
        previous = newPrevious;
    }
}
     
    