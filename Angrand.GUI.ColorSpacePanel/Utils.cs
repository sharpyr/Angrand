namespace Angrand.GUI.ColorSpacePanel {
  public static class ColorExt {
    public static float Constraint(this (float min, float max) bound, float value) {
      if (value < bound.min) value = bound.min;
      if (value > bound.max) value = bound.max;
      return value;
    }
    public static float Constraint(this float value, float min, float max) {
      if (value < min) value = min;
      if (value > max) value = max;
      return value;
    }

    public static float RotateConstraint(this float value, float range) {
      while (value < 0) { value += range; }
      while (value > range) { value -= range; }
      return value;
    }


    public static (float h, float s, float l) ConstraintHsl(this (float h, float s, float l) hsl) {
      hsl.h = hsl.h.RotateConstraint(360);
      hsl.s = hsl.s.RotateConstraint(100);
      hsl.l = hsl.l.RotateConstraint(100);
      return hsl;
    }
  }
}