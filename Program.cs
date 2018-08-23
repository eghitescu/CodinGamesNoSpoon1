using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Don't let the machines win. You are humanity's last hope...
 **/
namespace NoSpoon1
{
class Player
{
    static void Main(string[] args)
    {
        int width = int.Parse(Console.ReadLine()); // the number of cells on the X axis
        int height = int.Parse(Console.ReadLine()); // the number of cells on the Y axis
        bool[,] initialTable = new bool[width, height];
        for (int i = 0; i < height; i++)
        {
            string line = Console.ReadLine(); // width characters, each either 0 or .
            if (line.Length != width)
                throw new ArgumentOutOfRangeException($"Line {i} does not have {width} characters");
            var lineAsChars = line.ToCharArray();
            for(int j=0;j<width;j++)
                initialTable[j,i] = lineAsChars[j].Equals("0");
        }
        
        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");


        // Three coordinates: a node, its right neighbor, its bottom neighbor
        Console.WriteLine("0 0 1 0 0 1");
    }
}
}