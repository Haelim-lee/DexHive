
using DexCommonUtil.UI도구.사용자정의컨트롤;

namespace DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.자재관리
{
    partial class 자재등록
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(자재등록));
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.자재등록표 = new DexCommonUtil.UI도구.사용자정의컨트롤.DexGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.자재LOTIB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt자재코드ID = new System.Windows.Forms.TextBox();
            this.txt자재코드타입 = new System.Windows.Forms.TextBox();
            this.txt자재기준수량 = new System.Windows.Forms.TextBox();
            this.공급사IB = new System.Windows.Forms.Label();
            this.txt자재코드명 = new System.Windows.Forms.TextBox();
            this.위치IB = new System.Windows.Forms.Label();
            this.txt자재그룹ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt자재기준단위 = new System.Windows.Forms.TextBox();
            this.lb이동위치 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.cbo이동위치 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.자재등록표)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Controls.Add(this.자재등록표, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 181F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1057, 547);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // 자재등록표
            // 
            this.자재등록표.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.자재등록표.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.자재등록표.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.자재등록표.DefaultCellStyle = dataGridViewCellStyle2;
            this.자재등록표.Dock = System.Windows.Forms.DockStyle.Fill;
            this.자재등록표.Location = new System.Drawing.Point(0, 181);
            this.자재등록표.Margin = new System.Windows.Forms.Padding(0);
            this.자재등록표.Name = "자재등록표";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.자재등록표.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.자재등록표.RowTemplate.Height = 23;
            this.자재등록표.Size = new System.Drawing.Size(1057, 366);
            this.자재등록표.TabIndex = 2;
            this.자재등록표.기본테이블명 = null;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 577F));
            this.tableLayoutPanel4.Controls.Add(this.자재LOTIB, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.txt자재코드ID, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.txt자재코드타입, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.txt자재기준수량, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.공급사IB, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.txt자재코드명, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.위치IB, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.txt자재그룹ID, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.label3, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.txt자재기준단위, 3, 2);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 4, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.23809F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.42857F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1057, 181);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // 자재LOTIB
            // 
            this.자재LOTIB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.자재LOTIB.AutoSize = true;
            this.자재LOTIB.Location = new System.Drawing.Point(23, 25);
            this.자재LOTIB.Name = "자재LOTIB";
            this.자재LOTIB.Size = new System.Drawing.Size(64, 12);
            this.자재LOTIB.TabIndex = 0;
            this.자재LOTIB.Text = "자재코드ID";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "자재코드타입";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "자재기준수량";
            // 
            // txt자재코드ID
            // 
            this.txt자재코드ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt자재코드ID.Location = new System.Drawing.Point(125, 21);
            this.txt자재코드ID.Name = "txt자재코드ID";
            this.txt자재코드ID.Size = new System.Drawing.Size(100, 21);
            this.txt자재코드ID.TabIndex = 2;
            // 
            // txt자재코드타입
            // 
            this.txt자재코드타입.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt자재코드타입.Location = new System.Drawing.Point(125, 80);
            this.txt자재코드타입.Name = "txt자재코드타입";
            this.txt자재코드타입.Size = new System.Drawing.Size(100, 21);
            this.txt자재코드타입.TabIndex = 2;
            // 
            // txt자재기준수량
            // 
            this.txt자재기준수량.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt자재기준수량.Location = new System.Drawing.Point(365, 80);
            this.txt자재기준수량.Name = "txt자재기준수량";
            this.txt자재기준수량.Size = new System.Drawing.Size(100, 21);
            this.txt자재기준수량.TabIndex = 2;
            // 
            // 공급사IB
            // 
            this.공급사IB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.공급사IB.AutoSize = true;
            this.공급사IB.Location = new System.Drawing.Point(262, 25);
            this.공급사IB.Name = "공급사IB";
            this.공급사IB.Size = new System.Drawing.Size(65, 12);
            this.공급사IB.TabIndex = 0;
            this.공급사IB.Text = "자재코드명";
            // 
            // txt자재코드명
            // 
            this.txt자재코드명.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt자재코드명.Location = new System.Drawing.Point(365, 21);
            this.txt자재코드명.Name = "txt자재코드명";
            this.txt자재코드명.Size = new System.Drawing.Size(100, 21);
            this.txt자재코드명.TabIndex = 2;
            // 
            // 위치IB
            // 
            this.위치IB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.위치IB.AutoSize = true;
            this.위치IB.Location = new System.Drawing.Point(23, 144);
            this.위치IB.Name = "위치IB";
            this.위치IB.Size = new System.Drawing.Size(64, 12);
            this.위치IB.TabIndex = 0;
            this.위치IB.Text = "자재그룹ID";
            // 
            // txt자재그룹ID
            // 
            this.txt자재그룹ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt자재그룹ID.Location = new System.Drawing.Point(125, 139);
            this.txt자재그룹ID.Name = "txt자재그룹ID";
            this.txt자재그룹ID.Size = new System.Drawing.Size(100, 21);
            this.txt자재그룹ID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "자재기준단위";
            // 
            // txt자재기준단위
            // 
            this.txt자재기준단위.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt자재기준단위.Location = new System.Drawing.Point(365, 139);
            this.txt자재기준단위.Name = "txt자재기준단위";
            this.txt자재기준단위.Size = new System.Drawing.Size(100, 21);
            this.txt자재기준단위.TabIndex = 2;
            // 
            // lb이동위치
            // 
            this.lb이동위치.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb이동위치.AutoSize = true;
            this.lb이동위치.Location = new System.Drawing.Point(23, 25);
            this.lb이동위치.Name = "lb이동위치";
            this.lb이동위치.Size = new System.Drawing.Size(53, 12);
            this.lb이동위치.TabIndex = 3;
            this.lb이동위치.Text = "이동위치";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.lb이동위치, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.cbo이동위치, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(480, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(577, 63);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // cbo이동위치
            // 
            this.cbo이동위치.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbo이동위치.FormattingEnabled = true;
            this.cbo이동위치.Location = new System.Drawing.Point(103, 21);
            this.cbo이동위치.Name = "cbo이동위치";
            this.cbo이동위치.Size = new System.Drawing.Size(121, 20);
            this.cbo이동위치.TabIndex = 4;
            // 
            // 자재등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 603);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "자재등록";
            this.Text = "자재등록";
            this.Controls.SetChildIndex(this.tableLayoutPanel3, 0);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.자재등록표)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label 자재LOTIB;
        private System.Windows.Forms.Label 공급사IB;
        private System.Windows.Forms.Label 위치IB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt자재코드ID;
        private System.Windows.Forms.TextBox txt자재코드명;
        private System.Windows.Forms.TextBox txt자재코드타입;
        private System.Windows.Forms.TextBox txt자재기준수량;
        private System.Windows.Forms.TextBox txt자재기준단위;
        private System.Windows.Forms.TextBox txt자재그룹ID;
        private DexGridView 자재등록표;
        private System.Windows.Forms.Label lb이동위치;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ComboBox cbo이동위치;
    }
}