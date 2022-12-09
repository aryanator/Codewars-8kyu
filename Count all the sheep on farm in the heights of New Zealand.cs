using System;
using System.Linq;
namespace CodeWars
{
    public class Kata
    {
        public int lostSheep(int[] friday, int[] saturday, int total)
        {
            // Code here
         return total - friday.Sum() - saturday.Sum();
        }
    }
}
