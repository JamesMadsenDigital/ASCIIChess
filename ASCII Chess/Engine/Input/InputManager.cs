using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIEngine.Input
{
    /// <summary>
    /// Manages application-wide input events.
    /// </summary>
    internal static class InputManager
    {
        // The last key that was pressed.
        private static ConsoleKey? lastKeyPressed = null;

        /// <summary>
        /// Returns true if a key was pressed this frame.
        /// </summary>
        public static bool KeyDown(ConsoleKey key)
        {
            if (lastKeyPressed == null)
                return false;

            if(lastKeyPressed.Value == key) return true;

            return false;
        }

        /// <summary>
        /// Sets the last pressed key. Should only be called from main game loop.
        /// </summary>
        public static void SetKey(ConsoleKey key)
        {
            lastKeyPressed = key;
        }

        /// <summary>
        /// Clears the last pressed key.
        /// </summary>
        public static void Clear()
        {
            lastKeyPressed = null;
        }
    }
}
