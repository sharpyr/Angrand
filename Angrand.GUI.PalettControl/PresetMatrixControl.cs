using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Palett;

namespace Angrand.GUI.PalettControl {
  public partial class PresetMatrixControl : UserControl {
    public PresetMatrixControl() {
      InitializeComponent();
      this.buttonDone.DragEnter += button_DragEnter;
      this.buttonDone.DragDrop += button_DragDrop;
      this.matrixPanel.SaturationThreshold = 75;
      this.matrixPanel.LightnessMinimum = 0;
      this.matrixPanel.HueThreshold = 120;
      this.matrixPanel.HueRange = 180;
      this.matrixPanel.OnMouseMoved += this.button_OnMouseMove;
      this.matrixPanel.OnMouseLeft += this.button_OnMouseLeave;
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public (Color min, Color max) Preset {
      get => (this.colorPanelLeft.Rgb, this.colorPanelRight.Rgb);
      set => (this.colorPanelLeft.Rgb, this.colorPanelRight.Rgb) = value;
    }
    public event Action OnDoneClicked;

    private void buttonDone_Click(object sender, EventArgs e) {
      this.OnDoneClicked?.Invoke();
    }

    private void button_OnMouseMove(Button sender) {
      if (sender.Name.StartsWith("button")) return;
      this.buttonDone.Text = sender.Name;
      this.buttonDone.BackColor = sender.BackColor;
      this.buttonDone.ForeColor = sender.BackColor.Reverse();
    }
    private void button_OnMouseLeave(Button sender) {
      this.buttonDone.Text = "Done";
      this.buttonDone.BackColor = Color.WhiteSmoke;
      this.buttonDone.ForeColor = Color.Gray;
    }

    private void button_DragEnter(object sender, DragEventArgs e) {
      if (e.Data.GetDataPresent("System.Drawing.Color"))
        e.Effect = DragDropEffects.Copy;
      else
        e.Effect = DragDropEffects.None;
    }
    private void button_DragDrop(object sender, DragEventArgs e) {
      ((Control)sender).BackColor = (Color)e.Data.GetData(typeof(Color));
    }
  }
}