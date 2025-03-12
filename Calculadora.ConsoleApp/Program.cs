using System.ComponentModel.Design;
using System.Linq.Expressions;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] historicoOperacoes = new string[100];
            int contadorHistorico = 0;


            while (true)
            {
                Console.Clear();
                Console.WriteLine("Calculadora Tabajara 2025");
                Console.WriteLine("_________________________");

                Console.WriteLine("Digite 1 para somar: ");
                Console.WriteLine("Digite 2 para subtrair: ");
                Console.WriteLine("Digite 3 para multiplicar: ");
                Console.WriteLine("Digite 4 para dividir: ");
                Console.WriteLine("Digite 5 para tabuada: ");
                Console.WriteLine("Digite 6 Histórico de Operações: ");
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

                else if (opcao == "6")
                {
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("Histórico de Operações");
                    Console.WriteLine("--------------------------------");

                    for (int contador = 0; contador < historicoOperacoes.Length; contador++)
                    {
                        string valorAtual = historicoOperacoes[contador];

                        if (valorAtual != null)
                            Console.WriteLine(valorAtual);
                    }

                    Console.WriteLine("Aperte ENTER para continuar");
                    Console.ReadLine();
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
                    historicoOperacoes[contadorHistorico] = $"{primeiroNumero} + {segundoNumero} = {resultado}";
                }
                else if (opcao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                    historicoOperacoes[contadorHistorico] = $"{primeiroNumero} - {segundoNumero} = {resultado}";

                }
            
                else if (opcao == "3")
                {
                    resultado = primeiroNumero * segundoNumero;
                    historicoOperacoes[contadorHistorico] = $"{primeiroNumero} * {segundoNumero} = {resultado}";
                }
                else if (opcao == "4")
                {

                    while(segundoNumero == 0)
                    {

                        Console.Write("Não é possível dividir por zero, digite o número novamente: ");
                        segundoNumero = Convert.ToDecimal (Console.ReadLine());

                    }
                    resultado = primeiroNumero / segundoNumero;
                    historicoOperacoes[contadorHistorico] = $"{primeiroNumero} / {segundoNumero} = {resultado}";

                }

                contadorHistorico += 1;

                Console.WriteLine("--------------------------------");
                Console.WriteLine("Resultado: " + resultado.ToString("F2"));
                Console.WriteLine("--------------------------------");

                //-----------------------------------------------------------------------

                

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
