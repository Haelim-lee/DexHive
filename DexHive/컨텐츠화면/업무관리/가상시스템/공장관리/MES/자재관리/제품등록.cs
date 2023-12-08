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
    public partial class 제품등록 : 스크린, I스크린
    {
        public 제품등록()
        {
            InitializeComponent();
            InitializeEvent();
        }

        private void InitializeEvent()
        {
            this.Shown += 제품등록_Shown;
            this.기본기능.저장버튼.Click += (object sender, EventArgs e) => 저장();
        }

        private void 제품등록_Shown(object sender, EventArgs e)
        {
            InitializeGrid();
        }

        private void InitializeGrid()
        {
            DexGridColumn[] 컬럼들 = new DexGridColumn[9];
            컬럼들[0] = new DexGridColumn();
            컬럼들[0].컬럼명 = "PRODUCTDEFINITIONID";
            컬럼들[0].헤더명 = "제품코드";
            컬럼들[0].너비 = 100;

            컬럼들[1] = new DexGridColumn();
            컬럼들[1].컬럼명 = "PRODUCTDEFINITIONNAME"; 
            컬럼들[1].헤더명 = "제품명"; 
            컬럼들[1].너비 = 100;

            컬럼들[2] = new DexGridColumn();
            컬럼들[2].컬럼명 = "SITEID";
            컬럼들[2].헤더명 = "SITEID";
            컬럼들[2].너비 = 100;

            컬럼들[3] = new DexGridColumn();
            컬럼들[3].컬럼명 = "QTY";
            컬럼들[3].헤더명 = "월계";
            컬럼들[3].너비 = 80;

            컬럼들[4] = new DexGridColumn();
            컬럼들[4].컬럼명 = "UNITID";
            컬럼들[4].헤더명 = "단위";
            컬럼들[4].너비 = 80;

            컬럼들[5] = new DexGridColumn();
            컬럼들[5].컬럼명 = "PRODUCTDEFINITIONTYPE";
            컬럼들[5].헤더명 = "제품정의타입";
            컬럼들[5].너비 = 80;

            컬럼들[6] = new DexGridColumn();
            컬럼들[6].컬럼명 = "CUSTOMERID";
            컬럼들[6].헤더명 = "고객사";
            컬럼들[6].너비 = 80;

            컬럼들[7] = new DexGridColumn();
            컬럼들[7].컬럼명 = "LOCATION";
            컬럼들[7].헤더명 = "위치";
            컬럼들[7].너비 = 80;

            컬럼들[8] = new DexGridColumn();
            컬럼들[8].컬럼명 = "MATERIALTYPE";
            컬럼들[8].헤더명 = "자재타입";
            컬럼들[8].너비 = 80;


            this.dexGridView1.열생성(컬럼들);


        }

        public void 저장()
        {
            Hashtable Param = new Hashtable();
            Param["PRODUCTDEFINITIONID"] = this.textBox1.Text;
            Param["SITEID"] = "A400";
            Param["PRODUCTDEFINITIONNAME"] = this.textBox2.Text;
            Param["QTY"] = "";
            Param["UNITID"] = "";
            Param["PRODUCTDEFINITIONTYPE"] = "";
            Param["CUSTOMERID"] = "";
            Param["LOCATION"] = "";
            Param["MATERIALTYPE"] = "";

            서비스.명령수행("제품등록", Param);
            조회();

        }

        public void 조회()
        {
            string 쿼리 = @"------------------
                      SELECT
                        A.코드 AS PRODUCTDEFINITIONID,
                        A.명칭 AS PRODUCTDEFINITIONNAME,
                        B.SITEID,
                        B.QTY,
                        B.UNITID,
                        B.PRODUCTDEFINITIONTYPE,
                        B.CUSTOMERID,
                        B.LOCATION,
                        B.MATERIALTYPE
                    FROM
                    (SELECT * FROM 기준정보 WHERE 코드그룹 = '제품') A
                    LEFT JOIN CIM_PRODUCTDEFINITION B
                    ON A.코드 = B.PRODUCTDEFINITIONID
                    AND A.명칭 = B.PRODUCTDEFINITIONNAME
                --------------------------";

            this.dexGridView1.바인딩(서비스.GetDataTable(쿼리));

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
