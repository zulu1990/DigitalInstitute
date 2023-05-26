namespace Task
{
    class Bird : Animal
    {
        private const string speciesName = "Bird";
        public override string Species { get; init; }

        public Bird(string name) : base(name)
        {
            Species = speciesName;
        }

        public Bird(string name, int age) : base(name, age)
        {
            Species = speciesName;
        }

        public Bird(string name, int age, string color) : base(name, age, color)
        {
            Species = speciesName;
        }

        public override void Move()
        {
            Console.WriteLine($"The {Species.ToLower()} flies");
        }

        public override void GetDetails()
        {
            Console.WriteLine($"Name: {base.Name}{Environment.NewLine}Age: {base.Age}{Environment.NewLine}Color: {base.Color}");
        }

    }
}
