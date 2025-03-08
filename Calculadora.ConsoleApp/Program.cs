namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("_________________________");
            Console.WriteLine("Calculadora Tabajara 2025");
            Console.WriteLine("_________________________");

            Console.WriteLine("Digite 1 para somar: ");
            Console.WriteLine("Digite 2 para subtrair: ");
            Console.WriteLine("Digite 3 para multiplicar: ");
            Console.WriteLine("Digite 4 para dividir: ");
            Console.WriteLine("Digite S para sair: ");

            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine().ToUpper();
          

            if (opcao == "S" || opcao == "s") {
                return;

            }
            
            Console.Write("Digite o primeiro número: ");
          
            string primeironumerostring = Console.ReadLine();
            int  primeironumero = Convert.ToInt32(primeironumerostring);
            
            Console.Write("Digite o segundo número: ");

            string segundonumerostring = Console.ReadLine();
            int segundonumero = Convert.ToInt32(segundonumerostring);

            int resultado = 0;
            if (opcao == "1") ;
            {
                 resultado = (primeironumero + segundonumero);
                
            }                        
         
            if (opcao == "2") ;
            {
                 resultado = (primeironumero - segundonumero);

            }
            
            if (opcao == "3") ;
            {
                 resultado = (primeironumero * segundonumero);

            }         
            if (opcao == "4") ;
            {
                 resultado = (primeironumero / segundonumero);
            }

            Console.WriteLine("Resultado: " + resultado);


            Console.ReadLine();





        }
    }
}
