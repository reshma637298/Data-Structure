using System;
using System.Linq;
namespace Datastructures
{
    class Program
    {
        static void Main(string[] args)
        {
            // petrol_price p = new petrol_price();
            // p.sellOrBuy();

            DictionaryCrud d = new DictionaryCrud();
            var result = d.dictionaryCreate();
            d.dictionaryAccess(result);
            d.dictionaryRemove(result);

            hash h = new hash();
            var hashresult = h.hashCreate();
            h.hashremove(hashresult);
        }
    }
}







                // for (int i = 0; i < rear - 1; i++)
                // {
                //     order[i] = order[i + 1];
                // }
                // rear--;
                // if(rear < limit)
                // {
                //     order[rear] = 0;
                    
                   
                // }