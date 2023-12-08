
namespace DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.자재관리
{
    partial class 자재이동
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(자재이동));
            this.bottomtable = new System.Windows.Forms.TableLayoutPanel();
            this.toptable = new System.Windows.Forms.TableLayoutPanel();
            this.자재LOTLB = new System.Windows.Forms.Label();
            this.이동위치그룹LB = new System.Windows.Forms.Label();
            this.이동위치LB = new System.Windows.Forms.Label();
            this.이동위치그룹CBX = new System.Windows.Forms.ComboBox();
            this.이동위치CBX = new System.Windows.Forms.ComboBox();
            this.추가BT = new System.Windows.Forms.Button();
            this.Popup = new System.Windows.Forms.Button();
            this.자재LOTTXB = new System.Windows.Forms.TextBox();
            this.dataGridView = new DexCommonUtil.UI도구.사용자정의컨트롤.DexGridView();
            this.Btn자재이동 = new System.Windows.Forms.Button();
            this.bottomtable.SuspendLayout();
            this.toptable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bottomtable
            // 
            this.bottomtable.ColumnCount = 1;
            this.bottomtable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 925F));
            this.bottomtable.Controls.Add(this.toptable, 0, 0);
            this.bottomtable.Controls.Add(this.dataGridView, 0, 1);
            this.bottomtable.Controls.Add(this.Btn자재이동, 0, 2);
            this.bottomtable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomtable.Location = new System.Drawing.Point(0, 28);
            this.bottomtable.Margin = new System.Windows.Forms.Padding(0);
            this.bottomtable.Name = "bottomtable";
            this.bottomtable.RowCount = 3;
            this.bottomtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.bottomtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.bottomtable.Size = new System.Drawing.Size(927, 473);
            this.bottomtable.TabIndex = 4;
            // 
            // toptable
            // 
            this.toptable.ColumnCount = 8;
            this.toptable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.toptable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.toptable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.toptable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.toptable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.toptable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.toptable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.toptable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.toptable.Controls.Add(this.자재LOTLB, 0, 0);
            this.toptable.Controls.Add(this.이동위치그룹LB, 3, 0);
            this.toptable.Controls.Add(this.이동위치LB, 5, 0);
            this.toptable.Controls.Add(this.이동위치그룹CBX, 4, 0);
            this.toptable.Controls.Add(this.이동위치CBX, 6, 0);
            this.toptable.Controls.Add(this.추가BT, 7, 0);
            this.toptable.Controls.Add(this.Popup, 2, 0);
            this.toptable.Controls.Add(this.자재LOTTXB, 1, 0);
            this.toptable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toptable.Location = new System.Drawing.Point(0, 0);
            this.toptable.Margin = new System.Windows.Forms.Padding(0);
            this.toptable.Name = "toptable";
            this.toptable.RowCount = 2;
            this.toptable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.06306F));
            this.toptable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.93694F));
            this.toptable.Size = new System.Drawing.Size(927, 90);
            this.toptable.TabIndex = 0;
            // 
            // 자재LOTLB
            // 
            this.자재LOTLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.자재LOTLB.AutoSize = true;
            this.자재LOTLB.Location = new System.Drawing.Point(23, 22);
            this.자재LOTLB.Name = "자재LOTLB";
            this.자재LOTLB.Size = new System.Drawing.Size(53, 12);
            this.자재LOTLB.TabIndex = 1;
            this.자재LOTLB.Text = "자재LOT";
            // 
            // 이동위치그룹LB
            // 
            this.이동위치그룹LB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.이동위치그룹LB.AutoSize = true;
            this.이동위치그룹LB.Location = new System.Drawing.Point(271, 22);
            this.이동위치그룹LB.Name = "이동위치그룹LB";
            this.이동위치그룹LB.Size = new System.Drawing.Size(77, 12);
            this.이동위치그룹LB.TabIndex = 1;
            this.이동위치그룹LB.Text = "이동위치그룹";
            // 
            // 이동위치LB
            // 
            this.이동위치LB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.이동위치LB.AutoSize = true;
            this.이동위치LB.Location = new System.Drawing.Point(513, 22);
            this.이동위치LB.Name = "이동위치LB";
            this.이동위치LB.Size = new System.Drawing.Size(53, 12);
            this.이동위치LB.TabIndex = 1;
            this.이동위치LB.Text = "이동위치";
            // 
            // 이동위치그룹CBX
            // 
            this.이동위치그룹CBX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.이동위치그룹CBX.FormattingEnabled = true;
            this.이동위치그룹CBX.Location = new System.Drawing.Point(363, 18);
            this.이동위치그룹CBX.Name = "이동위치그룹CBX";
            this.이동위치그룹CBX.Size = new System.Drawing.Size(124, 20);
            this.이동위치그룹CBX.TabIndex = 2;
            // 
            // 이동위치CBX
            // 
            this.이동위치CBX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.이동위치CBX.FormattingEnabled = true;
            this.이동위치CBX.Location = new System.Drawing.Point(593, 18);
            this.이동위치CBX.Name = "이동위치CBX";
            this.이동위치CBX.Size = new System.Drawing.Size(124, 20);
            this.이동위치CBX.TabIndex = 2;
            // 
            // 추가BT
            // 
            this.추가BT.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.추가BT.Location = new System.Drawing.Point(852, 16);
            this.추가BT.Margin = new System.Windows.Forms.Padding(0);
            this.추가BT.Name = "추가BT";
            this.추가BT.Size = new System.Drawing.Size(75, 23);
            this.추가BT.TabIndex = 0;
            this.추가BT.Text = "추가";
            this.추가BT.UseVisualStyleBackColor = true;
            this.추가BT.Click += new System.EventHandler(this.추가BT_Click);
            // 
            // Popup
            // 
            this.Popup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Popup.Location = new System.Drawing.Point(230, 16);
            this.Popup.Margin = new System.Windows.Forms.Padding(0);
            this.Popup.Name = "Popup";
            this.Popup.Size = new System.Drawing.Size(30, 23);
            this.Popup.TabIndex = 3;
            this.Popup.Text = "Popup";
            this.Popup.UseVisualStyleBackColor = true;
            this.Popup.Click += new System.EventHandler(this.Popup_Click);
            // 
            // 자재LOTTXB
            // 
            this.자재LOTTXB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.자재LOTTXB.Location = new System.Drawing.Point(103, 17);
            this.자재LOTTXB.Name = "자재LOTTXB";
            this.자재LOTTXB.Size = new System.Drawing.Size(124, 21);
            this.자재LOTTXB.TabIndex = 4;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 93);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(921, 337);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.기본테이블명 = null;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // Btn자재이동
            // 
            this.Btn자재이동.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Btn자재이동.Location = new System.Drawing.Point(852, 441);
            this.Btn자재이동.Margin = new System.Windows.Forms.Padding(0);
            this.Btn자재이동.Name = "Btn자재이동";
            this.Btn자재이동.Size = new System.Drawing.Size(75, 23);
            this.Btn자재이동.TabIndex = 2;
            this.Btn자재이동.Text = "자재이동";
            this.Btn자재이동.UseVisualStyleBackColor = true;
            this.Btn자재이동.Click += new System.EventHandler(this.Btn자재이동_Click);
            // 
            // 자재이동
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 529);
            this.Controls.Add(this.bottomtable);
            this.Name = "자재이동";
            this.Text = "자재이동";
            this.Controls.SetChildIndex(this.bottomtable, 0);
            this.bottomtable.ResumeLayout(false);
            this.toptable.ResumeLayout(false);
            this.toptable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel bottomtable;
        private System.Windows.Forms.TableLayoutPanel toptable;
        private System.Windows.Forms.Label 자재LOTLB;
        private System.Windows.Forms.Label 이동위치그룹LB;
        private System.Windows.Forms.Label 이동위치LB;
        private System.Windows.Forms.ComboBox 이동위치그룹CBX;
        private System.Windows.Forms.ComboBox 이동위치CBX;
        private System.Windows.Forms.Button 추가BT;
        private System.Windows.Forms.Button Popup;
        private System.Windows.Forms.TextBox 자재LOTTXB;
        private DexCommonUtil.UI도구.사용자정의컨트롤.DexGridView dataGridView;
        private System.Windows.Forms.Button Btn자재이동;
    }
}