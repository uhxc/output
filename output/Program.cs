using System;
using System.Globalization;

namespace output
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;


            Console.WriteLine($"produtos:\n{produto1}, cujo o preço é:{preco1:F2}\n{produto2}, cujo o preço é:{preco2:F2}\n");
            Console.WriteLine($"registro:\n{idade} anos, codigo é {codigo} e genero {genero}");
            Console.WriteLine($"medida com oitro casas decimais {medida:F8}\narredondado: {medida:F3}\nSeparador invariant culture {medida.ToString(CultureInfo.InvariantCulture)}");
            Console.ReadLine();

        }
    }
}
