using System
namespace CSharpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i < 100; ++i)
                sum += 1;

            Console.WriteLine(sum);
           
           Console.WriteLine("Zdravo narode");
           Console.ReadKey();
        }
    }
}
