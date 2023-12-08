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

namespace DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.품질관리.반제품_품질검사
{
    public partial class 반제품_품질검사 : 스크린,I스크린
    {
        public 반제품품질검사그리드 그리드모델 { get;set; }
        public 반제품검색조건모델 검색조건모델 { get; set; }
        public 반제품_품질검사()
        {
            InitializeComponent();
            InitializeProperty();
            InitializeEvnet();
        }

        private void InitializeEvnet()
        {
            this.Shown += 반제품_품질검사_Shown;
            this.기본기능.조회버튼.Click += (object sender, EventArgs e) => 조회();
        }

        private void 반제품_품질검사_Shown(object sender, EventArgs e)
        {
            InitializeComboBox();
            InitializeMainGrid();
            InitializecategoryGrid();
            InitializeJudgmentGrid();
            this.기본기능.행제거버튼.Visible = false;
            this.기본기능.행추가버튼.Visible = false;
            this.기본기능.저장버튼.Visible = false;
        }

        private void InitializeJudgmentGrid()
        {
            //물성검사이력그리드
            DexGridColumn[] 컬럼들 = new DexGridColumn[8];
            컬럼들[0] = new DexGridColumn();
            컬럼들[0].컬럼명 = "JUDGEINPUTTIME";
            컬럼들[0].헤더명 = "검사입력일시";
            컬럼들[0].너비 = 80;

            컬럼들[1] = new DexGridColumn();
            컬럼들[1].컬럼명 = "JUDGE";
            컬럼들[1].헤더명 = "결과 ";
            컬럼들[1].너비 = 100;

            컬럼들[2] = new DexGridColumn();
            컬럼들[2].컬럼명 = "ISSPECIALPASS";
            컬럼들[2].헤더명 = "특채여부";
            컬럼들[2].너비 = 100;

            컬럼들[3] = new DexGridColumn();
            컬럼들[3].컬럼명 = "";
            컬럼들[3].헤더명 = "점도 ";
            컬럼들[3].너비 = 100;

            컬럼들[4] = new DexGridColumn();
            컬럼들[4].컬럼명 = "";
            컬럼들[4].헤더명 = "수분";
            컬럼들[4].너비 = 100;

            컬럼들[5] = new DexGridColumn();
            컬럼들[5].컬럼명 = "JUDGEUSER";
            컬럼들[5].헤더명 = "검사자";
            컬럼들[5].너비 = 100;

            컬럼들[6] = new DexGridColumn();
            컬럼들[6].컬럼명 = "SPECIALPASSUSER";
            컬럼들[6].헤더명 = "특채자";
            컬럼들[6].너비 = 100;

            컬럼들[7] = new DexGridColumn();
            컬럼들[7].컬럼명 = "SPECIALPASSTIME";
            컬럼들[7].헤더명 = "특채시간";
            컬럼들[7].너비 = 100;

            this.그리드모델.물성검사이력그리드.열생성(컬럼들);
        }

        private void InitializecategoryGrid()
        {
            //물성검사입력그리드
            DexGridColumn[] 컬럼들 = new DexGridColumn[6];
            컬럼들[0] = new DexGridColumn();
            컬럼들[0].컬럼명 = "PROCESSDATAPARAMETERNAME";
            컬럼들[0].헤더명 = "항목";
            컬럼들[0].너비 = 80;

            컬럼들[1] = new DexGridColumn();
            컬럼들[1].컬럼명 = "TARGET";
            컬럼들[1].헤더명 = "기준 ";
            컬럼들[1].너비 = 100;

            컬럼들[2] = new DexGridColumn();
            컬럼들[2].컬럼명 = "LOWERLIMIT";
            컬럼들[2].헤더명 = "하한";
            컬럼들[2].너비 = 100;

            컬럼들[3] = new DexGridColumn();
            컬럼들[3].컬럼명 = "UPPERLIMIT";
            컬럼들[3].헤더명 = "상한  ";
            컬럼들[3].너비 = 100;

            컬럼들[4] = new DexGridColumn();
            컬럼들[4].컬럼명 = "UNITID";
            컬럼들[4].헤더명 = "단위";
            컬럼들[4].너비 = 100;

            컬럼들[5] = new DexGridColumn();
            컬럼들[5].컬럼명 = "";
            컬럼들[5].헤더명 = "측정값";
            컬럼들[5].너비 = 100;

            this.그리드모델.물성검사입력그리드.열생성(컬럼들);

        }
        private void InitializeMainGrid()
        {
            DexGridColumn[] 컬럼들 = new DexGridColumn[14];
            컬럼들[0] = new DexGridColumn();
            컬럼들[0].컬럼명 = "EQUIPMENTNAME";
            컬럼들[0].헤더명 = "설비";
            컬럼들[0].너비 = 80;

            컬럼들[1] = new DexGridColumn();
            컬럼들[1].컬럼명 = "JUDGE";
            컬럼들[1].헤더명 = "판정결과 ";
            컬럼들[1].너비 = 100;

            컬럼들[2] = new DexGridColumn();
            컬럼들[2].컬럼명 = "ISSPECIALPASS";
            컬럼들[2].헤더명 = "특채여부";
            컬럼들[2].너비 = 100;

            컬럼들[3] = new DexGridColumn();
            컬럼들[3].컬럼명 = "PRODUCTORDERID";
            컬럼들[3].헤더명 = "생산계획오더 ";
            컬럼들[3].너비 = 100;

            컬럼들[4] = new DexGridColumn();
            컬럼들[4].컬럼명 = "PRODUCTORDERTYPE";
            컬럼들[4].헤더명 = "생산계획타입";
            컬럼들[4].너비 = 100;

            컬럼들[5] = new DexGridColumn();
            컬럼들[5].컬럼명 = "LOTID";
            컬럼들[5].헤더명 = "LOTID";
            컬럼들[5].너비 = 100;

            컬럼들[6] = new DexGridColumn();
            컬럼들[6].컬럼명 = "PRODUCTDEFINITIONID";
            컬럼들[6].헤더명 = "반제품코드";
            컬럼들[6].너비 = 100;

            컬럼들[7] = new DexGridColumn();
            컬럼들[7].컬럼명 = "PRODUCTDEFINITIONNAME";
            컬럼들[7].헤더명 = "반제품명";
            컬럼들[7].너비 = 100;

            컬럼들[8] = new DexGridColumn();
            컬럼들[8].컬럼명 = "QTY ";
            컬럼들[8].헤더명 = "수량 ";
            컬럼들[8].너비 = 100;

            컬럼들[9] = new DexGridColumn();
            컬럼들[9].컬럼명 = "UNITID ";
            컬럼들[9].헤더명 = "단위";
            컬럼들[9].너비 = 100;

            컬럼들[10] = new DexGridColumn();
            컬럼들[10].컬럼명 = "JUDGEINPUTTIME";
            컬럼들[10].헤더명 = "검사입력일시";
            컬럼들[10].너비 = 100;

            컬럼들[11] = new DexGridColumn();
            컬럼들[11].컬럼명 = "JUDGEUSER";
            컬럼들[11].헤더명 = "검사자  ";
            컬럼들[11].너비 = 100;

            컬럼들[12] = new DexGridColumn();
            컬럼들[12].컬럼명 = "SPECIALPASSTIME";
            컬럼들[12].헤더명 = "특채시간";
            컬럼들[12].너비 = 100;

            컬럼들[13] = new DexGridColumn();
            컬럼들[13].컬럼명 = "SPECIALPASSUSER";
            컬럼들[13].헤더명 = "특채자";
            컬럼들[13].너비 = 100;

            그리드모델.메인그리드.열생성(컬럼들);
        }

