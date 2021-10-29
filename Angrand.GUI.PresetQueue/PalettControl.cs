using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Angrand.GUI.PresetQueue {
  public partial class PalettControl : UserControl {
    private bool ScrollLeftEnabled = true;
    private bool ScrollRightEnabled = true;
    public event Action OnDoneClicked;
    public event Action<Color> OnLeftUpdated;
    public event Action<Color> OnRightUpdated;
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public (Color min, Color max) Preset {
      get => (colorSpacePanelLeft.Rgb, colorSpacePanelRight.Rgb);
      set => (colorSpacePanelLeft.Rgb, colorSpacePanelRight.Rgb) = value;
    }

    public PalettControl() {
      InitializeComponent();
      colorSpacePanelLeft.OnColorChanged += UpdateLeft;
      colorSpacePanelRight.OnColorChanged += UpdateRight;
      cardCollectionLeft.OnClicked += OnCardCollectionLeftClicked;
      cardCollectionRight.OnClicked += OnCardCollectionRightClicked;
    }
    public void UpdateLeft(Color color) {
      var value = (int) (color.GetBrightness() * 100);
      if (ScrollLeftEnabled) vScrollBarLeft.Value = value;
      buttonBlockLeft.LocalUpdate(value, color);
      OnLeftUpdated?.Invoke(color);
    }
    public void UpdateRight(Color color) {
      var value = (int) (color.GetBrightness() * 100);
      if (ScrollRightEnabled) vScrollBarRight.Value = value;
      buttonBlockRight.LocalUpdate(value, color);
      OnRightUpdated?.Invoke(color);
    }
    public void OnCardCollectionLeftClicked(Color color) => colorSpacePanelLeft.Rgb = color;
    public void OnCardCollectionRightClicked(Color color) => colorSpacePanelRight.Rgb = color;
    private void vScrollBarLeft_Scroll(object sender, ScrollEventArgs e) {
      ScrollLeftEnabled = false;
      var hsl = colorSpacePanelLeft.Hsl.UpdateLightness(vScrollBarLeft.Value);
      colorSpacePanelLeft.Hsl = hsl;
      ScrollLeftEnabled = true;
    }
    private void vScrollBarRight_Scroll(object sender, ScrollEventArgs e) {
      ScrollRightEnabled = false;
      var hsl = colorSpacePanelRight.Hsl.UpdateLightness(vScrollBarRight.Value);
      colorSpacePanelRight.Hsl = hsl;
      ScrollRightEnabled = true;
    }
    private void OnButtonDone_Click(object sender, EventArgs e) => OnDoneClicked?.Invoke();
  }
}