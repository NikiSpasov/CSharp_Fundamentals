using System;
using System.Linq;


class Program
{
    static void Main()
    {
        var firstInput = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        var secondInput = Console.ReadLine()
           .Split(' ')
           .Select(int.Parse)
           .ToArray();


        Rectangle firstRect = new Rectangle
        {
            Top = firstInput[0],
            Left = firstInput[1],
            Width = firstInput[2],
            Height = firstInput[3]
        };
        Rectangle secondRect = new Rectangle
        {
            Top = secondInput[0],
            Left = secondInput[1],
            Width = secondInput[2],
            Height = secondInput[3]
        };
        bool a = FirstIsInsideSecond(firstRect, secondRect);
        Console.WriteLine(a ? "Inside":"Not inside");
    }
    public static bool FirstIsInsideSecond
        (Rectangle first,
        Rectangle second)
    {
        var leftIsCorrect = first.Left >= second.Left;
        var rightIsCorrect = first.Right <= second.Right;
        var bottomIsCorrect = first.Bottom >= second.Bottom;
        var topIsCorrect = first.Top >= second.Top;
        return leftIsCorrect && rightIsCorrect && bottomIsCorrect && topIsCorrect;
    }
}
