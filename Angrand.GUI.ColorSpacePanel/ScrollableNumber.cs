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
      get => (hScrollBar.Minimum, hScrollBar.Maximum);
      set {
        int min, max;
        if (value.min <= value.max) { (min, max) = value; } else { (max, min) = value; }
        hScrollBar.Minimum = min;
        hScrollBar.Maximum = max;
        numericUpDown.Minimum = min;
        numericUpDown.Maximum = max;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public string Label {
      get => label.Text;
      set => label.Text = value;
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public int numericValue {
      get => (int) numericUpDown.Value;
      set {
        numericEnabled = false;
        if (value < numericUpDown.Minimum) value = (int) numericUpDown.Minimum;
        if (value > numericUpDown.Maximum) value = (int) numericUpDown.Maximum;
        numericUpDown.Value = value;
        if (scrollEnabled) { hScrollBar.Value = value; } else { OnValueChanged?.Invoke(value); }
        numericEnabled = true;
      }
    }
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public int scrollValue {
      get => hScrollBar.Value;
      set {
        scrollEnabled = false;
        if (value < hScrollBar.Minimum) value = hScrollBar.Minimum;
        if (value > hScrollBar.Maximum) value = hScrollBar.Maximum;
        hScrollBar.Value = value;
        if (numericEnabled) { numericUpDown.Value = value; } else { OnValueChanged?.Invoke(value); }
        scrollEnabled = true;
      }
    }

    private void numericUpDown_ValueChanged(object sender, EventArgs e) {
      if (!numericEnabled) return;
      numericEnabled = false;
      scrollValue = numericValue;
      numericEnabled = true;
    }

    private void hScrollBar_ValueChanged(object sender, EventArgs e) {
      if (!scrollEnabled) return;
      scrollEnabled = false;
      numericValue = scrollValue;
      scrollEnabled = true;
    }
  }
}