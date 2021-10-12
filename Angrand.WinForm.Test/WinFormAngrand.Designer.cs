
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
            this.buttonSetEmpty = new System.Windows.Forms.Button();
            this.presetPalettControl = new Angrand.GUI.PalettControl.PresetPalettControl();
            this.presetMatrixControl = new Angrand.GUI.PalettControl.PresetMatrixControl();
            this.SuspendLayout();
            // 
            // buttonSetEmpty
            // 
            this.buttonSetEmpty.Location = new System.Drawing.Point(42, 653);
            this.buttonSetEmpty.Name = "buttonSetEmpty";
            this.buttonSetEmpty.Size = new System.Drawing.Size(137, 34);
            this.buttonSetEmpty.TabIndex = 2;
            this.buttonSetEmpty.Text = "Set Empty";
            this.buttonSetEmpty.UseVisualStyleBackColor = true;
            this.buttonSetEmpty.Click += new System.EventHandler(this.buttonSetEmpty_Click);
            // 
            // presetPalettControl
            // 
            this.presetPalettControl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.presetPalettControl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presetPalettControl.ForeColor = System.Drawing.Color.DarkGray;
            this.presetPalettControl.Location = new System.Drawing.Point(0, 0);
            this.presetPalettControl.Margin = new System.Windows.Forms.Padding(0);
            this.presetPalettControl.Name = "presetPalettControl";
            this.presetPalettControl.Size = new System.Drawing.Size(224, 650);
            this.presetPalettControl.TabIndex = 0;
            // 
            // presetMatrixControl
            // 
            this.presetMatrixControl.BackColor = System.Drawing.SystemColors.Control;
            this.presetMatrixControl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presetMatrixControl.ForeColor = System.Drawing.Color.DarkGray;
            this.presetMatrixControl.Location = new System.Drawing.Point(224, 0);
            this.presetMatrixControl.Margin = new System.Windows.Forms.Padding(0);
            this.presetMatrixControl.Name = "presetMatrixControl";
            this.presetMatrixControl.Size = new System.Drawing.Size(480, 540);
            this.presetMatrixControl.TabIndex = 3;
            // 
            // WinFormAngrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 697);
            this.Controls.Add(this.presetMatrixControl);
            this.Controls.Add(this.buttonSetEmpty);
            this.Controls.Add(this.presetPalettControl);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WinFormAngrand";
            this.Text = "Angrand";
            this.Load += new System.EventHandler(this.WinFormAngrand_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PresetPalettControl presetPalettControl;
        private System.Windows.Forms.Button buttonSetEmpty;
        private PresetMatrixControl presetMatrixControl;
    }
}

