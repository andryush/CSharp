using System;

namespace chess
{
    class Program
    {
       static string[,] chessFigures = {
                                 { "♜", "♞", "♝", "♚", "♛", "♝", "♞", "♜" },
                                 { "♟", "♟", "♟", "♟", "♟", "♟", "♟", "♟" },
                                 { " ", " ", " ", " ", " ", " ", " ", " " },
                                 { " ", " ", " ", " ", " ", " ", " ", " " },
                                 { " ", " ", " ", " ", " ", " ", " ", " " },
                                 { " ", " ", " ", " ", " ", " ", " ", " " },
                                 { "♙", "♙", "♙", "♙", "♙", "♙", "♙", "♙" },
                                 { "♖", "♘", "♗", "♔", "♕", "♗", "♘", "♖" }
                               };
        static int n = 8;


        static void Main(string[] args)
        {
            bool running = true;


            while(running)
            {
                string qayl = Console.ReadLine();
                char[] tver = qayl.ToCharArray();
                //Console.WriteLine(tver[0] - 97);
                //Console.WriteLine(tver[1] - 49);
                int m2 = tver[0] - 97;
                int m1 = tver[1] - 49;
                int m4 = tver[3] - 97;
                int m3 = tver[4] - 49; 


                if (qayl.Equals("quit") || qayl.Equals("exit"))
                {
                    running = false;
                }
                else 
                {
                    qaylAnel(m1, m2, m3, m4);
                }
                    





            }
            Console.WriteLine("EXIT ba dur@@@????");


            //boardNkarel();



            //figurnerNkarel();





        }



        public static void qaylAnel(int ai, int aj, int bi, int bj)
        {
            

            string oldFigure = chessFigures[bi, bj];
            chessFigures[bi, bj] = chessFigures[ai, aj];
            chessFigures[ai, aj] = " ";
            if (oldFigure != " ")
            {
                Console.WriteLine("You have got " + oldFigure);
            }
            figurnerNkarel();

        }

        public static void boardNkarel()
        {
            string board = "";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        board += " ";

                    }
                    else
                    {
                        board += "▀ ";
                    }

                }
                board += "\n";


            }
            Console.WriteLine(board);
        }// end of function boardNkarel()

        public static void figurnerNkarel()
        {
            string chess = "";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (chessFigures[i, j] != " ")
                    {
                        chess += chessFigures[i, j] + " ";
                    }
                    else
                    {
                        if ((i + j) % 2 == 0)
                        {
                            chess += "  ";

                        }
                        else
                        {
                            chess += "▀ ";
                        }   
                    }



                }
                chess += "\n";
            }
            Console.Write(chess);
        }

    }

}

/*
 int n = 3;
            string board = "";
            string num = "";
            //string[] figures = { "♜", "♞", "♝", "♚", "♛", "♝", "♞", "♜" };
            string[,] numpad = { { "1", "2", "3" }, 
                                 { "4", "5", "6" }, 
                                 { "7", "8", "9" } };

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    num += numpad[i, j];
                }
                num += "\n";
            }
            Console.Write(num);
*/
