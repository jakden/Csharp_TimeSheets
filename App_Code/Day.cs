using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public class Person
{
    // Field
    public string name;

    // Constructor
    public Person()
    {
        name = "unknown";
    }

    // Method
    public void SetName(string newName)
    {
        name = newName;
    }
}
class TestPerson
{
    static void Main()
    {
        Person person = new Person();
        Console.WriteLine(person.name);

        person.SetName("John Smith");
        Console.WriteLine(person.name);

        // Keep the console window open in debug mode.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }

 

class Week
{
    static void Main()
    {
	List<int> list = new List<int>();
	list.Add(1);
	list.Add(3);
	list.Add(5);
	list.Add(7);
    }
}
}
/* Output:
    unknown
    John Smith
*/


    