using System;
using System.Drawing;
using System.Windows.Forms;

namespace Angrand.GUI.PalettControl {
  public partial class MatrixPalettControl : UserControl {
    public MatrixPalettControl() {
      InitializeComponent();
      this.cardMatrix.OnClicked += OnCardCollectionClicked;
      this.colorSpacePanel.OnIndexChanged += OnColorSpacePanelIndexChanged;
      // this.Color = Color.FromArgb(0, 204, 204);
    }
    public Color Color {
      get => this.colorSpacePanel.Rgb;
      set => this.colorSpacePanel.Rgb = value;
    }
    public event Action OnDoneClicked;
    private void OnButtonDone_Click(object sender, EventArgs e) => OnDoneClicked?.Invoke();
    public void OnCardCollectionClicked(Color color) {
      this.colorSpacePanel.Rgb = color;
      var l = (int) (color.GetBrightness() * 100);
      this.vScrollBar.Value = l;
      this.buttonBlock.LocalUpdate(l, color);
    }
    private void vScrollBar_Scroll(object sender, ScrollEventArgs e) {
      this.colorSpacePanel.OnIndexChanged -= OnColorSpacePanelIndexChanged;
      var hsl = this.colorSpacePanel.Hsl.UpdateLightness(this.vScrollBar.Value);
      this.colorSpacePanel.Hsl = hsl;
      this.colorSpacePanel.OnIndexChanged += OnColorSpacePanelIndexChanged;
      this.buttonBlock.LocalUpdate((int) hsl.l, this.colorSpacePanel.Rgb);
    }
    public void OnColorSpacePanelIndexChanged(Color color) {
      var l = (int) (color.GetBrightness() * 100);
      this.vScrollBar.Value = l;
      this.buttonBlock.LocalUpdate(l, color);
    }
  }
}