public class KomboAccount : BasicAccount
{
    private uint Kombo { get; set; }
    public KomboAccount(string name) : base(name)
    {
        Kombo = 1;
    }
    public override void WinGame(Game game)
    {
        GameList.Add(game);
        if (game.GetType() == typeof(TrainingGame)) return;
        if (Kombo == 3)
        {
            Rating += game.Score * 10;
            Kombo = 1;
        }
        else
        {
            Rating += game.Score;
            Kombo++;
        }
    }
    public override void LoseGame(Game game)
    {
        GameList.Add(game);
        if (game.GetType() == typeof(TrainingGame)) return;
        if (Rating > (uint)(game.Score * Coeficient))
        {
            Rating -= (uint)(game.Score * Coeficient);
        }
        else
        {
            Rating = 1;
        }
        Kombo = 1;
    }
}