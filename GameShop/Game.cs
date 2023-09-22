using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShop
{
    public abstract class Game
    {
        // Condition of a game
        public enum Condition
        {
            poor,
            fair,
            good,
            mint
        }

        protected string console;
        protected string gameTitle;
        protected string gameDev; // game developer
        protected Condition condition;
        protected decimal originalPrice;
        protected DateTime releaseDate;

        // constructor
        public Game(string console, string gameTitle, string gameDev, Condition condition, decimal originalPrice, DateTime releaseDate)
        {
            this.console = console;
            this.gameTitle = gameTitle;
            this.gameDev = gameDev;
            this.condition = condition;
            this.originalPrice = originalPrice;
            this.releaseDate = releaseDate;
        }

        public string GetCondition()
        {
            string conditionName = Enum.GetName(typeof(Condition), condition);
            return conditionName;
        }

        // method to calculate the age of a game  in years
        public int CalculateApproxinateAgeInYears()
        {
            DateTime now = DateTime.Now;
            TimeSpan ageAsTimeSpan = now.Subtract(releaseDate);
            int ageInYears = ageAsTimeSpan.Days / 365;
            return ageInYears;
        }

        // method to be overriden that calculates the value of a game
        public abstract decimal CalculateApproximateValue();

        // method to build a description of the game
        public virtual string Description()
        {
            string condionName = Enum.GetName(typeof(Condition), condition); // gets the enumeration name instead of it's value
            // build a string describing current game
            string description = string.Format("Console: {0}{1}Game Title: {2}{3}Game Dev: {4}{5}Condtion: {6}{7}Current Value: {8:c}",
                console,
                Environment.NewLine,
                gameTitle,
                Environment.NewLine,
                gameDev,
                Environment.NewLine,
                condionName,
                Environment.NewLine,
                CalculateApproximateValue()
                );

            return description;
        }
    }
}
