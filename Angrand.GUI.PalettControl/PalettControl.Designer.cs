namespace Angrand.GUI.PalettControl
{
    partial class PalettControl
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
            this.tableLayoutPanelPalettControl = new System.Windows.Forms.TableLayoutPanel();
            this.vScrollBarRight = new System.Windows.Forms.VScrollBar();
            this.buttonBlockRight = new System.Windows.Forms.Button();
            this.colorSpacePanelLeft = new Angrand.GUI.ColorSpacePanel.ColorSpacePanel();
            this.cardCollectionLeft = new Angrand.GUI.CardCollection.CardCollection();
            this.colorSpacePanelRight = new Angrand.GUI.ColorSpacePanel.ColorSpacePanel();
            this.cardCollectionRight = new Angrand.GUI.CardCollection.CardCollection();
            this.buttonBlockLeft = new System.Windows.Forms.Button();
            this.vScrollBarLeft = new System.Windows.Forms.VScrollBar();
            this.buttonDone = new System.Windows.Forms.Button();
            this.tableLayoutPanelPalettControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelPalettControl
            // 
            this.tableLayoutPanelPalettControl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanelPalettControl.ColumnCount = 4;
            this.tableLayoutPanelPalettControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelPalettControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanelPalettControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanelPalettControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelPalettControl.Controls.Add(this.vScrollBarRight, 3, 1);
            this.tableLayoutPanelPalettControl.Controls.Add(this.buttonBlockRight, 3, 0);
            this.tableLayoutPanelPalettControl.Controls.Add(this.colorSpacePanelLeft, 1, 0);
            this.tableLayoutPanelPalettControl.Controls.Add(this.cardCollectionLeft, 1, 1);
            this.tableLayoutPanelPalettControl.Controls.Add(this.colorSpacePanelRight, 2, 0);
            this.tableLayoutPanelPalettControl.Controls.Add(this.cardCollectionRight, 2, 1);
            this.tableLayoutPanelPalettControl.Controls.Add(this.buttonBlockLeft, 0, 0);
            this.tableLayoutPanelPalettControl.Controls.Add(this.vScrollBarLeft, 0, 1);
            this.tableLayoutPanelPalettControl.Controls.Add(this.buttonDone, 0, 2);
            this.tableLayoutPanelPalettControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPalettControl.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelPalettControl.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelPalettControl.Name = "tableLayoutPanelPalettControl";
            this.tableLayoutPanelPalettControl.RowCount = 3;
            this.tableLayoutPanelPalettControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPalettControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPalettControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPalettControl.Size = new System.Drawing.Size(240, 474);
            this.tableLayoutPanelPalettControl.TabIndex = 0;
            // 
            // vScrollBarRight
            // 
            this.vScrollBarRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vScrollBarRight.Location = new System.Drawing.Point(204, 145);
            this.vScrollBarRight.Name = "vScrollBarRight";
            this.vScrollBarRight.Size = new System.Drawing.Size(36, 301);
            this.vScrollBarRight.TabIndex = 8;
            this.vScrollBarRight.Value = 50;
            this.vScrollBarRight.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBarRight_Scroll);
            // 
            // buttonBlockRight
            // 
            this.buttonBlockRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBlockRight.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonBlockRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBlockRight.ForeColor = System.Drawing.Color.Gray;
            this.buttonBlockRight.Location = new System.Drawing.Point(204, 0);
            this.buttonBlockRight.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBlockRight.Name = "buttonBlockRight";
            this.buttonBlockRight.Size = new System.Drawing.Size(36, 145);
            this.buttonBlockRight.TabIndex = 6;
            this.buttonBlockRight.UseVisualStyleBackColor = true;
            // 
            // colorSpacePanelLeft
            // 
            this.colorSpacePanelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorSpacePanelLeft.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorSpacePanelLeft.ForeColor = System.Drawing.Color.Gray;
            this.colorSpacePanelLeft.Location = new System.Drawing.Point(36, 0);
            this.colorSpacePanelLeft.Margin = new System.Windows.Forms.Padding(0);
            this.colorSpacePanelLeft.MinimumSize = new System.Drawing.Size(0, 120);
            this.colorSpacePanelLeft.Name = "colorSpacePanelLeft";
            this.colorSpacePanelLeft.Size = new System.Drawing.Size(84, 145);
            this.colorSpacePanelLeft.TabIndex = 1;
            // 
            // cardCollectionLeft
            // 
            this.cardCollectionLeft.CardColor = System.Drawing.Color.Empty;
            this.cardCollectionLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardCollectionLeft.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.cardCollectionLeft.Location = new System.Drawing.Point(36, 145);
            this.cardCollectionLeft.Margin = new System.Windows.Forms.Padding(0);
            this.cardCollectionLeft.Name = "cardCollectionLeft";
            this.cardCollectionLeft.Size = new System.Drawing.Size(84, 301);
            this.cardCollectionLeft.TabIndex = 3;
            // 
            // colorSpacePanelRight
            // 
            this.colorSpacePanelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorSpacePanelRight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorSpacePanelRight.ForeColor = System.Drawing.Color.Gray;
            this.colorSpacePanelRight.Location = new System.Drawing.Point(120, 0);
            this.colorSpacePanelRight.Margin = new System.Windows.Forms.Padding(0);
            this.colorSpacePanelRight.MinimumSize = new System.Drawing.Size(0, 120);
            this.colorSpacePanelRight.Name = "colorSpacePanelRight";
            this.colorSpacePanelRight.Size = new System.Drawing.Size(84, 145);
            this.colorSpacePanelRight.TabIndex = 2;
            // 
            // cardCollectionRight
            // 
            this.cardCollectionRight.CardColor = System.Drawing.Color.Empty;
            this.cardCollectionRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardCollectionRight.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.cardCollectionRight.Location = new System.Drawing.Point(120, 145);
            this.cardCollectionRight.Margin = new System.Windows.Forms.Padding(0);
            this.cardCollectionRight.Name = "cardCollectionRight";
            this.cardCollectionRight.Size = new System.Drawing.Size(84, 301);
            this.cardCollectionRight.TabIndex = 4;
            // 
            // buttonBlockLeft
            // 
            this.buttonBlockLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBlockLeft.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonBlockLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBlockLeft.ForeColor = System.Drawing.Color.Gray;
            this.buttonBlockLeft.Location = new System.Drawing.Point(0, 0);
            this.buttonBlockLeft.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBlockLeft.Name = "buttonBlockLeft";
            this.buttonBlockLeft.Size = new System.Drawing.Size(36, 145);
            this.buttonBlockLeft.TabIndex = 5;
            this.buttonBlockLeft.UseVisualStyleBackColor = true;
            // 
            // vScrollBarLeft
            // 
            this.vScrollBarLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vScrollBarLeft.Location = new System.Drawing.Point(0, 145);
            this.vScrollBarLeft.Name = "vScrollBarLeft";
            this.vScrollBarLeft.Size = new System.Drawing.Size(36, 301);
            this.vScrollBarLeft.TabIndex = 7;
            this.vScrollBarLeft.Value = 50;
            this.vScrollBarLeft.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBarLeft_Scroll);
            // 
            // buttonDone
            // 
            this.tableLayoutPanelPalettControl.SetColumnSpan(this.buttonDone, 4);
            this.buttonDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDone.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone.ForeColor = System.Drawing.Color.Gray;
            this.buttonDone.Location = new System.Drawing.Point(0, 446);
            this.buttonDone.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(240, 28);
            this.buttonDone.TabIndex = 0;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.OnButtonDone_Click);
            // 
            // PalettControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tableLayoutPanelPalettControl);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PalettControl";
            this.Size = new System.Drawing.Size(240, 474);
            this.tableLayoutPanelPalettControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPalettControl;
        private GUI.ColorSpacePanel.ColorSpacePanel colorSpacePanelLeft;
        private GUI.CardCollection.CardCollection cardCollectionLeft;
        private GUI.ColorSpacePanel.ColorSpacePanel colorSpacePanelRight;
        private GUI.CardCollection.CardCollection cardCollectionRight;
        private System.Windows.Forms.VScrollBar vScrollBarRight;
        private System.Windows.Forms.Button buttonBlockRight;
        private System.Windows.Forms.Button buttonBlockLeft;
        private System.Windows.Forms.VScrollBar vScrollBarLeft;
        private System.Windows.Forms.Button buttonDone;
    }
}
