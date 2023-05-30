namespace Task
{

    public class Weapon : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine($"Weapon has been disposed");
        }
    }
}
