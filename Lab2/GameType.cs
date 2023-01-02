public enum GameTypes
{
    Training, Basic, Double
}
public class GameType
{
    public static Game CreateGame(BasicAccount Winner, BasicAccount Loser, uint Score, GameTypes gameType)
    {
        switch (gameType)
        {
            case GameTypes.Double:
            return new DoubleGame(Winner, Loser, Score);
            case GameTypes.Basic:
            return new BasicGame(Winner, Loser, Score);
            case GameTypes.Training:
            return new TrainingGame(Winner, Loser);
            default:
            throw new ArgumentException("No game");
        }
    }
}