using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Friendface
{
    internal class App

    {
        private bool LoggedIn = true;
        public static List<Person> PersonList = new List<Person>();
        public void Run()
        {
            
            var Ådne = new Profile("Ådne", 35);

            while (LoggedIn)
            {
                MainMenu();
                var input = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                ShowChoice(input, Ådne);
            }
        }
        

        public void ShowPersonList()
        {
            int i = 1;
            foreach (Person person in PersonList)
            {
                Console.WriteLine(i++ + ". " + person.Name);                
            }
        }
        public static void AddPerson(Person person)
        {
            PersonList.Add(person);
        }

        public  void MainMenu()
        {
            Console.WriteLine("\nHva vil du gjøre?");
            Choice(1, "Se profil");
            Choice(2, "Mine venner");
            Choice(3, "Legg til venn");
            Choice(4, "Se personer i nærområdet");
            Choice(5, "Klokka er mye, på tide å logge av.");
        }

        public void  ShowChoice(int number, Profile profil)
        {
            Console.Clear();
            if (number == 1)
            {
                profil.Show();
            } else if (number == 2)
            {
                profil.ShowFriends();
            } else if (number == 3)
            {
                PublicAddFriend(FriendChoices());
            } else if (number == 4)
            {
                ShowPersonList();
                Console.WriteLine("\nHvem vil du kikke nærmere på?");
                var input = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                ShowDetails(input);
            } else if (number == 5)
            {
                Exit();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Ugyldig knapp.");
            } 
        }

        void Exit()
        {
            LoggedIn = false;
        }

        public int FriendChoices()
        {  
            Console.Clear();
            Console.WriteLine("Hvordan vil du legge til venn?\n");
            Choice(1, "Vil legge til en fra nærområdet?");
            Choice(2, "Vil du lag en ny? (hahahah)");
            var input = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            return input;
        }

        void PublicAddFriend(int number)
        {
            if (number == 1)
            {
                FriendAdderFromList();
            } else if (number == 2)
            {
                FriendCreater();
            }
            else
            {
                Console.WriteLine("Kanskje en annen gang da.");
            }
        }

        void FriendCreater()
        {
            Console.Write("Skriv inn navn: ");
            var name = Console.ReadLine();
            Console.Write("Skriv inn alder: ");
            var age = Console.ReadLine();
            var Person = new Person(name, age);
            Profile.AddFriend(Person);
            PersonList.Remove(Person);
        }

        void FriendAdderFromList()
        {
            ShowPersonList();
            Console.Write("Hvem vil du legge til? ");
            var input = Convert.ToInt32(Console.ReadLine());
            Profile.AddFriend(PersonList[input - 1]);
            Console.WriteLine($"{PersonList[input - 1].Name} er lagt til i vennelisten din.");
            PersonList.Remove(PersonList[input - 1]);
        }

        void ShowDetails(int number)
        {
            PersonList[number - 1].Show();
        }
    

        void Choice(int number, string description)
        {
            Console.WriteLine($"{number}. {description}");
        }

      

        
    }
}
