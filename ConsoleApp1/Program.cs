using ConsoleApp1;


Console.WriteLine("Enter the count of chinacity objects: ");
int count = Convert.ToInt32(Console.ReadLine());
ChinaCity[] array = new ChinaCity[count];

for (int i = 0; i < count; i++)
{
    Console.WriteLine("Enter the name: ");
    string name = Console.ReadLine();
    Console.WriteLine("Enter the population");
    uint population = Convert.ToUInt32(Console.ReadLine());
    ChinaCity city = new ChinaCity();
    city.Name = name;
    city.Population = population;
    array[i] = city;
}

uint totalPopulation = 0;
foreach (ChinaCity city in array)
{
    totalPopulation += city.Population;
}

Console.WriteLine($"Average Population: {totalPopulation/count}");