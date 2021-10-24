using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Palett;
using Veho;
using Veho.Matrix;

namespace Angrand.GUI.CardCollection {
  public partial class CardMatrice : UserControl {
    public event EventHandler OnClicked;
    public event MouseEventHandler OnMouseMoved;
    public event EventHandler OnMouseLeft;
    private Button[,] ButtonMatrice;

    public CardMatrice() {
      InitializeComponent();
      InitializeButtons();
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Button this[int x, int y] => ButtonMatrice[x, y];

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Color[,] ColorMatrix {
      get => ButtonMatrice.Map(button => button.BackColor);
      set => ButtonMatrice.IterZip(value, (i, j, button, color) => {
        button.BackColor = color;
        button.Name = $"button_{i:00}_{j:00}";
        button.Text = "";
      });
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public (string hex, string name)[,] MunsellMatrix {
      set => ButtonMatrice.IterZip(value, (button, kv) => {
        button.BackColor = Conv.HexToColor(kv.hex);
        button.Name = kv.name;
        button.Text = kv.name;
      });
    }

    private readonly Padding buttonPadding = new Padding(1, 0, 1, 0);
    public void InitializeButtons() {
      this.tableLayoutPanel.SuspendLayout();
      this.SuspendLayout();

      this.ButtonMatrice = (10, 10).Init((i, j) => {
        var button = new Button {
                                  BackColor = (360F - j * 20F, 68F, 96F - i * 8.5F).HslToColor(),
                                  ForeColor = Color.Transparent,
                                  TextAlign = ContentAlignment.MiddleCenter,
                                  Padding = buttonPadding,
                                  FlatAppearance = { BorderSize = 0 },
                                  FlatStyle = FlatStyle.Flat,
                                  Location = new Point(0, 0),
                                  Margin = new Padding(0),
                                  Name = $"button_{i:00}_{j:00}",
                                  Size = new Size(20, 20),
                                  Dock = DockStyle.Fill,
                                  TabIndex = i * 10 + j,
                                  UseVisualStyleBackColor = false
                                };
        button.MouseDown += this.button_MouseDown;
        button.MouseMove += this.OnMouseMoved;
        button.MouseLeave += this.OnMouseLeft;
        button.Click += this.OnClicked;
        this.tableLayoutPanel.Controls.Add(button, j, i);
        return button;
      });
      this.tableLayoutPanel.ResumeLayout(false);
      this.ResumeLayout(false);
    }


    private void button_MouseDown(object sender, MouseEventArgs e) {
      var button = sender as Button;
      button?.DoDragDrop(button.BackColor, DragDropEffects.Copy | DragDropEffects.Move);
    }
  }
}