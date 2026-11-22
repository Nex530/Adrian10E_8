using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adrian10E_8
{
    class Settings
    {
        private static int width = 16;
        private static int height = 16;
        public static int Width { get { return width; } }
        public static int Height { get { return height; } }

        public static string directions = "left";
    }
}
