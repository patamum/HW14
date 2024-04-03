namespace Task14_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Мурка", "Мяу", "белая");
            Dog dog = new Dog("Шарик", "Гав");
            cat.ShowInfo();
            dog.ShowInfo();
        }
    }
}