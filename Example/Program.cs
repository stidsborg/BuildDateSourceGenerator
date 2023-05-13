// See https://aka.ms/new-console-template for more information

namespace SourceGeneratorExample;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Helper.DeterministicBuild);
        Console.WriteLine(new DateTime(Helper.BuildTime));
    }
}