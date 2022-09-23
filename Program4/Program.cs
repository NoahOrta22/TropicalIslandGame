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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            // This is an example of how you'd initialize the object
            NavigationSystem GPS = new NavigationSystem(10, 10);
            GPS.PrintMap();
            
            /*// For testing the logic of Evaluate guess
            for(int i = 0; i < 10; i++)
            {
                GPS.EvaluateGuess(i, i);
                GPS.PrintMap();
            }
            Console.WriteLine($"{GPS.islandRow}, {GPS.islandCol}"); */

        }
    }
}
