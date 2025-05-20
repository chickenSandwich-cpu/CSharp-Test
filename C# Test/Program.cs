Console.Write("Enter the first side: ");
double side1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the second side: ");
double side2 = Convert.ToDouble(Console.ReadLine());

double side3 = Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2));
Console.WriteLine($"The length of the hypotenuse is: {side3}");