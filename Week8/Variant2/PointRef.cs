namespace Week8.Variant2;

public class PointRef
{
    public int X { get; set; }
    public int Y { get; set; }

    public void Print()
    {
        Console.WriteLine($"PointRef(class): X={X}, Y={Y}");
    }
}
