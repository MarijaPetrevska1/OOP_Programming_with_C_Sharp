
namespace Qinshift.ClassesAndObjects.Models
{
    public class Person
    {
        public Person()
        {
            SSN = GenerateSSN();
        }

   
        public Person(string fName, string lName, int age)
        {
            FirstName = fName;
            LastName = lName;
            Age = age;
            SSN = GenerateSSN();
        }


        
        public string FirstName { get; set; } = "Martin";
        public string LastName { get; set; }
        public int Age { get; set; }
        private long SSN { get; set; }

        private long GenerateSSN()
        {
            return new Random().Next(100000, 999999); 
        }

        public long GetSSN()
        {
            return SSN;
        }

        
        public void Talk(string text)
        {
            Console.WriteLine($"The human named {FirstName} is saying {text}!");
        }
    }
}
