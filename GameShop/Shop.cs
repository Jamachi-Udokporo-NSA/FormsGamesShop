using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShop
{
    // encapsulation class. Getters and setters
    class Shop
    {
        private string shopName;
        private List<Game> gamesForSale;
        private int currentlyViewedGame = 0;

        // Constructor
        public Shop(string shopName)
        {
            this.shopName = shopName;
            gamesForSale = new List<Game>();
        }

        // Get method for game currently viewed
        public int GameCurrentlyViewed
        {
            get { return currentlyViewedGame; }
        }

        // Get method to return number of games in stock
        public int NumberOfGames
        {
            get { return gamesForSale.Count; }
        }

        // Method to return available games' description
        public string DescribeCurrentGame()
        {
            string description;
            // if any games are available, show its description
            if (gamesForSale.Count > 0)
            {
                description = gamesForSale[currentlyViewedGame].Description();
            }
            else
            {
                description = "There are no games in stock";
            }
            return description;
        }

        // Method to add games to the list
        public void AddGame(Game game)
        {
            gamesForSale.Add(game);
        }

        // Method to remove game located at index of the list
        public void RemoveGameAt(int index)
        {
            if (index < gamesForSale.Count)
            {
                gamesForSale.RemoveAt(index);
                //Ensure currentlyViewedGame is either zero or pointing at an existing game
                ChangeCurrentGameDisplayed();
            }
        }

        public void ChangeCurrentGameDisplayed()
        {
            if (currentlyViewedGame > (gamesForSale.Count - 1))
            {
                currentlyViewedGame = gamesForSale.Count - 1;
                // This will be -1 if stock is zero
                if (currentlyViewedGame < 0)
                {
                    currentlyViewedGame = 0; // make sure it is current or zero....
                }
            }
        }

        //Method to check if there is a previous vehicle in the list.
        public bool IsPreviousGame()
        {
            if (currentlyViewedGame > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Method to check if there is a next vehicle in the list.
        public bool IsNextGame()
        {
            if (currentlyViewedGame < gamesForSale.Count - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void StepToPreviousGame() //Method to move to the previous vehicle in the list
        {
            if (IsPreviousGame())
            {
                currentlyViewedGame--;
            }
        }
        public void StepToNextGame() // Method to move to the next vehicle in the list.
        {
            if (IsNextGame())
            {
                currentlyViewedGame++;
            }
        }
    }
}
