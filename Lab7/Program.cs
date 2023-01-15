
using Lab7.Problem1;
using Lab7.Problem2;
using Lab7.Problem3;
using Lab7.Problem4;
using Lab7.Problem5;
using Lab7.Problem6;
using Lab7.Problem7;
using Lab7.Problem8;
using System.Globalization;

Console.WriteLine("Problem 1");
ResolveProblem1();
Console.WriteLine("Problem 2");
ResolveProblem2();
Console.WriteLine("Problem 3");
ResolveProblem3();
Console.WriteLine("Problem 4");
ResolveProblem4();
Console.WriteLine("Problem 5");
ResolveProblem5();
Console.WriteLine("Problem 6");
ResolveProblem6();
Console.WriteLine("Problem 7");
ResolveProblem7();
Console.WriteLine("Problem 8");
ResolveProblem8();


void ResolveProblem1() {
    string name = Console.ReadLine();
    int age = int.Parse(Console.ReadLine());
    IPerson person = new Lab7.Problem1.Citizen(name, age);
    Console.WriteLine(person.Name);
    Console.WriteLine(person.Age);
}

void ResolveProblem2() {
    string name = Console.ReadLine();
    int age = int.Parse(Console.ReadLine());
    string id = Console.ReadLine();
    string birthdate = Console.ReadLine();
    IIdentifiable identifiable = new Lab7.Problem1.Citizen(name, age, id, birthdate);
    IBirthable birthable = new Lab7.Problem1.Citizen(name, age, id, birthdate);
    Console.WriteLine(identifiable.Id);
    Console.WriteLine(birthable.Birthdate);
}

void ResolveProblem3() {
    string name = Console.ReadLine();

    Ferrari ferrari = new Ferrari();

    Console.Write($"{ferrari.Model}/");
    ferrari.Brake();
    Console.Write("/");
    ferrari.Accelerate();
    Console.Write("/");
    Console.Write($"{name}");
}

void ResolveProblem4() {
    string[] phones = Console.ReadLine().Split(" ");
    string[] sites = Console.ReadLine().Split(" ");

    Smartphone smartphone = new Smartphone();

    for (int i = 0; i < phones.Length; i++) {
        smartphone.Numbers.Add(phones[i]);
    }
    for (int i = 0; i < sites.Length; i++) {
        smartphone.Sites.Add(sites[i]);
    }
    for (int i = 0; i < smartphone.Numbers.Count; i++) {
        smartphone.Call(smartphone.Numbers[i]);
    }
    for (int i = 0; i < smartphone.Sites.Count; i++) {
        smartphone.Browse(smartphone.Sites[i]);
    }
}

void ResolveProblem5() {
    List<Robot> robots = new List<Robot>();
    List<Lab7.Problem5.Citizen> citizens = new List<Lab7.Problem5.Citizen>();

    string input;
    while ((input = Console.ReadLine()) != "End") {
        string[] inputData = input.Split();
        if (inputData.Length == 3) {
            string name = inputData[0];
            string age = inputData[1];
            string id = inputData[2];

            citizens.Add(new Lab7.Problem5.Citizen(name, age, id));
        } else if (inputData.Length == 2) {
            string model = inputData[0];
            string id = inputData[1];
            robots.Add(new Robot(model, id));
        }
    }

    string fakeId = Console.ReadLine();

    var pplFound = citizens.Where(x => x.Id.EndsWith(fakeId)).ToList();
    var robotsFound = robots.Where(x => x.Id.EndsWith(fakeId)).ToList();

    List<string> fakeIdsFound = new List<string>();

    foreach (var item in pplFound) {
        fakeIdsFound.Add(item.Id);
    }
    foreach (var item in robotsFound) {
        fakeIdsFound.Add(item.Id);
    }
    foreach (var item in fakeIdsFound) {
        Console.WriteLine(item);
    }


}

void ResolveProblem6() {
    List<Pet> pets = new List<Pet>();
    List<Lab7.Problem5.Citizen> citizens = new List<Lab7.Problem5.Citizen>();

    string input;
    while ((input = Console.ReadLine()) != "End") {
        string[] inputData = input.Split();
        if (inputData[0] == "Citizen") {
            string name = inputData[1];
            string age = inputData[2];
            string id = inputData[3];
            string birth = inputData[4];

            citizens.Add(new Lab7.Problem5.Citizen(name, age, id, birth));
        } else if (inputData[0] == "Pet") {
            string name = inputData[1];
            string birth = inputData[2];
            pets.Add(new Pet(name, birth));
        }
    }

    string yearToFind = Console.ReadLine();

    var pplFound = citizens.Where(x => x.Birthdate.Year == DateTime.ParseExact(yearToFind, "yyyy", CultureInfo.InvariantCulture).Year).ToList();
    var petsFound = pets.Where(x => x.Birthdate.Year == DateTime.ParseExact(yearToFind, "yyyy", CultureInfo.InvariantCulture).Year).ToList();

    List<string> birthYearFound = new List<string>();

    foreach (var item in pplFound) {
        birthYearFound.Add(item.Birthdate.ToString());
    }
    foreach (var item in petsFound) {
        birthYearFound.Add(item.Birthdate.ToString());
    }
    foreach (var item in birthYearFound) {
        Console.WriteLine(item);
    }


}

