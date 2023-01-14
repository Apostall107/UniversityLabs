using Lab7.Problem2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.Problem1 {
    internal class Citizen : IPerson, IIdentifiable, IBirthable 
{ 
    public string Name { get; set; }
    public int Age { get; set; }
    public string Id { get; set; }
    public string Birthdate { get; set; }

    public Citizen(string name, int age, string id, string birthdate) {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.Birthdate = birthdate;
    }

    public Citizen(string name, int age) {
        this.Name = name;
        this.Age = age;
    }
}
}
