using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CardGameClasses.Cards;
using CardGameClasses.Players;

namespace CardGameClasses
{
    //her læres virkelig noget om interfaces
    internal class Deck
    {
        private readonly List<ICard> _pile; // //den bunke af kort som skal deles ud
        private readonly List<ICard> _cardTypes; // den type af kort der findes i bunken. bruges til at bygge bunken op

        public Deck()
        {
            _pile = new List<ICard>();
            _cardTypes = new List<ICard>();
            ResetPile(); //bygger bunken op

        }

        public void ResetPile()
        {
            //fjerner alt i bunken
            _pile.Clear(); 

            //vi kigger på korttypen her
            foreach (var ICard in _cardTypes)  
            {
                // der tjekkes hvormange kort der skal være af hver Type
                for (int i = 1; i < ICard.getMaxnumber()+1; i++) 
                {
                    ICard.setNumber(i); //ændre nummeret af korttypen

                    //System.Console.WriteLine("type"+ICard.GetType().ToString()+"nummer: "+ICard.getNumber());

                    //da der ikke kan oprettes et nyt kort via en Interface laver vi op på Det kort som ligger i _cardType og 
                    _pile.Add(ICard.ShallowCopy());             //opretter en copi af den farve som så tilføjes til _pile

                }
            }
            
             //bunken blandes
            _pile.Shuffle();
            _pile.Shuffle();
            _pile.Shuffle();
            

        }

        public void DealCards(IPlayer _player,int number)
        {
            //vi laver forloop til at flytte kort fra bunken til en spiller
            for (int i = 0; i < number; i++)
            {

                if (_pile.Count > 0)
                {   
                  
                    _player.addCard(_pile.ElementAt(0));
                    _pile.RemoveAt(0);
                }
            }

        }

        //funktion til at tilføje en korttype til vores dæk
        public void AddCardType(ICard cardType) 
        {
            _cardTypes.Add(cardType);
        }

    }

}
