using System;
using System.Collections.Generic;

namespace SubmarineGame
{
    /// <summary>
    /// This class will represent the board of the game
    /// </summary>
    class Board
    {
        private int xVal;
        private int yVal;
        private int levVal;
        private Dictionary<decimal, decimal> submarineNubers = new Dictionary<decimal, decimal>();
        private Cell[,] boardCells;
        private int allAreaSubmarine;

        public Board(int xVal, int yVal, int levVal)
        {
            this.xVal = xVal;
            this.yVal = yVal;
            this.levVal = levVal;

            
            decimal area = xVal * yVal / 10;
            decimal areaSubmarine = Math.Ceiling(area);

            allAreaSubmarine = Convert.ToInt32(areaSubmarine);
            decimal numOfSubmarine = Math.Floor(areaSubmarine / 10);
            for(decimal i =1; i<5 ; i++)
            {
                submarineNubers.Add(i, numOfSubmarine);
            }
            areaSubmarine = areaSubmarine - 10 * numOfSubmarine;
            if (areaSubmarine > 0 && areaSubmarine < 5)
            {
                submarineNubers[areaSubmarine] = submarineNubers[areaSubmarine] + 1;
                areaSubmarine = 0;
            }
            else
            {
                for (int i = 4; i > 0; i--)
                {
                    if (areaSubmarine > 0)
                    {
                        submarineNubers[i] = submarineNubers[i] + 1;
                        areaSubmarine = areaSubmarine - i;
                    }

                }
            }
            boardCells = new Cell[xVal, yVal];
            for(int i =0; i<xVal; i++)
            {
                for(int j= 0; j<yVal; j++)
                {
                    boardCells[i, j] = new Cell();
                }
            }
            SetSubmarines();
        }

        /// <summary>
        /// This function will initialize the position of the submarines on the board
        /// </summary>
        private void SetSubmarines()
        {
            var rand = new Random();
            for (decimal i = 4; i>0; i--)
            {
                for(decimal j = 0; j< submarineNubers[i]; j++)
                {
                    bool isNext = false;
                    while (!isNext)
                    {
                        int start = Convert.ToInt32(i);
                        int coordinatX = rand.Next(0, xVal);
                        int coordinatY = rand.Next(start, yVal);
                        if (CheckCanBeSubmarine(coordinatX, coordinatY, start))
                        {
                            isNext = AddSubmarine(coordinatX, coordinatY, start);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// This function updates the game board cells as submarines
        /// </summary>
        /// <param name="coordinatX"></param>
        /// <param name="coordinatY"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        private bool AddSubmarine(int coordinatX, int coordinatY, int length)
        {
            for (int i = length; i > 0; i--)
            {
                boardCells[coordinatX, coordinatY - i].SetIsSubmarine();
            }
            return true;
        }

        /// <summary>
        /// This function checks whether a cell on the game board can be submarines
        /// </summary>
        /// <param name="coordinatX"></param>
        /// <param name="coordinatY"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        private bool CheckCanBeSubmarine(int coordinatX, int coordinatY, int length)
        {
            for (int i = length; i>0; i-- )
            {
                if ( boardCells[coordinatX, coordinatY - i].GetIsSubmarine())
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// This function updates the game board when the user has hit a cell
        /// </summary>
        /// <param name="coordinatX"></param>
        /// <param name="coordinatY"></param>
        /// <returns></returns>
        public int CellHit(int coordinatX, int coordinatY)
        {   
            if (!boardCells[coordinatX, coordinatY].GetIsHit())
            {
                boardCells[coordinatX, coordinatY].SetIsHit();
                if (boardCells[coordinatX, coordinatY].GetIsSubmarine())
                {
                    return 1;
                }
                return 2;
            }
            else
            {
                return 0;
            }
            
        }

        /// <summary>
        /// This function checks whether a cell on the game board has been hited
        /// </summary>
        /// <param name="coordinatX"></param>
        /// <param name="coordinatY"></param>
        /// <returns></returns>
        public int IsCellHit(int coordinatX, int coordinatY)
        {
            if (!boardCells[coordinatX, coordinatY].GetIsHit())
            {
                if (boardCells[coordinatX, coordinatY].GetIsSubmarine())
                {
                    return 1;
                }
                return 2;
            }
            else
            {
                return 0;
            }

        }

        /// <summary>
        /// This function returns the dictionary representing submarine type
        /// and quantity on the game board
        /// </summary>
        /// <returns></returns>
        internal Dictionary<decimal, decimal> GetDict()
        {
            return submarineNubers;
        }

        /// <summary>
        /// This function returns the area of space that the submarines occupy
        /// on the board
        /// </summary>
        /// <returns></returns>
        public int GetAllAreaSubmarine()
        {
            return allAreaSubmarine;
        }

        /// <summary>
        /// This function checks whether a particular cell is part of a submarine
        /// </summary>
        /// <param name="coordinatX"></param>
        /// <param name="coordinatY"></param>
        /// <returns></returns>
        internal bool CellSubmarines(int coordinatX, int coordinatY)
        {
            return boardCells[coordinatX, coordinatY].GetIsSubmarine();
        }
    }
}
