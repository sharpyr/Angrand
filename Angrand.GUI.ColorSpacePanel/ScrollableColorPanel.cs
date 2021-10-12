using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Palett;

namespace Angrand.GUI.ColorSpacePanel {
  public partial class ScrollableColorPanel : UserControl {
    private bool locked = false;
    public event Action<Color> OnColorChanged;

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
      this.scrollableR.OnValueChanged += this.rgb_ValueChanged;
      this.scrollableG.OnValueChanged += this.rgb_ValueChanged;
      this.scrollableB.OnValueChanged += this.rgb_ValueChanged;
      this.scrollableH.OnValueChanged += this.hsl_ValueChanged;
      this.scrollableS.OnValueChanged += this.hsl_ValueChanged;
      this.scrollableL.OnValueChanged += this.hsl_ValueChanged;
      this.textBox.KeyDown += this.textBox_KeyPress;
      this.textBox.Leave += this.hex_ValueChanged;
      this.tableLayoutPanel.DragEnter += this.control_DragEnter;
      this.tableLayoutPanel.DragDrop += this.control_DragDrop;
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public string Hex {
      get => this.Enabled ? this.textBox.Text : "#FFFFFF";
      set => this.textBox.Text = value;
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Color Rgb {
      get => this.Enabled
        ? Color.FromArgb(scrollableR.numericValue, scrollableG.numericValue, scrollableB.numericValue)
        : Color.Empty;
      set {
        this.scrollableR.numericValue = value.R;
        this.scrollableG.numericValue = value.G;
        this.scrollableB.numericValue = value.B;
        this.Enabled = !value.IsEmpty;
      }
    }
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public (float h, float s, float l) Hsl {
      get => (scrollableH.numericValue, scrollableS.numericValue, scrollableL.numericValue);
      set {
        this.scrollableH.numericValue = (int)value.h;
        this.scrollableS.numericValue = (int)value.s;
        this.scrollableL.numericValue = (int)value.l;
      }
    }

    private void PaintTextBox(Color color) {
      this.textBox.BackColor = color;
      this.textBox.ForeColor = color.Reverse();
    }
    private void rgb_ValueChanged(int value) {
      if (this.locked) return;
      this.locked = true;
      var color = this.Rgb;
      this.Hsl = color.ColorToHsl();
      this.Hex = color.ColorToHex();
      this.locked = false;
      this.PaintTextBox(color);
      this.OnColorChanged?.Invoke(color);
    }
    private void hsl_ValueChanged(int value) {
      if (this.locked) return;
      this.locked = true;
      var hsl = this.Hsl;
      var color = this.Rgb = hsl.HslToColor();
      this.Hex = color.ColorToHex();
      this.locked = false;
      this.PaintTextBox(color);
      this.OnColorChanged?.Invoke(color);
    }
    private void hex_ValueChanged(object sender, EventArgs e) {
      if (this.locked) return;
      this.locked = true;
      var hex = this.Hex;
      var color = this.Rgb = Conv.HexToColor(hex);
      this.Hsl = color.ColorToHsl();
      this.locked = false;
      this.PaintTextBox(color);
      this.OnColorChanged?.Invoke(color);
    }

    private void textBox_KeyPress(object sender, KeyEventArgs e) {
      if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return)) {
        this.SelectNextControl((Control)sender, true, true, true, true);
      }
    }

    private void control_DragEnter(object sender, DragEventArgs e) {
      e.Effect = e.Data.GetDataPresent("System.Drawing.Color")
        ? DragDropEffects.Copy
        : DragDropEffects.None;
    }
    private void control_DragDrop(object sender, DragEventArgs e) {
      this.Rgb = (Color)e.Data.GetData(typeof(Color));
    }
  }
}