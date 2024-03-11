// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, World!");

public class CollegeCourse
{
    //Private Field
    private string _collegename;
    private string _instructor;
    private int _enrollment;
    private int _age;
    private DateTime _startdate;
    private DateTime _enddate;
    private string _courseCode;

    

    //The field subject is declated as private to encapsulate it within the  Course class. This ensures that the selection of course can only be acceses and modified through controlled methods and preventing direct manipulatuon form outside the class.


    //3. Implementation of Properties------------------------------------------------
    public string Instructor
    {
        get { return _instructor; }
        set
        {
            //You can add validation logic here if needed

            if (string.IsNullOrEmpty(value))
            {
                _instructor = value; //
            }
            else
            {
                throw new ArgumentException("Instructor name cannpt be empty.");
            }


            
        }


    }
    //Understanding Getters and Setters(15 points)
    public int Enrollment
    {
        get { return _enrollment;}

        set
        {
            if (value <=0)
                
            {
                throw new ArgumentOutOfRangeException("Enrollment number must be a positive");

            }
            _enrollment = value; //Asign the validated value to _enrollment
        }
    }


    //Read only only Properties

    public string CourseCode
    {

        get { return _courseCode; }

    }

    //Write only Properties

    public int Age
    {
        set
        {
            if (value >=0)
            {

                _age = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Enter valid Age");

            }
        }
    }





    public void DisplayCourseInfo()
    {
       
        Console.WriteLine($"Instructor: {_instructor}");
        Console.WriteLine($"Enrollment: {_enrollment}");
    }
    class RTC
    {
        static void Main(string[] args)

        {
            CollegeCourse collegecourse = new CollegeCourse();

            try
            {
                
                Console.WriteLine($"Enrollment Number: {collegecourse.Enrollment}");

            }
            catch (Exception)
            {
                Console.WriteLine("Please enter valid number");
            }

            Console.ReadLine();
        }
    }

    //Why the field is private ?
    //Answer: Instructor field is made private so that we can have validations and It is encapsulated within the class and accessed through a public property Instructor, which provides controlled access to the field. The private access level ensures that the field is not directly accessible from outside the class, promoting encapsulation and data integrity.

    //What is the role within class?
    //Answer: It is storing instructor name of this course. Instructor is a private field used to store the instructor's name. It indicates that the field is not directly accessible from outside the class.

    //PRIVATE FIELDS AND PUBLIC PROPERTIES EXPLANATION:

    //What is the need for Private Fields? Explanation
    //Answer: 1.Encapsulation and Data integrity 2. Data Hiding 3.Controlled Access 4.Abstraction 5. Security.
    //Using encapulation it prevents the direct access and manupation from external code. This promotes data intergrity and reduces the risk of unintended changes to objects. By hiding the data the internal  implementation details are hidden from external code, providing a clear separation between the public interface of the class and its internal workings. Private filed only be access and modified by methods and properties within the same class. This control over access ensures that the class can enforce business rules, validation logic, and constraints on the data it manages.Private fields help in enforcing security measures by restricting access to sensitive data. By hiding implementation details and providing controlled access, private fields reduce the risk of unauthorized access and manipulation of critical information.

    //How public properties provide controlled access to these fields?
    //Answer:Propertied are special methods that provide controlled access to private fields. They act as an interface through which external code can interact with the class's data. Properties encapsulate the access to the underlying fields, allowing the class to enforce validation rules, compute values dynamically, or perform other operations before allowing access to the data and By defining properties with custom get and set accessors, a class can control how its data is read and modified. Get accessors retrieve the value of a property (which may be derived from a private field or calculated dynamically), while set accessors assign new values to the property (after validating or processing them).

    //What is the benefits of encapsulation approach.
    //Answer: 1.Data Hiding 2.Controlled Access (getter and setter) 3. Abstraction 4.Flexilibty and Evolution 5. Easy to test code like Unit Test 6.Resuability of code. 7.Reduction of Human based errors 8.Code will be more cleaner and understandable way. 





}
