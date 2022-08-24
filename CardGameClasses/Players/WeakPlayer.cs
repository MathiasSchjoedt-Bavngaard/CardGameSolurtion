using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGameClasses.Cards;

namespace CardGameClasses.Players
{
    public class WeakPlayer : IPlayer
    {

        private string _name = "unknownplayer";
        private List<ICard> _hand; //den hånd spilleren har
        private int _totalValue = 0; //til test
        private int _Handlimit = 3;

        public WeakPlayer(string name = "unkwownplayer")
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
            //tjek om der er maks kort 
            if (_hand.Count() >= _Handlimit)
            {
                //fjern den laveste

                _hand.Remove(findMinimum());
            }
            //tilføjer kort og værdig
            _hand.Add(Card);


        }

        //finder det laveste kort til at fjerne det.
        private ICard findMinimum()
        {
            ICard lowest = _hand.ElementAt(0);
            foreach (var ICard in _hand)
            {
                if (lowest.getValue() > ICard.getValue())
                    lowest = ICard;
            }
            return lowest;
        }


        public void resetHand()
        {
            _totalValue = 0;
            _hand.Clear();
        }


    }
}
