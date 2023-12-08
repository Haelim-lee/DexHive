using DexCommonUtil.UI도구;
using DexCommonUtil.UI도구.사용자정의컨트롤;
using DexServer;
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
    public partial class 자재POPUP : Form
    {
        public PopupGrid 그리드모델 { get; set; }
        public 자재이동 자재이동 { get; set; }
        public I서버인터페이스 서비스 { get; set; }

        public 자재POPUP()
        {
            InitializeComponent();
            InitializeEvnet();
            InitlalizeProperty();
        }

        private void InitlalizeProperty()
        {
            그리드모델 = new PopupGrid();
            그리드모델.그리드 = this.PopupGrid;
            그리드모델.그리드.기본테이블명 = "CIM_MATERIALLOT";
        }

        private void InitializeEvnet()
        {
            this.Shown += 자재POPUP_Shown;
        }

        private void 자재POPUP_Shown(object sender, EventArgs e)
        {
            InltializeGrid();
        }

        private void InltializeGrid()
        {
            DexGridColumn[] 컬럼들 = new DexGridColumn[3];
            컬럼들[0] = new DexGridColumn();
            컬럼들[0].컬럼명 = "MATERIALLOTID";
            컬럼들[0].헤더명 = "자재LOT";
            컬럼들[0].너비 = 100;

            컬럼들[1] = new DexGridColumn();
            컬럼들[1].컬럼명 = "LOCATION";
            컬럼들[1].헤더명 = "현위치";
            컬럼들[1].너비 = 100;

            컬럼들[2] = new DexGridColumn();
            컬럼들[2].컬럼명 = "QTY";
            컬럼들[2].헤더명 = "수량";
            컬럼들[2].너비 = 100;

            그리드모델.그리드.열생성(컬럼들);
            조회();
        }

        public void 저장()
        {
            
        }

        public void 조회()
        {
            string 쿼리 = @"------------------------------------
                                 SELECT 
                                 [MATERIALLOTID]
                                ,[LOCATION]
                                ,[QTY]
                                FROM [CIM_MATERIALLOT]
                                WHERE MATERIALLOTID LIKE '%{0}%'";

            this.그리드모델.그리드.바인딩(서비스.GetDataTable(string.Format(쿼리,this.자재이동.검색조건모델.자재LOT.Text)));
        }

        public void 초기화()
        {
        }

        public void 행제거()
        {
            
        }

        public void 행추가()
        {
            
        }

        private void PopupGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string 선택된LOT = (sender as DexGridView).CurrentCell.Value.ToString();
            자재이동.검색조건모델.자재LOT.Text = 선택된LOT;
            Close();
        }
    }
}
