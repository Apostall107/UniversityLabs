using Lab13.Problem4;
using System.Text;
using System.Text.RegularExpressions;

ResolveProblem12_13();


//============================Resolvers============================
void ResolveProblem1() {
    string str = Console.ReadLine();
    var strBuilder = new StringBuilder(str.Length);

    for (int i = str.Length - 1; i >= 0; i--) {
        strBuilder.Append(str[i]);
    }

    Console.WriteLine(strBuilder.ToString());
}

void ResolveProblem2() {
    string str = Console.ReadLine();

    if (str.Length >= 20) {
        Console.WriteLine(str.Substring(0, 20));
    } else {
        for (int i = 0; i < 20; i++) {
            if (str.Length <= i) {
                Console.Write("*");
                continue;
            }
            Console.Write(str[i]);
        }
    }
}

void ResolveProblem3() {
    string email = Console.ReadLine();
    string text = Console.ReadLine();

    int censorCount = email.Substring(0, email.IndexOf('@')).Length;

    string censored = "";
    for (int i = 0; i < censorCount; i++) {
        censored += "*";
    }
    censored += email.Substring(email.IndexOf('@'));

    Console.WriteLine(text.Replace(email, censored));
}

void ResolveProblem4() {
    string key = Console.ReadLine();
    var sentences = Console.ReadLine()
        .Split(".!?".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
        .ToList();

    Console.WriteLine(string.Join(Environment.NewLine, SentenceHelper.GetSentenceByKey(sentences, key)));
}

void ResolveProblem5() {
    string url = Console.ReadLine();

    string protocol = "";
    int protocolIndex = url.IndexOf("://");
    if (protocolIndex > 0) {
        protocol = url.Substring(0, protocolIndex);
        url = url.Substring(protocolIndex + 3);
    }

    string server = "";
    string resource = "";
    int serverIndex = url.IndexOf('/');
    if (serverIndex < 0) {
        server = url;
    } else {
        server = url.Substring(0, serverIndex);
        resource = url.Substring(serverIndex + 1);
    }

    Console.WriteLine($"Protocol = {protocol}\nServer = {server}\nResource = {resource}");
}

void ResolveProblem7() {
    string text = Console.ReadLine();
    int start = text.IndexOf("<upcase>");
    int end = text.IndexOf("</upcase>");

    while (start != -1) {
        string toReplace = text.Substring(start, end - start + 9);
        string toUpper = toReplace.Substring(8, toReplace.Length - 17).ToUpper();

        text = text.Replace(toReplace, toUpper);

        start = text.IndexOf("<upcase>");
        end = text.IndexOf("</upcase>");
    }

    Console.WriteLine(text);
}

void ResolveProblem8() {
    var text = Console.ReadLine().Split(new char[] { ' ', '.', ',', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
    var palindromes = new SortedSet<string>();

    foreach (var word in text) {
        var isPalindrome = true;

        for (int i = 0; i <= word.Length / 2; i++) {
            if (word[i] != word[word.Length - 1 - i]) {
                isPalindrome = false;
                break;
            }
        }

        if (isPalindrome) {
            palindromes.Add(word);
        }
    }

    Console.WriteLine($"{string.Join(", ", palindromes)}");
}

void ResolveProblem9() {
    string text = Console.ReadLine();
    string result = Regex.Replace(text, @"\b(\w)", m => m.Value.ToUpper());
    Console.WriteLine(result);
}

void ResolveProblem10() {
    string str = Console.ReadLine();
    string stringAux = "";
    for (int i = 0; i < str.Length / 2; i++) {
        if (str[i] == str[str.Length - 1 - i])
            continue;

        stringAux = str.Remove(i, 1);
        if (stringAux.SequenceEqual(stringAux.Reverse())) {
            Console.WriteLine(i);
            return;
        }

        stringAux = str.Remove(str.Length - 1 - i, 1);
        if (stringAux.SequenceEqual(stringAux.Reverse())) {
            Console.WriteLine(str.Length - 1 - i);
            return;
        }
    }

    Console.WriteLine("-1");
}

void ResolveProblem11() {
    string str1 = Console.ReadLine();
    string str2 = Console.ReadLine();
    if (CheckTwoStrings(str1, str2))
        Console.Write("Yes");
    else
        Console.Write("No");
}

static bool CheckTwoStrings(string str1, string str2) {
    bool[] sortingVector = new bool[32];
    for (int i = 0; i < 32; i++)
        sortingVector[i] = false;

    for (int i = 0; i < str1.Length; i++)
        sortingVector[str1[i] - 'a'] = true;

    for (int i = 0; i < str2.Length; i++)
        if (sortingVector[str2[i] - 'a'])
            return true;

    return false;
}

void ResolveProblem12_13() {
    SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

    bool isWorking = true;
    while (isWorking) {
        string[] command = Console.ReadLine().Split(' ');
        switch (command[0]) {
            case "A":
            phonebook[command[1]] = command[2];
            break;
            case "S":
            Console.WriteLine(phonebook.ContainsKey(command[1]) ? $"{command[1]} -> {phonebook[command[1]]}" : $"Contact {command[1]} does not exist.");
            break;
            case "ListAll":
            foreach (KeyValuePair<string, string> item in phonebook) {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

            break;
            default:
            isWorking = false;
            break;
        }
    }
}