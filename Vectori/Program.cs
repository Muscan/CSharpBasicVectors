using System;

using static Vectori.Vectori;

namespace Vectori
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = { 33, 32, 55, 756, 87878, 9, 0, 1, -2 };


            //afisare(v);
            v = stergere(v, 2);
            //stergere(v, 0);
            //v = inserare(v,6 , 10);
            afisare(v);
            //bubbleSort2(v);
            //Console.WriteLine(binarySearch2(v,55));
            int[] vectorX = { 1,2,3 };
            int[] vectorY = { 1,2,3,4,9};
            binarySearch508(vectorX, vectorY);





            
            

        }
    }
}
