using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Angrand.GUI.PresetQueue {
  public partial class PresetPalettControl : UserControl {
    public PresetPalettControl() {
      InitializeComponent();
      presetQueue.OnPresetClicked += PresetQueuePresetClicked;
      presetQueue.OnChevronClicked += PresetQueueChevronClicked;
    }
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public (Color min, Color max) Preset {
      get => palettControl.Preset;
      set => palettControl.Preset = value;
    }
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public (Color min, Color max)[] PresetCollection {
      get => presetQueue.Presets;
      set => presetQueue.Presets = value;
    }
    public event Action OnDoneClicked {
      add => palettControl.OnDoneClicked += value;
      remove => palettControl.OnDoneClicked -= value;
    }
    public event Action<Color> OnLeftUpdated {
      add => palettControl.OnLeftUpdated += value;
      remove => palettControl.OnLeftUpdated -= value;
    }
    public event Action<Color> OnRightUpdated {
      add => palettControl.OnRightUpdated += value;
      remove => palettControl.OnRightUpdated -= value;
    }
    private void PresetQueuePresetClicked((Color min, Color max) preset) => palettControl.Preset = preset;
    private void PresetQueueChevronClicked(int index) => presetQueue.SetColor(index, palettControl.Preset);
  }
}