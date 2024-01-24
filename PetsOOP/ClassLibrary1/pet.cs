using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class pet
    {
        public string Name { get; set; }

        // constructor 
        public pet(string Name)
        {
            Name = Name;
        }
        public abstract void MakeSound();
        public void Showinfo()
        {
            Console.WriteLine("Pet Name: " + Name);
        }
    }

}
