using System;

    class NextDate
    {
        static void Main()
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
                if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10)
                {
                    if (day == 31)
                    {
                        day = 1;
                        month++;
                        Console.WriteLine("{0}.{1}.{2}", day, month, year);
                    }
                    else if (day != 31)
                    {
                        day++;
                        Console.WriteLine("{0}.{1}.{2}", day, month, year);
                    }
                }
                else if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    if (day == 30)
                    {
                        day = 1;
                        month++;
                        Console.WriteLine("{0}.{1}.{2}", day, month, year);
                    }
                    else if (day != 30)
                    {
                        day++;
                        Console.WriteLine("{0}.{1}.{2}", day, month, year);
                    }     
                }
                else if (month == 2)
                {
                    if ((year % 4 != 0 || year % 100 == 0) && year % 400 != 0)
                    {
                        if (day == 28)
                        {
                            day = 1;
                            month++;
                            Console.WriteLine("{0}.{1}.{2}",day,month,year);
                        }
                        else if (day != 28)
                        {
                            day++;
                            Console.WriteLine("{0}.{1}.{2}", day, month, year);
                        }
                    }
                    else if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                    {
                        if (day == 29)
                        {
                            day = 1;
                            month++;
                            Console.WriteLine("{0}.{1}.{2}", day, month, year);
                        }
                        else if (day != 29)
                        {
                            day++;
                            Console.WriteLine("{0}.{1}.{2}", day, month, year);
                        }
                    }
                }
                else if (month == 12)
                {
                    if (day == 31)
                    {
                        day = 1;
                        month = 1;
                        year++;
                        Console.WriteLine("{0}.{1}.{2}", day, month, year);
                    }
                    else if (day != 31)
                    {
                        day++;
                        Console.WriteLine("{0}.{1}.{2}", day, month, year);
                    }
                }
            }
        }
