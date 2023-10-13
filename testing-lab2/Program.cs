using testing_lab2;

var c = Triangle.GetTriangleInfo("234,56", "350,6", "350,6");

Console.WriteLine(c.Item1);

foreach (var item in c.Item2)
{
    Console.WriteLine(item);
}

