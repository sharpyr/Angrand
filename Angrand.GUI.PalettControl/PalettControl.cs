using System;
using System.ComponentModel;
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
      this.colorSpacePanelLeft.OnColorChanged += OnColorSpacePanelLeftIndexChanged;
      this.colorSpacePanelRight.OnColorChanged += OnColorSpacePanelRightIndexChanged;
      // this.Preset = (Color.FromArgb(0, 204, 204), Color.FromArgb(153, 153, 255));
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public (Color min, Color max) Preset {
      get => (this.colorSpacePanelLeft.Rgb, this.colorSpacePanelRight.Rgb);
      set => (this.colorSpacePanelLeft.Rgb, this.colorSpacePanelRight.Rgb) = value;
    }

    private void PalettControl_Load(object sender, EventArgs e) {
      // this.Preset = (Color.FromArgb(0, 204, 204), Color.FromArgb(153, 153, 255));
    }

    public event Action OnDoneClicked;
    public event Action<Color> OnLeftUpdated;
    public event Action<Color> OnRightUpdated;

    private void OnButtonDone_Click(object sender, EventArgs e) => OnDoneClicked?.Invoke();

    public void OnCardCollectionLeftClicked(Color color) {
      this.colorSpacePanelLeft.Rgb = color;
      var value = (int) (color.GetBrightness() * 100);
      this.vScrollBarLeft.Value = value;
      this.buttonBlockLeft.LocalUpdate(value, color);
    }

    public void OnCardCollectionRightClicked(Color color) {
      this.colorSpacePanelRight.Rgb = color;
      var value = (int) (color.GetBrightness() * 100);
      this.vScrollBarRight.Value = value;
      this.buttonBlockRight.LocalUpdate(value, color);
    }

    private void vScrollBarLeft_Scroll(object sender, ScrollEventArgs e) {
      this.colorSpacePanelLeft.OnColorChanged -= OnColorSpacePanelLeftIndexChanged;
      var hsl = this.colorSpacePanelLeft.Hsl.UpdateLightness(this.vScrollBarLeft.Value);
      this.colorSpacePanelLeft.Hsl = hsl;
      this.colorSpacePanelLeft.OnColorChanged += OnColorSpacePanelLeftIndexChanged;
      var color = this.colorSpacePanelLeft.Rgb;
      this.buttonBlockLeft.LocalUpdate((int) hsl.l, color);
    }
    private void vScrollBarRight_Scroll(object sender, ScrollEventArgs e) {
      this.colorSpacePanelRight.OnColorChanged -= OnColorSpacePanelRightIndexChanged;
      var hsl = this.colorSpacePanelRight.Hsl.UpdateLightness(this.vScrollBarRight.Value);
      this.colorSpacePanelRight.Hsl = hsl;
      this.colorSpacePanelRight.OnColorChanged += OnColorSpacePanelRightIndexChanged;
      var color = this.colorSpacePanelRight.Rgb;
      this.buttonBlockRight.LocalUpdate((int) hsl.l, color);
    }

    public void OnColorSpacePanelLeftIndexChanged(Color color) {
      var value = (int) (color.GetBrightness() * 100);
      this.vScrollBarLeft.Value = value;
      this.buttonBlockLeft.LocalUpdate(value, color);
      this.OnLeftUpdated?.Invoke(color);
    }

    public void OnColorSpacePanelRightIndexChanged(Color color) {
      var value = (int) (color.GetBrightness() * 100);
      this.vScrollBarRight.Value = value;
      this.buttonBlockRight.LocalUpdate(value, color);
      this.OnRightUpdated?.Invoke(color);
    }
  }
}