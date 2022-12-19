using System;

public class Student
{

	public string idnumber;
	public string pinumber;
	
	
	public Student(string id, string pn)
	{
		idnumber = id;
		pinumber = pn;

	}


}

public class Teacher : Student
{
	public Teacher (string id, string pn) : base(id, pn)
	{
        idnumber = id;
        pinumber = pn;
    }
}

public class Chaperone : Student
{
    public Chaperone (string id, string pn) : base(id, pn)
	{
        idnumber = id;
        pinumber = pn;

    }
}