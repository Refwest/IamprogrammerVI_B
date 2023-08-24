using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IamprogrammerVI_B
{
    internal class Person
    {
        string name;
        int age;

        //// !59 Static Keyword
        public static int Count;        //Static

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            Count++;    //Static
        }

      
        //// Next
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;

            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
            
    }
}
