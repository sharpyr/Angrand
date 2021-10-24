
using Angrand.GUI.ColorSpacePanel;
using Angrand.GUI.PalettControl;

namespace Angrand.PalettApp
{
    partial class WinFormAngrand
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitPalett = new Angrand.GUI.PalettControl.SplitPalett();
            this.presetMatrixControl = new Angrand.GUI.PalettControl.PresetMatrixControl();
            this.presetPalettControl = new Angrand.GUI.PalettControl.PresetPalettControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.splitPalett, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.presetMatrixControl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.presetPalettControl, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1657, 697);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // splitPalett
            // 
            this.splitPalett.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPalett.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.splitPalett.Location = new System.Drawing.Point(764, 20);
            this.splitPalett.Margin = new System.Windows.Forms.Padding(10);
            this.splitPalett.Name = "splitPalett";
            this.splitPalett.Size = new System.Drawing.Size(873, 657);
            this.splitPalett.TabIndex = 5;
            // 
            // presetMatrixControl
            // 
            this.presetMatrixControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.presetMatrixControl.BackColor = System.Drawing.SystemColors.Control;
            this.presetMatrixControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.presetMatrixControl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presetMatrixControl.ForeColor = System.Drawing.Color.DarkGray;
            this.presetMatrixControl.Location = new System.Drawing.Point(264, 20);
            this.presetMatrixControl.Margin = new System.Windows.Forms.Padding(10);
            this.presetMatrixControl.Name = "presetMatrixControl";
            this.presetMatrixControl.Size = new System.Drawing.Size(480, 657);
            this.presetMatrixControl.TabIndex = 4;
            // 
            // presetPalettControl
            // 
            this.presetPalettControl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.presetPalettControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.presetPalettControl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presetPalettControl.ForeColor = System.Drawing.Color.DarkGray;
            this.presetPalettControl.Location = new System.Drawing.Point(20, 20);
            this.presetPalettControl.Margin = new System.Windows.Forms.Padding(10);
            this.presetPalettControl.Name = "presetPalettControl";
            this.presetPalettControl.Size = new System.Drawing.Size(224, 657);
            this.presetPalettControl.TabIndex = 1;
            // 
            // WinFormAngrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1657, 697);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WinFormAngrand";
            this.Text = "Angrand";
            this.Load += new System.EventHandler(this.WinFormAngrand_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private SplitPalett splitPalett;
        private PresetMatrixControl presetMatrixControl;
        private PresetPalettControl presetPalettControl;
    }
}

