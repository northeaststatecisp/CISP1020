namespace _04_AbstractClasses
{
    internal class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"My name is {Name} and I go Meow!");
        }
    }
}
