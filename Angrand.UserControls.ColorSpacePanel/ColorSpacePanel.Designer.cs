namespace Angrand.UserControls.ColorControlPanel
{
    partial class ColorSpacePanel
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
            this.tableLayoutPanelColorControlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxL = new System.Windows.Forms.ComboBox();
            this.comboBoxS = new System.Windows.Forms.ComboBox();
            this.comboBoxB = new System.Windows.Forms.ComboBox();
            this.comboBoxG = new System.Windows.Forms.ComboBox();
            this.comboBoxR = new System.Windows.Forms.ComboBox();
            this.comboBoxH = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelColorControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelColorControlPanel
            // 
            this.tableLayoutPanelColorControlPanel.ColumnCount = 1;
            this.tableLayoutPanelColorControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelColorControlPanel.Controls.Add(this.comboBoxL, 0, 5);
            this.tableLayoutPanelColorControlPanel.Controls.Add(this.comboBoxS, 0, 4);
            this.tableLayoutPanelColorControlPanel.Controls.Add(this.comboBoxB, 0, 2);
            this.tableLayoutPanelColorControlPanel.Controls.Add(this.comboBoxG, 0, 1);
            this.tableLayoutPanelColorControlPanel.Controls.Add(this.comboBoxR, 0, 0);
            this.tableLayoutPanelColorControlPanel.Controls.Add(this.comboBoxH, 0, 3);
            this.tableLayoutPanelColorControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelColorControlPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelColorControlPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelColorControlPanel.Name = "tableLayoutPanelColorControlPanel";
            this.tableLayoutPanelColorControlPanel.RowCount = 6;
            this.tableLayoutPanelColorControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.665F));
            this.tableLayoutPanelColorControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.665F));
            this.tableLayoutPanelColorControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.665F));
            this.tableLayoutPanelColorControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.665F));
            this.tableLayoutPanelColorControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.665F));
            this.tableLayoutPanelColorControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.675F));
            this.tableLayoutPanelColorControlPanel.Size = new System.Drawing.Size(100, 160);
            this.tableLayoutPanelColorControlPanel.TabIndex = 0;
            // 
            // comboBoxL
            // 
            this.comboBoxL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxL.FormattingEnabled = true;
            this.comboBoxL.Location = new System.Drawing.Point(1, 131);
            this.comboBoxL.Margin = new System.Windows.Forms.Padding(1);
            this.comboBoxL.Name = "comboBoxL";
            this.comboBoxL.Size = new System.Drawing.Size(98, 23);
            this.comboBoxL.TabIndex = 5;
            this.comboBoxL.SelectedIndexChanged += new System.EventHandler(this.HslSelectedIndexChanged);
            // 
            // comboBoxS
            // 
            this.comboBoxS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxS.FormattingEnabled = true;
            this.comboBoxS.Location = new System.Drawing.Point(1, 105);
            this.comboBoxS.Margin = new System.Windows.Forms.Padding(1);
            this.comboBoxS.Name = "comboBoxS";
            this.comboBoxS.Size = new System.Drawing.Size(98, 23);
            this.comboBoxS.TabIndex = 4;
            this.comboBoxS.SelectedIndexChanged += new System.EventHandler(this.HslSelectedIndexChanged);
            // 
            // comboBoxB
            // 
            this.comboBoxB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxB.FormattingEnabled = true;
            this.comboBoxB.Location = new System.Drawing.Point(1, 53);
            this.comboBoxB.Margin = new System.Windows.Forms.Padding(1);
            this.comboBoxB.Name = "comboBoxB";
            this.comboBoxB.Size = new System.Drawing.Size(98, 23);
            this.comboBoxB.TabIndex = 2;
            this.comboBoxB.SelectedIndexChanged += new System.EventHandler(this.RgbSelectedIndexChanged);
            // 
            // comboBoxG
            // 
            this.comboBoxG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxG.FormattingEnabled = true;
            this.comboBoxG.Location = new System.Drawing.Point(1, 27);
            this.comboBoxG.Margin = new System.Windows.Forms.Padding(1);
            this.comboBoxG.Name = "comboBoxG";
            this.comboBoxG.Size = new System.Drawing.Size(98, 23);
            this.comboBoxG.TabIndex = 1;
            this.comboBoxG.SelectedIndexChanged += new System.EventHandler(this.RgbSelectedIndexChanged);
            // 
            // comboBoxR
            // 
            this.comboBoxR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxR.FormattingEnabled = true;
            this.comboBoxR.Location = new System.Drawing.Point(1, 1);
            this.comboBoxR.Margin = new System.Windows.Forms.Padding(1);
            this.comboBoxR.Name = "comboBoxR";
            this.comboBoxR.Size = new System.Drawing.Size(98, 23);
            this.comboBoxR.TabIndex = 0;
            this.comboBoxR.SelectedIndexChanged += new System.EventHandler(this.RgbSelectedIndexChanged);
            // 
            // comboBoxH
            // 
            this.comboBoxH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxH.FormattingEnabled = true;
            this.comboBoxH.Location = new System.Drawing.Point(1, 79);
            this.comboBoxH.Margin = new System.Windows.Forms.Padding(1);
            this.comboBoxH.Name = "comboBoxH";
            this.comboBoxH.Size = new System.Drawing.Size(98, 23);
            this.comboBoxH.TabIndex = 3;
            this.comboBoxH.SelectedIndexChanged += new System.EventHandler(this.HslSelectedIndexChanged);
            // 
            // ColorSpacePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelColorControlPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ColorSpacePanel";
            this.Size = new System.Drawing.Size(100, 160);
            this.tableLayoutPanelColorControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelColorControlPanel;
        private System.Windows.Forms.ComboBox comboBoxB;
        private System.Windows.Forms.ComboBox comboBoxG;
        private System.Windows.Forms.ComboBox comboBoxR;
        private System.Windows.Forms.ComboBox comboBoxL;
        private System.Windows.Forms.ComboBox comboBoxS;
        private System.Windows.Forms.ComboBox comboBoxH;
    }
}
