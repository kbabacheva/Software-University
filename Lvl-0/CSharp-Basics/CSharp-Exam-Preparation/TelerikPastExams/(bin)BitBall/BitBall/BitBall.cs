using System;

class BitBall
{
    static void Main()
    {
        int fieldLenght = 8;
        int[,] matrix = new int[fieldLenght, fieldLenght];
        // first 8 numbers
        for (int i = 0; i < fieldLenght; i++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int j = 0; j < fieldLenght; j++)
            {
                int bit = (number >> j) & 1;//take the last bit from number
                //if its 0, we do nothing
                if (bit == 1)
                {
                    matrix[i, j] = 1; // its from the 1st team
                }
            }
        }
        //second 8 numbers
        for (int i = 0; i < fieldLenght; i++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int j = 0; j < fieldLenght; j++)
            {
                int bit = (number >> j) & 1;//take the last bit from number
                //if its 0, we do nothing
                if (bit == 1)
                {
                    if (matrix[i, j] == 1) //checking if second player doesnt match 1st player
                    {
                        matrix[i,j] = 0;
                    }
                    else
                    {
                        matrix[i, j] = 2;
                    }
                }
            }
        }
        int counter1 = 0;
        int counter2 = 0;
        //second player
        for (int col = 0; col < fieldLenght; col++)
        {
            for (int row = 0; row < fieldLenght; row++)
            {
                if (matrix[row,col] == 1)
                {
                    break;
                }
                else if (matrix[row,col] == 2)
                {
                    counter2++;
                    break;
                }
            }
        }
        //first player
        for (int col = 0; col < fieldLenght; col++)
        {
            for (int row = fieldLenght - 1; row >= 0; row--)
            {
                if (matrix[row, col] == 1)
                {
                    counter1++;
                    break;
                }
                else if (matrix[row, col] == 2)
                {
                    break;
                }
            }
        }
        Console.WriteLine("{0}:{1}",counter1,counter2);
    }
}

