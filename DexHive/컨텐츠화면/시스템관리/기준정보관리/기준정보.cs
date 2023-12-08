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

namespace DexHive.컨텐츠화면.시스템관리.기준정보관리그룹
{
    public partial class 기준정보 : 스크린, I스크린
    {
        public 기준정보표_모델 그리드모델 {get;set;}

        public 기준정보()
        {
            InitializeComponent();
            InitializeProperty();
            InitializeEvent();
        }

        private void InitializeProperty()
        {
            그리드모델 = new 기준정보표_모델();
            그리드모델.그리드 = 기준정보표;
            그리드모델.그리드.기본테이블명 = "기준정보";

           
        }
        private void InitializeEvent()
        {
            this.Shown += 기준정보화면_Load;//직원관리화면
            
            this.기본기능.조회버튼.Click += (object sender, EventArgs e) => 조회();
            this.기본기능.저장버튼.Click += (object sender, EventArgs e) => 저장();
            this.기본기능.행추가버튼.Click += (object sender, EventArgs e) => 행추가();
            this.기본기능.행제거버튼.Click += (object sender, EventArgs e) => 행제거();
        }

        public void 조회()
        {
            Hashtable Param = new Hashtable();
            Param["코드"] = this.textBox1.Text;
            Param["값"] = this.textBox2.Text; 
            Param["코드그룹"] = (this.comboBox1.SelectedValue == null) ? string.Empty : this.comboBox1.SelectedValue.ToString();

            DexGridColumn[] 컬럼들 = new DexGridColumn[4];
            컬럼들[0] = new DexGridColumn();
            컬럼들[0].컬럼명 = "코드";
            컬럼들[0].헤더명 = "코드";
            컬럼들[0].너비 = 100;

            컬럼들[1] = new DexGridColumn();
            컬럼들[1].컬럼명 = "값";
            컬럼들[1].헤더명 = "값";
            컬럼들[1].너비 = 80;

            컬럼들[2] = new DexGridColumn();
            컬럼들[2].컬럼명 = "코드그룹";
            컬럼들[2].헤더명 = "코드그룹";
            컬럼들[2].너비 = 100;

     

            컬럼들[3] = new DexGridColumn();
            컬럼들[3].컬럼명 = "설명";
            컬럼들[3].헤더명 = "설명";
            컬럼들[3].너비 = 80;

            그리드모델.그리드.열생성(컬럼들);

            this.그리드모델.그리드.바인딩(서비스.조회수행("기준정보조회", Param));
        }

        public void 행추가()
        {
            if (기준정보표.DataSource == null) 조회();
            {
                ((DataTable)기준정보표.DataSource).Rows.Add();
            }
        }

        public void 행제거()
        {
            if (기준정보표.CurrentRow != null)
                if ((DataRowView)기준정보표.CurrentRow.DataBoundItem != null)
                {
                    bool a = 기준정보표.CurrentRow.IsNewRow;
                    DataRow DR = ((DataRowView)기준정보표.CurrentRow.DataBoundItem).Row;
                    기준정보표.Rows.Remove(기준정보표.CurrentRow);
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
     

        public void 초기화()
        {
            throw new NotImplementedException();
        }

        private void 기준정보화면_Load(object sender, EventArgs e)
        {
            DataTable 결과 = 서비스.조회수행("기준정보조회",new Hashtable());
            this.기준정보표.DataSource = 결과;

            comboBox1.DataSource = 서비스.조회수행("코드그룹조회", new Hashtable());
            comboBox1.DisplayMember = "명칭";
            comboBox1.ValueMember = "코드";
        }

    }
}
