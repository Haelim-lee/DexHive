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
    public partial class 자재등록 : 스크린,I스크린
    {
        public 자재등록표_모델 그리드모델 { get; set; }
        public 자재등록모델 등록조건모델 { get; set; }

        public 자재등록()
        {
            InitializeComponent();
            InitializeProperty();
            InitializeEvent();
        }

        private void InitializeEvent()
        {
            this.Shown += 자재등록_Shown;

            this.기본기능.조회버튼.Click += (object sender, EventArgs e) => 조회();
            this.기본기능.저장버튼.Click += (object sender, EventArgs e) => 저장();
            this.기본기능.행추가버튼.Click += (object sender, EventArgs e) => 행추가();
            this.기본기능.행제거버튼.Click += (object sender, EventArgs e) => 행제거();
        }

        private void InitializeProperty()
        {
            그리드모델 = new 자재등록표_모델();
            그리드모델.그리드 = this.자재등록표;

            등록조건모델 = new 자재등록모델();
            등록조건모델.자재코드ID= this.txt자재코드ID;
            등록조건모델.자재코드명 = this.txt자재코드명;
            등록조건모델.자재그룹ID = this.txt자재그룹ID;
            등록조건모델.자재코드타입 = this.txt자재코드타입;
            등록조건모델.자재기준수량 = this.txt자재기준수량;
            등록조건모델.자재기준단위 = this.txt자재기준단위;
            등록조건모델.이동위치 = this.cbo이동위치;
        }

        private void 자재등록_Shown(object sender, EventArgs e)
        {
            그리드초기화();
            콤보박스초기화();
        }

        private void 콤보박스초기화()
        {
            Hashtable Param = new Hashtable();
            Param = new Hashtable();
            등록조건모델.이동위치.DataSource = 서비스.GetDataTable("SELECT FACILITYNAME FROM CIM_FACILITY ");
            등록조건모델.이동위치.DisplayMember = "FACILITYCLASSID";
            등록조건모델.이동위치.ValueMember = "FACILITYNAME";
        }

        private void 그리드초기화()
        {
            DexGridColumn[] 컬럼들 = new DexGridColumn[7];
            컬럼들[0] = new DexGridColumn();
            컬럼들[0].컬럼명 = "MATERIALDEFINITIONID";
            컬럼들[0].헤더명 = "자재코드ID";
            컬럼들[0].너비 = 100;

            컬럼들[1] = new DexGridColumn();
            컬럼들[1].컬럼명 = "SITEID";
            컬럼들[1].헤더명 = "사이트ID";
            컬럼들[1].너비 = 100;

            컬럼들[2] = new DexGridColumn();
            컬럼들[2].컬럼명 = "MATERIALDEFINITIONNAME";
            컬럼들[2].헤더명 = "자재코드명";
            컬럼들[2].너비 = 100;

            컬럼들[3] = new DexGridColumn();
            컬럼들[3].컬럼명 = "MATERIALCLASSID";
            컬럼들[3].헤더명 = "자재그룹ID";
            컬럼들[3].너비 = 100;

            컬럼들[4] = new DexGridColumn();
            컬럼들[4].컬럼명 = "QTY";
            컬럼들[4].헤더명 = "자재기준수량";
            컬럼들[4].너비 = 100;

            컬럼들[5] = new DexGridColumn();
            컬럼들[5].컬럼명 = "UNITID";
            컬럼들[5].헤더명 = "자재기준단위";
            컬럼들[5].너비 = 100;

            컬럼들[6] = new DexGridColumn();
            컬럼들[6].컬럼명 = "MATERIALTYPE";
            컬럼들[6].헤더명 = "자재코드타입";
            컬럼들[6].너비 = 100;

            그리드모델.그리드.열생성(컬럼들);
            그리드모델.그리드.DataSource = 서비스.GetDataTable("SELECT * FROM [CIM_MATERIALDEFINITION]");
        }

        public void 저장()
        {
            Hashtable Param = new Hashtable();
            Param["MATERIALDEFINITIONID"] = string.IsNullOrEmpty(등록조건모델.자재코드ID.Text as string) ? string.Empty : 등록조건모델.자재코드ID.Text as string;
            Param["SITEID"] = "A400";
            Param["MATERIALDEFINITIONNAME"] = string.IsNullOrEmpty(등록조건모델.자재코드명.Text as string) ? string.Empty : 등록조건모델.자재코드명.Text as string;
            Param["MATERIALCLASSID"] = string.IsNullOrEmpty(등록조건모델.자재그룹ID.Text as string) ? string.Empty : 등록조건모델.자재그룹ID.Text as string;
            Param["QTY"] = string.IsNullOrEmpty(등록조건모델.자재기준수량.Text as string) ? string.Empty : 등록조건모델.자재기준수량.Text as string;
            Param["UNITID"] = string.IsNullOrEmpty(등록조건모델.자재기준단위.Text as string) ? string.Empty : 등록조건모델.자재기준단위.Text as string;
            Param["MATERIALTYPE"] = string.IsNullOrEmpty(등록조건모델.자재코드타입.Text as string) ? string.Empty : 등록조건모델.자재코드타입.Text as string;
            Param["MODIFYTIME"] = DateTime.Now;
            Param["LOCATION"] = string.IsNullOrEmpty(등록조건모델.이동위치.SelectedValue as string) ? string.Empty : 등록조건모델.이동위치.SelectedValue as string;

            서비스.명령수행("자재등록", Param);
            그리드모델.그리드.DataSource = 서비스.GetDataTable("SELECT * FROM [CIM_MATERIALDEFINITION]");
        }

        public void 조회()
        {
            Hashtable Param = new Hashtable();
            Param["MATERIALDEFINITIONID"] = string.IsNullOrEmpty(등록조건모델.자재코드ID.Text as string) ? string.Empty : 등록조건모델.자재코드ID.Text as string;
            Param["SITEID"] = "A400";
            Param["MATERIALDEFINITIONNAME"] = string.IsNullOrEmpty(등록조건모델.자재코드명.Text as string) ? string.Empty : 등록조건모델.자재코드명.Text as string;
            Param["MATERIALCLASSID"] = string.IsNullOrEmpty(등록조건모델.자재그룹ID.Text as string) ? string.Empty : 등록조건모델.자재그룹ID.Text as string;
            Param["QTY"] = string.IsNullOrEmpty(등록조건모델.자재기준수량.Text as string) ? string.Empty : 등록조건모델.자재기준수량.Text as string;
            Param["UNITID"] = string.IsNullOrEmpty(등록조건모델.자재기준단위.Text as string) ? string.Empty : 등록조건모델.자재기준단위.Text as string;
            Param["MATERIALTYPE"] = string.IsNullOrEmpty(등록조건모델.자재코드타입.Text as string) ? string.Empty : 등록조건모델.자재코드타입.Text as string;

            this.그리드모델.그리드.바인딩(서비스.조회수행("자재조회", Param));
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
