using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friendface
{
    internal class Person
    {
        public string Name;
        private string Age;
        private List<string> Hobbies;
        /*
        public Person(string name, string age) {

            Name = name;
            Age = age;
            
        }
        */
        public Person(string name, string age) 
        {
            Name = name;
            Age = age;
            App.AddPerson(this);
       }

        public void Hobby(string hobby)
        {
            Hobbies.Add(hobby);            
        }

        public void Show()
        {
            
            Console.WriteLine($"Navn: {Name} \n" +
                              $"Alder: {Age} \n");
        }
    }
}
