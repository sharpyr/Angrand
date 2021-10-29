using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Angrand.GUI.PresetQueue {
  public partial class CardCollection : UserControl {
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Color CardColor { get; set; }

    public CardCollection() {
      InitializeComponent();
    }

    public event Action<Color> OnClicked;

    private void button_color_Click(object sender, EventArgs e) {
      OnClicked?.Invoke(CardColor = ((Button) sender).BackColor);
    }
  }
}