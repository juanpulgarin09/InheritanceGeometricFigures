namespace GeometricFigures.Backend;

public class Parallelogram : Rectangle
{
    private double _h;

    public Parallelogram(string name, double a, double b, double h) : base(name,a, b)
    {
        H = h;
    }

    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }

    public override double GetArea() => B * _h;
    public override double GetPerimeter() => 2 * (A + B);

    private double ValidateH(double value)
    {
        if (value <= 0) throw new ArgumentOutOfRangeException("H must be greater than 0");
        return value;
    }

}
