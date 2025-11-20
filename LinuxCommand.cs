public class LinuxCommand
{
    public string command { get; set; }
    public string description { get; set; }
    public string example { get; set; }
    public string category { get; set; }

    public void Display()
    {
        Console.WriteLine($"Command: {command}");
        Console.WriteLine($"Description: {description}");
        Console.WriteLine($"Example: {example}");
        Console.WriteLine($"Category: {category}");
        Console.WriteLine("-------------------------------------------");
    }
}
