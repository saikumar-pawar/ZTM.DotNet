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
    [ExpectedException(typeof(ArgumentException))]
    public void Calculator_Divide_ThrowsExceptionFor20And0()
    {
        var calculator = new Calculator();

        calculator.Divide(20, 0);
    }

    [TestMethod]
    public void Calculator_Multiply_Returns120For12Aand10()
    {
        var calculator = new Calculator();

        var result = calculator.Multiply(12, 10);

        Assert.AreEqual(120, result);
    }

    [TestMethod]
    public void Calculator_Substract_Returns32For34And2()
    {
        var calculator = new Calculator();

        var result = calculator.Substract(34, 2);

        Assert.AreEqual(32, result);
    }
}
