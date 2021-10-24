using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Palett;

namespace Angrand.GUI.PalettControl {
  public partial class PresetMatrixControl : UserControl {
    public event EventHandler OnDoneClicked {
      add => this.buttonDone.Click += value;
      remove => this.buttonDone.Click -= value;
    }
    public event Action<Color> OnLeftColorChanged {
      add => this.colorPanelLeft.OnColorChanged += value;
      remove => this.colorPanelLeft.OnColorChanged -= value;
    }
    public event Action<Color> OnRightColorChanged {
      add => this.colorPanelRight.OnColorChanged += value;
      remove => this.colorPanelRight.OnColorChanged -= value;
    }
    public PresetMatrixControl() {
      InitializeComponent();
      this.matrixPanel.SaturationThreshold = 75;
      this.matrixPanel.LightnessMinimum = 0;
      this.matrixPanel.HueThreshold = 120;
      this.matrixPanel.HueRange = 180;
      this.matrixPanel.OnMouseMoved += this.button_OnMouseMove;
      this.matrixPanel.OnMouseLeft += this.button_OnMouseLeave;
      this.colorPanelLeft.OnTextBoxMouseDown += this.colorPanel_MouseDown;
      this.colorPanelRight.OnTextBoxMouseDown += this.colorPanel_MouseDown;
      this.buttonDone.DragEnter += this.button_DragEnter;
      this.buttonDone.DragDrop += this.button_DragDrop;
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public (Color min, Color max) Preset {
      get => (this.colorPanelLeft.Rgb, this.colorPanelRight.Rgb);
      set => (this.colorPanelLeft.Rgb, this.colorPanelRight.Rgb) = value;
    }

    private void button_OnMouseMove(object sender, MouseEventArgs e) {
      var button = (Button)sender;
      if (button.Name.StartsWith("button")) return;
      this.buttonDone.Text = button.Name;
      this.buttonDone.BackColor = button.BackColor;
      this.buttonDone.ForeColor = button.BackColor.Reverse();
    }
    private void button_OnMouseLeave(object sender, EventArgs e) {
      this.buttonDone.Text = "Done";
      this.buttonDone.BackColor = Color.WhiteSmoke;
      this.buttonDone.ForeColor = Color.Gray;
    }

    private void button_DragEnter(object sender, DragEventArgs e) {
      e.Effect = e.Data.GetDataPresent(typeof(Color))
        ? DragDropEffects.Copy
        : DragDropEffects.None;
    }
    private void button_DragDrop(object sender, DragEventArgs e) {
      ((Control)sender).BackColor = (Color)e.Data.GetData(typeof(Color));
    }

    private void colorPanel_MouseDown(object sender, MouseEventArgs e) {
      Console.WriteLine($">> [{((Control)sender).Name}] {0}");
      this.DoDragDrop(this.Preset, DragDropEffects.Copy | DragDropEffects.Move);
    }
  }
}