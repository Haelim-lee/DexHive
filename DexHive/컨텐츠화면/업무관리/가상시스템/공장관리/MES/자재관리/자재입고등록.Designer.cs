
namespace DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.자재관리
{
    partial class 자재입고등록
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(자재입고등록));
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGrid = new DexCommonUtil.UI도구.사용자정의컨트롤.DexGridView();
            this.Alltable = new System.Windows.Forms.TableLayoutPanel();
            this.자재코드LB = new System.Windows.Forms.Label();
            this.공급사LB = new System.Windows.Forms.Label();
            this.공급사CBX = new System.Windows.Forms.ComboBox();
            this.자재CBX = new System.Windows.Forms.ComboBox();
            this.위치LB = new System.Windows.Forms.Label();
            this.위치CBX = new System.Windows.Forms.ComboBox();
            this.입고수량LB = new System.Windows.Forms.Label();
            this.단위LB = new System.Windows.Forms.Label();
            this.입고수량TXB = new System.Windows.Forms.TextBox();
            this.단위CBX = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.Alltable.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.dataGrid, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.Alltable, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(960, 488);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel3.SetColumnSpan(this.dataGrid, 6);
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(0, 110);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowTemplate.Height = 23;
            this.dataGrid.Size = new System.Drawing.Size(960, 378);
            this.dataGrid.TabIndex = 5;
            this.dataGrid.기본테이블명 = null;
            // 
            // Alltable
            // 
            this.Alltable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Alltable.ColumnCount = 6;
            this.Alltable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.Alltable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.Alltable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.Alltable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.Alltable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.Alltable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 360F));
            this.Alltable.Controls.Add(this.자재코드LB, 0, 0);
            this.Alltable.Controls.Add(this.자재CBX, 1, 0);
            this.Alltable.Controls.Add(this.공급사LB, 0, 1);
            this.Alltable.Controls.Add(this.공급사CBX, 1, 1);
            this.Alltable.Controls.Add(this.위치CBX, 3, 0);
            this.Alltable.Controls.Add(this.위치LB, 2, 0);
            this.Alltable.Controls.Add(this.단위LB, 2, 1);
            this.Alltable.Controls.Add(this.단위CBX, 3, 1);
            this.Alltable.Controls.Add(this.입고수량LB, 4, 1);
            this.Alltable.Controls.Add(this.입고수량TXB, 5, 1);
            this.Alltable.Location = new System.Drawing.Point(0, 1);
            this.Alltable.Margin = new System.Windows.Forms.Padding(0);
            this.Alltable.Name = "Alltable";
            this.Alltable.RowCount = 3;
            this.Alltable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.Alltable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.Alltable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Alltable.Size = new System.Drawing.Size(960, 108);
            this.Alltable.TabIndex = 4;
            // 
            // 자재코드LB
            // 
            this.자재코드LB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.자재코드LB.AutoSize = true;
            this.자재코드LB.Location = new System.Drawing.Point(32, 11);
            this.자재코드LB.Name = "자재코드LB";
            this.자재코드LB.Size = new System.Drawing.Size(35, 12);
            this.자재코드LB.TabIndex = 0;
            this.자재코드LB.Text = "*자재";
            // 
            // 공급사LB
            // 
            this.공급사LB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.공급사LB.AutoSize = true;
            this.공급사LB.Location = new System.Drawing.Point(26, 46);
            this.공급사LB.Name = "공급사LB";
            this.공급사LB.Size = new System.Drawing.Size(47, 12);
            this.공급사LB.TabIndex = 0;
            this.공급사LB.Text = "*공급사";
            // 
            // 공급사CBX
            // 
            this.공급사CBX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.공급사CBX.FormattingEnabled = true;
            this.공급사CBX.Location = new System.Drawing.Point(103, 42);
            this.공급사CBX.Name = "공급사CBX";
            this.공급사CBX.Size = new System.Drawing.Size(144, 20);
            this.공급사CBX.TabIndex = 4;
            // 
            // 자재CBX
            // 
            this.자재CBX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.자재CBX.FormattingEnabled = true;
            this.자재CBX.Location = new System.Drawing.Point(103, 7);
            this.자재CBX.Name = "자재CBX";
            this.자재CBX.Size = new System.Drawing.Size(144, 20);
            this.자재CBX.TabIndex = 6;
            // 
            // 위치LB
            // 
            this.위치LB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.위치LB.AutoSize = true;
            this.위치LB.Location = new System.Drawing.Point(282, 11);
            this.위치LB.Name = "위치LB";
            this.위치LB.Size = new System.Drawing.Size(35, 12);
            this.위치LB.TabIndex = 0;
            this.위치LB.Text = "*위치";
            // 
            // 위치CBX
            // 
            this.위치CBX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.위치CBX.FormattingEnabled = true;
            this.위치CBX.Location = new System.Drawing.Point(353, 7);
            this.위치CBX.Name = "위치CBX";
            this.위치CBX.Size = new System.Drawing.Size(144, 20);
            this.위치CBX.TabIndex = 4;
            // 
            // 입고수량LB
            // 
            this.입고수량LB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.입고수량LB.AutoSize = true;
            this.입고수량LB.Location = new System.Drawing.Point(520, 46);
            this.입고수량LB.Name = "입고수량LB";
            this.입고수량LB.Size = new System.Drawing.Size(59, 12);
            this.입고수량LB.TabIndex = 0;
            this.입고수량LB.Text = "*입고수량";
            // 
            // 단위LB
            // 
            this.단위LB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.단위LB.AutoSize = true;
            this.단위LB.Location = new System.Drawing.Point(282, 46);
            this.단위LB.Name = "단위LB";
            this.단위LB.Size = new System.Drawing.Size(35, 12);
            this.단위LB.TabIndex = 3;
            this.단위LB.Text = "*단위";
            // 
            // 입고수량TXB
            // 
            this.입고수량TXB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.입고수량TXB.Location = new System.Drawing.Point(603, 42);
            this.입고수량TXB.Name = "입고수량TXB";
            this.입고수량TXB.Size = new System.Drawing.Size(144, 21);
            this.입고수량TXB.TabIndex = 5;
            // 
            // 단위CBX
            // 
            this.단위CBX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.단위CBX.FormattingEnabled = true;
            this.단위CBX.Location = new System.Drawing.Point(353, 42);
            this.단위CBX.Name = "단위CBX";
            this.단위CBX.Size = new System.Drawing.Size(144, 20);
            this.단위CBX.TabIndex = 4;
            // 
            // 자재입고등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 544);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "자재입고등록";
            this.Text = "자재입고등록";
            this.Controls.SetChildIndex(this.tableLayoutPanel3, 0);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.Alltable.ResumeLayout(false);
            this.Alltable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DexCommonUtil.UI도구.사용자정의컨트롤.DexGridView dataGrid;
        private System.Windows.Forms.TableLayoutPanel Alltable;
        private System.Windows.Forms.Label 자재코드LB;
        private System.Windows.Forms.Label 공급사LB;
        private System.Windows.Forms.Label 입고수량LB;
        private System.Windows.Forms.Label 단위LB;
        private System.Windows.Forms.ComboBox 단위CBX;
        private System.Windows.Forms.ComboBox 공급사CBX;
        private System.Windows.Forms.TextBox 입고수량TXB;
        private System.Windows.Forms.ComboBox 자재CBX;
        private System.Windows.Forms.Label 위치LB;
        private System.Windows.Forms.ComboBox 위치CBX;
    }
}