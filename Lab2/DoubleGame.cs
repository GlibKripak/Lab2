public class DoubleGame : Game
{
    public DoubleGame(BasicAccount Winner, BasicAccount Loser, uint Score) : base(Winner, Loser)
    {
        this.Score = Score*2;
        Winner.WinGame(this);
        Loser.LoseGame(this);
    }
}