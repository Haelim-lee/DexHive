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

namespace DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.공정관리_반제품_
{
    public partial class 자재LOT정보Popup : Form
    {
        public 자재LOT정보그리드 그리드모델 { get; set; }
        public 자재LOT검색모델 검색모델 { get; set; }
        public I서버인터페이스 서비스 { get; set; }
        public 주제공정시작 주제공정시작 { get; set; }

        public 자재LOT정보Popup()
        {
            InitializeComponent();
            InitlalizeProperty();
            InitlalizeEvent();
        }

        private void 자재LOT정보Popup_Shown(object sender, EventArgs e)
        {
            InitializeGrid();
        }

        private void InitlalizeProperty()
        {
            그리드모델 = new 자재LOT정보그리드();
            그리드모델.dateGrid = this.dataGrid;
            그리드모델.dateGrid.기본테이블명 = "CIM_MATERIALDEFINITION";

            검색모델 = new 자재LOT검색모델();
            검색모델.제품코드 = this.ProductcodeTBX;
            검색모델.제품명 = this.LOTIDTXB;
            검색모델.자재코드 = this.MaterialCodeCBO;
            검색모델.자재LOT = this.자재LOTTXB;
            
        }

        private void InitlalizeEvent()
        {
            this.Shown += 자재LOT정보Popup_Shown;
            
        }

        private void InitializeGrid()
        {
            DexGridColumn[] 컬럼들 = new DexGridColumn[6];

            컬럼들[0] = new DexGridColumn();
            컬럼들[0].컬럼명 = "CHECKBOX";
            컬럼들[0].헤더명 = "CHECKBOX";
            컬럼들[0].너비 = 80;
            컬럼들[0].컬럼타입 = 컬럼타입.체크박스;

            컬럼들[1] = new DexGridColumn();
            컬럼들[1].컬럼명 = "MATERIALDEFINITIONID";
            컬럼들[1].헤더명 = "자재LOT";
            컬럼들[1].너비 = 80;

            컬럼들[2] = new DexGridColumn();
            컬럼들[2].컬럼명 = "MATERIALDEFINITIONNAME";
            컬럼들[2].헤더명 = "자재코드";
            컬럼들[2].너비 = 80;

            컬럼들[3] = new DexGridColumn();
            컬럼들[3].컬럼명 = "MBOMQTY";
            컬럼들[3].헤더명 = "자재명";
            컬럼들[3].너비 = 80;

            컬럼들[4] = new DexGridColumn();
            컬럼들[4].컬럼명 = "QTY";
            컬럼들[4].헤더명 = "수량";
            컬럼들[4].너비 = 80;

            컬럼들[5] = new DexGridColumn();
            컬럼들[5].컬럼명 = "UNITID";
            컬럼들[5].헤더명 = "단위";
            컬럼들[5].너비 = 80;

            그리드모델.dateGrid.열생성(컬럼들);
            조회();
        }

        public void 저장()
        {
            throw new NotImplementedException();
        }

        public void 조회()
        {
            Hashtable Param = new Hashtable();
            this.그리드모델.dateGrid.바인딩(서비스.조회수행("LOT추가팝업창", Param));
            //BOM 데이터 만들어야댐
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

        private void button2_Click(object sender, EventArgs e)
        {
            string 아이템 = string.Empty;
            foreach (DataGridViewRow item in 그리드모델.dateGrid.Rows)
            {
                아이템 = IsCheck(item);

                if(아이템 == "True")
                {
                    주제공정시작.그리드모델.LOT정보그리드.Rows.Add(item.Cells["MATERIALDEFINITIONID"].Value, item.Cells["MATERIALDEFINITIONNAME"].Value, item.Cells["MBOMQTY"].Value, item.Cells["QTY"].Value,"", item.Cells["UNITID"].Value, "", "", "", "", "");
                }
                else
                { 
                }
            }
        }

        private string IsCheck(DataGridViewRow item)
        {
            string 아이템;
            if (item.Cells["CHECKBOX"].Value != null)
                아이템 = item.Cells["CHECKBOX"].Value.ToString();
            else
                아이템 = "False";
            return 아이템;
        }
    }
}
