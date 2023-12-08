
namespace DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.공정관리_반제품_
{
    partial class 자재LOT정보Popup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(자재LOT정보Popup));
            this.AllTable = new System.Windows.Forms.TableLayoutPanel();
            this.DateTable = new System.Windows.Forms.TableLayoutPanel();
            this.dataGrid = new DexCommonUtil.UI도구.사용자정의컨트롤.DexGridView();
            this.TopTable = new System.Windows.Forms.TableLayoutPanel();
            this.Productcode = new System.Windows.Forms.Label();
            this.MaterialCode = new System.Windows.Forms.Label();
            this.LOTID = new System.Windows.Forms.Label();
            this.자재LOT = new System.Windows.Forms.Label();
            this.MaterialCodeCBO = new System.Windows.Forms.ComboBox();
            this.ProductcodeTBX = new System.Windows.Forms.TextBox();
            this.LOTIDTXB = new System.Windows.Forms.TextBox();
            this.자재LOTTXB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.AllTable.SuspendLayout();
            this.DateTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.TopTable.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllTable
            // 
            this.AllTable.ColumnCount = 1;
            this.AllTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AllTable.Controls.Add(this.DateTable, 0, 1);
            this.AllTable.Controls.Add(this.TopTable, 0, 0);
            this.AllTable.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.AllTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllTable.Location = new System.Drawing.Point(0, 0);
            this.AllTable.Margin = new System.Windows.Forms.Padding(0);
            this.AllTable.Name = "AllTable";
            this.AllTable.RowCount = 3;
            this.AllTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.AllTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AllTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.AllTable.Size = new System.Drawing.Size(716, 374);
            this.AllTable.TabIndex = 3;
            // 
            // DateTable
            // 
            this.DateTable.ColumnCount = 1;
            this.DateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DateTable.Controls.Add(this.dataGrid, 0, 0);
            this.DateTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateTable.Location = new System.Drawing.Point(0, 90);
            this.DateTable.Margin = new System.Windows.Forms.Padding(0);
            this.DateTable.Name = "DateTable";
            this.DateTable.RowCount = 1;
            this.DateTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DateTable.Size = new System.Drawing.Size(716, 244);
            this.DateTable.TabIndex = 0;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(0, 0);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowTemplate.Height = 23;
            this.dataGrid.Size = new System.Drawing.Size(716, 244);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.기본테이블명 = null;
            // 
            // TopTable
            // 
            this.TopTable.ColumnCount = 5;
            this.TopTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.TopTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.TopTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.TopTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.TopTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 226F));
            this.TopTable.Controls.Add(this.Productcode, 0, 0);
            this.TopTable.Controls.Add(this.MaterialCode, 0, 1);
            this.TopTable.Controls.Add(this.LOTID, 2, 0);
            this.TopTable.Controls.Add(this.자재LOT, 2, 1);
            this.TopTable.Controls.Add(this.MaterialCodeCBO, 1, 1);
            this.TopTable.Controls.Add(this.ProductcodeTBX, 1, 0);
            this.TopTable.Controls.Add(this.LOTIDTXB, 3, 0);
            this.TopTable.Controls.Add(this.자재LOTTXB, 3, 1);
            this.TopTable.Controls.Add(this.button1, 4, 1);
            this.TopTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopTable.Location = new System.Drawing.Point(0, 0);
            this.TopTable.Margin = new System.Windows.Forms.Padding(0);
            this.TopTable.Name = "TopTable";
            this.TopTable.RowCount = 2;
            this.TopTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TopTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TopTable.Size = new System.Drawing.Size(716, 90);
            this.TopTable.TabIndex = 1;
            // 
            // Productcode
            // 
            this.Productcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Productcode.AutoSize = true;
            this.Productcode.Location = new System.Drawing.Point(28, 16);
            this.Productcode.Name = "Productcode";
            this.Productcode.Size = new System.Drawing.Size(53, 12);
            this.Productcode.TabIndex = 0;
            this.Productcode.Text = "제품코드";
            // 
            // MaterialCode
            // 
            this.MaterialCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MaterialCode.AutoSize = true;
            this.MaterialCode.Location = new System.Drawing.Point(28, 61);
            this.MaterialCode.Name = "MaterialCode";
            this.MaterialCode.Size = new System.Drawing.Size(53, 12);
            this.MaterialCode.TabIndex = 0;
            this.MaterialCode.Text = "자재코드";
            // 
            // LOTID
            // 
            this.LOTID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LOTID.AutoSize = true;
            this.LOTID.Location = new System.Drawing.Point(279, 16);
            this.LOTID.Name = "LOTID";
            this.LOTID.Size = new System.Drawing.Size(41, 12);
            this.LOTID.TabIndex = 0;
            this.LOTID.Text = "제품명";
            // 
            // 자재LOT
            // 
            this.자재LOT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.자재LOT.AutoSize = true;
            this.자재LOT.Location = new System.Drawing.Point(273, 61);
            this.자재LOT.Name = "자재LOT";
            this.자재LOT.Size = new System.Drawing.Size(53, 12);
            this.자재LOT.TabIndex = 0;
            this.자재LOT.Text = "자재LOT";
            // 
            // MaterialCodeCBO
            // 
            this.MaterialCodeCBO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MaterialCodeCBO.FormattingEnabled = true;
            this.MaterialCodeCBO.Location = new System.Drawing.Point(113, 57);
            this.MaterialCodeCBO.Name = "MaterialCodeCBO";
            this.MaterialCodeCBO.Size = new System.Drawing.Size(129, 20);
            this.MaterialCodeCBO.TabIndex = 1;
            // 
            // ProductcodeTBX
            // 
            this.ProductcodeTBX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductcodeTBX.Location = new System.Drawing.Point(113, 12);
            this.ProductcodeTBX.Name = "ProductcodeTBX";
            this.ProductcodeTBX.Size = new System.Drawing.Size(129, 21);
            this.ProductcodeTBX.TabIndex = 2;
            // 
            // LOTIDTXB
            // 
            this.LOTIDTXB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LOTIDTXB.Location = new System.Drawing.Point(358, 12);
            this.LOTIDTXB.Name = "LOTIDTXB";
            this.LOTIDTXB.Size = new System.Drawing.Size(129, 21);
            this.LOTIDTXB.TabIndex = 2;
            // 
            // 자재LOTTXB
            // 
            this.자재LOTTXB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.자재LOTTXB.Location = new System.Drawing.Point(358, 57);
            this.자재LOTTXB.Name = "자재LOTTXB";
            this.자재LOTTXB.Size = new System.Drawing.Size(129, 21);
            this.자재LOTTXB.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(638, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "조회";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 334);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(716, 40);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(400, 8);
            this.button2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "추가";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(558, 8);
            this.button3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "취소";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // 자재LOT정보Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 374);
            this.Controls.Add(this.AllTable);
            this.Name = "자재LOT정보Popup";
            this.Text = "자재LOT정보Popup";
            this.AllTable.ResumeLayout(false);
            this.DateTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.TopTable.ResumeLayout(false);
            this.TopTable.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel AllTable;
        private System.Windows.Forms.TableLayoutPanel DateTable;
        private DexCommonUtil.UI도구.사용자정의컨트롤.DexGridView dataGrid;
        private System.Windows.Forms.TableLayoutPanel TopTable;
        private System.Windows.Forms.Label Productcode;
        private System.Windows.Forms.Label MaterialCode;
        private System.Windows.Forms.Label LOTID;
        private System.Windows.Forms.Label 자재LOT;
        private System.Windows.Forms.ComboBox MaterialCodeCBO;
        private System.Windows.Forms.TextBox ProductcodeTBX;
        private System.Windows.Forms.TextBox LOTIDTXB;
        private System.Windows.Forms.TextBox 자재LOTTXB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}