﻿using System;

namespace ConsoleApp4
{
    class Person
    {
        public int age;
        public Person(int initialAge)
        {
            this.age = initialAge;
        }
        public void amIOld()
        {
            // Do some computations in here and print out the correct statement to the console 
            if (this.age < 0)
            {
                this.age = 0;
                Console.WriteLine("Age is not valid, setting age to 0.");
            }
            else if (this.age < 13) Console.WriteLine("You are young.");
            else if (this.age >= 13 && this.age < 18) Console.WriteLine("You are a teenager.");
            else Console.WriteLine("You are old");
        }

        public void yearPasses()
        {
            // Increment the age of the person in here
            this.age = this.age + 1;
        }

        static void Main(String[] args)
        {
            int T = int.Parse(Console.In.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int age = int.Parse(Console.In.ReadLine());
                Person p = new Person(age);
                p.amIOld();
                for (int j = 0; j < 3; j++)
                {
                    p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();
            }
        }
    }
}