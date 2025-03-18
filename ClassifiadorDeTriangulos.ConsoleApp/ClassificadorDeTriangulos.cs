using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassificadorDeTriangulos.ConsoleApp
{
    public class ClassificadorDeTriangulos
    {
        public int LadoX { get; set; }
        public int LadoY { get; set; }
        public int LadoZ { get; set; }

        public ClassificadorDeTriangulos(int ladoX, int ladoY, int ladoZ)
        {
            LadoX = ladoX;
            LadoY = ladoY;
            LadoZ = ladoZ;
        }

        public bool EhTriangulo()
        {
            return (LadoX + LadoY > LadoZ) &&
                   (LadoX + LadoZ > LadoY) &&
                   (LadoY + LadoZ > LadoX);
        }

        public string Classificar()
        {
            if (!EhTriangulo())
                return "Não é um Triângulo";

            if (LadoX == LadoY && LadoY == LadoZ)
                return "Triângulo Equilátero";

            if (LadoX == LadoY || LadoX == LadoZ || LadoY == LadoZ)
                return "Triângulo Isósceles";

            return "Triângulo Escaleno";
        }
    }
}
