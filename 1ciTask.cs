
class Program
{
    static void Main()
    {
        Console.WriteLine("Imtahan qiymetinizi daxil edin (0-100 araliginda):");

        // Istifadəçidən qiyməti almaq üçün
        if (double.TryParse(Console.ReadLine(), out double qiymet))
        {
            // Qiymətin 0 və 100 aralığında olub olmadığını yoxlamaq
            if (qiymet >= 0 && qiymet <= 100)
            {
                // Qiymət aralığına görə tələbənin çapını tapmaq
                if (qiymet >= 91)
                    Console.WriteLine("Qiymet: A");
                else if (qiymet >= 81)
                    Console.WriteLine("Qiymet: B");
                else if (qiymet >= 71)
                    Console.WriteLine("Qiymet: C");
                else if (qiymet >= 61)
                    Console.WriteLine("Qiymet: D");
                else if (qiymet >= 51)
                    Console.WriteLine("Qiymet: E");
                else
                    Console.WriteLine("Qiymet: Kəsildiniz");
            }
            else
            {
                Console.WriteLine("Xəta: Qiymət 0 və 100 aralığında olmalıdır.");
            }
        }
        else
        {
            Console.WriteLine("Xəta: Düzgün qiymət daxil edin.");
        }
    }
}