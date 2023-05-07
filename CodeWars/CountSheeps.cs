//https://www.codewars.com/kata/58e0f0bf92d04ccf0a000010/csharp

using System.Linq;
namespace CodeWars
{
    public class CountSheeps
    {
        public int lostSheep(int[] friday, int[] saturday, int total)
        {
            return total - friday.Sum() - saturday.Sum();
        }
    }
    
}