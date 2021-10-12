using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Palett;
using Veho;
using Veho.Matrix;

namespace Angrand.GUI.CardCollection {
  public partial class CardMatrice : UserControl {
    private Button[,] ButtonMatrice;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Color CardColor { get; set; }

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
        var button = new Button();
        button.BackColor = (360F - j * 20F, 68F, 96F - i * 8.5F).HslToColor();
        button.ForeColor = Color.Transparent;
        button.TextAlign = ContentAlignment.MiddleCenter;
        button.Padding = buttonPadding;
        button.FlatAppearance.BorderSize = 0;
        button.FlatStyle = FlatStyle.Flat;
        button.Location = new Point(0, 0);
        button.Margin = new Padding(0);
        button.Name = $"button_{i:00}_{j:00}";
        button.Size = new Size(20, 20);
        button.Dock = DockStyle.Fill;
        button.TabIndex = i * 10 + j;
        button.UseVisualStyleBackColor = false;
        button.Click += this.button_Click;
        button.MouseDown += this.button_MouseDown;
        button.MouseMove += this.button_MouseMove;
        button.MouseLeave += this.button_MouseLeave;

        this.tableLayoutPanel.Controls.Add(button, j, i);
        return button;
      });
      this.tableLayoutPanel.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    public event Action<Color> OnClicked;
    public event Action<Button> OnMouseMoved;
    public event Action<Button> OnMouseLeft;

    private void button_Click(object sender, EventArgs e) {
      OnClicked?.Invoke(CardColor = ((Button)sender).BackColor);
    }

    private void button_MouseDown(object sender, MouseEventArgs e) {
      var button = sender as Button;
      button?.DoDragDrop(button.BackColor, DragDropEffects.Copy | DragDropEffects.Move);
    }
    private void button_MouseMove(object sender, MouseEventArgs e) {
      this.OnMouseMoved?.Invoke((Button)sender);
    }
    private void button_MouseLeave(object sender, EventArgs e) {
      this.OnMouseLeft?.Invoke((Button)sender);
    }
  }
}