using System;

Point pointCall = Point.NewPoint(3,2);
Point secondPoint = Point.NewPoint(-4,0);

Console.WriteLine($"({pointCall.XValue}),({pointCall.YValue})");
Console.WriteLine($"({secondPoint.XValue}),({secondPoint.YValue})");


public class Point
{
    public int XValue {get; private set;}
    public int YValue {get; private set;}

   public Point(int xValue, int yValue)
   {
        XValue = xValue;
        YValue = yValue;
   }

    public Point ()
    {
        XValue = 0;
        YValue = 0;
    }

    public static Point NewPoint (int XValue,int YValue)
    {
        return new Point(XValue,YValue);
    }

}