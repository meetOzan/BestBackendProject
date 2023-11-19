using Person = Uygulama3.Person;

namespace BestBackendProject;

public class Login
{

    private static List<Uygulama3.Person> personList;

    public Login()
    {
        personList = new List<Uygulama3.Person>()
        {
            new Uygulama3.Person(name: "Merzan", surname: "Kahraman", isAlive: true, age: 42)
        };
    }
    
    public int CheckLogin(Uygulama3.Person p)
    {
        var result = personList.FirstOrDefault(x => x.Name == p.Name && x.Surname == p.Surname);
        if (result.Age == p.Age) return 1;
        else return 0;
    }
}
