using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGameClasses.Cards;

namespace CardGameClasses.Players
{
    public class StrongPlayer : IPlayer
    {
        private string _name = "unknownplayer";
        private List<ICard> _hand; //den hånd spilleren har
        private int _totalValue = 0; //til test

        public StrongPlayer(string name = "unkwownplayer")
        {
            _hand = new List<ICard>();
            _name = name;

        }

        public string getName()
        {
            return _name;
        }

        public void showHand()
        {
            Console.WriteLine("player: " + getName() + "has: ");
            int cardNr = 0;

            foreach (var ICard in _hand)
            {
                cardNr++;
                Console.WriteLine("cardnr " + cardNr + ":  " + ICard.getsuit() + " " + ICard.getNumber() + "  med værdig: " + ICard.getValue());

            }
            Console.WriteLine("total value:  " + getTotalvalue() + " \n");
        }
        public int getTotalvalue()
        {
            _totalValue = 0;
            foreach (var ICard in _hand)
            {
                _totalValue = _totalValue + ICard.getValue();

            }
            return _totalValue;
        }

        public void addCard(ICard Card)
        {
            _hand.Add(Card);

        }

        public void resetHand()
        {

            _hand.Clear();
        }

    }
}
