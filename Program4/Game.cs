using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Program4
{
    public partial class Game : Form
    {
        //Initialized to hold map creation
        string output = "";
        //Used to keep track if the game is running 
        bool running = false;

        //Initializes object
        NavigationSystem navigationSystem;
        FindTheIslandGame game;

        //Size of the map variables
        int MapRowCount;
        int MapColumnCount;

        public Game()
        {
            InitializeComponent();

        }

        public void MapSizeButton_Click(object sender, EventArgs e)
        {

            running = true;
            //Gets data from form controls
            MapRowCount = Int32.Parse(MapRows.Text);
            MapColumnCount = Int32.Parse(MapCol.Text);

            //Max map size that we will expect is 11x11 if it's bigger then we need to check variables
            //Checking to make sure map initialization is in bounds
            MapRowCount = (MapRowCount>11 || MapRowCount<1) ? 10 : MapRowCount;
            MapColumnCount = (MapColumnCount>11 || MapColumnCount<1) ? 10 : MapColumnCount;


            //Initializes map from map size
            navigationSystem = new NavigationSystem(MapRowCount, MapColumnCount);

            game = new FindTheIslandGame();

            //References the creation of map processes and sets equal to label
            navigationSystem.PrintMap(ref output);
            MapOutput.Text = output;

            //Resets map size texts
            MapRows.Text = "";
            MapCol.Text = "";
            
            //Prohibits any further changes to the map size when game starts
            if (running)
            {
                MapSizeButton.Enabled = false;
                MapRows.Enabled = false;
                MapCol.Enabled = false;
                RowGuess.Enabled = true;
                ColumnGuess.Enabled = true;
                GuessEnterButton.Enabled = true;
            }

        }
      
        public void GuessEnterButton_Click(object sender, EventArgs e)
        {

            //Message shown when user chooses the correct answer
            string CorrectGuess = "Congratulations! You have chosen the correct location of the island at:(" + RowGuess.Text + "," + ColumnGuess.Text + 
                ") in " + navigationSystem.Guess + " guess(es)\n" + "To play again with a different map, click the \"Resart\" button";
                

            //holds guess answer
            bool guessResult;

            //Won't allow a Guess unless a map has been created
            if (running)
            {
                //Gets data from form controls
                int MapRowGuess = Int32.Parse(RowGuess.Text);
                int MapColumnGuess = Int32.Parse(ColumnGuess.Text);

                //Checks the input of the guesses
                game.SetParameters(MapRowGuess, MapColumnGuess,MapRowCount,MapColumnCount);

                //Sets guessResult to true (correct) or false (wrong)
                guessResult = navigationSystem.EvaluateGuess(game.Row, game.Col);

                //If the correct location was choosen
                if (guessResult)
                {
                    navigationSystem.PrintMap(ref output);
                    MapOutput.Text = output;
                    running = false;
                    MessageBox.Show(CorrectGuess, "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
                    //Disables anymore guesses
                    GuessEnterButton.Enabled = false;

                    //Clears text boxes guesses
                    RowGuess.Text = "";
                    ColumnGuess.Text = "";

                    RowGuess.Enabled = false;
                    ColumnGuess.Enabled = false;

                }

                //Prints updated map
                navigationSystem.PrintMap(ref output);
                MapOutput.Text = output;

                //Clears text boxes guesses
                RowGuess.Text = "";
                ColumnGuess.Text = "";
            }

        }

        private void Instructions_Click(object sender, EventArgs e)
        {
            //Contains the instructions for the game
            string instructText = "Welcome To The Tropical Island Game!\n\n" +
            "The purpose of this game is to guess where the island is based on a set map size.\n\n" +
            "Here are the instructions for the game and if you ever forget just click the instructions button to come back!\n\n" +
            "1. Enter the size of the map you want to play with within the bounds of 11 x 11\n" +
            "2. Enter the guess of where you think the island is within the bounds of the map.\n" +
            "3. The game will provide feedback on how far your guess is from the correct answer, adjust your next answer accordingly.\n" +
            "4. To quit the current game press the \"Quit\" button.\n" +
            "5. Once a game has been completed, click the \"Restart\" button to play again.\n\n" +
            "ENJOY!";
            MessageBox.Show(instructText, "Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            MapSizeButton.Enabled = false;
            MapRows.Enabled = false;
            MapCol.Enabled = false;
            RowGuess.Enabled = false;
            ColumnGuess.Enabled = false;
            GuessEnterButton.Enabled = false;
            //Resets map 
            MapOutput.Text = "";
            string quitMessage = "You have quit the game, I guess it was too hard! Click the \"Resart\" button to play again with an easier map size";

            //Message printed to screen
            MessageBox.Show(quitMessage, "You have Quit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            //Will not allow a guess until the map is created 
            RowGuess.Enabled = false;
            ColumnGuess.Enabled = false;
            GuessEnterButton.Enabled = false;

            //Enables mapsizing buttons when new game is created 
            MapSizeButton.Enabled = true;
            MapRows.Enabled = true;
            MapCol.Enabled = true;
            //Clears the map
            MapOutput.Text = "";
        }
    }
}
