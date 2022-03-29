namespace Package;
public class Calculator
{
    public IAdder Adder = new Adder();
    public IMultiplier Multiplier = new Multiplier();

    public int Mult(int a, int b)
    {
        return Multiplier.Mult(a, b, Adder);
    }

    public int Add(int a, int b)
    {
        return Adder.Add(a, b);
    }

    public int Subtract(int a, int b) 
    {
        return a - b;
    }
}

public class Adder : IAdder
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}

public class Multiplier : IMultiplier
{


    public int Mult(int a, int b, IAdder adder)
    {
        var result = 0;
        for (int i = 0; i < b; ++i)
        {
            result = adder.Add(result, a);
        }
        return result;
    }
}