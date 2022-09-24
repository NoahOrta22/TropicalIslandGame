﻿using System;
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

        public Game()
        {
            InitializeComponent();

        }

        private void MapSizeButton_Click(object sender, EventArgs e)
        {


            //Gets data from form controls
            int MapRowCount = Int32.Parse(MapRows.Text);
            int MapColumnCount = Int32.Parse(MapCol.Text);
            
            //Initializes object of user inputted size
            NavigationSystem navigationSystem = new NavigationSystem(MapRowCount, MapColumnCount);
            
            //References the creation of map processes and sets equal to label
            navigationSystem.PrintMap(ref output);
            MapOutput.Text = output;

            //Resets map size texts
            MapRows.Text = "";
            MapCol.Text = "";
            
            //Prohibits any further changes to the map size when game starts
            running = true;
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
      
        private void GuessEnterButton_Click(object sender, EventArgs e)
        {

            //holds guess answer
            bool guessResult;

            //Gets data from form controls
            int MapRowGuess = Int32.Parse(RowGuess.Text);
            int MapColumnGuess =Int32.Parse(ColumnGuess.Text);

            //Checks the input of the guesses
            FindTheIslandGame findTheIslandGame = new FindTheIslandGame(MapRowGuess,MapColumnGuess);
            //Initializes guess checker - (*THIS DOESN'T HOLD THE GAME MAP bcs it's a different instance*)
            NavigationSystem GuessChecker = new NavigationSystem();// ^^^ noah's comment

            //Sets guessResult to true (correct) or false (wrong)
            guessResult = GuessChecker.EvaluateGuess(findTheIslandGame.Row,findTheIslandGame.Col);

            if (guessResult)
            {
                GuessEnterButton.Enabled = false;
                GuessChecker.PrintMap(ref output);
                MapOutput.Text = output;
                running = false;
            }

            GuessChecker.PrintMap(ref output);
            MapOutput.Text = output;

            //Clears text boxes guesses
            RowGuess.Text = "";
            ColumnGuess.Text = "";

        }

        private void Instructions_Click(object sender, EventArgs e)
        {
            string instructText = "Welcome To The Tropical Island Game!\n\n" +
                "The purpose of this game is to guess where the island is based on a set map size.\n\n" +
                "Here are the instructions for the game and if you ever forget just click the instructions button to come back!\n\n" +
                "1. Enter the size of the map you want to play with within the bounds of -- --\n" +
                "2. Enter the guess of where you think the island is within the bounds of the map.\n" +
                "3. The game will provide feedback on how far your guess is from the correct answer, adjust your next answer accordingly.\n" +
                "4. To quit the current game press the \"Quit\" button.\n" +
                "5. Once a game has been completed, click the \"Restart\" button to play again.\n\n" +
                "ENJOY!";
                
            MessageBox.Show(instructText, "Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            running = false;
            output = "";
            GuessEnterButton.Enabled = false;
            MapSizeButton.Enabled = false;
            MapRows.Enabled = false;
            MapCol.Enabled = false;
            RowGuess.Enabled = false;
            ColumnGuess.Enabled = false;

        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            output = "";

            //Will not allow a guess until the map is created 
            RowGuess.Enabled = true;
            ColumnGuess.Enabled = true;
            GuessEnterButton.Enabled = true;

            //Enables mapsizing buttons when new game is created 
            MapSizeButton.Enabled = true;
            MapRows.Enabled = true;
            MapCol.Enabled = true;
        }
    }
}