using System;

namespace SixteenSegmentConverter
{
    class Program
    {
        static int[,] usageMap = new int[,]
        {
            {0, 1, 1, 1, 1, 1, 1, 1, 0, 2, 2, 2, 2, 2, 2, 2, 0},
            {8, 11, 0, 0, 0, 0, 0, 0, 12, 0, 0, 0, 0, 0, 0, 13, 3},
            {8, 0, 11, 0, 0, 0, 0, 0, 12, 0, 0, 0, 0, 0, 13, 0, 3},
            {8, 0, 0, 11, 0, 0, 0, 0, 12, 0, 0, 0, 0, 13, 0, 0, 3},
            {8, 0, 0, 0, 11, 0, 0, 0, 12, 0, 0, 0, 13, 0, 0, 0, 3},
            {8, 0, 0, 0, 0, 11, 0, 0, 12, 0, 0, 13, 0, 0, 0, 0, 3},
            {8, 0, 0, 0, 0, 0, 11, 0, 12, 0, 13, 0, 0, 0, 0, 0, 3},
            {8, 0, 0, 0, 0, 0, 0, 11, 12, 13, 0, 0, 0, 0, 0, 0, 3},
            {0, 9, 9, 9, 9, 9, 9, 9, 0, 10, 10, 10, 10, 10, 10, 10, 0},
            {7, 0, 0, 0, 0, 0, 0, 14, 15, 16, 0, 0, 0, 0, 0, 0, 4},
            {7, 0, 0, 0, 0, 0, 14, 0, 15, 0, 16, 0, 0, 0, 0, 0, 4},
            {7, 0, 0, 0, 0, 14, 0, 0, 15, 0, 0, 16, 0, 0, 0, 0, 4},
            {7, 0, 0, 0, 14, 0, 0, 0, 15, 0, 0, 0, 16, 0, 0, 0, 4},
            {7, 0, 0, 14, 0, 0, 0, 0, 15, 0, 0, 0, 0, 16, 0, 0, 4},
            {7, 0, 14, 0, 0, 0, 0, 0, 15, 0, 0, 0, 0, 0, 16, 0, 4},
            {7, 14, 0, 0, 0, 0, 0, 0, 15, 0, 0, 0, 0, 0, 0, 16, 4},
            {0, 6, 6, 6, 6, 6, 6, 6, 0, 5, 5, 5, 5, 5, 5, 5, 0}
        };

        static int[] EncodeAsSixteenSegmentsVector(char c)
        {
            switch (c)
            {
                case '[':
                    return new int[] { 1, 0, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 1, 1, 0, 1 };
                case ']':
                    return new int[] { 0, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 1, 1, 0, 1 };
                case '-':
                    return new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1 };
                case '=':
                    return new int[] { 1, 1, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1 };
                case '0':
                    return new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 1, 1 };
                case '1':
                    return new int[] { 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1};
                case '2':
                    return new int[] { 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 1, 1, 1, 1, 1 };
                case '3':
                    return new int[] { 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1 };
                case '4':
                    return new int[] { 1, 1, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1 };
                case '5':
                    return new int[] { 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1 };
                case '6':
                    return new int[] { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1 };
                case '7':
                    return new int[] { 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
                case '8':
                    return new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1 };
                case '9':
                    return new int[] { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1 };
                case 'A':
                    return new int[] { 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1 };
                case 'b':
                    return new int[] { 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1 ,1 , 0, 1 };
                case 'C':
                    return new int[] { 0, 0, 1, 1, 0, 0, 0, 0 , 1, 1, 1, 1, 1, 1, 1, 1 };
                case 'c':
                    return new int[] { 1, 1, 1, 1, 1, 0, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
                case 'd':
                    return new int[] { 1, 1, 0, 0, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 1 };
                case 'E':
                    return new int[] { 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1 };
                case 'F':
                    return new int[] { 0, 0, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1 };
                case 'H':
                    return new int[] { 1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, };
                case 'h':
                    return new int[] { 1, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1 };
                case 'L':
                    return new int[] { 1, 1, 1, 1, 0, 0, 0, 0, 1 ,1 ,1, 1, 1, 1, 1, 1, 1, 1 };
                case 'o':
                    return new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1 ,1 };
                case 'r':
                    return new int[] { 1, 1, 1, 1, 1, 1, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1 };
                case 't':
                    return new int[] { 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1 };
                case 'U':
                    return new int[] { 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1 };
                case 'u':
                    return new int[] { 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 1 };
                default:
                    return new int[] { 1, 1, 1, 1, 1, 1, 1 };
            }
        }

        static void PrintVector(int[] segments)
        {
            Console.Write("SEGMENTS ENCODING: ");
            foreach (int s in segments)
            {
                Console.Write(s);
            }
            Console.WriteLine();
        }

        static void PrintSegmentsWithStars(int[] segments)
        {
            Console.WriteLine();
            for (int i = 0; i <= 16; i++)
            {
                for (int j = 0; j <= 16; j++)
                {
                    if (usageMap[i, j] == 0)
                        Console.Write(" ");
                    else
                    {
                        if (segments[usageMap[i, j] - 1] == 1)
                            Console.Write(" ");
                        else
                            Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void PrintSegmentsWithStarsByRows(int[] segments, int row)
        {
            for (int j = 0; j < 17; j++) // Adjusted loop condition to j < 17
            {
                if (usageMap[row, j] == 0)
                    Console.Write(" ");
                else
                {
                    if (usageMap[row, j] > segments.Length) // Added check to ensure index is within range
                        Console.Write("*"); // If index is out of range, print '*'
                    else if (segments[usageMap[row, j] - 1] == 1)
                        Console.Write(" ");
                    else
                        Console.Write("*");
                }
            }
        }


        static bool IsAllowedCharacter(char c)
        {
            switch (c)
            {
                case '[':
                case ']':
                case '-':
                case '=':
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case 'A':
                case 'b':
                case 'C':
                case 'c':
                case 'd':
                case 'E':
                case 'F':
                case 'H':
                case 'h':
                case 'L':
                case 'o':
                case 'r':
                case 't':
                case 'U':
                case 'u':
                    return true;
                default:
                    return false;
            }
        }

        static void MainOnByOne()
        {
            string txt;
            int[] segments;

            Console.WriteLine("Enter a text:");
            Console.WriteLine("(Printable characters: []-=0123456789AbCcdEFHhLortUu):");
            txt = Console.ReadLine();

            foreach (char c in txt)
            {
                if (IsAllowedCharacter(c))
                {
                    segments = EncodeAsSixteenSegmentsVector(c);
                    PrintVector(segments);
                    PrintSegmentsWithStars(segments);
                }
                else
                {
                    Console.WriteLine("Error: This character is not allowed!");
                }
            }

            Console.WriteLine();
            Console.Write("Press [Enter] to close the app");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            string txt;
            int[] segments;

            Console.WriteLine("Enter a text:");
            Console.WriteLine("(Printable characters: []-=0123456789AbCcdEFHhLortUu):");
            txt = Console.ReadLine();

            Console.WriteLine();
            for (int row = 0; row <= 16; row++)
            {
                foreach (char c in txt)
                {
                    segments = EncodeAsSixteenSegmentsVector(c);
                    PrintSegmentsWithStarsByRows(segments, row);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("Press [Enter] to close the app");
            Console.ReadLine();
        }

    }
}
