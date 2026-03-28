using Variant1;

var file = new FileResource("report.txt");
var network = new NetworkResource("api.company.local");

var manager = new ResourceManager<Resource>();

manager.Add(file);
manager.Add(network);

manager.OpenAll();

Console.WriteLine("Demonstrating 'using' with FileResource");
using (var tempFile = new FileResource("temp.txt"))
{
    tempFile.Open();
    Console.WriteLine($"Inside using block, IsOpen = {tempFile.IsOpen}");
}
Console.WriteLine("Exited using block — Dispose was called automatically!\n");

manager.CloseAll();

Console.WriteLine("Done.");