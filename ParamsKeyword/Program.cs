var numberPrinter = new NumberPrinter();
numberPrinter.PrintNumbers(new int[] { 5, 10, 15, 20 });
numberPrinter.PrintNumbers(2, 4, 6, 8);

public class NumberPrinter
{
    public void PrintNumbers(params int[] numbers)
    {
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
