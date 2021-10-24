using System.ComponentModel;

namespace Angrand.GUI.ColorSpacePanel {
  partial class MatrixPanel {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.hScrollBarHueRange = new System.Windows.Forms.HScrollBar();
            this.vScrollBarLightness = new System.Windows.Forms.VScrollBar();
            this.vScrollBarSaturation = new System.Windows.Forms.VScrollBar();
            this.hScrollBarHue = new System.Windows.Forms.HScrollBar();
            this.cardMatrice = new Angrand.GUI.CardCollection.CardMatrice();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel.Controls.Add(this.hScrollBarHueRange, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.cardMatrice, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.vScrollBarLightness, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.vScrollBarSaturation, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.hScrollBarHue, 1, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(230, 220);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // hScrollBarHueRange
            // 
            this.hScrollBarHueRange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hScrollBarHueRange.Location = new System.Drawing.Point(25, 197);
            this.hScrollBarHueRange.Margin = new System.Windows.Forms.Padding(1);
            this.hScrollBarHueRange.Maximum = 369;
            this.hScrollBarHueRange.Name = "hScrollBarHueRange";
            this.hScrollBarHueRange.Size = new System.Drawing.Size(180, 22);
            this.hScrollBarHueRange.TabIndex = 4;
            // 
            // vScrollBarLightness
            // 
            this.vScrollBarLightness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vScrollBarLightness.Location = new System.Drawing.Point(1, 1);
            this.vScrollBarLightness.Margin = new System.Windows.Forms.Padding(1);
            this.vScrollBarLightness.Maximum = 109;
            this.vScrollBarLightness.Name = "vScrollBarLightness";
            this.vScrollBarLightness.Size = new System.Drawing.Size(22, 170);
            this.vScrollBarLightness.TabIndex = 1;
            // 
            // vScrollBarSaturation
            // 
            this.vScrollBarSaturation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vScrollBarSaturation.Location = new System.Drawing.Point(207, 1);
            this.vScrollBarSaturation.Margin = new System.Windows.Forms.Padding(1);
            this.vScrollBarSaturation.Maximum = 109;
            this.vScrollBarSaturation.Name = "vScrollBarSaturation";
            this.vScrollBarSaturation.Size = new System.Drawing.Size(22, 170);
            this.vScrollBarSaturation.TabIndex = 2;
            // 
            // hScrollBarHue
            // 
            this.hScrollBarHue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hScrollBarHue.Location = new System.Drawing.Point(25, 173);
            this.hScrollBarHue.Margin = new System.Windows.Forms.Padding(1);
            this.hScrollBarHue.Maximum = 369;
            this.hScrollBarHue.Name = "hScrollBarHue";
            this.hScrollBarHue.Size = new System.Drawing.Size(180, 22);
            this.hScrollBarHue.TabIndex = 3;
            // 
            // cardMatrice
            // 
            this.cardMatrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardMatrice.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.cardMatrice.Location = new System.Drawing.Point(25, 1);
            this.cardMatrice.Margin = new System.Windows.Forms.Padding(1);
            this.cardMatrice.Name = "cardMatrice";
            this.cardMatrice.Size = new System.Drawing.Size(180, 170);
            this.cardMatrice.TabIndex = 0;
            // 
            // MatrixPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "MatrixPanel";
            this.Size = new System.Drawing.Size(230, 220);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private CardCollection.CardMatrice cardMatrice;
        private System.Windows.Forms.VScrollBar vScrollBarLightness;
        private System.Windows.Forms.VScrollBar vScrollBarSaturation;
        private System.Windows.Forms.HScrollBar hScrollBarHue;
        private System.Windows.Forms.HScrollBar hScrollBarHueRange;
    }
}