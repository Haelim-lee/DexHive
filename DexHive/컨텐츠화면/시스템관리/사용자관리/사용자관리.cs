﻿using System;
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

namespace DexHive.컨텐츠화면.시스템관리.사용자관리그룹
{
    public partial class 사용자관리 : 스크린, I스크린
    {
        public 사용자관리표_모델 그리드모델 {get;set;}

        public 사용자관리()
        {
            InitializeComponent();
            InitializeProperty();
            InitializeEvent();
        }

        private void InitializeProperty()
        {
            그리드모델 = new 사용자관리표_모델();
            그리드모델.그리드 = 사용자관리표;
            그리드모델.그리드.기본테이블명 = "사용자정보";
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
            Param["연락처"] = this.textBox2.Text;
            Param["이메일"] = this.textBox3.Text;
            Param["생년월일"] = this.textBox4.Text;
            Param["이름"] = this.textBox5.Text;

            DexGridColumn[] 컬럼들 = new DexGridColumn[6];
            컬럼들[0] = new DexGridColumn();
            컬럼들[0].컬럼명 = "아이디";
            컬럼들[0].헤더명 = "아이디";
            컬럼들[0].너비 = 100;

            컬럼들[1] = new DexGridColumn();
            컬럼들[1].컬럼명 = "비밀번호";
            컬럼들[1].헤더명 = "비밀번호";
            컬럼들[1].너비 = 80;

            컬럼들[2] = new DexGridColumn();
            컬럼들[2].컬럼명 = "이름";
            컬럼들[2].헤더명 = "이름";
            컬럼들[2].너비 = 100;



            컬럼들[3] = new DexGridColumn();
            컬럼들[3].컬럼명 = "생년월일";
            컬럼들[3].헤더명 = "생년월일";
            컬럼들[3].너비 = 80;

            컬럼들[4] = new DexGridColumn();
            컬럼들[4].컬럼명 = "이메일";
            컬럼들[4].헤더명 = "이메일";
            컬럼들[4].너비 = 80;

            컬럼들[5] = new DexGridColumn();
            컬럼들[5].컬럼명 = "연락처";
            컬럼들[5].헤더명 = "연락처";
            컬럼들[5].너비 = 80;

            그리드모델.그리드.열생성(컬럼들);

            this.그리드모델.그리드.바인딩(서비스.조회수행("사용자조회", Param));


            //    Dictionary<string, Hashtable> 입력매개변수 = new Dictionary<string, Hashtable>();
            //    Hashtable 입력변수1 = new Hashtable();
            //    입력변수1["값"] = "용수현";
            //    입력변수1["자료형"] = SqlDbType.NVarChar;
            //    입력변수1["방향"] = ParameterDirection.Input;
            //    Hashtable 입력변수2 = new Hashtable();
            //    입력변수2["값"] = 1;
            //    입력변수2["자료형"] = SqlDbType.Int;
            //    입력변수2["방향"] = ParameterDirection.Input;


            //    입력매개변수.Add("@사용자명", 입력변수1);
            //    입력매개변수.Add("@등급", 입력변수2);

            //    Dictionary<string, Hashtable> 출력매개변수 = new Dictionary<string, Hashtable>();

            //    Hashtable 출력변수1 = new Hashtable();
            //    출력변수1["값"] = "용수현";
            //    출력변수1["자료형"] = SqlDbType.NVarChar;
            //    출력변수1["방향"] = ParameterDirection.Output;
            //    출력매개변수.Add("@검색결과", 출력변수1);
            //    this.서비스.프로시저호출("사용자관리", 입력매개변수, 출력매개변수);
            //
        }
        public void 행추가()
        {
            if (사용자관리표.DataSource == null) 조회();
            {
                ((DataTable)사용자관리표.DataSource).Rows.Add();
            }
        }

        public void 행제거()
        {
            if (사용자관리표.CurrentRow != null)
                if ((DataRowView)사용자관리표.CurrentRow.DataBoundItem != null)
                {
                    bool a = 사용자관리표.CurrentRow.IsNewRow;
                    DataRow DR = ((DataRowView)사용자관리표.CurrentRow.DataBoundItem).Row;
                    사용자관리표.Rows.Remove(사용자관리표.CurrentRow);
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
            this.사용자관리표.DataSource = 결과;
        }

 
    }
}
