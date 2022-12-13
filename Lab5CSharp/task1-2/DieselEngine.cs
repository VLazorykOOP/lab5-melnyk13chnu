namespace pro100user.task2;

//Дизильний двигун
public class DieselEngine : InternalCombustionEngine
{
    public DieselEngine()
    {
        Console.WriteLine("Constructor \"DieselEngine\"");
    }
    
    public DieselEngine(string name) : base(name)
    {
        Console.WriteLine("Constructor \"DieselEngine\"");
    }
    
    public DieselEngine(string name, string power) : base(name, power)
    {
        Console.WriteLine("Constructor \"DieselEngine\"");
    }
    
    ~DieselEngine()
    {
        Console.WriteLine("Destructor \"DieselEngine\"");
    }
    
    public override void Show()
    {
        Console.WriteLine($"DieselEngine \"{name}\" <- InternalCombustionEngine <- Engine");
    }
}