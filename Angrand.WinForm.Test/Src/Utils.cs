using System.Drawing;

namespace Angrand.PalettApp {
  public static class ColorExt {
    public static (byte, byte, byte) Rgb(this Color color) {
      return (color.R, color.G, color.B);
    }

    public static (Color min, Color max) DefaultPreset = (
      Color.FromArgb(0, 204, 204), Color.FromArgb(153, 153, 255)
    );
    public static (Color min, Color max) DefaultGrays = (Color.LightGray, Color.Gainsboro);
    public static (Color min, Color max)[] PresetCollection = {
      DefaultPreset,
      DefaultGrays,
      DefaultGrays,
      DefaultGrays,
      DefaultGrays,
    };
  }
}