using System;

namespace AdressVerwaltung
{
    public class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }

        public Person(string name, string address, string phone, int age)
        {
            Name = name;
            Address = address;
            Phone = phone;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nAddress: {Address}\nPhone: {Phone}\nAge: {Age}";
        }
    }
} 