using System;
using System.Drawing;
using System.Windows.Forms;

namespace Angrand.GUI.PalettControl {
  public partial class PalettControl : UserControl {
    public (Color, Color) ColorPair {
      get => (this.colorSpacePanelLeft.Rgb, this.colorSpacePanelRight.Rgb);
      set => (this.colorSpacePanelLeft.Rgb, this.colorSpacePanelRight.Rgb) = value;
    }

    public PalettControl() {
      InitializeComponent();
      this.cardCollectionLeft.OnClicked += OnCardCollectionLeftClicked;
      this.cardCollectionRight.OnClicked += OnCardCollectionRightClicked;
      this.colorSpacePanelLeft.OnIndexChanged += OnColorSpacePanelLeftIndexChanged;
      this.colorSpacePanelRight.OnIndexChanged += OnColorSpacePanelRightIndexChanged;
      this.buttonBlockLeft.BackColor = this.colorSpacePanelLeft.Rgb;
      this.buttonBlockRight.BackColor = this.colorSpacePanelRight.Rgb;
    }

    public event Action OnButtonDoneClicked;

    private void OnButtonDone_Click(object sender, EventArgs e) => OnButtonDoneClicked?.Invoke();

    public void OnCardCollectionLeftClicked(Color color) {
      this.colorSpacePanelLeft.Rgb = color;
      this.vScrollBarLeft.Value = (int) (color.GetBrightness() * 100);
      this.buttonBlockLeft.BackColor = color;
      this.buttonBlockLeft.Text = this.vScrollBarLeft.Value.ToString();
    }

    public void OnCardCollectionRightClicked(Color color) {
      this.colorSpacePanelRight.Rgb = color;
      this.vScrollBarRight.Value = (int) (color.GetBrightness() * 100);
      this.buttonBlockRight.BackColor = color;
      this.buttonBlockRight.Text = this.vScrollBarRight.Value.ToString();
    }

    private void vScrollBarLeft_Scroll(object sender, ScrollEventArgs e) {
      this.colorSpacePanelLeft.OnIndexChanged -= OnColorSpacePanelLeftIndexChanged;
      var hsl = this.colorSpacePanelLeft.Hsl.UpdateLightness(this.vScrollBarLeft.Value);
      this.colorSpacePanelLeft.Hsl = hsl;
      this.colorSpacePanelLeft.OnIndexChanged += OnColorSpacePanelLeftIndexChanged;
      this.buttonBlockLeft.BackColor = this.colorSpacePanelLeft.Rgb;
      this.buttonBlockLeft.Text = ((int) hsl.l).ToString();
    }
    private void vScrollBarRight_Scroll(object sender, ScrollEventArgs e) {
      this.colorSpacePanelRight.OnIndexChanged -= OnColorSpacePanelRightIndexChanged;
      var hsl = this.colorSpacePanelRight.Hsl.UpdateLightness(this.vScrollBarRight.Value);
      this.colorSpacePanelRight.Hsl = hsl;
      this.colorSpacePanelRight.OnIndexChanged += OnColorSpacePanelRightIndexChanged;
      this.buttonBlockRight.BackColor = this.colorSpacePanelRight.Rgb;
      this.buttonBlockRight.Text = ((int) hsl.l).ToString();
    }

    public void OnColorSpacePanelLeftIndexChanged(Color color) {
      var l = (int) (color.GetBrightness() * 100);
      this.vScrollBarLeft.Value = l;
      this.buttonBlockLeft.BackColor = color;
      this.buttonBlockLeft.Text = l.ToString();
    }

    public void OnColorSpacePanelRightIndexChanged(Color color) {
      var l = (int) (color.GetBrightness() * 100);
      this.vScrollBarRight.Value = l;
      this.buttonBlockRight.BackColor = color;
      this.buttonBlockRight.Text = l.ToString();
    }
  }
}