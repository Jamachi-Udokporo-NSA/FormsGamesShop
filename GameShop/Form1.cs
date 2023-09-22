using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameShop
{
    public partial class Form1 : Form
    {
        // list of games
        Shop shop;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            shop = new Shop("GamePause");
            PSGame spiderman = new PSGame("Play Station", "Spiderman","Sony", Game.Condition.mint, 130, new DateTime(2012, 3, 13));
            PSGame avengers = new PSGame("Play Station", "Avengers","Sony", Game.Condition.poor, 293, new DateTime(2018, 10, 23));
            PSGame crowsFeet = new PSGame("Play Station", "Crows Feet", "Sony", Game.Condition.good, 88, new DateTime(2013, 7, 2));
            PSGame clashRoyal = new PSGame("Play Station", "Clash Royal", "Ubisoft", Game.Condition.fair, 69, new DateTime(2006, 4, 14));
            PSGame DragonBall = new PSGame("Play Station", "Dragon ball", "Sony", Game.Condition.mint, 75, new DateTime(2012, 7, 19));
            PSGame undertale = new PSGame("Play Station", "undertale", "Ubisoft", Game.Condition.poor, 84, new DateTime(2010, 11, 27));
            PSGame skate = new PSGame("Play Station", "Skate", "Sony", Game.Condition.mint, 74, new DateTime(2017, 8, 12));
            XboxGame MortalKombat = new XboxGame("Xbox", "Mortal Kombat", "Ubisoft", Game.Condition.poor, 59, new DateTime(2018, 10, 17));
            XboxGame cookingMama = new XboxGame("Xbox", "Cooking Mama", "Ubisoft", Game.Condition.good, 86, new DateTime(2004, 3, 24));
            XboxGame uncharted = new XboxGame("Xbox", "Uncharted", "Sony", Game.Condition.fair, 77, new DateTime(2018, 9, 16));
            // add the games to the games list
            shop.AddGame(spiderman);
            shop.AddGame(avengers);
            shop.AddGame(crowsFeet);
            shop.AddGame(clashRoyal);
            shop.AddGame(DragonBall);
            shop.AddGame(undertale);
            shop.AddGame(skate);
            shop.AddGame(MortalKombat);
            shop.AddGame(cookingMama);
            shop.AddGame(uncharted);
            DisplayGame();
        }

        // Method to display currently viewed game
        private void DisplayGame()
        {
            labelCurrentGame.Text = string.Format("Viewing {0} of {1}",
                shop.GameCurrentlyViewed + 1, shop.NumberOfGames);
            textBoxGame.Text = shop.DescribeCurrentGame();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            shop.StepToPreviousGame();
            DisplayGame();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            shop.StepToNextGame();
            DisplayGame();
        }
    }
}
