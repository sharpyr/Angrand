namespace Angrand.UserControls.PalettControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PalettControl));
            this.tableLayoutPanelPalettControl = new System.Windows.Forms.TableLayoutPanel();
            this.vScrollBarRight = new System.Windows.Forms.VScrollBar();
            this.buttonBlockRight = new System.Windows.Forms.Button();
            this.colorSpacePanelLeft = new Angrand.UserControls.ColorControlPanel.ColorSpacePanel();
            this.colorCardCollectionLeft = new Angrand.UserControls.ColorCardCollection.ColorCardCollection();
            this.colorSpacePanelRight = new Angrand.UserControls.ColorControlPanel.ColorSpacePanel();
            this.colorCardCollectionRight = new Angrand.UserControls.ColorCardCollection.ColorCardCollection();
            this.buttonBlockLeft = new System.Windows.Forms.Button();
            this.vScrollBarLeft = new System.Windows.Forms.VScrollBar();
            this.tableLayoutPanelPalettControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelPalettControl
            // 
            this.tableLayoutPanelPalettControl.ColumnCount = 4;
            this.tableLayoutPanelPalettControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelPalettControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanelPalettControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanelPalettControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelPalettControl.Controls.Add(this.vScrollBarRight, 3, 1);
            this.tableLayoutPanelPalettControl.Controls.Add(this.buttonBlockRight, 3, 0);
            this.tableLayoutPanelPalettControl.Controls.Add(this.colorSpacePanelLeft, 1, 0);
            this.tableLayoutPanelPalettControl.Controls.Add(this.colorCardCollectionLeft, 1, 1);
            this.tableLayoutPanelPalettControl.Controls.Add(this.colorSpacePanelRight, 2, 0);
            this.tableLayoutPanelPalettControl.Controls.Add(this.colorCardCollectionRight, 2, 1);
            this.tableLayoutPanelPalettControl.Controls.Add(this.buttonBlockLeft, 0, 0);
            this.tableLayoutPanelPalettControl.Controls.Add(this.vScrollBarLeft, 0, 1);
            this.tableLayoutPanelPalettControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPalettControl.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelPalettControl.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelPalettControl.Name = "tableLayoutPanelPalettControl";
            this.tableLayoutPanelPalettControl.RowCount = 2;
            this.tableLayoutPanelPalettControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.2F));
            this.tableLayoutPanelPalettControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.8F));
            this.tableLayoutPanelPalettControl.Size = new System.Drawing.Size(300, 400);
            this.tableLayoutPanelPalettControl.TabIndex = 0;
            // 
            // vScrollBarRight
            // 
            this.vScrollBarRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vScrollBarRight.Location = new System.Drawing.Point(255, 152);
            this.vScrollBarRight.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.vScrollBarRight.Name = "vScrollBarRight";
            this.vScrollBarRight.Size = new System.Drawing.Size(45, 243);
            this.vScrollBarRight.TabIndex = 7;
            this.vScrollBarRight.Value = 50;
            this.vScrollBarRight.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBarRight_Scroll);
            // 
            // buttonBlockRight
            // 
            this.buttonBlockRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBlockRight.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonBlockRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBlockRight.Location = new System.Drawing.Point(255, 0);
            this.buttonBlockRight.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBlockRight.Name = "buttonBlockRight";
            this.buttonBlockRight.Size = new System.Drawing.Size(45, 152);
            this.buttonBlockRight.TabIndex = 5;
            this.buttonBlockRight.UseVisualStyleBackColor = true;
            // 
            // colorSpacePanelLeft
            // 
            this.colorSpacePanelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorSpacePanelLeft.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.colorSpacePanelLeft.Hsl = ((System.ValueTuple<float, float, float>)(resources.GetObject("colorSpacePanelLeft.Hsl")));
            this.colorSpacePanelLeft.Location = new System.Drawing.Point(45, 0);
            this.colorSpacePanelLeft.Margin = new System.Windows.Forms.Padding(0);
            this.colorSpacePanelLeft.Name = "colorSpacePanelLeft";
            this.colorSpacePanelLeft.Rgb = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
            this.colorSpacePanelLeft.Size = new System.Drawing.Size(105, 152);
            this.colorSpacePanelLeft.TabIndex = 0;
            // 
            // colorCardCollectionLeft
            // 
            this.colorCardCollectionLeft.CardColor = System.Drawing.Color.Empty;
            this.colorCardCollectionLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorCardCollectionLeft.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.colorCardCollectionLeft.Location = new System.Drawing.Point(45, 152);
            this.colorCardCollectionLeft.Margin = new System.Windows.Forms.Padding(0);
            this.colorCardCollectionLeft.Name = "colorCardCollectionLeft";
            this.colorCardCollectionLeft.Size = new System.Drawing.Size(105, 248);
            this.colorCardCollectionLeft.TabIndex = 1;
            // 
            // colorSpacePanelRight
            // 
            this.colorSpacePanelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorSpacePanelRight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.colorSpacePanelRight.Hsl = ((System.ValueTuple<float, float, float>)(resources.GetObject("colorSpacePanelRight.Hsl")));
            this.colorSpacePanelRight.Location = new System.Drawing.Point(150, 0);
            this.colorSpacePanelRight.Margin = new System.Windows.Forms.Padding(0);
            this.colorSpacePanelRight.Name = "colorSpacePanelRight";
            this.colorSpacePanelRight.Rgb = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
            this.colorSpacePanelRight.Size = new System.Drawing.Size(105, 152);
            this.colorSpacePanelRight.TabIndex = 2;
            // 
            // colorCardCollectionRight
            // 
            this.colorCardCollectionRight.CardColor = System.Drawing.Color.Empty;
            this.colorCardCollectionRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorCardCollectionRight.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.colorCardCollectionRight.Location = new System.Drawing.Point(150, 152);
            this.colorCardCollectionRight.Margin = new System.Windows.Forms.Padding(0);
            this.colorCardCollectionRight.Name = "colorCardCollectionRight";
            this.colorCardCollectionRight.Size = new System.Drawing.Size(105, 248);
            this.colorCardCollectionRight.TabIndex = 3;
            // 
            // buttonBlockLeft
            // 
            this.buttonBlockLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBlockLeft.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonBlockLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBlockLeft.Location = new System.Drawing.Point(0, 0);
            this.buttonBlockLeft.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBlockLeft.Name = "buttonBlockLeft";
            this.buttonBlockLeft.Size = new System.Drawing.Size(45, 152);
            this.buttonBlockLeft.TabIndex = 4;
            this.buttonBlockLeft.UseVisualStyleBackColor = true;
            // 
            // vScrollBarLeft
            // 
            this.vScrollBarLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vScrollBarLeft.Location = new System.Drawing.Point(0, 152);
            this.vScrollBarLeft.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.vScrollBarLeft.Name = "vScrollBarLeft";
            this.vScrollBarLeft.Size = new System.Drawing.Size(45, 243);
            this.vScrollBarLeft.TabIndex = 6;
            this.vScrollBarLeft.Value = 50;
            this.vScrollBarLeft.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBarLeft_Scroll);
            // 
            // PalettControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelPalettControl);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PalettControl";
            this.Size = new System.Drawing.Size(300, 400);
            this.tableLayoutPanelPalettControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPalettControl;
        private ColorControlPanel.ColorSpacePanel colorSpacePanelLeft;
        private ColorCardCollection.ColorCardCollection colorCardCollectionLeft;
        private ColorControlPanel.ColorSpacePanel colorSpacePanelRight;
        private ColorCardCollection.ColorCardCollection colorCardCollectionRight;
        private System.Windows.Forms.VScrollBar vScrollBarRight;
        private System.Windows.Forms.Button buttonBlockRight;
        private System.Windows.Forms.Button buttonBlockLeft;
        private System.Windows.Forms.VScrollBar vScrollBarLeft;
    }
}
