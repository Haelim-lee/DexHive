
namespace DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.실적리포트
{
    partial class 생산LOT추적공통
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(생산LOT추적공통));
            this.SearchCondition = new System.Windows.Forms.TableLayoutPanel();
            this.SearchGroups = new System.Windows.Forms.TableLayoutPanel();
            this.TopSearch = new System.Windows.Forms.TableLayoutPanel();
            this.기간LB = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.기간중LB = new System.Windows.Forms.Label();
            this.UnderSearch = new System.Windows.Forms.TableLayoutPanel();
            this.제품군LB = new System.Windows.Forms.Label();
            this.제품구분LB = new System.Windows.Forms.Label();
            this.제품LB = new System.Windows.Forms.Label();
            this.생산LOTLB = new System.Windows.Forms.Label();
            this.제품구분CBX = new System.Windows.Forms.ComboBox();
            this.제품군CBX = new System.Windows.Forms.ComboBox();
            this.제품CBX = new System.Windows.Forms.ComboBox();
            this.생산LOTTXB = new System.Windows.Forms.TextBox();
            this.Allgrids = new System.Windows.Forms.TableLayoutPanel();
            this.Maingrid = new DexCommonUtil.UI도구.사용자정의컨트롤.DexGridView();
            this.GridGroups = new System.Windows.Forms.TableLayoutPanel();
            this.SearchCondition.SuspendLayout();
            this.SearchGroups.SuspendLayout();
            this.TopSearch.SuspendLayout();
            this.UnderSearch.SuspendLayout();
            this.Allgrids.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Maingrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchCondition
            // 
            this.SearchCondition.ColumnCount = 1;
            this.SearchCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SearchCondition.Controls.Add(this.SearchGroups, 0, 0);
            this.SearchCondition.Controls.Add(this.Allgrids, 0, 1);
            this.SearchCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchCondition.Location = new System.Drawing.Point(0, 28);
            this.SearchCondition.Margin = new System.Windows.Forms.Padding(0);
            this.SearchCondition.Name = "SearchCondition";
            this.SearchCondition.RowCount = 2;
            this.SearchCondition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.SearchCondition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.SearchCondition.Size = new System.Drawing.Size(946, 503);
            this.SearchCondition.TabIndex = 3;
            // 
            // SearchGroups
            // 
            this.SearchGroups.ColumnCount = 1;
            this.SearchGroups.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SearchGroups.Controls.Add(this.TopSearch, 0, 0);
            this.SearchGroups.Controls.Add(this.UnderSearch, 0, 1);
            this.SearchGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchGroups.Location = new System.Drawing.Point(0, 0);
            this.SearchGroups.Margin = new System.Windows.Forms.Padding(0);
            this.SearchGroups.Name = "SearchGroups";
            this.SearchGroups.RowCount = 2;
            this.SearchGroups.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.48454F));
            this.SearchGroups.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.51546F));
            this.SearchGroups.Size = new System.Drawing.Size(946, 80);
            this.SearchGroups.TabIndex = 4;
            // 
            // TopSearch
            // 
            this.TopSearch.ColumnCount = 5;
            this.TopSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TopSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.TopSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TopSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.TopSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 650F));
            this.TopSearch.Controls.Add(this.기간LB, 0, 0);
            this.TopSearch.Controls.Add(this.dateTimePicker1, 1, 0);
            this.TopSearch.Controls.Add(this.dateTimePicker2, 3, 0);
            this.TopSearch.Controls.Add(this.기간중LB, 2, 0);
            this.TopSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopSearch.Location = new System.Drawing.Point(0, 0);
            this.TopSearch.Margin = new System.Windows.Forms.Padding(0);
            this.TopSearch.Name = "TopSearch";
            this.TopSearch.RowCount = 1;
            this.TopSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.TopSearch.Size = new System.Drawing.Size(946, 39);
            this.TopSearch.TabIndex = 1;
            // 
            // 기간LB
            // 
            this.기간LB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.기간LB.AutoSize = true;
            this.기간LB.Location = new System.Drawing.Point(35, 13);
            this.기간LB.Name = "기간LB";
            this.기간LB.Size = new System.Drawing.Size(29, 12);
            this.기간LB.TabIndex = 0;
            this.기간LB.Text = "기간";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(103, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 21);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TopSearch.SetColumnSpan(this.dateTimePicker2, 2);
            this.dateTimePicker2.Location = new System.Drawing.Point(383, 9);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(874, 21);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // 기간중LB
            // 
            this.기간중LB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.기간중LB.AutoSize = true;
            this.기간중LB.Location = new System.Drawing.Point(348, 13);
            this.기간중LB.Name = "기간중LB";
            this.기간중LB.Size = new System.Drawing.Size(14, 12);
            this.기간중LB.TabIndex = 3;
            this.기간중LB.Text = "~";
            // 
            // UnderSearch
            // 
            this.UnderSearch.ColumnCount = 9;
            this.UnderSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.UnderSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.UnderSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.UnderSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.UnderSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.UnderSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.UnderSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.UnderSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.UnderSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.UnderSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.UnderSearch.Controls.Add(this.제품군LB, 0, 0);
            this.UnderSearch.Controls.Add(this.제품구분LB, 2, 0);
            this.UnderSearch.Controls.Add(this.제품LB, 5, 0);
            this.UnderSearch.Controls.Add(this.생산LOTLB, 7, 0);
            this.UnderSearch.Controls.Add(this.제품구분CBX, 3, 0);
            this.UnderSearch.Controls.Add(this.제품군CBX, 1, 0);
            this.UnderSearch.Controls.Add(this.제품CBX, 6, 0);
            this.UnderSearch.Controls.Add(this.생산LOTTXB, 8, 0);
            this.UnderSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnderSearch.Location = new System.Drawing.Point(0, 39);
            this.UnderSearch.Margin = new System.Windows.Forms.Padding(0);
            this.UnderSearch.Name = "UnderSearch";
            this.UnderSearch.RowCount = 1;
            this.UnderSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UnderSearch.Size = new System.Drawing.Size(946, 41);
            this.UnderSearch.TabIndex = 2;
            // 
            // 제품군LB
            // 
            this.제품군LB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.제품군LB.AutoSize = true;
            this.제품군LB.Location = new System.Drawing.Point(29, 14);
            this.제품군LB.Name = "제품군LB";
            this.제품군LB.Size = new System.Drawing.Size(41, 12);
            this.제품군LB.TabIndex = 0;
            this.제품군LB.Text = "제품군";
            // 
            // 제품구분LB
            // 
            this.제품구분LB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.제품구분LB.AutoSize = true;
            this.제품구분LB.Location = new System.Drawing.Point(323, 14);
            this.제품구분LB.Name = "제품구분LB";
            this.제품구분LB.Size = new System.Drawing.Size(53, 12);
            this.제품구분LB.TabIndex = 1;
            this.제품구분LB.Text = "제품구분";
            // 
            // 제품LB
            // 
            this.제품LB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.제품LB.AutoSize = true;
            this.제품LB.Location = new System.Drawing.Point(695, 14);
            this.제품LB.Name = "제품LB";
            this.제품LB.Size = new System.Drawing.Size(29, 12);
            this.제품LB.TabIndex = 2;
            this.제품LB.Text = "제품";
            // 
            // 생산LOTLB
            // 
            this.생산LOTLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.생산LOTLB.AutoSize = true;
            this.생산LOTLB.Location = new System.Drawing.Point(983, 14);
            this.생산LOTLB.Name = "생산LOTLB";
            this.생산LOTLB.Size = new System.Drawing.Size(53, 12);
            this.생산LOTLB.TabIndex = 3;
            this.생산LOTLB.Text = "생산LOT";
            // 
            // 제품구분CBX
            // 
            this.제품구분CBX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.제품구분CBX.FormattingEnabled = true;
            this.제품구분CBX.Location = new System.Drawing.Point(403, 10);
            this.제품구분CBX.Name = "제품구분CBX";
            this.제품구분CBX.Size = new System.Drawing.Size(194, 20);
            this.제품구분CBX.TabIndex = 4;
            // 
            // 제품군CBX
            // 
            this.제품군CBX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.제품군CBX.FormattingEnabled = true;
            this.제품군CBX.Location = new System.Drawing.Point(103, 10);
            this.제품군CBX.Name = "제품군CBX";
            this.제품군CBX.Size = new System.Drawing.Size(194, 20);
            this.제품군CBX.TabIndex = 5;
            // 
            // 제품CBX
            // 
            this.제품CBX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.제품CBX.FormattingEnabled = true;
            this.제품CBX.Location = new System.Drawing.Point(763, 10);
            this.제품CBX.Name = "제품CBX";
            this.제품CBX.Size = new System.Drawing.Size(194, 20);
            this.제품CBX.TabIndex = 4;
            // 
            // 생산LOTTXB
            // 
            this.생산LOTTXB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.생산LOTTXB.Location = new System.Drawing.Point(1060, 10);
            this.생산LOTTXB.Margin = new System.Windows.Forms.Padding(0);
            this.생산LOTTXB.Name = "생산LOTTXB";
            this.생산LOTTXB.Size = new System.Drawing.Size(200, 21);
            this.생산LOTTXB.TabIndex = 6;
            // 
            // Allgrids
            // 
            this.Allgrids.ColumnCount = 2;
            this.Allgrids.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.Allgrids.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 692F));
            this.Allgrids.Controls.Add(this.Maingrid, 0, 0);
            this.Allgrids.Controls.Add(this.GridGroups, 1, 0);
            this.Allgrids.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Allgrids.Location = new System.Drawing.Point(0, 80);
            this.Allgrids.Margin = new System.Windows.Forms.Padding(0);
            this.Allgrids.Name = "Allgrids";
            this.Allgrids.RowCount = 1;
            this.Allgrids.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Allgrids.Size = new System.Drawing.Size(946, 423);
            this.Allgrids.TabIndex = 0;
            // 
            // Maingrid
            // 
            this.Maingrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Maingrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Maingrid.Location = new System.Drawing.Point(0, 0);
            this.Maingrid.Margin = new System.Windows.Forms.Padding(0);
            this.Maingrid.Name = "Maingrid";
            this.Maingrid.RowTemplate.Height = 23;
            this.Maingrid.Size = new System.Drawing.Size(250, 423);
            this.Maingrid.TabIndex = 0;
            this.Maingrid.기본테이블명 = null;
            this.Maingrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Maingrid_CellClick);
            this.Maingrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Maingrid_CellContentClick);
            this.Maingrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Maingrid_CellContentDoubleClick);
            // 
            // GridGroups
            // 
            this.GridGroups.ColumnCount = 2;
            this.GridGroups.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GridGroups.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GridGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridGroups.Location = new System.Drawing.Point(250, 0);
            this.GridGroups.Margin = new System.Windows.Forms.Padding(0);
            this.GridGroups.Name = "GridGroups";
            this.GridGroups.RowCount = 3;
            this.GridGroups.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.GridGroups.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.GridGroups.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.GridGroups.Size = new System.Drawing.Size(696, 423);
            this.GridGroups.TabIndex = 1;
            // 
            // 생산LOT추적공통
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 559);
            this.Controls.Add(this.SearchCondition);
            this.Name = "생산LOT추적공통";
            this.Text = "생산LOT추적공통";
            this.Controls.SetChildIndex(this.SearchCondition, 0);
            this.SearchCondition.ResumeLayout(false);
            this.SearchGroups.ResumeLayout(false);
            this.TopSearch.ResumeLayout(false);
            this.TopSearch.PerformLayout();
            this.UnderSearch.ResumeLayout(false);
            this.UnderSearch.PerformLayout();
            this.Allgrids.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Maingrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel SearchCondition;
        private System.Windows.Forms.TableLayoutPanel Allgrids;
        private DexCommonUtil.UI도구.사용자정의컨트롤.DexGridView Maingrid;
        private System.Windows.Forms.TableLayoutPanel GridGroups;
        private System.Windows.Forms.TableLayoutPanel SearchGroups;
        private System.Windows.Forms.TableLayoutPanel TopSearch;
        private System.Windows.Forms.Label 기간LB;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label 기간중LB;
        private System.Windows.Forms.TableLayoutPanel UnderSearch;
        private System.Windows.Forms.Label 제품군LB;
        private System.Windows.Forms.Label 제품구분LB;
        private System.Windows.Forms.Label 제품LB;
        private System.Windows.Forms.Label 생산LOTLB;
        private System.Windows.Forms.ComboBox 제품구분CBX;
        private System.Windows.Forms.ComboBox 제품군CBX;
        private System.Windows.Forms.ComboBox 제품CBX;
        private System.Windows.Forms.TextBox 생산LOTTXB;
    }
}