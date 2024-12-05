var temperature = new Temparatue(TemperatureUnit.Celcius, 110.76m);
Console.WriteLine($"Temperature: {temperature.ValueInCelcius.ToString("0.0")}°C");

public enum TemperatureUnit
{
    Celcius,
    Fahrenheit,
    Kelvin
}

public class Temparatue
{
    public Temparatue(TemperatureUnit unit, decimal value)
    {
        Unit = unit;
        Value = value;
    }

    public TemperatureUnit Unit { get; set; }
    public decimal Value { get; set; }

    public decimal ValueInCelcius
    {
        get
        {
            return Unit switch {
                TemperatureUnit.Celcius when Value > 100 => Math.Round(Value, 0),
                TemperatureUnit.Celcius => Value,
                TemperatureUnit.Fahrenheit => (Value - 32) * 5 / 9,
                TemperatureUnit.Kelvin => Value - 273.15m,
                _ => 0,
            };

            //switch (Unit)
            //{
            //    case TemperatureUnit.Celcius:
            //        return Value;
            //    case TemperatureUnit.Fahrenheit:
            //        return (Value - 32) * 5 / 9;
            //    case TemperatureUnit.Kelvin:
            //        return Value - 273.15m;
            //    default:
            //        return 0;
            //}
        }
    }
}