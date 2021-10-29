using System.Drawing;
using System.Windows.Forms;

namespace Angrand.GUI.CardCollection {
  public static class ButtonUtil {
    private static readonly Padding buttonPadding = new Padding(1, 0, 1, 0);
    
    public static Button MakePixelButton() {
      var button = new Button {
                                ForeColor = Color.Transparent,
                                TextAlign = ContentAlignment.MiddleCenter,
                                Padding = buttonPadding,
                                FlatAppearance = { BorderSize = 0 },
                                FlatStyle = FlatStyle.Flat,
                                Location = new Point(0, 0),
                                Margin = new Padding(0),
                                Size = new Size(20, 20),
                                Dock = DockStyle.Fill,
                                // TabIndex = i * w + j,
                                UseVisualStyleBackColor = false,
                                AllowDrop = true
                              };
      return button;
    }
  }
}