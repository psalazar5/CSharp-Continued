class Student
{
  string FirstName;
  string LastName;
  int StudentId;
  int GradePointAverage;

  string FormatFullName ()
  {
    //method to create a properly formatted name from first and last names 
    return firstName + " " + lastName;
  }

  Student()
  {
    //base (built-in) constructor method
  }

  Student(int gpa)
  {
    //method where you can get GPA when creating a Student
    GradePointAverage = gpa;
  }

  Student(string firstName, string lastName)
  {
    //method where you can set names when creating a Student
    FirstName = firstName;
    LastName = lastName;
  }

}

//Creating instances

//Using base constructor:

Student student = new Student();
student.FirstName = "Bob";

//Using "gpa" constructor: 

int startingGpa = 3.2;
Student student = new Student(startingGpa)

//Using "named" constructor :

string firstName = "Erik";
string lastName = "Gross";
Student student = new Student( firstName, lastName);

//Accessing behavior in the class 

string displayName = student.FormatFullName