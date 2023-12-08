
namespace DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.자재관리
{
    partial class 자재POPUP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(자재POPUP));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PopupGrid = new DexCommonUtil.UI도구.사용자정의컨트롤.DexGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.PopupGrid, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(625, 347);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // PopupGrid
            // 
            this.PopupGrid.AllowUserToAddRows = false;
            this.PopupGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PopupGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PopupGrid.Location = new System.Drawing.Point(0, 20);
            this.PopupGrid.Margin = new System.Windows.Forms.Padding(0);
            this.PopupGrid.Name = "PopupGrid";
            this.PopupGrid.RowTemplate.Height = 23;
            this.PopupGrid.Size = new System.Drawing.Size(625, 327);
            this.PopupGrid.TabIndex = 3;
            this.PopupGrid.기본테이블명 = null;
            this.PopupGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PopupGrid_CellContentDoubleClick);
            // 
            // 자재POPUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 347);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "자재POPUP";
            this.Text = "자재POPUP";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DexCommonUtil.UI도구.사용자정의컨트롤.DexGridView PopupGrid;
    }
}