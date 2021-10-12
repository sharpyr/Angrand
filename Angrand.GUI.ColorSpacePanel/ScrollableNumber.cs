using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Angrand.GUI.ColorSpacePanel {
  public partial class ScrollableNumber : UserControl {
    private bool scrollEnabled = true;
    private bool numericEnabled = true;
    public event Action<int> OnValueChanged;
    public ScrollableNumber() {
      InitializeComponent();
    }
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public (int min, int max) Bound {
      get => (this.hScrollBar.Minimum, this.hScrollBar.Maximum);
      set {
        int min, max;
        if (value.min <= value.max) { (min, max) = value; }
        else { (max, min) = value; }
        this.hScrollBar.Minimum = min;
        this.hScrollBar.Maximum = max;
        this.numericUpDown.Minimum = min;
        this.numericUpDown.Maximum = max;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public string Label {
      get => this.label.Text;
      set => this.label.Text = value;
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public int numericValue {
      get => (int)this.numericUpDown.Value;
      set {
        this.numericEnabled = false;
        if (value < this.numericUpDown.Minimum) value = (int)this.numericUpDown.Minimum;
        if (value > this.numericUpDown.Maximum) value = (int)this.numericUpDown.Maximum;
        this.numericUpDown.Value = value;
        if (this.scrollEnabled) { this.hScrollBar.Value = value; }
        else { this.OnValueChanged?.Invoke(value); }
        this.numericEnabled = true;
      }
    }
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public int scrollValue {
      get => this.hScrollBar.Value;
      set {
        this.scrollEnabled = false;
        if (value < this.hScrollBar.Minimum) value = this.hScrollBar.Minimum;
        if (value > this.hScrollBar.Maximum) value = this.hScrollBar.Maximum;
        this.hScrollBar.Value = value;
        if (this.numericEnabled) { this.numericUpDown.Value = value; }
        else { this.OnValueChanged?.Invoke(value); }
        this.scrollEnabled = true;
      }
    }

    private void numericUpDown_ValueChanged(object sender, EventArgs e) {
      if (!this.numericEnabled) return;
      this.numericEnabled = false;
      this.scrollValue = this.numericValue;
      this.numericEnabled = true;
    }

    private void hScrollBar_ValueChanged(object sender, EventArgs e) {
      if (!this.scrollEnabled) return;
      this.scrollEnabled = false;
      this.numericValue = this.scrollValue;
      this.scrollEnabled = true;
    }
  }
}