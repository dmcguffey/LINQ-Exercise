namespace LINQ
{
    public class Program
    {
        public static void OrderTitles(string[] titles)
        {
            var orderedTitles = titles.OrderBy(title => title.Length);
            foreach (var title in orderedTitles)
            {
                Console.WriteLine(title);
            }
        }
        static void Main(string[] args)
        {
            string[] videoGames = { "God of War", "NBA2K", "Need for Speed", "Legend of Zelda" };
            OrderTitles(videoGames);
        }
    }
}
