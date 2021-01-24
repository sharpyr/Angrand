using System.Drawing;

namespace Angrand.PalettApp
{
    public static class ColorExt
    {
        public static (byte, byte, byte) Rgb(this Color color)
        {
            return (color.R, color.G, color.B);
        }
    }
}