using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program4
{
    public class FindTheIslandGame : Game
    {
        //member variables
        private int rowGuess;
        private int colGuess;
        private static int Guesscount = 0;

        public FindTheIslandGame()
        {
            rowGuess = 4;
            colGuess = 4;
        }

        public FindTheIslandGame(int row, int col)
        {
            Guesscount++;
            if (row > 0)
                rowGuess = row;
            else
                rowGuess = 1;
            if (col > 0)
                colGuess = col;
            else
                colGuess = 1;
        }

        public int Row
        {
            get { return rowGuess; }
        }

        public int Col
        {
            get { return colGuess; }
        }

       void ShowInstructions()
        {
            string instructText = "Welcome To The Tropical Island Game!\n" +
            "The purpose of this game is to guess where the island is based on a set map size\n" +
            "Here are the instructions for the game and if you ever forget just click the instructions button to come back!\n" +
            "1.Enter the size of the map you want to play with within the bounds of -- --\n" +
            "2.Enter the guess of where you think the island is within the bounds of the map\n" +
            "3.The game will provide feedback on how far your guess is from the correct answer, adjust your next answer accordingly\n" +
            "4.To quit the current game press the \"Quit\" button\n" +
            "5.Once a game has been completed, click the \"Restart\" button to play again\n" +
            "ENJOY";

            MessageBox.Show(instructText, "Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void newGame()
        {
            Guesscount = 0;
            ShowInstructions();
/*
            //Will not allow a guess until the map is created 
            RowGuess.Enabled = true;
            ColumnGuess.Enabled = true;
            GuessEnterButton.Enabled = true;

            //Enables mapsizing buttons when new game is created 
            MapSizeButton.Enabled = true;
            MapRows.Enabled = true;
            MapCol.Enabled = true;*/

        }


    }
}
