using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friendface
{
    internal class Profile
    {
        private string Name;
        private int Age;
        public static List<Person> FriendList = new List<Person>();

        public Profile(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public static void AddFriend(Person person)
        {
            FriendList.Add(person);
        }

        public void RemoveFriend(Person person)
        {
            FriendList.Remove(person);
        }

        public void ShowFriends()
        {
            if (FriendList.Count > 0)
            {
                foreach (var friend in FriendList)
                {
                    Console.WriteLine(friend.Name);
                }
            }
            else
            {
                Console.WriteLine("Du har ingen venner!");

            }
            
        }

        public void Show()
        {
            Console.WriteLine($"Navn: {Name}, Alder: {Age}");
            
        }

    }
}
