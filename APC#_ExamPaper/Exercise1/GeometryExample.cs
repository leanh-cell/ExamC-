using System;
class Cylinder
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the dimenstions of the cylinder");
        Console.Write("Radius: ");
        double Radius = double.Parse(Console.ReadLine());
        Console.Write("Height: ");
        double Height = double.Parse(Console.ReadLine());

        Console.WriteLine("\nCylinder Characteristics");
        Console.WriteLine("Radius: " + Radius + ", Height:" + Height);
        double BaseArea = Radius * Radius * Math.PI;
        double Lateral = 2 * Math.PI * Radius * Height;
        double TotalArea = 2 * Math.PI * Radius * (Height + Radius);
        double Volume = Math.PI * Radius * Radius * Height;
        Console.WriteLine("Base: " + Math.Round(BaseArea, 2) + " | Lateral: " + Math.Round(Lateral, 2)
            + " | Total: " + Math.Round(TotalArea, 2) + " | Volume: " + Math.Round(Volume, 2));
    }
}