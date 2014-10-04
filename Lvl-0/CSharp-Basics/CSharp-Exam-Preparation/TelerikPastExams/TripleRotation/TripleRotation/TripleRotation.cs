using System;

class TripleRotation
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        if (number>=1000)
            {
                int thirdDigit = number % 10;
                number /= 10;
                int secondDigit = number % 10;
                number /= 10;
                int firstDigit = number % 10;
                number /= 10;
                if (firstDigit == 0 && secondDigit == 0 && thirdDigit == 0)
                {
                    Console.WriteLine(number);
                }
                else if (firstDigit == 0 && secondDigit == 0 && thirdDigit !=0)
                {
                    Console.WriteLine("{0}{1}",thirdDigit,number);
                }
                else if (firstDigit == 0 && secondDigit !=0 && thirdDigit != 0)
                {
                    Console.WriteLine("{0}{1}{2}",secondDigit,thirdDigit,number);
                }
                else if (firstDigit == 0 && secondDigit !=0 && thirdDigit == 0)
                {
                    Console.WriteLine("{0}{1}",secondDigit,number);
                }
                else if (firstDigit != 0 && secondDigit == 0 && thirdDigit == 0)
                {
                    Console.WriteLine("{0}{1}",firstDigit,number);
                }
                else if (firstDigit != 0 && secondDigit != 0 && thirdDigit == 0)
                {
                    Console.WriteLine("{0}{1}{2}",firstDigit,secondDigit,number);
                }
                else if (firstDigit != 0 && secondDigit == 0 && thirdDigit != 0)
                {
                    Console.WriteLine("{0}{1}{2}",firstDigit,thirdDigit,number);
                }
                else if (firstDigit != 0 && secondDigit != 0 && thirdDigit !=0)
                {
                    Console.WriteLine("{0}{1}{2}{3}",firstDigit,secondDigit,thirdDigit,number);
                }
            }
        else if (number<1000 && number >=100)
        {

            int thirdDigit = number % 10;
            number /= 10;
            int secondDigit = number % 10;
            number /= 10;
            if (thirdDigit == 0 && secondDigit == 0)
            {
                Console.WriteLine(number);
            }
            else if (thirdDigit == 0 && secondDigit !=0)
            {
                Console.WriteLine("{0}{1}",number,secondDigit);
            }
            else if (thirdDigit != 0 && secondDigit == 0)
            {
                Console.WriteLine("{0}{1}",number,thirdDigit);
            }
            else if (thirdDigit != 0 && secondDigit != 0)
            {
                Console.WriteLine("{0}{1}{2}", number,secondDigit,thirdDigit);
            }
        }
        else if (number>=10 && number<=99)
        {
            if (number % 10 != 0)
            {
            int secondDigit = number % 10;
            number /=10;
            Console.WriteLine("{0}{1}",secondDigit,number);
            }
            else
            {
                Console.WriteLine(number/10);
            }
        }
        else if (number>0 && number<10)
        {
            Console.WriteLine(number);
        }
    }
}

