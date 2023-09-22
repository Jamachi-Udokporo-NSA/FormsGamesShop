using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShop
{
    // inherits from Game class
    public class PSGame : Game
    {
        // constructor
        public PSGame(string console, string gameTitile, string gameDev, Condition condition, decimal originalPrice, DateTime releaseDate) : base(console, gameTitile, gameDev, condition, originalPrice, releaseDate)
        {
            // no new attributes needed
        }

        // overriden method to calculate the value of a game
        public override decimal CalculateApproximateValue()
        {
            decimal value = 0;

            // alter the car's value based on condition
            if (condition == Condition.mint)
            {
                value = originalPrice * 0.8m; // 90% of original value
            }
            else if (condition == Condition.good)
            {
                value = originalPrice * 0.7m; // 80% of original value
            }
            else if (condition == Condition.fair)
            {
                value = originalPrice * 0.5m; // 70% of original value
            }
            else if (condition == Condition.poor)
            {
                value = originalPrice * 0.4m; // 50% of original value
            }
            int age = CalculateApproxinateAgeInYears();

            for (int i = 0; i < age; i++)
            {
                // lose 20 percent each year old
                value = value * 0.8m;
            }
            // round to the nearest pound
            value = Decimal.Round(value, 0);
            // round to the nearest £10
            value = value - (value % 10);
            // and then adds £99
            value = value + 99;
            return value;
            //throw new NotImplementedException();
        }
    }
}
