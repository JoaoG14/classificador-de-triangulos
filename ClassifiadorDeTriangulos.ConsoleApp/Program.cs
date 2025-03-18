namespace ClassificadorDeTriangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                ExibirCabecalho();

                int ladoX = LerLado("X");
                int ladoY = LerLado("Y");
                int ladoZ = LerLado("Z");

                ExibirValoresInformados(ladoX, ladoY, ladoZ);

                // Criar uma instância da classe ClassificadorDeTriangulos
                ClassificadorDeTriangulos classificador = new ClassificadorDeTriangulos(ladoX, ladoY, ladoZ);

                // Obter a classificação e exibir o resultado
                string resultado = classificador.Classificar();
                Console.WriteLine(resultado);
                Console.WriteLine("------------------------------------");

                if (!DesejaContinar())
                    break;
            }
        }

        static void ExibirCabecalho()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Classificador de Triângulos");
            Console.WriteLine("------------------------------------");
        }

        static int LerLado(string nomeLado)
        {
            int lado;
            while (true)
            {
                Console.Write($"Digite o valor do lado {nomeLado}: ");
                if (int.TryParse(Console.ReadLine(), out lado))
                    return lado;

                Console.WriteLine("Valor inválido. Digite um número inteiro.");
            }
        }

        static void ExibirValoresInformados(int ladoX, int ladoY, int ladoZ)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Valores Informados:");
            Console.WriteLine($"Lado X: {ladoX}");
            Console.WriteLine($"Lado Y: {ladoY}");
            Console.WriteLine($"Lado Z: {ladoZ}");
            Console.WriteLine("------------------------------------");
        }

        static bool DesejaContinar()
        {
            Console.WriteLine("Deseja continuar? (S/N) ");
            string continuar = Console.ReadLine()?.ToUpper() ?? "N";
            return continuar == "S";
        }
    }
}