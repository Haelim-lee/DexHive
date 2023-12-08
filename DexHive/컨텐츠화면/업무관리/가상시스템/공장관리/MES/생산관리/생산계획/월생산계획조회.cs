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
    public partial class 월생산계획조회 :스크린 ,I스크린
    {
        public 조회조건모델 조회조건모델 { get;  set; }

        public 월생산계획조회()
        {
            InitializeComponent();
            InitializeProperty();
            InitializeEvent();
            this.기본기능.저장버튼.Visible = false;
        }

        private void InitializeProperty()
        {
            조회조건모델 = new 조회조건모델();
            조회조건모델.제품콤보 = this.comboBox2;
            조회조건모델.시작날짜 = this.dateTimePickerYearMonth1;
            조회조건모델.종료날짜 = this.dateTimePickerYearMonth2;
        }

        private void InitializeEvent()
        {
            this.Shown += 월생산계획조회_Shown;
            this.기본기능.조회버튼.Click +=(object sender, EventArgs e) => 조회();
            조회조건모델.종료날짜.CausesValidation = true;
            조회조건모델.종료날짜.DropDown += 종료날짜_DropDown;
            조회조건모델.시작날짜.DropDown += 시작날짜_DropDown;
        }

        private void 종료날짜_DropDown(object sender, EventArgs e)
        {
            조회조건모델.시작날짜.Tag = 조회조건모델.시작날짜.Value;
        }

        private void 시작날짜_DropDown(object sender, EventArgs e)
        {
            조회조건모델.시작날짜.Tag = 조회조건모델.시작날짜.Value;
        }





        private void 월생산계획조회_Shown(object sender, EventArgs e)
        {
            this.기본기능.저장버튼.Visible = false;
            this.기본기능.행추가버튼.Visible = false;
            this.기본기능.행제거버튼.Visible = false;
            InitializeCombobox();
            InitializeGrid();
            조회();
            
        }

        private void InitializeCombobox()
        {
            Hashtable 조건 = new Hashtable();
            조건["코드그룹"] = "제품";
            this.조회조건모델.제품콤보.DataSource = 서비스.조회수행("공통코드", 조건);
            this.조회조건모델.제품콤보.DisplayMember = "명칭";
            this.조회조건모델.제품콤보.ValueMember = "코드";
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

        public void 조회()
        {
            //Hashtable Param = new Hashtable();
            //Param["PLANID"] = this.dateTimePicker1.Value.ToShortDateString();
            //Param["PRODUCTDEFINITIONID"] = this.comboBox2.SelectedValue.ToString();
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
                                  ,TRY_CONVERT(INT,A.[WEEKQTY1]) + TRY_CONVERT(INT,A.[WEEKQTY2]) + TRY_CONVERT(INT,A.[WEEKQTY3]) + TRY_CONVERT(INT,A.[WEEKQTY4]) + TRY_CONVERT(INT,A.[WEEKQTY5]) as QTY
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
                              AND CONVERT(CHAR(10), PLANID +'-01', 23) BETWEEN '{0}' AND '{1}'
                    -----------------------------------------";
                                  // ^ YYYY-MM + 01(DD) 시작일 ~ 종료일
            string Time1 = this.dateTimePickerYearMonth1.Value.ToShortDateString().Substring(0, 8) + "01";
            string Time2 = this.dateTimePickerYearMonth2.Value.ToShortDateString().Substring(0, 8) + dateTimePickerYearMonth2.Value.Day.ToString().PadLeft(2, '0');
            쿼리=string.Format(쿼리, Time1, Time2);
            this.dexGridView1.바인딩(서비스.GetDataTable(쿼리));

            if (DateTime.Compare(조회조건모델.시작날짜.Value, 조회조건모델.종료날짜.Value) > 0)
            {
                MessageBox.Show("날짜를 재설정하세요.");
                조회조건모델.시작날짜.Value = (DateTime)조회조건모델.시작날짜.Tag;
                조회조건모델.시작날짜.Value = 조회조건모델.종료날짜.Value;
                // ^ if ( 시작월 > 종료월 ), 시작 월을 금월로 세팅하는코드
            }

            if (DateTime.Compare(조회조건모델.시작날짜.Value.AddMonths(6), 조회조건모델.종료날짜.Value) < 0)
            {   MessageBox.Show("검색기간은 6개월 이내로 선택하여 주십시오.");
                조회조건모델.시작날짜.Value = (DateTime)조회조건모델.시작날짜.Tag;
                조회조건모델.시작날짜.Value = 조회조건모델.종료날짜.Value;
                // ^ if (종료월 >= 시작월+6 ), 시작월을 금월로 세팅하는 코드
                //else if ((Convert.ToInt32(dateTimePickerYearMonth2.Value)) - Convert.ToInt32(dateTimePickerYearMonth1.Value) > 6 )
                //조회조건모델.시작날짜.Value.ToString > 조회조건모델.종료날짜.Value + 6 )
                //DateTime.Compare(조회조건모델.종료날짜.Value, 조회조건모델.시작날짜.Value) > 6)
            }

  
        }

        public void 저장()
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

        public void 초기화()
        {
            throw new NotImplementedException();
        }

    
    }
}
