
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
            this.labelColorCardCollection = new System.Windows.Forms.Label();
            this.labelColorControlPanel = new System.Windows.Forms.Label();
            this.labelAux = new System.Windows.Forms.Label();
            this._colorSpacePanel = new Angrand.UserControls.ColorControlPanel.ColorSpacePanel();
            this._colorCardCollection = new Angrand.UserControls.ColorCardCollection.ColorCardCollection();
            this.palettControl1 = new Angrand.UserControls.PalettControl.PalettControl();
            this.SuspendLayout();
            // 
            // labelColorCardCollection
            // 
            this.labelColorCardCollection.AutoSize = true;
            this.labelColorCardCollection.Location = new System.Drawing.Point(101, 218);
            this.labelColorCardCollection.Name = "labelColorCardCollection";
            this.labelColorCardCollection.Size = new System.Drawing.Size(164, 19);
            this.labelColorCardCollection.TabIndex = 2;
            this.labelColorCardCollection.Text = "Waiting for information ...";
            // 
            // labelColorControlPanel
            // 
            this.labelColorControlPanel.AutoSize = true;
            this.labelColorControlPanel.Location = new System.Drawing.Point(101, 9);
            this.labelColorControlPanel.Name = "labelColorControlPanel";
            this.labelColorControlPanel.Size = new System.Drawing.Size(164, 19);
            this.labelColorControlPanel.TabIndex = 5;
            this.labelColorControlPanel.Text = "Waiting for information ...";
            // 
            // labelAux
            // 
            this.labelAux.AutoSize = true;
            this.labelAux.Location = new System.Drawing.Point(101, 29);
            this.labelAux.Name = "labelAux";
            this.labelAux.Size = new System.Drawing.Size(164, 19);
            this.labelAux.TabIndex = 7;
            this.labelAux.Text = "Waiting for information ...";
            // 
            // _colorSpacePanel
            // 
            this._colorSpacePanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._colorSpacePanel.Hsl = ((System.ValueTuple<float, float, float>)(resources.GetObject("_colorSpacePanel.Hsl")));
            this._colorSpacePanel.Location = new System.Drawing.Point(105, 48);
            this._colorSpacePanel.Margin = new System.Windows.Forms.Padding(0);
            this._colorSpacePanel.Name = "_colorSpacePanel";
            this._colorSpacePanel.Rgb = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(150)))), ((int)(((byte)(236)))));
            this._colorSpacePanel.Size = new System.Drawing.Size(100, 160);
            this._colorSpacePanel.TabIndex = 6;
            // 
            // _colorCardCollection
            // 
            this._colorCardCollection.CardColor = System.Drawing.Color.Empty;
            this._colorCardCollection.Font = new System.Drawing.Font("Segoe UI", 7F);
            this._colorCardCollection.Location = new System.Drawing.Point(105, 237);
            this._colorCardCollection.Margin = new System.Windows.Forms.Padding(0);
            this._colorCardCollection.Name = "_colorCardCollection";
            this._colorCardCollection.Size = new System.Drawing.Size(100, 300);
            this._colorCardCollection.TabIndex = 3;
            this._colorCardCollection.Load += new System.EventHandler(this._colorCardCollection_Load);
            // 
            // palettControl1
            // 
            this.palettControl1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.palettControl1.Location = new System.Drawing.Point(300, 29);
            this.palettControl1.Margin = new System.Windows.Forms.Padding(2);
            this.palettControl1.Name = "palettControl1";
            this.palettControl1.Size = new System.Drawing.Size(300, 400);
            this.palettControl1.TabIndex = 8;
            // 
            // WinFormAngrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.palettControl1);
            this.Controls.Add(this.labelAux);
            this.Controls.Add(this._colorSpacePanel);
            this.Controls.Add(this.labelColorControlPanel);
            this.Controls.Add(this._colorCardCollection);
            this.Controls.Add(this.labelColorCardCollection);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WinFormAngrand";
            this.Text = "Angrand";
            this.Load += new System.EventHandler(this.WinFormAngrand_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelColorCardCollection;
        private UserControls.ColorCardCollection.ColorCardCollection _colorCardCollection;
        private System.Windows.Forms.Label labelColorControlPanel;
        private UserControls.ColorControlPanel.ColorSpacePanel _colorSpacePanel;
        private System.Windows.Forms.Label labelAux;
        private UserControls.PalettControl.PalettControl palettControl1;
    }
}

