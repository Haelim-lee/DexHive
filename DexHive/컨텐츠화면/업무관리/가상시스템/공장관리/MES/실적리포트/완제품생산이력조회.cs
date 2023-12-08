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
    public partial class 완제품생산이력조회 : 스크린,I스크린
    {
        public 완제품생산이력표_모델 그리드모델 { get; set; }
        public 완제품생산이력검색_모델 검색조건모델 { get; set; }

        public 완제품생산이력조회()
        {
            InitializeComponent();
            InitializeProperty();
            InitializeEvent();
        }

        private void InitializeEvent()
        {
            this.Shown += 완제품생산이력조회_Shown;

            this.기본기능.조회버튼.Click += (object sender, EventArgs e) => 조회();
            this.기본기능.저장버튼.Click += (object sender, EventArgs e) => 저장();
            this.기본기능.행추가버튼.Click += (object sender, EventArgs e) => 행추가();
            this.기본기능.행제거버튼.Click += (object sender, EventArgs e) => 행제거();
        }

        private void 완제품생산이력조회_Shown(object sender, EventArgs e)
        {
            그리드초기화();
            그리드상세초기화();
            콤보박스초기화();
            조회();
        }

        private void 콤보박스초기화()
        {
            Hashtable Param = new Hashtable();
            Param["코드그룹"] = "생산LOT";
            검색조건모델.제품군.DataSource = 서비스.조회수행("공통코드", Param);
            검색조건모델.제품군.DisplayMember = "명칭";
            검색조건모델.제품군.ValueMember = "코드";


            Param = new Hashtable();
            Param["코드그룹"] = "제품";

            검색조건모델.제품.DataSource = 서비스.조회수행("공통코드", Param);
            검색조건모델.제품.DisplayMember = "명칭";
            검색조건모델.제품.ValueMember = "코드";

            Param = new Hashtable();
            Param["코드그룹"] = "자재코드";
            검색조건모델.생산계획오더.DataSource = 서비스.조회수행("공통코드", Param);
            검색조건모델.생산계획오더.DisplayMember = "명칭";
            검색조건모델.생산계획오더.ValueMember = "코드";
        }

        private void 그리드상세초기화()
        {
            DexGridColumn[] 컬럼들 = new DexGridColumn[9];
            컬럼들[0] = new DexGridColumn();
            컬럼들[0].컬럼명 = "LOTID";
            컬럼들[0].헤더명 = "생산LOT";
            컬럼들[0].너비 = 150;

            컬럼들[1] = new DexGridColumn();
            컬럼들[1].컬럼명 = "MATERIALDEFINITIONID";
            컬럼들[1].헤더명 = "자재코드";
            컬럼들[1].너비 = 100;

            컬럼들[2] = new DexGridColumn();
            컬럼들[2].컬럼명 = "MATERIALDEFINITIONNAME";
            컬럼들[2].헤더명 = "자재명";
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
            컬럼들[7].컬럼명 = "PRODUCTTYPE";
            컬럼들[7].헤더명 = "설비명";
            컬럼들[7].너비 = 100;

            컬럼들[8] = new DexGridColumn();
            컬럼들[8].컬럼명 = "LASTEVENTTIME";
            컬럼들[8].헤더명 = "시스템수정일시";
            컬럼들[8].너비 = 100;

            그리드모델.그리드상세.열생성(컬럼들);
        }

        private void 그리드초기화()
        {
            DexGridColumn[] 컬럼들 = new DexGridColumn[12];
            컬럼들[0] = new DexGridColumn();
            컬럼들[0].컬럼명 = "LOTID";
            컬럼들[0].헤더명 = "생산LOT";
            컬럼들[0].너비 = 100;

            컬럼들[1] = new DexGridColumn();
            컬럼들[1].컬럼명 = "PARENTLOTID";
            컬럼들[1].헤더명 = "모 LOT ID";
            컬럼들[1].너비 = 100;

            컬럼들[2] = new DexGridColumn();
            컬럼들[2].컬럼명 = "PRODUCTORDERID";
            컬럼들[2].헤더명 = "생산계획오더";
            컬럼들[2].너비 = 100;

            컬럼들[3] = new DexGridColumn();
            컬럼들[3].컬럼명 = "PRODUCTDEFINITIONID";
            컬럼들[3].헤더명 = "제품코드";
            컬럼들[3].너비 = 100;

            컬럼들[4] = new DexGridColumn();
            컬럼들[4].컬럼명 = "PRODUCTDEFINITIONNAME";
            컬럼들[4].헤더명 = "제품명";
            컬럼들[4].너비 = 100;

            컬럼들[5] = new DexGridColumn();
            컬럼들[5].컬럼명 = "ORIGINALQTY";
            컬럼들[5].헤더명 = "계획수량";
            컬럼들[5].너비 = 100;

            컬럼들[6] = new DexGridColumn();
            컬럼들[6].컬럼명 = "QTY+DEFECTQTY+LOSSQTY+SAMPLEQTY";
            컬럼들[6].헤더명 = "투입수량";
            컬럼들[6].너비 = 100;

            컬럼들[7] = new DexGridColumn();
            컬럼들[7].컬럼명 = "QTY";
            컬럼들[7].헤더명 = "양품수량";
            컬럼들[7].너비 = 100;

            컬럼들[8] = new DexGridColumn();
            컬럼들[8].컬럼명 = "DEFECTQTY+LOSSQTY";
            컬럼들[8].헤더명 = "폐기수량";
            컬럼들[8].너비 = 100;

            컬럼들[9] = new DexGridColumn();
            컬럼들[9].컬럼명 = "UNITID";
            컬럼들[9].헤더명 = "단위";
            컬럼들[9].너비 = 100;

            컬럼들[10] = new DexGridColumn();
            컬럼들[10].컬럼명 = "EQUIPMENTID";
            컬럼들[10].헤더명 = "투입설비";
            컬럼들[10].너비 = 100;

            컬럼들[11] = new DexGridColumn();
            컬럼들[11].컬럼명 = "STATE";
            컬럼들[11].헤더명 = "LOT 진행상태";
            컬럼들[11].너비 = 100;

            그리드모델.그리드.열생성(컬럼들);
        }

        private void InitializeProperty()
        {
            그리드모델 = new 완제품생산이력표_모델();
            그리드모델.그리드 = this.완제품생산이력표_모델;
            그리드모델.그리드상세 = this.완제품생산이력표_모델2;
            그리드모델.그리드.기본테이블명 = "CIM_PRODUCTORDER";
            

            검색조건모델 = new 완제품생산이력검색_모델();
            검색조건모델.날짜검색_시작 = this.dateTimePicker1;
            검색조건모델.날짜검색_종료 = this.dateTimePicker2;
            검색조건모델.제품군 = this.제품군CBX;
            검색조건모델.제품 = this.제품CBX;
            검색조건모델.생산계획오더 = this.생산계획오더CBX;
            

            검색조건모델.날짜검색_시작.Value = DateTime.Now.AddDays(-7);
            검색조건모델.날짜검색_종료.Value = DateTime.Now;
            검색조건모델.제품군.SelectedIndex = -1;
            검색조건모델.제품.SelectedIndex = -1;
            검색조건모델.생산계획오더.SelectedIndex = -1;
        }

        public void 저장()
        {
            그리드모델.그리드.CurrentCell = null;
            DataTable 반영표 = 그리드모델.그리드.DataSource as DataTable;
            그리드모델.그리드.반영(반영표, 서비스);
            조회();
        }

        public void 조회()
        {
            Hashtable Param = new Hashtable();
            Param["LOTID"] = string.IsNullOrEmpty(검색조건모델.제품군.SelectedValue as string) ? string.Empty : 검색조건모델.제품군.SelectedValue as string;
            Param["PRODUCTDEFINITIONNAME"] = string.IsNullOrEmpty(검색조건모델.제품.SelectedValue as string) ? string.Empty : 검색조건모델.제품.SelectedValue as string;
            Param["PRODUCTORDERID"] = string.IsNullOrEmpty(검색조건모델.생산계획오더.SelectedValue as string) ? string.Empty : 검색조건모델.생산계획오더.SelectedValue as string;

            this.그리드모델.그리드.바인딩(서비스.조회수행("제품생산이력조회", Param));
            this.그리드모델.그리드상세.바인딩(서비스.조회수행("LOT이력정보조회", Param));
        }

        public void 초기화()
        {
            throw new NotImplementedException();
        }

        public void 행제거()
        {
            if (그리드모델.그리드.CurrentRow != null)
                if ((DataRowView)그리드모델.그리드.CurrentRow.DataBoundItem != null)
                {
                    bool a = 그리드모델.그리드.CurrentRow.IsNewRow;
                    DataRow DR = ((DataRowView)그리드모델.그리드.CurrentRow.DataBoundItem).Row;
                    그리드모델.그리드.Rows.Remove(그리드모델.그리드.CurrentRow);
                }
        }

        public void 행추가()
        {
            if (그리드모델.그리드.DataSource == null) 조회();
            ((DataTable)그리드모델.그리드.DataSource).Rows.Add();
        }
    }
}
