namespace Week8.Variant3;

public static class Variant3Program
{
    public static void Run()
    {
        var container = new DataContainer<DataItem>();

        for (int i = 0; i < 10000; i++)
        {
            var item = new DataItem
            {
                Id = $"item-{i}",
                Payload = new byte[1024]
            };
            container.AddItem(item);
        }

        Console.WriteLine($"Total size before GC: {container.GetTotalSize()} bytes");

        // GC.Collect() force heap.
        // Size wont change cuz all object have link inside container. GC will delete only objects to which nobody  pointing.
        GC.Collect();

        Console.WriteLine("GC.Collect() was called.");
        Console.WriteLine($"Total size after GC: {container.GetTotalSize()} bytes");
    }
}
