using System;
using System.Collections.Generic;
using System.Collections;


namespace collections
{
    class Program
    {
        public List<string> anunner = new List<string>();
        public List<int> tver = new List<int>();

        public ArrayList myArrayList = new ArrayList();

        static void Main(string[] args)
        {
            Program program = new Program();
            program.anunner.Add("Andrey");
            program.anunner.Add("Gagik");

            program.tver.Add(33);
            program.tver.Add(73);

            program.myArrayList.Add(3);
            program.myArrayList.Add(7);
            program.myArrayList.Add("stringType");


            program.AnunnerLoop();
            program.TverLoop();

            program.ArrayListLoop();
            //program.myArrayList.

        }


        public void AnunnerLoop()
        {
            foreach (string i in anunner)
            {
                Console.WriteLine(i);
            }
        }

        public void TverLoop()
        {
            foreach (int i in tver)
            {
                Console.WriteLine(i);
            }
        }

        public void ArrayListLoop()
        {
            foreach (dynamic i in myArrayList)
            {
                Console.WriteLine(i);
            }
        }
    }
}
