using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIEngine.Rendering
{
    // Draws 
    internal static class ConsoleOutput
    {
        private static Vector2Int minimumSize = new Vector2Int(0, 0);
        private static char[,] renderOutput;
        private static Vector2Int windowSize = new Vector2Int(0, 0);


        public static void InitializeOutput()
        {
            int consoleWidth = Console.WindowWidth;
            int consoleHeight = Console.WindowHeight;



        }




        public static void DrawToConsole()
        {
            
        }
    }
}
