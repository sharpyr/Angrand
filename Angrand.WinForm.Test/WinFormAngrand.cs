using System;
using System.Drawing;
using System.Windows.Forms;

namespace Angrand.PalettApp {
  public partial class WinFormAngrand : Form {
    public WinFormAngrand() {
      InitializeComponent();
    }

    private void WinFormAngrand_Load(object sender, EventArgs e) { }

    private void palettControlMajor_Load(object sender, EventArgs e) {
      palettControlMajor.OnButtonDoneClicked += this.Close;
      palettControlMajor.ColorPair = (Color.DarkTurquoise, Color.LightBlue);
    }
  }
}