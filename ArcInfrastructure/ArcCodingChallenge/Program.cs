Console.WriteLine("Please select a shape from the list of options:");
Console.WriteLine("1. Circle");
Console.WriteLine("2. Triangle");
Console.WriteLine("3. Rectangle");
Console.WriteLine("4. Square");

double area = 0;

switch (Console.ReadLine())
{
    case "1":
        Console.WriteLine("Please enter the radius of the circle: ");
        double circleRadius = double.Parse(Console.ReadLine());
        area = Math.PI * Math.Pow(circleRadius, 2);
        Console.WriteLine($"The area of the circle is: {area}");
        break;
    case "2":      
        Console.WriteLine("Please enter the base of the triangle: ");
        double triangleBase = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the height of the triangle: ");
        double triangleHeight = double.Parse(Console.ReadLine());
        area = (triangleBase * triangleHeight) / 2;
        Console.WriteLine($"The area of the triangle is: {area}");
        break;
    case "3":        
        Console.WriteLine("Please enter the width of the rectangle: ");
        double rectangleWidth = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the height of the rectangle: ");
        double rectangleHeight = double.Parse(Console.ReadLine());
        area = rectangleWidth * rectangleHeight;
        Console.WriteLine($"The area of the rectangle is: {area}");
        break;
    case "4":
        Console.WriteLine("Please enter the side of the square: ");
        double side = double.Parse(Console.ReadLine());        
        area = side * side;
        Console.WriteLine($"The area of the square is: {area}");
        break;
    default:
        Console.WriteLine("You made a wrong selection. Please try again.");
        break;
}

Console.WriteLine("Press any key to close this window.");
Console.ReadKey();