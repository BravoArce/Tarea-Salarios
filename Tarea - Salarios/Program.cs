using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Tarea___Salarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Contadores y Acumuladores 
            //float total;
            //float salario;
            //total = 0;

            //total += salario;//total = total + salario
            //total -=salario;//total = total - salario
            //total *=salario;//total = total * salario
            //total /=total;//total = total / salario

            //Arreglos y matrices
            int[] edad = new int[] { 20, 30, 40 };
            float[] salario = new float[] { 200, 300, 400 };
            String[] musico = new String[3];
            musico[0] = "Ringo:";
            musico[1] = "Paul:";
            musico[2] = "John:";

            Console.WriteLine(musico.Length);

            //Ciclo for
            for (int i = 0; i < musico.Length; i++)
            {
                double total = 0;
                float IVA = 0;
                total = salario[i] - (salario[i] * 0.13);
                Console.WriteLine($"{musico[i]} Edad {edad[i]} años, Salario {salario[i]}mil, IVA {salario[i] * 0.13}mil, Total " + total + "mil");

            }

            Console.ReadLine();
        }
    }
}
