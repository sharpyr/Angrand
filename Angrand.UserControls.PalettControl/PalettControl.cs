using System.Drawing;
using System.Windows.Forms;

namespace Angrand.UserControls.PalettControl {
  public partial class PalettControl : UserControl {
    public (Color, Color) ColorPair => (this.colorSpacePanelLeft.Rgb, this.colorSpacePanelRight.Rgb);

    public PalettControl() {
      InitializeComponent();
      this.colorCardCollectionLeft.OnClicked += OnColorCardCollectionLeftClicked;
      this.colorCardCollectionRight.OnClicked += OnColorCardCollectionRightClicked;
      this.colorSpacePanelLeft.OnIndexChanged += OnColorSpacePanelLeftIndexChanged;
      this.colorSpacePanelRight.OnIndexChanged += OnColorSpacePanelRightIndexChanged;
      this.buttonBlockLeft.BackColor = this.colorSpacePanelLeft.Rgb;
      this.buttonBlockRight.BackColor = this.colorSpacePanelRight.Rgb;
    }


    public void OnColorCardCollectionLeftClicked(Color color) {
      this.buttonBlockLeft.BackColor = color;
      this.colorSpacePanelLeft.Rgb = color;
      this.vScrollBarLeft.Value = (int) (color.GetBrightness() * 100);
    }

    public void OnColorCardCollectionRightClicked(Color color) {
      this.buttonBlockRight.BackColor = color;
      this.colorSpacePanelRight.Rgb = color;
      this.vScrollBarRight.Value = (int) (color.GetBrightness() * 100);
    }

    private void vScrollBarLeft_Scroll(object sender, ScrollEventArgs e) {
      this.colorSpacePanelLeft.OnIndexChanged -= OnColorSpacePanelLeftIndexChanged;
      var hsl = this.colorSpacePanelLeft.Hsl.UpdateLightness(this.vScrollBarLeft.Value);
      this.colorSpacePanelLeft.Hsl = hsl;
      this.colorSpacePanelLeft.OnIndexChanged += OnColorSpacePanelLeftIndexChanged;
      this.buttonBlockLeft.BackColor = this.colorSpacePanelLeft.Rgb;
      buttonBlockLeft.Text = ((VScrollBar) sender).Value.ToString();
    }

    public void OnColorSpacePanelLeftIndexChanged(Color color, (bool, bool) tuple) {
      vScrollBarLeft.Value = (int) (color.GetBrightness() * 100);
    }

    private void vScrollBarRight_Scroll(object sender, ScrollEventArgs e) {
      this.colorSpacePanelRight.OnIndexChanged -= OnColorSpacePanelRightIndexChanged;
      var hsl = this.colorSpacePanelRight.Hsl.UpdateLightness(this.vScrollBarRight.Value);
      this.colorSpacePanelRight.Hsl = hsl;
      this.colorSpacePanelRight.OnIndexChanged += OnColorSpacePanelRightIndexChanged;
      this.buttonBlockRight.BackColor = this.colorSpacePanelRight.Rgb;
      buttonBlockRight.Text = ((VScrollBar) sender).Value.ToString();
    }

    public void OnColorSpacePanelRightIndexChanged(Color color, (bool, bool) tuple) {
      vScrollBarRight.Value = (int) (color.GetBrightness() * 100);
    }
  }
}