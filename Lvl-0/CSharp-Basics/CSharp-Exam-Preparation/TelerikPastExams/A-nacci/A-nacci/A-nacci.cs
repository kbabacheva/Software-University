using System;

class Anacci
{
    static void Main()
    {
        int shift = 64;
        string firstNumber = Console.ReadLine();
        int first = firstNumber[0] - shift;
        string secondNumber = Console.ReadLine();
        int second = secondNumber[0] - shift;
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine((char)(first + shift));
        if (rows>1)
	    {
		    int next = first + second;
            if (next > 26)
            {
                next %= 26;
            }
            string result = ((char)(second + shift)).ToString() + ((char)(next + shift)).ToString();
            Console.WriteLine(result);
            first = second;
            second = next;

            for (int i = 3; i <= rows; i++)
		    {
                next = first + second;
                if (next > 26)
                {
                    next %= 26;
                }
                first = second;
                second = next;
                next = first + second;
                if (next > 26)
                {
                    next %= 26;
                }
                first = second;
                second = next;
                Console.Write((char)(first + shift));
                Console.Write(new String(' ', i - 2));
                Console.WriteLine((char)(second+shift));
		    }
	    }
    }
}

