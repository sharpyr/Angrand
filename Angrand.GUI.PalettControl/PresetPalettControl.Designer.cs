namespace Angrand.GUI.PalettControl
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
            this.tableLayoutPanelPresetPalettControl = new System.Windows.Forms.TableLayoutPanel();
            this.labelPalett = new System.Windows.Forms.Label();
            this.labelPresets = new System.Windows.Forms.Label();
            this.presetQueue = new Angrand.GUI.PresetQueue.PresetQueue();
            this.palettControl = new Angrand.GUI.PalettControl.PalettControl();
            this.tableLayoutPanelPresetPalettControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelPresetPalettControl
            // 
            this.tableLayoutPanelPresetPalettControl.ColumnCount = 1;
            this.tableLayoutPanelPresetPalettControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPresetPalettControl.Controls.Add(this.labelPalett, 0, 0);
            this.tableLayoutPanelPresetPalettControl.Controls.Add(this.labelPresets, 0, 2);
            this.tableLayoutPanelPresetPalettControl.Controls.Add(this.presetQueue, 0, 3);
            this.tableLayoutPanelPresetPalettControl.Controls.Add(this.palettControl, 0, 1);
            this.tableLayoutPanelPresetPalettControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPresetPalettControl.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelPresetPalettControl.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelPresetPalettControl.Name = "tableLayoutPanelPresetPalettControl";
            this.tableLayoutPanelPresetPalettControl.RowCount = 5;
            this.tableLayoutPanelPresetPalettControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPresetPalettControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanelPresetPalettControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPresetPalettControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelPresetPalettControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPresetPalettControl.Size = new System.Drawing.Size(240, 650);
            this.tableLayoutPanelPresetPalettControl.TabIndex = 1;
            // 
            // labelPalett
            // 
            this.labelPalett.AutoSize = true;
            this.labelPalett.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPalett.ForeColor = System.Drawing.Color.Gray;
            this.labelPalett.Location = new System.Drawing.Point(0, 0);
            this.labelPalett.Margin = new System.Windows.Forms.Padding(0);
            this.labelPalett.Name = "labelPalett";
            this.labelPalett.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelPalett.Size = new System.Drawing.Size(240, 23);
            this.labelPalett.TabIndex = 2;
            this.labelPalett.Text = "Color cards";
            // 
            // labelPresets
            // 
            this.labelPresets.AutoSize = true;
            this.labelPresets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPresets.ForeColor = System.Drawing.Color.Gray;
            this.labelPresets.Location = new System.Drawing.Point(0, 536);
            this.labelPresets.Margin = new System.Windows.Forms.Padding(0);
            this.labelPresets.Name = "labelPresets";
            this.labelPresets.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelPresets.Size = new System.Drawing.Size(240, 23);
            this.labelPresets.TabIndex = 3;
            this.labelPresets.Text = "Preset Collection";
            // 
            // presetQueue
            // 
            this.presetQueue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.presetQueue.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presetQueue.Location = new System.Drawing.Point(0, 559);
            this.presetQueue.Margin = new System.Windows.Forms.Padding(0);
            this.presetQueue.Name = "presetQueue";
            this.presetQueue.Size = new System.Drawing.Size(240, 90);
            this.presetQueue.TabIndex = 4;
            // 
            // palettControl
            // 
            this.palettControl.BackColor = System.Drawing.SystemColors.Control;
            this.palettControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palettControl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.palettControl.ForeColor = System.Drawing.Color.DarkGray;
            this.palettControl.Location = new System.Drawing.Point(0, 23);
            this.palettControl.Margin = new System.Windows.Forms.Padding(0);
            this.palettControl.Name = "palettControl";
            this.palettControl.Size = new System.Drawing.Size(240, 513);
            this.palettControl.TabIndex = 5;
            // 
            // PresetPalettControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.tableLayoutPanelPresetPalettControl);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkGray;
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
        private System.Windows.Forms.Label labelPresets;
        private PresetQueue.PresetQueue presetQueue;
        private PalettControl palettControl;
    }
}
