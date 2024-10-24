namespace Participation_Classes
{
    public class Character 
    {
        public string name;
        public int exp = 0;

        public Character ()
        {
            name = "Not Assigned";
        }

        public Character(string name)
        { 
            this.name = name;
        }
    
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Character hero = new Character();
            Console.WriteLine("Hero: " + hero.name + " - " + hero.exp + " EXP");

            Character heroine = new Character("Agatha");
            Console.WriteLine("Hero: " + heroine.name + " - " + heroine.exp + " EXP");

        }
    }
}
