using System.ComponentModel;

namespace Angrand.GUI.PalettControl {
  partial class SplitPalett {
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDone = new System.Windows.Forms.Button();
            this.pixelHolder = new System.Windows.Forms.TableLayoutPanel();
            this.scrollablePixelMatrix = new Angrand.GUI.CardCollection.ScrollablePixelMatrix();
            this.colorPanel = new Angrand.GUI.ColorSpacePanel.ScrollableColorPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.tableLayoutPanel);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.scrollablePixelMatrix);
            this.splitContainer.Size = new System.Drawing.Size(480, 360);
            this.splitContainer.SplitterDistance = 128;
            this.splitContainer.TabIndex = 0;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.buttonDone, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.colorPanel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.pixelHolder, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(128, 360);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // buttonDone
            // 
            this.buttonDone.AllowDrop = true;
            this.buttonDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDone.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.buttonDone.ForeColor = System.Drawing.Color.Gray;
            this.buttonDone.Location = new System.Drawing.Point(0, 324);
            this.buttonDone.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDone.MinimumSize = new System.Drawing.Size(0, 35);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(128, 36);
            this.buttonDone.TabIndex = 2;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            // 
            // pixelHolder
            // 
            this.pixelHolder.ColumnCount = 2;
            this.pixelHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pixelHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pixelHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pixelHolder.Location = new System.Drawing.Point(1, 175);
            this.pixelHolder.Margin = new System.Windows.Forms.Padding(1);
            this.pixelHolder.Name = "pixelHolder";
            this.pixelHolder.RowCount = 2;
            this.pixelHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pixelHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pixelHolder.Size = new System.Drawing.Size(126, 148);
            this.pixelHolder.TabIndex = 3;
            // 
            // scrollablePixelMatrix
            // 
            this.scrollablePixelMatrix.AutoSize = true;
            this.scrollablePixelMatrix.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scrollablePixelMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollablePixelMatrix.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.scrollablePixelMatrix.Location = new System.Drawing.Point(0, 0);
            this.scrollablePixelMatrix.Margin = new System.Windows.Forms.Padding(1);
            this.scrollablePixelMatrix.MinimumSize = new System.Drawing.Size(50, 50);
            this.scrollablePixelMatrix.Name = "scrollablePixelMatrix";
            this.scrollablePixelMatrix.Size = new System.Drawing.Size(348, 360);
            this.scrollablePixelMatrix.TabIndex = 0;
            // 
            // colorPanel
            // 
            this.colorPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.colorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorPanel.Location = new System.Drawing.Point(0, 1);
            this.colorPanel.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.colorPanel.MinimumSize = new System.Drawing.Size(48, 174);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(128, 174);
            this.colorPanel.TabIndex = 0;
            // 
            // SplitPalett
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.splitContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(480, 360);
            this.Name = "SplitPalett";
            this.Size = new System.Drawing.Size(480, 360);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private CardCollection.ScrollablePixelMatrix scrollablePixelMatrix;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private ColorSpacePanel.ScrollableColorPanel colorPanel;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.TableLayoutPanel pixelHolder;
    }
}