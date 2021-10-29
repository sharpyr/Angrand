using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Palett;
using Palett.Types;
using Veho;
using Veho.Matrix;

namespace Angrand.GUI.CardCollection {
  public partial class PixelMatrix : UserControl {
    public event MouseEventHandler OnMouseMoved;
    public event EventHandler OnMouseLeft;
    public event EventHandler OnDoubleClicked;
    private Button[,] matrix;
    private readonly TableLayoutPanel tableLayoutPanel;
    public bool MunsellMode { get; set; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public (int h, int w) MatrixSize {
      get => this.matrix.Size();
      set => this.InitializeButtons(value.h, value.w);
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Button this[int x, int y] => matrix[x, y];

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Color[,] ColorMatrix {
      get => matrix.Map(button => button.BackColor);
      set {
        if (MunsellMode) {
          matrix.IterZip(value, (i, j, button, color) => {
            var (hex, name) = color.ColorToHsl().Nearest();
            button.BackColor = Conv.HexToColor(hex);
            button.Text = name;
          });
        }
        else {
          matrix.IterZip(value, (i, j, button, color) => {
            button.BackColor = color;
            button.Text = "";
          });
        }
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public (float, float, float)[,] HSLMatrix {
      get => matrix.Map(button => button.BackColor.ColorToHsl());
      set {
        if (MunsellMode) {
          matrix.IterZip(value, (i, j, button, color) => {
            var (hex, name) = color.Nearest();
            button.BackColor = Conv.HexToColor(hex);
            button.Text = name;
          });
        }
        else {
          matrix.IterZip(value, (i, j, button, color) => {
            button.BackColor = color.HslToColor();
            button.Text = "";
          });
        }
      }
    }

    public PixelMatrix() {
      InitializeComponent();
      this.tableLayoutPanel = new TableLayoutPanel {
                                                     Dock = DockStyle.Fill,
                                                     Font = new Font("Segoe UI", 7F),
                                                     Location = new Point(0, 0),
                                                     Margin = new Padding(0),
                                                     BackColor = DefaultBackColor,
                                                     Name = "tableLayoutPanel",
                                                     TabIndex = 0
                                                   };
      this.Controls.Add(this.tableLayoutPanel);
      this.MunsellMode = true;
    }

    public void InitializeButtons(int h, int w) {
      tableLayoutPanel.SuspendLayout();
      SuspendLayout();
      tableLayoutPanel.InitGrid(h, w);
      var gradientCrostab = Munsell.GradientCrostab(((0, 50, 95), (240, 60, 15)), HSLAttr.L, HSLAttr.H, h, w);
      this.matrix = (h, w).Init((i, j) => {
        var button = ButtonUtil.MakePixelButton();
        button.BackColor = gradientCrostab[i, j].HslToColor();
        button.Name = $"button_{i:00}_{j:00}";
        button.TabIndex = i * w + j;
        button.MouseDown += button_MouseDown;
        button.MouseMove += OnMouseMoved;
        button.MouseLeave += OnMouseLeft;
        return button;
      });
      this.tableLayoutPanel.AssignControls(this.matrix);
      tableLayoutPanel.ResumeLayout(false);
      ResumeLayout(false);
    }

    private void button_MouseDown(object sender, MouseEventArgs e) {
      if (e.Button == MouseButtons.Left && e.Clicks == 1) {
        var button = sender as Button;
        button?.DoDragDrop(button.BackColor, DragDropEffects.Copy | DragDropEffects.Move);
      }
      if (e.Button == MouseButtons.Left && e.Clicks == 2) {
        this.OnDoubleClicked?.Invoke(sender, e);
      }
    }
  }
}