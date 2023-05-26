namespace Task
{
    sealed class Cat : Animal
    {
        private const string speciesName = "Cat";
        public override string Species { get; init; }

        public Cat(string name) : base(name)
        {
            Species = speciesName;
        }

        public Cat(string name, int age) : base(name, age)
        {
            Species = speciesName;
        }

        public Cat(string name, int age, string color) : base(name, age, color)
        {
            Species = speciesName;
        }

        public override void Move()
        {
            Console.WriteLine($"The {Species.ToLower()} runs");
        }

        public override void GetDetails()
        {
            Console.WriteLine($"Name: {base.Name}{Environment.NewLine}Age: {base.Age}{Environment.NewLine}Color: {base.Color}");
        }

    }
}
