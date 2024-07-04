using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1_26
{//pedir tres numeros y ordenarlos de forma descendente
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digita tres numeros enteros");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            ordenarNumeros(n1,n2, n3);
            ordenarnumeros1(n1,n2, n3);
            ordenarNumeros2(n1,n2, n3);
            Console.ReadKey();
        }//fin del main
        static void ordenarNumeros (int n1, int n2, int n3)
        {
            int resultado1 = n1 > n2 && n1 > n3 ? resultado1 = n1 : n2 > n1 && n2 > n3 ? resultado1 = n2 : n3 > n1 && n3 > n2 ? resultado1 = n3 : 0;
           
            Console.WriteLine("Número 1 = "+resultado1);
            
        }
        public static void ordenarnumeros1 (int n1, int n2, int n3)
        {
            int resultado2 = n1 > n2 & n1 <n3 || n1 > n3 & n1 < n2 ? resultado2 = n1 : n2 > n1 & n2 < n3 || n2 > n3 & n2 < n1 ? resultado2 = n2 : n3 > n1 & n3 < n2 || n3>n2&n3<n1 ? resultado2 = n3 : 0;
            Console.WriteLine("Número 2= "+resultado2);
        }
        static void ordenarNumeros2 (int n1, int n2, int n3)
        {
            int resultado3 = n1 < n2 && n1 < n3? resultado3=n1 : n2<n1 && n2<n3 ? resultado3 = n2 : n3 < n1 && n3 < n2 ? resultado3 = n3: 0;
            Console.WriteLine("Numero 3= "+resultado3);
        }
    }//fin de la class program
}//fin del namespace
