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
    public partial class 자재입고등록 : 스크린,I스크린
    {
        public 자재입고등록_모델 그리드모델 { get; set; }
        public 자재입고검색_모델 검색조건모델 { get; set; }

        public 자재입고등록()
        {
            InitializeComponent();
            InitializeProperty();
            InitlalizeEvent();
        }

        private void InitlalizeEvent()
        {
            this.Shown += 자재입고등록_Shown;
            this.기본기능.조회버튼.Click += (object sender, EventArgs e) => 조회();
            this.기본기능.저장버튼.Click += (object sender, EventArgs e) => 저장();
        }

        private void 자재입고등록_Shown(object sender, EventArgs e)
        {
            this.기본기능.행제거버튼.Visible = false;
            this.기본기능.행추가버튼.Visible = false;

            InitializeComboBox();
            InitializedataGrid();
            조회();
        }

        private void InitializedataGrid()
        {
            DexGridColumn[] 컬럼들 = new DexGridColumn[12];
            컬럼들[0] = new DexGridColumn();
            컬럼들[0].컬럼명 = "MATERIALDEFINITIONID";
            컬럼들[0].헤더명 = "자재코드";
            컬럼들[0].너비 = 100;

            컬럼들[1] = new DexGridColumn();
            컬럼들[1].컬럼명 = "MATERIALDEFINITIONNAME";
            컬럼들[1].헤더명 = "자재명";
            컬럼들[1].너비 = 100;

            컬럼들[2] = new DexGridColumn();
            컬럼들[2].컬럼명 = "MATERIALLOTID";
            컬럼들[2].헤더명 = "자재LOT";
            컬럼들[2].너비 = 100;

            컬럼들[3] = new DexGridColumn();
            컬럼들[3].컬럼명 = "PREVLOCATION";
            컬럼들[3].헤더명 = "이전위치";
            컬럼들[3].너비 = 100;

            컬럼들[4] = new DexGridColumn();
            컬럼들[4].컬럼명 = "LOCATION";
            컬럼들[4].헤더명 = "현위치";
            컬럼들[4].너비 = 100;

            컬럼들[5] = new DexGridColumn();
            컬럼들[5].컬럼명 = "QTY";
            컬럼들[5].헤더명 = "입고수량";
            컬럼들[5].너비 = 100;

            컬럼들[6] = new DexGridColumn();
            컬럼들[6].컬럼명 = "UNITID";
            컬럼들[6].헤더명 = "단위";
            컬럼들[6].너비 = 100;

            컬럼들[7] = new DexGridColumn();
            컬럼들[7].컬럼명 = "CREATETIME";
            컬럼들[7].헤더명 = "입고일";
            컬럼들[7].너비 = 100;

            컬럼들[8] = new DexGridColumn();
            컬럼들[8].컬럼명 = "VENDORID";
            컬럼들[8].헤더명 = "공급사";
            컬럼들[8].너비 = 100;

            컬럼들[9] = new DexGridColumn();
            컬럼들[9].컬럼명 = "PRODUCTTIME";
            컬럼들[9].헤더명 = "생산일";
            컬럼들[9].너비 = 100;

            컬럼들[10] = new DexGridColumn();
            컬럼들[10].컬럼명 = "LIMIT";
            컬럼들[10].헤더명 = "유효기간";
            컬럼들[10].너비 = 100;

            컬럼들[11] = new DexGridColumn();
            컬럼들[11].컬럼명 = "LIMITTIME";
            컬럼들[11].헤더명 = "만료일";
            컬럼들[11].너비 = 100;

            그리드모델.그리드.열생성(컬럼들);
            조회();
        }

        private void InitializeComboBox()
        {
            Hashtable Param = new Hashtable();
            Param = new Hashtable();
            Param["코드그룹"] = "위치";
            ComboBoxBinding(검색조건모델.자재위치, "공통코드", Param, false);

            Param = new Hashtable();
            검색조건모델.공급사.DataSource = 서비스.GetDataTable("SELECT VENDORID, VENDORNAME FROM CIM_VENDOR");
            검색조건모델.공급사.DisplayMember = "VENDORNAME";
            검색조건모델.공급사.ValueMember = "VENDORID";

            Param = new Hashtable();
            Param["코드그룹"] = "단위";
            ComboBoxBinding(검색조건모델.단위, "공통코드", Param, false);
       
            Param = new Hashtable();
            검색조건모델.자재코드.DataSource = 서비스.GetDataTable("SELECT MATERIALDEFINITIONID ,MATERIALDEFINITIONNAME FROM [CIM_MATERIALDEFINITION]");
            검색조건모델.자재코드.DisplayMember = "MATERIALDEFINITIONNAME";
            검색조건모델.자재코드.ValueMember = "MATERIALDEFINITIONID";
        }

       
        private void InitializeProperty()
        {
            그리드모델 = new 자재입고등록_모델();
            그리드모델.그리드 = this.dataGrid;
            그리드모델.그리드.기본테이블명 = "CIM_MATERIALLOT";

            검색조건모델 = new 자재입고검색_모델();
            검색조건모델.자재코드 = this.자재CBX;
            검색조건모델.공급사 = this.공급사CBX;
            검색조건모델.단위 = this.단위CBX;
            검색조건모델.자재위치 = this.위치CBX;
            검색조건모델.입고수량 = this.입고수량TXB;
        }

        public void 저장()
        {

            if (string.Empty == this.입고수량TXB.Text)
            {
                MessageBox.Show("입고수량을 입력하세요.");
                return;
            }

            Hashtable Param = new Hashtable();
            Param["MATERIALDEFINITIONNAME"] = (검색조건모델.자재코드.SelectedItem as DataRowView).Row[1].ToString();
            Param["MATERIALDEFINITIONID"] = string.IsNullOrEmpty(검색조건모델.자재코드.SelectedValue as string) ? string.Empty : 검색조건모델.자재코드.SelectedValue as string;
            Param["VENDORID"] = string.IsNullOrEmpty(검색조건모델.공급사.SelectedValue as string) ? string.Empty : 검색조건모델.공급사.SelectedValue as string;
            Param["QTY"] = string.IsNullOrEmpty(검색조건모델.입고수량.Text as string) ? string.Empty : 검색조건모델.입고수량.Text as string;
            Param["LOCATION"] = string.IsNullOrEmpty(검색조건모델.자재위치.SelectedValue as string) ? string.Empty : 검색조건모델.자재위치.SelectedValue as string;
            Param["UNITID"] = string.IsNullOrEmpty(검색조건모델.단위.SelectedValue as string) ? string.Empty : 검색조건모델.단위.SelectedValue as string;
            Param["CREATETIME"] = DateTime.Now;
            Param["MODIFYTIME"] = DateTime.Now;
            Param["MATERIALLOTID"] = 자재LOT생성();
            Param["ORIGINALQTY"] = string.IsNullOrEmpty(검색조건모델.입고수량.Text as string) ? string.Empty : 검색조건모델.입고수량.Text as string;
            서비스.명령수행("자재입고등록1", Param);       
            조회();
        }

        private string 자재LOT생성()
        {
            string 쿼리 = string.Format("SELECT COUNT(*) FROM CIM_MATERIALLOT WHERE CONVERT(CHAR(10), CREATETIME, 23) = '{0}'", DateTime.Now.ToShortDateString());
            int 시퀀스 = Convert.ToInt32(서비스.GetDataTable(쿼리).Rows[0][0]);
            string 자재LOT = DateTime.Now.ToString("yyMMdd") + (시퀀스 + 1).ToString().PadLeft(4,'0');

            return 자재LOT;
        }

        public void 조회()
        {
            Hashtable Param = new Hashtable();
            this.그리드모델.그리드.바인딩(서비스.조회수행("자재공급사조회", Param));
        }

        public void 초기화()
        {
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