        private void InitializeComboBox()
        {
            Hashtable Param = new Hashtable();
            Param = new Hashtable();
            Param["코드그룹"] = "제품구분";
            ComboBoxBinding(검색조건모델.제품구분, "공통코드", Param, false);

            Param = new Hashtable();
            검색조건모델.설비.DataSource = 서비스.GetDataTable("SELECT EQUIPMENTID ,EQUIPMENTNAME FROM CIM_EQUIPMENT ");
            검색조건모델.설비.DisplayMember = "EQUIPMENTNAME";
            검색조건모델.설비.ValueMember = "EQUIPMENTID";

            Param = new Hashtable();
            검색조건모델.반제품.DataSource = 서비스.GetDataTable("SELECT PRODUCTDEFINITIONNAME, PRODUCTDEFINITIONID FROM CIM_PRODUCTDEFINITION ");
            검색조건모델.반제품.DisplayMember = "PRODUCTDEFINITIONNAME";
            검색조건모델.반제품.ValueMember = "PRODUCTDEFINITIONID";
        }

        private void InitializeProperty()
        {
            그리드모델 = new 반제품품질검사그리드();
            그리드모델.메인그리드 = 메인그리드;
            그리드모델.물성검사입력그리드 = 물성검사입력그리드;
            그리드모델.물성검사이력그리드 = 물성검사이력그리드;

            검색조건모델 = new 반제품검색조건모델();
            검색조건모델.제품구분 = CBO제품구분;
            검색조건모델.설비 = CBO설비;
            검색조건모델.반제품 = CBO반제품;
            검색조건모델.LOT설비 = TXB설비;
            검색조건모델.생산계획오더 = TXB생산계획오더;
            검색조건모델.반제품명 = TXB반제품명;
            검색조건모델.LOTID = TXBLOTID;
            검색조건모델.생산계획타입 = TXB생산계획타입;
            검색조건모델.수량 = TXBQTY;
            검색조건모델.수량타입 = TXBQTY2;

        }

        public void 조회()
        {
            Dictionary<string, Hashtable> 입력매개변수 = new Dictionary<string, Hashtable>();
            Dictionary<string, Hashtable> 출력매개변수 = new Dictionary<string, Hashtable>();
            Hashtable 제품구분 = new Hashtable();
            
            Hashtable 설비 = new Hashtable();
            설비["값"] = string.IsNullOrEmpty(검색조건모델.설비.SelectedValue as string) ? string.Empty : "%" + (검색조건모델.설비.SelectedValue as string)+ "%" ;
            설비["자료형"] = "VARCHAR";
            설비["방향"] = false;

            Hashtable 반제품 = new Hashtable();
            반제품["값"] = string.IsNullOrEmpty(검색조건모델.반제품.SelectedValue as string) ? string.Empty : "%"+(검색조건모델.반제품.SelectedValue as string)+"%";
            반제품["자료형"] = "VARCHAR";
            반제품["방향"] = false;

            입력매개변수.Add("@EQUIPMENTID", 설비);
            입력매개변수.Add("@PRODUCTDEFINITIONID", 반제품);
            DataSet ResultTable = this.서비스.프로시저호출("반제품_품질검사_결과조회", 입력매개변수, 출력매개변수);
            this.그리드모델.메인그리드.바인딩(ResultTable.Tables[0]);
        }

        public void 저장()
        {
            throw new NotImplementedException();
        }

        public void 행제거()
        {
            throw new NotImplementedException();
        }

        public void 행추가()
        {
            throw new NotImplementedException();
        }

        public void 초기화()
        {
            throw new NotImplementedException();
        }

       
    }
}
