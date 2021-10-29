using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Angrand.GUI.PresetQueue {
  public partial class MatrixPalettControl : UserControl {
    public MatrixPalettControl() {
      InitializeComponent();
      cardMatrix.OnClicked += OnCardMatrixClicked;
      colorSpacePanel.OnColorChanged += OnColorSpacePanelIndexChanged;
      // this.Color = Color.FromArgb(0, 204, 204);
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Color Color {
      get => colorSpacePanel.Rgb;
      set => colorSpacePanel.Rgb = value;
    }
    public event Action OnDoneClicked;
    private void OnButtonDone_Click(object sender, EventArgs e) => OnDoneClicked?.Invoke();
    public void OnCardMatrixClicked(Color color) {
      colorSpacePanel.Rgb = color;
      var l = (int) (color.GetBrightness() * 100);
      vScrollBar.Value = l;
      buttonBlock.LocalUpdate(l, color);
    }
    private void vScrollBar_Scroll(object sender, ScrollEventArgs e) {
      colorSpacePanel.OnColorChanged -= OnColorSpacePanelIndexChanged;
      var hsl = colorSpacePanel.Hsl.UpdateLightness(vScrollBar.Value);
      colorSpacePanel.Hsl = hsl;
      colorSpacePanel.OnColorChanged += OnColorSpacePanelIndexChanged;
      buttonBlock.LocalUpdate((int) hsl.l, colorSpacePanel.Rgb);
    }
    public void OnColorSpacePanelIndexChanged(Color color) {
      var l = (int) (color.GetBrightness() * 100);
      vScrollBar.Value = l;
      buttonBlock.LocalUpdate(l, color);
    }
  }
}