using System.Drawing;

namespace Angrand.GUI.PresetQueue {
  public static class Utils {
    public static readonly (Color min, Color max) DefaultPreset = (
      Color.FromArgb(0, 204, 204), Color.FromArgb(153, 153, 255)
    );
    public static readonly (Color min, Color max) DefaultGrays = (Color.LightGray, Color.Gainsboro);
    public static readonly (Color min, Color max)[] PresetCollection = {
      DefaultPreset,
      DefaultGrays,
      DefaultGrays,
      DefaultGrays,
      DefaultGrays,
    };
  }
}