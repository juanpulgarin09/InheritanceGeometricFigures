namespace GeometricFigures.Backend;

public abstract class GeometricFigure(string name)
{

    public string Name
    {
        get;
        set;
    } = name;

    public abstract double GetArea();
    public abstract double GetPerimeter();

    public override string ToString()
    {
        return $"{Name,-15} => Area.....: {GetArea(),14:F5}   Perimiter: {GetPerimeter(),14:F5}";
    }
}
