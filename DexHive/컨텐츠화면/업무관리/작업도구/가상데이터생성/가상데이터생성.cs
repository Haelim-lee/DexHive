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

namespace DexHive.컨텐츠화면.업무관리.작업도구.가상데이터생성그룹
{
    public partial class 가상데이터생성 : 스크린, I스크린
    {
        public 가상데이터표_모델 그리드모델 { get; set; }
        public 검색조건_모델 검색조건모델 { get; set; }
        
        public 가상데이터생성()
        {
            InitializeComponent();
            InitializeProperty();
            InitializeEvent();
        }


        private void InitializeProperty()
        {
            그리드모델 = new 가상데이터표_모델();
            그리드모델.그리드 = this.dexGridView1;

            검색조건모델 = new 검색조건_모델();
            검색조건모델.테이블명 = this.comboBox2;
            검색조건모델.컬럼명 = this.comboBox3;
            검색조건모델.데이터종류 = this.comboBox1;
            검색조건모델.데이터타입_시퀀스 = this.radioButton1;
            검색조건모델.데이터타입_문자열 = this.radioButton2;
        }
        private void InitializeEvent()
        {
            this.Shown += 가상데이터생성_Shown;//직원관리화면

            this.기본기능.조회버튼.Click += (object sender, EventArgs e) => 조회();
            this.기본기능.저장버튼.Click += (object sender, EventArgs e) => 저장();
            this.기본기능.행추가버튼.Click += (object sender, EventArgs e) => 행추가();
            this.기본기능.행제거버튼.Click += (object sender, EventArgs e) => 행제거();

            this.검색조건모델.테이블명.SelectedValueChanged += (object sender, EventArgs e)=> 컬럼콤보초기화();
        }

 

        private void 가상데이터생성_Shown(object sender, EventArgs e)
        {
            그리드초기화();
            콤보박스초기화();//콤보박스초기화
            조회();
        }
        private void 컬럼콤보초기화()
        {
            Hashtable Param = new Hashtable();
            if (검색조건모델.테이블명.SelectedValue as string != null)
                Param["TABLE_NAME"] = 검색조건모델.테이블명.SelectedValue.ToString();
            검색조건모델.컬럼명.DataSource = 서비스.조회수행("컬럼스키마", Param);
            검색조건모델.컬럼명.DisplayMember = "COLUMN_NAME";
            검색조건모델.컬럼명.ValueMember = "COLUMN_NAME";
        }

        private void 콤보박스초기화()
        {
            Hashtable Param = new Hashtable();
            Param["코드그룹"] = "데이터타입";
            검색조건모델.테이블명.DataSource = 서비스.조회수행("테이블스키마", Param);
            검색조건모델.테이블명.DisplayMember = "TABLE_NAME";
            검색조건모델.테이블명.ValueMember = "TABLE_NAME";


            Param = new Hashtable();
            Param["코드그룹"] = "데이터타입";

            검색조건모델.데이터종류.DataSource = 서비스.조회수행("공통코드", Param);
            검색조건모델.데이터종류.DisplayMember = "명칭";
            검색조건모델.데이터종류.ValueMember = "코드";
        }

        public void 저장()
        {
            그리드모델.그리드.CurrentCell = null;
            DataTable 반영표 = 그리드모델.그리드.DataSource as DataTable;
            그리드모델.그리드.반영(반영표, 서비스);
            조회();
        }

        public void 조회()
        {
            Hashtable Param = new Hashtable();
            Param["테이블명"] = string.IsNullOrEmpty(검색조건모델.데이터종류.SelectedValue as string) ? string.Empty : 검색조건모델.테이블명.SelectedValue as string; 
            Param["컬럼명"] = string.IsNullOrEmpty(검색조건모델.데이터종류.SelectedValue as string) ? string.Empty : 검색조건모델.컬럼명.SelectedValue as string; 
            Param["데이터타입값"] = string.IsNullOrEmpty(검색조건모델.데이터종류.SelectedValue as string) ? string.Empty : 검색조건모델.데이터종류.SelectedValue as string;
            //Param["데이터타입코드"] = 검색조건모델.데이터타입_시퀀스.Checked ? true: false;

            this.그리드모델.그리드.바인딩(서비스.조회수행("가상데이터리스트", Param));
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

        private void 그리드초기화()
        {
            DexGridColumn[] 컬럼들 = new DexGridColumn[5];
            컬럼들[0] = new DexGridColumn();
            컬럼들[0].컬럼명 = "데이터포멧1";
            컬럼들[0].헤더명 = "데이터포멧1";
            컬럼들[0].너비 = 100;

            컬럼들[1] = new DexGridColumn();
            컬럼들[1].컬럼명 = "데이터포멧2";
            컬럼들[1].헤더명 = "데이터포멧2";
            컬럼들[1].너비 = 100;

            컬럼들[2] = new DexGridColumn();
            컬럼들[2].컬럼명 = "데이터포멧3";
            컬럼들[2].헤더명 = "데이터포멧3";
            컬럼들[2].너비 = 100;



            컬럼들[3] = new DexGridColumn();
            컬럼들[3].컬럼명 = "데이터타입코드";
            컬럼들[3].헤더명 = "데이터타입코드";
            컬럼들[3].너비 = 120;

            컬럼들[4] = new DexGridColumn();
            컬럼들[4].컬럼명 = "데이터타입값";
            컬럼들[4].헤더명 = "데이터타입값";
            컬럼들[4].너비 = 100;

            그리드모델.그리드.열생성(컬럼들);
        }


    }
}
