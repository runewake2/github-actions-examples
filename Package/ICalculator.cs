public interface IAdder
{
    int Add(int a, int b);
}

public interface IMultiplier
{
    int Mult(int a, int b, IAdder adder);
}