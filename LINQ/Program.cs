namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> games = new List<string>() { "Super Mario Bros. 3", "League of Legends", "Batman Arkham Asylum", "Pokemon Alpha Sapphire" };
            var gamesInOrder = games.OrderBy(x => x.Length);
            foreach (var game in gamesInOrder)
            {
                Console.WriteLine(game);
            }
        }
    }
}