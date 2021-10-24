using System.ComponentModel;

namespace Angrand.GUI.ColorSpacePanel {
  partial class ScrollableColorPanel {
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.scrollableL = new Angrand.GUI.ColorSpacePanel.ScrollableNumber();
            this.scrollableS = new Angrand.GUI.ColorSpacePanel.ScrollableNumber();
            this.scrollableH = new Angrand.GUI.ColorSpacePanel.ScrollableNumber();
            this.scrollableB = new Angrand.GUI.ColorSpacePanel.ScrollableNumber();
            this.scrollableG = new Angrand.GUI.ColorSpacePanel.ScrollableNumber();
            this.scrollableR = new Angrand.GUI.ColorSpacePanel.ScrollableNumber();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AllowDrop = true;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.scrollableL, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.scrollableS, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.scrollableH, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.scrollableB, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.scrollableG, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.scrollableR, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.textBox, 0, 6);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.tableLayoutPanel.RowCount = 8;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(130, 174);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Location = new System.Drawing.Point(0, 148);
            this.textBox.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.textBox.Name = "textBox";
            this.textBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox.Size = new System.Drawing.Size(130, 25);
            this.textBox.TabIndex = 6;
            this.textBox.Text = "#FFFFFF";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // scrollableL
            // 
            this.scrollableL.AutoSize = true;
            this.scrollableL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scrollableL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollableL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.scrollableL.Location = new System.Drawing.Point(1, 122);
            this.scrollableL.Margin = new System.Windows.Forms.Padding(1);
            this.scrollableL.Name = "scrollableL";
            this.scrollableL.Size = new System.Drawing.Size(128, 22);
            this.scrollableL.TabIndex = 5;
            // 
            // scrollableS
            // 
            this.scrollableS.AutoSize = true;
            this.scrollableS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scrollableS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollableS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.scrollableS.Location = new System.Drawing.Point(1, 98);
            this.scrollableS.Margin = new System.Windows.Forms.Padding(1);
            this.scrollableS.Name = "scrollableS";
            this.scrollableS.Size = new System.Drawing.Size(128, 22);
            this.scrollableS.TabIndex = 4;
            // 
            // scrollableH
            // 
            this.scrollableH.AutoSize = true;
            this.scrollableH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scrollableH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollableH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.scrollableH.Location = new System.Drawing.Point(1, 74);
            this.scrollableH.Margin = new System.Windows.Forms.Padding(1);
            this.scrollableH.Name = "scrollableH";
            this.scrollableH.Size = new System.Drawing.Size(128, 22);
            this.scrollableH.TabIndex = 3;
            // 
            // scrollableB
            // 
            this.scrollableB.AutoSize = true;
            this.scrollableB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scrollableB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollableB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.scrollableB.Location = new System.Drawing.Point(1, 50);
            this.scrollableB.Margin = new System.Windows.Forms.Padding(1);
            this.scrollableB.Name = "scrollableB";
            this.scrollableB.Size = new System.Drawing.Size(128, 22);
            this.scrollableB.TabIndex = 2;
            // 
            // scrollableG
            // 
            this.scrollableG.AutoSize = true;
            this.scrollableG.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scrollableG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollableG.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.scrollableG.Location = new System.Drawing.Point(1, 26);
            this.scrollableG.Margin = new System.Windows.Forms.Padding(1);
            this.scrollableG.Name = "scrollableG";
            this.scrollableG.Size = new System.Drawing.Size(128, 22);
            this.scrollableG.TabIndex = 1;
            // 
            // scrollableR
            // 
            this.scrollableR.AutoSize = true;
            this.scrollableR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scrollableR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollableR.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.scrollableR.Location = new System.Drawing.Point(1, 2);
            this.scrollableR.Margin = new System.Windows.Forms.Padding(1);
            this.scrollableR.Name = "scrollableR";
            this.scrollableR.Size = new System.Drawing.Size(128, 22);
            this.scrollableR.TabIndex = 0;
            // 
            // ScrollableColorPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(48, 174);
            this.Name = "ScrollableColorPanel";
            this.Size = new System.Drawing.Size(130, 174);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private ScrollableNumber scrollableR;
        private ScrollableNumber scrollableL;
        private ScrollableNumber scrollableS;
        private ScrollableNumber scrollableH;
        private ScrollableNumber scrollableB;
        private ScrollableNumber scrollableG;
        private System.Windows.Forms.TextBox textBox;
    }
}