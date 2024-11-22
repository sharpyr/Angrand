
using Angrand.GUI.ColorSpacePanel;
using Angrand.GUI.PalettControl;
using Angrand.GUI.PresetQueue;

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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.splitPalett = new Angrand.GUI.PalettControl.SplitPalett();
            this.splitPreset = new Angrand.GUI.PalettControl.SplitPreset();
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
            this.splitContainer.Margin = new System.Windows.Forms.Padding(10);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.splitPreset);
            this.splitContainer.Panel1.Margin = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.splitPalett);
            this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer.Size = new System.Drawing.Size(1006, 697);
            this.splitContainer.SplitterDistance = 335;
            this.splitContainer.TabIndex = 7;
            // 
            // splitPalett
            // 
            this.splitPalett.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.splitPalett.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPalett.Location = new System.Drawing.Point(10, 10);
            this.splitPalett.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.splitPalett.Name = "splitPalett";
            this.splitPalett.Size = new System.Drawing.Size(647, 677);
            this.splitPalett.TabIndex = 0;
            // 
            // splitPreset
            // 
            this.splitPreset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPreset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.splitPreset.Location = new System.Drawing.Point(0, 0);
            this.splitPreset.Margin = new System.Windows.Forms.Padding(0);
            this.splitPreset.Name = "splitPreset";
            this.splitPreset.Padding = new System.Windows.Forms.Padding(10);
            this.splitPreset.Size = new System.Drawing.Size(335, 697);
            this.splitPreset.TabIndex = 8;
            // 
            // WinFormAngrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 697);
            this.Controls.Add(this.splitContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WinFormAngrand";
            this.Text = "Angrand";
            this.Load += new System.EventHandler(this.WinFormAngrand_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private SplitPalett splitPalett;
        private SplitPreset splitPreset;
    }
}

