namespace Task
{

    internal class Weapon : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine($"Wipon has been disposed");
        }
    }
}
