namespace pro100user.task2;

//Двигун внутрішнього згорання
public class InternalCombustionEngine : Engine
{
    public InternalCombustionEngine()
    {
        Console.WriteLine("Constructor \"InternalCombustionEngine\"");
    }
    
    public InternalCombustionEngine(string name) : base(name)
    {
        Console.WriteLine("Constructor \"InternalCombustionEngine\"");
    }
    
    public InternalCombustionEngine(string name, string power) : base(name, power)
    {
        Console.WriteLine("Constructor \"InternalCombustionEngine\"");
    }
    
    ~InternalCombustionEngine()
    {
        Console.WriteLine("Destructor \"InternalCombustionEngine\"");
    }
    
    public override void Show()
    {
        Console.WriteLine($"InternalCombustionEngine \"{name}\" <- Engine");
    }
}