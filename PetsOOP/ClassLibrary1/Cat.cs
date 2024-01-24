using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Cat : pet
    {
        public Cat(string name) : base(name)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine(Name + " meows at you.");
        }

        public void Climb()
        {
            Console.WriteLine(Name + " climbs the wall");
        }

        public void Meet(Chimp newFriend)
        {
            Console.WriteLine(Name + " scrathes at " + newFriend.Name);
        }

        public void Meet(Turtle newfriend)
        {
            Console.WriteLine(Name + " scrathes at " + newfriend.Name);
        }
    }
}
