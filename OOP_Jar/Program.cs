using System;

public class Program
{
    public static void Main(string[] args)
    {
         int[,] Matric = {
            { 0,0,0,0,0,0,0},
            {0,0,0,0,0,0, 0},
            {0,0,0,1,0,0,0},
            {0,0,0,0,0, 0, 0},
            {0,0,0,0,0, 0, 0}

         };

          
        for (int i = 0; i <= 4; i++)
        {
            for (int j = 0; j <= 6; j++)
            {
             
                    if (Matric[i, j] == 1)
                    {
                        Matric[i - 1, j] = 1;
                         //Matric[i , j] = 1;
                        Matric[i, j - 1] = 1;
                        Matric[i, j + 1] = 1;
                 
                    }
                
                
            }
               
             

        }
        for (int i = 0; i <= 4; i++)
        {
            for (int j = 0; j <= 6; j++)
            {
                Console.Write("  " + Matric[i, j]);
            }
            Console.WriteLine();

        }


    }
    public void Nkar(int[,] Matric)
    {
        for (int i = 0; i <= 4; i++)
        {
            for (int j = 0; j <= 4; j++)
            {
                Console.Write("  " + Matric[i, j]);
            }
            Console.WriteLine();

        }
    }
}