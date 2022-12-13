namespace pro100user.task2;

//Двигун
public class Engine
{
    protected string name;
    
    public Engine()
    {
        name = "someengine";
        Console.WriteLine("Constructor \"Engine\"");
    }
    
    public Engine(string name)
    {
        this.name = name;
        Console.WriteLine("Constructor \"Engine\"");
    }
    
    public Engine(string name, string power)
    {
        this.name = name + " " + power;
        Console.WriteLine("Constructor \"Engine\"");
    }
    
    ~Engine()
    {
        Console.WriteLine("Destructor \"Engine\"");
    }

    public virtual void Show()
    {
        Console.WriteLine($"Engine \"{name}\"");
    }
}