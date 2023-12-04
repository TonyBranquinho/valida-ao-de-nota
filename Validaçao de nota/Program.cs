using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validaçao_de_nota {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double primeira, segunda, media;

            Console.Write("Digite a primeira nota: ");
            primeira = double.Parse(Console.ReadLine(), CI);
               
            while (primeira < 0 || primeira > 10) {
                Console.Write("Valor invalido! Tente novamente: ");
                primeira = double.Parse(Console.ReadLine(), CI);
            }


            Console.Write("Digite a segunda nota: ");
            segunda = double.Parse(Console.ReadLine(), CI);

            while (segunda < 0 || segunda > 10) {
                Console.Write("Valor invalido! Tente novamente: ");
                segunda = double.Parse(Console.ReadLine(), CI);
            }

            media = (primeira + segunda) / 2;

            Console.WriteLine("Media = " + media.ToString("F2", CI));
        }
    }
}
