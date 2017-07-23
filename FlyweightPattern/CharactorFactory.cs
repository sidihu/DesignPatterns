using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class CharactorFactory
    {
        public Hashtable hashTable = new Hashtable();

        public Charactor GetCharactor(string symbol)
        {
            Charactor c = hashTable[symbol] as Charactor;

            if(c==null)
            {
                switch(symbol.ToUpper())
                {
                    case "A":
                            c = new CharactorA();
                        break;
                    case "B":
                        c = new CharactorB();
                        break;
                    case "C":
                        c = new CharactorC();
                        break;
                    default:
                        c = new CharactorA();
                        break;
                }
                hashTable.Add(symbol, c);
            }

            return c;
        }
    }
}
