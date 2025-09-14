using System;
using System.Collections.Generic;
using System.Text;

/*
 * ProfReynolds
 */

namespace TicTacToe_Interfaces
{
    /// <summary>
    /// CellOwners is the set of possible cell states
    /// </summary>
    public enum CellOwners
    {
        Error, // this is the default state - never used
        Open,
        Human,
        Computer
    }
}
