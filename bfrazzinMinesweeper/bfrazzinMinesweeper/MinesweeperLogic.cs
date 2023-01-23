using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bfrazzinMinesweeper
{
    public class MinesweeperLogic
    {
        Random rand = new Random();
        public void PlaceBombsHandler(object sender, PlaceBombEventArgs e)
        {
            // determined where the user clicked
            // CCLEAN THIS WHOLE PIECE OF SHIT UP USING HELPER METHODS!!!!!!!!!!!!!!!!!!!!!!!!!!!
            int clickedRow = e.ClickLocation.Item1;
            int clickedCol = e.ClickLocation.Item2;

            // now generate the bombs
            List<Tuple<int, int>> response = new List<Tuple<int, int>>();

            // 10 bombs
            for(int i = 0; i < 10; i++)
            {
                bool validChoice = false;
                do
                {
                    // place within the grid
                    // CONSIDER CHANGING THE 10 VALUE TO A VARIABLE
                    Tuple<int, int> bombLocation = Tuple.Create(rand.Next(10), rand.Next(10));

                    // check to see if it is a valid choice

                    // confirm that the bomb is not where we have clicked
                    validChoice = CheckIfValidLocation(clickedRow, clickedCol, response, validChoice, bombLocation);
                } while (!validChoice);
                
            }

            // use hasBomb boolean?
        }

        private static bool CheckIfValidLocation(int clickedRow, int clickedCol, List<Tuple<int, int>> response, bool validChoice, Tuple<int, int> bombLocation)
        {
            if (bombLocation.Item1 != clickedRow && bombLocation.Item2 != clickedCol)
            {
                // check all of the locations
                validChoice = true;
                foreach (var location in response)
                {

                    if (bombLocation.Item1 == location.Item1 && bombLocation.Item2 == location.Item2)
                    {
                        validChoice = false;
                    }
                }
            }

            return validChoice;
        }
    }
}
