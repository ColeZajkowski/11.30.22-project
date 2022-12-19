/*
 * Program Name: User managment creator
 * Programmer: Cole Zajkowski
 * Date: 12/19/2022
 *
 * Description: The program allows users to create new account for a school district in a C# application.
 */
using System.Net;
using System.Reflection.Metadata;

bool isLooping = false;

const string TEACHER_IDNUMBER = "Amherst";
const string TEACHER_PINUMBER = "Steele";



List<Student> student = new List<Student>();
List<Chaperone> chaperone = new List<Chaperone>();
List<Teacher> teacher = new List<Teacher>();

Console.WriteLine("Press Y to Login to an existing account");
Console.WriteLine("Press N to make a new account");
string studentInput = Console.ReadLine();
if (studentInput == "Y")
{
    Login();
    
}else if(studentInput == "N")
{
    CreateUsers();
}
else
{
    Console.WriteLine("Incorrect ID or PIN");
}


 void CreateUsers()
{
    Console.WriteLine("Enter District Name First(Amherst)");
    string idnumber = Console.ReadLine();
    Console.WriteLine("Then enter School Name (Steele)");
    string pinumber = Console.ReadLine();

    if (idnumber == TEACHER_IDNUMBER && pinumber == TEACHER_PINUMBER)
    {
        isLooping = true;
        Console.Clear();
    }
    else
    {
        isLooping = false;
        Console.Clear();
        Console.WriteLine("Amherst Exempted Village Schools staff or students only!");
        CreateUsers();
    }
  

    while (isLooping)
    {
        Console.WriteLine("You submitted Amherst, Steele. Please Create an account");
        Console.WriteLine("Create a new ID number: ");
        string id = Console.ReadLine();

        Console.WriteLine("Create a new PIN code");

        string pn = Console.ReadLine();

        Console.WriteLine("Press 1 to create a student account");
        Console.WriteLine("Press 2 to create a chaperone account");
        Console.WriteLine("Press 3 to create a teacher account");
        Console.WriteLine("Press 0 to login to an existing account");
        int selection = int.Parse(Console.ReadLine());


        if (selection == 1)
        {
            student.Add(new Student(id, pn));
            Console.WriteLine(id + "Has sucessfully created a student account");
        }

        else if (selection == 2)
        {
            chaperone.Add(new Chaperone(id, pn));
            Console.WriteLine("Has sucessfully created a chaperone account");
        }

        else if (selection == 3)
        {
            teacher.Add(new Teacher(id, pn));
            Console.WriteLine("Has sucessfully created a teacher account");
        }
        else if (selection == 0)
        {
            Login();
        }
        else
        {
            Console.WriteLine("Incorrect submission, please return to home!");
        }
        Console.Clear();






        Console.WriteLine("All students:");
        foreach (Student stu in student)
        {
            Console.WriteLine(stu.idnumber);
        }
        Console.WriteLine("All chaperones:");
        foreach (Chaperone cha in chaperone)
        {
            Console.WriteLine(cha.idnumber);
        }
        Console.WriteLine("All teachers:");
        foreach (Teacher tea in teacher)
        {
            Console.WriteLine(tea.idnumber);
        }

    }
}

void Login()
{
    Console.WriteLine("Enter ID");
    string id = Console.ReadLine();
    Console.WriteLine("Enter corresponding PIN");
    String pn = Console.ReadLine();

    foreach(Student student in student)
    {
        if(student.idnumber == id)
        {
            if (student.pinumber == pn)
            {
                LoadApp(id);
            }
            else
            {
                Console.WriteLine("Incorrect PIN");
                Login();
            }
        }
        else
        {
            Console.WriteLine("Invalid ID");
            Login();
        }
    }
}

void LoadApp(string idnumber)
{
    Console.WriteLine("Hello"+ idnumber+"!");
}



