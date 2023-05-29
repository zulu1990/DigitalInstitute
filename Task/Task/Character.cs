namespace Task
{
    // abstract class
    public abstract class Character : IDisposable
    {

        private string name;
        private double health;
        private double strength;
        private double availablePoints;
        //private Weapon Weapons { get; set; } = new Weapon();


        // Properties
        public string Name
        {
            get => name;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("Name can't be empty\n");
                }
                name = value;
            }
        }
        public double Health
        {
            get => health;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Health can't be less than 0\n");
                }
                if (value > 100)
                {
                    throw new ArgumentOutOfRangeException("Health can't be more than 100\n");
                }
                health = value;
            }
        }
        public double Strength
        {
            get => strength;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Strength can't be less than 0\n");
                }
                strength = value;

            }
        }
        public double AvailablePoints
        {
            get => availablePoints;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Points can't be less than 0\n");
                }
                availablePoints = value;
            }
        }
        private Weapon Weapon { get; set; }

        // Constructors(parameterless/with parameters)
        public Character()
        {
            Name = "Default";
            Health = 100;
            Strength = 100;
            AvailablePoints = 0;
        }
        // overloaded constructor
        public Character(string name) : this()
        {
            Name = name;
        }
        // overloaded constructor
        public Character(string name, double health, double strength, double availablePoints) : this(name)
        {
            Health = health;
            Strength = strength;
            AvailablePoints = availablePoints;
        }

        // abstract class
        public abstract void Attack(Character oponent);

        public override string ToString()
        {
            string coloredHealth;
            if (Health == 0)
            {
                coloredHealth = $"\u001b[31m{Health}\u001b[0m";
            }
            else
            {
                coloredHealth= $"\u001b[37m{Health}\u001b[0m";
            }
            string coloredName = $"\u001b[32m{Name}\u001b[0m";
            return $"{nameof(Name)}: {coloredName}\n{nameof(Health)}: {coloredHealth}\n" +
                $"{nameof(Strength)}: {Strength}\n{nameof(AvailablePoints)}: {AvailablePoints}\n";
        }

        public void Dispose()
        {
            Weapon?.Dispose();
        }

    }
}


