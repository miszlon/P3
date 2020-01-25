using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10
{
    public class Person
    {
        public Person(string name, string lastName, string phone, int iD)
        {
            
            Name = name;
            LastName = lastName;
            Phone = phone;
            ID = iD;
        }

        
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public int ID { get; set; }
    }
}
