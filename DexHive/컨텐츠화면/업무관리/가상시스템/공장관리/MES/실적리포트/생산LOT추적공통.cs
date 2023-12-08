using DexCommonUtil.UI도구;
using DexCommonUtil.UI도구.사용자정의컨트롤;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.실적리포트
{
    //만들다말았음 ~ 
    public partial class 생산LOT추적공통 : 스크린,I스크린
    {
        public 생산LOT추적_모델 그리드모델 { get; set; }
        public 생산LOT추적검색_모델 검색조건모델 { get; set; }
      
        public 생산LOT추적공통()
        {
            InitializeComponent();
            InitializeProperty();
            InitializeEvent();
        }

        private void InitializeEvent()
        {
            this.Shown += 생산LOT추적공통_Shown;

            this.기본기능.조회버튼.Click += (object sender, EventArgs e) => 조회();
            this.기본기능.저장버튼.Click += (object sender, EventArgs e) => 저장();
          
        }

        private void 생산LOT추적공통_Shown(object sender, EventArgs e)
        {
            콤보박스초기화();
            조회();
            메인그리드초기화();
            this.기본기능.행제거버튼.Visible = false;
            this.기본기능.행추가버튼.Visible = false;
        }

        private void 반제품자재소진정보초기화()
        {
            DexGridColumn[] 컬럼들 = new DexGridColumn[10];
            컬럼들[0] = new DexGridColumn();
            컬럼들[0].컬럼명 = "LOTID";
            컬럼들[0].헤더명 = "자재LOT";
            컬럼들[0].너비 = 100;

            컬럼들[1] = new DexGridColumn();
            컬럼들[1].컬럼명 = "PRODUCTDEFINITIONID";
            컬럼들[1].헤더명 = "자재코드";
            컬럼들[1].너비 = 100;

            컬럼들[2] = new DexGridColumn();
            컬럼들[2].컬럼명 = "PRODUCTDEFINITIONNAME";
            컬럼들[2].헤더명 = "자재명";
            컬럼들[2].너비 = 100;

            컬럼들[3] = new DexGridColumn();
            컬럼들[3].컬럼명 = "ACTIVITY";
            컬럼들[3].헤더명 = "투입수량";
            컬럼들[3].너비 = 100;

            컬럼들[4] = new DexGridColumn();
            컬럼들[4].컬럼명 = "STATE";
            컬럼들[4].헤더명 = "총량";
            컬럼들[4].너비 = 100;

            컬럼들[5] = new DexGridColumn();
            컬럼들[5].컬럼명 = "QTY";
            컬럼들[5].헤더명 = "단위";
            컬럼들[5].너비 = 100;

            컬럼들[6] = new DexGridColumn();
            컬럼들[6].컬럼명 = "UNITID";
            컬럼들[6].헤더명 = "설비";
            컬럼들[6].너비 = 100;

            컬럼들[7] = new DexGridColumn();
            컬럼들[7].컬럼명 = "EQUIPMENTID";
            컬럼들[7].헤더명 = "설비명";
            컬럼들[7].너비 = 100;

            컬럼들[8] = new DexGridColumn();
            컬럼들[8].컬럼명 = "EQUIPMENTNAME";
            컬럼들[8].헤더명 = "입고일";
            컬럼들[8].너비 = 100;

            컬럼들[9] = new DexGridColumn();
            컬럼들[9].컬럼명 = "TRACKINTIME";
            컬럼들[9].헤더명 = "스캔일시";
            컬럼들[9].너비 = 100;

            그리드모델.반제품자재소진정보그리드.열생성(컬럼들);
        }

        private void 완제품LOT이력그리드초기화()
        {
            DexGridColumn[] 컬럼들 = new DexGridColumn[12];
            컬럼들[0] = new DexGridColumn();
            컬럼들[0].컬럼명 = "LOTID";
            컬럼들[0].헤더명 = "생산LOT";
            컬럼들[0].너비 = 100;

            컬럼들[1] = new DexGridColumn();
            컬럼들[1].컬럼명 = "PRODUCTDEFINITIONID";
            컬럼들[1].헤더명 = "제품코드";
            컬럼들[1].너비 = 100;

            컬럼들[2] = new DexGridColumn();
            컬럼들[2].컬럼명 = "PRODUCTDEFINITIONNAME";
            컬럼들[2].헤더명 = "제품명";
            컬럼들[2].너비 = 100;

            컬럼들[3] = new DexGridColumn();
            컬럼들[3].컬럼명 = "ACTIVITY";
            컬럼들[3].헤더명 = "액티비티";
            컬럼들[3].너비 = 100;

            컬럼들[4] = new DexGridColumn();
            컬럼들[4].컬럼명 = "STATE";
            컬럼들[4].헤더명 = "상태";
            컬럼들[4].너비 = 100;

            컬럼들[5] = new DexGridColumn();
            컬럼들[5].컬럼명 = "QTY";
            컬럼들[5].헤더명 = "수량";
            컬럼들[5].너비 = 100;

            컬럼들[6] = new DexGridColumn();
            컬럼들[6].컬럼명 = "UNITID";
            컬럼들[6].헤더명 = "단위";
            컬럼들[6].너비 = 100;

            컬럼들[7] = new DexGridColumn();
            컬럼들[7].컬럼명 = "EQUIPMENTID";
            컬럼들[7].헤더명 = "투입설비";
            컬럼들[7].너비 = 100;

            컬럼들[8] = new DexGridColumn();
            컬럼들[8].컬럼명 = "EQUIPMENTNAME";
            컬럼들[8].헤더명 = "설비명";
            컬럼들[8].너비 = 100;

            컬럼들[9] = new DexGridColumn();
            컬럼들[9].컬럼명 = "TRACKINTIME";
            컬럼들[9].헤더명 = "투입일시";
            컬럼들[9].너비 = 100;

            컬럼들[10] = new DexGridColumn();
            컬럼들[10].컬럼명 = "TRACKOUTTIME";
            컬럼들[10].헤더명 = "완료일시";
            컬럼들[10].너비 = 100;

            컬럼들[11] = new DexGridColumn();
            컬럼들[11].컬럼명 = "MODIFYTIME";
            컬럼들[11].헤더명 = "시스템수정일시";
            컬럼들[11].너비 = 100;

            그리드모델.완제품LOT이력그리드.열생성(컬럼들);
        }

        private void 그리드그룹완제품초기화()
        {
            GridGroups = new TableLayoutPanel();
            GridGroups.ColumnCount = 2;
            GridGroups.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            GridGroups.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            GridGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            GridGroups.Location = new System.Drawing.Point(250, 0);
            GridGroups.Margin = new System.Windows.Forms.Padding(0);
            GridGroups.Name = "GridGroups";
            GridGroups.RowCount = 3;
            GridGroups.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            GridGroups.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            GridGroups.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            GridGroups.Size = new System.Drawing.Size(696, 423);
            GridGroups.TabIndex = 1;


            GridGroups.Controls.Add(그리드모델.완제품LOT이력그리드, 0, 0);
            GridGroups.Controls.Add(그리드모델.반제품자재소진정보그리드,0,1);
            GridGroups.Controls.Add(그리드모델.공정별불량정보그리드,0,2);
            GridGroups.Controls.Add(그리드모델.완제품품질검사정보그리드,1,2);

            this.GridGroups.SetColumnSpan(this.그리드모델.완제품LOT이력그리드, 2);
            this.GridGroups.SetColumnSpan(this.그리드모델.반제품자재소진정보그리드, 2);
          
            그리드모델.완제품LOT이력그리드.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            그리드모델.완제품LOT이력그리드.Dock = System.Windows.Forms.DockStyle.Fill;
            그리드모델.완제품LOT이력그리드.Location = new System.Drawing.Point(0, 0);
            그리드모델.완제품LOT이력그리드.Margin = new System.Windows.Forms.Padding(0);
            그리드모델.완제품LOT이력그리드.Name = "완제품LOT이력";
            그리드모델.완제품LOT이력그리드.RowTemplate.Height = 23;
            그리드모델.완제품LOT이력그리드.Size = new System.Drawing.Size(254, 423);
            그리드모델.완제품LOT이력그리드.TabIndex = 0;

            그리드모델.반제품자재소진정보그리드.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            그리드모델.반제품자재소진정보그리드.Dock = System.Windows.Forms.DockStyle.Fill;
            그리드모델.반제품자재소진정보그리드.Location = new System.Drawing.Point(0, 0);
            그리드모델.반제품자재소진정보그리드.Margin = new System.Windows.Forms.Padding(0);
            그리드모델.반제품자재소진정보그리드.Name = "반제품자재소진정보";
            그리드모델.반제품자재소진정보그리드.RowTemplate.Height = 23;
            그리드모델.반제품자재소진정보그리드.Size = new System.Drawing.Size(254, 423);
            그리드모델.반제품자재소진정보그리드.TabIndex = 0;

            그리드모델.공정별불량정보그리드.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            그리드모델.공정별불량정보그리드.Dock = System.Windows.Forms.DockStyle.Fill;
            그리드모델.공정별불량정보그리드.Location = new System.Drawing.Point(0, 0);
            그리드모델.공정별불량정보그리드.Margin = new System.Windows.Forms.Padding(0);
            그리드모델.공정별불량정보그리드.Name = "공정별불량정보";
            그리드모델.공정별불량정보그리드.RowTemplate.Height = 23;
            그리드모델.공정별불량정보그리드.Size = new System.Drawing.Size(254, 423);
            그리드모델.공정별불량정보그리드.TabIndex = 0;

            그리드모델.완제품품질검사정보그리드.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            그리드모델.완제품품질검사정보그리드.Dock = System.Windows.Forms.DockStyle.Fill;
            그리드모델.완제품품질검사정보그리드.Location = new System.Drawing.Point(0, 0);
            그리드모델.완제품품질검사정보그리드.Margin = new System.Windows.Forms.Padding(0);
            그리드모델.완제품품질검사정보그리드.Name = "완제품품질검사정보";
            그리드모델.완제품품질검사정보그리드.RowTemplate.Height = 23;
            그리드모델.완제품품질검사정보그리드.Size = new System.Drawing.Size(254, 423);
            그리드모델.완제품품질검사정보그리드.TabIndex = 0;

            완제품LOT이력그리드초기화();
            반제품자재소진정보초기화();
            공정별불량정보초기화();
            완제품품질검사정보초기화();

            Hashtable Param = new Hashtable();
            this.그리드모델.완제품LOT이력그리드.바인딩(서비스.조회수행("LOT이력정보조회", Param));
            this.그리드모델.반제품자재소진정보그리드.바인딩(서비스.조회수행("소진정보조회", Param));
            this.그리드모델.공정별불량정보그리드.바인딩(서비스.조회수행("LOT이력정보조회", Param));
            this.그리드모델.완제품품질검사정보그리드.바인딩(서비스.조회수행("LOT이력정보조회", Param));
        }

        private void 완제품품질검사정보초기화()
        {
            DexGridColumn[] 컬럼들 = new DexGridColumn[7];
            컬럼들[0] = new DexGridColumn();
            컬럼들[0].컬럼명 = "LOTID";
            컬럼들[0].헤더명 = "항목";
            컬럼들[0].너비 = 100;

            컬럼들[1] = new DexGridColumn();
            컬럼들[1].컬럼명 = "PRODUCTDEFINITIONID";
            컬럼들[1].헤더명 = "검사결과";
            컬럼들[1].너비 = 100;

            컬럼들[2] = new DexGridColumn();
            컬럼들[2].컬럼명 = "PRODUCTDEFINITIONNAME";
            컬럼들[2].헤더명 = "검사수량";
            컬럼들[2].너비 = 100;

            컬럼들[3] = new DexGridColumn();
            컬럼들[3].컬럼명 = "ACTIVITY";
            컬럼들[3].헤더명 = "단위";
            컬럼들[3].너비 = 100;

            컬럼들[4] = new DexGridColumn();
            컬럼들[4].컬럼명 = "STATE";
            컬럼들[4].헤더명 = "NG처리";
            컬럼들[4].너비 = 100;

            컬럼들[5] = new DexGridColumn();
            컬럼들[5].컬럼명 = "QTY";
            컬럼들[5].헤더명 = "검사자";
            컬럼들[5].너비 = 100;

            컬럼들[6] = new DexGridColumn();
            컬럼들[6].컬럼명 = "UNITID";
            컬럼들[6].헤더명 = "검사일";
            컬럼들[6].너비 = 100;

            그리드모델.완제품품질검사정보그리드.열생성(컬럼들);
        }

        private void 공정별불량정보초기화()
        {
            DexGridColumn[] 컬럼들 = new DexGridColumn[6];
            컬럼들[0] = new DexGridColumn();
            컬럼들[0].컬럼명 = "LOTID";
            컬럼들[0].헤더명 = "공정";
            컬럼들[0].너비 = 100;

            컬럼들[1] = new DexGridColumn();
            컬럼들[1].컬럼명 = "PRODUCTDEFINITIONID";
            컬럼들[1].헤더명 = "총수량";
            컬럼들[1].너비 = 100;

            컬럼들[2] = new DexGridColumn();
            컬럼들[2].컬럼명 = "PRODUCTDEFINITIONNAME";
            컬럼들[2].헤더명 = "불량코드";
            컬럼들[2].너비 = 100;

            컬럼들[3] = new DexGridColumn();
            컬럼들[3].컬럼명 = "ACTIVITY";
            컬럼들[3].헤더명 = "검사항목명";
            컬럼들[3].너비 = 100;

            컬럼들[4] = new DexGridColumn();
            컬럼들[4].컬럼명 = "STATE";
            컬럼들[4].헤더명 = "폐기수량";
            컬럼들[4].너비 = 100;

            컬럼들[5] = new DexGridColumn();
            컬럼들[5].컬럼명 = "QTY";
            컬럼들[5].헤더명 = "단위";
            컬럼들[5].너비 = 100;

            그리드모델.공정별불량정보그리드.열생성(컬럼들);
        }

        private void 메인그리드초기화()
        {
            DexGridColumn[] 컬럼들 = new DexGridColumn[2];
            컬럼들[0] = new DexGridColumn();
            컬럼들[0].컬럼명 = "LOTID";
            컬럼들[0].헤더명 = "생산LOT";
            컬럼들[0].너비 = 100;

            컬럼들[1] = new DexGridColumn();
            컬럼들[1].컬럼명 = "PRODUCTDEFINITIONID";
            컬럼들[1].헤더명 = "제품/자제코드";
            컬럼들[1].너비 = 100;

            그리드모델.메인그리드.열생성(컬럼들);
        }

        private void 콤보박스초기화()
        {
            Hashtable Param = new Hashtable();
            Param["코드그룹"] = "생산LOT";
            검색조건모델.제품군.DataSource = 서비스.조회수행("공통코드", Param);
            검색조건모델.제품군.DisplayMember = "명칭";
            검색조건모델.제품군.ValueMember = "코드";

            Param = new Hashtable();
            Param["코드그룹"] = "제품구분";
            검색조건모델.제품구분.DataSource = 서비스.조회수행("공통코드", Param);
            검색조건모델.제품구분.DisplayMember = "명칭";
            검색조건모델.제품구분.ValueMember = "코드";

            Param = new Hashtable();
            Param["코드그룹"] = "제품";
            검색조건모델.제품.DataSource = 서비스.조회수행("공통코드", Param);
            검색조건모델.제품.DisplayMember = "명칭";
            검색조건모델.제품.ValueMember = "코드";
        }

        private void InitializeProperty()
        {
            그리드모델 = new 생산LOT추적_모델();
            그리드모델.메인그리드 = this.Maingrid;
            그리드모델.완제품LOT이력그리드 = new DexGridView();
            그리드모델.반제품자재소진정보그리드 = new DexGridView();
            그리드모델.공정별불량정보그리드 = new DexGridView();
            그리드모델.완제품품질검사정보그리드 = new DexGridView();
            그리드모델.반제품LOT이력그리드 = new DexGridView();
            그리드모델.원자재소진정보그리드 = new DexGridView();
            그리드모델.반제품음성검사정보그리드 = new DexGridView();
            그리드모델.반응성검사이력그리드 = new DexGridView();
            그리드모델.WORKINGTANK물성검사이력그리드 = new DexGridView();
            그리드모델.원자재LOT이력그리드 = new DexGridView();

            검색조건모델 = new 생산LOT추적검색_모델();
            검색조건모델.날짜검색_시작 = this.dateTimePicker1;
            검색조건모델.날짜검색_종료 = this.dateTimePicker2;
            검색조건모델.제품 = this.제품CBX;
            검색조건모델.제품군 = this.제품군CBX;
            검색조건모델.제품구분 = this.제품구분CBX;
            검색조건모델.생산LOT = this.생산LOTTXB;
        }

        public void 저장()
        {
        }

        public void 조회()
        {
            Hashtable Param = new Hashtable();
            Param["MATERIALTYPE"] = string.IsNullOrEmpty(검색조건모델.제품.SelectedValue as string) ? string.Empty : 검색조건모델.제품.SelectedValue as string;
            Param["VENDORID"] = string.IsNullOrEmpty(검색조건모델.제품구분.SelectedValue as string) ? string.Empty : 검색조건모델.제품구분.SelectedValue as string;
            Param["LOCATION"] = string.IsNullOrEmpty(검색조건모델.제품군.SelectedValue as string) ? string.Empty : 검색조건모델.제품군.SelectedValue as string;
            Param["LOTID"] = 검색조건모델.생산LOT.Text;
            //Param["ENDTIME"] = dateTimePicker1.Value.ToShortDateString() + "," + dateTimePicker2.Value.ToShortDateString();
            this.그리드모델.메인그리드.바인딩(서비스.조회수행("LOT이력정보조회", Param));
        }

        public void 초기화()
        {
        }

        public void 행제거()
        {
        }

        public void 행추가()
        {
        }

        private void Maingrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            그리드그룹완제품초기화();
        }
        //반제품 클릭시이벤트로 반제품그리드들 보여줘야함
        private void 그리드그룹반제품초기화()
        {
            GridGroups = new TableLayoutPanel();
            GridGroups.ColumnCount = 1;
            GridGroups.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            GridGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            GridGroups.Location = new System.Drawing.Point(250, 0);
            GridGroups.Margin = new System.Windows.Forms.Padding(0);
            GridGroups.Name = "GridGroups";
            GridGroups.RowCount = 5;
            GridGroups.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            GridGroups.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            GridGroups.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            GridGroups.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            GridGroups.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            GridGroups.Size = new System.Drawing.Size(696, 423);
            GridGroups.TabIndex = 1;

           
            GridGroups.Controls.Add(그리드모델.반제품LOT이력그리드, 0, 0);
            GridGroups.Controls.Add(그리드모델.원자재소진정보그리드, 0, 1);
            GridGroups.Controls.Add(그리드모델.반제품음성검사정보그리드, 0, 2);
            GridGroups.Controls.Add(그리드모델.반응성검사이력그리드, 0, 3);
            GridGroups.Controls.Add(그리드모델.WORKINGTANK물성검사이력그리드, 0, 4);

            그리드모델.반제품LOT이력그리드.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            그리드모델.반제품LOT이력그리드.Dock = System.Windows.Forms.DockStyle.Fill;
            그리드모델.반제품LOT이력그리드.Location = new System.Drawing.Point(0, 0);
            그리드모델.반제품LOT이력그리드.Margin = new System.Windows.Forms.Padding(0);
            그리드모델.반제품LOT이력그리드.Name = "반제품LOT이력그리드";
            그리드모델.반제품LOT이력그리드.RowTemplate.Height = 23;
            그리드모델.반제품LOT이력그리드.Size = new System.Drawing.Size(254, 423);
            그리드모델.반제품LOT이력그리드.TabIndex = 0;

            그리드모델.원자재소진정보그리드.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            그리드모델.원자재소진정보그리드.Dock = System.Windows.Forms.DockStyle.Fill;
            그리드모델.원자재소진정보그리드.Location = new System.Drawing.Point(0, 0);
            그리드모델.원자재소진정보그리드.Margin = new System.Windows.Forms.Padding(0);
            그리드모델.원자재소진정보그리드.Name = "원자재소진정보그리드";
            그리드모델.원자재소진정보그리드.RowTemplate.Height = 23;
            그리드모델.원자재소진정보그리드.Size = new System.Drawing.Size(254, 423);
            그리드모델.원자재소진정보그리드.TabIndex = 0;

            그리드모델.반제품음성검사정보그리드.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            그리드모델.반제품음성검사정보그리드.Dock = System.Windows.Forms.DockStyle.Fill;
            그리드모델.반제품음성검사정보그리드.Location = new System.Drawing.Point(0, 0);
            그리드모델.반제품음성검사정보그리드.Margin = new System.Windows.Forms.Padding(0);
            그리드모델.반제품음성검사정보그리드.Name = "반제품음성검사정보그리드";
            그리드모델.반제품음성검사정보그리드.RowTemplate.Height = 23;
            그리드모델.반제품음성검사정보그리드.Size = new System.Drawing.Size(254, 423);
            그리드모델.반제품음성검사정보그리드.TabIndex = 0;

            그리드모델.반응성검사이력그리드.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            그리드모델.반응성검사이력그리드.Dock = System.Windows.Forms.DockStyle.Fill;
            그리드모델.반응성검사이력그리드.Location = new System.Drawing.Point(0, 0);
            그리드모델.반응성검사이력그리드.Margin = new System.Windows.Forms.Padding(0);
            그리드모델.반응성검사이력그리드.Name = "반응성검사이력그리드";
            그리드모델.반응성검사이력그리드.RowTemplate.Height = 23;
            그리드모델.반응성검사이력그리드.Size = new System.Drawing.Size(254, 423);
            그리드모델.반응성검사이력그리드.TabIndex = 0;

            그리드모델.WORKINGTANK물성검사이력그리드.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            그리드모델.WORKINGTANK물성검사이력그리드.Dock = System.Windows.Forms.DockStyle.Fill;
            그리드모델.WORKINGTANK물성검사이력그리드.Location = new System.Drawing.Point(0, 0);
            그리드모델.WORKINGTANK물성검사이력그리드.Margin = new System.Windows.Forms.Padding(0);
            그리드모델.WORKINGTANK물성검사이력그리드.Name = "WORKINGTANK물성검사이력그리드";
            그리드모델.WORKINGTANK물성검사이력그리드.RowTemplate.Height = 23;
            그리드모델.WORKINGTANK물성검사이력그리드.Size = new System.Drawing.Size(254, 423);
            그리드모델.WORKINGTANK물성검사이력그리드.TabIndex = 0;

            반제품LOT이력그리드초기화();
            원자재소진정보그리드();
            반제품음성검사정보그리드();
            반응성검사이력그리드();
            WORKINGTANK물성검사이력그리드();

            Hashtable Param = new Hashtable();
            this.그리드모델.반제품LOT이력그리드.바인딩(서비스.조회수행("생산LOT추적", Param));
            this.그리드모델.원자재소진정보그리드.바인딩(서비스.조회수행("생산LOT추적", Param));
            this.그리드모델.반제품음성검사정보그리드.바인딩(서비스.조회수행("생산LOT추적", Param));
            this.그리드모델.반응성검사이력그리드.바인딩(서비스.조회수행("생산LOT추적", Param));
            this.그리드모델.WORKINGTANK물성검사이력그리드.바인딩(서비스.조회수행("생산LOT추적", Param));
        }

        private void WORKINGTANK물성검사이력그리드()
        {
            DexGridColumn[] 컬럼들 = new DexGridColumn[10];
            컬럼들[0] = new DexGridColumn();
            컬럼들[0].컬럼명 = "LOTID";
            컬럼들[0].헤더명 = "순번";
            컬럼들[0].너비 = 100;

            컬럼들[1] = new DexGridColumn();
            컬럼들[1].컬럼명 = "PRODUCTDEFINITIONID";
            컬럼들[1].헤더명 = "검사일시";
            컬럼들[1].너비 = 100;

            컬럼들[2] = new DexGridColumn();
            컬럼들[2].컬럼명 = "PRODUCTDEFINITIONNAME";
            컬럼들[2].헤더명 = "판정";
            컬럼들[2].너비 = 100;

            컬럼들[3] = new DexGridColumn();
            컬럼들[3].컬럼명 = "ACTIVITY";
            컬럼들[3].헤더명 = "특채여부";
            컬럼들[3].너비 = 100;

            컬럼들[4] = new DexGridColumn();
            컬럼들[4].컬럼명 = "STATE";
            컬럼들[4].헤더명 = "검사자";
            컬럼들[4].너비 = 100;

            컬럼들[5] = new DexGridColumn();
            컬럼들[5].컬럼명 = "QTY";
            컬럼들[5].헤더명 = "특채자";
            컬럼들[5].너비 = 100;

            컬럼들[6] = new DexGridColumn();
            컬럼들[6].컬럼명 = "UNITID";
            컬럼들[6].헤더명 = "특채일시";
            컬럼들[6].너비 = 100;

            컬럼들[7] = new DexGridColumn();
            컬럼들[7].컬럼명 = "EQUIPMENTID";
            컬럼들[7].헤더명 = "정도";
            컬럼들[7].너비 = 100;

            컬럼들[8] = new DexGridColumn();
            컬럼들[8].컬럼명 = "EQUIPMENTNAME";
            컬럼들[8].헤더명 = "수분";
            컬럼들[8].너비 = 100;

            컬럼들[9] = new DexGridColumn();
            컬럼들[9].컬럼명 = "TRACKINTIME";
            컬럼들[9].헤더명 = "OHV";
            컬럼들[9].너비 = 100;

            그리드모델.WORKINGTANK물성검사이력그리드.열생성(컬럼들);
        }

        private void 반응성검사이력그리드()
        {
            DexGridColumn[] 컬럼들 = new DexGridColumn[13];
            컬럼들[0] = new DexGridColumn();
            컬럼들[0].컬럼명 = "LOTID";
            컬럼들[0].헤더명 = "순번";
            컬럼들[0].너비 = 100;

            컬럼들[1] = new DexGridColumn();
            컬럼들[1].컬럼명 = "PRODUCTDEFINITIONID";
            컬럼들[1].헤더명 = "검사일시";
            컬럼들[1].너비 = 100;

            컬럼들[2] = new DexGridColumn();
            컬럼들[2].컬럼명 = "PRODUCTDEFINITIONNAME";
            컬럼들[2].헤더명 = "판정";
            컬럼들[2].너비 = 100;

            컬럼들[3] = new DexGridColumn();
            컬럼들[3].컬럼명 = "ACTIVITY";
            컬럼들[3].헤더명 = "특채여부";
            컬럼들[3].너비 = 100;

            컬럼들[4] = new DexGridColumn();
            컬럼들[4].컬럼명 = "STATE";
            컬럼들[4].헤더명 = "검사자";
            컬럼들[4].너비 = 100;

            컬럼들[5] = new DexGridColumn();
            컬럼들[5].컬럼명 = "QTY";
            컬럼들[5].헤더명 = "특채자";
            컬럼들[5].너비 = 100;

            컬럼들[6] = new DexGridColumn();
            컬럼들[6].컬럼명 = "UNITID";
            컬럼들[6].헤더명 = "특채일시";
            컬럼들[6].너비 = 100;

            컬럼들[7] = new DexGridColumn();
            컬럼들[7].컬럼명 = "EQUIPMENTID";
            컬럼들[7].헤더명 = "CT";
            컬럼들[7].너비 = 100;

            컬럼들[8] = new DexGridColumn();
            컬럼들[8].컬럼명 = "EQUIPMENTNAME";
            컬럼들[8].헤더명 = "CHT";
            컬럼들[8].너비 = 100;

            컬럼들[9] = new DexGridColumn();
            컬럼들[9].컬럼명 = "TRACKINTIME";
            컬럼들[9].헤더명 = "GT";
            컬럼들[9].너비 = 100;

            컬럼들[10] = new DexGridColumn();
            컬럼들[10].컬럼명 = "TRACKINTIME";
            컬럼들[10].헤더명 = "RT";
            컬럼들[10].너비 = 100;

            컬럼들[11] = new DexGridColumn();
            컬럼들[11].컬럼명 = "TRACKINTIME";
            컬럼들[11].헤더명 = "중량";
            컬럼들[11].너비 = 100;

            컬럼들[12] = new DexGridColumn();
            컬럼들[12].컬럼명 = "TRACKINTIME";
            컬럼들[12].헤더명 = "검사시간";
            컬럼들[12].너비 = 100;

            그리드모델.반응성검사이력그리드.열생성(컬럼들);
        }

        private void 반제품음성검사정보그리드()
        {
            DexGridColumn[] 컬럼들 = new DexGridColumn[10];
            컬럼들[0] = new DexGridColumn();
            컬럼들[0].컬럼명 = "LOTID";
            컬럼들[0].헤더명 = "순번";
            컬럼들[0].너비 = 100;

            컬럼들[1] = new DexGridColumn();
            컬럼들[1].컬럼명 = "PRODUCTDEFINITIONID";
            컬럼들[1].헤더명 = "검사일시";
            컬럼들[1].너비 = 100;

            컬럼들[2] = new DexGridColumn();
            컬럼들[2].컬럼명 = "PRODUCTDEFINITIONNAME";
            컬럼들[2].헤더명 = "판정";
            컬럼들[2].너비 = 100;

            컬럼들[3] = new DexGridColumn();
            컬럼들[3].컬럼명 = "ACTIVITY";
            컬럼들[3].헤더명 = "특채여부";
            컬럼들[3].너비 = 100;

            컬럼들[4] = new DexGridColumn();
            컬럼들[4].컬럼명 = "STATE";
            컬럼들[4].헤더명 = "검사자";
            컬럼들[4].너비 = 100;

            컬럼들[5] = new DexGridColumn();
            컬럼들[5].컬럼명 = "QTY";
            컬럼들[5].헤더명 = "특채자";
            컬럼들[5].너비 = 100;

            컬럼들[6] = new DexGridColumn();
            컬럼들[6].컬럼명 = "UNITID";
            컬럼들[6].헤더명 = "특채일시";
            컬럼들[6].너비 = 100;

            컬럼들[7] = new DexGridColumn();
            컬럼들[7].컬럼명 = "EQUIPMENTID";
            컬럼들[7].헤더명 = "정도";
            컬럼들[7].너비 = 100;

            컬럼들[8] = new DexGridColumn();
            컬럼들[8].컬럼명 = "EQUIPMENTNAME";
            컬럼들[8].헤더명 = "수분";
            컬럼들[8].너비 = 100;

            컬럼들[9] = new DexGridColumn();
            컬럼들[9].컬럼명 = "TRACKINTIME";
            컬럼들[9].헤더명 = "OHV";
            컬럼들[9].너비 = 100;

            그리드모델.반제품음성검사정보그리드.열생성(컬럼들);
        }

        private void 원자재소진정보그리드()
        {
            DexGridColumn[] 컬럼들 = new DexGridColumn[11];
            컬럼들[0] = new DexGridColumn();
            컬럼들[0].컬럼명 = "LOTID";
            컬럼들[0].헤더명 = "자재LOT";
            컬럼들[0].너비 = 100;

            컬럼들[1] = new DexGridColumn();
            컬럼들[1].컬럼명 = "PRODUCTDEFINITIONID";
            컬럼들[1].헤더명 = "자재코드";
            컬럼들[1].너비 = 100;

            컬럼들[2] = new DexGridColumn();
            컬럼들[2].컬럼명 = "PRODUCTDEFINITIONNAME";
            컬럼들[2].헤더명 = "자재명";
            컬럼들[2].너비 = 100;

            컬럼들[3] = new DexGridColumn();
            컬럼들[3].컬럼명 = "ACTIVITY";
            컬럼들[3].헤더명 = "투입수량";
            컬럼들[3].너비 = 100;

            컬럼들[4] = new DexGridColumn();
            컬럼들[4].컬럼명 = "STATE";
            컬럼들[4].헤더명 = "총량";
            컬럼들[4].너비 = 100;

            컬럼들[5] = new DexGridColumn();
            컬럼들[5].컬럼명 = "QTY";
            컬럼들[5].헤더명 = "단위";
            컬럼들[5].너비 = 100;

            컬럼들[6] = new DexGridColumn();
            컬럼들[6].컬럼명 = "UNITID";
            컬럼들[6].헤더명 = "설비";
            컬럼들[6].너비 = 100;

            컬럼들[7] = new DexGridColumn();
            컬럼들[7].컬럼명 = "EQUIPMENTID";
            컬럼들[7].헤더명 = "설비명";
            컬럼들[7].너비 = 100;

            컬럼들[8] = new DexGridColumn();
            컬럼들[8].컬럼명 = "EQUIPMENTNAME";
            컬럼들[8].헤더명 = "투입일시";
            컬럼들[8].너비 = 100;

            컬럼들[9] = new DexGridColumn();
            컬럼들[9].컬럼명 = "TRACKINTIME";
            컬럼들[9].헤더명 = "입고일";
            컬럼들[9].너비 = 100;

            컬럼들[10] = new DexGridColumn();
            컬럼들[10].컬럼명 = "TRACKINTIME";
            컬럼들[10].헤더명 = "스캔일시";
            컬럼들[10].너비 = 100;

            그리드모델.원자재소진정보그리드.열생성(컬럼들);
        }

        private void 반제품LOT이력그리드초기화()
        {
            DexGridColumn[] 컬럼들 = new DexGridColumn[12];
            컬럼들[0] = new DexGridColumn();
            컬럼들[0].컬럼명 = "LOTID";
            컬럼들[0].헤더명 = "생산LOT";
            컬럼들[0].너비 = 100;

            컬럼들[1] = new DexGridColumn();
            컬럼들[1].컬럼명 = "PRODUCTDEFINITIONID";
            컬럼들[1].헤더명 = "제품코드";
            컬럼들[1].너비 = 100;

            컬럼들[2] = new DexGridColumn();
            컬럼들[2].컬럼명 = "PRODUCTDEFINITIONNAME";
            컬럼들[2].헤더명 = "제품명";
            컬럼들[2].너비 = 100;

            컬럼들[3] = new DexGridColumn();
            컬럼들[3].컬럼명 = "ACTIVITY";
            컬럼들[3].헤더명 = "액티비티";
            컬럼들[3].너비 = 100;

            컬럼들[4] = new DexGridColumn();
            컬럼들[4].컬럼명 = "STATE";
            컬럼들[4].헤더명 = "상태";
            컬럼들[4].너비 = 100;

            컬럼들[5] = new DexGridColumn();
            컬럼들[5].컬럼명 = "QTY";
            컬럼들[5].헤더명 = "수량";
            컬럼들[5].너비 = 100;

            컬럼들[6] = new DexGridColumn();
            컬럼들[6].컬럼명 = "UNITID";
            컬럼들[6].헤더명 = "단위";
            컬럼들[6].너비 = 100;

            컬럼들[7] = new DexGridColumn();
            컬럼들[7].컬럼명 = "EQUIPMENTID";
            컬럼들[7].헤더명 = "투입설비";
            컬럼들[7].너비 = 100;

            컬럼들[8] = new DexGridColumn();
            컬럼들[8].컬럼명 = "EQUIPMENTNAME";
            컬럼들[8].헤더명 = "설비명";
            컬럼들[8].너비 = 100;

            컬럼들[9] = new DexGridColumn();
            컬럼들[9].컬럼명 = "TRACKINTIME";
            컬럼들[9].헤더명 = "투입일시";
            컬럼들[9].너비 = 100;

            컬럼들[10] = new DexGridColumn();
            컬럼들[10].컬럼명 = "TRACKOUTTIME";
            컬럼들[10].헤더명 = "완료일시";
            컬럼들[10].너비 = 100;

            컬럼들[11] = new DexGridColumn();
            컬럼들[11].컬럼명 = "MODIFYTIME";
            컬럼들[11].헤더명 = "시스템수정일시";
            컬럼들[11].너비 = 100;

            그리드모델.반제품LOT이력그리드.열생성(컬럼들);
        }

        private void Maingrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            그리드그룹완제품초기화();
        
        }

        private void 그리드그룹반제품상세초기화()
        {
            GridGroups = new TableLayoutPanel();
            GridGroups.ColumnCount = 1;
            GridGroups.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            GridGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            GridGroups.Location = new System.Drawing.Point(250, 0);
            GridGroups.Margin = new System.Windows.Forms.Padding(0);
            GridGroups.Name = "GridGroups";
            GridGroups.RowCount = 1;
            GridGroups.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            GridGroups.Size = new System.Drawing.Size(696, 423);
            GridGroups.TabIndex = 1;

            GridGroups.Controls.Add(그리드모델.원자재LOT이력그리드, 0, 0);

            그리드모델.원자재LOT이력그리드.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            그리드모델.원자재LOT이력그리드.Dock = System.Windows.Forms.DockStyle.Fill;
            그리드모델.원자재LOT이력그리드.Location = new System.Drawing.Point(0, 0);
            그리드모델.원자재LOT이력그리드.Margin = new System.Windows.Forms.Padding(0);
            그리드모델.원자재LOT이력그리드.Name = "원자재LOT이력그리드";
            그리드모델.원자재LOT이력그리드.RowTemplate.Height = 23;
            그리드모델.원자재LOT이력그리드.Size = new System.Drawing.Size(254, 423);
            그리드모델.원자재LOT이력그리드.TabIndex = 0;

            원자재LOT이력그리드();
        }

        private void 원자재LOT이력그리드()
        {
            DexGridColumn[] 컬럼들 = new DexGridColumn[10];
            컬럼들[0] = new DexGridColumn();
            컬럼들[0].컬럼명 = "LOTID";
            컬럼들[0].헤더명 = "자재LOT";
            컬럼들[0].너비 = 100;

            컬럼들[1] = new DexGridColumn();
            컬럼들[1].컬럼명 = "PRODUCTDEFINITIONID";
            컬럼들[1].헤더명 = "자재구분명";
            컬럼들[1].너비 = 100;

            컬럼들[2] = new DexGridColumn();
            컬럼들[2].컬럼명 = "PRODUCTDEFINITIONNAME";
            컬럼들[2].헤더명 = "자재코드";
            컬럼들[2].너비 = 100;

            컬럼들[3] = new DexGridColumn();
            컬럼들[3].컬럼명 = "ACTIVITY";
            컬럼들[3].헤더명 = "자재명";
            컬럼들[3].너비 = 100;

            컬럼들[4] = new DexGridColumn();
            컬럼들[4].컬럼명 = "ACTIVITY";
            컬럼들[4].헤더명 = "액티비티";
            컬럼들[4].너비 = 100;

            컬럼들[5] = new DexGridColumn();
            컬럼들[5].컬럼명 = "QTY";
            컬럼들[5].헤더명 = "상태";
            컬럼들[5].너비 = 100;

            컬럼들[6] = new DexGridColumn();
            컬럼들[6].컬럼명 = "UNITID";
            컬럼들[6].헤더명 = "수량";
            컬럼들[6].너비 = 100;

            컬럼들[7] = new DexGridColumn();
            컬럼들[7].컬럼명 = "EQUIPMENTID";
            컬럼들[7].헤더명 = "단위";
            컬럼들[7].너비 = 100;

            컬럼들[8] = new DexGridColumn();
            컬럼들[8].컬럼명 = "EQUIPMENTNAME";
            컬럼들[8].헤더명 = "위치";
            컬럼들[8].너비 = 100;

            컬럼들[9] = new DexGridColumn();
            컬럼들[9].컬럼명 = "TRACKINTIME";
            컬럼들[9].헤더명 = "설비명";
            컬럼들[9].너비 = 100;

            그리드모델.원자재LOT이력그리드.열생성(컬럼들);
        }

        private void Maingrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            그리드그룹완제품초기화();
        }
    }
}
