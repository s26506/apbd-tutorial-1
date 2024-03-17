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

    public static int Maksymalna(int[] t)
    {
        int m = 0;
        for (int i = 0; i < t.Length; i++)
        {
            if (i == 0) m = t[i];
            else
            if (m < t[i]) m = t[i];
        }
        return m;
    }
}

