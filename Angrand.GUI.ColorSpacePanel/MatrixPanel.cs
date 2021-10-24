using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Palett;
using Veho;
using Veho.Matrix;

namespace Angrand.GUI.ColorSpacePanel {
  public partial class MatrixPanel : UserControl {
    public bool MunsellMode = true;
    public MatrixPanel() {
      InitializeComponent();
      this.vScrollBarLightness.ValueChanged += this.scrollBar_ValueChanged;
      this.vScrollBarSaturation.ValueChanged += this.scrollBar_ValueChanged;
      this.hScrollBarHue.ValueChanged += this.scrollBar_ValueChanged;
      this.hScrollBarHueRange.ValueChanged += this.scrollBar_ValueChanged;
    }
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public int LightnessMinimum {
      get => 100 - this.vScrollBarLightness.Value;
      set => this.vScrollBarLightness.Value = 100 - value;
    }
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public int SaturationThreshold {
      get => 100 - this.vScrollBarSaturation.Value;
      set => this.vScrollBarSaturation.Value = 100 - value;
    }
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public int HueThreshold {
      get => this.hScrollBarHue.Value;
      set => this.hScrollBarHue.Value = value;
    }
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public int HueRange {
      get => this.hScrollBarHueRange.Value;
      set => this.hScrollBarHueRange.Value = value;
    }
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public event EventHandler OnClicked {
      add => this.cardMatrice.OnClicked += value;
      remove => this.cardMatrice.OnClicked -= value;
    }
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public event MouseEventHandler OnMouseMoved {
      add => this.cardMatrice.OnMouseMoved += value;
      remove => this.cardMatrice.OnMouseMoved -= value;
    }
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public event EventHandler OnMouseLeft {
      add => this.cardMatrice.OnMouseLeft += value;
      remove => this.cardMatrice.OnMouseLeft -= value;
    }
    public (float, float, float)[,] MakeMatrix(int hueThreshold, int saturationThreshold, int lightnessMinimum, int hueRange) {
      (float min, float max, float step) hues = (hueThreshold, hueThreshold + hueRange, (float)hueRange / 10);
      (float min, float max, float step) lights = (lightnessMinimum, 95, (float)(95 - lightnessMinimum) / 10);
      return (10, 10).Init((i, j) => {
        var h = hues.min + j * hues.step;
        var l = lights.max - i * lights.step;
        (float, float, float) hsl = (h, saturationThreshold, l);
        return hsl.ConstraintHsl();
      });
    }

    public void scrollBar_ValueChanged(object sender, System.EventArgs e) {
      var matrix = this.MakeMatrix(this.HueThreshold, this.SaturationThreshold, this.LightnessMinimum, this.HueRange);
      if (this.MunsellMode) {
        var munsellMatrix = matrix.Map(hsl => hsl.Nearest());
        this.cardMatrice.MunsellMatrix = munsellMatrix;
      }
      else {
        var colorMatrix = matrix.Map(Conv.HslToColor);
        this.cardMatrice.ColorMatrix = colorMatrix;
      }
    }
  }
}