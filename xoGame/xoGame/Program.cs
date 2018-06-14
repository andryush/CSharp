﻿using System;

namespace xoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int movesDone = 0;
            bool winner = true;
            char player = 'X';
            char[,] board = new char[3, 3];

            Initialize(board);
            


            while(winner)
            {
                Console.Clear();
                Print(board);
                Console.Write("Please enter a row: ");
                int i = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please enter a col: ");
                int j = Convert.ToInt32(Console.ReadLine());

                board[i, j] = player;

                if (player == board[0, 0] && player == board[0, 1] && player == board[0, 2] ||
                    player == board[1, 0] && player == board[1, 1] && player == board[1, 2] ||
                    player == board[2, 0] && player == board[2, 1] && player == board[2, 2] ||
                    player == board[0, 0] && player == board[0, 1] && player == board[0, 2] ||
                    player == board[1, 0] && player == board[1, 1] && player == board[1, 2] ||
                    player == board[2, 0] && player == board[2, 1] && player == board[2, 2] ||
                    player == board[0, 0] && player == board[1, 1] && player == board[2, 2] ||
                    player == board[0, 2] && player == board[1, 1] && player == board[2, 0])
                {
                    Console.WriteLine(player + " win the game");
                    winner = false;
                }
                movesDone += 1;
                if (movesDone == 9)
                {
                    Console.WriteLine("It's a DRAW");
                    winner = false;
                }
                
                player = ChangePlayer(player);
                

                
            }
            Console.ReadLine();

        }

        static char ChangePlayer(char currentPlayer)
        {
            if (currentPlayer == 'X')
            {
                return 'O';
            }
            else
            {
                return 'X';
            }
        }

        static void Initialize(char[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = ' ';
                }
            }
        }

        static void Print(char[,] board)
        {
            Console.WriteLine("  | 0 | 1 | 2 |");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i + " | ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
        }
        
    }
}
