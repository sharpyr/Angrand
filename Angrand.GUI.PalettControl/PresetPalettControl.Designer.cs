﻿namespace Angrand.GUI.PalettControl
{
    partial class PresetPalettControl
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

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PresetPalettControl));
            this.tableLayoutPanelPresetPalettControl = new System.Windows.Forms.TableLayoutPanel();
            this.labelPalett = new System.Windows.Forms.Label();
            this.labelPresets = new System.Windows.Forms.Label();
            this.palettControl = new Angrand.GUI.PalettControl.PalettControl();
            this.presetQueue = new Angrand.GUI.PresetQueue.PresetQueue();
            this.tableLayoutPanelPresetPalettControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelPresetPalettControl
            // 
            this.tableLayoutPanelPresetPalettControl.ColumnCount = 1;
            this.tableLayoutPanelPresetPalettControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPresetPalettControl.Controls.Add(this.labelPalett, 0, 0);
            this.tableLayoutPanelPresetPalettControl.Controls.Add(this.palettControl, 0, 1);
            this.tableLayoutPanelPresetPalettControl.Controls.Add(this.labelPresets, 0, 2);
            this.tableLayoutPanelPresetPalettControl.Controls.Add(this.presetQueue, 0, 3);
            this.tableLayoutPanelPresetPalettControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPresetPalettControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tableLayoutPanelPresetPalettControl.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelPresetPalettControl.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelPresetPalettControl.Name = "tableLayoutPanelPresetPalettControl";
            this.tableLayoutPanelPresetPalettControl.RowCount = 5;
            this.tableLayoutPanelPresetPalettControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPresetPalettControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.tableLayoutPanelPresetPalettControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPresetPalettControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanelPresetPalettControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPresetPalettControl.Size = new System.Drawing.Size(240, 650);
            this.tableLayoutPanelPresetPalettControl.TabIndex = 1;
            // 
            // labelPalett
            // 
            this.labelPalett.AutoSize = true;
            this.labelPalett.ForeColor = System.Drawing.Color.Gray;
            this.labelPalett.Location = new System.Drawing.Point(3, 3);
            this.labelPalett.Margin = new System.Windows.Forms.Padding(3);
            this.labelPalett.Name = "labelPalett";
            this.labelPalett.Size = new System.Drawing.Size(78, 19);
            this.labelPalett.TabIndex = 2;
            this.labelPalett.Text = "Color cards";
            // 
            // labelPresets
            // 
            this.labelPresets.AutoSize = true;
            this.labelPresets.ForeColor = System.Drawing.Color.Gray;
            this.labelPresets.Location = new System.Drawing.Point(3, 544);
            this.labelPresets.Margin = new System.Windows.Forms.Padding(3);
            this.labelPresets.Name = "labelPresets";
            this.labelPresets.Size = new System.Drawing.Size(53, 19);
            this.labelPresets.TabIndex = 3;
            this.labelPresets.Text = "PresetCollection";
            // 
            // palettControl
            // 
            this.palettControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palettControl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.palettControl.Location = new System.Drawing.Point(0, 25);
            this.palettControl.Margin = new System.Windows.Forms.Padding(0);
            this.palettControl.Name = "palettControl";
            this.palettControl.Preset = ((System.ValueTuple<System.Drawing.Color, System.Drawing.Color>)(resources.GetObject("palettControl.Preset")));
            this.palettControl.Size = new System.Drawing.Size(240, 516);
            this.palettControl.TabIndex = 0;
            this.palettControl.Load += new System.EventHandler(this.palettControl_Load);
            // 
            // presetQueue
            // 
            this.presetQueue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.presetQueue.Location = new System.Drawing.Point(0, 566);
            this.presetQueue.Margin = new System.Windows.Forms.Padding(0);
            this.presetQueue.Name = "presetQueue";
            this.presetQueue.Size = new System.Drawing.Size(240, 84);
            this.presetQueue.TabIndex = 4;
            // 
            // PresetPalettControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.tableLayoutPanelPresetPalettControl);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PresetPalettControl";
            this.Size = new System.Drawing.Size(240, 650);
            this.tableLayoutPanelPresetPalettControl.ResumeLayout(false);
            this.tableLayoutPanelPresetPalettControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPresetPalettControl;
        private System.Windows.Forms.Label labelPalett;
        private PalettControl palettControl;
        private System.Windows.Forms.Label labelPresets;
        private PresetQueue.PresetQueue presetQueue;
    }
}
