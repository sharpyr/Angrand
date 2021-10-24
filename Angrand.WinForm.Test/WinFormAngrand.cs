﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Angrand.PalettApp {
  public partial class WinFormAngrand : Form {
    public WinFormAngrand() {
      InitializeComponent();
      Console.WriteLine("----------------------------");
      // presetPalettControl.Preset = (Color.FromArgb(0, 204, 204), Color.FromArgb(153, 153, 255));
      presetPalettControl.Preset = (Color.Aqua, Color.Empty);
    }

    private void WinFormAngrand_Load(object sender, EventArgs e) {
      presetPalettControl.OnLeftUpdated += this.OnLeftUpdated;
      presetPalettControl.OnRightUpdated += this.OnRightUpdated;
      presetMatrixControl.Preset = (Color.Coral, Color.Goldenrod);
      presetMatrixControl.OnDoneClicked += this.OnDoneClicked;
      // splitPalett.Count = 20;
      splitPalett.OnDoneClicked += this.OnDoneClicked;
      splitPalett.Preset = (Color.Coral, Color.Goldenrod);
      splitPalett.OnLeftColorChanged += this.OnLeftUpdated;
      splitPalett.OnRightColorChanged += this.OnRightUpdated;
    }

    private void presetPalettControl_Load(object sender, EventArgs e) {
      // presetPalettControl.OnDoneClicked += this.Close;
      // presetPalettControl.Preset = (Color.FromArgb(0, 204, 204), Color.FromArgb(153, 153, 255));
    }

    private void OnLeftUpdated(Color color) {
      Console.WriteLine($"Left Color: {color}");
    }
    private void OnRightUpdated(Color color) {
      Console.WriteLine($"Right Color: {color}");
    }

    private void OnDoneClicked(object sender, EventArgs e) {
      this.Close();
    }

    private void buttonSetEmpty_Click(object sender, EventArgs e) {
      presetPalettControl.Preset = (Color.Empty, Color.Empty);
    }
  }
}