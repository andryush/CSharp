using System;

namespace chess
{
    class Program
    {
       static string[,] chessFigures = {
                                 { "♜", "♞", "♝", "♚", "♛", "♝", "♞", "♜" },
                                 { "♟", "♟", "♟", "♟", "♟", "♟", "♟", "♟" },
                                 { "♖ ", " ", " ", " ", " ", " ", " ", " " },
                                 { " ", " ", " ", " ", " ", " ", " ", " " },
                                 { " ", " ", " ", " ", " ", " ", " ", " " },
                                 { " ", " ", " ", " ", " ", " ", " ", " " },
                                 { "♙", "♙", "♙", "♙", "♙", "♙", "♙", "♙" },
                                 { "♖", "♘", "♗", "♔", "♕", "♗", "♘", "♖" }
                               };

        static void Main(string[] args)
        {
            int n = 8;
            string board = "";
            string chess = "";
            //string[] figures = { "♜", "♞", "♝", "♚", "♛", "♝", "♞", "♜" };

            //nkarec board@

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
            Console.Write(board);

            //qayl anel
            qaylAnel(0, 1, 2, 0);


            // nkarel figurner@
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    chess += chessFigures[i, j] + " ";
                }
                chess += "\n";
            }
            Console.Write(chess);
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
