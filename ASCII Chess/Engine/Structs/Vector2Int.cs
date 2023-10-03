using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIEngine
{
    /// <summary>
    /// Struct for identifying a 2D point in space.
    /// </summary>
    internal struct Vector2Int
    {
        // X and Y position.
        public int x;
        public int y;

        /// <summary>
        /// Creates a new Vector2Int at (0, 0).
        /// </summary>
        public Vector2Int()
        {
            x = 0;
            y = 0;
        }

        /// <summary>
        /// Creates a new Vector2Int at (x, y).
        /// </summary>
        public Vector2Int(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

    }
}
