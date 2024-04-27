using System;
using System.Runtime.CompilerServices;
using System.Xml;
using Microsoft.Win32;

Color newColor = new Color(122,25,0);
Color myFavoriteColor = Color.Green;


Console.WriteLine("({0}),({1}),({2})" , newColor.R, newColor.G, newColor.B);
System.Console.WriteLine("({0}),({1}),({2})", myFavoriteColor.R, myFavoriteColor.G, myFavoriteColor.B);

public class Color{
    public int R {get;set;}
    public int G {get;set;}
    public int B {get;set;}

    public Color(int rVal, int gVal,int bVal){
        this.R = rVal;
        this.G = gVal;
        this.B = bVal;
    }

    public static Color White => new Color(255,255,255);
    public static Color Black => new Color(0,0,0);
    public static Color Red => new Color(255,0,0);
    public static Color Orange => new Color(255,165,0);
    public static Color Yellow => new Color(255,255,0);
    public static Color Green => new Color(0,128,0);
    public static Color Blue => new Color(0,0,255);
    public static Color Purple => new Color(128,0,128);

}