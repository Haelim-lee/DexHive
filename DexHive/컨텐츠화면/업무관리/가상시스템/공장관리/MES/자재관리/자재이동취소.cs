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
    public partial class 자재이동취소 : 스크린,I스크린
    {
        public 자재이동취소모델 그리드모델 { get; set; }
        public 자재이동취소검색모델 검색조건모델 { get; set; }

        public 자재이동취소()
        {
            InitializeComponent();
            InltlalizeProperty();
            InitlalizeEvent();
        }

        private void InitlalizeEvent()
        {
            this.Shown += 자재이동취소_Shown;
            this.기본기능.조회버튼.Click += (object sender, EventArgs e) => 조회();
            this.검색조건모델.위치그룹.SelectedValueChanged += 위치그룹_SelectedValueChanged;
        }

        private void 위치그룹_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox 이동위치그룹콤보 = sender as ComboBox;
            if (이동위치그룹콤보 != null || 이동위치그룹콤보.SelectedValue != null)
            {
                string 선택된위치 = 이동위치그룹콤보.SelectedValue.ToString();

                검색조건모델.위치.DataSource = 서비스.GetDataTable(string.Format("SELECT FACILITYNAME FROM CIM_FACILITY WHERE FACILITYCLASSID = '{0}'", 선택된위치));
                검색조건모델.위치.DisplayMember = "FACILITYNAME";
                검색조건모델.위치.ValueMember = "FACILITYNAME";
            }
        }

        private void 자재이동취소_Shown(object sender, EventArgs e)
        {
            InitializeComboBox();
            InitializeGrid();
            this.기본기능.행제거버튼.Visible = false;
            this.기본기능.행추가버튼.Visible = false;
            this.기본기능.저장버튼.Visible = false;
        }

        private void InitializeGrid()
        {
            DexGridColumn[] 컬럼들 = new DexGridColumn[15];
            컬럼들[0] = new DexGridColumn();
            컬럼들[0].컬럼명 = "LOTID";
            컬럼들[0].헤더명 = "자재LOT";
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
            컬럼들[3].컬럼명 = "MATERIALTYPE";
            컬럼들[3].헤더명 = "자재타입";
            컬럼들[3].너비 = 100;

            컬럼들[4] = new DexGridColumn();
            컬럼들[4].컬럼명 = "PRODUCTORDERID";
            컬럼들[4].헤더명 = "생산계획오더";
            컬럼들[4].너비 = 100;

            컬럼들[5] = new DexGridColumn();
            컬럼들[5].컬럼명 = "LOCATION";
            컬럼들[5].헤더명 = "현위치";
            컬럼들[5].너비 = 100;

            컬럼들[6] = new DexGridColumn();
            컬럼들[6].컬럼명 = "FACILITYNAME";
            컬럼들[6].헤더명 = "이동위치";
            컬럼들[6].너비 = 100;

            컬럼들[7] = new DexGridColumn();
            컬럼들[7].컬럼명 = "FACILITYCLASSID";
            컬럼들[7].헤더명 = "이동위치명";
            컬럼들[7].너비 = 100;

            컬럼들[8] = new DexGridColumn();
            컬럼들[8].컬럼명 = "LOSSQTY";
            컬럼들[8].헤더명 = "이동수량";
            컬럼들[8].너비 = 100;

            컬럼들[9] = new DexGridColumn();
            컬럼들[9].컬럼명 = "QTY";
            컬럼들[9].헤더명 = "재고수량";
            컬럼들[9].너비 = 100;

            컬럼들[10] = new DexGridColumn();
            컬럼들[10].컬럼명 = "UNITID";
            컬럼들[10].헤더명 = "단위";
            컬럼들[10].너비 = 100;

            컬럼들[11] = new DexGridColumn();
            컬럼들[11].컬럼명 = "VENDORID";
            컬럼들[11].헤더명 = "공급사명";
            컬럼들[11].너비 = 100;

            컬럼들[12] = new DexGridColumn();
            컬럼들[12].컬럼명 = "CREATETIME";
            컬럼들[12].헤더명 = "입고일";
            컬럼들[12].너비 = 100;
            //
            컬럼들[13] = new DexGridColumn();
            컬럼들[13].컬럼명 = "MATERIALDEFINITIONNAME";
            컬럼들[13].헤더명 = "제조일";
            컬럼들[13].너비 = 100;
            //
            컬럼들[14] = new DexGridColumn();
            컬럼들[14].컬럼명 = "LIMIT LIMITTIME";
            컬럼들[14].헤더명 = "유효기간 만료일";
            컬럼들[14].너비 = 100;

            그리드모델.그리드.열생성(컬럼들);
        }

        private void InitializeComboBox()
        {
            Hashtable Param = new Hashtable();
            Param = new Hashtable();
            검색조건모델.위치그룹.DataSource = 서비스.GetDataTable("SELECT DISTINCT FACILITYCLASSID FROM CIM_FACILITY ");
            검색조건모델.위치그룹.DisplayMember = "FACILITYCLASSID";
            검색조건모델.위치그룹.ValueMember = "FACILITYCLASSID";
        }

        private void InltlalizeProperty()
        {
            그리드모델 = new 자재이동취소모델();
            그리드모델.그리드 = this.dataGridView;
            그리드모델.그리드.기본테이블명 = "CIM_MATERIALLOT";

            검색조건모델 = new 자재이동취소검색모델();
            검색조건모델.자재LOT = this.자재TXB;
            검색조건모델.위치그룹 = this.위치그룹CBO;
            검색조건모델.위치 = this.위치CBO;
            검색조건모델.검색날짜시작 = this.dateTimestart;
            검색조건모델.검색날짜종료 = this.dateTimeend;
            검색조건모델.검색날짜시작.Value = DateTime.Now.AddDays(-7);
            검색조건모델.검색날짜종료.Value = DateTime.Now;

        }

        public void 저장()
        {
        }

        public void 조회()
        {

            if (DateTime.Compare(검색조건모델.검색날짜시작.Value, 검색조건모델.검색날짜종료.Value) >= 0)
            {
                MessageBox.Show("날짜를 재설정하세요.");
                return;
            }

            if (DateTime.Compare(검색조건모델.검색날짜시작.Value.AddMonths(6), 검색조건모델.검색날짜종료.Value) < 0)
            {
                MessageBox.Show("검색기간은 6개월이내로 선택하여 주십시오.");
                return;
            }

            Dictionary<string, Hashtable> 입력매개변수 = new Dictionary<string, Hashtable>();
            Dictionary<string, Hashtable> 출력매개변수 = new Dictionary<string, Hashtable>();

            Hashtable 자재LOT = new Hashtable();
            자재LOT["값"] = string.IsNullOrEmpty(검색조건모델.자재LOT.Text) ? string.Empty : "%" + (검색조건모델.자재LOT.Text) + "%";
            자재LOT["자료형"] = "VARCHAR";
            자재LOT["방향"] = false;

            입력매개변수.Add("@MATERIALLOTID", 자재LOT);
            DataSet ResultTable = this.서비스.프로시저호출("자재이동_취소조회", 입력매개변수, 출력매개변수);
            this.그리드모델.그리드.바인딩(ResultTable.Tables[0]);

        }

        public void 초기화()
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

        private void BTN자재이동취소_Click(object sender, EventArgs e)
        {
            if (string.Empty == 검색조건모델.위치.Text)
            {
                MessageBox.Show("이동위치를 선택하여 주십시오.");
            }
            if (그리드모델.그리드.CurrentCell.Value.ToString() == null)
            {
                MessageBox.Show("이동할자재를 선택해주세요.");
                return;
            }
            Dictionary<string, Hashtable> 입력매개변수 = new Dictionary<string, Hashtable>();
            Dictionary<string, Hashtable> 출력매개변수 = new Dictionary<string, Hashtable>();

            Hashtable 위치 = new Hashtable();
            위치["값"] = string.IsNullOrEmpty(검색조건모델.위치.SelectedValue as string) ? string.Empty :  (검색조건모델.위치.SelectedValue as string) ;
            위치["자료형"] = "VARCHAR";
            위치["방향"] = false;

            Hashtable 자재LOT = new Hashtable();
            자재LOT["값"] = string.IsNullOrEmpty(검색조건모델.자재LOT.Text) ? string.Empty : "%" + (검색조건모델.자재LOT.Text) + "%";
            자재LOT["자료형"] = "VARCHAR";
            자재LOT["방향"] = false;

            입력매개변수.Add("@MATERIALLOTID", 자재LOT);
            입력매개변수.Add("@LOCATION", 위치);
            DataSet ResultTable = this.서비스.프로시저호출("자재이동_취소", 입력매개변수, 출력매개변수);

            int QTY = Convert.ToInt32(그리드모델.그리드["QTY", 그리드모델.그리드.CurrentRow.Index].Value.ToString());
            int IQTY = Convert.ToInt32(그리드모델.그리드["LOSSQTY", 그리드모델.그리드.CurrentRow.Index].Value.ToString());
            int 현재수량 = QTY + IQTY;

            //이전수량은 0 으로 바꾸고 현수량과 이전수량 합치는 쿼리
            string 쿼리 = @"-----------------------------------------
                                UPDATE [CIM_MATERIALLOT]
                                SET
                                QTY = '{0}' ,
                                LOSSQTY = '0'
                                WHERE MATERIALLOTID ='{1}' 
                                ";
            쿼리 = string.Format(쿼리, 현재수량, 검색조건모델.자재LOT.Text);
            서비스.ExcuteQuery(쿼리);
        }
    }
}
