namespace UnitTests;

public class Calculator
{
    public decimal Sum(decimal val1, decimal val2)
    {
        return val1 + val2;
    }

    public decimal Divide(decimal val1, decimal val2)
    {
        if (val2 == 0)
        {
            throw new ArgumentException("Divisor cannot be 0");
        }

        return val1 / val2;
    }

    public decimal Multiply(decimal val1, decimal val2)
    {
        return val1 * val2;
    }

    public decimal Substract(decimal val1, decimal val2)
    {
        return val1 - val2;
    }
}
