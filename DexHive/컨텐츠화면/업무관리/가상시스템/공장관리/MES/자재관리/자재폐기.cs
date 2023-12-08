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
    public partial class 자재폐기 : 스크린,I스크린
    {
        public 자재폐기그리드 그리드모델 { get; set; } 
        public 자재폐기검색모델 검색모델 { get; set; }
 
        public 자재폐기()
        {
            InitializeComponent();
            InitializeEvnet();
            InitlaliProperty();
        }

        private void 자재폐기_Shown(object sender, EventArgs e)
        {
            InitializeComboBox();
            InitializeGrid();
            조회();
            this.기본기능.저장버튼.Visible = false;
            this.기본기능.행제거버튼.Visible = false;
            this.기본기능.행추가버튼.Visible = false;
        }

        private void InitializeComboBox()
        {

            Hashtable Param = new Hashtable();
            Param = new Hashtable();
            Param["코드그룹"] = "위치";
            ComboBoxBinding(검색모델.위치, "공통코드", Param, false);

            Param = new Hashtable();
            Param["코드그룹"] = "폐기사유";
            검색모델.폐기사유.DataSource = 서비스.조회수행("공통코드", Param);
            검색모델.폐기사유.DisplayMember = "코드설명";
            검색모델.폐기사유.ValueMember = "코드";

        }

        private void InitlaliProperty()
        {
            그리드모델 = new 자재폐기그리드();
            그리드모델.그리드 = this.자재폐기그리드;
            그리드모델.그리드.기본테이블명 = "CIM_MATERIALLOT";

            검색모델 = new 자재폐기검색모델();
            검색모델.기간시작 = this.DateTimeStart;
            검색모델.기간종료 = this.DateTimeEnd;
            검색모델.기간시작.Value = DateTime.Now.AddDays(-7);
            검색모델.기간종료.Value = DateTime.Now;
            검색모델.위치 = this.위치CBO;
            검색모델.자재LOT = this.자재LOTTXB;
            검색모델.생산LOT = this.생산LOTTXB;
            검색모델.자재타입 = this.자재타입TXB;
            검색모델.재고수량 = this.재고수량TXB;
            검색모델.QTY = this.QTYTXB;
            검색모델.현위치 = this.현위치TXB;
            검색모델.자재명 = this.자재명TXB;
            검색모델.폐기사유 = this.폐기사유CBO;
            검색모델.폐기사유2 = this.폐기사유TXB;
            검색모델.특이사항 = this.특이사항CBO;
        }

        private void InitializeEvnet()
        {
            this.Shown += 자재폐기_Shown;
            this.기본기능.조회버튼.Click += (object sender, EventArgs e) => 조회();
        }

        private void InitializeGrid()
        {
            DexGridColumn[] 컬럼들 = new DexGridColumn[12];
            컬럼들[0] = new DexGridColumn();
            컬럼들[0].컬럼명 = "MATERIALLOTID";
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
            컬럼들[3].컬럼명 = "MATERIALTYPE";
            컬럼들[3].헤더명 = "자재타입";
            컬럼들[3].너비 = 100;

            //컬럼 합쳐야함
            컬럼들[4] = new DexGridColumn();
            컬럼들[4].컬럼명 = "LOCATION";
            컬럼들[4].헤더명 = "자재위치";
            컬럼들[4].너비 = 100;

            컬럼들[5] = new DexGridColumn();
            컬럼들[5].컬럼명 = "QTY";
            컬럼들[5].헤더명 = "재고수량";
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
            //컬럼없음

            컬럼들[10] = new DexGridColumn();
            컬럼들[10].컬럼명 = "LIMIT";
            컬럼들[10].헤더명 = "유효기간";
            컬럼들[10].너비 = 100;

            컬럼들[11] = new DexGridColumn();
            컬럼들[11].컬럼명 = "LIMITTIME";
            컬럼들[11].헤더명 = "만료일";
            컬럼들[11].너비 = 100;
            //컬럼없음

            그리드모델.그리드.열생성(컬럼들);
            조회();
        }

        public void 저장()
        {
            
        }

        public void 조회()
        {
            if (DateTime.Compare(검색모델.기간시작.Value.AddMonths(6), 검색모델.기간종료.Value) < 0)
                MessageBox.Show("검색기간은 6개월이내로 선택하여 주십시오.");

            if (DateTime.Compare(검색모델.기간시작.Value, 검색모델.기간종료.Value) > 0)
                MessageBox.Show("날짜를 재설정하세요.");

            Hashtable Param = new Hashtable();
            this.그리드모델.그리드.바인딩(서비스.조회수행("자재폐기조회", Param));
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

        private void 자재폐기그리드_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           DexGridView 선택된그리드 =sender as DexGridView;
            this.생산LOTTXB.Text =선택된그리드.Rows[e.RowIndex].Cells["MATERIALLOTID"].Value.ToString();
            this.자재타입TXB.Text = 선택된그리드.Rows[e.RowIndex].Cells["MATERIALTYPE"].Value.ToString();
            this.재고수량TXB.Text = 선택된그리드.Rows[e.RowIndex].Cells["QTY"].Value.ToString();
            this.QTYTXB.Text = 선택된그리드.Rows[e.RowIndex].Cells["UNITID"].Value.ToString();
            this.현위치TXB.Text = 선택된그리드.Rows[e.RowIndex].Cells["LOCATION"].Value.ToString();
            this.자재명TXB.Text = 선택된그리드.Rows[e.RowIndex].Cells["MATERIALDEFINITIONNAME"].Value.ToString();

        }

        private void btn폐기_Click(object sender, EventArgs e)
        {
            if (string.Empty == this.생산LOTTXB.Text)
            {
                MessageBox.Show("처리대상이 없습니다.  대상을 선택하세요.");
                return;
            }
               
            string 쿼리 = @"-------------------------------------------------
                            DELETE 
                            FROM [CIM_MATERIALLOT] 
                            WHERE MATERIALLOTID = '{0}' 
                            ";

            쿼리 = string.Format(쿼리, this.검색모델.생산LOT.Text);
            서비스.ExcuteQuery(쿼리);
            조회();
        }
    }
}
