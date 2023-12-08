namespace DexCommonUtil.UI도구
{
    partial class 스크린
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(스크린));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CommandPanel = new System.Windows.Forms.ToolStrip();
            this.조회버튼 = new System.Windows.Forms.ToolStripButton();
            this.행제거버튼 = new System.Windows.Forms.ToolStripButton();
            this.행추가버튼 = new System.Windows.Forms.ToolStripButton();
            this.저장버튼 = new System.Windows.Forms.ToolStripButton();
            this.CommonAction = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.닫기버튼 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CommonActionDtail = new System.Windows.Forms.ToolStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.CommandPanel.SuspendLayout();
            this.CommonAction.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.CommonActionDtail.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 360F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Controls.Add(this.CommandPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CommonAction, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.닫기버튼, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 28);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // CommandPanel
            // 
            this.CommandPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CommandPanel.Dock = System.Windows.Forms.DockStyle.None;
            this.CommandPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.조회버튼,
            this.행제거버튼,
            this.행추가버튼,
            this.저장버튼});
            this.CommandPanel.Location = new System.Drawing.Point(360, 1);
            this.CommandPanel.Name = "CommandPanel";
            this.CommandPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CommandPanel.Size = new System.Drawing.Size(394, 25);
            this.CommandPanel.TabIndex = 5;
            this.CommandPanel.Text = "toolStrip1";
            // 
            // 조회버튼
            // 
            this.조회버튼.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.조회버튼.Image = ((System.Drawing.Image)(resources.GetObject("조회버튼.Image")));
            this.조회버튼.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.조회버튼.Name = "조회버튼";
            this.조회버튼.Size = new System.Drawing.Size(23, 22);
            this.조회버튼.Text = "조회";
            this.조회버튼.ToolTipText = "조회";
            // 
            // 행제거버튼
            // 
            this.행제거버튼.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.행제거버튼.Image = ((System.Drawing.Image)(resources.GetObject("행제거버튼.Image")));
            this.행제거버튼.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.행제거버튼.Name = "행제거버튼";
            this.행제거버튼.Size = new System.Drawing.Size(23, 22);
            this.행제거버튼.Text = "행제거";
            this.행제거버튼.ToolTipText = "행제거";
            // 
            // 행추가버튼
            // 
            this.행추가버튼.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.행추가버튼.Image = ((System.Drawing.Image)(resources.GetObject("행추가버튼.Image")));
            this.행추가버튼.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.행추가버튼.Name = "행추가버튼";
            this.행추가버튼.Size = new System.Drawing.Size(23, 22);
            this.행추가버튼.Text = "행추가";
            this.행추가버튼.ToolTipText = "행추가";
            // 
            // 저장버튼
            // 
            this.저장버튼.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.저장버튼.Image = ((System.Drawing.Image)(resources.GetObject("저장버튼.Image")));
            this.저장버튼.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.저장버튼.Name = "저장버튼";
            this.저장버튼.Size = new System.Drawing.Size(23, 22);
            this.저장버튼.Text = "저장";
            this.저장버튼.ToolTipText = "저장버튼";
            // 
            // CommonAction
            // 
            this.CommonAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CommonAction.Dock = System.Windows.Forms.DockStyle.None;
            this.CommonAction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripComboBox1});
            this.CommonAction.Location = new System.Drawing.Point(0, 1);
            this.CommonAction.Name = "CommonAction";
            this.CommonAction.Size = new System.Drawing.Size(360, 25);
            this.CommonAction.TabIndex = 4;
            this.CommonAction.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(31, 22);
            this.toolStripLabel1.Text = "경로";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(300, 25);
            // 
            // 닫기버튼
            // 
            this.닫기버튼.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.닫기버튼.BackColor = System.Drawing.SystemColors.Control;
            this.닫기버튼.BackgroundImage = global::DexCommonUtil.Properties.Resources.cross;
            this.닫기버튼.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.닫기버튼.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.닫기버튼.ForeColor = System.Drawing.Color.Transparent;
            this.닫기버튼.Location = new System.Drawing.Point(754, 0);
            this.닫기버튼.Margin = new System.Windows.Forms.Padding(0);
            this.닫기버튼.Name = "닫기버튼";
            this.닫기버튼.Size = new System.Drawing.Size(30, 28);
            this.닫기버튼.TabIndex = 0;
            this.닫기버튼.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.Controls.Add(this.CommonActionDtail, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 413);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(784, 28);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // CommonActionDtail
            // 
            this.CommonActionDtail.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.CommonActionDtail.Location = new System.Drawing.Point(0, 0);
            this.CommonActionDtail.Name = "CommonActionDtail";
            this.CommonActionDtail.Size = new System.Drawing.Size(704, 25);
            this.CommonActionDtail.TabIndex = 5;
            this.CommonActionDtail.Text = "toolStrip2";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 22);
            // 
            // 스크린
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.Name = "스크린";
            this.Text = "스크린";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.CommandPanel.ResumeLayout(false);
            this.CommandPanel.PerformLayout();
            this.CommonAction.ResumeLayout(false);
            this.CommonAction.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.CommonActionDtail.ResumeLayout(false);
            this.CommonActionDtail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button 닫기버튼;
        private System.Windows.Forms.ToolStrip CommonAction;
        private System.Windows.Forms.ToolStrip CommonActionDtail;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStrip CommandPanel;
        private System.Windows.Forms.ToolStripButton 조회버튼;
        private System.Windows.Forms.ToolStripButton 행제거버튼;
        private System.Windows.Forms.ToolStripButton 행추가버튼;
        private System.Windows.Forms.ToolStripButton 저장버튼;
    }
}