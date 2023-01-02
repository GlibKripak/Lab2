public class BasicGame : Game
{
    public BasicGame(BasicAccount Winner, BasicAccount Loser, uint Score) : base(Winner, Loser)
    {
        this.Score = Score;
        Winner.WinGame(this);
        Loser.LoseGame(this);
    }
}