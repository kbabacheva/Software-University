using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace JustCars
{
    struct Object
    {
        public int x;
        public int y;
        public char c;
        public ConsoleColor color;
    }

    class JustCars
    {
        static void PrintOnPosition(int x, int y, char c,
            ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(c);
        }

        static void PrintStringOnPosition(int x, int y, string str,
            ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(str);
        }

        static void Main()
        {
            Console.WriteLine("You are a car @");
            Console.WriteLine("You must avoid other cars #");
            Console.WriteLine("Catching * will decrease cars speed");
            Console.WriteLine("Catching - will get you a live");
            Console.WriteLine("Move your car with left and right arrows");
            Console.WriteLine("Press any key to start the game");
            string start = Console.ReadLine();
            double speed = 100.0; // za skorost na koli4kite
            double acceleration = 0.5; // skorost na uskorenie
            int playfieldWidth = 5;
            int livesCount = 5;
            Console.BufferHeight = Console.WindowHeight = 20;
            Console.BufferWidth = Console.WindowWidth = 30;
            Object userCar = new Object();
            userCar.x = 2;
            userCar.y = Console.WindowHeight - 1;
            userCar.c = '@';
            userCar.color = ConsoleColor.Yellow;
            Random randomGenerator = new Random();
            List<Object> objects = new List<Object>();

            while (true)
            {
                if (speed > 400)
                {
                    speed = 400;
                }
                speed+= acceleration;//increasing speed
                bool hitted = false;
                {
                    int chance = randomGenerator.Next(0, 100);
                    if (chance < 10)
                    {
                        //add object
                        Object newObject = new Object();
                        newObject.color = ConsoleColor.Cyan;
                        newObject.x = randomGenerator.Next(0, playfieldWidth);//showing an object on random position
                        newObject.y = 0;
                        newObject.c = '-';
                        objects.Add(newObject);
                    }
                    else if (chance < 20)
                    {
                        // add object
                        Object newObject = new Object();
                        newObject.color = ConsoleColor.Cyan;
                        newObject.x = randomGenerator.Next(0, playfieldWidth);//showing an object on random position
                        newObject.y = 0;
                        newObject.c = '*';
                        objects.Add(newObject);
                    }
                    else
                    {
                        Object newCar = new Object();
                        newCar.color = ConsoleColor.Green;
                        newCar.x = randomGenerator.Next(0, playfieldWidth);//showing a car on random position
                        newCar.y = 0;
                        newCar.c = '#';
                        objects.Add(newCar);
                    }
                }
                while (Console.KeyAvailable) // switch if with while for better maneuverability
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                   // while (Console.KeyAvailable) Console.ReadKey(true);//while button is pressed to move the car
                    if (pressedKey.Key == ConsoleKey.LeftArrow)
                    {
                        if (userCar.x - 1 >= 0)
                        {
                            userCar.x--;
                        }
                    }
                    else if (pressedKey.Key == ConsoleKey.RightArrow)
                    {
                        if (userCar.x + 1 < playfieldWidth)
                        {
                            userCar.x++;
                        }
                    }
                }
                List<Object> newList = new List<Object>();
                for (int i = 0; i < objects.Count; i++)//falling of the cars
                {
                    Object oldCar = objects[i];
                    Object newObject = new Object();
                    newObject.x = oldCar.x;
                    newObject.y = oldCar.y + 1;
                    newObject.c = oldCar.c;
                    newObject.color = oldCar.color;
                    if (newObject.c == '-' && newObject.y == userCar.y && newObject.x == userCar.x)
                    {
                        livesCount++; // if we catch it, we get a life
                    }
                    if (newObject.c == '*' && newObject.y == userCar.y && newObject.x == userCar.x)
                    {
                        speed -= 20; // if we catch it, speed decreases with 20
                    }
                    if (newObject.c == '#' && newObject.y == userCar.y && newObject.x == userCar.x)//thats how we die
                    {
                        livesCount--;
                        hitted = true;
                        speed += 50; //when we die, increase the speed with 50
                        if (speed > 400)
                        {
                            speed = 400;
                        }
                        if (livesCount <=0)
                        {
                            PrintStringOnPosition(8, 10, "GAME OVER!", ConsoleColor.Red);
                            PrintStringOnPosition(8, 12, "Press [Enter] to exit", ConsoleColor.Red);//when lives are over, game over
                            Console.ReadLine();
                            Environment.Exit(0);
                        }
                    }
                    if (newObject.y < Console.WindowHeight)
                    {
                        newList.Add(newObject);
                    }
                }
                objects = newList; //old list to have the same objects are new list
                Console.Clear();
                if (hitted)
                {
                    objects.Clear(); //clear all objects when hitted
                    PrintOnPosition(userCar.x, userCar.y, 'X', ConsoleColor.Red);
                }
                else
                {
                    PrintOnPosition(userCar.x, userCar.y, userCar.c, userCar.color);
                }
                foreach (Object car in objects)
                {
                    PrintOnPosition(car.x, car.y, car.c, car.color);
                }
                PrintStringOnPosition(8, 4, "Lives: " + livesCount, ConsoleColor.White);
                PrintStringOnPosition(8, 5, "Speed: " + speed, ConsoleColor.White);
                PrintStringOnPosition(8, 6, "Acceleration: " + acceleration, ConsoleColor.White);
                // Console.Beep(); if i want to add a sound
                Thread.Sleep((int)(600 - speed));
            }
        }
    }
}
