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

namespace DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.공정관리_반제품_
{
    public partial class 주제공정시작 : 스크린, I스크린
    {
        public LOT목록_모델 그리드모델 { get; set; }
        public LOT목록검색_모델 검색조건모델 { get; set; }
        public 자재LOT정보Popup Popup창 { get; set; }
        

        public 주제공정시작()
        {
            InitializeComponent();
            InitializeProperty();
            InitlalizeEnvet();
        }

        private void InitlalizeEnvet()
        {
            this.Shown += 주제공정시작_Shown;

            this.기본기능.조회버튼.Click += (object sender, EventArgs e) => 조회();
            this.기본기능.저장버튼.Click += (object sender, EventArgs e) => 저장();
            this.LOT목록그리드.CellContentClick += LOT목록그리드_CellContentClick;
        }

        private void LOT목록그리드_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)//컬럼이 버튼이면서 인덱스가 헤더행이 아닌경우 
            {
                string 쿼리 = @"-------------------------------------------------
                            DELETE 
                            FROM [CIM_PRODUCTORDER] 
                            WHERE PRODUCTORDERID = '{0}' 
                            ";

                쿼리 = string.Format(쿼리, senderGrid["PRODUCTORDERID", 그리드모델.LOT목록그리드.CurrentRow.Index].Value.ToString());
                서비스.ExcuteQuery(쿼리);
                조회();
            }
        }

        private void 주제공정시작_Shown(object sender, EventArgs e)
        {
            this.기본기능.행제거버튼.Visible = false;
            this.기본기능.행추가버튼.Visible = false;

            InitializeComboBox();
            InitializeGrid();
            InitializedataGrid();
            
        }

        private void InitializedataGrid()
        {
            DexGridColumn[] 컬럼들 = new DexGridColumn[11];
            컬럼들[0] = new DexGridColumn();
            컬럼들[0].컬럼명 = "MATERIALDEFINITIONID";
            컬럼들[0].헤더명 = "자재LOT";
            컬럼들[0].너비 = 80;

            컬럼들[1] = new DexGridColumn();
            컬럼들[1].컬럼명 = "MATERIALDEFINITIONNAME";
            컬럼들[1].헤더명 = "자재코드";
            컬럼들[1].너비 = 80;

            컬럼들[2] = new DexGridColumn();
            컬럼들[2].컬럼명 = "MBOMQTY";
            컬럼들[2].헤더명 = "자재명";
            컬럼들[2].너비 = 80;

            컬럼들[3] = new DexGridColumn();
            컬럼들[3].컬럼명 = "QTY";
            컬럼들[3].헤더명 = "투입수량";
            컬럼들[3].너비 = 80;

            컬럼들[4] = new DexGridColumn();
            컬럼들[4].컬럼명 = "ORIGINALQTY";
            컬럼들[4].헤더명 = "총량";
            컬럼들[4].너비 = 80;

            컬럼들[5] = new DexGridColumn();
            컬럼들[5].컬럼명 = "UNITID";
            컬럼들[5].헤더명 = "단위";
            컬럼들[5].너비 = 80;

            컬럼들[6] = new DexGridColumn();
            컬럼들[6].컬럼명 = "EQUIPMENTID";
            컬럼들[6].헤더명 = "설비";
            컬럼들[6].너비 = 80;

            컬럼들[7] = new DexGridColumn();
            컬럼들[7].컬럼명 = "EQUIPMENTNAME";
            컬럼들[7].헤더명 = "설비명";
            컬럼들[7].너비 = 80;

            컬럼들[8] = new DexGridColumn();
            컬럼들[8].컬럼명 = "MODIFYTIME";
            컬럼들[8].헤더명 = "시스템수정일시";
            컬럼들[8].너비 = 80;

            컬럼들[9] = new DexGridColumn();
            컬럼들[9].컬럼명 = "EXPIREDATE";
            컬럼들[9].헤더명 = "유효기간만료일";
            컬럼들[9].너비 = 80;

            컬럼들[10] = new DexGridColumn();
            컬럼들[10].컬럼명 = "EXPIREDURATION";
            컬럼들[10].헤더명 = "유효기간";
            컬럼들[10].너비 = 80;

            그리드모델.LOT정보그리드.열생성(컬럼들);
            조회();
        }

        private void InitializeGrid()
        {
            DexGridColumn[] 컬럼들 = new DexGridColumn[15];
            컬럼들[0] = new DexGridColumn();
            컬럼들[0].컬럼명 = "STATENAME";
            컬럼들[0].헤더명 = "상태";
            컬럼들[0].너비 = 80;

            컬럼들[1] = new DexGridColumn();
            컬럼들[1].컬럼명 = "PRODUCTORDERID";
            컬럼들[1].헤더명 = "생산계획오더";
            컬럼들[1].너비 = 80;

            컬럼들[2] = new DexGridColumn();
            컬럼들[2].컬럼명 = "PRODUCTORDERTYPE";
            컬럼들[2].헤더명 = "생산계획타입";
            컬럼들[2].너비 = 80;

            컬럼들[3] = new DexGridColumn();
            컬럼들[3].컬럼명 = "PRODUCTDEFINITIONID";
            컬럼들[3].헤더명 = "제품코드";
            컬럼들[3].너비 = 80;

            컬럼들[4] = new DexGridColumn();
            컬럼들[4].컬럼명 = "PRODUCTDEFINITIONNAME";
            컬럼들[4].헤더명 = "제품명";
            컬럼들[4].너비 = 80;

            컬럼들[5] = new DexGridColumn();
            컬럼들[5].컬럼명 = "ORIGINALQTY";
            컬럼들[5].헤더명 = "계획수량";
            컬럼들[5].너비 = 80;

            컬럼들[6] = new DexGridColumn();
            컬럼들[6].컬럼명 = "QTY";
            컬럼들[6].헤더명 = "투입수량";
            컬럼들[6].너비 = 80;

            컬럼들[7] = new DexGridColumn();
            컬럼들[7].컬럼명 = "UNITID";
            컬럼들[7].헤더명 = "단위";
            컬럼들[7].너비 = 80;

            컬럼들[8] = new DexGridColumn();
            컬럼들[8].컬럼명 = "SCHEDULESTARTTIME";
            컬럼들[8].헤더명 = "계획시작일";
            컬럼들[8].너비 = 80;

            컬럼들[9] = new DexGridColumn();
            컬럼들[9].컬럼명 = "SCHEDULEENDTIME";
            컬럼들[9].헤더명 = "계획종료일";
            컬럼들[9].너비 = 80;

            컬럼들[10] = new DexGridColumn();
            컬럼들[10].컬럼명 = "LOTID";
            컬럼들[10].헤더명 = "생산LOT";
            컬럼들[10].너비 = 80;

            컬럼들[11] = new DexGridColumn();
            컬럼들[11].컬럼명 = "STATE";
            컬럼들[11].헤더명 = "LOT진행상태";
            컬럼들[11].너비 = 80;

            컬럼들[12] = new DexGridColumn();
            컬럼들[12].컬럼명 = "DELETE";
            컬럼들[12].헤더명 = "삭제";
            컬럼들[12].너비 = 80;
            컬럼들[12].컬럼타입 = 컬럼타입.버튼;

            컬럼들[13] = new DexGridColumn();
            컬럼들[13].컬럼명 = "";
            컬럼들[13].헤더명 = "자동투입";
            컬럼들[13].너비 = 80;

            컬럼들[14] = new DexGridColumn();
            컬럼들[14].컬럼명 = "";
            컬럼들[14].헤더명 = "투입오차";
            컬럼들[14].너비 = 80;

            그리드모델.LOT목록그리드.열생성(컬럼들);
            
            조회();
        }

        private void InitializeComboBox()
        {
            //데이터넣어야함
            Hashtable 조건 = new Hashtable();
            조건["코드그룹"] = "생산계획타입";
            this.ProductiontypeCBX.DataSource = 서비스.조회수행("공통코드", 조건);
            this.ProductiontypeCBX.DisplayMember = "명칭";
            this.ProductiontypeCBX.ValueMember = "코드";
            //생산계획타입

            조건 = new Hashtable();
            조건["코드그룹"] = "제품";
            this.제품CBX.DataSource = 서비스.조회수행("공통코드", 조건);
            this.제품CBX.DisplayMember = "명칭";
            this.제품CBX.ValueMember = "코드";
            //제품

            조건 = new Hashtable();
            조건["코드그룹"] = "LOT진행상태";
            this.LOT진행상태CBX.DataSource = 서비스.조회수행("공통코드", 조건);
            this.LOT진행상태CBX.DisplayMember = "명칭";
            this.LOT진행상태CBX.ValueMember = "코드";
            //LOT 진행상태

            조건 = new Hashtable();
            조건["코드그룹"] = "투입설비";
            this.투입설비CBX.DataSource = 서비스.조회수행("공통코드", 조건);
            this.투입설비CBX.DisplayMember = "명칭";
            this.투입설비CBX.ValueMember = "코드";
            //투입설비

        }

        private void InitializeProperty()
        {
            그리드모델 = new LOT목록_모델();
            그리드모델.LOT목록그리드 = this.LOT목록그리드;
            그리드모델.LOT정보그리드 = this.LOT정보그리드;
            그리드모델.LOT목록그리드.기본테이블명 = "CIM_PRODUCTORDER";
            그리드모델.LOT정보그리드.기본테이블명 = "CIM_MATERIALLOT";

            검색조건모델 = new LOT목록검색_모델();
            검색조건모델.dateTimeStart = dateTimeStart;
            검색조건모델.dateTimeEnd = dateTimeEnd;
            검색조건모델.Productionorder = ProductionorderTXB;
            검색조건모델.Productiontype = ProductiontypeCBX;
            검색조건모델.제품 = 제품CBX;
            검색조건모델.LOT진행상태 = LOT진행상태CBX;
            검색조건모델.생산LOT = 생산LOTTXB;
            검색조건모델.LOTProgress = LOTProgressTXB;
            검색조건모델.투입수량 = 투입수량nud;
            검색조건모델.투입설비 = 투입설비CBX;
            검색조건모델.투입일시 = 투입일시Dtp;
            검색조건모델.dateTimeStart.Value = DateTime.Now.AddDays(-7);
            검색조건모델.dateTimeEnd.Value = DateTime.Now;
            
        }

        public void 저장()
        {

            if (DateTime.Compare(검색조건모델.dateTimeStart.Value, 검색조건모델.dateTimeEnd.Value) >= 0)
                MessageBox.Show("날짜를 재설정하세요.");

            if (DateTime.Compare(검색조건모델.dateTimeStart.Value.AddMonths(6), 검색조건모델.dateTimeEnd.Value) < 0)
                MessageBox.Show("검색기간은 6개월이내로 선택하여 주십시오.");

            if (string.Empty == this.투입설비CBX.Text)
                MessageBox.Show("투입설비를 선택하세요.");
            
            if (DateTime.Compare(검색조건모델.투입일시.Value, DateTime.Now ) >=0)
                MessageBox.Show("투입시간은 현재시간보다 미래일 수 없습니다.");


            //for (int i = 0; i < length; i++)
            //{
            //    this.LOT정보그리드.Rows.Add();
            //    this.LOT정보그리드["materiallot", i].Value = "d";
            //    this.LOT정보그리드["materialdefinitionid", i].Value = "d";
            //}

            Hashtable Param = new Hashtable();
            Param["MATERIALDEFINITIONID"] = string.IsNullOrEmpty(검색조건모델.Productiontype.SelectedValue as string) ? string.Empty : 검색조건모델.Productiontype.SelectedValue as string;
            Param["PRODUCTDEFINITIONID"] = string.IsNullOrEmpty(검색조건모델.제품.SelectedValue as string) ? string.Empty : 검색조건모델.제품.SelectedValue as string;
            Param["PRODUCTORDERID"] = string.IsNullOrEmpty(검색조건모델.Productionorder.Text as string) ? string.Empty : 검색조건모델.Productionorder.Text as string;
            Param["STATE"] = string.IsNullOrEmpty(검색조건모델.LOT진행상태.SelectedValue as string) ? string.Empty : 검색조건모델.LOT진행상태.SelectedValue as string;
            Param["LOTID"] = string.IsNullOrEmpty(검색조건모델.생산LOT.Text as string) ? string.Empty : 검색조건모델.생산LOT.Text as string;
            Param["QTY"] = string.IsNullOrEmpty(검색조건모델.LOTProgress.Text as string) ? string.Empty : 검색조건모델.LOTProgress.Text as string;
            Param["QTY"] = string.IsNullOrEmpty(검색조건모델.투입수량.Text as string) ? string.Empty : 검색조건모델.투입수량.Text as string;
            Param["CREATETIME"] = DateTime.Now;
            Param["MODIFYTIME"] = DateTime.Now;
            Param["MATERIALLOTID"] = "";
            서비스.명령수행("주제공정시작", Param);
            조회();
        }

       
        

       
        public void 조회()
        {
            Hashtable Param = new Hashtable();
            this.그리드모델.LOT목록그리드.바인딩(서비스.조회수행("주제공정시작", Param));
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

        private void 자재LOT정보BTN_Click(object sender, EventArgs e)
        {
            this.Popup창 = new 자재LOT정보Popup();
            this.Popup창.서비스 = 서비스;
            this.Popup창.주제공정시작 = this;
            this.Popup창.Show();

        }

        private void Btn투입_Click(object sender, EventArgs e)
        {
            if (string.Empty == 검색조건모델.투입수량.Text)
            {
                MessageBox.Show("투입수량을 입력해주시길 바랍니다.");
            }
            else if (검색조건모델.투입수량.Value <= 0)
            {
                MessageBox.Show("투입수량이 1보다 적습니다 확인바랍니다.");
            }
            else
            {
                MessageBox.Show("주제 합성 탱크 투입일시"+DateTime.Now+"투입 하시겠습니까?");

                string 쿼리 = @"------------------------------------
                            UPDATE [CIM_MATERIALLOT]
                            SET 
                            STATE ='투입'
                            WHERE MATERIALLOTID = '{0}'
                            ";

                쿼리 = string.Format(쿼리, this.검색조건모델.생산LOT.Text);
                서비스.ExcuteQuery(쿼리);
            }
        }

        private void Btn투입취소_Click(object sender, EventArgs e)
        {
            string 생산계획오더 = 그리드모델.LOT정보그리드["PRODUCTORDERID", 그리드모델.LOT정보그리드.CurrentRow.Index].Value.ToString();
            string LOT완료상태 = 그리드모델.LOT정보그리드["STATE", 그리드모델.LOT정보그리드.CurrentRow.Index].Value.ToString();
            if (생산계획오더 == "완료" || LOT완료상태 == "완료")
            {
                MessageBox.Show("처리대상이 아닙니다.");
            }
            else
            {
                MessageBox.Show("투입 취소 하시겠습니까?");

                string 쿼리 = @"-----------------------------------
                            UPDATE [CIM_MATERIALLOT]
                            SET 
                            STATE ='투입대기'
                            WHERE MATERIALLOTID = '{0}'
                            ";
                쿼리 = string.Format(쿼리, this.검색조건모델.생산LOT.Text);
                서비스.ExcuteQuery(쿼리);
            }
        }
    }
}
