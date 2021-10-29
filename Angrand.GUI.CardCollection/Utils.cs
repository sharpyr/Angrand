using Aryth;

namespace Angrand.GUI.CardCollection {
  public static class ColorExt {
    public static (float h, float s, float l) Restrict(this (float h, float s, float l) hsl) {
      hsl.h = Math.Restrict(hsl.h, 360);
      hsl.s = Math.Limit(hsl.s, 100);
      hsl.l = Math.Limit(hsl.l, 100);
      return hsl;
    }
  }
}