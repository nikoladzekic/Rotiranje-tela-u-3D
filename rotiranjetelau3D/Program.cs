using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rotiranjetelau3D
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double[,] A,B;
            double[,] Rx;
            int i = 0, j = 0, x, k;
            double cos, sin;
           Console.WriteLine("Unesi broj vrsta matrice: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi stepen rotacije: ");
            double stepen = double.Parse(Console.ReadLine());
            /////Konverzija u radijane, jer Math.Cos ne radi sa stepenima
            cos = Math.Cos(stepen * (Math.PI / 180));
            sin = Math.Sin(stepen * (Math.PI / 180));
            ////////////////
            A = new double[n, 3];
            B = new double[n, 3];
            Rx = new double[3, 3] { { 1, 0, 0 }, { 0, cos, sin*(-1)}, { 0, sin, cos } };////Definisanje Rx matrice sa pomocu koje se radi rotacija
            
            for (i = 0; i < n; i++)
            {
                k = i + 1;// da ne bi pisalo 0 koodrinata
                for (j=0;j<3;j++)
                {
                    x = j + 1; //da ne bi pisalo 0 tacka   
                    Console.WriteLine("Unesi " + k + ". koordinate " + x + ". tacke: ");
                    A[i, j] = int.Parse(Console.ReadLine());   
                }
            }
            Console.WriteLine("Koordinate novodobijenog tela su: ");
            for (i = 0; i < n; i++)
            {
               
                for (j = 0; j < 3; j++)
                {
                    Console.Write(A[i,j] + "\t");

                }
                Console.WriteLine();
            }
            //////////// Mnozenje matrica ////////////
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    B[i, j] = 0;
                    for (k = 0; k < 3; k++)
                    {
                        B[i, j] += A[i, k] * Rx[k, j];
                    }
                }
            }


            /////////////Ispis Rx matrice/////////
            Console.WriteLine();
            Console.WriteLine("matrica rx je: ");

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write(Rx[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Nove koordinate kvadra pomerenog za: " + stepen + " stepeni su: ");

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write(B[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
