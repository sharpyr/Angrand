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
  public partial class SplitPalett : UserControl {
    public event EventHandler OnDoneClicked {
      add => presetMatrixControl.OnDoneClicked += value;
      remove => presetMatrixControl.OnDoneClicked -= value;
    }
    public event Action<Color> OnLeftColorChanged {
      add => this.presetMatrixControl.OnLeftColorChanged += value;
      remove => this.presetMatrixControl.OnLeftColorChanged -= value;
    }
    public event Action<Color> OnRightColorChanged {
      add => this.presetMatrixControl.OnRightColorChanged += value;
      remove => this.presetMatrixControl.OnRightColorChanged -= value;
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public List<CardPreset> CardPresetCollection = new List<CardPreset>();
    
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public ColorPair Preset {
      get => this.presetMatrixControl.Preset;
      set => this.presetMatrixControl.Preset = value;
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
      get => this.tableLayoutPanel.RowCount - 1;
      set {
        this.splitContainer.SuspendLayout();
        this.tableLayoutPanel.SuspendLayout();
        this.SuspendLayout();

        this.tableLayoutPanel.RowCount = value + 1;
        var unitPercent = 100F / Count;
        this.tableLayoutPanel.RowStyles.Clear();
        this.tableLayoutPanel.Controls.Clear();
        for (var i = 0; i < value; i++) {
          this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, unitPercent));
        }
        this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

        this.CardPresetCollection.Clear();
        this.CardPresetCollection.Capacity = value;
        for (var i = 0; i < value; i++) {
          var cardPreset = new CardPreset {
                                            AllowDrop = true,
                                            AutoSizeMode = AutoSizeMode.GrowAndShrink,
                                            Dock = DockStyle.Fill,
                                            // Margin = new Padding(0),
                                            Size = new Size(64, 16),
                                            Name = "cardPreset_" + i,
                                            TabIndex = i,
                                          };
          cardPreset.OnLabelDoubleClicked += this.cardPreset_DoubleClicked;
          this.CardPresetCollection.Add(cardPreset);
          this.tableLayoutPanel.Controls.Add(cardPreset, 0, i);
        }
        this.splitContainer.ResumeLayout(false);
        this.tableLayoutPanel.ResumeLayout(false);
        this.ResumeLayout(false);
      }
    }
    public SplitPalett() {
      InitializeComponent();
      this.presetMatrixControl.DragDrop += this.presetMatrixControl_DragDrop;
      this.presetMatrixControl.DragEnter += this.presetMatrixControl_DragEnter;
      // this.presetMatrixControl.MouseDown += this.presetMatrixControl_MouseDown;
      if (this.Count <= 0) this.Count = 20;
    }


    private void cardPreset_DoubleClicked(object sender, EventArgs e) {
      var cardPreset = (CardPreset)sender;
      this.presetMatrixControl.Preset = cardPreset.Preset;
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