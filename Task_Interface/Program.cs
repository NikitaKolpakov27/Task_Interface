namespace Task_Interface
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Human human = new Human("Алеша", true);
            Cat cat = new Cat("Мурка", false);
            
            cat.move();
            human.move();
            
            human.feedWithMilk();
            cat.feedWithMilk();
        }
    }
}