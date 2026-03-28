namespace Week8.Variant2;

public static class BoxingTester
{
    public static void Test()
    {
        
        int a = 10;
        object b = a;//boxing value 10 is wrapped into object on heap
        int c = (int)b;//unboxing unwrap back into int on stack
        //Boxing: int(stack) -> object(heap)

        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b (boxed) = {b}");
        Console.WriteLine($"c (unboxed) = {c}");

        
        // Proof that boxing creates a copy:
        a = 20;
        Console.WriteLine($"After a = 20:");
        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b (boxed, no change) = {b}");
    }
}
