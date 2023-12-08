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

namespace DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.생산계획
{
    public partial class 월생산계획추가 : 스크린, I스크린
    {
        입력조건모델 주별생산수량 = new 입력조건모델();
        public 월생산계획추가()
        {
            InitializeComponent();
            InitializeProperty();
            InitializeEvent();
            this.기본기능.조회버튼.Visible = false;
            this.기본기능.행제거버튼.Visible = false;
            this.기본기능.행추가버튼.Visible = false;
        }

        private void InitializeProperty()
        {
            주별생산수량.주차별계획수량 = new TextBox[5];
            주별생산수량.주차별계획수량[0] = textBox1;
            주별생산수량.주차별계획수량[1] = textBox2;
            주별생산수량.주차별계획수량[2] = textBox3;
            주별생산수량.주차별계획수량[3] = textBox4;
            주별생산수량.주차별계획수량[4] = textBox5;
        }

        private void InitializeEvent()
        {
            this.Shown += 월생산계획추가_Shown;
            this.기본기능.저장버튼.Click += (object sender, EventArgs e) => 저장();
            foreach (TextBox 텍스트박스 in 주별생산수량.주차별계획수량) 텍스트박스.TextChanged += 텍스트박스_TextChanged;
            foreach (TextBox 텍스트박스 in 주별생산수량.주차별계획수량) 텍스트박스.Enter += 텍스트박스_Enter;

        }

        private void 텍스트박스_Enter(object sender, EventArgs e)
        {
            TextBox 선택된박스 = sender as TextBox;
            선택된박스.Text = "";
        }

        private void 텍스트박스_TextChanged(object sender, EventArgs e)
        {
            int 결과값 = 0;
            foreach (TextBox 텍스트박스 in 주별생산수량.주차별계획수량)
            //textBox1~5 각각 이벤트 거는 대신 textBox1~5 그룹화 후 foreach 써서 모든 값 더하는 코드.
            {
                int 변환값 = 0;
                if (int.TryParse(텍스트박스.Text, out 변환값))     
                    //TryParse : 정수인 값만 sum up. 
                {
                    결과값 += 변환값;
                }
            }
         
            this.textBox6.Text = 결과값.ToString();
        }

        private void 월생산계획추가_Shown(object sender, EventArgs e)
        {
            InitializeCombobox();
            InitializeGrid();
            InitializeTextbox();
            조회();

        }

        private void InitializeTextbox()
        {
            this.textBox1.Text = "1주차";
            this.textBox2.Text = "2주차";
            this.textBox3.Text = "3주차";
            this.textBox4.Text = "4주차";
            this.textBox5.Text = "5주차";
            this.textBox6.Text = "월계";

        }

        private void InitializeGrid()
        {
            DexGridColumn[] 컬럼들 = new DexGridColumn[10];
            컬럼들[0] = new DexGridColumn();
            컬럼들[0].컬럼명 = "PLANID";
            컬럼들[0].헤더명 = "계획월";
            컬럼들[0].너비 = 100;

            컬럼들[1] = new DexGridColumn();
            컬럼들[1].컬럼명 = "PRODUCTDEFINITIONID";
            컬럼들[1].헤더명 = "제품코드";
            컬럼들[1].너비 = 100;

            컬럼들[2] = new DexGridColumn();
            컬럼들[2].컬럼명 = "PRODUCTDEFINITIONNAME";
            컬럼들[2].헤더명 = "제품명";
            컬럼들[2].너비 = 100;

            컬럼들[3] = new DexGridColumn();
            컬럼들[3].컬럼명 = "UNITID";
            컬럼들[3].헤더명 = "단위";
            컬럼들[3].너비 = 80;

            컬럼들[4] = new DexGridColumn();
            컬럼들[4].컬럼명 = "WEEKQTY1";
            컬럼들[4].헤더명 = "1주";
            컬럼들[4].너비 = 80;

            컬럼들[5] = new DexGridColumn();
            컬럼들[5].컬럼명 = "WEEKQTY2";
            컬럼들[5].헤더명 = "2주";
            컬럼들[5].너비 = 80;

            컬럼들[6] = new DexGridColumn();
            컬럼들[6].컬럼명 = "WEEKQTY3";
            컬럼들[6].헤더명 = "3주";
            컬럼들[6].너비 = 80;

            컬럼들[7] = new DexGridColumn();
            컬럼들[7].컬럼명 = "WEEKQTY4";
            컬럼들[7].헤더명 = "4주";
            컬럼들[7].너비 = 80;

            컬럼들[8] = new DexGridColumn();
            컬럼들[8].컬럼명 = "WEEKQTY5";
            컬럼들[8].헤더명 = "5주";
            컬럼들[8].너비 = 80;

            컬럼들[9] = new DexGridColumn();
            컬럼들[9].컬럼명 = "QTY";
            컬럼들[9].헤더명 = "월계";
            컬럼들[9].너비 = 80;

            this.dexGridView1.열생성(컬럼들);
        }

