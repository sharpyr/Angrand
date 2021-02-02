using System;
using System.Drawing;
using System.Windows.Forms;

namespace Angrand.GUI.PalettControl {
  public partial class PalettControl : UserControl {
    public (Color, Color) Preset {
      get => (this.colorSpacePanelLeft.Rgb, this.colorSpacePanelRight.Rgb);
      set => (this.colorSpacePanelLeft.Rgb, this.colorSpacePanelRight.Rgb) = value;
    }

    public PalettControl() {
      InitializeComponent();
      this.cardCollectionLeft.OnClicked += OnCardCollectionLeftClicked;
      this.cardCollectionRight.OnClicked += OnCardCollectionRightClicked;
      this.colorSpacePanelLeft.OnIndexChanged += OnColorSpacePanelLeftIndexChanged;
      this.colorSpacePanelRight.OnIndexChanged += OnColorSpacePanelRightIndexChanged;
    }

    private void PalettControl_Load(object sender, EventArgs e) {
      // this.Preset = (Color.FromArgb(0, 204, 204), Color.FromArgb(153, 153, 255));
    }

    public event Action OnDoneClicked;

    private void OnButtonDone_Click(object sender, EventArgs e) => OnDoneClicked?.Invoke();

    public void OnCardCollectionLeftClicked(Color color) {
      this.colorSpacePanelLeft.Rgb = color;
      var l = (int) (color.GetBrightness() * 100);
      this.vScrollBarLeft.Value = l;
      this.buttonBlockLeft.LocalUpdate(l, color);
    }

    public void OnCardCollectionRightClicked(Color color) {
      this.colorSpacePanelRight.Rgb = color;
      var l = (int) (color.GetBrightness() * 100);
      this.vScrollBarRight.Value = l;
      this.buttonBlockRight.LocalUpdate(l, color);
    }

    private void vScrollBarLeft_Scroll(object sender, ScrollEventArgs e) {
      this.colorSpacePanelLeft.OnIndexChanged -= OnColorSpacePanelLeftIndexChanged;
      var hsl = this.colorSpacePanelLeft.Hsl.UpdateLightness(this.vScrollBarLeft.Value);
      this.colorSpacePanelLeft.Hsl = hsl;
      this.colorSpacePanelLeft.OnIndexChanged += OnColorSpacePanelLeftIndexChanged;
      this.buttonBlockRight.LocalUpdate((int) hsl.l, this.colorSpacePanelLeft.Rgb);
    }
    private void vScrollBarRight_Scroll(object sender, ScrollEventArgs e) {
      this.colorSpacePanelRight.OnIndexChanged -= OnColorSpacePanelRightIndexChanged;
      var hsl = this.colorSpacePanelRight.Hsl.UpdateLightness(this.vScrollBarRight.Value);
      this.colorSpacePanelRight.Hsl = hsl;
      this.colorSpacePanelRight.OnIndexChanged += OnColorSpacePanelRightIndexChanged;
      this.buttonBlockRight.LocalUpdate((int) hsl.l, this.colorSpacePanelRight.Rgb);
    }

    public void OnColorSpacePanelLeftIndexChanged(Color color) {
      var l = (int) (color.GetBrightness() * 100);
      this.vScrollBarLeft.Value = l;
      this.buttonBlockLeft.LocalUpdate(l, color);
    }

    public void OnColorSpacePanelRightIndexChanged(Color color) {
      var l = (int) (color.GetBrightness() * 100);
      this.vScrollBarRight.Value = l;
      this.buttonBlockRight.LocalUpdate(l, color);
    }
  }
}