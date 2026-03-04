namespace GeometricFigures.Backend;

public class Triangle : Rectangle
{
    private double _c;
    private double _h;

    public Triangle(string name, double a, double b, double c, double h): base(name, a, b)
    {
        _c = c;
        H = h;
    }

    public double C 
    {
        get => _c;
        set => _c = ValidateH(value);
    }

    public double H
    {
        get => _h;
        set => _h = value;
    }

    public override double GetArea() => (B * H) / 2;
    public override double GetPerimeter() => A + B + C;

    private double ValidateH(double value)
    {
        if(value <= 0) throw new ArgumentException("H must be greater than 0");
        return value;
    }
}
