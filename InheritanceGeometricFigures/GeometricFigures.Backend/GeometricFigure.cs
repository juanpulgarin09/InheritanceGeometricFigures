namespace GeometricFigures.Backend;

public abstract class GeometricFigure
{
    public string Name { get; set; }

    protected GeometricFigure(string name)
    {
        Name = name;
    }

    public abstract double GetArea();
    public abstract double GetPerimeter();

    public override string ToString()
    {
        return $"{Name,-15} => Area.....: {GetArea(),14:N5}   Perimiter: {GetPerimeter(),14:N5}";
    }
}
