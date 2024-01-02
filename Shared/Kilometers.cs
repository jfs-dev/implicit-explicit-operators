namespace implicit_explicit_operators.Shared;

public class Kilometers(double value)
{
    public double Value { get; } = value;

    public static implicit operator Meters(Kilometers kilometers) => new(kilometers.Value * 1000);
}