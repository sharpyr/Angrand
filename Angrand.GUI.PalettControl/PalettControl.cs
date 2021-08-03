using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Palett.Types;

namespace Angrand.GUI.PalettControl {
  public partial class PalettControl : UserControl {
    private bool ScrollLeftEnabled = true;
    private bool ScrollRightEnabled = true;
    public event Action OnDoneClicked;
    public event Action<Color> OnLeftUpdated;
    public event Action<Color> OnRightUpdated;
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public (Color min, Color max) Preset {
      get => (this.colorSpacePanelLeft.Rgb, this.colorSpacePanelRight.Rgb);
      set => (this.colorSpacePanelLeft.Rgb, this.colorSpacePanelRight.Rgb) = value;
    }

    public PalettControl() {
      InitializeComponent();
      this.colorSpacePanelLeft.OnColorChanged += UpdateLeft;
      this.colorSpacePanelRight.OnColorChanged += UpdateRight;
      this.cardCollectionLeft.OnClicked += OnCardCollectionLeftClicked;
      this.cardCollectionRight.OnClicked += OnCardCollectionRightClicked;
    }
    public void UpdateLeft(Color color) {
      var value = (int) (color.GetBrightness() * 100);
      if (ScrollLeftEnabled) this.vScrollBarLeft.Value = value;
      this.buttonBlockLeft.LocalUpdate(value, color);
      this.OnLeftUpdated?.Invoke(color);
    }
    public void UpdateRight(Color color) {
      var value = (int) (color.GetBrightness() * 100);
      if (ScrollRightEnabled) this.vScrollBarRight.Value = value;
      this.buttonBlockRight.LocalUpdate(value, color);
      this.OnRightUpdated?.Invoke(color);
    }
    public void OnCardCollectionLeftClicked(Color color) => this.colorSpacePanelLeft.Rgb = color;
    public void OnCardCollectionRightClicked(Color color) => this.colorSpacePanelRight.Rgb = color;
    private void vScrollBarLeft_Scroll(object sender, ScrollEventArgs e) {
      ScrollLeftEnabled = false;
      var hsl = this.colorSpacePanelLeft.Hsl.UpdateLightness(this.vScrollBarLeft.Value);
      this.colorSpacePanelLeft.Hsl = hsl;
      ScrollLeftEnabled = true;
    }
    private void vScrollBarRight_Scroll(object sender, ScrollEventArgs e) {
      ScrollRightEnabled = false;
      var hsl = this.colorSpacePanelRight.Hsl.UpdateLightness(this.vScrollBarRight.Value);
      this.colorSpacePanelRight.Hsl = hsl;
      ScrollRightEnabled = true;
    }
    private void OnButtonDone_Click(object sender, EventArgs e) => OnDoneClicked?.Invoke();
  }
}