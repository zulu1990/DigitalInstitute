namespace Task
{
    class Fish : Animal
    {
        private const string speciesName = "Fish";
        public override string Species { get; init; }

        public Fish(string name) : base(name)
        {
            Species = speciesName;
        }

        public Fish(string name, int age) : base(name, age)
        {
            Species = speciesName;
        }

        public Fish(string name, int age, string color) : base(name, age, color)
        {
            Species = speciesName;
        }

        public override void Move()
        {
            Console.WriteLine($"The {Species.ToLower()} swims");
        }

        public override void GetDetails()
        {
            Console.WriteLine($"Name: {base.Name}{Environment.NewLine}Age: {base.Age}{Environment.NewLine}Color: {base.Color}");
        }

    }
}
