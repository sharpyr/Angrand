using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Palett.Types;

namespace Angrand.GUI.PalettControl {
  public partial class PalettControl : UserControl {
    public PalettControl() {
      InitializeComponent();
      this.cardCollectionLeft.OnClicked += OnCardCollectionLeftClicked;
      this.cardCollectionRight.OnClicked += OnCardCollectionRightClicked;
      // this.colorSpacePanelLeft.OnColorChanged += PanelLeftOnChanged;
      // this.colorSpacePanelRight.OnColorChanged += PanelRightOnChanged;
      this.colorSpacePanelLeft.OnColorChanged += UpdateLeft;
      this.colorSpacePanelRight.OnColorChanged += UpdateRight;

      // this.Preset = (Color.FromArgb(0, 204, 204), Color.FromArgb(153, 153, 255));
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public (Color min, Color max) Preset {
      get => (this.colorSpacePanelLeft.Rgb, this.colorSpacePanelRight.Rgb);
      set {
        (this.colorSpacePanelLeft.Rgb, this.colorSpacePanelRight.Rgb) = value;
        // this.UpdateLeft(value.min);
        // this.UpdateRight(value.max);
      }
    }

    private void PalettControl_Load(object sender, EventArgs e) {
      // this.Preset = (Color.FromArgb(0, 204, 204), Color.FromArgb(153, 153, 255));
    }

    public event Action OnDoneClicked;
    public event Action<Color> OnLeftUpdated;
    public event Action<Color> OnRightUpdated;

    private void OnButtonDone_Click(object sender, EventArgs e) => OnDoneClicked?.Invoke();

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

    public void OnCardCollectionLeftClicked(Color color) {
      this.colorSpacePanelLeft.Rgb = color;
      // this.UpdateLeft(color);
    }

    public void OnCardCollectionRightClicked(Color color) {
      this.colorSpacePanelRight.Rgb = color;
      // this.UpdateRight(color);
    }

    private bool ScrollLeftEnabled = true;
    private bool ScrollRightEnabled = true;

    private void vScrollBarLeft_Scroll(object sender, ScrollEventArgs e) {
      // this.colorSpacePanelLeft.OnColorChanged -= OnPanelLeftChanged;
      ScrollLeftEnabled = false;
      var hsl = this.colorSpacePanelLeft.Hsl.UpdateLightness(this.vScrollBarLeft.Value);
      this.colorSpacePanelLeft.Hsl = hsl;
      ScrollLeftEnabled = true;
      // this.colorSpacePanelLeft.OnColorChanged += OnPanelLeftChanged;
      this.buttonBlockLeft.LocalUpdate((int) hsl.l, this.colorSpacePanelLeft.Rgb);
    }
    private void vScrollBarRight_Scroll(object sender, ScrollEventArgs e) {
      // this.colorSpacePanelRight.OnColorChanged -= OnPanelRightChanged;
      ScrollLeftEnabled = false;
      var hsl = this.colorSpacePanelRight.Hsl.UpdateLightness(this.vScrollBarRight.Value);
      this.colorSpacePanelRight.Hsl = hsl;
      ScrollLeftEnabled = true;
      // this.colorSpacePanelRight.OnColorChanged += OnPanelRightChanged;
      this.buttonBlockRight.LocalUpdate((int) hsl.l, this.colorSpacePanelRight.Rgb);
    }

    // public void OnPanelLeftChanged(Color color) {
    //   Console.WriteLine($"OnPanelLeftChanged");
    //   var value = (int) (color.GetBrightness() * 100);
    //   if (ScrollLeftEnabled) this.vScrollBarLeft.Value = value;
    //   this.buttonBlockLeft.LocalUpdate(value, color);
    //   this.OnLeftUpdated?.Invoke(color);
    // }
    //
    // public void OnPanelRightChanged(Color color) {
    //   Console.WriteLine($"OnPanelRightChanged");
    //   var value = (int) (color.GetBrightness() * 100);
    //   this.vScrollBarRight.Value = value;
    //   this.buttonBlockRight.LocalUpdate(value, color);
    // }

    // public void PanelLeftOnChanged(Color color) {
    //   Console.WriteLine($"PanelLeftOnChanged");
    //   // this.OnLeftUpdated?.Invoke(color);
    // }
    // public void PanelRightOnChanged(Color color) {
    //   Console.WriteLine($"PanelRightOnChanged");
    //   this.OnRightUpdated?.Invoke(color);
    // }

    private void buttonBlockLeft_BackColorChanged(object sender, EventArgs e) { }

    private void buttonBlockRight_BackColorChanged(object sender, EventArgs e) { }
  }
}