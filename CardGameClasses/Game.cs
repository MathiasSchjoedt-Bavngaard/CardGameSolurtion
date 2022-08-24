using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGameClasses.Cards;
using CardGameClasses.Players;

namespace CardGameClasses
{
    public class Game
    {
        private readonly List<IPlayer> players;
        private readonly Deck spilleDeck;
        private List<IPlayer> winners;


        public Game()
        {
            this.spilleDeck = new Deck();
            this.players = new List<IPlayer>();
            this.winners = new List<IPlayer>();

        }

        public void AddCard(ICard card)
        {
            spilleDeck.AddCardType(card);

        }

        public void AddPlayer(IPlayer _playername)
        {
            
            if (!players.Exists(x => x.getName() == _playername.getName()))
            {
                players.Add(_playername);
            }
        }

        public void ShowWinner()
        {
           winners.Clear();
           winners.Add(players[0]);

            foreach (var Player in players)
            {
                if (Player.getTotalvalue() > winners.ElementAt(0).getTotalvalue())
                {
                    winners.Clear();
                    winners.Add(Player);
                }
                else if (Player.getTotalvalue() == winners.ElementAt(0).getTotalvalue())
                {
                    winners.Add(Player);
                }
            }
            
           winners = winners.Distinct().ToList(); //removes Duplicates
            System.Console.WriteLine("The winners is:  ");

            foreach (var Player in winners) { System.Console.WriteLine(Player.getName()+"  "); }
        }




        public void StartGame(int numberOfCards)
        {
            spilleDeck.ResetPile();
            foreach (var player in players)
            {
                spilleDeck.DealCards(player, numberOfCards);

            }

            System.Console.WriteLine("alle spillere har fået kort: \n hvilke kort har i?");
            foreach (var player in players)
            {
                player.showHand();

            }

            ShowWinner();


        }

        public void ResetSpil()
        {
            spilleDeck.ResetPile();
            foreach (var player in players) { player.resetHand(); }
        }

    }
}
