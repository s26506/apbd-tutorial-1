public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Start");
        Console.WriteLine("Druga");
        Console.WriteLine("3");
    }

    public static float Srednia(int[] t)
    {
        float wynik = 0;
        foreach(var elem in t)
        {
            wynik += elem;
        }

        return wynik / t.Length;
    }
}

