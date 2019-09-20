using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your full name: ");

            try
            {
                string name = Console.ReadLine();

                Hello_Name(name);


                Console.WriteLine("");
                Console.Write("Now enter your age: ");
                string input = Console.ReadLine();
                int age = int.Parse(input);

                if ((age > 0) && (age <= 100))
                {
                    Drinking_Age(age);
                }
                else
                {
                    Console.WriteLine("Please enter a valid/realistic age");
                }
            }
            catch
            {
                Console.WriteLine("There was an error. Please exit and try again.");
            }
        } //End of Main method

        private static string Hello_Name(string get_name)
        {
            Console.WriteLine("");
            Console.Write("Hello " + get_name + "!");

            return get_name;
        }

        private static int Drinking_Age(int get_age)
        {
            Console.WriteLine("");
            int caluclate_drinking_age = 21 - get_age;

            if (caluclate_drinking_age >=0)
            {
                Console.WriteLine("You are not legally able to drink yet.");
            }
            else
            {
                Console.WriteLine("You are legally able to drink!");
            }

            return caluclate_drinking_age;
        }
    }
}
