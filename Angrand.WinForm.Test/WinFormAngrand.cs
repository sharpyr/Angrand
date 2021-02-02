using System;
using System.Windows.Forms;
using Angrand.GUI.PalettControl;

namespace Angrand.PalettApp {
  public partial class WinFormAngrand : Form {
    public WinFormAngrand() {
      InitializeComponent();
    }

    private void WinFormAngrand_Load(object sender, EventArgs e) { }


    private void presetPalettControl_Load(object sender, EventArgs e) {
      // presetPalettControl.OnDoneClicked += this.Close;
      // presetPalettControl.Preset = (Color.FromArgb(0, 204, 204), Color.FromArgb(153, 153, 255));
    }


    private void presetPalettControl1_Load_1(object sender, EventArgs e) {
      // presetPalettControl1.Preset = Utils.DefaultPreset;
      // presetPalettControl1.PresetCollection = Utils.PresetCollection;
    }
  }
}