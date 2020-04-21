using System;
using System.Collections.Generic;

namespace Nose_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //ÖVNING 1
            string[] TOYs = { "toy car", "toy robot", "toy doll", "toy plane", "toy hero" };//array med 5 olika leksaker.
            int rng = 0;//talet börjar med 0 då arrayer alltid läser av första platsen som 0
            
            for (int i = 0; i < 5; i++)
                {
                
                string TOY = TOYs[rng];//den TOY som kallas är talet som rng är.
                Console.WriteLine(TOY);
                Console.ReadLine();
                rng++;//efter varje gång adderas +1 till inten och då läser stringen en ny plats på arrayen.
                }


            string[] classmates = { "Collin", "Theodore", "Sebastian", "Benjamin", "Simon" };
            int[] numbers = { 3, 5, 7, 8, 9};
        }
    }
}
