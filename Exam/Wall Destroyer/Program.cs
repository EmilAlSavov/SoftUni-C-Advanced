using System;

namespace Wall_Destroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] player = new int[2];

            int rotCounter = 0;
            int holeCounter = 1;

            char[,] wall = new char[size, size];
            bool isDead = false;

            for (int i = 0; i < size; i++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int j = 0; j < size; j++)
                {
                    if (input[j] == 'V')
                    {
                        player[0] = i;
                        player[1] = j;
                    }
                    wall[i, j] = input[j];
                }
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                if (command == "up")
                {
                    if (player[0] - 1 < 0)
                    {
                        continue;
                    }
                    if (wall[player[0] - 1, player[1]] == 'R')
                    {
                        Console.WriteLine("Vanko hit a rod!");
                        rotCounter++;
                        continue;
                    }
                    if (wall[player[0] - 1, player[1]] == 'C')
                    {
                        wall[player[0], player[1]] = '*';
                        wall[player[0] - 1, player[1]] = 'E';
                        player[0]--;
                        holeCounter++;
                        isDead = true;
                        break;
                    }
                    if (wall[player[0] - 1, player[1]] == '*')
                    {
                        Console.WriteLine($"The wall is already destroyed at position [{player[0] - 1}, {player[1]}]!");
                        wall[player[0], player[1]] = '*';
                        wall[player[0] - 1, player[1]] = 'V';
                        player[0]--;
                        continue;
                    }
                    wall[player[0], player[1]] = '*';
                    wall[player[0] - 1, player[1]] = 'V';
                    player[0]--;
                    holeCounter++;
                }
                if (command == "down")
                {
                    if (player[0] + 1 >= size)
                    {
                        continue;
                    }
                    if (wall[player[0] + 1, player[1]] == 'R')
                    {
                        Console.WriteLine("Vanko hit a rod!");
                        rotCounter++;
                        continue;
                    }
                    if (wall[player[0] + 1, player[1]] == 'C')
                    {
                        wall[player[0], player[1]] = '*';
                        wall[player[0] + 1, player[1]] = 'E';
                        player[0]++;
                        holeCounter++;
                        isDead = true;
                        break;
                    }
                    if (wall[player[0] + 1, player[1]] == '*')
                    {
                        Console.WriteLine($"The wall is already destroyed at position [{player[0] + 1}, {player[1]}]!");
                        wall[player[0], player[1]] = '*';
                        wall[player[0] + 1, player[1]] = 'V';
                        player[0]++;
                        continue;
                    }
                    wall[player[0], player[1]] = '*';
                    wall[player[0] + 1, player[1]] = 'V';
                    player[0]++;
                    holeCounter++;
                }
                if (command == "left")
                {
                    if (player[1]  - 1 < 0)
                    {
                        continue;
                    }
                    if (wall[player[0], player[1] - 1] == 'R')
                    {
                        Console.WriteLine("Vanko hit a rod!");
                        rotCounter++;
                        continue;
                    }
                    if (wall[player[0], player[1] - 1] == 'C')
                    {
                        wall[player[0], player[1]] = '*';
                        wall[player[0], player[1] - 1] = 'E';
                        player[1]--;
                        holeCounter++;
                        isDead = true;
                        break;
                    }
                    if (wall[player[0], player[1] - 1] == '*')
                    {
                        Console.WriteLine($"The wall is already destroyed at position [{player[0]}, {player[1] - 1}]!");
                        wall[player[0], player[1]] = '*';
                        wall[player[0], player[1] - 1] = 'V';
                        player[1]--;
                        continue;
                    }
                    wall[player[0], player[1]] = '*';
                    wall[player[0], player[1] - 1] = 'V';
                    player[1]--;
                    holeCounter++;
                }
                if (command == "right")
                {
                    if (player[1] + 1 >= size)
                    {
                        continue;
                    }
                    if (wall[player[0], player[1] + 1] == 'R')
                    {
                        Console.WriteLine("Vanko hit a rod!");
                        rotCounter++;
                        continue;
                    }
                    if (wall[player[0], player[1] + 1] == 'C')
                    {
                        wall[player[0], player[1]] = '*';
                        wall[player[0], player[1] + 1] = 'E';
                        player[1]++;
                        holeCounter++;
                        isDead = true;
                        break;
                    }
                    if (wall[player[0], player[1]  + 1] == '*')
                    {
                        Console.WriteLine($"The wall is already destroyed at position [{player[0]}, {player[1] + 1}]!");
                        wall[player[0], player[1]] = '*';
                        wall[player[0], player[1] + 1] = 'V';
                        player[1]++;
                        continue;
                    }
                    wall[player[0], player[1]] = '*';
                    wall[player[0], player[1] + 1] = 'V';
                    player[1]++;
                    holeCounter++;
                }
            }

            if (isDead)
            {
                Console.WriteLine($"Vanko got electrocuted, but he managed to make {holeCounter} hole(s).");
            }
            else
            {
                Console.WriteLine($"Vanko managed to make {holeCounter} hole(s) and he hit only {rotCounter} rod(s).");
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(wall[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
