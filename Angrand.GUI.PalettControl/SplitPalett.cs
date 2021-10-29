using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Angrand.GUI.CardCollection;
using Palett;
using Palett.Types;
using Veho;
using Veho.Matrix;

namespace Angrand.GUI.PalettControl {
  public partial class SplitPalett : UserControl {
    private Button[,] matrix;
    public event EventHandler OnDoneClicked {
      add => buttonDone.Click += value;
      remove => buttonDone.Click -= value;
    }
    public event Action<Color> OnColorChanged {
      add => colorPanel.OnColorChanged += value;
      remove => colorPanel.OnColorChanged -= value;
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Color Color {
      get => this.colorPanel.Rgb;
      set => this.colorPanel.Rgb = value;
    }

    public SplitPalett() {
      InitializeComponent();
      this.MatrixSize = (12, 5);
      colorPanel.OnTextBoxMouseDown += this.button_MouseDown;
      scrollablePixelMatrix.OnDoubleClicked += this.button_DoubleClicked;
      scrollablePixelMatrix.InitializeParameters(0, 75, 120, 180, true);
    }

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
      set => matrix.IterZip(value, (button, color) => button.BackColor = color);
    }

    public void InitializeButtons(int h, int w) {
      pixelHolder.SuspendLayout();
      SuspendLayout();
      pixelHolder.InitGrid(h, w);
      var gradientCrostab = Munsell.GradientCrostab(((0, 50, 95), (240, 60, 15)), HSLAttr.L, HSLAttr.H, h, w);
      this.matrix = (h, w).Init((i, j) => {
        var button = ButtonUtil.MakePixelButton();
        button.BackColor = gradientCrostab[i, j].HslToColor();
        button.Name = $"button_{i:00}_{j:00}";
        button.Text = "";
        button.TabIndex = i * w + j;
        button.MouseDown += button_MouseDown;
        button.DragEnter += button_DragEnter;
        button.DragDrop += button_DragDrop;
        return button;
      });
      this.pixelHolder.AssignControls(this.matrix);
      pixelHolder.ResumeLayout(false);
      ResumeLayout(false);
    }

    private void button_DoubleClicked(object sender, EventArgs e) {
      var button = (Control)sender;
      // Console.WriteLine($">> [double clicked] {button.BackColor}");
      this.colorPanel.Rgb = button.BackColor;
    }

    private void button_MouseDown(object sender, MouseEventArgs e) {
      if (e.Button != MouseButtons.Left) return;
      switch (e.Clicks) {
        case 1: {
          DoDragDrop(((Control)sender)?.BackColor ?? Color.Transparent, DragDropEffects.Copy | DragDropEffects.Move);
          return;
        }
        case 2:
          this.button_DoubleClicked(sender, e);
          return;
      }
    }

    private void button_DragEnter(object sender, DragEventArgs e) {
      e.Effect = e.Data.GetDataPresent(typeof(Color)) ? DragDropEffects.Copy : DragDropEffects.None;
    }

    private void button_DragDrop(object sender, DragEventArgs e) {
      var button = (Button)sender;
      button.BackColor = (Color)e.Data.GetData(typeof(Color));
    }
  }
}