// See https://aka.ms/new-console-template for more information

namespace Testing
{

    public class Test
    {
        public Test(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public string Name { get; set; }
        public string Surname { get; set; }

        public override string ToString()
        {
            return Name + " " + Surname;
        }

    }

    public class Animal
    {
        public DateTime BirthDate { get; set; }
        public string Name { get; set; }       
    }

    public class Dog : Animal
    {
        public int Id { get; set; }
    }
    public class Cat: Animal
    {
        public int Id { get; set; }
    }

    

    public static class Testing
    {
        public static void Main()
        {      
            Test test = new Test("Test1", "Surname 1");
            Console.WriteLine(test.ToString());
        }
    }
}
