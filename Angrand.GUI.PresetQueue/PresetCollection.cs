using System.Drawing;

namespace Angrand.GUI.PresetQueue {
  public static class PresetCollection {
    public static (Color min, Color max)[] Presets() => new[] {
      (Color.FromArgb(0, 204, 204), Color.FromArgb(153, 153, 255)),
      (Color.LightGray, Color.Gainsboro),
      (Color.LightGray, Color.Gainsboro),
      (Color.LightGray, Color.Gainsboro),
      (Color.LightGray, Color.Gainsboro),
    };
  }
}