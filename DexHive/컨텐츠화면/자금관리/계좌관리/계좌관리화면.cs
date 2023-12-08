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

namespace DexHive.컨텐츠화면.자금관리.계좌관리
{
    public partial class 계좌관리화면 : 스크린,I스크린
    {
        public 검색조건_모델 검색조건 { get; set; }
        public 계좌관리표_모델 계좌관리표 { get; set; }

        public 계좌관리화면()
        {
            InitializeComponent();
            InitializeProperty();
            InitializeEvent();

        }

        private void InitializeEvent()
        {
            this.Shown += InitializeScreen;
            this.검색조건.은행명.SelectedIndexChanged += 은행명_SelectedIndexChanged;
        }

        private void 은행명_SelectedIndexChanged(object sender, EventArgs e)
        {
            //InitializeComboBox

            Hashtable 조건 = new Hashtable();
            if (1 == this.검색조건.은행명.SelectedIndex)
                조건["코드그룹"] = "KB상품그룹";
            else if (2 == this.검색조건.은행명.SelectedIndex)
                조건["코드그룹"] = "SC상품그룹";
            else
                return;
                
            this.검색조건.금융상품.DataSource = 서비스.조회수행("공통코드", 조건);
            this.검색조건.금융상품.DisplayMember = "키";
            this.검색조건.금융상품.ValueMember = "값";
        }

        private void InitializeScreen(object sender, EventArgs e)
        {
            //InitializeGrid
            DexGridColumn[] 컬럼들 = new DexGridColumn[4];
            컬럼들[0] = new DexGridColumn();
            컬럼들[0].컬럼명 = "예금주";
            컬럼들[0].헤더명 = "예금주";
            컬럼들[0].너비 = 100;

            컬럼들[1] = new DexGridColumn();
            컬럼들[1].컬럼명 = "은행명";
            컬럼들[1].헤더명 = "은행명";
            컬럼들[1].너비 = 100;

            컬럼들[2] = new DexGridColumn();
            컬럼들[2].컬럼명 = "계좌번호";
            컬럼들[2].헤더명 = "계좌번호";
            컬럼들[2].너비 = 100;

            컬럼들[3] = new DexGridColumn();
            컬럼들[3].컬럼명 = "금융상품";
            컬럼들[3].헤더명 = "금융상품";
            컬럼들[3].너비 = 100;

            this.계좌관리표.그리드.열생성(컬럼들);

            //InitializeComboBox
            Hashtable 조건 = new Hashtable();
            조건["코드그룹"] = "은행명그룹";
            this.검색조건.은행명.DataSource = 서비스.조회수행("공통코드", 조건);
            this.검색조건.은행명.DisplayMember = "명칭";
            this.검색조건.은행명.ValueMember = "코드";


        }

        private void InitializeProperty()
        {
            this.검색조건 = new 검색조건_모델();
            this.검색조건.예금주 = this.textBox1;
            this.검색조건.은행명 = this.comboBox1;
            this.검색조건.계좌번호 = this.textBox2;
            this.검색조건.금융상품 = this.comboBox2;

            this.계좌관리표 = new 계좌관리표_모델();
            this.계좌관리표.그리드 = this.dexGridView1;
            this.계좌관리표.그리드.기본테이블명 = "계좌관리표";

        }

        public void 저장()
        {
            throw new NotImplementedException();
        }

        public void 조회()
        {
            throw new NotImplementedException();
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
