public class BasicAccount
{
    protected string Name { get; set; }
    protected uint Rating { get; set; }
    protected uint GamesCount { get { return (uint) GameList.Count; } }
    protected double Coeficient { get; set; }
    protected List<Game> GameList { get; set; }
    public BasicAccount(string name)
    {
        Name = name;
        Rating = 1;
        Coeficient = 1;
        GameList = new List<Game>();
    }
    public virtual void WinGame(Game game)
    {
        GameList.Add(game);
        Rating += game.Score;
    }
    public virtual void LoseGame(Game game)
    {
        GameList.Add(game);
        if (Rating > game.Score) Rating -= (uint)(game.Score * Coeficient);
    }
    public List<Game> GetStats()
    {
        Console.WriteLine(this.Name + " Status:\nRating- " + this.Rating + "\tGames Played- " + this.GamesCount + "\tAccount type- " + this.GetType());
        foreach (Game game in GameList)
        {
            Console.Write("Winner- ");
            Console.Write(game.Winner.Name);
            Console.Write("\tLoser- ");
            Console.Write(game.Loser.Name);
            Console.Write("\tScore- ");
            Console.Write(game.Score);
            Console.WriteLine("\tID- " + game.GameId + "\tType- " + game.GetType());
        }
        return GameList;
    }
}