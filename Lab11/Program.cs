using Lab11.Problem1;

ResolveProblem1();
ResolveProblem2();
ResolveProblem3();

//===================Resolvers===================
void ResolveProblem1() {
    var dispatcher = new Dispatcher();
    var printHandler = new PrintHandler();

    dispatcher.NameChange += printHandler.OnDispatcherNameChange;

    string name = Console.ReadLine();

    while (name.ToLower() != "end") {
        dispatcher.Name = name;
        name = Console.ReadLine();
    }
}

void ResolveProblem2() {
    new Lab11.Problem2.Core().Start();
}

void ResolveProblem3() {
    new Lab11.Problem3.Core().Execute();
}