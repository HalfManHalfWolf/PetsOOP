﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Chimp : pet
    {
        public Chimp(string name) : base(name)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine(Name + " hoots at you.");
        }

      
    }
}
