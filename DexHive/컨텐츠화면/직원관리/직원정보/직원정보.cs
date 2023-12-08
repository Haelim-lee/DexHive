using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DexCommonUtil.UI도구;
using DexCommonUtil.UI도구.사용자정의컨트롤;
using DexHive;

namespace DexHive.컨텐츠화면.직원관리.직원정보그룹
{
    public partial class 직원정보 : 스크린, I스크린
    {
        public 직원정보표_모델 그리드모델 {get;set;}

        public 직원정보()
        {
            InitializeComponent();
            InitializeProperty();
            InitializeEvent();
        }

        private void InitializeProperty()
        {
            그리드모델 = new 직원정보표_모델();
            그리드모델.그리드 = 직원정보표;
            그리드모델.그리드.기본테이블명 = "직원정보";
        }
        private void InitializeEvent()
        {
            this.Load += 직원관리화면_Load;//직원관리화면
            
            this.기본기능.조회버튼.Click += (object sender, EventArgs e) => 조회();
            this.기본기능.저장버튼.Click += (object sender, EventArgs e) => 저장();
            this.기본기능.행추가버튼.Click += (object sender, EventArgs e) => 행추가();
            this.기본기능.행제거버튼.Click += (object sender, EventArgs e) => 행제거();
        }

        public void 조회()
        {
            Hashtable Param = new Hashtable();
            Param["아이디"] = this.textBox1.Text;
            Param["이름"] = this.textBox2.Text;
            Param["입사일"] = this.textBox5.Text;
            Param["생년월일"] = this.textBox4.Text;
            Param["직급"] = this.textBox3.Text;

            DexGridColumn[] 컬럼들 = new DexGridColumn[5];
            컬럼들[0] = new DexGridColumn();
            컬럼들[0].컬럼명 = "아이디";
            컬럼들[0].헤더명 = "아이디";
            컬럼들[0].너비 = 100;

            컬럼들[1] = new DexGridColumn();
            컬럼들[1].컬럼명 = "이름";
            컬럼들[1].헤더명 = "이름";
            컬럼들[1].너비 = 80;

            컬럼들[2] = new DexGridColumn();
            컬럼들[2].컬럼명 = "입사일";
            컬럼들[2].헤더명 = "입사일";
            컬럼들[2].너비 = 100;

     

            컬럼들[3] = new DexGridColumn();
            컬럼들[3].컬럼명 = "생년월일";
            컬럼들[3].헤더명 = "생년월일";
            컬럼들[3].너비 = 80;

            컬럼들[4] = new DexGridColumn();
            컬럼들[4].컬럼명 = "직급";
            컬럼들[4].헤더명 = "직급";
            컬럼들[4].너비 = 80;

            그리드모델.그리드.열생성(컬럼들);

            this.그리드모델.그리드.바인딩(서비스.조회수행("직원조회", Param));
        }

        public void 행추가()
        {
            if (직원정보표.DataSource == null) 조회();
            {
                ((DataTable)직원정보표.DataSource).Rows.Add();
            }
        }

        public void 행제거()
        {
            if (직원정보표.CurrentRow != null)
                if ((DataRowView)직원정보표.CurrentRow.DataBoundItem != null)
                {
                    bool a = 직원정보표.CurrentRow.IsNewRow;
                    DataRow DR = ((DataRowView)직원정보표.CurrentRow.DataBoundItem).Row;
                    직원정보표.Rows.Remove(직원정보표.CurrentRow);
                    //((DataTable)직원등록표.DataSource).Rows.Remove(DR);
                }
        }

        public void 저장()
        {
            그리드모델.그리드.CurrentCell = null;
            DataTable 반영표 = 그리드모델.그리드.DataSource as DataTable;
            그리드모델.그리드.반영(반영표,서비스);
            조회();
        }

        public void 수정()
        {
            throw new NotImplementedException();
        }

        public void 삭제()
        {

        }

        public void 초기화()
        {
            throw new NotImplementedException();
        }

        private void 직원관리화면_Load(object sender, EventArgs e)
        {
            string 명령어 = @"SELECT [회원].[아이디],
	                                 [회원].[이름],
                                     [직원].[직급],
                                     [직원].[입사일]
                                FROM [사용자정보] 회원
                          RIGHT JOIN [직원정보] 직원 ON [직원].아이디 = [회원].아이디";
            
            DataTable 결과 = 서비스.GetDataTable(명령어);
            this.직원정보표.DataSource = 결과;
        }

 
    }
}
