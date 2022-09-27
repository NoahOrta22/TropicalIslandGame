// Main Driver of the Program

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program4
{
    internal static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
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
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Game());

        }
        
    }
}
