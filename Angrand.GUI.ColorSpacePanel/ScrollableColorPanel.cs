using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Palett;

namespace Angrand.GUI.ColorSpacePanel {
  public partial class ScrollableColorPanel : UserControl {
    private bool locked = false;
    public event Action<Color> OnColorChanged;
    public event MouseEventHandler OnTextBoxMouseDown {
      add => textBox.MouseDown += value;
      remove => textBox.MouseDown -= value;
    }

    public ScrollableColorPanel() {
      InitializeComponent();
      scrollableR.Label = "R";
      scrollableG.Label = "G";
      scrollableB.Label = "B";
      scrollableH.Label = "H";
      scrollableS.Label = "S";
      scrollableL.Label = "L";
      scrollableR.Bound = (0, 255 + 9);
      scrollableG.Bound = (0, 255 + 9);
      scrollableB.Bound = (0, 255 + 9);
      scrollableH.Bound = (0, 360 + 9);
      scrollableS.Bound = (0, 100 + 9);
      scrollableL.Bound = (0, 100 + 9);
      scrollableR.OnValueChanged += rgb_ValueChanged;
      scrollableG.OnValueChanged += rgb_ValueChanged;
      scrollableB.OnValueChanged += rgb_ValueChanged;
      scrollableH.OnValueChanged += hsl_ValueChanged;
      scrollableS.OnValueChanged += hsl_ValueChanged;
      scrollableL.OnValueChanged += hsl_ValueChanged;
      textBox.KeyDown += textBox_KeyPress;
      textBox.Leave += hex_ValueChanged;
      tableLayoutPanel.DragEnter += control_DragEnter;
      tableLayoutPanel.DragDrop += control_DragDrop;
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public string Hex {
      get => Enabled ? textBox.Text : "#FFFFFF";
      set => textBox.Text = value;
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Color Rgb {
      get => Enabled
        ? Color.FromArgb(scrollableR.numericValue, scrollableG.numericValue, scrollableB.numericValue)
        : Color.Empty;
      set {
        scrollableR.numericValue = value.R;
        scrollableG.numericValue = value.G;
        scrollableB.numericValue = value.B;
        Enabled = !value.IsEmpty;
      }
    }
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public (float h, float s, float l) Hsl {
      get => (scrollableH.numericValue, scrollableS.numericValue, scrollableL.numericValue);
      set {
        scrollableH.numericValue = (int)value.h;
        scrollableS.numericValue = (int)value.s;
        scrollableL.numericValue = (int)value.l;
      }
    }

    private void PaintTextBox(Color color) {
      textBox.BackColor = color;
      textBox.ForeColor = color.Reverse();
      OnColorChanged?.Invoke(Rgb);
    }
    private void rgb_ValueChanged(int value) {
      if (locked) return;
      locked = true;
      var color = Rgb;
      Hsl = color.ColorToHsl();
      Hex = color.ColorToHex();
      PaintTextBox(color);
      locked = false;
    }
    private void hsl_ValueChanged(int value) {
      if (locked) return;
      locked = true;
      var hsl = Hsl;
      var color = Rgb = hsl.HslToColor();
      Hex = color.ColorToHex();
      PaintTextBox(color);
      locked = false;
    }
    private void hex_ValueChanged(object sender, EventArgs e) {
      if (locked) return;
      locked = true;
      var hex = Hex;
      var color = Rgb = Conv.HexToColor(hex);
      Hsl = color.ColorToHsl();
      PaintTextBox(color);
      locked = false;
    }

    private void textBox_KeyPress(object sender, KeyEventArgs e) {
      if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return)) {
        SelectNextControl((Control)sender, true, true, true, true);
      }
    }

    private void control_DragEnter(object sender, DragEventArgs e) {
      e.Effect = e.Data.GetDataPresent(typeof(Color))
        ? DragDropEffects.Copy
        : DragDropEffects.None;
    }
    private void control_DragDrop(object sender, DragEventArgs e) {
      Rgb = (Color)e.Data.GetData(typeof(Color));
    }
  }
}