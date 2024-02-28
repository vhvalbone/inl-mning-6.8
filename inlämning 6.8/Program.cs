using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Ange ett heltal:");
        int heltal = Convert.ToInt32(Console.ReadLine());

        int antalPrimtal = AntalPrimtalMindreAn(heltal);
        Console.WriteLine("Antalet primtal mindre än " + heltal + " är: " + antalPrimtal);
    }

    public static bool ArPrimtal(int n)
    {
        if (n <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    public static int AntalPrimtalMindreAn(int n)
    {
        int antalPrimtal = 0;
        for (int i = 2; i < n; i++)
        {
            if (ArPrimtal(i))
            {
                antalPrimtal++;
            }
        }
        return antalPrimtal;
    }
}

