
namespace DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.자재관리
{
    partial class 자재폐기
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(자재폐기));
            this.AllTable = new System.Windows.Forms.TableLayoutPanel();
            this.Topmenu = new System.Windows.Forms.TableLayoutPanel();
            this.DateTable = new System.Windows.Forms.TableLayoutPanel();
            this.Period = new System.Windows.Forms.Label();
            this.DateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.DateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.DateTimeLB = new System.Windows.Forms.Label();
            this.위치LB = new System.Windows.Forms.Label();
            this.위치CBO = new System.Windows.Forms.ComboBox();
            this.자재LOTLB = new System.Windows.Forms.Label();
            this.자재LOTTXB = new System.Windows.Forms.TextBox();
            this.자재폐기그리드 = new DexCommonUtil.UI도구.사용자정의컨트롤.DexGridView();
            this.BottomMenu = new System.Windows.Forms.TableLayoutPanel();
            this.생산LOTLB = new System.Windows.Forms.Label();
            this.저재타입LB = new System.Windows.Forms.Label();
            this.재고수량 = new System.Windows.Forms.Label();
            this.현위치LB = new System.Windows.Forms.Label();
            this.폐기사유LB = new System.Windows.Forms.Label();
            this.특이사항LB = new System.Windows.Forms.Label();
            this.자재명LB = new System.Windows.Forms.Label();
            this.생산LOTTXB = new System.Windows.Forms.TextBox();
            this.현위치TXB = new System.Windows.Forms.TextBox();
            this.자재명TXB = new System.Windows.Forms.TextBox();
            this.자재타입TXB = new System.Windows.Forms.TextBox();
            this.재고수량TXB = new System.Windows.Forms.TextBox();
            this.QTYTXB = new System.Windows.Forms.TextBox();
            this.폐기사유TXB = new System.Windows.Forms.TextBox();
            this.폐기사유CBO = new System.Windows.Forms.ComboBox();
            this.특이사항CBO = new System.Windows.Forms.ComboBox();
            this.btn폐기 = new System.Windows.Forms.Button();
            this.AllTable.SuspendLayout();
            this.Topmenu.SuspendLayout();
            this.DateTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.자재폐기그리드)).BeginInit();
            this.BottomMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllTable
            // 
            this.AllTable.ColumnCount = 1;
            this.AllTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AllTable.Controls.Add(this.Topmenu, 0, 0);
            this.AllTable.Controls.Add(this.자재폐기그리드, 0, 1);
            this.AllTable.Controls.Add(this.BottomMenu, 0, 2);
            this.AllTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllTable.Location = new System.Drawing.Point(0, 28);
            this.AllTable.Margin = new System.Windows.Forms.Padding(0);
            this.AllTable.Name = "AllTable";
            this.AllTable.RowCount = 3;
            this.AllTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.AllTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AllTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.AllTable.Size = new System.Drawing.Size(1093, 529);
            this.AllTable.TabIndex = 3;
            // 
            // Topmenu
            // 
            this.Topmenu.ColumnCount = 7;
            this.Topmenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.Topmenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.Topmenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.Topmenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.Topmenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.Topmenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.Topmenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 388F));
            this.Topmenu.Controls.Add(this.DateTable, 1, 0);
            this.Topmenu.Controls.Add(this.DateTimeLB, 0, 0);
            this.Topmenu.Controls.Add(this.위치LB, 0, 1);
            this.Topmenu.Controls.Add(this.위치CBO, 1, 1);
            this.Topmenu.Controls.Add(this.자재LOTLB, 3, 1);
            this.Topmenu.Controls.Add(this.자재LOTTXB, 4, 1);
            this.Topmenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Topmenu.Location = new System.Drawing.Point(0, 0);
            this.Topmenu.Margin = new System.Windows.Forms.Padding(0);
            this.Topmenu.Name = "Topmenu";
            this.Topmenu.RowCount = 2;
            this.Topmenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Topmenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Topmenu.Size = new System.Drawing.Size(1093, 70);
            this.Topmenu.TabIndex = 0;
            // 
            // DateTable
            // 
            this.DateTable.ColumnCount = 3;
            this.Topmenu.SetColumnSpan(this.DateTable, 3);
            this.DateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.DateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.DateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.DateTable.Controls.Add(this.Period, 1, 0);
            this.DateTable.Controls.Add(this.DateTimeStart, 0, 0);
            this.DateTable.Controls.Add(this.DateTimeEnd, 2, 0);
            this.DateTable.Location = new System.Drawing.Point(105, 0);
            this.DateTable.Margin = new System.Windows.Forms.Padding(0);
            this.DateTable.Name = "DateTable";
            this.DateTable.RowCount = 1;
            this.DateTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DateTable.Size = new System.Drawing.Size(365, 35);
            this.DateTable.TabIndex = 0;
            // 
            // Period
            // 
            this.Period.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Period.AutoSize = true;
            this.Period.Location = new System.Drawing.Point(179, 11);
            this.Period.Name = "Period";
            this.Period.Size = new System.Drawing.Size(14, 12);
            this.Period.TabIndex = 1;
            this.Period.Text = "~";
            // 
            // DateTimeStart
            // 
            this.DateTimeStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimeStart.Location = new System.Drawing.Point(3, 7);
            this.DateTimeStart.Name = "DateTimeStart";
            this.DateTimeStart.Size = new System.Drawing.Size(166, 21);
            this.DateTimeStart.TabIndex = 2;
            // 
            // DateTimeEnd
            // 
            this.DateTimeEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimeEnd.Location = new System.Drawing.Point(203, 7);
            this.DateTimeEnd.Name = "DateTimeEnd";
            this.DateTimeEnd.Size = new System.Drawing.Size(174, 21);
            this.DateTimeEnd.TabIndex = 2;
            // 
            // DateTimeLB
            // 
            this.DateTimeLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateTimeLB.AutoSize = true;
            this.DateTimeLB.Location = new System.Drawing.Point(38, 11);
            this.DateTimeLB.Name = "DateTimeLB";
            this.DateTimeLB.Size = new System.Drawing.Size(29, 12);
            this.DateTimeLB.TabIndex = 1;
            this.DateTimeLB.Text = "기간";
            // 
            // 위치LB
            // 
            this.위치LB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.위치LB.AutoSize = true;
            this.위치LB.Location = new System.Drawing.Point(38, 46);
            this.위치LB.Name = "위치LB";
            this.위치LB.Size = new System.Drawing.Size(29, 12);
            this.위치LB.TabIndex = 1;
            this.위치LB.Text = "위치";
            // 
            // 위치CBO
            // 
            this.위치CBO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.위치CBO.FormattingEnabled = true;
            this.위치CBO.Location = new System.Drawing.Point(108, 42);
            this.위치CBO.Name = "위치CBO";
            this.위치CBO.Size = new System.Drawing.Size(124, 20);
            this.위치CBO.TabIndex = 2;
            // 
            // 자재LOTLB
            // 
            this.자재LOTLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.자재LOTLB.AutoSize = true;
            this.자재LOTLB.Location = new System.Drawing.Point(378, 46);
            this.자재LOTLB.Name = "자재LOTLB";
            this.자재LOTLB.Size = new System.Drawing.Size(53, 12);
            this.자재LOTLB.TabIndex = 1;
            this.자재LOTLB.Text = "자재LOT";
            // 
            // 자재LOTTXB
            // 
            this.자재LOTTXB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.자재LOTTXB.Location = new System.Drawing.Point(473, 42);
            this.자재LOTTXB.Name = "자재LOTTXB";
            this.자재LOTTXB.Size = new System.Drawing.Size(99, 21);
            this.자재LOTTXB.TabIndex = 3;
            // 
            // 자재폐기그리드
            // 
            this.자재폐기그리드.AllowUserToAddRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.자재폐기그리드.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.자재폐기그리드.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.자재폐기그리드.DefaultCellStyle = dataGridViewCellStyle5;
            this.자재폐기그리드.Dock = System.Windows.Forms.DockStyle.Fill;
            this.자재폐기그리드.Location = new System.Drawing.Point(3, 73);
            this.자재폐기그리드.Name = "자재폐기그리드";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.자재폐기그리드.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.자재폐기그리드.RowTemplate.Height = 23;
            this.자재폐기그리드.Size = new System.Drawing.Size(1087, 333);
            this.자재폐기그리드.TabIndex = 1;
            this.자재폐기그리드.기본테이블명 = null;
            this.자재폐기그리드.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.자재폐기그리드_CellClick);
            // 
            // BottomMenu
            // 
            this.BottomMenu.ColumnCount = 7;
            this.BottomMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.BottomMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.BottomMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.BottomMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.BottomMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.BottomMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.BottomMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 388F));
            this.BottomMenu.Controls.Add(this.생산LOTLB, 0, 0);
            this.BottomMenu.Controls.Add(this.저재타입LB, 2, 0);
            this.BottomMenu.Controls.Add(this.재고수량, 4, 0);
            this.BottomMenu.Controls.Add(this.현위치LB, 0, 1);
            this.BottomMenu.Controls.Add(this.폐기사유LB, 0, 2);
            this.BottomMenu.Controls.Add(this.특이사항LB, 0, 3);
            this.BottomMenu.Controls.Add(this.자재명LB, 2, 1);
            this.BottomMenu.Controls.Add(this.생산LOTTXB, 1, 0);
            this.BottomMenu.Controls.Add(this.현위치TXB, 1, 1);
            this.BottomMenu.Controls.Add(this.자재명TXB, 3, 1);
            this.BottomMenu.Controls.Add(this.자재타입TXB, 3, 0);
            this.BottomMenu.Controls.Add(this.재고수량TXB, 5, 0);
            this.BottomMenu.Controls.Add(this.QTYTXB, 6, 0);
            this.BottomMenu.Controls.Add(this.폐기사유TXB, 2, 2);
            this.BottomMenu.Controls.Add(this.폐기사유CBO, 1, 2);
            this.BottomMenu.Controls.Add(this.특이사항CBO, 1, 3);
            this.BottomMenu.Controls.Add(this.btn폐기, 6, 3);
            this.BottomMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomMenu.Location = new System.Drawing.Point(0, 409);
            this.BottomMenu.Margin = new System.Windows.Forms.Padding(0);
            this.BottomMenu.Name = "BottomMenu";
            this.BottomMenu.RowCount = 4;
            this.BottomMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.BottomMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.BottomMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.BottomMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.BottomMenu.Size = new System.Drawing.Size(1093, 120);
            this.BottomMenu.TabIndex = 2;
            // 
            // 생산LOTLB
            // 
            this.생산LOTLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.생산LOTLB.AutoSize = true;
            this.생산LOTLB.Location = new System.Drawing.Point(26, 9);
            this.생산LOTLB.Name = "생산LOTLB";
            this.생산LOTLB.Size = new System.Drawing.Size(53, 12);
            this.생산LOTLB.TabIndex = 1;
            this.생산LOTLB.Text = "생산LOT";
            // 
            // 저재타입LB
            // 
            this.저재타입LB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.저재타입LB.AutoSize = true;
            this.저재타입LB.Location = new System.Drawing.Point(261, 9);
            this.저재타입LB.Name = "저재타입LB";
            this.저재타입LB.Size = new System.Drawing.Size(53, 12);
            this.저재타입LB.TabIndex = 1;
            this.저재타입LB.Text = "자재타입";
            // 
            // 재고수량
            // 
            this.재고수량.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.재고수량.AutoSize = true;
            this.재고수량.Location = new System.Drawing.Point(496, 9);
            this.재고수량.Name = "재고수량";
            this.재고수량.Size = new System.Drawing.Size(53, 12);
            this.재고수량.TabIndex = 1;
            this.재고수량.Text = "재고수량";
            // 
            // 현위치LB
            // 
            this.현위치LB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.현위치LB.AutoSize = true;
            this.현위치LB.Location = new System.Drawing.Point(32, 39);
            this.현위치LB.Name = "현위치LB";
            this.현위치LB.Size = new System.Drawing.Size(41, 12);
            this.현위치LB.TabIndex = 1;
            this.현위치LB.Text = "현위치";
            // 
            // 폐기사유LB
            // 
            this.폐기사유LB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.폐기사유LB.AutoSize = true;
            this.폐기사유LB.Location = new System.Drawing.Point(26, 69);
            this.폐기사유LB.Name = "폐기사유LB";
            this.폐기사유LB.Size = new System.Drawing.Size(53, 12);
            this.폐기사유LB.TabIndex = 1;
            this.폐기사유LB.Text = "폐기사유";
            // 
            // 특이사항LB
            // 
            this.특이사항LB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.특이사항LB.AutoSize = true;
            this.특이사항LB.Location = new System.Drawing.Point(26, 99);
            this.특이사항LB.Name = "특이사항LB";
            this.특이사항LB.Size = new System.Drawing.Size(53, 12);
            this.특이사항LB.TabIndex = 1;
            this.특이사항LB.Text = "특이사항";
            // 
            // 자재명LB
            // 
            this.자재명LB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.자재명LB.AutoSize = true;
            this.자재명LB.Location = new System.Drawing.Point(267, 39);
            this.자재명LB.Name = "자재명LB";
            this.자재명LB.Size = new System.Drawing.Size(41, 12);
            this.자재명LB.TabIndex = 1;
            this.자재명LB.Text = "자재명";
            // 
            // 생산LOTTXB
            // 
            this.생산LOTTXB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.생산LOTTXB.Location = new System.Drawing.Point(108, 4);
            this.생산LOTTXB.Name = "생산LOTTXB";
            this.생산LOTTXB.ReadOnly = true;
            this.생산LOTTXB.Size = new System.Drawing.Size(124, 21);
            this.생산LOTTXB.TabIndex = 3;
            // 
            // 현위치TXB
            // 
            this.현위치TXB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.현위치TXB.Location = new System.Drawing.Point(108, 34);
            this.현위치TXB.Name = "현위치TXB";
            this.현위치TXB.ReadOnly = true;
            this.현위치TXB.Size = new System.Drawing.Size(124, 21);
            this.현위치TXB.TabIndex = 3;
            // 
            // 자재명TXB
            // 
            this.자재명TXB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.자재명TXB.Location = new System.Drawing.Point(343, 34);
            this.자재명TXB.Name = "자재명TXB";
            this.자재명TXB.ReadOnly = true;
            this.자재명TXB.Size = new System.Drawing.Size(124, 21);
            this.자재명TXB.TabIndex = 3;
            // 
            // 자재타입TXB
            // 
            this.자재타입TXB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.자재타입TXB.Location = new System.Drawing.Point(343, 4);
            this.자재타입TXB.Name = "자재타입TXB";
            this.자재타입TXB.ReadOnly = true;
            this.자재타입TXB.Size = new System.Drawing.Size(124, 21);
            this.자재타입TXB.TabIndex = 3;
            // 
            // 재고수량TXB
            // 
            this.재고수량TXB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.재고수량TXB.Location = new System.Drawing.Point(578, 4);
            this.재고수량TXB.Name = "재고수량TXB";
            this.재고수량TXB.ReadOnly = true;
            this.재고수량TXB.Size = new System.Drawing.Size(124, 21);
            this.재고수량TXB.TabIndex = 3;
            // 
            // QTYTXB
            // 
            this.QTYTXB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.QTYTXB.Location = new System.Drawing.Point(708, 4);
            this.QTYTXB.Name = "QTYTXB";
            this.QTYTXB.ReadOnly = true;
            this.QTYTXB.Size = new System.Drawing.Size(124, 21);
            this.QTYTXB.TabIndex = 3;
            // 
            // 폐기사유TXB
            // 
            this.폐기사유TXB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.폐기사유TXB.Location = new System.Drawing.Point(238, 64);
            this.폐기사유TXB.Name = "폐기사유TXB";
            this.폐기사유TXB.ReadOnly = true;
            this.폐기사유TXB.Size = new System.Drawing.Size(99, 21);
            this.폐기사유TXB.TabIndex = 3;
            // 
            // 폐기사유CBO
            // 
            this.폐기사유CBO.FormattingEnabled = true;
            this.폐기사유CBO.Location = new System.Drawing.Point(108, 63);
            this.폐기사유CBO.Name = "폐기사유CBO";
            this.폐기사유CBO.Size = new System.Drawing.Size(121, 20);
            this.폐기사유CBO.TabIndex = 4;
            // 
            // 특이사항CBO
            // 
            this.BottomMenu.SetColumnSpan(this.특이사항CBO, 2);
            this.특이사항CBO.FormattingEnabled = true;
            this.특이사항CBO.Location = new System.Drawing.Point(108, 93);
            this.특이사항CBO.Name = "특이사항CBO";
            this.특이사항CBO.Size = new System.Drawing.Size(229, 20);
            this.특이사항CBO.TabIndex = 5;
            // 
            // btn폐기
            // 
            this.btn폐기.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn폐기.Location = new System.Drawing.Point(705, 93);
            this.btn폐기.Margin = new System.Windows.Forms.Padding(0);
            this.btn폐기.Name = "btn폐기";
            this.btn폐기.Size = new System.Drawing.Size(75, 23);
            this.btn폐기.TabIndex = 6;
            this.btn폐기.Text = "폐기";
            this.btn폐기.UseVisualStyleBackColor = true;
            this.btn폐기.Click += new System.EventHandler(this.btn폐기_Click);
            // 
            // 자재폐기
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 585);
            this.Controls.Add(this.AllTable);
            this.Name = "자재폐기";
            this.Text = "자재폐기";
            this.Controls.SetChildIndex(this.AllTable, 0);
            this.AllTable.ResumeLayout(false);
            this.Topmenu.ResumeLayout(false);
            this.Topmenu.PerformLayout();
            this.DateTable.ResumeLayout(false);
            this.DateTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.자재폐기그리드)).EndInit();
            this.BottomMenu.ResumeLayout(false);
            this.BottomMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel AllTable;
        private System.Windows.Forms.TableLayoutPanel Topmenu;
        private System.Windows.Forms.TableLayoutPanel DateTable;
        private DexCommonUtil.UI도구.사용자정의컨트롤.DexGridView 자재폐기그리드;
        private System.Windows.Forms.Label Period;
        private System.Windows.Forms.Label DateTimeLB;
        private System.Windows.Forms.Label 위치LB;
        private System.Windows.Forms.Label 자재LOTLB;
        private System.Windows.Forms.TableLayoutPanel BottomMenu;
        private System.Windows.Forms.DateTimePicker DateTimeStart;
        private System.Windows.Forms.DateTimePicker DateTimeEnd;
        private System.Windows.Forms.ComboBox 위치CBO;
        private System.Windows.Forms.TextBox 자재LOTTXB;
        private System.Windows.Forms.Label 생산LOTLB;
        private System.Windows.Forms.Label 저재타입LB;
        private System.Windows.Forms.Label 재고수량;
        private System.Windows.Forms.Label 현위치LB;
        private System.Windows.Forms.Label 폐기사유LB;
        private System.Windows.Forms.Label 특이사항LB;
        private System.Windows.Forms.Label 자재명LB;
        private System.Windows.Forms.TextBox 생산LOTTXB;
        private System.Windows.Forms.TextBox 현위치TXB;
        private System.Windows.Forms.TextBox 자재명TXB;
        private System.Windows.Forms.TextBox 자재타입TXB;
        private System.Windows.Forms.TextBox 재고수량TXB;
        private System.Windows.Forms.TextBox QTYTXB;
        private System.Windows.Forms.TextBox 폐기사유TXB;
        private System.Windows.Forms.ComboBox 폐기사유CBO;
        private System.Windows.Forms.ComboBox 특이사항CBO;
        private System.Windows.Forms.Button btn폐기;
    }
}