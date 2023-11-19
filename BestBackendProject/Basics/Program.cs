// See https://aka.ms/new-console-template for more information

using BestBackendProject;

Console.WriteLine("Hello, World!");

Main.main();

struct Person
{
    public string name { get; set; }
    public int age { get; set; }
}

public struct PersonConst
{

    private string Name { get; set; }
    private int Age { get; set; }

    public PersonConst(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class People // Heapte saklanır
{
    
    private string Id { get; set; }
    private string Name { get; set; }
    private bool IsAlive { get; set; }
    
    public People(string id, string name, bool isAlive)
    {
        Id = id;
        Name = name;
        IsAlive = isAlive;
    }

}