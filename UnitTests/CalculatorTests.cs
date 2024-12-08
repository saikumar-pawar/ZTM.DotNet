namespace UnitTests;

[TestClass]
public sealed class CalculatorTests
{
    [TestMethod]
    public void Calculator_Sum_Return20For12And8()
    {
        //Arrange
        var calculator = new Calculator();

        //Act
        var result = calculator.Sum(12, 8);

        //Assert
        Assert.AreEqual(20, result);
    }

    [TestMethod]
    public void Calculator_Divide_Returns8For16And2()
    {
        var calculator = new Calculator();

        var result = calculator.Divide(16, 2);

        Assert.AreEqual(8, result);
    }

    [TestMethod]
    [ExpectedException(typeof(DivideByZeroException))]
    public void Calculator_Divide_ThrowsExceptionFor20And0()
    {
        var calculator = new Calculator();

        calculator.Divide(20, 0);
    }
}
