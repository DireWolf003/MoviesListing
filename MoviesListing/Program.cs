namespace MoviesListing
{
    internal class Program
    {
        static MovieManager movieManager = new MovieManager();
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("1: Add Movie");
            Console.WriteLine("2: List Movies");
            string? choice = Console.ReadLine();
            if (choice == "1")
            {
                Add();
            }
            else if (choice == "2")
            {
                List();
            }
        }

        static void List()
        {
            Console.Clear();
            Console.WriteLine("LIST MENU");
            Console.WriteLine();
            foreach (Movie m in movieManager.Movies)
            {
                Console.WriteLine($"Title: {m.Title}, Duration: {m.Duration}, Year: {m.Year}");
            }

            movieManager.MoviesAfter2000();
            Console.WriteLine();
            movieManager.SearchMovei();
            Console.WriteLine();
            movieManager.ShortMovie();
            Console.ReadLine();
            Menu();
        }

        static void Add()
        {
            Console.Clear();
            Console.WriteLine("ADD MENU");

            Movie m = new Movie();

            Console.Write("Movie Title: ");
            m.Title = Console.ReadLine() ?? "";

            Console.Write("Movie Duration: ");
            m.Duration = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Movie Year: ");
            m.Year = int.Parse(Console.ReadLine() ?? "0");

            movieManager.Add(m);

            //Console.ReadLine();
            Menu();
        }
    }
}
