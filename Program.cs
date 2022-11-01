using Hilo.Game;

namespace Hilo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hilo!");
            
            Director director = new Director();
            director.StartGame();
        }
    }

}