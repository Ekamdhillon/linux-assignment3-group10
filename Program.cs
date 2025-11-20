using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        string json = File.ReadAllText("linux_commands.json");

        List<LinuxCommand> commands =
            JsonSerializer.Deserialize<List<LinuxCommand>>(json);

        Console.WriteLine("=== Linux Commands Reference ===\n");

        foreach (var cmd in commands)
        {
            cmd.Display();
        }
    }
}
