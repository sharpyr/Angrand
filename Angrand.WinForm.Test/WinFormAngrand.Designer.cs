﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinFormAngrand));
            this.presetPalettControl1 = new Angrand.GUI.PalettControl.PresetPalettControl();
            this.matrixPalettControl1 = new Angrand.GUI.PalettControl.MatrixPalettControl();
            this.SuspendLayout();
            // 
            // presetPalettControl1
            // 
            this.presetPalettControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.presetPalettControl1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.presetPalettControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presetPalettControl1.ForeColor = System.Drawing.Color.DarkGray;
            this.presetPalettControl1.Location = new System.Drawing.Point(0, 0);
            this.presetPalettControl1.Margin = new System.Windows.Forms.Padding(0);
            this.presetPalettControl1.Name = "presetPalettControl1";
            this.presetPalettControl1.Preset = ((System.ValueTuple<System.Drawing.Color, System.Drawing.Color>)(resources.GetObject("presetPalettControl1.Preset")));
            this.presetPalettControl1.PresetCollection = new System.ValueTuple<System.Drawing.Color, System.Drawing.Color>[] {
        ((System.ValueTuple<System.Drawing.Color, System.Drawing.Color>)(resources.GetObject("presetPalettControl1.PresetCollection"))),
        ((System.ValueTuple<System.Drawing.Color, System.Drawing.Color>)(resources.GetObject("presetPalettControl1.PresetCollection1"))),
        ((System.ValueTuple<System.Drawing.Color, System.Drawing.Color>)(resources.GetObject("presetPalettControl1.PresetCollection2"))),
        ((System.ValueTuple<System.Drawing.Color, System.Drawing.Color>)(resources.GetObject("presetPalettControl1.PresetCollection3"))),
        ((System.ValueTuple<System.Drawing.Color, System.Drawing.Color>)(resources.GetObject("presetPalettControl1.PresetCollection4")))};
            this.presetPalettControl1.Size = new System.Drawing.Size(224, 650);
            this.presetPalettControl1.TabIndex = 0;
            // 
            // matrixPalettControl1
            // 
            this.matrixPalettControl1.BackColor = System.Drawing.SystemColors.Control;
            this.matrixPalettControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matrixPalettControl1.ForeColor = System.Drawing.Color.DarkGray;
            this.matrixPalettControl1.Location = new System.Drawing.Point(53, 676);
            this.matrixPalettControl1.Margin = new System.Windows.Forms.Padding(0);
            this.matrixPalettControl1.Name = "matrixPalettControl1";
            this.matrixPalettControl1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(211)))));
            this.matrixPalettControl1.Size = new System.Drawing.Size(120, 300);
            this.matrixPalettControl1.TabIndex = 1;
            // 
            // WinFormAngrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 985);
            this.Controls.Add(this.matrixPalettControl1);
            this.Controls.Add(this.presetPalettControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WinFormAngrand";
            this.Text = "Angrand";
            this.Load += new System.EventHandler(this.WinFormAngrand_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PresetPalettControl presetPalettControl1;
        private MatrixPalettControl matrixPalettControl1;
    }
}

