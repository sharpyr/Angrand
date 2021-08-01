using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Veho.Vector;

namespace Angrand.GUI.PresetQueue {
  public partial class PresetQueue : UserControl {
    public PresetQueue() {
      InitializeComponent();
      // this.Presets = Utils.PresetCollection;
    }
    public int Count => this.tableLayoutPanelPresetQueue.RowCount - 1;
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public (Color min, Color max)[] Presets {
      get => Inits.Init(this.Count, this.GetColor);
      set => value.Iterate(this.SetColor);
    }

    public event Action<(Color min, Color max)> OnPresetClicked;
    public event Action<int> OnChevronClicked;
    public (Button left, Button right) this[int index] {
      get {
        index %= this.Count;
        var left = (Button) tableLayoutPanelPresetQueue.GetControlFromPosition(1, index);
        var right = (Button) tableLayoutPanelPresetQueue.GetControlFromPosition(2, index);
        return (left, right);
      }
    }
    public (Color min, Color max) GetColor(int index) {
      var (left, right) = this[index];
      return (left.BackColor, right.BackColor);
    }
    public void SetColor(int index, (Color min, Color max) preset) {
      var (left, right) = this[index];
      left.BackColor = preset.min;
      right.BackColor = preset.max;
    }
    public void PushColor((Color min, Color max) preset) {
      var hi = this.Count - 1;
      for (var i = 0; i < hi;) this.SetColor(i, this.GetColor(++i));
      this.SetColor(hi, preset);
    }
    private void OnButtonPreset_Click(object sender, EventArgs e) {
      var index = tableLayoutPanelPresetQueue.GetRow((Control) sender);
      this.OnPresetClicked?.Invoke(this.GetColor(index));
    }
    private void OnButtonChevron_Click(object sender, EventArgs e) {
      var index = this.tableLayoutPanelPresetQueue.GetRow((Control) sender);
      this.OnChevronClicked?.Invoke(index);
    }
  }
}