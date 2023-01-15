
using Lab9.Problem1;
using Lab9.Problem4;
using Lab9.Problem5;
using Lab9.Problem6;
using System.Text;

Console.WriteLine("Problem 1");
ResolveProblem1_2();
Console.WriteLine("Problem 2");
ResolveProblem1_2();
Console.WriteLine("Problem 3");
ResolveProblem3();
Console.WriteLine("Problem 4");
ResolveProblem4();
Console.WriteLine("Problem 5");
ResolveProblem5();
Console.WriteLine("Problem 6");
ResolveProblem6();



void ResolveProblem1_2() {
    var creationData = Console.ReadLine().Split();
    ListyIterator<string> collection;

    if (creationData.Length > 1) {
        collection = new ListyIterator<string>(creationData.Skip(1));
    } else {
        collection = new ListyIterator<string>();
    }


    var sb = new StringBuilder();
    string cmdInput;
    while ((cmdInput = Console.ReadLine()) != "END") {
        var input = cmdInput.Split();
        try {
            switch (input[0]) {
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

    }

    Console.WriteLine(sb.ToString().Trim());
}

void ResolveProblem3() {
    var stack = new Stack<int>();
    string cmdInput;


    while ((cmdInput = Console.ReadLine()) != "END") {
        var input = cmdInput.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        switch (input[0]) {
            case "Push":
            var elements = input.Skip(1).Select(int.Parse);
            stack.Push(elements); //TODO: check
            break;
            case "Pop":
            try {
                stack.Pop();
            } catch (ArgumentException ae) {
                Console.WriteLine(ae.Message);
            }

            break;
            default:
            break;
        }

    }

    foreach (var element in stack) {
        Console.WriteLine(element);
    }
    foreach (var element in stack) {
        Console.WriteLine(element);
    }
}


void ResolveProblem4() {
    var stoneValues = Console.ReadLine()
    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse);

    var stones = new Stones<int>(stoneValues);

    Console.WriteLine(string.Join(", ", stones));
}

/*--------------------------------------------Problem 5------------------------*/
void ResolveProblem5() {
    var people = GetPeople();
    var targetPersonNumber = int.Parse(Console.ReadLine());
    if (targetPersonNumber < 0 || targetPersonNumber >= people.Count) {
        Console.WriteLine("No matches");
        return;
    }

    var targetPerson = people[targetPersonNumber];
    var equalityCount = CountEqualPeople(targetPerson, people);
    if (equalityCount <= 1) {
        Console.WriteLine("No matches");
        return;
    }

    var differenceEqualCount = CountDifferentPeople(targetPerson, people);
    Console.WriteLine($"{equalityCount} {differenceEqualCount} {people.Count}");
}

static int CountDifferentPeople(Lab9.Problem5.Person targetPerson, List<Lab9.Problem5.Person> people) {
    var differentPeopleCount = 0;

    for (int i = 1; i < people.Count; i++) {
        if (people[i - 1].CompareTo(people[i]) != 0) {
            differentPeopleCount++;
        }
    }

    return differentPeopleCount;
}

int CountEqualPeople(Lab9.Problem5.Person targetPerson, List<Lab9.Problem5.Person> people) {
    var equalityCount = 1;

    for (int i = 1; i < people.Count; i++) {
        if (people[i - 1].CompareTo(people[i]) == 0) {
            equalityCount++;
        }
    }

    return equalityCount;
}

List<Lab9.Problem5.Person> GetPeople() {
    var people = new List<Lab9.Problem5.Person>();

    var personData = Console.ReadLine().Split();

    while (personData[0] != "END") {
        var name = personData[0];
        var age = int.Parse(personData[1]);
        var town = personData[2];

        people.Add(new Lab9.Problem5.Person(name, age, town));

        personData = Console.ReadLine().Split();
    }

    return people;
}
/*--------------------------------------------Problem 5 END------------------------*/

void ResolveProblem6() {

    var peopleByName = new SortedSet<Lab9.Problem6.Person>(new PersonNameComparator());
    var peopleByAge = new SortedSet<Lab9.Problem6.Person>(new PersonAgeComparator());
    FillSetsWithPeople(peopleByName, peopleByAge);
    PrintBothSets(peopleByName, peopleByAge);


    void PrintBothSets(SortedSet<Lab9.Problem6.Person> peopleByName, SortedSet<Lab9.Problem6.Person> peopleByAge) {
        var sb = new StringBuilder();

        ExtractPeopleData(sb, peopleByName);
        ExtractPeopleData(sb, peopleByAge);

        Console.Write(sb);
    }
    void ExtractPeopleData(StringBuilder sb, SortedSet<Lab9.Problem6.Person> peopleCollection) {
        foreach (var person in peopleCollection) {
            sb.AppendLine(person.ToString());
        }
    }

    void FillSetsWithPeople(SortedSet<Lab9.Problem6.Person> peopleByName, SortedSet<Lab9.Problem6.Person> peopleByAge) {
        var numberOfPeople = int.Parse(Console.ReadLine());

        while (numberOfPeople > 0) {
            var personData = Console.ReadLine().Split();
            var name = personData[0];
            var age = int.Parse(personData[1]);

            peopleByName.Add(new Lab9.Problem6.Person(name, age));
            peopleByAge.Add(new Lab9.Problem6.Person(name, age));

            numberOfPeople--;
        }
    }
}
