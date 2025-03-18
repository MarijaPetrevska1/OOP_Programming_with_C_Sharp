using Task1.Models;

namespace Task1.Models
{
    // Car class
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver CarDriver { get; set; }

        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }

        // Calculating the speed considering the driver's skill
        public int CalculateSpeed()
        {
            return Speed * CarDriver.Skill;
        }
    }
}
