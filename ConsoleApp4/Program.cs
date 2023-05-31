using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXERCICIO1
            //int[] vet2;
            //float media = 0;
            //Console.WriteLine("entre com um tamanho");
            //int T = int.Parse(Console.ReadLine());

            //vet2 = new int[T];
            //Random rand = new Random();


            //for (int i = 0; i < T; i++)
            //{
            //    vet2[i] = rand.Next(10, 50);
            //    media = media + vet2[i];
            //}
            //for (int i = 0; i < T; i++)
            //{
            //    Console.WriteLine("posição[{0}] = {1}", i, vet2[i]);
            //}
            //Console.WriteLine(media / (float)T);
            //Console.ReadKey();




            //EXERCICIO2
            //int[] vet2;
            //float media = 0, numPar = 0, numImpar = 0;
            //Console.WriteLine("entre com um tamanho");
            //int T = int.Parse(Console.ReadLine());

            //vet2 = new int[T];
            //Random rand = new Random();


            //for (int i = 0; i < T; i++)
            //{
            //    vet2[i] = rand.Next(10, 50);

            //    if (vet2[i] % 2 == 0)
            //    {
            //        numPar = numPar + vet2[i];
            //    }
            //    else
            //        numImpar = numImpar + vet2[i];

            //}
            //for (int i = 0; i < T; i++)
            //{
            //    Console.WriteLine("posição[{0}] = {1}", i, vet2[i]);
            //}
            //Console.WriteLine("Os numeros pares são " + numPar + "os numeros impares são " + numImpar);
            //Console.ReadKey();



            //EXERCICIO3
            //int[] vet2;
            //float media = 0;
            //Console.WriteLine("entre com um tamanho");
            //int T = int.Parse(Console.ReadLine());

            //vet2 = new int[T];
            //Random rand = new Random();


            //for (int i = 0; i < T; i++)
            //{
            //    vet2[i] = rand.Next(10, 50);
            //    Console.WriteLine("posição[{0}] = {1}", i, vet2[i]);
            //}


            //for (int i = T-1; i >= 0; i--)
            //{
            //    Console.WriteLine("posição[{0}] = {1}", i, vet2[i]  );
            //}

            //Console.ReadKey();

            //EXERCICIO4


            int[] vet2;
            float media = 0, numPar = 0, numImpar = 0;
            Console.WriteLine("entre com um tamanho");
            int T = int.Parse(Console.ReadLine());

            vet2 = new int[T];
            Random rand = new Random();
            int cont = 0;

            for (int i = 0; i < T; i++)
            {
                vet2[i] = rand.Next(10, 50);

                if (vet2[i] % 3 == 0 && vet2[i] % 5 == 0)
                {
                    numPar = numPar + vet2[i];
                    cont++;
                }
              
            }
            for (int i = 0; i < T; i++)
            {
                Console.WriteLine("posição[{0}] = {1}", i, vet2[i]);
            }
            Console.WriteLine("Os numeros pares são " + numPar /(float)cont);
            Console.ReadKey();









        }
    }
}
