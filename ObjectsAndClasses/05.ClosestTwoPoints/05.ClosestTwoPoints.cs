﻿using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    public static double CalculateDistance(Point firstPoint, Point secondPoint)
    {
        var diffX = firstPoint.X - secondPoint.X;
        var diffY = firstPoint.Y - secondPoint.Y;

        var powX = Math.Pow(diffX, 2);
        var powY = Math.Pow(diffY, 2);
        return Math.Sqrt(powX + powY);
    }
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        var points = new List<Point>();
        for (int i = 0; i < num; i++)
        {
            var currentPointParts =
                Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            points.Add(new Point
            {
                X = currentPointParts[0],
                Y = currentPointParts[1]
            });
        }
        var minDistanceSoFar = double.MaxValue;
        Point firstPointMax = null;
        Point secondPointMax = null;
        for (int i = 0; i < points.Count - 1; i++)
        {
            for (int j = i + 1; j < points.Count; j++)
            {
                var firstPoint = points[i];
                var secondPoin = points[j];

                var currentDistance = CalculateDistance(
                    firstPoint, secondPoin);
                if (currentDistance < minDistanceSoFar)
                {
                    minDistanceSoFar = currentDistance;
                    firstPointMax = firstPoint;
                    secondPointMax = secondPoin;

                }
            }
        }
        Console.WriteLine($"{minDistanceSoFar:F3}");
        Console.WriteLine($"({firstPointMax.X}, {firstPointMax.Y})");
        Console.WriteLine($"({secondPointMax.X}, {secondPointMax.Y})");
    }
}
