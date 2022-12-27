namespace Addressbook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Addressbook program");

            Addressbook ab = new Addressbook("Abhilash", "Abhi", "harohalli", "karnataka", "bangalore", 560087, 09876554321, "abhiabc75@gmail.com");
            ab.displaycontact();
        }
    }
}