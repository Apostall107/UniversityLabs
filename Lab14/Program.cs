using Lab14;

ResolveProblem12();

//============================Resolvers============================
void ResolveProblem1()
{
    var students = Helpers.GetStudentsByGroup();
    Console.WriteLine(String.Join(Environment.NewLine, students
        .Where(x => x.Group == 2)
        .OrderBy(x => x.FirstName)
        .Select(x => $"{x.FirstName} {x.LastName}")));
}

void ResolveProblem2()
{
    var students = Helpers.GetStudentsByFirstName();
    Console.WriteLine(String.Join(Environment.NewLine, students
        .Where(x => x.Key.CompareTo(x.Value) < 0)
        .Select(x => $"{x.Key} {x.Value}")));
}

void ResolveProblem3()
{
    int minAge = 18;
    int maxAge = 24;
    var students = Helpers.GetStudentsByAge();
    Console.WriteLine(String.Join(Environment.NewLine, students
        .Where(x => x.Value >= minAge && x.Value <= maxAge)
        .Select(x => $"{x.Key} {x.Value}")));
}

void ResolveProblem4()
{
    var students = Helpers.SortStudents();
    Console.WriteLine(String.Join(Environment.NewLine, students
        .OrderBy(x => x.LastName)
        .ThenByDescending(x => x.FirstName)
        .Select(x => $"{x.FirstName} {x.LastName}")));
}

void ResolveProblem5()
{
    var students = Helpers.FilterStudentsByEmail(x => x.EndsWith("@gmail.com"));
    Console.WriteLine(String.Join(Environment.NewLine, students));
}

void ResolveProblem6()
{
    var students = Helpers.FilterStudentsByPhone();
    Console.WriteLine(String.Join(Environment.NewLine, students
        .Where(x => x.Value.StartsWith("02") || x.Value.StartsWith("+3592"))
        .Select(x => x.Key)));
}

void ResolveProblem7()
{
    var students = Helpers.GetExcelentStudents();
    Console.WriteLine(String.Join(Environment.NewLine, students
        .Where(x => x.Contains("6"))
        .Select(x =>
        x.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries))
        .Select(x => String.Join(" ", x.Where(x => char.IsLetter(x[0]))))));
}

void ResolveProblem8()
{
    var students = Helpers.GetWeekStudents();
    Console.WriteLine(String.Join(Environment.NewLine, students
        .Where(x => x.Marks.Where(x => x <= 3).Count() >= 2)
        .Select(x => x.FullName)));
}

void ResolveProblem9()
{
    var students = Helpers.GetEnrolledStudents();
    var target = new string[] { "14", "15" };
    Console.WriteLine(string.Join(Environment.NewLine, students
        .Where(x => target.Contains(x.Id.Substring(x.Id.Length - 2)))
        .Select(x => string.Join(" ", x.Marks))));
}

void ResolveProblem10()
{
    Console.WriteLine(String.Join(Environment.NewLine, Helpers.GetStudentsForGroupBy()
        .GroupBy(x => x.Group)
        .OrderBy(x => x.Key)
        .Select(x => $"{x.Key} - {string.Join(", ", x.Select(x => x.FullName))}")));
}

void ResolveProblem11()
{
    var specialities = Helpers.GetSpecs();
    var students = Helpers.GetStudentsForSpecs();

    var studentSpecialities = students.Join(specialities,
            st => st.Faculty,
            sp => sp.Faculty,
            (st, sp) => new
            {
                Name = st.FullName,
                Faculty = st.Faculty,
                Speciality = sp.Name
            });

    Console.WriteLine(string.Join(Environment.NewLine, studentSpecialities
        .OrderBy(st => st.Name)
        .Select(st => $"{st.Name} {st.Faculty} {st.Speciality}")));
}

void ResolveProblem12()
{
    var arrows = LittleJohn.GetArrows();
    int.TryParse(string.Join(string.Empty, arrows.Select(x => x.Amount)), out var arrowsCount);
    var binary = Convert.ToString(arrowsCount, 2);
    Console.WriteLine(Convert.ToInt32(LittleJohn.AppendReverse(binary), 2));
}