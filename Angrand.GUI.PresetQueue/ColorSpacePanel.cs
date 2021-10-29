using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Palett;
using Veho;

namespace Angrand.GUI.PresetQueue {
  public partial class ColorSpacePanel : UserControl {
    public bool RgbEnabled = true;
    public bool HslEnabled = true;
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Color Rgb {
      get => Enabled
        ? Color.FromArgb(comboBoxR.SelectedIndex, comboBoxG.SelectedIndex, comboBoxB.SelectedIndex)
        : Color.Empty;
      set {
        RgbEnabled = false;
        SetRgbSelection(value);
        Enabled = !value.IsEmpty;
        if (HslEnabled) { Hsl = value.ColorToHsl(); }
        else { OnColorChanged?.Invoke(value); }
        RgbEnabled = true;
      }
    }
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public (float h, float s, float l) Hsl {
      get => (comboBoxH.SelectedIndex, comboBoxS.SelectedIndex, comboBoxL.SelectedIndex);
      set {
        HslEnabled = false;
        SetHslSelection(value);
        var color = value.HslToColor();
        if (RgbEnabled) { Rgb = color; }
        else { OnColorChanged?.Invoke(color); }
        HslEnabled = true;
      }
    }
    public event Action<Color> OnColorChanged;
    public ColorSpacePanel() {
      InitializeComponent();
      object[] indexes;
      comboBoxR.Items.AddRange(indexes = Vec.Init(256, x => (object)x));
      comboBoxG.Items.AddRange(indexes); // indexes = Enumerable.Range(0, 256).Select(x => (object) x).ToArray();
      comboBoxB.Items.AddRange(indexes);
      comboBoxH.Items.AddRange(indexes = Vec.Init(361, x => (object)x));
      comboBoxS.Items.AddRange(indexes = Vec.Init(101, x => (object)x));
      comboBoxL.Items.AddRange(indexes);
      Rgb = Color.Gainsboro;
    }
    private void SetRgbSelection(Color color) { // if color.IsEmpty: R/G/B equals to 0
      comboBoxR.SelectedIndex = color.R;
      comboBoxG.SelectedIndex = color.G;
      comboBoxB.SelectedIndex = color.B;
    }
    private void SetHslSelection((float h, float s, float l) hsl) {
      comboBoxH.SelectedIndex = (int)hsl.h;
      comboBoxS.SelectedIndex = (int)hsl.s;
      comboBoxL.SelectedIndex = (int)hsl.l;
    }
    private void RgbSelectedIndexChanged(object sender, EventArgs e) {
      if (!RgbEnabled) return;
      RgbEnabled = false;
      Hsl = Rgb.ColorToHsl();
      RgbEnabled = true;
    }
    private void HslSelectedIndexChanged(object sender, EventArgs e) {
      if (!HslEnabled) return;
      HslEnabled = false;
      Rgb = Hsl.HslToColor();
      HslEnabled = true;
    }
  }
}