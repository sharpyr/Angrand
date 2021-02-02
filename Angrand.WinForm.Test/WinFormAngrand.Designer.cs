
using Angrand.GUI.ColorSpacePanel;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinFormAngrand));
            this.presetPalettControl = new Angrand.GUI.PalettControl.PresetPalettControl();
            this.SuspendLayout();
            // 
            // presetPalettControl
            // 
            this.presetPalettControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.presetPalettControl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.presetPalettControl.Location = new System.Drawing.Point(0, 0);
            this.presetPalettControl.Margin = new System.Windows.Forms.Padding(0);
            this.presetPalettControl.Name = "presetPalettControl";
            this.presetPalettControl.Preset = ((System.ValueTuple<System.Drawing.Color, System.Drawing.Color>)(resources.GetObject("presetPalettControl.Preset")));
            this.presetPalettControl.Size = new System.Drawing.Size(224, 719);
            this.presetPalettControl.TabIndex = 0;
            this.presetPalettControl.Load += new System.EventHandler(this.presetPalettControl_Load);
            // 
            // WinFormAngrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 719);
            this.Controls.Add(this.presetPalettControl);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WinFormAngrand";
            this.Text = "Angrand";
            this.Load += new System.EventHandler(this.WinFormAngrand_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private GUI.PalettControl.PresetPalettControl presetPalettControl;
    }
}

