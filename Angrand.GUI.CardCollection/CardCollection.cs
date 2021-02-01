using System;
using System.Drawing;
using System.Windows.Forms;

namespace Angrand.GUI.CardCollection {
  public partial class CardCollection : UserControl {
    public Color CardColor { get; set; }

    public CardCollection() {
      InitializeComponent();
    }

    public event Action<Color> OnClicked;

    private void button_color_Click(object sender, EventArgs e) {
      OnClicked?.Invoke(this.CardColor = ((Button) sender).BackColor);
    }
  }
}