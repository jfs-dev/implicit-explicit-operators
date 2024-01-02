namespace implicit_explicit_operators.Shared;

public class Meters(double value)
{
    public double Value { get; } = value;

    public static explicit operator Kilometers(Meters meters) => new(meters.Value / 1000);
}