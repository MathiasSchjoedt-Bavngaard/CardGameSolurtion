using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameClasses.Cards
{
    public interface ICard
    {
        public int getMaxnumber();

        public int getValue();
        public string getsuit();
        public int getNumber();

        public void setNumber(int number);
        public ICard ShallowCopy();
    }
}
