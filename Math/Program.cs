namespace Mathematic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 17, 12, 30, 42, 54, };
            int a = array.Max();
            int b = array.Where(n => n != a).Max();
            Console.WriteLine($"Array's second the  biggest number {b} ");

            int c = 9;
            c += 4;
            Console.WriteLine(c);
            Console.Write("A ededini daxil edin:  ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("B ededi daxil edin:  ");
            int e = int.Parse(Console.ReadLine());

            Console.WriteLine($"{d}+{e}={d + e}");
            int f = int.Parse(Console.ReadLine());


            Console.Write("Ededi Daxil edin:");
            int number = int.Parse(Console.ReadLine());
            double g = Math.Sqrt(number);
            Console.WriteLine(g);




            Console.WriteLine("Eded daxil edin ");
            int h = int.Parse(Console.ReadLine());

            int r4 = h % 10;
            h = h / 10;
            int r3 = h % 10;

            Console.WriteLine(r3);
            h = h / 10;
            int r2 = h % 10;
            Console.WriteLine(r2);


            Console.Write("Heftenin gununu daxil et");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Bazarertesi");
                    break;

                case 2:
                    Console.WriteLine("Çərşəmbə Axsami");
                    break;

                case 3:
                    Console.WriteLine("Cersembe");
                    break;


                case 4:
                    Console.WriteLine("Cume Axsami");
                    break;


                case 5:
                    Console.WriteLine("Cume");
                    break;

                case 6:
                    Console.WriteLine("Senbe");
                    break;
                case 7:
                    Console.WriteLine("Bazar");
                    break;

                default:
                    Console.WriteLine("Duzgun daxil edilmeyib");
                    break;
            }

            Console.WriteLine("eded daxil edin");
            int p=int.Parse(Console.ReadLine());

            int digCount = (int)Math.Log10(p) + 1;
            Console.WriteLine(digCount);
        }
    }
}
