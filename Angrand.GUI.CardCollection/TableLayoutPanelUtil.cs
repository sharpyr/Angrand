using System.Windows.Forms;
using Veho;
using Veho.Matrix;
using static System.Math;

namespace Angrand.GUI.CardCollection {
  public static class TableLayoutPanelUtil {
    public static TableLayoutPanel InitGrid(this TableLayoutPanel tableLayoutPanel, int h, int w) {
      tableLayoutPanel.ColumnStyles.Clear();
      tableLayoutPanel.RowStyles.Clear();
      var (dh, dw) = (100F / h, 100F / w);
      tableLayoutPanel.ColumnCount = w + 1;
      tableLayoutPanel.RowCount = h + 1;
      for (var j = 0; j < w; j++) tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, dw));
      for (var i = 0; i < h; i++) tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, dh));
      tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
      tableLayoutPanel.RowStyles.Add(new RowStyle());
      return tableLayoutPanel;
    }
    public static TableLayoutPanel AssignControls(this TableLayoutPanel tableLayoutPanel, Button[,] ButtonMatrix) {
      tableLayoutPanel.Controls.Clear();
      var (h, w) = (Min(tableLayoutPanel.RowCount, ButtonMatrix.Height()), Min(tableLayoutPanel.ColumnCount, ButtonMatrix.Width()));
      (h, w).Iter((i, j) => {
        tableLayoutPanel.Controls.Add(ButtonMatrix[i, j], j, i);
      });
      return tableLayoutPanel;
    }
  }
}