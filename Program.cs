using System;

namespace arbete_spel1
{
    class Program
    {
        static void Main(string[] args)
        {
           Random rand = new Random();
           int guess = 0;
           string hej = "gissa ett nummer mellan 1 till 100, hoppas du lyckas gissa rätt och inte dra en rage quit =(";
           int num = rand.Next(1,100);
           Console.WriteLine(hej);


           int i = 0;

           while(guess != num)
           {
               try
               {
                   guess = Convert.ToInt32(Console.ReadLine());

                   if (guess > num)
                   {
                       Console.WriteLine("För högt testa igen");
                   }
                   else
                   {
                       Console.WriteLine("För lågt försök igen");
                   }
               }
               catch
               {             
                   
                Console.WriteLine("Du får inte skriva en bokstav, det är ett krav att skriva en siffra");
                 i--;
               }
               i++;
           }
           Console.WriteLine("bra jobbat du hade rätt det tog " + i +" försök för dig");
           Console.ReadLine();
        }

    }
}
