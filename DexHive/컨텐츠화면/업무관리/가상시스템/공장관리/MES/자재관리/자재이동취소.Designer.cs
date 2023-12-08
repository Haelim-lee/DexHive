
namespace DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.자재관리
{
    partial class 자재이동취소
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(자재이동취소));
            this.alltable = new System.Windows.Forms.TableLayoutPanel();
            this.toptable = new System.Windows.Forms.TableLayoutPanel();
            this.datetable = new System.Windows.Forms.TableLayoutPanel();
            this.기간중LB = new System.Windows.Forms.Label();
            this.dateTimestart = new System.Windows.Forms.DateTimePicker();
            this.dateTimeend = new System.Windows.Forms.DateTimePicker();
            this.기간LB = new System.Windows.Forms.Label();
            this.위치그룹LB = new System.Windows.Forms.Label();
            this.위치LB = new System.Windows.Forms.Label();
            this.자재LB = new System.Windows.Forms.Label();
            this.위치그룹CBO = new System.Windows.Forms.ComboBox();
            this.위치CBO = new System.Windows.Forms.ComboBox();
            this.자재TXB = new System.Windows.Forms.TextBox();
            this.dataGridView = new DexCommonUtil.UI도구.사용자정의컨트롤.DexGridView();
            this.BTN자재이동취소 = new System.Windows.Forms.Button();
            this.alltable.SuspendLayout();
            this.toptable.SuspendLayout();
            this.datetable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // alltable
            // 
            this.alltable.ColumnCount = 1;
            this.alltable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.alltable.Controls.Add(this.toptable, 0, 0);
            this.alltable.Controls.Add(this.dataGridView, 0, 1);
            this.alltable.Controls.Add(this.BTN자재이동취소, 0, 2);
            this.alltable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alltable.Location = new System.Drawing.Point(0, 28);
            this.alltable.Margin = new System.Windows.Forms.Padding(0);
            this.alltable.Name = "alltable";
            this.alltable.RowCount = 3;
            this.alltable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.alltable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.alltable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.alltable.Size = new System.Drawing.Size(834, 448);
            this.alltable.TabIndex = 3;
            // 
            // toptable
            // 
            this.toptable.ColumnCount = 6;
            this.toptable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.toptable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.toptable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.toptable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.toptable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.toptable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 274F));
            this.toptable.Controls.Add(this.datetable, 1, 0);
            this.toptable.Controls.Add(this.기간LB, 0, 0);
            this.toptable.Controls.Add(this.위치그룹LB, 0, 1);
            this.toptable.Controls.Add(this.위치LB, 2, 1);
            this.toptable.Controls.Add(this.자재LB, 4, 1);
            this.toptable.Controls.Add(this.위치그룹CBO, 1, 1);
            this.toptable.Controls.Add(this.위치CBO, 3, 1);
            this.toptable.Controls.Add(this.자재TXB, 5, 1);
            this.toptable.Location = new System.Drawing.Point(0, 0);
            this.toptable.Margin = new System.Windows.Forms.Padding(0);
            this.toptable.Name = "toptable";
            this.toptable.RowCount = 2;
            this.toptable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.toptable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.toptable.Size = new System.Drawing.Size(834, 100);
            this.toptable.TabIndex = 0;
            // 
            // datetable
            // 
            this.datetable.ColumnCount = 3;
            this.toptable.SetColumnSpan(this.datetable, 3);
            this.datetable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.datetable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.datetable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.datetable.Controls.Add(this.기간중LB, 1, 0);
            this.datetable.Controls.Add(this.dateTimestart, 0, 0);
            this.datetable.Controls.Add(this.dateTimeend, 2, 0);
            this.datetable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datetable.Location = new System.Drawing.Point(100, 0);
            this.datetable.Margin = new System.Windows.Forms.Padding(0);
            this.datetable.Name = "datetable";
            this.datetable.RowCount = 1;
            this.datetable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.datetable.Size = new System.Drawing.Size(360, 50);
            this.datetable.TabIndex = 0;
            // 
            // 기간중LB
            // 
            this.기간중LB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.기간중LB.AutoSize = true;
            this.기간중LB.Location = new System.Drawing.Point(163, 19);
            this.기간중LB.Name = "기간중LB";
            this.기간중LB.Size = new System.Drawing.Size(14, 12);
            this.기간중LB.TabIndex = 1;
            this.기간중LB.Text = "~";
            // 
            // dateTimestart
            // 
            this.dateTimestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimestart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimestart.Location = new System.Drawing.Point(3, 14);
            this.dateTimestart.Name = "dateTimestart";
            this.dateTimestart.Size = new System.Drawing.Size(144, 21);
            this.dateTimestart.TabIndex = 2;
            // 
            // dateTimeend
            // 
            this.dateTimeend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeend.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeend.Location = new System.Drawing.Point(193, 14);
            this.dateTimeend.Name = "dateTimeend";
            this.dateTimeend.Size = new System.Drawing.Size(164, 21);
            this.dateTimeend.TabIndex = 2;
            // 
            // 기간LB
            // 
            this.기간LB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.기간LB.AutoSize = true;
            this.기간LB.Location = new System.Drawing.Point(35, 19);
            this.기간LB.Name = "기간LB";
            this.기간LB.Size = new System.Drawing.Size(29, 12);
            this.기간LB.TabIndex = 1;
            this.기간LB.Text = "기간";
            // 
            // 위치그룹LB
            // 
            this.위치그룹LB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.위치그룹LB.AutoSize = true;
            this.위치그룹LB.Location = new System.Drawing.Point(23, 69);
            this.위치그룹LB.Name = "위치그룹LB";
            this.위치그룹LB.Size = new System.Drawing.Size(53, 12);
            this.위치그룹LB.TabIndex = 1;
            this.위치그룹LB.Text = "위치그룹";
            // 
            // 위치LB
            // 
            this.위치LB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.위치LB.AutoSize = true;
            this.위치LB.Location = new System.Drawing.Point(265, 69);
            this.위치LB.Name = "위치LB";
            this.위치LB.Size = new System.Drawing.Size(29, 12);
            this.위치LB.TabIndex = 1;
            this.위치LB.Text = "위치";
            // 
            // 자재LB
            // 
            this.자재LB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.자재LB.AutoSize = true;
            this.자재LB.Location = new System.Drawing.Point(495, 69);
            this.자재LB.Name = "자재LB";
            this.자재LB.Size = new System.Drawing.Size(29, 12);
            this.자재LB.TabIndex = 1;
            this.자재LB.Text = "자재";
            // 
            // 위치그룹CBO
            // 
            this.위치그룹CBO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.위치그룹CBO.FormattingEnabled = true;
            this.위치그룹CBO.Location = new System.Drawing.Point(103, 65);
            this.위치그룹CBO.Name = "위치그룹CBO";
            this.위치그룹CBO.Size = new System.Drawing.Size(124, 20);
            this.위치그룹CBO.TabIndex = 2;
            // 
            // 위치CBO
            // 
            this.위치CBO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.위치CBO.FormattingEnabled = true;
            this.위치CBO.Location = new System.Drawing.Point(333, 65);
            this.위치CBO.Name = "위치CBO";
            this.위치CBO.Size = new System.Drawing.Size(124, 20);
            this.위치CBO.TabIndex = 2;
            // 
            // 자재TXB
            // 
            this.자재TXB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.자재TXB.Location = new System.Drawing.Point(560, 64);
            this.자재TXB.Margin = new System.Windows.Forms.Padding(0);
            this.자재TXB.Name = "자재TXB";
            this.자재TXB.Size = new System.Drawing.Size(194, 21);
            this.자재TXB.TabIndex = 3;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 100);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(834, 308);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.기본테이블명 = null;
            // 
            // BTN자재이동취소
            // 
            this.BTN자재이동취소.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN자재이동취소.Location = new System.Drawing.Point(734, 416);
            this.BTN자재이동취소.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.BTN자재이동취소.Name = "BTN자재이동취소";
            this.BTN자재이동취소.Size = new System.Drawing.Size(100, 23);
            this.BTN자재이동취소.TabIndex = 2;
            this.BTN자재이동취소.Text = "자재이동취소";
            this.BTN자재이동취소.UseVisualStyleBackColor = true;
            this.BTN자재이동취소.Click += new System.EventHandler(this.BTN자재이동취소_Click);
            // 
            // 자재이동취소
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 504);
            this.Controls.Add(this.alltable);
            this.Name = "자재이동취소";
            this.Text = "자재이동취소";
            this.Controls.SetChildIndex(this.alltable, 0);
            this.alltable.ResumeLayout(false);
            this.toptable.ResumeLayout(false);
            this.toptable.PerformLayout();
            this.datetable.ResumeLayout(false);
            this.datetable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel alltable;
        private System.Windows.Forms.TableLayoutPanel toptable;
        private System.Windows.Forms.TableLayoutPanel datetable;
        private System.Windows.Forms.Label 기간LB;
        private System.Windows.Forms.Label 위치그룹LB;
        private System.Windows.Forms.Label 위치LB;
        private System.Windows.Forms.Label 자재LB;
        private System.Windows.Forms.Label 기간중LB;
        private System.Windows.Forms.DateTimePicker dateTimestart;
        private System.Windows.Forms.DateTimePicker dateTimeend;
        private System.Windows.Forms.ComboBox 위치그룹CBO;
        private System.Windows.Forms.ComboBox 위치CBO;
        private System.Windows.Forms.TextBox 자재TXB;
        private DexCommonUtil.UI도구.사용자정의컨트롤.DexGridView dataGridView;
        private System.Windows.Forms.Button BTN자재이동취소;
    }
}