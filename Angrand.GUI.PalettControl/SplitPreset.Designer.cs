using System.ComponentModel;
using Angrand.GUI.ColorSpacePanel;

namespace Angrand.GUI.PalettControl {
  partial class SplitPreset {
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
            this.presetMatrixControl = new Angrand.GUI.PalettControl.PresetMatrixControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.tableLayoutPanel);
            this.splitContainer.Panel1MinSize = 48;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.presetMatrixControl);
            this.splitContainer.Panel2MinSize = 96;
            this.splitContainer.Size = new System.Drawing.Size(540, 480);
            this.splitContainer.SplitterDistance = 120;
            this.splitContainer.SplitterWidth = 5;
            this.splitContainer.TabIndex = 0;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AllowDrop = true;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.Size = new System.Drawing.Size(120, 480);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // presetMatrixControl
            // 
            this.presetMatrixControl.AllowDrop = true;
            this.presetMatrixControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.presetMatrixControl.BackColor = System.Drawing.SystemColors.Control;
            this.presetMatrixControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.presetMatrixControl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presetMatrixControl.ForeColor = System.Drawing.Color.DarkGray;
            this.presetMatrixControl.Location = new System.Drawing.Point(0, 0);
            this.presetMatrixControl.Margin = new System.Windows.Forms.Padding(0);
            this.presetMatrixControl.Name = "presetMatrixControl";
            this.presetMatrixControl.Size = new System.Drawing.Size(415, 480);
            this.presetMatrixControl.TabIndex = 0;
            // 
            // SplitPreset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SplitPreset";
            this.Size = new System.Drawing.Size(540, 480);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private PresetMatrixControl presetMatrixControl;
  }
}