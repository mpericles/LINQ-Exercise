namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //create a list of string .Orderby
            List<string> VideoGames = new List<string>()
            {
                "Gameboy",
                "Tetris",
                "Pacman",
                "Candycrush"
            };
            VideoGames.Add("joystick");
            //populate the list .Add
            VideoGames.Add("joystick");
            VideoGames.Add("toystick");

            //sort the list by string lenght . lenght
            Console.WriteLine();
            Console.WriteLine("List Sorted by the Length of the VideoGame Name");
            var SortedVideoGames = VideoGames.OrderBy(x => x.Length);
            foreach ( var videoGame in SortedVideoGames)
            { Console.WriteLine(videoGame); };


        }
    }
}
