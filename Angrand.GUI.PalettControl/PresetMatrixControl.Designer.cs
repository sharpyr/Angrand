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
            this.tableLayoutPanelMatricePalettControl = new System.Windows.Forms.TableLayoutPanel();
            this.colorPanelRight = new Angrand.GUI.ColorSpacePanel.ScrollableColorPanel();
            this.buttonDone = new System.Windows.Forms.Button();
            this.colorPanelLeft = new Angrand.GUI.ColorSpacePanel.ScrollableColorPanel();
            this.matrixPanel = new Angrand.GUI.ColorSpacePanel.MatrixPanel();
            this.tableLayoutPanelMatricePalettControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMatricePalettControl
            // 
            this.tableLayoutPanelMatricePalettControl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanelMatricePalettControl.ColumnCount = 2;
            this.tableLayoutPanelMatricePalettControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMatricePalettControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMatricePalettControl.Controls.Add(this.colorPanelRight, 1, 0);
            this.tableLayoutPanelMatricePalettControl.Controls.Add(this.buttonDone, 0, 2);
            this.tableLayoutPanelMatricePalettControl.Controls.Add(this.colorPanelLeft, 0, 0);
            this.tableLayoutPanelMatricePalettControl.Controls.Add(this.matrixPanel, 0, 1);
            this.tableLayoutPanelMatricePalettControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMatricePalettControl.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMatricePalettControl.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelMatricePalettControl.Name = "tableLayoutPanelMatricePalettControl";
            this.tableLayoutPanelMatricePalettControl.RowCount = 4;
            this.tableLayoutPanelMatricePalettControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMatricePalettControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMatricePalettControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMatricePalettControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMatricePalettControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMatricePalettControl.Size = new System.Drawing.Size(480, 480);
            this.tableLayoutPanelMatricePalettControl.TabIndex = 0;
            // 
            // colorPanelRight
            // 
            this.colorPanelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorPanelRight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.colorPanelRight.Location = new System.Drawing.Point(240, 0);
            this.colorPanelRight.Margin = new System.Windows.Forms.Padding(0);
            this.colorPanelRight.Name = "colorPanelRight";
            this.colorPanelRight.Size = new System.Drawing.Size(240, 170);
            this.colorPanelRight.TabIndex = 11;
            // 
            // buttonDone
            // 
            this.buttonDone.AllowDrop = true;
            this.tableLayoutPanelMatricePalettControl.SetColumnSpan(this.buttonDone, 3);
            this.buttonDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDone.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone.ForeColor = System.Drawing.Color.Gray;
            this.buttonDone.Location = new System.Drawing.Point(0, 452);
            this.buttonDone.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(480, 28);
            this.buttonDone.TabIndex = 0;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // colorPanelLeft
            // 
            this.colorPanelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorPanelLeft.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.colorPanelLeft.Location = new System.Drawing.Point(0, 0);
            this.colorPanelLeft.Margin = new System.Windows.Forms.Padding(0);
            this.colorPanelLeft.Name = "colorPanelLeft";
            this.colorPanelLeft.Size = new System.Drawing.Size(240, 170);
            this.colorPanelLeft.TabIndex = 10;
            // 
            // matrixPanel
            // 
            this.tableLayoutPanelMatricePalettControl.SetColumnSpan(this.matrixPanel, 2);
            this.matrixPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrixPanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.matrixPanel.Location = new System.Drawing.Point(0, 170);
            this.matrixPanel.Margin = new System.Windows.Forms.Padding(0);
            this.matrixPanel.Name = "matrixPanel";
            this.matrixPanel.Size = new System.Drawing.Size(480, 282);
            this.matrixPanel.TabIndex = 14;
            // 
            // PresetMatrixControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tableLayoutPanelMatricePalettControl);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PresetMatrixControl";
            this.Size = new System.Drawing.Size(480, 480);
            this.tableLayoutPanelMatricePalettControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMatricePalettControl;
        private System.Windows.Forms.Button buttonDone;
        private ColorSpacePanel.ScrollableColorPanel colorPanelRight;
        private ColorSpacePanel.ScrollableColorPanel colorPanelLeft;
        private ColorSpacePanel.MatrixPanel matrixPanel;
    }
}
