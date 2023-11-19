namespace BestBackendProject;

public interface NewInterface
{
     string[] getNameArray();
}

class InterfaceKlass : NewInterface
{
     public string[] getNameArray()
     {
          throw new NotImplementedException();
     }
}