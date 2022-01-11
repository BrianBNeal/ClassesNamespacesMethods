using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesNamespacesMethods.Pets
{
    class Dog
    {
        //properties - TitleCase
        //auto property - has a plain getter/setter
        //access modifier   type   name   getter & setter
        public string FurType { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public double Weight { get; set; }
        public DateTime DateOfBirth { get; private set; }
        //calculated property
        public int Age {
            get
            {
                return (DateTime.Now - DateOfBirth).Days / 365;
            }
        }


        //methods - TitleCase
        //access modifier   return type    name   code
        public void Bark()
        {
            Console.WriteLine($"{Name} barks loudly.");
        }

        public void SetDateOfBirth(DateTime dob)
        {
            DateOfBirth = dob;
        }


        

    }
}
