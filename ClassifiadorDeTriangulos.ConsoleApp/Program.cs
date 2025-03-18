namespace ClassifiadorDeTriangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while(true)
            {

                Console.Clear();
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Classificador de Triângulos");
                Console.WriteLine("------------------------------------");

                int ladoX;
                int ladoY;
                int ladoZ;

                while (true)
                {
                    Console.Write("Digite o valor do lado X: ");
                    bool conseguiuConverter = int.TryParse(Console.ReadLine(), out ladoX);
                    if (conseguiuConverter)
                        break;
                }

                while (true)
                {
                    Console.Write("Digite o valor do lado Y: ");
                    bool conseguiuConverter = int.TryParse(Console.ReadLine(), out ladoY);
                    if (conseguiuConverter)
                        break;
                }

                while (true)
                {
                    Console.Write("Digite o valor do lado Z: ");
                    bool conseguiuConverter = int.TryParse(Console.ReadLine(), out ladoZ);
                    if (conseguiuConverter)
                        break;
                }


                Console.WriteLine("------------------------------------");
                Console.WriteLine("Valores Informados:");
                Console.WriteLine($"Lado X: {ladoX}");
                Console.WriteLine($"Lado Y: {ladoY}");
                Console.WriteLine($"Lado Z: {ladoZ}");
                Console.WriteLine("------------------------------------");


                if (ladoX + ladoY < ladoZ || ladoX + ladoZ < ladoY || ladoY + ladoZ < ladoX)
                {
                    Console.WriteLine("É um Triângulo");
                }
                else if (ladoX == ladoY && ladoY == ladoZ)
                {
                    Console.WriteLine("Triângulo Equilátero");
                }
                else if (ladoX == ladoY || ladoX == ladoZ || ladoY == ladoZ)
                {
                    Console.WriteLine("Triângulo Isósceles");
                }
                else
                {
                    Console.WriteLine("Não é um Triângulo");
                }


                Console.WriteLine("------------------------------------");
                Console.WriteLine("Deseja continuar? (S/N) ");
                string continuar = Console.ReadLine()!.ToUpper();


                if (continuar == "N")
                    break;
            }
            
        }
    }
}
