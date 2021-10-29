using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Palett;

namespace Angrand.GUI.PalettControl {
  public partial class PresetMatrixControl : UserControl {
    public event EventHandler OnDoneClicked {
      add => buttonDone.Click += value;
      remove => buttonDone.Click -= value;
    }
    public event Action<Color> OnLeftColorChanged {
      add => colorPanelLeft.OnColorChanged += value;
      remove => colorPanelLeft.OnColorChanged -= value;
    }
    public event Action<Color> OnRightColorChanged {
      add => colorPanelRight.OnColorChanged += value;
      remove => colorPanelRight.OnColorChanged -= value;
    }
    public PresetMatrixControl() {
      InitializeComponent();
      scrollablePixelMatrix.InitializeParameters(0, 75, 120, 180, true);
      scrollablePixelMatrix.OnMouseMoved += button_OnMouseMove;
      scrollablePixelMatrix.OnMouseLeft += button_OnMouseLeave;
      colorPanelLeft.OnTextBoxMouseDown += colorPanel_MouseDown;
      colorPanelRight.OnTextBoxMouseDown += colorPanel_MouseDown;
      buttonDone.DragEnter += button_DragEnter;
      buttonDone.DragDrop += button_DragDrop;
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public (Color min, Color max) Preset {
      get => (colorPanelLeft.Rgb, colorPanelRight.Rgb);
      set => (colorPanelLeft.Rgb, colorPanelRight.Rgb) = value;
    }

    private void button_OnMouseMove(object sender, MouseEventArgs e) {
      var button = (Button)sender;
      if (button.Name.StartsWith("button")) return;
      buttonDone.Text = button.Name;
      buttonDone.BackColor = button.BackColor;
      buttonDone.ForeColor = button.BackColor.Reverse();
    }
    private void button_OnMouseLeave(object sender, EventArgs e) {
      buttonDone.Text = "Done";
      buttonDone.BackColor = Color.WhiteSmoke;
      buttonDone.ForeColor = Color.Gray;
    }

    private void button_DragEnter(object sender, DragEventArgs e) {
      e.Effect = e.Data.GetDataPresent(typeof(Color)) ? DragDropEffects.Copy : DragDropEffects.None;
    }
    private void button_DragDrop(object sender, DragEventArgs e) {
      ((Control)sender).BackColor = (Color)e.Data.GetData(typeof(Color));
    }

    private void colorPanel_MouseDown(object sender, MouseEventArgs e) {
      // Console.WriteLine($">> [{((Control)sender).Name}] {0}");
      DoDragDrop(Preset, DragDropEffects.Copy | DragDropEffects.Move);
    }
  }
}