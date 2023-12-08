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

namespace DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.작업지시
{
    public partial class 작업지시조회 : 스크린, I스크린
    {
        public 작업조회모델 작업조회모델 { get; set; }
        public 작업지시그리드 작업지시그리드 { get; set; }

        public 작업지시조회()
        {
            InitializeComponent();
            InitializeProperty();
            InitializeEvent();
        }

        private void InitializeProperty()
        {
            작업조회모델 = new 작업조회모델();
            작업조회모델.제품명 = this.comboBox2;
            작업조회모델.생산구분 = this.comboBox5;
            작업조회모델.LOT상태 = this.comboBox6;
            작업조회모델.날짜검색시작 = this.dateTimePicker1;
            작업조회모델.날짜검색종료 = this.dateTimePicker2;
            작업조회모델.날짜검색시작.Value = DateTime.Now;
            작업조회모델.날짜검색종료.Value = DateTime.Now;

            작업지시그리드 = new 작업지시그리드();
            작업지시그리드.그리드 = this.dexGridView1;
        }

        private void InitializeEvent()
        {
            this.Shown += 생산계획오더조회_Shown;
            this.기본기능.조회버튼.Click += (object sender, EventArgs e) => 조회();
            this.dexGridView1.DataError += DexGridView1_DataError;
        }

        private void DexGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
            MessageBox.Show(e.Exception.Message);
            
        }

        private void 생산계획오더조회_Shown(object sender, EventArgs e)
        {
            InitializeCombobox();
            InitializeGrid();
            this.기본기능.행제거버튼.Visible = false;
            this.기본기능.행추가버튼.Visible = false;
            this.기본기능.저장버튼.Visible = false;
            조회();
        }

        private void InitializeCombobox()
        {
            Hashtable Param = new Hashtable();
            Param = new Hashtable();
            Param["코드그룹"] = "제품";
            ComboBoxBinding(작업조회모델.제품명, "공통코드", Param, false);

            Param = new Hashtable();
            Param["코드그룹"] = "생산구분";
            ComboBoxBinding(작업조회모델.생산구분, "공통코드", Param, false);

            Param = new Hashtable();
            Param["코드그룹"] = "LOT상태";
            ComboBoxBinding(작업조회모델.LOT상태, "공통코드", Param, false);
        }

        private void InitializeGrid()
        {
            DexGridColumn[] 컬럼들 = new DexGridColumn[8];
            컬럼들[0] = new DexGridColumn();
            컬럼들[0].컬럼명 = "STATE";
            컬럼들[0].헤더명 = "상태";
            컬럼들[0].컬럼타입 = 컬럼타입.콤보박스;
            컬럼들[0].콤보박스데이터소스 = 서비스.GetDataTable("SELECT 코드,명칭 FROM 기준정보 WHERE 코드그룹 = 'LOT상태'");
            컬럼들[0].콤보박스디스플레이멤버 = "명칭";
            컬럼들[0].콤보박스벨류멤버 = "코드";
            컬럼들[0].너비 = 80;

            컬럼들[1] = new DexGridColumn();
            컬럼들[1].컬럼명 = "PRODUCTORDERID";
            컬럼들[1].헤더명 = "생산계획오더";
            컬럼들[1].너비 = 100;

            컬럼들[2] = new DexGridColumn();
            컬럼들[2].컬럼명 = "PRODUCTDEFINITIONID";
            컬럼들[2].헤더명 = "제품코드";
            컬럼들[2].너비 = 100;

            컬럼들[3] = new DexGridColumn();
            컬럼들[3].컬럼명 = "PRODUCTORDERNAME";
            컬럼들[3].헤더명 = "제품명";
            컬럼들[3].너비 = 100;

            컬럼들[4] = new DexGridColumn();
            컬럼들[4].컬럼명 = "UNITID";
            컬럼들[4].헤더명 = "단위";
            컬럼들[4].너비 = 80;

            컬럼들[5] = new DexGridColumn();
            컬럼들[5].컬럼명 = "QTY";
            컬럼들[5].헤더명 = "수량";
            컬럼들[5].너비 = 80;

            컬럼들[6] = new DexGridColumn();
            컬럼들[6].컬럼명 = "SCHEDULESTARTTIME";
            컬럼들[6].헤더명 = "계획시작일";
            컬럼들[6].너비 = 80;

            컬럼들[7] = new DexGridColumn();
            컬럼들[7].컬럼명 = "SCHEDULEENDTIME";
            컬럼들[7].헤더명 = "계획종료일";
            컬럼들[7].너비 = 80;

            this.dexGridView1.열생성(컬럼들);
        }

        public void 조회()
        {
            Hashtable Param = new Hashtable();
            Param["SCHEDULESTARTTIME"] = dateTimePicker1.Value.ToShortDateString() + "," + dateTimePicker2.Value.ToShortDateString();
            this.dexGridView1.바인딩(서비스.조회수행("생산계획오더조회", Param));
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
