// See https://aka.ms/new-console-template for more information


Console.WriteLine("What is the length of the classroom");
double classLength = double.Parse(Console.ReadLine());
Console.WriteLine("What is the width of the classroom");
double classWidth = double.Parse(Console.ReadLine());
Console.WriteLine("What is the height of the classroom");
double classHeight = double.Parse(Console.ReadLine());

double roomArea = AreaOfRoom(classLength, classWidth);
double roomPerimeter = PerimeterOfRoom(classLength, classWidth);
double roomVolume = VolumeOfRoom(classLength, classWidth, classHeight);
double roomSurfaceArea = SurfaceAreaOfRoom(classLength, classWidth, classHeight);
Console.WriteLine($"The area of the room is {roomArea} square feet, the perimeter is {roomPerimeter} feet, the volume is {roomVolume} cubic feet, and the surface area is {roomSurfaceArea} square feet.");

if (roomArea <= 250)
{
    Console.WriteLine("This is a small-sized room.");
}
else if (roomArea > 250 && roomArea < 650)
{
    Console.WriteLine("This is a medium-sized room.");
}
else
{
    Console.WriteLine("This is a large-sized room.");
}











double AreaOfRoom(double length, double width)
{
    double area = length * width;
    return area;
}

double PerimeterOfRoom (double length, double width)
{
    double perimeter = 2 * (length + width);
    return perimeter;
}

double VolumeOfRoom (double length, double width, double height)
{
    double volume = length * width * height;
    return volume;
}

double SurfaceAreaOfRoom(double length, double width, double height)
{
    double surfaceArea = 2 *((width * length) + (height * length) + (height * width));
    return surfaceArea;
}