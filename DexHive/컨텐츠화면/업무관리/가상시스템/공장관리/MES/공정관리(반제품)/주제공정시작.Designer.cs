
namespace DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.공정관리_반제품_
{
    partial class 주제공정시작
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(주제공정시작));
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.LOT정보그리드 = new DexCommonUtil.UI도구.사용자정의컨트롤.DexGridView();
            this.SearchPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LOT진행상태LB = new System.Windows.Forms.Label();
            this.ProductiontypeLB = new System.Windows.Forms.Label();
            this.DateTable = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.기간중 = new System.Windows.Forms.Label();
            this.ProductionorderLB = new System.Windows.Forms.Label();
            this.DateTimeLB = new System.Windows.Forms.Label();
            this.ProductionorderTXB = new System.Windows.Forms.TextBox();
            this.ProductiontypeCBX = new System.Windows.Forms.ComboBox();
            this.제품LB = new System.Windows.Forms.Label();
            this.제품CBX = new System.Windows.Forms.ComboBox();
            this.LOT진행상태CBX = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FullTable = new System.Windows.Forms.TableLayoutPanel();
            this.생산LOTLB = new System.Windows.Forms.Label();
            this.LOTProgressLB = new System.Windows.Forms.Label();
            this.투입수량LB = new System.Windows.Forms.Label();
            this.투입일시LB = new System.Windows.Forms.Label();
            this.투입설비LB = new System.Windows.Forms.Label();
            this.생산LOTTXB = new System.Windows.Forms.TextBox();
            this.LOTProgressTXB = new System.Windows.Forms.TextBox();
            this.KGLB = new System.Windows.Forms.Label();
            this.투입설비CBX = new System.Windows.Forms.ComboBox();
            this.투입수량nud = new System.Windows.Forms.NumericUpDown();
            this.투입일시Dtp = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn자동투입 = new System.Windows.Forms.Button();
            this.자재LOT정보BTN = new System.Windows.Forms.Button();
            this.BOMBTN = new System.Windows.Forms.Button();
            this.LOT목록그리드 = new DexCommonUtil.UI도구.사용자정의컨트롤.DexGridView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn투입취소 = new System.Windows.Forms.Button();
            this.Btn투입 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LOT정보그리드)).BeginInit();
            this.SearchPanel.SuspendLayout();
            this.DateTable.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.FullTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.투입수량nud)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LOT목록그리드)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.LOT정보그리드, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.SearchPanel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.LOT목록그리드, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 5);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1254, 845);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // LOT정보그리드
            // 
            this.LOT정보그리드.AllowUserToAddRows = false;
            this.LOT정보그리드.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LOT정보그리드.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LOT정보그리드.Location = new System.Drawing.Point(3, 523);
            this.LOT정보그리드.Name = "LOT정보그리드";
            this.LOT정보그리드.RowTemplate.Height = 23;
            this.LOT정보그리드.Size = new System.Drawing.Size(1248, 274);
            this.LOT정보그리드.TabIndex = 9;
            this.LOT정보그리드.기본테이블명 = null;
            // 
            // SearchPanel
            // 
            this.SearchPanel.ColumnCount = 9;
            this.SearchPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.SearchPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.SearchPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.SearchPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.SearchPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.SearchPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.SearchPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.SearchPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.SearchPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 439F));
            this.SearchPanel.Controls.Add(this.LOT진행상태LB, 3, 2);
            this.SearchPanel.Controls.Add(this.ProductiontypeLB, 3, 1);
            this.SearchPanel.Controls.Add(this.DateTable, 1, 0);
            this.SearchPanel.Controls.Add(this.ProductionorderLB, 0, 1);
            this.SearchPanel.Controls.Add(this.DateTimeLB, 0, 0);
            this.SearchPanel.Controls.Add(this.ProductionorderTXB, 1, 1);
            this.SearchPanel.Controls.Add(this.ProductiontypeCBX, 4, 1);
            this.SearchPanel.Controls.Add(this.제품LB, 0, 2);
            this.SearchPanel.Controls.Add(this.제품CBX, 1, 2);
            this.SearchPanel.Controls.Add(this.LOT진행상태CBX, 4, 2);
            this.SearchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchPanel.Location = new System.Drawing.Point(0, 0);
            this.SearchPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.RowCount = 4;
            this.SearchPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.SearchPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.SearchPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.SearchPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.SearchPanel.Size = new System.Drawing.Size(1254, 90);
            this.SearchPanel.TabIndex = 5;
            // 
            // LOT진행상태LB
            // 
            this.LOT진행상태LB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LOT진행상태LB.AutoSize = true;
            this.LOT진행상태LB.Location = new System.Drawing.Point(333, 69);
            this.LOT진행상태LB.Name = "LOT진행상태LB";
            this.LOT진행상태LB.Size = new System.Drawing.Size(77, 12);
            this.LOT진행상태LB.TabIndex = 0;
            this.LOT진행상태LB.Text = "LOT진행상태";
            // 
            // ProductiontypeLB
            // 
            this.ProductiontypeLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductiontypeLB.AutoSize = true;
            this.ProductiontypeLB.Location = new System.Drawing.Point(333, 39);
            this.ProductiontypeLB.Name = "ProductiontypeLB";
            this.ProductiontypeLB.Size = new System.Drawing.Size(77, 12);
            this.ProductiontypeLB.TabIndex = 0;
            this.ProductiontypeLB.Text = "생산계획타입";
            // 
            // DateTable
            // 
            this.DateTable.ColumnCount = 3;
            this.SearchPanel.SetColumnSpan(this.DateTable, 4);
            this.DateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.DateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.DateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DateTable.Controls.Add(this.dateTimeStart, 0, 0);
            this.DateTable.Controls.Add(this.dateTimeEnd, 2, 0);
            this.DateTable.Controls.Add(this.기간중, 1, 0);
            this.DateTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateTable.Location = new System.Drawing.Point(120, 0);
            this.DateTable.Margin = new System.Windows.Forms.Padding(0);
            this.DateTable.Name = "DateTable";
            this.DateTable.RowCount = 1;
            this.DateTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DateTable.Size = new System.Drawing.Size(477, 30);
            this.DateTable.TabIndex = 5;
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeStart.Location = new System.Drawing.Point(3, 4);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(163, 21);
            this.dateTimeStart.TabIndex = 2;
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimeEnd.Location = new System.Drawing.Point(193, 4);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(165, 21);
            this.dateTimeEnd.TabIndex = 3;
            // 
            // 기간중
            // 
            this.기간중.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.기간중.AutoSize = true;
            this.기간중.Location = new System.Drawing.Point(172, 9);
            this.기간중.Name = "기간중";
            this.기간중.Size = new System.Drawing.Size(14, 12);
            this.기간중.TabIndex = 0;
            this.기간중.Text = "~";
            // 
            // ProductionorderLB
            // 
            this.ProductionorderLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductionorderLB.AutoSize = true;
            this.ProductionorderLB.Location = new System.Drawing.Point(21, 39);
            this.ProductionorderLB.Name = "ProductionorderLB";
            this.ProductionorderLB.Size = new System.Drawing.Size(77, 12);
            this.ProductionorderLB.TabIndex = 0;
            this.ProductionorderLB.Text = "생산계획오더";
            // 
            // DateTimeLB
            // 
            this.DateTimeLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateTimeLB.AutoSize = true;
            this.DateTimeLB.Location = new System.Drawing.Point(45, 9);
            this.DateTimeLB.Name = "DateTimeLB";
            this.DateTimeLB.Size = new System.Drawing.Size(29, 12);
            this.DateTimeLB.TabIndex = 0;
            this.DateTimeLB.Text = "기간";
            // 
            // ProductionorderTXB
            // 
            this.ProductionorderTXB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductionorderTXB.Location = new System.Drawing.Point(123, 34);
            this.ProductionorderTXB.Name = "ProductionorderTXB";
            this.ProductionorderTXB.Size = new System.Drawing.Size(163, 21);
            this.ProductionorderTXB.TabIndex = 5;
            // 
            // ProductiontypeCBX
            // 
            this.ProductiontypeCBX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductiontypeCBX.FormattingEnabled = true;
            this.ProductiontypeCBX.Location = new System.Drawing.Point(437, 35);
            this.ProductiontypeCBX.Name = "ProductiontypeCBX";
            this.ProductiontypeCBX.Size = new System.Drawing.Size(157, 20);
            this.ProductiontypeCBX.TabIndex = 8;
            // 
            // 제품LB
            // 
            this.제품LB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.제품LB.AutoSize = true;
            this.제품LB.Location = new System.Drawing.Point(45, 69);
            this.제품LB.Name = "제품LB";
            this.제품LB.Size = new System.Drawing.Size(29, 12);
            this.제품LB.TabIndex = 0;
            this.제품LB.Text = "제품";
            // 
            // 제품CBX
            // 
            this.제품CBX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.제품CBX.FormattingEnabled = true;
            this.제품CBX.Location = new System.Drawing.Point(123, 65);
            this.제품CBX.Name = "제품CBX";
            this.제품CBX.Size = new System.Drawing.Size(163, 20);
            this.제품CBX.TabIndex = 7;
            // 
            // LOT진행상태CBX
            // 
            this.LOT진행상태CBX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LOT진행상태CBX.FormattingEnabled = true;
            this.LOT진행상태CBX.Location = new System.Drawing.Point(437, 65);
            this.LOT진행상태CBX.Name = "LOT진행상태CBX";
            this.LOT진행상태CBX.Size = new System.Drawing.Size(157, 20);
            this.LOT진행상태CBX.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FullTable);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(3, 373);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1248, 84);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOT정보";
            // 
            // FullTable
            // 
            this.FullTable.ColumnCount = 8;
            this.FullTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.FullTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.FullTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.FullTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.FullTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.FullTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.FullTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195F));
            this.FullTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 268F));
            this.FullTable.Controls.Add(this.생산LOTLB, 0, 0);
            this.FullTable.Controls.Add(this.LOTProgressLB, 2, 0);
            this.FullTable.Controls.Add(this.투입수량LB, 4, 0);
            this.FullTable.Controls.Add(this.투입일시LB, 2, 1);
            this.FullTable.Controls.Add(this.투입설비LB, 0, 1);
            this.FullTable.Controls.Add(this.생산LOTTXB, 1, 0);
            this.FullTable.Controls.Add(this.LOTProgressTXB, 3, 0);
            this.FullTable.Controls.Add(this.KGLB, 6, 0);
            this.FullTable.Controls.Add(this.투입설비CBX, 1, 1);
            this.FullTable.Controls.Add(this.투입수량nud, 5, 0);
            this.FullTable.Controls.Add(this.투입일시Dtp, 3, 1);
            this.FullTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FullTable.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FullTable.Location = new System.Drawing.Point(3, 17);
            this.FullTable.Margin = new System.Windows.Forms.Padding(0);
            this.FullTable.Name = "FullTable";
            this.FullTable.RowCount = 3;
            this.FullTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.FullTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.FullTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.FullTable.Size = new System.Drawing.Size(1242, 64);
            this.FullTable.TabIndex = 4;
            // 
            // 생산LOTLB
            // 
            this.생산LOTLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.생산LOTLB.AutoSize = true;
            this.생산LOTLB.Location = new System.Drawing.Point(33, 9);
            this.생산LOTLB.Name = "생산LOTLB";
            this.생산LOTLB.Size = new System.Drawing.Size(53, 12);
            this.생산LOTLB.TabIndex = 0;
            this.생산LOTLB.Text = "생산LOT";
            // 
            // LOTProgressLB
            // 
            this.LOTProgressLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LOTProgressLB.AutoSize = true;
            this.LOTProgressLB.Location = new System.Drawing.Point(311, 9);
            this.LOTProgressLB.Name = "LOTProgressLB";
            this.LOTProgressLB.Size = new System.Drawing.Size(77, 12);
            this.LOTProgressLB.TabIndex = 0;
            this.LOTProgressLB.Text = "LOT진행상태";
            // 
            // 투입수량LB
            // 
            this.투입수량LB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.투입수량LB.AutoSize = true;
            this.투입수량LB.Location = new System.Drawing.Point(613, 9);
            this.투입수량LB.Name = "투입수량LB";
            this.투입수량LB.Size = new System.Drawing.Size(53, 12);
            this.투입수량LB.TabIndex = 0;
            this.투입수량LB.Text = "투입수량";
            // 
            // 투입일시LB
            // 
            this.투입일시LB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.투입일시LB.AutoSize = true;
            this.투입일시LB.Location = new System.Drawing.Point(323, 39);
            this.투입일시LB.Name = "투입일시LB";
            this.투입일시LB.Size = new System.Drawing.Size(53, 12);
            this.투입일시LB.TabIndex = 0;
            this.투입일시LB.Text = "투입일시";
            // 
            // 투입설비LB
            // 
            this.투입설비LB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.투입설비LB.AutoSize = true;
            this.투입설비LB.Location = new System.Drawing.Point(33, 39);
            this.투입설비LB.Name = "투입설비LB";
            this.투입설비LB.Size = new System.Drawing.Size(53, 12);
            this.투입설비LB.TabIndex = 0;
            this.투입설비LB.Text = "투입설비";
            // 
            // 생산LOTTXB
            // 
            this.생산LOTTXB.AcceptsTab = true;
            this.생산LOTTXB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.생산LOTTXB.Location = new System.Drawing.Point(123, 3);
            this.생산LOTTXB.Name = "생산LOTTXB";
            this.생산LOTTXB.Size = new System.Drawing.Size(164, 21);
            this.생산LOTTXB.TabIndex = 5;
            // 
            // LOTProgressTXB
            // 
            this.LOTProgressTXB.AcceptsTab = true;
            this.LOTProgressTXB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LOTProgressTXB.Location = new System.Drawing.Point(413, 3);
            this.LOTProgressTXB.Name = "LOTProgressTXB";
            this.LOTProgressTXB.Size = new System.Drawing.Size(164, 21);
            this.LOTProgressTXB.TabIndex = 5;
            // 
            // KGLB
            // 
            this.KGLB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.KGLB.AutoSize = true;
            this.KGLB.Location = new System.Drawing.Point(798, 9);
            this.KGLB.Name = "KGLB";
            this.KGLB.Size = new System.Drawing.Size(22, 12);
            this.KGLB.TabIndex = 6;
            this.KGLB.Text = "KG";
            // 
            // 투입설비CBX
            // 
            this.투입설비CBX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.투입설비CBX.FormattingEnabled = true;
            this.투입설비CBX.Location = new System.Drawing.Point(123, 35);
            this.투입설비CBX.Name = "투입설비CBX";
            this.투입설비CBX.Size = new System.Drawing.Size(164, 20);
            this.투입설비CBX.TabIndex = 7;
            // 
            // 투입수량nud
            // 
            this.투입수량nud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.투입수량nud.Location = new System.Drawing.Point(703, 4);
            this.투입수량nud.Name = "투입수량nud";
            this.투입수량nud.Size = new System.Drawing.Size(89, 21);
            this.투입수량nud.TabIndex = 8;
            // 
            // 투입일시Dtp
            // 
            this.투입일시Dtp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.투입일시Dtp.Location = new System.Drawing.Point(413, 34);
            this.투입일시Dtp.Name = "투입일시Dtp";
            this.투입일시Dtp.Size = new System.Drawing.Size(164, 21);
            this.투입일시Dtp.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(3, 463);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1248, 54);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "입력정보";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 6;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel4.Controls.Add(this.btn자동투입, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.자재LOT정보BTN, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.BOMBTN, 5, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1242, 34);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // btn자동투입
            // 
            this.btn자동투입.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn자동투입.Location = new System.Drawing.Point(223, 5);
            this.btn자동투입.Name = "btn자동투입";
            this.btn자동투입.Size = new System.Drawing.Size(74, 23);
            this.btn자동투입.TabIndex = 8;
            this.btn자동투입.Text = "자동투입";
            this.btn자동투입.UseVisualStyleBackColor = true;
            // 
            // 자재LOT정보BTN
            // 
            this.자재LOT정보BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.자재LOT정보BTN.Location = new System.Drawing.Point(303, 5);
            this.자재LOT정보BTN.Name = "자재LOT정보BTN";
            this.자재LOT정보BTN.Size = new System.Drawing.Size(140, 23);
            this.자재LOT정보BTN.TabIndex = 8;
            this.자재LOT정보BTN.Text = "자재LOT 정보";
            this.자재LOT정보BTN.UseVisualStyleBackColor = true;
            this.자재LOT정보BTN.Click += new System.EventHandler(this.자재LOT정보BTN_Click);
            // 
            // BOMBTN
            // 
            this.BOMBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BOMBTN.Location = new System.Drawing.Point(1175, 5);
            this.BOMBTN.Name = "BOMBTN";
            this.BOMBTN.Size = new System.Drawing.Size(64, 23);
            this.BOMBTN.TabIndex = 8;
            this.BOMBTN.Text = "BOM";
            this.BOMBTN.UseVisualStyleBackColor = true;
            // 
            // LOT목록그리드
            // 
            this.LOT목록그리드.AllowUserToAddRows = false;
            this.LOT목록그리드.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LOT목록그리드.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LOT목록그리드.Location = new System.Drawing.Point(3, 93);
            this.LOT목록그리드.Name = "LOT목록그리드";
            this.LOT목록그리드.RowTemplate.Height = 23;
            this.LOT목록그리드.Size = new System.Drawing.Size(1248, 274);
            this.LOT목록그리드.TabIndex = 8;
            this.LOT목록그리드.기본테이블명 = null;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel5.Controls.Add(this.Btn투입취소, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.Btn투입, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 800);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1254, 45);
            this.tableLayoutPanel5.TabIndex = 10;
            // 
            // Btn투입취소
            // 
            this.Btn투입취소.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn투입취소.Location = new System.Drawing.Point(1178, 0);
            this.Btn투입취소.Margin = new System.Windows.Forms.Padding(0);
            this.Btn투입취소.Name = "Btn투입취소";
            this.Btn투입취소.Size = new System.Drawing.Size(75, 45);
            this.Btn투입취소.TabIndex = 0;
            this.Btn투입취소.Text = "투입취소";
            this.Btn투입취소.UseVisualStyleBackColor = true;
            this.Btn투입취소.Click += new System.EventHandler(this.Btn투입취소_Click);
            // 
            // Btn투입
            // 
            this.Btn투입.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn투입.Location = new System.Drawing.Point(1103, 0);
            this.Btn투입.Margin = new System.Windows.Forms.Padding(0);
            this.Btn투입.Name = "Btn투입";
            this.Btn투입.Size = new System.Drawing.Size(75, 45);
            this.Btn투입.TabIndex = 0;
            this.Btn투입.Text = "투입";
            this.Btn투입.UseVisualStyleBackColor = true;
            this.Btn투입.Click += new System.EventHandler(this.Btn투입_Click);
            // 
            // 주제공정시작
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 901);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "주제공정시작";
            this.Text = "주제공정시작";
            this.Controls.SetChildIndex(this.tableLayoutPanel3, 0);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LOT정보그리드)).EndInit();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.DateTable.ResumeLayout(false);
            this.DateTable.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.FullTable.ResumeLayout(false);
            this.FullTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.투입수량nud)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LOT목록그리드)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel FullTable;
        private System.Windows.Forms.Label LOT진행상태LB;
        private System.Windows.Forms.Label 투입수량LB;
        private System.Windows.Forms.Label KGLB;
        private System.Windows.Forms.ComboBox LOT진행상태CBX;
        private System.Windows.Forms.TableLayoutPanel SearchPanel;
        private System.Windows.Forms.Label ProductiontypeLB;
        private System.Windows.Forms.TableLayoutPanel DateTable;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.Label 기간중;
        private System.Windows.Forms.Label ProductionorderLB;
        private System.Windows.Forms.Label DateTimeLB;
        private System.Windows.Forms.TextBox ProductionorderTXB;
        private System.Windows.Forms.ComboBox ProductiontypeCBX;
        private System.Windows.Forms.ComboBox 제품CBX;
        private System.Windows.Forms.Label 제품LB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label 생산LOTLB;
        private System.Windows.Forms.Label LOTProgressLB;
        private System.Windows.Forms.Label 투입일시LB;
        private System.Windows.Forms.Label 투입설비LB;
        private System.Windows.Forms.TextBox 생산LOTTXB;
        private System.Windows.Forms.TextBox LOTProgressTXB;
        private System.Windows.Forms.ComboBox 투입설비CBX;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btn자동투입;
        private System.Windows.Forms.Button 자재LOT정보BTN;
        private System.Windows.Forms.Button BOMBTN;
        private DexCommonUtil.UI도구.사용자정의컨트롤.DexGridView LOT정보그리드;
        private DexCommonUtil.UI도구.사용자정의컨트롤.DexGridView LOT목록그리드;
        private System.Windows.Forms.NumericUpDown 투입수량nud;
        private System.Windows.Forms.DateTimePicker 투입일시Dtp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button Btn투입취소;
        private System.Windows.Forms.Button Btn투입;
    }
}