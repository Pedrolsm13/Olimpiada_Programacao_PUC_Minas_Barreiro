﻿using System; 

class Program {

    public static void Main(string[] args) { 
        double x1 = 0, y1 = 0, x2 = 0, y2 = 0;
        string [] ponto1 = Console.ReadLine().Split(" ");
        string [] ponto2 = Console.ReadLine().Split(" ");
        x1 = double.Parse(ponto1[0]);
        y1 = double.Parse(ponto1[1]);
        x2 = double.Parse(ponto2[0]);
        y2 = double.Parse(ponto2[1]);
        double resp = Math.Sqrt((Math.Pow((x2-x1),2))+(Math.Pow((y2-y1),2)));
        Console.WriteLine($"{resp:F4}");
    }

}