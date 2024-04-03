using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14_1
{
    class Cat : Animal
    {
        string name;
        string sound;
        string color;

        public override string Name { get; set; }
        public Cat(string name, string sound, string color)
            : base(name)
        {
            this.sound = sound;
            this.color = color;
        }
        public override void Say()
        {
            Console.WriteLine(sound);
        }
    }
}
