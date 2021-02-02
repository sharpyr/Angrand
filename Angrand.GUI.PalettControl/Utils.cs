using System;
using System.Drawing;
using System.Windows.Forms;

namespace Angrand.GUI.PalettControl {
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
    public static void StillAction(this Control control, Action action) {
      if (!control.Enabled) return;
      control.Enabled = false;
      action();
      control.Enabled = true;
    }

    public static void LocalUpdate<T>(this Button button, T value, Color color) {
      button.BackColor = color;
      button.Text = value.ToString();
    }

    public static (float h, float s, float l) UpdateLightness(this (float h, float s, float l) hsl, float newLight) =>
      (hsl.h, hsl.s, newLight);
  }
}