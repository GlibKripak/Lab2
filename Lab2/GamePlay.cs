﻿public class GamePlay
{
    public static void Main(string[] args)
    {
        BasicAccount player1 = new BasicAccount("Ben");
        BasicAccount player2 = new CheatAccount("Leo");
        BasicAccount player3 = new KomboAccount("Alex");
        Play(player1, player2, 0, GameTypes.Training);
        Play(player1, player3, 10, GameTypes.Basic);
        Play(player1, player2, 10, GameTypes.Double);
        Play(player2, player3, 0, GameTypes.Training);
        Play(player2, player1, 10, GameTypes.Basic);
        Play(player2, player3, 10, GameTypes.Double);
        Play(player3, player1, 0, GameTypes.Training);
        Play(player3, player2, 10, GameTypes.Basic);
        Play(player3, player1, 10, GameTypes.Double);
        Play(player1, player2, 0, GameTypes.Training);
        Play(player1, player3, 10, GameTypes.Basic);
        Play(player1, player2, 10, GameTypes.Double);
        Play(player2, player3, 0, GameTypes.Training);
        Play(player2, player1, 10, GameTypes.Basic);
        Play(player2, player3, 10, GameTypes.Double);
        Play(player3, player1, 0, GameTypes.Training);
        Play(player3, player2, 10, GameTypes.Basic);
        Play(player3, player1, 10, GameTypes.Double);
        player1.GetStats();
        player2.GetStats();
        player3.GetStats();
    }
    public static void Play(BasicAccount player1,BasicAccount player2, uint score, GameTypes gameType)
    {
        Random random = new Random();
        if (random.Next(0, 2) == 1)
        {
            GameType.CreateGame(player1,player2,score, gameType);
        }
        else
        {
            GameType.CreateGame(player2, player1, score, gameType);
        }
    }
}