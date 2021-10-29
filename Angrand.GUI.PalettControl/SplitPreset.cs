using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Angrand.GUI.CardCollection;
using Veho.Vector;
using static System.Math;
using ColorPair = System.ValueTuple<System.Drawing.Color, System.Drawing.Color>;

namespace Angrand.GUI.PalettControl {
  public partial class SplitPreset : UserControl {
    public event EventHandler OnDoneClicked {
      add => presetMatrixControl.OnDoneClicked += value;
      remove => presetMatrixControl.OnDoneClicked -= value;
    }
    public event Action<Color> OnLeftColorChanged {
      add => presetMatrixControl.OnLeftColorChanged += value;
      remove => presetMatrixControl.OnLeftColorChanged -= value;
    }
    public event Action<Color> OnRightColorChanged {
      add => presetMatrixControl.OnRightColorChanged += value;
      remove => presetMatrixControl.OnRightColorChanged -= value;
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public readonly List<PixelRow> CardPresetCollection = new List<PixelRow>();
    
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public ColorPair Preset {
      get => presetMatrixControl.Preset;
      set => presetMatrixControl.Preset = value;
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public ColorPair[] PresetCollection {
      get => CardPresetCollection.Map(x => x.Preset);
      set {
        for (int i = 0, hi = Min(CardPresetCollection.Count, value.Length); i < hi; i++)
          CardPresetCollection[i].Preset = value[i];
      }
    }
    
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public int Count {
      get => tableLayoutPanel.RowCount - 1;
      set {
        splitContainer.SuspendLayout();
        tableLayoutPanel.SuspendLayout();
        SuspendLayout();

        tableLayoutPanel.RowCount = value + 1;
        var unitPercent = 100F / Count;
        tableLayoutPanel.RowStyles.Clear();
        tableLayoutPanel.Controls.Clear();
        for (var i = 0; i < value; i++) {
          tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, unitPercent));
        }
        tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

        CardPresetCollection.Clear();
        CardPresetCollection.Capacity = value;
        for (var i = 0; i < value; i++) {
          var cardPreset = new PixelRow {
                                            AllowDrop = true,
                                            AutoSizeMode = AutoSizeMode.GrowAndShrink,
                                            Dock = DockStyle.Fill,
                                            // Margin = new Padding(0),
                                            Size = new Size(64, 16),
                                            Name = "cardPreset_" + i,
                                            TabIndex = i,
                                          };
          cardPreset.OnLabelDoubleClicked += cardPreset_DoubleClicked;
          CardPresetCollection.Add(cardPreset);
          tableLayoutPanel.Controls.Add(cardPreset, 0, i);
        }
        splitContainer.ResumeLayout(false);
        tableLayoutPanel.ResumeLayout(false);
        ResumeLayout(false);
      }
    }
    public SplitPreset() {
      InitializeComponent();
      presetMatrixControl.DragDrop += presetMatrixControl_DragDrop;
      presetMatrixControl.DragEnter += presetMatrixControl_DragEnter;
      // this.presetMatrixControl.MouseDown += this.presetMatrixControl_MouseDown;
      // presetMatrixControl.Munsel
      if (Count <= 0) Count = 20;
    }


    private void cardPreset_DoubleClicked(object sender, EventArgs e) {
      var cardPreset = (PixelRow)sender;
      presetMatrixControl.Preset = cardPreset.Preset;
    }

    // private void presetMatrixControl_MouseDown(object sender, MouseEventArgs e) {
    //   this.presetMatrixControl.DoDragDrop(this.presetMatrixControl.Preset, DragDropEffects.Copy | DragDropEffects.Move);
    // }

    private void presetMatrixControl_DragEnter(object sender, DragEventArgs e) {
      e.Effect = e.Data.GetDataPresent(typeof(ColorPair))
        ? DragDropEffects.Copy
        : DragDropEffects.None;
    }

    private void presetMatrixControl_DragDrop(object sender, DragEventArgs e) {
      var control = (PresetMatrixControl)sender;
      control.Preset = (ColorPair)e.Data.GetData(typeof(ColorPair));
    }
  }
}