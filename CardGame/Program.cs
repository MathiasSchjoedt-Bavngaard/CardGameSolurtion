
using CardGameClasses;
using CardGameClasses.Players;
using CardGameClasses.Cards;

using System.Numerics;

namespace CardGame.applikation
{
    public class Program
    {
        public static void Main()
        {
            Game mitSpil = new Game(); 

            mitSpil.AddPlayer(new StrongPlayer("simon"));
            mitSpil.AddPlayer(new WeakPlayer("torben"));
            mitSpil.AddPlayer(new StrongPlayer("alexandra"));

            mitSpil.AddCard(new BlueCard());
            mitSpil.AddCard(new GreenCard());
            mitSpil.AddCard(new YellowCard());
            mitSpil.AddCard(new RedCard());
            mitSpil.AddCard(new GoldCard());

            mitSpil.StartGame(10);




        }
    }
}