void ResolveProblem7() {
    List<Lab7.Problem5.Citizen> citizens = new List<Lab7.Problem5.Citizen>();
    List<Lab7.Problem7.Rebel> rebels = new List<Lab7.Problem7.Rebel>();



    int n = int.Parse(Console.ReadLine());

    for (int i = 0; i < n; i++) {

        string[] inputData = Console.ReadLine().Split();
        if (inputData.Length == 4) {
            string name = inputData[0];
            string age = inputData[1];
            string id = inputData[2];
            string birth = inputData[3];

            citizens.Add(new Lab7.Problem5.Citizen(name, age, id, birth));
        } else if (inputData.Length == 3) {
            string name = inputData[0];
            string age = inputData[1];
            string group = inputData[2];
            rebels.Add(new Rebel(name, age, group));
        }
    }

    string input;


    while ((input = Console.ReadLine()) != "End") {
        var toFindRebel = rebels.Where(x => x.Name == input).FirstOrDefault();
        var toFindCitizen = citizens.Where(x => x.Name == input).FirstOrDefault();

        if (toFindRebel != null) {
            toFindRebel.BuyFood();
        }
        if (toFindCitizen != null) {
            toFindCitizen.BuyFood();
        }
    }

    Console.WriteLine(Lab7.Problem5.Citizen.Food + Rebel.Food);

}

void ResolveProblem8() {
    NumberFormatInfo provider = new NumberFormatInfo();
    provider.NumberDecimalSeparator = ".";

    string input;
    List<Private> privates = new List<Private>();
    List<Spy> spys = new List<Spy>();
    List<LeutenantGeneral> leutenantGenerals = new List<LeutenantGeneral>();
    List<Engineer> engineers = new List<Engineer>();
    List<Commando> commandos = new List<Commando>();
    List<Spy> spies = new List<Spy>();

    while ((input = Console.ReadLine()) != "End") {
        var soldierData = input.Split(" ");
        string name;
        string lastName;
        int Id;
        string corpse;
        double sallary;




        switch (soldierData[0]) {
            case "Private":
            Id = int.Parse(soldierData[1]);
            name = soldierData[2];
            lastName = soldierData[3];
            sallary = double.Parse(soldierData[4], provider);

            privates.Add(new Private(name, lastName, Id, sallary));

            break;
            case "Spy":
            Id = int.Parse(soldierData[1]);
            name = soldierData[2];
            lastName = soldierData[3];
            int code = int.Parse(soldierData[4]);

            spies.Add(new Spy(name, lastName, Id, code));
            break;
            case "LeutenantGeneral":
            Id = int.Parse(soldierData[1]);
            name = soldierData[2];
            lastName = soldierData[3];
            sallary = double.Parse(soldierData[4], provider);
            List<Private> myPrivates = new List<Private>();
            for (int i = 5; i < soldierData.Length; i++) {
                myPrivates.Add(privates.Where(x => x.Id == int.Parse(soldierData[i])).FirstOrDefault());
            }
            myPrivates.RemoveAll(x => x == null);

            leutenantGenerals.Add(new LeutenantGeneral(name, lastName, Id, sallary, myPrivates));
            break;
            case "Engineer":
            Id = int.Parse(soldierData[1]);
            name = soldierData[2];
            lastName = soldierData[3];
            sallary = double.Parse(soldierData[4], provider);
            corpse = soldierData[5];
            List<string> repairs = new List<string>();
            for (int i = 6; i < soldierData.Length; i++) {
                repairs.Add($"Repairs: \n\t Part Name: \n\t {soldierData[i]}Hours Worked: {soldierData[++i]}");
            }

            engineers.Add(new Engineer(name, lastName, Id, sallary, corpse, repairs));
            break;
            case "Commando":
            Id = int.Parse(soldierData[1]);
            name = soldierData[2];
            lastName = soldierData[3];
            sallary = double.Parse(soldierData[4], provider);
            corpse = soldierData[5];
            string codeName = soldierData.Length > 6 ? soldierData[6] : "";
            string state = soldierData.Length > 7 ? soldierData[7] : "";

            commandos.Add(new Commando(name, lastName, Id, sallary, corpse, codeName, state));
            break;
            default:
            break;
        }


    }


    foreach (var item in privates) {
        Console.WriteLine(item.ToString());
    }
    foreach (var item in spies) {
        Console.WriteLine(item.ToString());

    }
    foreach (var item in leutenantGenerals) {
        Console.WriteLine(item.ToString());
    }
    foreach (var item in engineers) {
        Console.WriteLine(item.ToString());

    }
    foreach (var item in commandos) {
        Console.WriteLine(item.ToString());

    }
}

