using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CardGameClasses.Cards;

namespace CardGameClasses.Players
{
    public interface IPlayer
    {
        public string getName();
        public void showHand();

        public int getTotalvalue();

        public void addCard(ICard Card);

        public void resetHand();

    }
}
