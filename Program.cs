using System.Globalization;

/*
Entrada de dados
    Array
    ReadLine()
Operação
    For()
    Media
Saída de Dados
    WriteLine
*/

namespace VetoresEmCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULE A MÉDIA DE ALTURA");
            Console.WriteLine();

            Console.Write("Informe quantas alturas serão calculadas: ");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for(int i = 0; i < n; i++)
            {
                Console.Write("Informe uma altura: ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            }

            double sum = 0.0;

            for(int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            double avg = sum / n;

            Console.WriteLine("Average height: " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}