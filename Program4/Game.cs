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
        public Game()
        {
            InitializeComponent();
        }

        private void MapSizeButton_Click(object sender, EventArgs e)
        {

        }
      
        private void GuessEnterButton_Click(object sender, EventArgs e)
        {

        }

        private void Instructions_Click(object sender, EventArgs e)
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

    }
}
