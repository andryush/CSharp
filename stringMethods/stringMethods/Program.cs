using System;

namespace stringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstText = "When an Eastern sage was desired by his sultan to inscribe on a ring the sentiment which, amidst the perpetual change of human affairs, was most descriptive of their real tendency, he engraved on it the words. And this, too, shall pass away. It is impossible to imagine a thought more truly and universally applicable to human affairs than that expressed in these memorable words, or more descriptive of that perpetual oscillation from good to evil, and from evil to good, which from the beginning of the world has been the invariable characteristic of the annals of man, and so evidently flows from the strange mixture of noble and generous with base and selfish inclinations, which is constantly found in the children of Adam.";
            FirstText = FirstText.ToLower();
            string abc = "abcdefghijklmnopqrstuvwxyz";

            char[] AbcArray = abc.ToCharArray();
            Random rand = new Random();


            //Console.WriteLine(GenerateRandomText());
            Console.WriteLine(QtyOfChars(FirstText));
            Console.WriteLine(QtyOfChars(GenerateRandomText()));
            PrintStars(QtyOfChars(FirstText));
            Console.WriteLine("_____________");
            PrintStars(QtyOfChars(GenerateRandomText()));



          

            void PrintStars(int[] masiv)
            {
                foreach(int x in masiv)
                {
                    string astx = "";
                    for (int i = 0; i < x; i++)
                    {
                        astx += "*";
                    }
                    Console.WriteLine(astx);

                }

            }

            int[] QtyOfChars(string text)
            {
                int[] QtChar = new int[AbcArray.Length];
                for (int i = 0; i < AbcArray.Length; i++)
                {
                    int index = text.IndexOf(AbcArray[i]);
                    int qty = 0;


                    do
                    {
                        if (index != -1)
                        {
                            index++;
                            qty++;
                            index = text.IndexOf(AbcArray[i], index);
                            //Console.Write(index);
                        }

                    }
                    while (index != -1);
                    Console.WriteLine(AbcArray[i] + "=" + qty);
                    QtChar[i] = qty;


                }
                return QtChar;
            }

            string GenerateRandomText()
            {
                string RandomText = "";

                for (int i = 0; i < FirstText.Length; i++)
                {
                    int r = rand.Next(0, 26);
                    if (r % 5 == 0)
                    {
                        RandomText += " ";
                    }
                    else
                    {
                        RandomText += abc[r];
                    }

                }

                return RandomText;
            }


        }
    }
}
