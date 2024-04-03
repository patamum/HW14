using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14_1
{
    abstract class Animal
    {
        abstract public string Name { get; set; }
        public Animal(string name) 
        {
            Name = name;
        }
        abstract public void Say();
        public void ShowInfo()
        {
            Console.WriteLine("Животное: {0}", Name);
            Say();
        }
    }
    

}
