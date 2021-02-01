
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
            this.palettControlMajor = new Angrand.GUI.PalettControl.PalettControl();
            this.presetButton1 = new Angrand.GUI.PresetQueue.PresetButton();
            this.SuspendLayout();
            // 
            // palettControlMajor
            // 
            this.palettControlMajor.ColorPair = ((System.ValueTuple<System.Drawing.Color, System.Drawing.Color>)(resources.GetObject("palettControlMajor.ColorPair")));
            this.palettControlMajor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.palettControlMajor.Location = new System.Drawing.Point(0, 0);
            this.palettControlMajor.Margin = new System.Windows.Forms.Padding(10);
            this.palettControlMajor.Name = "palettControlMajor";
            this.palettControlMajor.Size = new System.Drawing.Size(224, 507);
            this.palettControlMajor.TabIndex = 9;
            this.palettControlMajor.Load += new System.EventHandler(this.palettControlMajor_Load);
            // 
            // presetButton1
            // 
            this.presetButton1.Location = new System.Drawing.Point(37, 517);
            this.presetButton1.Margin = new System.Windows.Forms.Padding(0);
            this.presetButton1.Name = "presetButton1";
            this.presetButton1.Size = new System.Drawing.Size(150, 20);
            this.presetButton1.TabIndex = 10;
            // 
            // WinFormAngrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 577);
            this.Controls.Add(this.presetButton1);
            this.Controls.Add(this.palettControlMajor);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WinFormAngrand";
            this.Text = "Angrand";
            this.Load += new System.EventHandler(this.WinFormAngrand_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private GUI.PalettControl.PalettControl palettControlMajor;
        private GUI.PresetQueue.PresetButton presetButton1;
    }
}

