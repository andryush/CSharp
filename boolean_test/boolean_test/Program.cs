using System;

namespace boolean_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string table = "";
            int n = 22;
            int g = 6;

            for (int i = 1; i < n; i++)
            {
                
                for (int j = 1; j < n; j++)
                {
                    
                    if((j <= g || j >= n-g) || (i <= g || i >= n-g)) 
                    {
                        table += "*";
                    }
                    else 
                    {
                        table += " ";
                    }
                }
                table += "\n";

            }
            Console.Write(table);
            int x = 25;
            int y = 35;
            bool gndak_dashti_mej_e = (x > 0 && x < 100);
            if (gndak_dashti_mej_e)
            {
                Console.WriteLine("IN AREA");   
            }

        }
    }
}
/*
 cross in the middle
 for (int i = 1; i < n; i++)
            {
                
                for (int j = 1; j < n; j++)
                {
                    
                    if(j == n/2 || i == n/2) 
                    {
                        table += "-";
                    }
                    else 
                    {
                        table += "*";
                    }
                }
                table += "\n";

            }
            Console.Write(table);

______

for (int i = 1; i < n; i++)
            {
                
                for (int j = 1; j < n; j++)
                {
                    
                    if((j <= g || j >= n-g) || (i <= g || i >= n-g)) 
                    {
                        table += "*";
                    }
                    else 
                    {
                        table += " ";
                    }
                }
                table += "\n";

            }
            Console.Write(table);

 */ 