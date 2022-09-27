//   FindTheIslandGame Class

//  Controls the overflow of the game
//It presents the guesses of the user to the navigation system

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program4
{
    /*
*   FindTheIslandGame
*
*   Description:
*       Controls the overflow of the game
*       It presents the guesses of the user to the navigation system
*       
*
*
*   Public:
*       
*                       FindTheIslandGame()
*                       SetParameters(int rowguess, int colguess, int rows, int cols)
*
*       private void    Checkguess()
*
*   Usage:
*       FindTheIslandGame Game = new FindIslandGame();
*       - makes an object 
*       
*       Game.Checkguess(2, 3,11,11)                    - checks if the guess is within the bounds of the map
*
*/
    public class FindTheIslandGame : Game
    {
        //member variables
        private int rowGuess;
        private int colGuess;
        private int mapRows;
        private int mapCols;

        //Defaults
        public FindTheIslandGame()
        {
            rowGuess = 4;
            colGuess = 4;
        }

        //  Description:
        //      Takes in the map size and the users guess
        //      Checks the users guess with the check guess function
        //     
        // Params: 
        //      int rowguess - value of row guess
        //      int colguess - value of column guess
        //      int rows     - number of rows
        //      int cols     - number of cols
        public void SetParameters(int rowguess, int colguess, int rows, int cols)
        {
            rowGuess = rowguess;
            colGuess = colguess;
            mapRows = rows;
            mapCols = cols;
            Checkguess();
        }


        //  Description:
        //      Checks the users input with the size of the map
        //      If the input is larger than the map size it makes the input 0,0
        //      Displays an error message to let the user know the mistake and changes
        private void Checkguess()
        {
            if (rowGuess >= mapRows)
            {
                MessageBox.Show("You guessed larger than the map! Your guess is being set to (0,0)","Illegal Guess",MessageBoxButtons.OK,MessageBoxIcon.Error);
                rowGuess = 0;
                colGuess = 0;
            }
            else if (colGuess >= mapCols)
            {
                MessageBox.Show("You guessed larger than the map! Your guess is being set to (0,0)", "Illegal Guess", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rowGuess = 0;
                colGuess = 0;
            }
        }

        public int Row
        {
            get { return rowGuess; }
        }

        public int Col
        {
            get { return colGuess; }
        }

    }
}
