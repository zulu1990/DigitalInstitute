namespace Task
{
    // abstract class
    public abstract class Character : IDisposable
    {

        private string _name;
        private double _health;
        private double _strength;
        private double _availablePoints;
        private Weapon _weapon;
        //private Weapon Weapons { get; set; } = new Weapon();


        // Properties
        public string Name
        {
            get => _name;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("Name can't be empty\n");
                }
                _name = value;
            }
        }
        public double Health
        {
            get => _health;
            set
            {
                if (value < 0)
                {
                    // throw new ArgumentOutOfRangeException("Health can't be less than 0\n");
                    Console.WriteLine("character died");
                    return;
                }
                if (value > 100)
                {
                    throw new ArgumentOutOfRangeException("Health can't be more than 100\n");
                }
                _health = value;
            }
        }
        public double Strength
        {
            get => _strength;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Strength can't be less than 0\n");
                }
                _strength = value;

            }
        }
        public double AvailablePoints
        {
            get => _availablePoints;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Points can't be less than 0\n");
                }
                _availablePoints = value;
            }
        }
        public Weapon Weapon
        {
            get => _weapon;
            set => _weapon = value;
        }

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
                coloredHealth = $"\u001b[37m{Health}\u001b[0m";
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


