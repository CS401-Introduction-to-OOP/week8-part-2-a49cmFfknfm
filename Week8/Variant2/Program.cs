namespace Week8.Variant2;

public static class Variant2Program
{
    public static void Run()
    {
        //value type (struct), copying creating an independent copy
        Point p1 = new Point { X = 1, Y = 2 };
        Point p2 = p1;
        p2.X = 10;
        p1.Print();  // X=1  NOT changed
        p2.Print();  // X=10
        Console.WriteLine();

        // reference type copying creates a reference to the same object ===
        Console.WriteLine("=== Class (Reference Type) ===");
        PointRef r1 = new PointRef { X = 1, Y = 2 };
        PointRef r2 = r1;
        r2.X = 10;
        r1.Print();  // X=10 changed because r1 and r2 point to the same object
        r2.Print();  // X=10
        Console.WriteLine();
        BoxingTester.Test();
    }
}
