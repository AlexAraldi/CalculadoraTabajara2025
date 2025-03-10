using System.ComponentModel.Design;
using System.Linq.Expressions;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            while(true)
            {
                Console.Clear();
                Console.WriteLine("Calculadora Tabajara 2025");
                Console.WriteLine("_________________________");

                Console.WriteLine("Digite 1 para somar: ");
                Console.WriteLine("Digite 2 para subtrair: ");
                Console.WriteLine("Digite 3 para multiplicar: ");
                Console.WriteLine("Digite 4 para dividir: ");
                Console.WriteLine("Digite 5 para tabuada: ");
                Console.WriteLine("Digite S para sair: ");

                //-----------------------------------------------------------------------

                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine().ToUpper();


                if (opcao == "S")
                {
                    break;
                }
                //-----------------------------------------------------------------------

                else if (opcao == "5")
                {

                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("Tabuada");
                    Console.WriteLine("--------------------------------");

                    Console.Write("Digite um número: ");
                    int numeroTabuada = Convert.ToInt32(Console.ReadLine());
                    for (int contador = 1; contador <= 10; contador++)
                    {
                        
                        int resultadoTabuada = numeroTabuada * contador;
                        Console.WriteLine($"{numeroTabuada} x {contador} = {resultadoTabuada}");

                        
                    }
                     Console.WriteLine("Fim da operação");
                     Console.ReadLine( );

                    continue;
                }

                    //-----------------------------------------------------------------------

                    Console.Write("Digite o primeiro número: ");

                string primeiroNumeroString = Console.ReadLine();
                decimal primeiroNumero = Convert.ToDecimal(primeiroNumeroString);

                Console.Write("Digite o segundo número: ");

                string segundoNumeroString = Console.ReadLine();
                decimal segundoNumero = Convert.ToDecimal(segundoNumeroString);

                //-----------------------------------------------------------------------

                decimal resultado = 0;
                if (opcao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;
                }
                else if (opcao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                }
                else if (opcao == "3")
                {
                    resultado = primeiroNumero * segundoNumero;
                }
                else if (opcao == "4")
                {

                    while(segundoNumero == 0)
                    {

                        Console.Write("Não é possível dividir por zero, digite o número novamente: ");
                        segundoNumero = Convert.ToDecimal (Console.ReadLine());

                    }
                    resultado = primeiroNumero / segundoNumero;


                }

                //-----------------------------------------------------------------------

                Console.WriteLine("Resultado: " + resultado);

                Console.Write("Deseja realizar nova operação? S/N ");
                string novaoperacao = Console.ReadLine().ToUpper();


                if (novaoperacao == "N")
                {                   
                    break;
                }

            }








          





        }
    }
}
