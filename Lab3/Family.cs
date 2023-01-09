using Lab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3 {
    internal class Family {

        private List<Person> members;

        public Family() {
            members = new List<Person>();
        }

        public void AddMember(Person member) {
            members.Add(member);
        }

        public Person GetOldestMember() {
            Person oldestMember = members[0];

            for (int i = 1; i < members.Count; i++) {
                if (members[i].Age > oldestMember.Age) {
                    oldestMember = members[i];
                }
            }

            return oldestMember;
        }
    }
}
