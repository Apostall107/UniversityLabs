using InheritanceLab.Problem1;
using InheritanceLab.Problem2;
using InheritanceLab.Problem3;
using InheritanceLab.Problem4;

Console.WriteLine("Problem 1");
ResolveProblem1();
Console.WriteLine("Problem 2");
ResolveProblem2();
Console.WriteLine("Problem 3");
ResolveProblem3();
Console.WriteLine("Problem 4");
ResolveProblem4();

//=================Resolvers=================
void ResolveProblem1()
{
    try
    {
        string name = Console.ReadLine();
        int.TryParse(Console.ReadLine(), out int age);

        var child = new Child(name, age);
        Console.WriteLine(child);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

void ResolveProblem2()
{
    try
    {
        string author = Console.ReadLine();
        string title = Console.ReadLine();
        decimal price = decimal.Parse(Console.ReadLine());
        Book book = new Book(author, title, price);
        GoldenEditionBook goldenEditionBook = new GoldenEditionBook(author, title, price);
        Console.WriteLine(book + Environment.NewLine);
        Console.WriteLine(goldenEditionBook);
    }
    catch (ArgumentException ae)
    {
        Console.WriteLine(ae.Message);
    }
}

void ResolveProblem3()
{
    try
    {
        var studentInfo = Console.ReadLine().Split();
        var workerInfo = Console.ReadLine().Split();
        decimal.TryParse(workerInfo[2], out decimal weekSalary);
        int.TryParse(workerInfo[3], out int workHours);

        var oStudent = new Student(studentInfo[0], studentInfo[1], studentInfo[2]);
        var oWorker = new Worker(workerInfo[0], workerInfo[1], weekSalary, workHours);

        Console.WriteLine(oStudent);
        Console.WriteLine(oWorker);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

void ResolveProblem4()
{
    var playList = SongHelper.ComposePlaylist();
    SongHelper.PrintPlaylistSummary(playList);
}