using System;
using System.Windows.Forms;

namespace Angrand.PalettApp {
  public partial class WinFormAngrand : Form {
    public WinFormAngrand() {
      InitializeComponent();
    }

    private void WinFormAngrand_Load(object sender, EventArgs e) { }


    private void presetPalettControl_Load(object sender, EventArgs e) {
      presetPalettControl.OnDoneClicked += this.Close;
      // presetPalettControl.Preset = (Color.FromArgb(0, 204, 204), Color.FromArgb(153, 153, 255));
    }
  }
}