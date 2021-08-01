using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Palett.Convert;
using Veho.Vector;

namespace Angrand.GUI.ColorSpacePanel {
  public partial class ColorSpacePanel : UserControl {
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Color Rgb {
      get => Color.FromArgb(comboBoxR.SelectedIndex, comboBoxG.SelectedIndex, comboBoxB.SelectedIndex);
      set {
        this.RgbEnabled = false;
        // Debug.Print($"set rgb {value} (hsl: {value.ColorToHsl()})");
        this.comboBoxR.SelectedIndex = value.R;
        this.comboBoxG.SelectedIndex = value.G;
        this.comboBoxB.SelectedIndex = value.B;
        if (this.HslEnabled) this.Hsl = value.ColorToHsl();
        this.RgbEnabled = true;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public (float h, float s, float l) Hsl {
      get => (comboBoxH.SelectedIndex, comboBoxS.SelectedIndex, comboBoxL.SelectedIndex);
      set {
        this.HslEnabled = false;
        // Debug.Print($"set hsl {value} (rgb {value.HslToRgb()})");
        this.comboBoxH.SelectedIndex = (int) value.h;
        this.comboBoxS.SelectedIndex = (int) value.s;
        this.comboBoxL.SelectedIndex = (int) value.l;
        if (this.RgbEnabled) this.Rgb = value.HslToColor();
        this.HslEnabled = true;
      }
    }

    public event Action<Color> OnColorChanged;

    public bool RgbEnabled = true;
    public bool HslEnabled = true;

    private void UpdateHsl((float, float, float) hsl) {
      this.RgbEnabled = false;
      this.Hsl = hsl;
      OnColorChanged?.Invoke(this.Rgb);
      this.RgbEnabled = true;
    }

    private void UpdateRgb(Color color) {
      this.HslEnabled = false;
      this.Rgb = color;
      OnColorChanged?.Invoke(color);
      this.HslEnabled = true;
    }

    public ColorSpacePanel() {
      InitializeComponent();
      object[] indexes;
      this.comboBoxR.Items.AddRange(indexes = Inits.Init(256, x => (object) x));
      this.comboBoxG.Items.AddRange(indexes); // indexes = Enumerable.Range(0, 256).Select(x => (object) x).ToArray();
      this.comboBoxB.Items.AddRange(indexes);
      this.comboBoxH.Items.AddRange(indexes = Inits.Init(361, x => (object) x));
      this.comboBoxS.Items.AddRange(indexes = Inits.Init(101, x => (object) x));
      this.comboBoxL.Items.AddRange(indexes);
      this.Rgb = Color.Gainsboro;
    }

    private void RgbSelectedIndexChanged(object sender, EventArgs e) {
      if (!this.RgbEnabled) return;
      this.UpdateHsl(this.Rgb.ColorToHsl());
    }

    private void HslSelectedIndexChanged(object sender, EventArgs e) {
      if (!this.HslEnabled) return;
      this.UpdateRgb(this.Hsl.HslToColor());
    }
  }
}