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
    public partial class 자재이동 : 스크린, I스크린
    {
        public 자재이동그리드모델 그리드모델 { get; set; }
        public 자재이동검색모델 검색조건모델 { get; set; }
        public 자재POPUP Popup창 { get; set; }

        public 자재이동()
        {
            InitializeComponent();
            InitializeProperty();
            InitlalizeEvent();
        }

        private void InitlalizeEvent()
        {
            this.Shown += 자재이동_Shown;
            this.기본기능.저장버튼.Click += (object sender, EventArgs e) => 저장();
            this.검색조건모델.이동위치그룹.SelectedValueChanged += 이동위치그룹_SelectedValueChanged;
            this.그리드모델.그리드.CurrentCellDirtyStateChanged += 그리드_CurrentCellDirtyStateChanged;
            this.그리드모델.그리드.DataError += 그리드_DataError;
        }

       
        private void 그리드_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
           DexGridView 그리드 = sender as DexGridView;
            string Test = 그리드.CurrentRow.Cells["FACILITYID"].Value as string;
        }

        private void 그리드_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            DexGridView senderGrid = sender as DexGridView;
            
            if (senderGrid.Columns[senderGrid.CurrentCell.ColumnIndex] is DataGridViewComboBoxColumn && senderGrid.CurrentCell.ColumnIndex==7)//컬럼이 버튼이면서 인덱스가 헤더행이 아닌 경우
            {
                if (그리드모델.그리드.CurrentRow != null)
                    if ((DataRowView)그리드모델.그리드.CurrentRow.DataBoundItem != null)
                    {

                        //senderGrid.CurrentRow.Cells["FACILITYID"].Value = null;
                        DataGridViewComboBoxCell ComboBoxCell = senderGrid.CurrentRow.Cells["FACILITYID"] as DataGridViewComboBoxCell;//ComboBoxCell
                        //DataGridViewComboBoxColumn ComboBox = senderGrid.Columns["FACILITYID"] as DataGridViewComboBoxColumn;
                        string 선택값= senderGrid.CurrentRow.Cells["FACILITYCLASSID"].Value.ToString();
                        ComboBoxCell.DataSource = 서비스.GetDataTable(string.Format("SELECT DISTINCT FACILITYID,FACILITYNAME FROM CIM_FACILITY WHERE FACILITYCLASSID = '{0}'", 선택값));
                    }   
            }
        }

        private void 이동위치그룹_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox 이동위치그룹콤보 = sender as ComboBox;
            if (이동위치그룹콤보 != null || 이동위치그룹콤보.SelectedValue != null)
            {
                string 선택된위치 = 이동위치그룹콤보.SelectedValue.ToString();

                검색조건모델.이동위치.DataSource = 서비스.GetDataTable(string.Format("SELECT DISTINCT FACILITYID,FACILITYNAME FROM CIM_FACILITY WHERE FACILITYCLASSID = '{0}'", 선택된위치));
                검색조건모델.이동위치.DisplayMember = "FACILITYNAME";
                검색조건모델.이동위치.ValueMember = "FACILITYID";
            }
        }

        private void 자재이동_Shown(object sender, EventArgs e)
        {
            InitializeComboBox();
            InitializeGrid();
            this.기본기능.행제거버튼.Visible = false;
            this.기본기능.행추가버튼.Visible = false;
            
        }

        private void InitializeGrid()
        {
            DexGridColumn[] 컬럼들 = new DexGridColumn[16];
            컬럼들[0] = new DexGridColumn();
            컬럼들[0].컬럼명 = "DELETE";
            컬럼들[0].헤더명 = "삭제";
            컬럼들[0].너비 = 80;
            컬럼들[0].컬럼타입 = 컬럼타입.버튼;

            컬럼들[1] = new DexGridColumn();
            컬럼들[1].컬럼명 = "MATERIALLOTID";
            컬럼들[1].헤더명 = "자재LOT";
            컬럼들[1].너비 = 100;

            컬럼들[2] = new DexGridColumn();
            컬럼들[2].컬럼명 = "MATERIALDEFINITIONID";
            컬럼들[2].헤더명 = "자재코드";
            컬럼들[2].너비 = 100;

            컬럼들[3] = new DexGridColumn();
            컬럼들[3].컬럼명 = "MATERIALDEFINITIONNAME";
            컬럼들[3].헤더명 = "자재명";
            컬럼들[3].너비 = 100;

            컬럼들[4] = new DexGridColumn();
            컬럼들[4].컬럼명 = "MATERIALTYPE";
            컬럼들[4].헤더명 = "자재타입";
            컬럼들[4].너비 = 100;

            컬럼들[5] = new DexGridColumn();
            컬럼들[5].컬럼명 = "PRODUCTORDERID";
            컬럼들[5].헤더명 = "생산계획오더";
            컬럼들[5].너비 = 100;

            컬럼들[6] = new DexGridColumn();
            컬럼들[6].컬럼명 = "LOCATION";
            컬럼들[6].헤더명 = "현위치";
            컬럼들[6].너비 = 100;

            컬럼들[7] = new DexGridColumn();
            컬럼들[7].컬럼명 = "FACILITYCLASSID";
            컬럼들[7].헤더명 = "이동위치그룹";
            컬럼들[7].너비 = 100;
            컬럼들[7].컬럼타입 = 컬럼타입.콤보박스;
            컬럼들[7].콤보박스데이터소스 = 서비스.GetDataTable("SELECT DISTINCT FACILITYCLASSNAME ,FACILITYCLASSID FROM CIM_FACILITY");
            컬럼들[7].콤보박스디스플레이멤버 = "FACILITYCLASSNAME";
            컬럼들[7].콤보박스벨류멤버 = "FACILITYCLASSID";

            컬럼들[8] = new DexGridColumn();
            컬럼들[8].컬럼명 = "FACILITYID";
            컬럼들[8].헤더명 = "이동위치";
            컬럼들[8].너비 = 100;
            컬럼들[8].컬럼타입 = 컬럼타입.콤보박스;
            컬럼들[8].콤보박스데이터소스 = 서비스.GetDataTable("SELECT DISTINCT FACILITYID,FACILITYNAME FROM CIM_FACILITY");
            컬럼들[8].콤보박스디스플레이멤버 = "FACILITYNAME";
            컬럼들[8].콤보박스벨류멤버 = "FACILITYID";
           
            컬럼들[9] = new DexGridColumn();
            컬럼들[9].컬럼명 = "MOVEQTY";
            컬럼들[9].헤더명 = "이동수량";
            컬럼들[9].너비 = 100;

            컬럼들[10] = new DexGridColumn();
            컬럼들[10].컬럼명 = "QTY";
            컬럼들[10].헤더명 = "재고수량";
            컬럼들[10].너비 = 100;

            컬럼들[11] = new DexGridColumn();
            컬럼들[11].컬럼명 = "UNITID";
            컬럼들[11].헤더명 = "단위";
            컬럼들[11].너비 = 100;

            컬럼들[12] = new DexGridColumn();
            컬럼들[12].컬럼명 = "VENDORID";
            컬럼들[12].헤더명 = "공급사명";
            컬럼들[12].너비 = 100;

            컬럼들[13] = new DexGridColumn();
            컬럼들[13].컬럼명 = "CREATETIME";
            컬럼들[13].헤더명 = "입고일";
            컬럼들[13].너비 = 100;

            컬럼들[14] = new DexGridColumn();
            컬럼들[14].컬럼명 = "LIMIT";
            컬럼들[14].헤더명 = "제조일";
            컬럼들[14].너비 = 100;
            //
            컬럼들[15] = new DexGridColumn();
            컬럼들[15].컬럼명 = "LIMITTIME";
            컬럼들[15].헤더명 = "유효기간 만료일";
            컬럼들[15].너비 = 100;

            그리드모델.그리드.열생성(컬럼들);
        }


        private void Popup_Click(object sender, EventArgs e)
        {
            if (string.Empty == 검색조건모델.자재LOT.Text)
            {
                MessageBox.Show("자재LOT명을 입력해주세요.");
                return;
            }
            
            string 쿼리 = @"SELECT [MATERIALLOTID]
                                  ,[LOCATION]
                                  ,[QTY]
                            FROM [CIM_MATERIALLOT]
                           WHERE MATERIALLOTID LIKE '%{0}%'";

            DataTable 결과 =서비스.GetDataTable(string.Format(쿼리, 검색조건모델.자재LOT.Text));

            if (결과.Rows.Count != 0)
            {
                this.Popup창 = new 자재POPUP();
                this.Popup창.서비스 = 서비스;
                this.Popup창.자재이동 = this;
                this.Popup창.Show();
            }
            else
            {
                MessageBox.Show("자재LOT이 존재하지않습니다.");
                return;
            }
        }

        private void 추가BT_Click(object sender, EventArgs e)
        {
            if (string.Empty == 검색조건모델.이동위치.Text)
            {
                MessageBox.Show("이동위치를 선택하여 주십시오.");
                return;
            }
            string 쿼리 = @"---------------------------------------------
                         SELECT 
                         A.[MATERIALTYPE]
                        ,A.[MATERIALLOTID]
                        ,A.[MATERIALDEFINITIONID]
                        ,B.[MATERIALDEFINITIONNAME]
                        ,C.[LOTID]
                        ,A.[QTY]
                        ,A.[LOCATION]
                        ,D.[FACILITYNAME]
                        ,D.[FACILITYID]
                        ,D.[FACILITYCLASSID]
                        ,A.[UNITID]
                        ,A.[CREATETIME]
                        ,A.[VENDORID]
                        FROM [CIM_MATERIALLOT] A
                        LEFT JOIN [CIM_MATERIALDEFINITION] B
                        ON A.MATERIALCLASSID = B.MATERIALCLASSID
                        LEFT JOIN [CIM_LOT] C
                        ON B.ACTIVITY = C.ACTIVITY
                        LEFT JOIN [CIM_FACILITY] D
                        ON A.ACTIVITY =D.ACTIVITY
                        WHERE MATERIALLOTID = '{0}'";

            쿼리 = string.Format(쿼리, 검색조건모델.자재LOT.Text);
            DataTable 데이터 = 서비스.GetDataTable(쿼리);
           

            DataRow 행 = ((DataTable)그리드모델.그리드.DataSource).Rows.Add(); 
            
            string 바뀔위치그룹 = 검색조건모델.이동위치그룹.SelectedValue as string;
            string 바뀔위치 = 검색조건모델.이동위치.SelectedValue as string;

            string MATERIALTYPE = 데이터.Rows[0]["MATERIALTYPE"].ToString();
            string MATERIALLOTID = 데이터.Rows[0]["MATERIALLOTID"].ToString();
            string MATERIALDEFINITIONID = 데이터.Rows[0]["MATERIALDEFINITIONID"].ToString();
            string MATERIALDEFINITIONNAME = 데이터.Rows[0]["MATERIALDEFINITIONNAME"].ToString();
            string LOTID = 데이터.Rows[0]["LOTID"].ToString();
            string QTY = 데이터.Rows[0]["QTY"].ToString();
            string LOCATION = 데이터.Rows[0]["LOCATION"].ToString();
            string FACILITYNAME = 데이터.Rows[0]["FACILITYNAME"].ToString();
            string FACILITYID = 데이터.Rows[0]["FACILITYID"].ToString();
            string FACILITYCLASSID = 데이터.Rows[0]["FACILITYCLASSID"].ToString();
            string UNITID = 데이터.Rows[0]["UNITID"].ToString();
            string CREATETIME = 데이터.Rows[0]["CREATETIME"].ToString();
            string VENDORID = 데이터.Rows[0]["VENDORID"].ToString();
            행["MATERIALTYPE"] = MATERIALTYPE;
            행["MATERIALLOTID"] = MATERIALLOTID;
            행["MATERIALDEFINITIONID"] = MATERIALDEFINITIONID;
            행["MATERIALDEFINITIONNAME"] = MATERIALDEFINITIONNAME;
            행["LOTID"] = LOTID;
            행["QTY"] = QTY;
            행["LOCATION"] = LOCATION;
            행["FACILITYNAME"] = FACILITYNAME;
            행["FACILITYID"] = FACILITYID;
            행["FACILITYCLASSID"] = FACILITYCLASSID;
            행["UNITID"] = UNITID;
            행["CREATETIME"] = CREATETIME;
            행["VENDORID"] = VENDORID;
            행["FACILITYCLASSID"] = 바뀔위치그룹;
            행["FACILITYID"] = 바뀔위치;
            //DataGridViewComboBoxColumn 콤보박스 = 그리드모델.그리드.Columns["FACILITYID"] as DataGridViewComboBoxColumn;
            //콤보박스.DataSource = 서비스.GetDataTable(string.Format("SELECT FACILITYNAME FROM CIM_FACILITY WHERE FACILITYCLASSID = '{0}'", 행["FACILITYCLASSID"].ToString()));

           
        }
        
        private void InitializeComboBox()
        {
            Hashtable Param = new Hashtable();
            Param = new Hashtable();
            검색조건모델.이동위치그룹.DataSource = 서비스.GetDataTable("SELECT DISTINCT FACILITYCLASSID FROM CIM_FACILITY ");
            검색조건모델.이동위치그룹.DisplayMember = "FACILITYCLASSID";
            검색조건모델.이동위치그룹.ValueMember = "FACILITYCLASSID";
        }

        private void InitializeProperty()
        {
            그리드모델 = new 자재이동그리드모델();
            그리드모델.그리드 = dataGridView;
            그리드모델.그리드.기본테이블명 = "CIM_MATERIALLOT";
            


            검색조건모델 = new 자재이동검색모델();
            검색조건모델.자재LOT = 자재LOTTXB;
            검색조건모델.이동위치그룹 = 이동위치그룹CBX;
            검색조건모델.이동위치 = 이동위치CBX;
            검색조건모델.Popup = Popup;
        }

       

        public void 저장()
        {
        }
        public void 조회()
        {
        }
       
        public void 초기화()
        {
        }

        public void 행제거()
        {
        }

        public void 행추가()
        {
            if (그리드모델.그리드.DataSource == null)
            ((DataTable)그리드모델.그리드.DataSource).Rows.Add();
        }

        private void Btn자재이동_Click(object sender, EventArgs e)
        {
            if (string.Empty == this.검색조건모델.자재LOT.Text)
            {
                MessageBox.Show("이동할 자재가 없습니다.");
                return;
            }

            if (string.IsNullOrWhiteSpace(그리드모델.그리드["MOVEQTY", 그리드모델.그리드.CurrentRow.Index].Value as string))
            {
                MessageBox.Show("이동수량을 입력해주세요.");
                return;
            }

            string 쿼리 = string.Empty;
            foreach (DataGridViewRow item in 그리드모델.그리드.Rows)
            {
                string 위치 = item.Cells["LOCATION"].Value.ToString();
                string 대상랏 = item.Cells["MATERIALLOTID"].Value.ToString();
                    쿼리 = @"---------------------------------
                                UPDATE [CIM_MATERIALLOT]
                                SET
                                PREVLOCATION ='{0}'
                                WHERE MATERIALLOTID = '{1}'";

                쿼리 = string.Format(쿼리, 위치, 대상랏);
                서비스.ExcuteQuery(쿼리);

            }
            //현위치를 이전위치로 바꾸는 쿼리
           
            foreach (DataGridViewRow item in 그리드모델.그리드.Rows)
            {
                쿼리 = @"---------------------------------
                                UPDATE [CIM_MATERIALLOT]
                                SET
                                LOCATION ='{0}'
                                WHERE MATERIALLOTID = '{1}'";

                쿼리 = string.Format(쿼리, 그리드모델.그리드["LOCATION", 그리드모델.그리드.CurrentRow.Index].Value.ToString(), 검색조건모델.자재LOT.Text);
                서비스.ExcuteQuery(쿼리);
            }

            //이전수량쿼리
            
            int IQTY = Convert.ToInt32(그리드모델.그리드["MOVEQTY", 그리드모델.그리드.CurrentRow.Index].Value.ToString());
            int QTY = Convert.ToInt32(그리드모델.그리드["QTY", 그리드모델.그리드.CurrentRow.Index].Value.ToString());
            int 현재수량 = QTY - IQTY;
           
            쿼리 = @"-----------------------------------------
                                UPDATE [CIM_MATERIALLOT]
                                SET
                                QTY = '{0}' ,
                                LOSSQTY = '{1}'
                                WHERE MATERIALLOTID ='{2}'
                                ";

            쿼리 = string.Format(쿼리, 현재수량, 그리드모델.그리드["MOVEQTY", 그리드모델.그리드.CurrentRow.Index].Value.ToString(), 검색조건모델.자재LOT.Text);
            //QTY = 뺸값 LOSSQTY = 그리드에 적은값 (빼는값)  
            
            서비스.ExcuteQuery(쿼리);

            //새로넣어주는쿼리
            Hashtable Param = new Hashtable();
            Param["MATERIALLOTID"] = 검색조건모델.자재LOT.Text;
            Param["MATERIALDEFINITIONID"] = 그리드모델.그리드["MATERIALDEFINITIONID", 그리드모델.그리드.CurrentRow.Index].Value.ToString();
            Param["LOCATION"] = 검색조건모델.이동위치.Text;
            Param["ORIGINALQTY"] = 그리드모델.그리드["QTY", 그리드모델.그리드.CurrentRow.Index].Value.ToString();
            Param["QTY"] = 그리드모델.그리드["MOVEQTY", 그리드모델.그리드.CurrentRow.Index].Value.ToString();
            Param["PREVLOCATION"] = 그리드모델.그리드["LOCATION", 그리드모델.그리드.CurrentRow.Index].Value.ToString();
            Param["PREVQTY"] = 그리드모델.그리드["QTY", 그리드모델.그리드.CurrentRow.Index].Value.ToString();
            서비스.명령수행("자재이동", Param);
            
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)//컬럼이 버튼이면서 인덱스가 헤더행이 아닌 경우
            {
                if (그리드모델.그리드.CurrentRow != null)
                    if ((DataRowView)그리드모델.그리드.CurrentRow.DataBoundItem != null)
                    {
                        bool a = 그리드모델.그리드.CurrentRow.IsNewRow;
                        DataRow DR = ((DataRowView)그리드모델.그리드.CurrentRow.DataBoundItem).Row;
                        그리드모델.그리드.Rows.Remove(그리드모델.그리드.CurrentRow);
                    }
            }
        }
    }

        
}
