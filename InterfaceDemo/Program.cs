namespace InterfaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Console.WriteLine("Hello, World!");
            animal.Eat();
            Dog dog = new Dog();
            dog.Eat();
            dog.MakeSound();
            Cat cat = new Cat();
            cat.Eat();
            cat.MakeSound();
            Console.ReadLine();
        }
    }
}
