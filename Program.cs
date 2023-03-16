using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //нахождение макслимального значения
            int[] array = {8,-1,4,16,-5,3};
            int max = array[0];
            int min = array[0];
            int indexMax = 0;
            int indexMin = 0;
            for(int i=1;i<array.Length;i++)
            {
             if (array[i]>max)
                    if (array[i]<=-100)
                {
                    max = array[i];
                    indexMax = i;
                }
                if (array[i] < min)
                {
                    min = array[i];
                    indexMin = i;
                        }
            }
            Console.WriteLine($"max={max}\tindexMax={indexMax}");
            Console.WriteLine($"min={min}\tindexMin={indexMin}");
            Console.ReadLine();
            
        }
    }
}
