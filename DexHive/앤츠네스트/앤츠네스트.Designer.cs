namespace DexHive
{
    partial class 앤츠네스트
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.로고버튼 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.시스템관리버튼 = new System.Windows.Forms.Button();
            this.직원관리버튼 = new System.Windows.Forms.Button();
            this.업무관리버튼 = new System.Windows.Forms.Button();
            this.자금관리버튼 = new System.Windows.Forms.Button();
            this.서브메뉴 = new System.Windows.Forms.TreeView();
            this.컨텐츠뷰어 = new System.Windows.Forms.TabControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.로고버튼, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.서브메뉴, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.컨텐츠뷰어, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // 로고버튼
            // 
            this.로고버튼.Dock = System.Windows.Forms.DockStyle.Fill;
            this.로고버튼.Location = new System.Drawing.Point(3, 3);
            this.로고버튼.Name = "로고버튼";
            this.로고버튼.Size = new System.Drawing.Size(194, 84);
            this.로고버튼.TabIndex = 0;
            this.로고버튼.Text = "로고";
            this.로고버튼.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.시스템관리버튼, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.직원관리버튼, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.업무관리버튼, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.자금관리버튼, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(200, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(584, 90);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // 시스템관리버튼
            // 
            this.시스템관리버튼.Dock = System.Windows.Forms.DockStyle.Fill;
            this.시스템관리버튼.Location = new System.Drawing.Point(438, 3);
            this.시스템관리버튼.Name = "시스템관리버튼";
            this.시스템관리버튼.Size = new System.Drawing.Size(139, 84);
            this.시스템관리버튼.TabIndex = 0;
            this.시스템관리버튼.Text = "시스템관리";
            this.시스템관리버튼.UseVisualStyleBackColor = true;
            // 
            // 직원관리버튼
            // 
            this.직원관리버튼.Dock = System.Windows.Forms.DockStyle.Fill;
            this.직원관리버튼.Location = new System.Drawing.Point(148, 3);
            this.직원관리버튼.Name = "직원관리버튼";
            this.직원관리버튼.Size = new System.Drawing.Size(139, 84);
            this.직원관리버튼.TabIndex = 0;
            this.직원관리버튼.Text = "직원관리";
            this.직원관리버튼.UseVisualStyleBackColor = true;
            // 
            // 업무관리버튼
            // 
            this.업무관리버튼.Dock = System.Windows.Forms.DockStyle.Fill;
            this.업무관리버튼.Location = new System.Drawing.Point(3, 3);
            this.업무관리버튼.Name = "업무관리버튼";
            this.업무관리버튼.Size = new System.Drawing.Size(139, 84);
            this.업무관리버튼.TabIndex = 0;
            this.업무관리버튼.Text = "업무관리";
            this.업무관리버튼.UseVisualStyleBackColor = true;
            // 
            // 자금관리버튼
            // 
            this.자금관리버튼.Dock = System.Windows.Forms.DockStyle.Fill;
            this.자금관리버튼.Location = new System.Drawing.Point(293, 3);
            this.자금관리버튼.Name = "자금관리버튼";
            this.자금관리버튼.Size = new System.Drawing.Size(139, 84);
            this.자금관리버튼.TabIndex = 0;
            this.자금관리버튼.Text = "자금관리";
            this.자금관리버튼.UseVisualStyleBackColor = true;
            // 
            // 서브메뉴
            // 
            this.서브메뉴.Dock = System.Windows.Forms.DockStyle.Fill;
            this.서브메뉴.Location = new System.Drawing.Point(3, 93);
            this.서브메뉴.Name = "서브메뉴";
            this.서브메뉴.Size = new System.Drawing.Size(194, 465);
            this.서브메뉴.TabIndex = 2;
            // 
            // 컨텐츠뷰어
            // 
            this.컨텐츠뷰어.Dock = System.Windows.Forms.DockStyle.Fill;
            this.컨텐츠뷰어.Location = new System.Drawing.Point(203, 93);
            this.컨텐츠뷰어.Name = "컨텐츠뷰어";
            this.컨텐츠뷰어.SelectedIndex = 0;
            this.컨텐츠뷰어.Size = new System.Drawing.Size(578, 465);
            this.컨텐츠뷰어.TabIndex = 3;
            // 
            // 앤츠네스트
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "앤츠네스트";
            this.Text = "앤츠네스트 - 사업관리시스템";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button 로고버튼;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button 직원관리버튼;
        private System.Windows.Forms.Button 업무관리버튼;
        private System.Windows.Forms.Button 자금관리버튼;
        private System.Windows.Forms.Button 시스템관리버튼;
        private System.Windows.Forms.TreeView 서브메뉴;
        private System.Windows.Forms.TabControl 컨텐츠뷰어;
    }
}

