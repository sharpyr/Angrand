using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Palett.Convert;
using Veho.Vector;

namespace Angrand.GUI.ColorSpacePanel {
  public partial class ColorSpacePanel : UserControl {
    public bool RgbEnabled = true;
    public bool HslEnabled = true;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Color Rgb {
      get => this.Enabled
        ? Color.FromArgb(comboBoxR.SelectedIndex, comboBoxG.SelectedIndex, comboBoxB.SelectedIndex)
        : Color.Empty;
      set {
        this.RgbEnabled = false;
        this.SetRgbSelection(value);
        this.Enabled = !value.IsEmpty;
        if (this.HslEnabled) {
          this.Hsl = value.ColorToHsl();
        } else {
          this.OnColorChanged?.Invoke(value);
        }
        this.RgbEnabled = true;
        // if (!this.HslEnabled) OnColorChanged?.Invoke(value);
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public (float h, float s, float l) Hsl {
      get => (comboBoxH.SelectedIndex, comboBoxS.SelectedIndex, comboBoxL.SelectedIndex);
      set {
        this.HslEnabled = false;
        this.SetHslSelection(value);
        if (this.RgbEnabled) {
          this.Rgb = value.HslToColor();
        } else {
          this.OnColorChanged?.Invoke(value.HslToColor());
        }
        this.HslEnabled = true;
        // if (!this.RgbEnabled) OnColorChanged?.Invoke(value.HslToColor());
      }
    }

    public event Action<Color> OnColorChanged;

    private void SetRgbSelection(Color color) {
      if (color.IsEmpty) {
        this.comboBoxR.SelectedIndex = 0;
        this.comboBoxG.SelectedIndex = 0;
        this.comboBoxB.SelectedIndex = 0;
      } else {
        this.comboBoxR.SelectedIndex = color.R;
        this.comboBoxG.SelectedIndex = color.G;
        this.comboBoxB.SelectedIndex = color.B;
      }
    }
    private void SetHslSelection((float h, float s, float l) hsl) {
      this.comboBoxH.SelectedIndex = (int) hsl.h;
      this.comboBoxS.SelectedIndex = (int) hsl.s;
      this.comboBoxL.SelectedIndex = (int) hsl.l;
    }
    private void UpdateHsl((float, float, float) hsl) {
      this.RgbEnabled = false;
      this.Hsl = hsl;
      // OnColorChanged?.Invoke(this.Rgb);
      this.RgbEnabled = true;
    }

    private void UpdateRgb(Color color) {
      this.HslEnabled = false;
      this.Rgb = color;
      // OnColorChanged?.Invoke(color);
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