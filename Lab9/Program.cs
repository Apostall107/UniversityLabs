// See https://aka.ms/new-console-template for more information
using Lab9.Problem1;
using System.Collections.Generic;
using System.Text;

Console.WriteLine("Problem 1");
ResolveProblem1_2();
//Console.WriteLine("Problem 2");
//ResolveProblem1_2();
//Console.WriteLine("Problem 3");
//ResolveProblem3();
//Console.WriteLine("Problem 4");
//ResolveProblem4();
//Console.WriteLine("Problem 5");
//ResolveProblem5();
//Console.WriteLine("Problem 6");
//ResolveProblem6();
//Console.WriteLine("Problem 7");
//ResolveProblem7();
//Console.WriteLine("Problem 8");
//ResolveProblem8();

void ResolveProblem1_2() {
    var creationData = Console.ReadLine().Split();
    ListyIterator<string> collection;

    if (creationData.Length > 1) {
        collection = new ListyIterator<string>(creationData.Skip(1));
    } else {
        collection = new ListyIterator<string>();
    }


    var sb = new StringBuilder();
    var cmdInput = Console.ReadLine().Split();

    while (cmdInput[0] != "END") {
        try {
            switch (cmdInput[0]) {
                case "Move":
                sb.AppendLine(collection.Move().ToString());
                break;
                case "Print":
                sb.AppendLine(collection.Print());
                break;
                case "HasNext":
                sb.AppendLine(collection.HasNext().ToString());
                break;
                case "PrintAll":
                foreach (var item in collection) {
                    sb.Append($"{item} ");
                }

                sb.Remove(sb.Length - 1, 1);
                sb.AppendLine();
                break;
                default:
                break;
            }
        } catch (ArgumentException ae) {
            sb.AppendLine(ae.Message);
        }

        cmdInput = Console.ReadLine().Split();
    }

    Console.WriteLine(sb.ToString().Trim());
}