
var temperature = new Temperature(TemperatureUnit.Test, 10);
Console.WriteLine($"Temperature: {temperature.ValueInCelcius.ToString("10.0")}°C");

////Underlying values are int 
//Console.WriteLine((int)TemperatureUnit.Celcius);
//Console.WriteLine((int)TemperatureUnit.Fahrenheit);
//Console.WriteLine((int)TemperatureUnit.Kelvin);

////Casting values from int to TemperatureUnit 
////Warning: 7 can be casted but is not defined.
//int temperature2 = 7;
//TemperatureUnit kelvin = (TemperatureUnit)temperature2;
enum TemperatureUnit
{
    Celcius,
    Fahrenheit,
    Kelvin, 
    Test
}
class Temperature
{
    public Temperature(TemperatureUnit unit, decimal value)
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
            return Unit switch
            {
                TemperatureUnit.Celcius => Value,
                TemperatureUnit.Fahrenheit => (Value - 32) * 5 / 9,
                TemperatureUnit.Kelvin => Value - 273.15m,
                _ => 0
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