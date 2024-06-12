using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon {
    public static class GameLogic
    {
        private static List<Pokemon> _starter = new List<Pokemon>()
        {
            new Pokemon("Pikachu", 500, 1000, 100),
            new Pokemon("Levi", 1000, 5000, 200),
            new Pokemon("Viktor", 5000, 10000, 100)
        };

        public static void Run()
        {
            var name = "What is your name: ".RequestString();
            var starter = ChooseStarter();
            var you = new Trainer(name, starter);

            Console.WriteLine(you.Name);
            Console.WriteLine(you._Pokemon.FirstOrDefault().Name);
        }

        private static string RequestString(this string Messages)
        {
            Console.Write(Messages);
            return Console.ReadLine();
        }

        private static Pokemon ChooseStarter()
        {
            for (int i = 0; i < _starter.Count; i++)
            {
                var count = _starter[i];
                Console.WriteLine($"{i}. Name: {count.Name} HP: {count.HP} power: {count.Attakpower} Lvl: {count.Level}");
            }
            
     
            Console.WriteLine("Choose starter: ");
            int.TryParse(Console.ReadLine(), out int result);
            return _starter[result];
        }
    }
}
