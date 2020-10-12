using System;

namespace Task_Interface
{
    public class Human : Mammal, IMovable
    {
        private string name;

        public Human(string name, bool gender)
        {
            this.name = name;
            this.gender = gender;
        }
        
        public void move()
        {
            Console.WriteLine("Человек по имени " + this.name + " пошёл.");
        }

        public override void feedWithMilk()
        {
            if (this.gender == false) {
                Console.WriteLine("Человек по имени " + this.name + " покормил своего детёныша молоком.");
            }
            else
            {
                Console.WriteLine("Человек не смог покормить, поскольку не того пола.");
            }
        }
    }
}