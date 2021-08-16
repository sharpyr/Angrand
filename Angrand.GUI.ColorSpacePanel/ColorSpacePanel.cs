using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Palett.Convert;
using Veho;

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
        if (this.HslEnabled) { this.Hsl = value.ColorToHsl(); } else { this.OnColorChanged?.Invoke(value); }
        this.RgbEnabled = true;
      }
    }
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public (float h, float s, float l) Hsl {
      get => (comboBoxH.SelectedIndex, comboBoxS.SelectedIndex, comboBoxL.SelectedIndex);
      set {
        this.HslEnabled = false;
        this.SetHslSelection(value);
        var color = value.HslToColor();
        if (this.RgbEnabled) { this.Rgb = color; } else { this.OnColorChanged?.Invoke(color); }
        this.HslEnabled = true;
      }
    }
    public event Action<Color> OnColorChanged;
    public ColorSpacePanel() {
      InitializeComponent();
      object[] indexes;
      this.comboBoxR.Items.AddRange(indexes = Vec.Init(256, x => (object) x));
      this.comboBoxG.Items.AddRange(indexes); // indexes = Enumerable.Range(0, 256).Select(x => (object) x).ToArray();
      this.comboBoxB.Items.AddRange(indexes);
      this.comboBoxH.Items.AddRange(indexes = Vec.Init(361, x => (object) x));
      this.comboBoxS.Items.AddRange(indexes = Vec.Init(101, x => (object) x));
      this.comboBoxL.Items.AddRange(indexes);
      this.Rgb = Color.Gainsboro;
    }
    private void SetRgbSelection(Color color) { // if color.IsEmpty: R/G/B equals to 0
      this.comboBoxR.SelectedIndex = color.R;
      this.comboBoxG.SelectedIndex = color.G;
      this.comboBoxB.SelectedIndex = color.B;
    }
    private void SetHslSelection((float h, float s, float l) hsl) {
      this.comboBoxH.SelectedIndex = (int) hsl.h;
      this.comboBoxS.SelectedIndex = (int) hsl.s;
      this.comboBoxL.SelectedIndex = (int) hsl.l;
    }
    private void RgbSelectedIndexChanged(object sender, EventArgs e) {
      if (!this.RgbEnabled) return;
      this.RgbEnabled = false;
      this.Hsl = this.Rgb.ColorToHsl();
      this.RgbEnabled = true;
    }
    private void HslSelectedIndexChanged(object sender, EventArgs e) {
      if (!this.HslEnabled) return;
      this.HslEnabled = false;
      this.Rgb = this.Hsl.HslToColor();
      this.HslEnabled = true;
    }
  }
}