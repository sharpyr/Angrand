﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Angrand.GUI.PalettControl {
  public partial class PresetPalettControl : UserControl {
    public PresetPalettControl() {
      InitializeComponent();
      presetQueue.OnPresetClicked += this.PresetQueuePresetClicked;
      presetQueue.OnChevronClicked += this.PresetQueueChevronClicked;
    }
    public (Color min, Color max) Preset {
      get => palettControl.Preset;
      set => palettControl.Preset = value;
    }
    public (Color min, Color max)[] PresetCollection {
      get => presetQueue.Presets;
      set => presetQueue.Presets = value;
    }
    public event Action OnDoneClicked {
      add => palettControl.OnDoneClicked += value;
      remove => palettControl.OnDoneClicked -= value;
    }
    private void PresetQueuePresetClicked((Color min, Color max) preset) => palettControl.Preset = preset;
    private void PresetQueueChevronClicked(int index) => presetQueue.SetColor(index, this.palettControl.Preset);
  }
}