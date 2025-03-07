namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Calculadora Tabajara 2025");
            Console.WriteLine("-----------------------------------------");

            Console.Write("Digite o primeiro número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            double resultado = numero1 + numero2;

            Console.WriteLine();
            Console.WriteLine($"Resultado da soma: {resultado}");

            Console.ReadLine();



        }
    }
}
