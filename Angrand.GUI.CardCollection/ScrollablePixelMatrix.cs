using System;
using System.ComponentModel;
using System.Windows.Forms;
using Veho;

namespace Angrand.GUI.CardCollection {
  public partial class ScrollablePixelMatrix : UserControl {
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public (int h, int w) MatrixSize {
      get => this.pixelMatrix.MatrixSize;
      set => this.pixelMatrix.MatrixSize = value;
    }
    public ScrollablePixelMatrix() {
      InitializeComponent();
      this.MatrixSize = (12, 12);
      vScrollBarLightness.ValueChanged += scrollBar_ValueChanged;
      vScrollBarSaturation.ValueChanged += scrollBar_ValueChanged;
      hScrollBarHue.ValueChanged += scrollBar_ValueChanged;
      hScrollBarHueRange.ValueChanged += scrollBar_ValueChanged;
    }
    public void InitializeParameters(int lightnessMinimum = 0, int saturationThreshold = 75, int hueThreshold = 120, int hueRange = 180, bool munsellMode = true) {
      this.SuspendLayout();
      this.LightnessMinimum = lightnessMinimum;
      this.SaturationThreshold = saturationThreshold;
      this.HueThreshold = hueThreshold;
      this.HueRange = hueRange;
      this.pixelMatrix.MunsellMode = munsellMode;
      this.ResumeLayout(false);
    }
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public int LightnessMinimum {
      get => 100 - vScrollBarLightness.Value;
      set => vScrollBarLightness.Value = 100 - value;
    }
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public int SaturationThreshold {
      get => 100 - vScrollBarSaturation.Value;
      set => vScrollBarSaturation.Value = 100 - value;
    }
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public int HueThreshold {
      get => hScrollBarHue.Value;
      set => hScrollBarHue.Value = value;
    }
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public int HueRange {
      get => hScrollBarHueRange.Value;
      set => hScrollBarHueRange.Value = value;
    }
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public event EventHandler OnDoubleClicked {
      add => pixelMatrix.OnDoubleClicked += value;
      remove => pixelMatrix.OnDoubleClicked -= value;
    }
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public event MouseEventHandler OnMouseMoved {
      add => pixelMatrix.OnMouseMoved += value;
      remove => pixelMatrix.OnMouseMoved -= value;
    }
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public event EventHandler OnMouseLeft {
      add => pixelMatrix.OnMouseLeft += value;
      remove => pixelMatrix.OnMouseLeft -= value;
    }
 

    public void scrollBar_ValueChanged(object sender, EventArgs e) {
      var size = this.MatrixSize;
      (float min, float max, float step) hues = (this.HueThreshold, this.HueThreshold + this.HueRange, (float)this.HueRange / size.w);
      (float min, float max, float step) lights = (this.LightnessMinimum, 98, (float)(98 - this.LightnessMinimum) / size.h);
      var hslMatrix = size.Init((i, j) => {
        var h = hues.min + j * hues.step;
        var l = lights.max - i * lights.step;
        (float, float, float) hsl = (h, this.SaturationThreshold, l);
        return hsl.Restrict();
      });
      pixelMatrix.HSLMatrix = hslMatrix;
    }
  }
}