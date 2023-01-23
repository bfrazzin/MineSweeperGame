using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bfrazzinMinesweeper
{
    public partial class MinesweeperGUI : Form
    {
        Cell[,] cells = new Cell[10, 10];
        public MinesweeperGUI()
        {
            InitializeComponent();
            CreateGrid();
        }

        public void CreateGrid()
        {
            // NOT FIN
            for(int row = 0; row < cells.GetLength(0); row++ )
            {
                for(int col = 0; col < cells.GetLength(1); col++)
                {
                    cells[row, col] = new Cell();
                    cells[row, col].Row = row;
                    cells[row, col].Col = col;
                    cells[row, col].CellClick += CellClickHandler;
                    
                }
            }
        }

        //handler for cell click
        public void CellClickHandler(object sender, EventArgs e)
        {
            //click on red and it clicks on the blotch of red around it
            Cell currentCell = ((Cell)sender);
            // we have the color of the cell we just clicked
            Color targetColor = currentCell.BackColor;


            CheckAbove(currentCell, targetColor);
            CheckBelow(currentCell, targetColor);


            // do the help methods then delete this
            // check above. these if statements check if they find a match
            // first have to check if there is a row above it
            // TRY TO CREATE THESE INTO HELPER METHODS. extract method auto featrure
            // TO HELP UNDERSTAND WHAT IS HAPPENEING CELL BY CELL DO THREAD.SLEEP(500
            NewMethod(currentCell, targetColor);

            private void CheckBelow(Cell currentCell, Color targetColor)
            {
                if (currentCell.Row < cells.GetLength(0) - 1)
                {
                    // CHECK DIRECTLY ABOVE 
                    if (targetColor == cells[currentCell.Row + 1, currentCell.Col].BackColor)
                    {
                        cells[currentCell.Row + 1, currentCell.Col].PerformClick();
                    }
                    // CHECK ABOVE ? AND TO THE LEFT
                    if (currentCell.Col > 0)
                    {
                        if (targetColor == cells[currentCell.Row + 1, currentCell.Col - 1].BackColor)
                        {
                            cells[currentCell.Row + 1, currentCell.Col - 1].PerformClick();
                        }
                    }
                    // CHECK RIGHT?
                    if (currentCell.Col < cells.GetLength(1) - 1)
                    {
                        if (targetColor == cells[currentCell.Row + 1, currentCell.Col + 1].BackColor)
                        {
                            cells[currentCell.Row + 1, currentCell.Col + 1].PerformClick();
                        }

                    }
                }
            }

            private void CheckSide(Cell currentCell, Color targetColor)


        }

        private void NewMethod(Cell currentCell, Color targetColor)
        {
            if (currentCell.Row > 0)
            {
                // CHECK DIRECTLY ABOVE 
                if (targetColor == cells[currentCell.Row - 1, currentCell.Col].BackColor)
                {
                    cells[currentCell.Row - 1, currentCell.Col].PerformClick();
                }
                // CHECK ABOVE ? AND TO THE LEFT
                if (currentCell.Col > 0)
                {
                    if (targetColor == cells[currentCell.Row - 1, currentCell.Col - 1].BackColor)
                    {
                        cells[currentCell.Row - 1, currentCell.Col - 1].PerformClick();
                    }
                }
                // CHECK RIGHT?
                if (currentCell.Col < cells.GetLength(1) - 1)
                {
                    if (targetColor == cells[currentCell.Row - 1, currentCell.Col + 1].BackColor)
                    {
                        cells[currentCell.Row - 1, currentCell.Col + 1].PerformClick();
                    }

                }
            }
        }
    }
}
if (targetColor == cells[currentCell.Row - 1, currentCell.Col].BackColor)
{
    cells[currentCell.Row - 1, currentCell.Col - 1].PerformClick();
}
if (currentCell.Col > 0)
{
    if (targetColor == cells[currentCell.Row - 1, currentCell.Col - 1].BackColor)
    {
        cells[currentCell.Row - 1, currentCell.Col - 1].PerformClick();
    }
    if (currentCell.Col < cells.GetLength(1))
    {
        // CHECK TO THE RIGHT
        if (targetColor == cells[currentCell.Row - 1, currentCell.Col + 1].BackColor)
        {
            cells[currentCell.Row - 1, currentCell.Col - 1].PerformClick();
        }
    }
}