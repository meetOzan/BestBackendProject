namespace Uygulama3;

public class Person
{
    public string Name { get; set; }

    public string Surname{ get; set; }

    public int Age { get; set; }
    
    private bool IsAlive { get; set; }


    public Person(string name, string surname, int age, bool isAlive)
    {
        Name = name;
        Surname = surname;
        Age = age;
        IsAlive = isAlive;
    }

    public Person(string name, int age, bool isAlive)
    {
        Name = name;
        Age = age;
        IsAlive = isAlive;
    }
    
}