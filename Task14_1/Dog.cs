using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14_1
{
    class Dog : Animal
    {
        string name;
        string sound;

        public override string Name { get; set; }
        public Dog(string name, string sound)
            : base(name)
        {
            this.sound = sound;
        }
        public override void Say()
        {
            Console.WriteLine(sound);
        }
    }
}
