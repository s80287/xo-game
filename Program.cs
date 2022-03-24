using System;

namespace xo_game
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaration
            char[,] list = new char[3, 3];
            int i = 0;

            display(list);

            while (i < 4)
            {
                markX(list);
                display(list);
                if (doesXWin(list))
                {
                    Console.WriteLine("X wins");
                    break;
                }
                markO(list);
                display(list);
                if (doesOWin(list))
                {
                    Console.WriteLine("O wins");
                    break;
                }
                i++;
            }

            if (i == 4)
            {
                Console.WriteLine("Draw");
            }

        }

        static void markX(char[,] list)
        {
            int row, column;

            // Player x turn 1
            // Input row, column
            Console.WriteLine("Player x enter move");
            Console.Write("Row: ");
            row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Column: ");
            column = Convert.ToInt32(Console.ReadLine());
            list[row - 1, column - 1] = 'x';
        }

        static void markO(char[,] list)
        {
            int row, column;

            // Player x turn 1
            // Input row, column
            Console.WriteLine("Player o enter move");
            Console.Write("Row: ");
            row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Column: ");
            column = Convert.ToInt32(Console.ReadLine());
            list[row - 1, column - 1] = 'o';
        }

        // Graph display
        static void display(char[,] list)
        {
            int j, k;

            for (j = 0; j < 3; j++)
            {
                for (k = 0; k < 3; k++)
                {
                    Console.Write("| " + list[j, k]);
                }
                Console.WriteLine("\n");
            }
        }

        static Boolean doesXWin(char[,] list)
        {
            if (list[0, 0] == 'x' && list[0, 1] == 'x'
                && list[0, 2] == 'x')
            {
                return true;
            }
            else if (list[1, 0] == 'x' && list[1, 1] == 'x'
                && list[1, 2] == 'x')
            {
                return true;
            }
            else if (list[2, 0] == 'x' && list[2, 1] == 'x'
                && list[2, 2] == 'x')
            {
                return true;
            }
            else if (list[0, 0] == 'x' && list[1, 0] == 'x'
                && list[2, 0] == 'x')
            {
                return true;
            }
            else if (list[0, 1] == 'x' && list[1, 1] == 'x'
                && list[2, 1] == 'x')
            {
                return true;
            }
            else if (list[0, 2] == 'x' && list[1, 2] == 'x'
                && list[2, 2] == 'x')
            {
                return true;
            }
            else if (list[0, 0] == 'x' && list[1, 1] == 'x'
                && list[2, 2] == 'x')
            {
                return true;
            }
            else if (list[0, 2] == 'x' && list[1, 1] == 'x'
                && list[2, 0] == 'x')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static Boolean doesOWin(char[,] list)
        {
            if (list[0, 0] == 'o' && list[0, 1] == 'o'
                && list[0, 2] == 'o')
            {
                return true;
            }
            else if (list[1, 0] == 'o' && list[1, 1] == 'o'
                && list[1, 2] == 'o')
            {
                return true;
            }
            else if (list[2, 0] == 'o' && list[2, 1] == 'o'
                && list[2, 2] == 'o')
            {
                return true;
            }
            else if (list[0, 0] == 'o' && list[1, 0] == 'o'
                && list[2, 0] == 'o')
            {
                return true;
            }
            else if (list[0, 1] == 'o' && list[1, 1] == 'o'
                && list[2, 1] == 'o')
            {
                return true;
            }
            else if (list[0, 2] == 'o' && list[1, 2] == 'o'
                && list[2, 2] == 'o')
            {
                return true;
            }
            else if (list[0, 0] == 'o' && list[1, 1] == 'o'
                && list[2, 2] == 'o')
            {
                return true;
            }
            else if (list[0, 2] == 'o' && list[1, 1] == 'o'
                && list[2, 0] == 'o')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