        private void InitializeCombobox()
        {
            Hashtable 조건 = new Hashtable();
            조건["코드그룹"] = "제품";
            this.comboBox1.DataSource = 서비스.조회수행("공통코드", 조건);
            this.comboBox1.DisplayMember = "명칭";
            this.comboBox1.ValueMember = "코드";

            조건 = new Hashtable();
            조건["코드그룹"] = "단위";
            this.comboBox2.DataSource = 서비스.조회수행("공통코드", 조건);
            this.comboBox2.DisplayMember = "명칭";
            this.comboBox2.ValueMember = "코드";

        }

        public void 저장()
        {
            int chkint = 0;
            foreach (TextBox 텍스트박스 in 주별생산수량.주차별계획수량)
                if (string.IsNullOrEmpty(텍스트박스.Text) || int.TryParse(텍스트박스.Text, out chkint) == false)
                {
                    MessageBox.Show("1~5주차 모두 입력하세요.");
                    return;
                }
            Hashtable Param = new Hashtable();
            Param["PLANID"] = this.dateTimePickerYearMonth1.Value.ToShortDateString().Substring(0, 7);
            Param["PRODUCTDEFINITIONID"] = this.comboBox1.SelectedValue.ToString();
            Param["SITEID"] = "A400";
            Param["WEEKQTY1"] = this.textBox1.Text;
            Param["WEEKQTY2"] = this.textBox2.Text;
            Param["WEEKQTY3"] = this.textBox3.Text;
            Param["WEEKQTY4"] = this.textBox4.Text;
            Param["WEEKQTY5"] = this.textBox5.Text;
            Param["UNITID"] = this.comboBox2.SelectedValue.ToString();
            Param["MODIFYTIME"] = DateTime.Now;

            Hashtable Result = 서비스.명령수행("월생산계획추가", Param);
            if (Result["IsSuccess"].Equals(false))
                MessageBox.Show(Result["ErrorMsg"].ToString());
            조회();



        }

        public void 조회()
        {
            string 쿼리 = @"------------------------------------------------
                           SELECT  A.[PLANID]
                                  ,A.[PRODUCTDEFINITIONID]
	                              ,B.[PRODUCTDEFINITIONNAME]
                                  ,A.[SITEID]
                                  ,A.[PRODUCTTYPE]
                                  ,A.[WEEKQTY1]
                                  ,A.[WEEKQTY2]
                                  ,A.[WEEKQTY3]
                                  ,A.[WEEKQTY4]
                                  ,A.[WEEKQTY5]
                                  ,TRY_CONVERT(int,A.WEEKQTY1)+TRY_CONVERT(int,A.WEEKQTY2)+TRY_CONVERT(int,A.WEEKQTY3)+TRY_CONVERT(int,A.WEEKQTY4)+TRY_CONVERT(int,A.WEEKQTY5) AS QTY
                                  ,A.[UNITID]
                                  ,A.[ACTIVITY]
                                  ,A.[PREACTIVITY]
                                  ,A.[CUSTOMACTIVITY]
                                  ,A.[PREVCUSTOMACTIVITY]
                                  ,A.[ISUSABLE]
                                  ,A.[DESCRIPTION]
                                  ,A.[REASONCODE]
                                  ,A.[COMMENTS]
                                  ,A.[CREATOR]
                                  ,A.[CREATETIME]
                                  ,A.[MODIFIER]
                                  ,A.[MODIFYTIME]
                                  ,A.[LASTEVENTIME]
                                  ,A.[TID]
                              FROM [CST_MONTHLYPLAN] A
                              LEFT JOIN CIM_PRODUCTDEFINITION B
                              ON A.PRODUCTDEFINITIONID = B.PRODUCTDEFINITIONID
                            WHERE 1=1
                    -----------------------------------------";
            // ^ YYYY-MM + 01(DD) 시작일 ~ 종료일
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
