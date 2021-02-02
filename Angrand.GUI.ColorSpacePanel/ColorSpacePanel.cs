using System;
using System.Drawing;
using System.Windows.Forms;
using Palett.Convert;
using Veho.Vector;

namespace Angrand.GUI.ColorSpacePanel {
  public partial class ColorSpacePanel : UserControl {
    public Color Rgb {
      get => Color.FromArgb(comboBoxR.SelectedIndex, comboBoxG.SelectedIndex, comboBoxB.SelectedIndex);
      set {
        this.RgbCollectionEnabled = false;
        // Debug.Print($"set rgb {value} (hsl: {value.ColorToHsl()})");
        this.comboBoxR.SelectedIndex = value.R;
        this.comboBoxG.SelectedIndex = value.G;
        this.comboBoxB.SelectedIndex = value.B;
        if (this.HslCollectionEnabled) this.Hsl = value.ColorToHsl();
        OnIndexChanged?.Invoke(this.Rgb);
        this.RgbCollectionEnabled = true;
      }
    }

    public (float h, float s, float l) Hsl {
      get => (comboBoxH.SelectedIndex, comboBoxS.SelectedIndex, comboBoxL.SelectedIndex);
      set {
        this.HslCollectionEnabled = false;
        // Debug.Print($"set hsl {value} (rgb {value.HslToRgb()})");
        this.comboBoxH.SelectedIndex = (int) value.h;
        this.comboBoxS.SelectedIndex = (int) value.s;
        this.comboBoxL.SelectedIndex = (int) value.l;
        if (this.RgbCollectionEnabled) this.Rgb = value.HslToColor();
        OnIndexChanged?.Invoke(this.Rgb);
        this.HslCollectionEnabled = true;
      }
    }

    public event Action<Color> OnIndexChanged;

    public bool RgbCollectionEnabled = true;
    public bool HslCollectionEnabled = true;

    private void UpdateHslCollection((float, float, float) hsl) {
      this.RgbCollectionEnabled = false;
      this.Hsl = hsl;
      this.RgbCollectionEnabled = true;
    }

    private void UpdateRgbCollection(Color color) {
      this.HslCollectionEnabled = false;
      this.Rgb = color;
      this.HslCollectionEnabled = true;
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
      if (!this.RgbCollectionEnabled) return;
      this.UpdateHslCollection(this.Rgb.ColorToHsl());
      OnIndexChanged?.Invoke(this.Rgb);
    }

    private void HslSelectedIndexChanged(object sender, EventArgs e) {
      if (!this.HslCollectionEnabled) return;
      this.UpdateRgbCollection(this.Hsl.HslToColor());
      OnIndexChanged?.Invoke(this.Rgb);
    }
  }
}