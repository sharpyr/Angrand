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
      this.colorSpacePanelLeft.OnColorChanged += OnColorSpacePanelLeftChanged;
      this.colorSpacePanelRight.OnColorChanged += OnColorSpacePanelRightChanged;
      // this.Preset = (Color.FromArgb(0, 204, 204), Color.FromArgb(153, 153, 255));
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public (Color min, Color max) Preset {
      get => (this.colorSpacePanelLeft.Rgb, this.colorSpacePanelRight.Rgb);
      set {
        (this.colorSpacePanelLeft.Rgb, this.colorSpacePanelRight.Rgb) = value;
        this.UpdateLeft(value.min);
        this.UpdateRight(value.max);
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
      this.vScrollBarLeft.Value = value;
      this.buttonBlockLeft.LocalUpdate(value, color);
    }
    public void UpdateRight(Color color) {
      var value = (int) (color.GetBrightness() * 100);
      this.vScrollBarRight.Value = value;
      this.buttonBlockRight.LocalUpdate(value, color);
    }

    public void OnCardCollectionLeftClicked(Color color) {
      this.colorSpacePanelLeft.Rgb = color;
      this.UpdateLeft(color);
    }

    public void OnCardCollectionRightClicked(Color color) {
      this.colorSpacePanelRight.Rgb = color;
      this.UpdateRight(color);
    }

    private void vScrollBarLeft_Scroll(object sender, ScrollEventArgs e) {
      this.colorSpacePanelLeft.OnColorChanged -= OnColorSpacePanelLeftChanged;
      var hsl = this.colorSpacePanelLeft.Hsl.UpdateLightness(this.vScrollBarLeft.Value);
      this.colorSpacePanelLeft.Hsl = hsl;
      this.colorSpacePanelLeft.OnColorChanged += OnColorSpacePanelLeftChanged;
      this.buttonBlockLeft.LocalUpdate((int) hsl.l, this.colorSpacePanelLeft.Rgb);
    }
    private void vScrollBarRight_Scroll(object sender, ScrollEventArgs e) {
      this.colorSpacePanelRight.OnColorChanged -= OnColorSpacePanelRightChanged;
      var hsl = this.colorSpacePanelRight.Hsl.UpdateLightness(this.vScrollBarRight.Value);
      this.colorSpacePanelRight.Hsl = hsl;
      this.colorSpacePanelRight.OnColorChanged += OnColorSpacePanelRightChanged;
      this.buttonBlockRight.LocalUpdate((int) hsl.l, this.colorSpacePanelRight.Rgb);
    }

    public void OnColorSpacePanelLeftChanged(Color color) {
      Console.WriteLine($"OnColorSpacePanelLeftChanged");
      var value = (int) (color.GetBrightness() * 100);
      this.vScrollBarLeft.Value = value;
      this.buttonBlockLeft.LocalUpdate(value, color);
    }

    public void OnColorSpacePanelRightChanged(Color color) {
      Console.WriteLine($"OnColorSpacePanelRightChanged");
      var value = (int) (color.GetBrightness() * 100);
      this.vScrollBarRight.Value = value;
      this.buttonBlockRight.LocalUpdate(value, color);
    }

    private void buttonBlockLeft_BackColorChanged(object sender, EventArgs e) {
      this.OnLeftUpdated?.Invoke(buttonBlockLeft.BackColor);
    }

    private void buttonBlockRight_BackColorChanged(object sender, EventArgs e) {
      this.OnRightUpdated?.Invoke(buttonBlockRight.BackColor);
    }
  }
}