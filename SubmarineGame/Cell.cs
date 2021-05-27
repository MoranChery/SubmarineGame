using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmarineGame
{
    /// <summary>
    /// This class will represent a cell of the game board
    /// </summary>
    class Cell
    {
        bool isSubmarine;
        bool isHit;


        public Cell()
        {
            this.isHit = false;
        }

        /// <summary>
        /// This function updates the cell as hited
        /// </summary>
        public void SetIsHit()
        {
            isHit = true;
        }

        /// <summary>
        /// This function updates the cell as part of a submarine
        /// </summary>
        public void SetIsSubmarine()
        {
            isSubmarine = true;
        }

        /// <summary>
        /// This function checks whether a cell is part of a submarine
        /// </summary>
        /// <returns></returns>
        public bool GetIsSubmarine()
        {
            return this.isSubmarine;
        }

        /// <summary>
        /// This function checks whether a cell is hited
        /// </summary>
        /// <returns></returns>
        public bool GetIsHit()
        {
            return this.isHit;
        }

    }
}
