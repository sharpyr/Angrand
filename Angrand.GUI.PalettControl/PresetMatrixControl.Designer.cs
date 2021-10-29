using Angrand.GUI.CardCollection;

namespace Angrand.GUI.PalettControl
{
    partial class PresetMatrixControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PresetMatrixControl));
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.colorPanelRight = new Angrand.GUI.ColorSpacePanel.ScrollableColorPanel();
            this.colorPanelLeft = new Angrand.GUI.ColorSpacePanel.ScrollableColorPanel();
            this.scrollablePixelMatrix = new Angrand.GUI.CardCollection.ScrollablePixelMatrix(  );
            this.buttonDone = new System.Windows.Forms.Button();
            this.tableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout
            // 
            this.tableLayout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayout.ColumnCount = 2;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.Controls.Add(this.colorPanelRight, 1, 0);
            this.tableLayout.Controls.Add(this.buttonDone, 0, 2);
            this.tableLayout.Controls.Add(this.colorPanelLeft, 0, 0);
            this.tableLayout.Controls.Add(this.scrollablePixelMatrix, 0, 1);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 4;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.Size = new System.Drawing.Size(450, 600);
            this.tableLayout.TabIndex = 0;
            // 
            // colorPanelRight
            // 
            this.colorPanelRight.AutoSize = true;
            this.colorPanelRight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.colorPanelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorPanelRight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.colorPanelRight.ForeColor = System.Drawing.Color.Black;
            this.colorPanelRight.Location = new System.Drawing.Point(225, 1);
            this.colorPanelRight.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.colorPanelRight.MinimumSize = new System.Drawing.Size(0, 175);
            this.colorPanelRight.Name = "colorPanelRight";
            this.colorPanelRight.Size = new System.Drawing.Size(225, 175);
            this.colorPanelRight.TabIndex = 11;
            // 
            // buttonDone
            // 
            this.buttonDone.AllowDrop = true;
            this.tableLayout.SetColumnSpan(this.buttonDone, 3);
            this.buttonDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDone.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone.ForeColor = System.Drawing.Color.Gray;
            this.buttonDone.Location = new System.Drawing.Point(0, 565);
            this.buttonDone.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(450, 35);
            this.buttonDone.TabIndex = 0;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            // 
            // colorPanelLeft
            // 
            this.colorPanelLeft.AutoSize = true;
            this.colorPanelLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.colorPanelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorPanelLeft.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.colorPanelLeft.ForeColor = System.Drawing.Color.Black;
            this.colorPanelLeft.Location = new System.Drawing.Point(0, 1);
            this.colorPanelLeft.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.colorPanelLeft.MinimumSize = new System.Drawing.Size(0, 175);
            this.colorPanelLeft.Name = "colorPanelLeft";
            this.colorPanelLeft.Size = new System.Drawing.Size(225, 175);
            this.colorPanelLeft.TabIndex = 10;
            // 
            // scrollablePixelMatrix
            // 
            this.scrollablePixelMatrix.AutoSize = true;
            this.tableLayout.SetColumnSpan(this.scrollablePixelMatrix, 2);
            this.scrollablePixelMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollablePixelMatrix.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.scrollablePixelMatrix.Location = new System.Drawing.Point(1, 178);
            this.scrollablePixelMatrix.Margin = new System.Windows.Forms.Padding(1);
            this.scrollablePixelMatrix.Name = "scrollablePixelMatrix";
            this.scrollablePixelMatrix.Size = new System.Drawing.Size(448, 386);
            this.scrollablePixelMatrix.TabIndex = 14;
            // 
            // PresetMatrixControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tableLayout);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PresetMatrixControl";
            this.Size = new System.Drawing.Size(450, 600);
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.Button buttonDone;
        private ColorSpacePanel.ScrollableColorPanel colorPanelRight;
        private ColorSpacePanel.ScrollableColorPanel colorPanelLeft;
        private ScrollablePixelMatrix scrollablePixelMatrix;
    }
}
