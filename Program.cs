// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the room calculator!");

Console.WriteLine("Please enter the length value of the classroom: ");

decimal length = decimal.Parse(Console.ReadLine());

Console.WriteLine("Please enter the width value:");

decimal width = decimal.Parse(Console.ReadLine());

Console.WriteLine("Please enter the height value:");

decimal height = decimal.Parse(Console.ReadLine());

decimal area;
decimal perimeter;
decimal volume;
decimal surfaceArea;

area = length * width;

perimeter = 2 * (length + width);

volume = length * width * height;

surfaceArea = (2 * length * height + 2 * length * width + 2 * height * width);

Console.WriteLine($"The area of the specified room is: {area}");

Console.WriteLine($"The perimeter of the specified room is: {perimeter}");

Console.WriteLine($"The volume of the specified room is: {volume}");

Console.WriteLine($"The surface area of the specified room is: {surfaceArea}");
if (area <= 250){
    Console.WriteLine("This is a small room!");
} else if (area > 250 && area < 650){
    Console.WriteLine("This is a medium sized room!");
} else {
    Console.WriteLine("This is a large room!");
}

Console.WriteLine("Bye bye!");