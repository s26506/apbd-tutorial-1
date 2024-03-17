public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Start");
        Console.WriteLine("Druga");
        Console.WriteLine("3");
    }


    public static float S(int[] tab)
    {
        float wynik = 0;
        foreach (var elem in tab)
        {
            wynik += elem;
        }

        return wynik / tab.Length;
    }

    public static float Sred(int[] tab)
    {
        float wynik = 0;
        foreach(var elem in tab)
        {
            wynik += elem;
        }
        return wynik / tab.Length;
>>>>>>> feature-new
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

