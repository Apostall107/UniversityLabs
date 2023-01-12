using GenericsLab.Problems0_6;
using GenericsLab.Problems7_8;
using GenericsLab.Problem9;


Console.WriteLine("Problem 0");
ResolveProblem00();
Console.WriteLine("Problem 1");
ResolveProblem01();
Console.WriteLine("Problem 2");
ResolveProblem02();
Console.WriteLine("Problem 3");
ResolveProblem03();
Console.WriteLine("Problem 4");
ResolveProblem04();
Console.WriteLine("Problem 5");
ResolveProblem05();
Console.WriteLine("Problem 6");
ResolveProblem06();
Console.WriteLine("Problem 7-8");
ResolveProblem07_08();
Console.WriteLine("Problem 9");
ResolveProblem09();

//===============Resolvers section===============
void ResolveProblem00()
{
    var intBox = new Box<int>(12313);
    var strBox = new Box<string>("life in a box");
    Console.WriteLine(intBox);
    Console.WriteLine(strBox);
}

void ResolveProblem01()
{
    int.TryParse(Console.ReadLine(), out var count);

    while (count > 0)
    {
        Console.WriteLine(new Box<string>(Console.ReadLine()));

        count--;
    }
}

void ResolveProblem02()
{
    int.TryParse(Console.ReadLine(), out var count);

    while (count > 0)
    {
        int.TryParse(Console.ReadLine(), out var number);
        Console.WriteLine(new Box<int>(number));

        count--;
    }
}

void Swap<T>(List<T> data, int firstSwapItem, int secondSwapItem)
{
    var temp = data[firstSwapItem];
    data[firstSwapItem] = data[secondSwapItem];
    data[secondSwapItem] = temp;
}

void ResolveProblem03()
{
    int.TryParse(Console.ReadLine(), out var count);
    var boxesCollection = new List<Box<string>>();

    while (count > 0)
    {
        boxesCollection.Add(new Box<string>(Console.ReadLine()));

        count--;
    }

    var swapIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
    Swap(boxesCollection, swapIndexes[0], swapIndexes[1]);
    foreach (var item in boxesCollection)
    {
        Console.WriteLine(item);
    }
}

void ResolveProblem04()
{
    int.TryParse(Console.ReadLine(), out var count);
    var boxesCollection = new List<Box<int>>();

    while (count > 0)
    {
        boxesCollection.Add(new Box<int>(Convert.ToInt32(Console.ReadLine())));

        count--;
    }

    var swapIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
    Swap(boxesCollection, swapIndexes[0], swapIndexes[1]);
    foreach (var item in boxesCollection)
    {
        Console.WriteLine(item);
    }
}

int CountGreaterThanGiven<T>(List<T> data, T givenValue) where T : IComparable<T>
{
    var count = 0;

    foreach (var item in data)
    {
        if (item.CompareTo(givenValue) > 0)
            count++;
    }

    return count;
}

void ResolveProblem05()
{
    int.TryParse(Console.ReadLine(), out var count);
    var boxesCollection = new List<Box<string>>();

    while (count > 0)
    {
        boxesCollection.Add(new Box<string>(Console.ReadLine()));

        count--;
    }

    var toCompare = new Box<string>(Console.ReadLine());
    Console.WriteLine(CountGreaterThanGiven(boxesCollection, toCompare));
}

void ResolveProblem06()
{
    int.TryParse(Console.ReadLine(), out var count);
    var boxesCollection = new List<Box<double>>();

    while (count > 0)
    {
        boxesCollection.Add(new Box<double>(Convert.ToDouble(Console.ReadLine())));

        count--;
    }

    var toCompare = new Box<double>(Convert.ToDouble(Console.ReadLine()));
    Console.WriteLine(CountGreaterThanGiven(boxesCollection, toCompare));
}

void ResolveProblem07_08()
{
    var interpreter = new CommandInterpreter();
    var cmdArgs = Console.ReadLine().Split();

    while (cmdArgs[0] != "END")
    {
        interpreter.ExecuteCommand(cmdArgs);
        cmdArgs = Console.ReadLine().Split();
    }
}

void ResolveProblem09()
{
    var input = Console.ReadLine().Split();
    var name = $"{input[0]} {input[1]}";
    var address = input[2];
    Console.WriteLine(new Tupple<string, string>(name, address));

    input = Console.ReadLine().Split();
    name = input[0];
    int.TryParse(input[1], out int liters);
    Console.WriteLine(new Tupple<string, int>(name, liters));

    input = Console.ReadLine().Split();
    int.TryParse(input[0], out int num);
    double.TryParse(input[1], out double value);
    Console.WriteLine(new Tupple<int, double>(num, value));
}