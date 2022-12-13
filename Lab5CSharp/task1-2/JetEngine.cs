namespace pro100user.task2;

//Реактивний двигун
public class JetEngine : DieselEngine
{
    public JetEngine()
    {
        Console.WriteLine("Constructor \"JetEngine\"");
    }
    
    public JetEngine(string name) : base(name)
    {
        Console.WriteLine("Constructor \"JetEngine\"");
    }
    
    public JetEngine(string name, string power) : base(name, power)
    {
        Console.WriteLine("Constructor \"JetEngine\"");
    }
    
    ~JetEngine()
    {
        Console.WriteLine("Destructor \"JetEngine\"");
    }
    
    public override void Show()
    {
        Console.WriteLine($"JetEngine \"{name}\" <- DieselEngine <- InternalCombustionEngine <- Engine");
    }
}