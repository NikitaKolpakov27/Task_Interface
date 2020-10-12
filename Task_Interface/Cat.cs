using System;

namespace Task_Interface
{
    public class Cat : Mammal, IMovable
    {
        private string name;
        
        public Cat(string name, bool gender)
        {
            this.name = name;
            this.gender = gender;
        }

        public void move()
        {
            if (gender == false)
            {
                Console.WriteLine("Кошка по имени " + name + " пошла.");
            }
            else
            {
                Console.WriteLine("Кот по имени " + name + " пошёл.");
            }
        }

        public override void feedWithMilk()
        {
            if (gender == false)
            {
                Console.WriteLine("Кошка по имени " + this.name + " покормила своего детёныша молоком.");
            }
            else
            {
                Console.WriteLine("Не удалось покормить, поскольку кот не того пола.");
            }
        }
    }
}