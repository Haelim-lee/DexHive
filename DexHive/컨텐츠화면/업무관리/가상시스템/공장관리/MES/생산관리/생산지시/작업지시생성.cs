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
    public partial class 작업지시생성 : 스크린, I스크린
    {
        public 작업지시생성()
        {
            InitializeComponent();
            InitializeEvent();
        }

        private void InitializeEvent()
        {
            this.Shown += 작업지시생성_Shown;
            this.기본기능.저장버튼.Click += (object sender, EventArgs e) => 저장();
        }


        private void 작업지시생성_Shown(object sender, EventArgs e)
        {
            InitializeComboBox();
            InitializeGrid();
            조회();
        }

        private void InitializeComboBox()
        {
            Hashtable 조건 = new Hashtable();
            조건["코드그룹"] = "제품구분";
            this.comboBox2.DataSource = 서비스.조회수행("공통코드", 조건);
            this.comboBox2.DisplayMember = "명칭";
            this.comboBox2.ValueMember = "코드";

            조건 = new Hashtable();
            조건["코드그룹"] = "생산구분";
            this.comboBox5.DataSource = 서비스.조회수행("공통코드", 조건);
            this.comboBox5.DisplayMember = "명칭";
            this.comboBox5.ValueMember = "코드";

            조건 = new Hashtable();
            조건["코드그룹"] = "단위";
            this.comboBox6.DataSource = 서비스.조회수행("공통코드", 조건);
            this.comboBox6.DisplayMember = "명칭";
            this.comboBox6.ValueMember = "코드";

            조건 = new Hashtable();
            조건["코드그룹"] = "생산계획오더상태";
            this.comboBox3.DataSource = 서비스.조회수행("공통코드", 조건);
            this.comboBox3.DisplayMember = "명칭";
            this.comboBox3.ValueMember = "코드";

            조건 = new Hashtable();
            조건["코드그룹"] = "제품";
            this.comboBox4.DataSource = 서비스.조회수행("공통코드", 조건);
            this.comboBox4.DisplayMember = "명칭";
            this.comboBox4.ValueMember = "코드";

            this.comboBox1.DataSource = 서비스.GetDataTable("SELECT VENDORID, VENDORNAME FROM CIM_VENDOR");
            this.comboBox1.DisplayMember = "VENDORNAME";
            this.comboBox1.ValueMember = "VENDORID";

        }

        private void InitializeGrid()
        {
            DexGridColumn[] 컬럼들 = new DexGridColumn[10];
            컬럼들[0] = new DexGridColumn();
            컬럼들[0].컬럼명 = "PRODUCTORDERID";
            컬럼들[0].헤더명 = "생산오더";
            컬럼들[0].너비 = 80;

            컬럼들[1] = new DexGridColumn();
            컬럼들[1].컬럼명 = "LOTID";
            컬럼들[1].헤더명 = "생산LOT";
            컬럼들[1].너비 = 80;
                   
            컬럼들[2] = new DexGridColumn();
            컬럼들[2].컬럼명 = "SITEID";
            컬럼들[2].헤더명 = "사이트";
            컬럼들[2].너비 = 80;

            컬럼들[3] = new DexGridColumn();
            컬럼들[3].컬럼명 = "PRODUCTTYPE";
            컬럼들[3].헤더명 = "제품타입";
            컬럼들[3].너비 = 80;

            컬럼들[4] = new DexGridColumn();
            컬럼들[4].컬럼명 = "QTY";
            컬럼들[4].헤더명 = "계획수량";
            컬럼들[4].너비 = 80;

            컬럼들[5] = new DexGridColumn();
            컬럼들[5].컬럼명 = "UNITID";
            컬럼들[5].헤더명 = "단위";
            컬럼들[5].너비 = 80;

            컬럼들[6] = new DexGridColumn();
            컬럼들[6].컬럼명 = "SCHEDULESTARTTIME";
            컬럼들[6].헤더명 = "계획시작일";
            컬럼들[6].너비 = 80;

            컬럼들[7] = new DexGridColumn();
            컬럼들[7].컬럼명 = "SCHEDULEENDTIME";
            컬럼들[7].헤더명 = "계획종료일";
            컬럼들[7].너비 = 80;

            컬럼들[8] = new DexGridColumn();
            컬럼들[8].컬럼명 = "CUSTOMERID";
            컬럼들[8].헤더명 = "고객사ID";
            컬럼들[8].컬럼타입 = 컬럼타입.콤보박스;
            컬럼들[8].콤보박스데이터소스 = 서비스.GetDataTable("SELECT VENDORID, VENDORNAME FROM CIM_VENDOR");
            컬럼들[8].콤보박스디스플레이멤버 = "VENDORNAME";
            컬럼들[8].콤보박스벨류멤버 = "VENDORID";
            컬럼들[8].너비 = 80;

            컬럼들[9] = new DexGridColumn();
            컬럼들[9].컬럼명 = "MODIFYTIME";
            컬럼들[9].헤더명 = "수정일시";
            컬럼들[9].너비 = 80;

            this.dexGridView1.열생성(컬럼들);
        }

        public void 저장()
        {
            string 생산계획오더아이디 = 생산계획오더아이디생성();
            string LOT아이디 = 생산LOT생성();
           
            // 기준정보에 생성
           
            Hashtable Param = new Hashtable();
            Param["PRODUCTORDERID"] = 생산계획오더아이디;
            Param["STATE"] = string.IsNullOrEmpty(this.comboBox3.SelectedValue.ToString()) ? "투입대기" : this.comboBox3.SelectedValue.ToString();
            Param["SCHEDULESTARTTIME"] = this.dateTimePicker1.Value.ToShortDateString();
            Param["SCHEDULEENDTIME"] = this.dateTimePicker2.Value.ToShortDateString();
            Param["SITEID"] = "A400";
            Param["PRODUCTTYPE"] = this.comboBox2.SelectedValue.ToString();
            Param["PRODUCTORDERTYPE"] = this.comboBox5.SelectedValue.ToString();
            Param["PRODUCTDEFINITIONID"] = this.comboBox4.SelectedValue.ToString();
            Param["QTY"] = this.textBox1.Text;
            Param["UNITID"] = this.comboBox6.SelectedValue.ToString();
            Param["MODIFYTIME"] = DateTime.Now.ToString();
            Param["CUSTOMERID"] = this.comboBox1.SelectedValue.ToString();
            서비스.명령수행("작업지시추가",Param);

            Param.Clear();
            Param["PRODUCTORDERID"] = 생산계획오더아이디;
            Param["LOTID"] = LOT아이디;
            Param["SITEID"] = "A400";
            Param["STATE"] = "투입대기";
            Param["CREATETIME"] = DateTime.Now;
            Param["MODIFYTIME"] = DateTime.Now;
            Param["VENDORID"] = this.comboBox1.SelectedValue.ToString();
            서비스.명령수행("생산LOT등록", Param);
            조회();
        }

        private string 생산LOT생성()
        {
            string 쿼리 = string.Format("SELECT COUNT(*) FROM CIM_LOT WHERE CONVERT(CHAR(10), CREATETIME, 23) = '{0}'", DateTime.Now.ToShortDateString());
            int 시퀀스 =Convert.ToInt32(서비스.GetDataTable(쿼리).Rows[0][0]);
            string 생산LOT =string.Format("{0}{1}{2}", "P", DateTime.Now.ToString("yyMMdd"), (시퀀스 + 1).ToString().PadLeft(4, '0'));

            return 생산LOT;
        }

        private string 생산계획오더아이디생성()
        {
            DataTable 오더번호 = 서비스.GetDataTable("SELECT NEXT VALUE FOR 작업지시오더");
            return 오더번호.Rows[0][0].ToString().PadLeft(12, '0');
        }

        public void 조회()
        {
            Hashtable Param = new Hashtable();
            Param["SCHEDULESTARTTIME"] = dateTimePicker1.Value.ToShortDateString() + "," + dateTimePicker2.Value.ToShortDateString();
            this.dexGridView1.바인딩(서비스.조회수행("작업지시조회", Param));
            this.dexGridView1.Columns["CUSTOMERID"].ReadOnly = true;

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
    }
}
