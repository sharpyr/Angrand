namespace Angrand.GUI.PresetQueue
{
    partial class MatrixPalettControl
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
            this.tableLayoutPanelMatrixPalettControl = new System.Windows.Forms.TableLayoutPanel();
            this.vScrollBar = new System.Windows.Forms.VScrollBar();
            this.buttonBlock = new System.Windows.Forms.Button();
            this.colorSpacePanel = new ColorSpacePanel();
            this.buttonDone = new System.Windows.Forms.Button();
            this.cardMatrix = new CardMatrix();
            this.tableLayoutPanelMatrixPalettControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMatrixPalettControl
            // 
            this.tableLayoutPanelMatrixPalettControl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanelMatrixPalettControl.ColumnCount = 3;
            this.tableLayoutPanelMatrixPalettControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelMatrixPalettControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMatrixPalettControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMatrixPalettControl.Controls.Add(this.vScrollBar, 2, 1);
            this.tableLayoutPanelMatrixPalettControl.Controls.Add(this.buttonBlock, 1, 0);
            this.tableLayoutPanelMatrixPalettControl.Controls.Add(this.colorSpacePanel, 0, 0);
            this.tableLayoutPanelMatrixPalettControl.Controls.Add(this.buttonDone, 0, 2);
            this.tableLayoutPanelMatrixPalettControl.Controls.Add(this.cardMatrix, 0, 1);
            this.tableLayoutPanelMatrixPalettControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMatrixPalettControl.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMatrixPalettControl.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelMatrixPalettControl.Name = "tableLayoutPanelMatrixPalettControl";
            this.tableLayoutPanelMatrixPalettControl.RowCount = 3;
            this.tableLayoutPanelMatrixPalettControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMatrixPalettControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMatrixPalettControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMatrixPalettControl.Size = new System.Drawing.Size(140, 320);
            this.tableLayoutPanelMatrixPalettControl.TabIndex = 0;
            // 
            // vScrollBar
            // 
            this.vScrollBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vScrollBar.Location = new System.Drawing.Point(112, 145);
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.Size = new System.Drawing.Size(28, 147);
            this.vScrollBar.TabIndex = 8;
            this.vScrollBar.Value = 50;
            this.vScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar_Scroll);
            // 
            // buttonBlock
            // 
            this.tableLayoutPanelMatrixPalettControl.SetColumnSpan(this.buttonBlock, 2);
            this.buttonBlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBlock.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonBlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBlock.ForeColor = System.Drawing.Color.Gray;
            this.buttonBlock.Location = new System.Drawing.Point(84, 0);
            this.buttonBlock.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBlock.Name = "buttonBlock";
            this.buttonBlock.Size = new System.Drawing.Size(56, 145);
            this.buttonBlock.TabIndex = 6;
            this.buttonBlock.UseVisualStyleBackColor = true;
            // 
            // colorSpacePanel
            // 
            this.colorSpacePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorSpacePanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorSpacePanel.ForeColor = System.Drawing.Color.Gray;
            this.colorSpacePanel.Location = new System.Drawing.Point(0, 0);
            this.colorSpacePanel.Margin = new System.Windows.Forms.Padding(0);
            this.colorSpacePanel.MinimumSize = new System.Drawing.Size(0, 120);
            this.colorSpacePanel.Name = "colorSpacePanel";
            this.colorSpacePanel.Size = new System.Drawing.Size(84, 145);
            this.colorSpacePanel.TabIndex = 2;
            // 
            // buttonDone
            // 
            this.tableLayoutPanelMatrixPalettControl.SetColumnSpan(this.buttonDone, 3);
            this.buttonDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDone.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone.ForeColor = System.Drawing.Color.Gray;
            this.buttonDone.Location = new System.Drawing.Point(0, 292);
            this.buttonDone.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(140, 28);
            this.buttonDone.TabIndex = 0;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.OnButtonDone_Click);
            // 
            // cardMatrix
            // 
            this.cardMatrix.CardColor = System.Drawing.Color.Empty;
            this.tableLayoutPanelMatrixPalettControl.SetColumnSpan(this.cardMatrix, 2);
            this.cardMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardMatrix.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.cardMatrix.Location = new System.Drawing.Point(0, 145);
            this.cardMatrix.Margin = new System.Windows.Forms.Padding(0);
            this.cardMatrix.Name = "cardMatrix";
            this.cardMatrix.Size = new System.Drawing.Size(112, 147);
            this.cardMatrix.TabIndex = 9;
            // 
            // MatrixPalettControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tableLayoutPanelMatrixPalettControl);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MatrixPalettControl";
            this.Size = new System.Drawing.Size(140, 320);
            this.tableLayoutPanelMatrixPalettControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMatrixPalettControl;
        private ColorSpacePanel colorSpacePanel;
        private System.Windows.Forms.VScrollBar vScrollBar;
        private System.Windows.Forms.Button buttonBlock;
        private System.Windows.Forms.Button buttonDone;
        private CardMatrix cardMatrix;
    }
}
