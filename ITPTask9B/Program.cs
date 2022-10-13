using ITPTask9B;
using System;

bool stillMore;
double lenght, breadth, height; 

do
{
    Console.Write("Input the lenght, please: ");
    string received = Console.ReadLine();
    //Should be of right data type and a positive value
    while(!Double.TryParse(received, out lenght) || lenght < 0)
    {
        Console.Write("Not accepted, concentrate: ");
        received = Console.ReadLine();
    }

    Console.Write("Input the breadth, please: ");
    received = Console.ReadLine();
    //Should be of right data type and a positive value
    while (!Double.TryParse(received, out breadth) || breadth < 0) 
    {
        Console.Write("Not accepted, concentrate: ");
        received = Console.ReadLine();
    }

    Console.Write("Input the height, please: ");
    received = Console.ReadLine();
    //Should be of right data type and a positive value
    while (!Double.TryParse(received, out height) || height < 0) 
    {
        Console.Write("Not accepted, concentrate: ");
        received = Console.ReadLine();
    }
    //Perfect information available:
    Room_ room = new Room_(lenght, breadth, height);

    Console.WriteLine("There area of the floor is {0:F3}.", room.CalculateFloorArea());
    Console.WriteLine("The area of the walls is {0:F3}.", room.CalculateWallArea());

    Console.Write("More of this (Y/N): ");
    string decision = Console.ReadLine().ToUpper();
    if (decision.StartsWith("Y)"))
        stillMore = true;
    else
        stillMore = false;
}while(stillMore);