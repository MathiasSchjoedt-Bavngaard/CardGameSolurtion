namespace CardGameClasses.Cards
{
    public class BlueCard : ICard
    {

        private readonly string _suit = "Blue  ";
        private readonly int _suitValue = 2;
        private int _number = 0;
        private int _MaxNumber = 8;

        private int Value = 0;

        public BlueCard(int number = 0)
        {
            if (number > 0 && number <= 8)
                _number = number;
        }
        public ICard ShallowCopy()
        {
            return (ICard)MemberwiseClone();
        }
        public int getMaxnumber() { return _MaxNumber; }
        public int getValue()
        {
            Value = _suitValue * _number;
            return Value;
        }

        public string getsuit()
        {
            return _suit;
        }

        public int getNumber()
        {
            return _number;
        }

        public void setNumber(int number)
        {
            if (number > 0 && number <= 8)
                _number = number;
            getValue();
        }
    }
}