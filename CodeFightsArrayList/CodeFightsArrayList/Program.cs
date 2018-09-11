using System;
using System.Collections;

namespace CodeFightsArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] statues = new int[] { 6, 2, 3, 8 };
            ArrayList myList = new ArrayList(statues);
            myList.Sort();

            for (int i = 0; i < myList.Count; ++i)
            {
                Console.WriteLine("COUNT - " + myList.Count);
                Console.WriteLine("i = " + i);
                if (i <= (myList.Count - 1))
                {
                    if (((int)myList[i + 1] - (int)myList[i]) == 1)
                    {
                        Console.WriteLine("OK");
                  
                    }
                    else
                    {
                        myList.Insert(i + 1, ((int)myList[i] + 1));
                    }
                    Console.WriteLine("ELEMENT = " + myList[i]);
                }


                //Console.WriteLine(myList.Count + "COUNT");
            }





            Console.WriteLine("___________");
            foreach(int i in myList)
            {
                Console.WriteLine(myList[i]);
            }

           
        }
    }
}
