﻿//  Navigation System Class

//  Main logic of the system. Takes care of the backend processes
//  like setting up the map, initializing island coordinates,
//  evaluating the users guess, printing the map, etc

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program4
{
    /*
    *   NavigationSystem
    *
    *   Description:
    *       Main logic of the system. Takes care of the backend processes
    *       like setting up the map, initializing island coordinates,
    *       evaluating the users guess, printing the map, etc
    *
    *
    *   Public:
    *       
    *                       NavigationSystem()
    *                       NavigationSystem(int r, int c)
    *
    *       private void    MakeMap()
    *       public  void    PrintMap()
    *       private void    setIslandLocation()
    *       public  bool    EvaluateGuess(int r, int c)
    *       private char    directionHint(int r, int c)
    *
    *   Usage:
    *       NavigationSystem GPS = new NavigationSystem(5, 4)
    *       - makes an object 
    *       
    *       GPS.EvaluateGuess(2, 3)                    - says if user if right
    *
    */
    public class NavigationSystem : Game
    {

        //  Member Variables
        private char[,] map;               // the grid of the "world"

        private int numRow;                // number of rows in the map/grid
        private int numCol;                // number of columns in the map/grid

        public int islandRow;              // coordinate for islands row
        public int islandCol;              // coordinate for islands column

        private int numGuess;

        private Random rnd = new Random(); // for generating random ints


        // Default Constructor
        public NavigationSystem()
        {
            numRow = 4;                     //  number of rows in the map
            numCol = 4;                     //  number of columns in the map

            numGuess = 0;

            //  initialize the size of the map
            map = new char[numRow, numCol];

            // set up this map to make everything water
            MakeMap();

            // make random coordinates for the secret island
            setIslandLocation();
        }

        // Parameterized Constructor
        // Params:
        //      int r - number of rows
        //      int c - number of columns
        public NavigationSystem(int r, int c)
        {
            //Limits the size of map
            //Checks map's bounds and resizes if illegal
            if(r > 11 || c > 11 || r == 0 || c== 0) 
            {
                MessageBox.Show("You entered an invalid map size \n Size is being set to 11x11", "Invalid Map Size", MessageBoxButtons.OK, MessageBoxIcon.Error);

                numRow = 11;
                numCol = 11;
            }
            else { 
                 numRow = r;         //  number of rows in the map
                 numCol = c;         //  number of columns in the map
            }

            numGuess = 0;            // the user hasn't guessed anything yet

            //  initialize the size of the map
            map = new char[numRow, numCol];

            // set up this map to make everything water
            MakeMap();

            // make random coordinates for the secret island
            setIslandLocation();              

        }

        //  Description: 
        //      Makes the map with the number of rows and columns that
        //      the user enters and initializes all elements to 
        //      '~' (water)
        private void MakeMap()
        {
            for(int i = 0; i < numRow; i++)
            {
                for(int j = 0; j < numCol; j++)
                {
                    map[i,j] = '~';
                }
            }
        }

        // Description:
        //      Prints out the current map in a formatted way
        //
        public void PrintMap(ref string waves)
        {
            waves = "";
            waves+="  ";                // 2 spaces for the formatting

            //  Numbers at top for the x-axis
            for(int i = 0; i < numCol; i++)
            {
                waves += $"{i} ";
                //waves += i;
            }
            waves += '\n';
            for (int i = 0; i < numRow; i++)
            {
                //accounts for the formatting of a double digit row number
                if (i <10)
                    waves += $"{i} ";
                else
                    waves += $"{i}";

                for (int j = 0; j < numCol; j++)
                {
                    waves += map[i,j];


                    // formatting for the spaces between waves
                    int numSpaces = j.ToString().Length;
                    for(int k = 0; k < numSpaces; k++)
                    {
                        waves += " ";
                    }
                }
                waves += "\n";
            }
        }

        //  Description:
        //      Sets random coordinates for the Secret Island
        private void setIslandLocation()
        {
            islandCol = rnd.Next(numCol);  // gets a random col coordinate
            islandRow = rnd.Next(numRow);  // gets a random row coordinate
        }

        //  Description:
        //      returns the value of what the private variable "numGuess" is
        public int Guess
        {
            get { return numGuess; }
        }

        //  Description:
        //      Evaluates the user's guess and tells them whether they were
        //      right or wrong
        // Params: 
        //      int r - value of row guess
        //      int c - value of column guess
        public bool EvaluateGuess(int r, int c)
        {
            numGuess++;                        // increment the number of guesses

            bool correct = false;              // if the user was right or not

            char hint = directionHint(r, c);   // get the hint

            // checks if the user guessed right
            correct = (hint == 'I') ? true : false;

            map[r, c] = hint;                  // charts the hint

            return correct;
        }

        //  Description:
        //      Gives the user a hint to go if they were wrong by changing
        //      the map, and displays an "I" for the island.
        //      this function does all the thinking to see where the island is.
        // Params: 
        //      int r - value of row guess
        //      int c - value of column guess
        private char directionHint(int r, int c)
        {
            char hint = ' ';

            // the user guessed right
            if(r == islandRow && c == islandCol)
            {
                return 'I';
            }
            // the user has the right column
            else if(c == islandCol)
            {
                return 'C';
            }
            // the user has the right row
            else if(r == islandRow)
            {
                return 'R';
            }
            // the user was completely wrong
            else
            {
                // the number of guesses is even (returns North or South)
                if(numGuess % 2 == 0)
                {
                    hint = (r > islandRow) ? 'N' : 'S';
                }
                // the number of guesses is odd (returns East or West)
                else {
                    hint = (c > islandCol) ? 'W' : 'E';
                }
            }

            return hint;
        }
    }


}
