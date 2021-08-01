using System;
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
      this.colorSpacePanelLeft.OnIndexChanged += OnColorSpacePanelLeftIndexChanged;
      this.colorSpacePanelRight.OnIndexChanged += OnColorSpacePanelRightIndexChanged;
      // this.Preset = (Color.FromArgb(0, 204, 204), Color.FromArgb(153, 153, 255));
    }

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
      var l = (int) (color.GetBrightness() * 100);
      this.vScrollBarLeft.Value = l;
      this.buttonBlockLeft.LocalUpdate(l, color);
      this.OnLeftUpdated?.Invoke(color);
    }

    public void OnCardCollectionRightClicked(Color color) {
      this.colorSpacePanelRight.Rgb = color;
      var l = (int) (color.GetBrightness() * 100);
      this.vScrollBarRight.Value = l;
      this.buttonBlockRight.LocalUpdate(l, color);
      this.OnRightUpdated?.Invoke(color);
    }

    private void vScrollBarLeft_Scroll(object sender, ScrollEventArgs e) {
      this.colorSpacePanelLeft.OnIndexChanged -= OnColorSpacePanelLeftIndexChanged;
      var hsl = this.colorSpacePanelLeft.Hsl.UpdateLightness(this.vScrollBarLeft.Value);
      this.colorSpacePanelLeft.Hsl = hsl;
      this.colorSpacePanelLeft.OnIndexChanged += OnColorSpacePanelLeftIndexChanged;
      var color = this.colorSpacePanelLeft.Rgb;
      this.buttonBlockLeft.LocalUpdate((int) hsl.l, color);
      this.OnLeftUpdated?.Invoke(color);
    }
    private void vScrollBarRight_Scroll(object sender, ScrollEventArgs e) {
      this.colorSpacePanelRight.OnIndexChanged -= OnColorSpacePanelRightIndexChanged;
      var hsl = this.colorSpacePanelRight.Hsl.UpdateLightness(this.vScrollBarRight.Value);
      this.colorSpacePanelRight.Hsl = hsl;
      this.colorSpacePanelRight.OnIndexChanged += OnColorSpacePanelRightIndexChanged;
      var color = this.colorSpacePanelRight.Rgb;
      this.buttonBlockRight.LocalUpdate((int) hsl.l, color);
      this.OnRightUpdated?.Invoke(color);
    }

    public void OnColorSpacePanelLeftIndexChanged(Color color) {
      var l = (int) (color.GetBrightness() * 100);
      this.vScrollBarLeft.Value = l;
      this.buttonBlockLeft.LocalUpdate(l, color);
      this.OnLeftUpdated?.Invoke(color);
    }

    public void OnColorSpacePanelRightIndexChanged(Color color) {
      var l = (int) (color.GetBrightness() * 100);
      this.vScrollBarRight.Value = l;
      this.buttonBlockRight.LocalUpdate(l, color);
      this.OnRightUpdated?.Invoke(color);
    }
  }
}