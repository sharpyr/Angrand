
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
            this.presetPalettControl = new Angrand.GUI.PalettControl.PresetPalettControl();
            this.matrixPalettControl1 = new Angrand.GUI.PalettControl.MatrixPalettControl();
            this.buttonSetEmpty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // presetPalettControl
            // 
            this.presetPalettControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.presetPalettControl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.presetPalettControl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presetPalettControl.ForeColor = System.Drawing.Color.DarkGray;
            this.presetPalettControl.Location = new System.Drawing.Point(0, 0);
            this.presetPalettControl.Margin = new System.Windows.Forms.Padding(0);
            this.presetPalettControl.Name = "presetPalettControl";
            this.presetPalettControl.Size = new System.Drawing.Size(224, 650);
            this.presetPalettControl.TabIndex = 0;
            // 
            // matrixPalettControl1
            // 
            this.matrixPalettControl1.BackColor = System.Drawing.SystemColors.Control;
            this.matrixPalettControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matrixPalettControl1.ForeColor = System.Drawing.Color.DarkGray;
            this.matrixPalettControl1.Location = new System.Drawing.Point(0, 704);
            this.matrixPalettControl1.Margin = new System.Windows.Forms.Padding(0);
            this.matrixPalettControl1.Name = "matrixPalettControl1";
            this.matrixPalettControl1.Size = new System.Drawing.Size(224, 272);
            this.matrixPalettControl1.TabIndex = 1;
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
            // WinFormAngrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 985);
            this.Controls.Add(this.buttonSetEmpty);
            this.Controls.Add(this.matrixPalettControl1);
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
        private MatrixPalettControl matrixPalettControl1;
        private System.Windows.Forms.Button buttonSetEmpty;
    }
}

