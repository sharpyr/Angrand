using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Palett;
using Veho;
using Veho.Sequence;
using PalettPreset = Palett.Types.Preset;
using ColorPair = System.ValueTuple<System.Drawing.Color, System.Drawing.Color>;

namespace Angrand.GUI.CardCollection {
  public partial class CardPreset : UserControl {
    public event EventHandler OnLabelDoubleClicked;
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public int Count { get; set; } = 5;
    private readonly Label[] labelCollection;
    public CardPreset() {
      InitializeComponent();
      this.tableLayoutPanel.SuspendLayout();
      this.SuspendLayout();
      this.labelCollection = Vec.Init(Count, i => {
        var label = new Label {
                                BackColor = Color.FromArgb(50 + i * 50, 50 + i * 50, 50 + i * 50),
                                Dock = DockStyle.Fill,
                                FlatStyle = FlatStyle.Flat,
                                ForeColor = Color.Transparent,
                                BorderStyle = BorderStyle.None,
                                Location = new Point(1, 1),
                                Margin = new Padding(0),
                                Name = "label_" + i,
                                Size = new Size(24, 24),
                                TabIndex = i,
                              };
        label.MouseDown += this.label_MouseDown;
        label.DoubleClick += this.label_DoubleClicked;
        this.tableLayoutPanel.Controls.Add(label, i, 0);
        return label;
      });
      this.tableLayoutPanel.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    public Label LabelLeft => this.labelCollection.First();
    public Label LabelRight => this.labelCollection.Last();

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public ColorPair Preset {
      get => (this.LabelLeft.BackColor, this.LabelRight.BackColor);
      set {
        var (min, max) = value;
        var preset = PalettPreset.Build(min.ColorToHex(), max.ColorToHex());
        var projector = ProjectorFactory.Build((0, this.Count - 1), preset);
        var colorCollection = Vec.Init(this.Count, i => projector.Project(i).HslToColor());
        labelCollection.IterZip(colorCollection, (label, color) => label.BackColor = color);
      }
    }

    private void label_DoubleClicked(object sender, EventArgs e) {
      this.OnLabelDoubleClicked?.Invoke(this, e);
    }

    private void label_MouseDown(object sender, MouseEventArgs e) {
      if (e.Button == MouseButtons.Left && e.Clicks == 1) {
        var preset = (this.LabelLeft.BackColor, this.LabelRight.BackColor);
        this.DoDragDrop(preset, DragDropEffects.Copy | DragDropEffects.Move);
      }
    }

    private void CardPreset_DragEnter(object sender, DragEventArgs e) {
      e.Effect = e.Data.GetDataPresent(typeof(ColorPair)) ? DragDropEffects.Copy : DragDropEffects.None;
    }

    private void CardPreset_DragDrop(object sender, DragEventArgs e) {
      var control = (CardPreset)sender;
      var (min, max) = (ColorPair)e.Data.GetData(typeof(ColorPair));
      control.Preset = (min, max);
    }
  }
}