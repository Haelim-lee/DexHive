
namespace DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.품질관리.반제품_품질검사
{
    partial class 반제품_품질검사
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(반제품_품질검사));
            this.Alltable = new System.Windows.Forms.TableLayoutPanel();
            this.메인그리드 = new DexCommonUtil.UI도구.사용자정의컨트롤.DexGridView();
            this.toptable = new System.Windows.Forms.TableLayoutPanel();
            this.LB제품구분 = new System.Windows.Forms.Label();
            this.LB설비 = new System.Windows.Forms.Label();
            this.LB반제품 = new System.Windows.Forms.Label();
            this.CBO제품구분 = new System.Windows.Forms.ComboBox();
            this.CBO설비 = new System.Windows.Forms.ComboBox();
            this.CBO반제품 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.LB물성검사입력 = new System.Windows.Forms.Label();
            this.물성검사입력그리드 = new DexCommonUtil.UI도구.사용자정의컨트롤.DexGridView();
            this.물성검사이력그리드 = new DexCommonUtil.UI도구.사용자정의컨트롤.DexGridView();
            this.BTN특채 = new System.Windows.Forms.Button();
            this.BTN판정 = new System.Windows.Forms.Button();
            this.LB물성검사이력 = new System.Windows.Forms.Label();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.Grouptable = new System.Windows.Forms.TableLayoutPanel();
            this.LB설비2 = new System.Windows.Forms.Label();
            this.LBLOTID = new System.Windows.Forms.Label();
            this.LB생산계획타입 = new System.Windows.Forms.Label();
            this.LB생산계획오더 = new System.Windows.Forms.Label();
            this.LB반제품명 = new System.Windows.Forms.Label();
            this.LB수량 = new System.Windows.Forms.Label();
            this.TXB설비 = new System.Windows.Forms.TextBox();
            this.TXBLOTID = new System.Windows.Forms.TextBox();
            this.TXB생산계획타입 = new System.Windows.Forms.TextBox();
            this.TXB생산계획오더 = new System.Windows.Forms.TextBox();
            this.TXB반제품명 = new System.Windows.Forms.TextBox();
            this.TXBQTY = new System.Windows.Forms.TextBox();
            this.TXBQTY2 = new System.Windows.Forms.TextBox();
            this.Alltable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.메인그리드)).BeginInit();
            this.toptable.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.물성검사입력그리드)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.물성검사이력그리드)).BeginInit();
            this.GroupBox.SuspendLayout();
            this.Grouptable.SuspendLayout();
            this.SuspendLayout();
            // 
            // Alltable
            // 
            this.Alltable.ColumnCount = 1;
            this.Alltable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Alltable.Controls.Add(this.메인그리드, 0, 1);
            this.Alltable.Controls.Add(this.toptable, 0, 0);
            this.Alltable.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.Alltable.Controls.Add(this.GroupBox, 0, 2);
            this.Alltable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Alltable.Location = new System.Drawing.Point(0, 28);
            this.Alltable.Name = "Alltable";
            this.Alltable.RowCount = 4;
            this.Alltable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.Alltable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Alltable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.Alltable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Alltable.Size = new System.Drawing.Size(1039, 606);
            this.Alltable.TabIndex = 0;
            // 
            // 메인그리드
            // 
            this.메인그리드.AllowUserToAddRows = false;
            this.메인그리드.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.메인그리드.Dock = System.Windows.Forms.DockStyle.Fill;
            this.메인그리드.Location = new System.Drawing.Point(0, 80);
            this.메인그리드.Margin = new System.Windows.Forms.Padding(0);
            this.메인그리드.Name = "메인그리드";
            this.메인그리드.RowTemplate.Height = 23;
            this.메인그리드.Size = new System.Drawing.Size(1039, 213);
            this.메인그리드.TabIndex = 0;
            this.메인그리드.기본테이블명 = null;
            // 
            // toptable
            // 
            this.toptable.ColumnCount = 6;
            this.toptable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.toptable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.toptable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.toptable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.toptable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.toptable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 379F));
            this.toptable.Controls.Add(this.LB제품구분, 0, 1);
            this.toptable.Controls.Add(this.LB설비, 2, 1);
            this.toptable.Controls.Add(this.LB반제품, 4, 1);
            this.toptable.Controls.Add(this.CBO제품구분, 1, 1);
            this.toptable.Controls.Add(this.CBO설비, 3, 1);
            this.toptable.Controls.Add(this.CBO반제품, 5, 1);
            this.toptable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toptable.Location = new System.Drawing.Point(0, 0);
            this.toptable.Margin = new System.Windows.Forms.Padding(0);
            this.toptable.Name = "toptable";
            this.toptable.RowCount = 2;
            this.toptable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.toptable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.toptable.Size = new System.Drawing.Size(1039, 80);
            this.toptable.TabIndex = 1;
            // 
            // LB제품구분
            // 
            this.LB제품구분.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB제품구분.AutoSize = true;
            this.LB제품구분.Location = new System.Drawing.Point(33, 54);
            this.LB제품구분.Name = "LB제품구분";
            this.LB제품구분.Size = new System.Drawing.Size(53, 12);
            this.LB제품구분.TabIndex = 0;
            this.LB제품구분.Text = "제품구분";
            // 
            // LB설비
            // 
            this.LB설비.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB설비.AutoSize = true;
            this.LB설비.Location = new System.Drawing.Point(315, 54);
            this.LB설비.Name = "LB설비";
            this.LB설비.Size = new System.Drawing.Size(29, 12);
            this.LB설비.TabIndex = 0;
            this.LB설비.Text = "설비";
            // 
            // LB반제품
            // 
            this.LB반제품.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB반제품.AutoSize = true;
            this.LB반제품.Location = new System.Drawing.Point(579, 54);
            this.LB반제품.Name = "LB반제품";
            this.LB반제품.Size = new System.Drawing.Size(41, 12);
            this.LB반제품.TabIndex = 0;
            this.LB반제품.Text = "반제품";
            // 
            // CBO제품구분
            // 
            this.CBO제품구분.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CBO제품구분.FormattingEnabled = true;
            this.CBO제품구분.Location = new System.Drawing.Point(123, 50);
            this.CBO제품구분.Name = "CBO제품구분";
            this.CBO제품구분.Size = new System.Drawing.Size(121, 20);
            this.CBO제품구분.TabIndex = 2;
            // 
            // CBO설비
            // 
            this.CBO설비.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CBO설비.FormattingEnabled = true;
            this.CBO설비.Location = new System.Drawing.Point(393, 50);
            this.CBO설비.Name = "CBO설비";
            this.CBO설비.Size = new System.Drawing.Size(121, 20);
            this.CBO설비.TabIndex = 2;
            // 
            // CBO반제품
            // 
            this.CBO반제품.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CBO반제품.FormattingEnabled = true;
            this.CBO반제품.Location = new System.Drawing.Point(663, 50);
            this.CBO반제품.Name = "CBO반제품";
            this.CBO반제품.Size = new System.Drawing.Size(121, 20);
            this.CBO반제품.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 469F));
            this.tableLayoutPanel3.Controls.Add(this.LB물성검사입력, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.물성검사입력그리드, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.물성검사이력그리드, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.BTN특채, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.BTN판정, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.LB물성검사이력, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 393);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1039, 213);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // LB물성검사입력
            // 
            this.LB물성검사입력.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LB물성검사입력.AutoSize = true;
            this.LB물성검사입력.Location = new System.Drawing.Point(3, 14);
            this.LB물성검사입력.Name = "LB물성검사입력";
            this.LB물성검사입력.Size = new System.Drawing.Size(77, 12);
            this.LB물성검사입력.TabIndex = 0;
            this.LB물성검사입력.Text = "물성검사입력";
            // 
            // 물성검사입력그리드
            // 
            this.물성검사입력그리드.AllowUserToAddRows = false;
            this.물성검사입력그리드.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel3.SetColumnSpan(this.물성검사입력그리드, 2);
            this.물성검사입력그리드.Dock = System.Windows.Forms.DockStyle.Fill;
            this.물성검사입력그리드.Location = new System.Drawing.Point(0, 40);
            this.물성검사입력그리드.Margin = new System.Windows.Forms.Padding(0);
            this.물성검사입력그리드.Name = "물성검사입력그리드";
            this.물성검사입력그리드.RowTemplate.Height = 23;
            this.물성검사입력그리드.Size = new System.Drawing.Size(380, 300);
            this.물성검사입력그리드.TabIndex = 0;
            this.물성검사입력그리드.기본테이블명 = null;
            // 
            // 물성검사이력그리드
            // 
            this.물성검사이력그리드.AllowUserToAddRows = false;
            this.물성검사이력그리드.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel3.SetColumnSpan(this.물성검사이력그리드, 2);
            this.물성검사이력그리드.Dock = System.Windows.Forms.DockStyle.Fill;
            this.물성검사이력그리드.Location = new System.Drawing.Point(390, 40);
            this.물성검사이력그리드.Margin = new System.Windows.Forms.Padding(0);
            this.물성검사이력그리드.Name = "물성검사이력그리드";
            this.물성검사이력그리드.RowTemplate.Height = 23;
            this.물성검사이력그리드.Size = new System.Drawing.Size(649, 300);
            this.물성검사이력그리드.TabIndex = 1;
            this.물성검사이력그리드.기본테이블명 = null;
            // 
            // BTN특채
            // 
            this.BTN특채.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN특채.Location = new System.Drawing.Point(961, 8);
            this.BTN특채.Name = "BTN특채";
            this.BTN특채.Size = new System.Drawing.Size(75, 23);
            this.BTN특채.TabIndex = 1;
            this.BTN특채.Text = "특채";
            this.BTN특채.UseVisualStyleBackColor = true;
            // 
            // BTN판정
            // 
            this.BTN판정.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN판정.Location = new System.Drawing.Point(302, 8);
            this.BTN판정.Name = "BTN판정";
            this.BTN판정.Size = new System.Drawing.Size(75, 23);
            this.BTN판정.TabIndex = 1;
            this.BTN판정.Text = "판정";
            this.BTN판정.UseVisualStyleBackColor = true;
            // 
            // LB물성검사이력
            // 
            this.LB물성검사이력.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LB물성검사이력.AutoSize = true;
            this.LB물성검사이력.Location = new System.Drawing.Point(393, 14);
            this.LB물성검사이력.Name = "LB물성검사이력";
            this.LB물성검사이력.Size = new System.Drawing.Size(77, 12);
            this.LB물성검사이력.TabIndex = 0;
            this.LB물성검사이력.Text = "물성검사이력";
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.Grouptable);
            this.GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox.Location = new System.Drawing.Point(3, 296);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(1033, 94);
            this.GroupBox.TabIndex = 4;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "LOT정보";
            // 
            // Grouptable
            // 
            this.Grouptable.ColumnCount = 7;
            this.Grouptable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.Grouptable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.Grouptable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.Grouptable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.Grouptable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.Grouptable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.Grouptable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 227F));
            this.Grouptable.Controls.Add(this.LB설비2, 0, 0);
            this.Grouptable.Controls.Add(this.LBLOTID, 0, 1);
            this.Grouptable.Controls.Add(this.LB생산계획타입, 2, 1);
            this.Grouptable.Controls.Add(this.LB생산계획오더, 2, 0);
            this.Grouptable.Controls.Add(this.LB반제품명, 4, 0);
            this.Grouptable.Controls.Add(this.LB수량, 4, 1);
            this.Grouptable.Controls.Add(this.TXB설비, 1, 0);
            this.Grouptable.Controls.Add(this.TXBLOTID, 1, 1);
            this.Grouptable.Controls.Add(this.TXB생산계획타입, 3, 1);
            this.Grouptable.Controls.Add(this.TXB생산계획오더, 3, 0);
            this.Grouptable.Controls.Add(this.TXB반제품명, 5, 0);
            this.Grouptable.Controls.Add(this.TXBQTY, 5, 1);
            this.Grouptable.Controls.Add(this.TXBQTY2, 6, 1);
            this.Grouptable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grouptable.Location = new System.Drawing.Point(3, 17);
            this.Grouptable.Margin = new System.Windows.Forms.Padding(0);
            this.Grouptable.Name = "Grouptable";
            this.Grouptable.RowCount = 2;
            this.Grouptable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Grouptable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Grouptable.Size = new System.Drawing.Size(1027, 74);
            this.Grouptable.TabIndex = 4;
            // 
            // LB설비2
            // 
            this.LB설비2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB설비2.AutoSize = true;
            this.LB설비2.Location = new System.Drawing.Point(45, 12);
            this.LB설비2.Name = "LB설비2";
            this.LB설비2.Size = new System.Drawing.Size(29, 12);
            this.LB설비2.TabIndex = 0;
            this.LB설비2.Text = "설비";
            // 
            // LBLOTID
            // 
            this.LBLOTID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBLOTID.AutoSize = true;
            this.LBLOTID.Location = new System.Drawing.Point(40, 49);
            this.LBLOTID.Name = "LBLOTID";
            this.LBLOTID.Size = new System.Drawing.Size(40, 12);
            this.LBLOTID.TabIndex = 0;
            this.LBLOTID.Text = "LOTID";
            // 
            // LB생산계획타입
            // 
            this.LB생산계획타입.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB생산계획타입.AutoSize = true;
            this.LB생산계획타입.Location = new System.Drawing.Point(311, 49);
            this.LB생산계획타입.Name = "LB생산계획타입";
            this.LB생산계획타입.Size = new System.Drawing.Size(77, 12);
            this.LB생산계획타입.TabIndex = 0;
            this.LB생산계획타입.Text = "생산계획타입";
            // 
            // LB생산계획오더
            // 
            this.LB생산계획오더.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB생산계획오더.AutoSize = true;
            this.LB생산계획오더.Location = new System.Drawing.Point(311, 12);
            this.LB생산계획오더.Name = "LB생산계획오더";
            this.LB생산계획오더.Size = new System.Drawing.Size(77, 12);
            this.LB생산계획오더.TabIndex = 0;
            this.LB생산계획오더.Text = "생산계획오더";
            // 
            // LB반제품명
            // 
            this.LB반제품명.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB반제품명.AutoSize = true;
            this.LB반제품명.Location = new System.Drawing.Point(613, 12);
            this.LB반제품명.Name = "LB반제품명";
            this.LB반제품명.Size = new System.Drawing.Size(53, 12);
            this.LB반제품명.TabIndex = 0;
            this.LB반제품명.Text = "반제품명";
            // 
            // LB수량
            // 
            this.LB수량.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB수량.AutoSize = true;
            this.LB수량.Location = new System.Drawing.Point(625, 49);
            this.LB수량.Name = "LB수량";
            this.LB수량.Size = new System.Drawing.Size(29, 12);
            this.LB수량.TabIndex = 0;
            this.LB수량.Text = "수량";
            // 
            // TXB설비
            // 
            this.TXB설비.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TXB설비.Location = new System.Drawing.Point(123, 8);
            this.TXB설비.Name = "TXB설비";
            this.TXB설비.ReadOnly = true;
            this.TXB설비.Size = new System.Drawing.Size(100, 21);
            this.TXB설비.TabIndex = 1;
            // 
            // TXBLOTID
            // 
            this.TXBLOTID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TXBLOTID.Location = new System.Drawing.Point(123, 45);
            this.TXBLOTID.Name = "TXBLOTID";
            this.TXBLOTID.ReadOnly = true;
            this.TXBLOTID.Size = new System.Drawing.Size(100, 21);
            this.TXBLOTID.TabIndex = 1;
            // 
            // TXB생산계획타입
            // 
            this.TXB생산계획타입.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TXB생산계획타입.Location = new System.Drawing.Point(413, 45);
            this.TXB생산계획타입.Name = "TXB생산계획타입";
            this.TXB생산계획타입.ReadOnly = true;
            this.TXB생산계획타입.Size = new System.Drawing.Size(100, 21);
            this.TXB생산계획타입.TabIndex = 1;
            // 
            // TXB생산계획오더
            // 
            this.TXB생산계획오더.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TXB생산계획오더.Location = new System.Drawing.Point(413, 8);
            this.TXB생산계획오더.Name = "TXB생산계획오더";
            this.TXB생산계획오더.ReadOnly = true;
            this.TXB생산계획오더.Size = new System.Drawing.Size(100, 21);
            this.TXB생산계획오더.TabIndex = 1;
            // 
            // TXB반제품명
            // 
            this.TXB반제품명.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Grouptable.SetColumnSpan(this.TXB반제품명, 2);
            this.TXB반제품명.Location = new System.Drawing.Point(703, 8);
            this.TXB반제품명.Name = "TXB반제품명";
            this.TXB반제품명.ReadOnly = true;
            this.TXB반제품명.Size = new System.Drawing.Size(321, 21);
            this.TXB반제품명.TabIndex = 1;
            // 
            // TXBQTY
            // 
            this.TXBQTY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TXBQTY.Location = new System.Drawing.Point(703, 45);
            this.TXBQTY.Name = "TXBQTY";
            this.TXBQTY.ReadOnly = true;
            this.TXBQTY.Size = new System.Drawing.Size(94, 21);
            this.TXBQTY.TabIndex = 1;
            // 
            // TXBQTY2
            // 
            this.TXBQTY2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TXBQTY2.Location = new System.Drawing.Point(803, 45);
            this.TXBQTY2.Name = "TXBQTY2";
            this.TXBQTY2.ReadOnly = true;
            this.TXBQTY2.Size = new System.Drawing.Size(94, 21);
            this.TXBQTY2.TabIndex = 1;
            // 
            // 반제품_품질검사
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 662);
            this.Controls.Add(this.Alltable);
            this.Name = "반제품_품질검사";
            this.Text = "반제품_품질검사";
            this.Controls.SetChildIndex(this.Alltable, 0);
            this.Alltable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.메인그리드)).EndInit();
            this.toptable.ResumeLayout(false);
            this.toptable.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.물성검사입력그리드)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.물성검사이력그리드)).EndInit();
            this.GroupBox.ResumeLayout(false);
            this.Grouptable.ResumeLayout(false);
            this.Grouptable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Alltable;
        private DexCommonUtil.UI도구.사용자정의컨트롤.DexGridView 메인그리드;
        private System.Windows.Forms.TableLayoutPanel toptable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DexCommonUtil.UI도구.사용자정의컨트롤.DexGridView 물성검사입력그리드;
        private DexCommonUtil.UI도구.사용자정의컨트롤.DexGridView 물성검사이력그리드;
        private System.Windows.Forms.Label LB제품구분;
        private System.Windows.Forms.Label LB설비;
        private System.Windows.Forms.Label LB반제품;
        private System.Windows.Forms.Button BTN특채;
        private System.Windows.Forms.Button BTN판정;
        private System.Windows.Forms.ComboBox CBO제품구분;
        private System.Windows.Forms.ComboBox CBO설비;
        private System.Windows.Forms.ComboBox CBO반제품;
        private System.Windows.Forms.Label LB물성검사입력;
        private System.Windows.Forms.Label LB물성검사이력;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.TableLayoutPanel Grouptable;
        private System.Windows.Forms.Label LB설비2;
        private System.Windows.Forms.Label LBLOTID;
        private System.Windows.Forms.Label LB생산계획타입;
        private System.Windows.Forms.Label LB생산계획오더;
        private System.Windows.Forms.Label LB반제품명;
        private System.Windows.Forms.Label LB수량;
        private System.Windows.Forms.TextBox TXB설비;
        private System.Windows.Forms.TextBox TXBLOTID;
        private System.Windows.Forms.TextBox TXB생산계획타입;
        private System.Windows.Forms.TextBox TXB생산계획오더;
        private System.Windows.Forms.TextBox TXB반제품명;
        private System.Windows.Forms.TextBox TXBQTY;
        private System.Windows.Forms.TextBox TXBQTY2;
    }
}