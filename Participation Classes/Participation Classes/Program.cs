namespace Participation_Classes
{
    public class Character 
    {
        public string name;
        public int exp = 0;
    
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Character hero = new Character();
            Console.WriteLine("Hero: " + hero.name + " - " + hero.exp + " EXP");
            
        }
    }
}
