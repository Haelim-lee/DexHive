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

namespace DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.자재관리
{
    public partial class 자재입고조회 : 스크린,I스크린
    {
        public 자재입고표_모델 그리드모델 { get; set; }
        public 자재검색_모델 검색조건모델 { get; set; }
        

        public 자재입고조회()
        {
            InitializeComponent();
            InitializeProperty();
            InitializeEvent();
        }

        private void InitializeEvent()
        {
            this.Shown += 자재입고조회_Shown;

            this.기본기능.조회버튼.Click += (object sender, EventArgs e) => 조회();
            this.기본기능.저장버튼.Click += (object sender, EventArgs e) => 저장();
            this.기본기능.행추가버튼.Click += (object sender, EventArgs e) => 행추가();
            this.기본기능.행제거버튼.Click += (object sender, EventArgs e) => 행제거();

            //this.검색조건모델.자재위치.SelectedValueChanged += (object sender, EventArgs e) => 컬럼콤보초기화();
        }

        private void 자재입고조회_Shown(object sender, EventArgs e)
        {
            그리드초기화();
            콤보박스초기화();
            조회();
        }

        private void 그리드초기화()
        {
            DexGridColumn[] 컬럼들 = new DexGridColumn[13];
            컬럼들[0] = new DexGridColumn();
            컬럼들[0].컬럼명 = "MATERIALTYPE";
            컬럼들[0].헤더명 = "자재구분";
            컬럼들[0].너비 = 100;

            컬럼들[1] = new DexGridColumn();
            컬럼들[1].컬럼명 = "MATERIALDEFINITIONID";
            컬럼들[1].헤더명 = "자재코드";
            컬럼들[1].너비 = 100;

            컬럼들[2] = new DexGridColumn();
            컬럼들[2].컬럼명 = "MATERIALDEFINITIONNAME";
            컬럼들[2].헤더명 = "자재명";
            컬럼들[2].너비 = 100;

            컬럼들[3] = new DexGridColumn();
            컬럼들[3].컬럼명 = "LOTID";
            컬럼들[3].헤더명 = "자재LOT";
            컬럼들[3].너비 = 100;

            컬럼들[4] = new DexGridColumn();
            컬럼들[4].컬럼명 = "PREVLOCATION";
            컬럼들[4].헤더명 = "이전위치";
            컬럼들[4].너비 = 100;

            컬럼들[5] = new DexGridColumn();
            컬럼들[5].컬럼명 = "LOCATION";
            컬럼들[5].헤더명 = "현위치";
            컬럼들[5].너비 = 100;

            컬럼들[6] = new DexGridColumn();
            컬럼들[6].컬럼명 = "QTY";
            컬럼들[6].헤더명 = "입고수량";
            컬럼들[6].너비 = 100;

            컬럼들[7] = new DexGridColumn();
            컬럼들[7].컬럼명 = "UNITID";
            컬럼들[7].헤더명 = "단위";
            컬럼들[7].너비 = 100;

            컬럼들[8] = new DexGridColumn();
            컬럼들[8].컬럼명 = "CREATETIME";
            컬럼들[8].헤더명 = "입고일";
            컬럼들[8].너비 = 100;

            컬럼들[9] = new DexGridColumn();
            컬럼들[9].컬럼명 = "VENDORID";
            컬럼들[9].헤더명 = "공급사";
            컬럼들[9].너비 = 100;

            컬럼들[10] = new DexGridColumn();
            컬럼들[10].컬럼명 = "PRODUCTTIME";
            컬럼들[10].헤더명 = "생산일";
            컬럼들[10].너비 = 100;

            컬럼들[11] = new DexGridColumn();
            컬럼들[11].컬럼명 = "LIMIT";
            컬럼들[11].헤더명 = "유효기간";
            컬럼들[11].너비 = 100;

            컬럼들[12] = new DexGridColumn();
            컬럼들[12].컬럼명 = "LIMITTIME";
            컬럼들[12].헤더명 = "만료일";
            컬럼들[12].너비 = 100;

            그리드모델.그리드.열생성(컬럼들);
        }

        private void 콤보박스초기화()
        {
            Hashtable Param = new Hashtable();
            Param["코드그룹"] = "자재코드";
            검색조건모델.자재명.DataSource = 서비스.조회수행("공통코드", Param);
            ComboBoxBinding(검색조건모델.자재명, "공통코드", Param, false);


            Param = new Hashtable();
            Param["코드그룹"] = "위치";

            검색조건모델.자재위치.DataSource = 서비스.조회수행("공통코드", Param);
            ComboBoxBinding(검색조건모델.자재위치, "공통코드", Param, false);

            Param = new Hashtable();
            Param["코드그룹"] = "공급사";
            검색조건모델.공급사명.DataSource = 서비스.GetDataTable("SELECT VENDORID, VENDORNAME FROM CIM_VENDOR");
            검색조건모델.공급사명.DisplayMember = "VENDORNAME";
            검색조건모델.공급사명.ValueMember = "VENDORID";
        }

        private void InitializeProperty()
        {
            그리드모델 = new 자재입고표_모델();
            그리드모델.그리드 = this.자재입고표;
            그리드모델.그리드.기본테이블명 = "CIM_MATERIALLOT";

            검색조건모델 = new 자재검색_모델();
            검색조건모델.자재LOT = this.자재lottbx;
            검색조건모델.공급사명 = this.공급사cbx;
            검색조건모델.자재명 = this.자재cbx;
            검색조건모델.자재위치 = this.위치cdx;
            검색조건모델.자재날짜검색_시작 = this.기간DTP;
            검색조건모델.자재날짜검색_종료 = this.기간DTP2;
            
            검색조건모델.자재날짜검색_시작.Value = DateTime.Now.AddDays(-7);
            검색조건모델.자재날짜검색_종료.Value = DateTime.Now;
            검색조건모델.자재명.SelectedIndex = -1;
        }

        public void 조회()
        {
            if (DateTime.Compare(검색조건모델.자재날짜검색_시작.Value, 검색조건모델.자재날짜검색_종료.Value) >= 0)
                MessageBox.Show("날짜를 재설정하세요.");
            if (DateTime.Compare(검색조건모델.자재날짜검색_시작.Value.AddMonths(6), 검색조건모델.자재날짜검색_종료.Value) < 0)
                MessageBox.Show("검색기간은 6개월이내로 선택하여 주십시오.");

            Hashtable Param = new Hashtable();
            Param["MATERIALTYPE"] = string.IsNullOrEmpty(검색조건모델.자재명.SelectedValue as string) ? string.Empty : 검색조건모델.자재명.SelectedValue as string;
            Param["VENDORID"] = string.IsNullOrEmpty(검색조건모델.공급사명.SelectedValue as string) ? string.Empty : 검색조건모델.공급사명.SelectedValue as string;
            Param["LOCATION"] = string.IsNullOrEmpty(검색조건모델.자재위치.SelectedValue as string) ? string.Empty : 검색조건모델.자재위치.SelectedValue as string;
            
            this.그리드모델.그리드.바인딩(서비스.조회수행("자재공급사조회", Param));
        }

        public void 저장()
        {
            

            그리드모델.그리드.CurrentCell = null;
            DataTable 반영표 = 그리드모델.그리드.DataSource as DataTable;
            그리드모델.그리드.반영(반영표, 서비스);
            조회(); 
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

        public void 초기화()
        {
            
        }


    }
}
