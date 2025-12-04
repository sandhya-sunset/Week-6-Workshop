namespace Task_1;

public class Rectangle
{
    private double length;
    private double breadth;

    public double Length
    {
        get => length;
        set => length = value;
    }

    public double Breadth
    {
        get => breadth;
        set => breadth = value;
    }

    public double GetArea() => Length * Breadth;

    public double GetPerimeter() => 2 * (Length + Breadth);

    public string ShowDetails() =>
        $"Length: {Length}, Breadth: {Breadth}, Area: {GetArea()}, Perimeter: {GetPerimeter()}";
}