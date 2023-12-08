using DexCommonUtil.UI도구;
using DexHive;
using DexHive.컨텐츠화면.시스템관리.기준정보관리그룹;
using DexHive.컨텐츠화면.시스템관리.메뉴관리;
using DexHive.컨텐츠화면.시스템관리.사용자관리그룹;
using DexHive.컨텐츠화면.직원관리.직원등록그룹;
using DexHive.컨텐츠화면.직원관리;
using DexServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DexHive.컨텐츠화면.업무관리.작업도구.가상데이터생성그룹;
using DexHive.컨텐츠화면.업무관리.계약관리그룹;
using DexHive.컨텐츠화면.자금관리.계좌관리;
using DexHive.컨텐츠화면.업무관리.일정관리;
using DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES;
using DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.자재관리;
using DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.생산계획;
using DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.실적리포트;
using DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.작업지시;
using DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.공정관리_반제품_;
using DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.품질관리.반제품_품질검사;

namespace DexHive
{
    public partial class 앤츠네스트 : Form
    {
    #region [상태 & 속성]
        public Dictionary<string,TabPage> 화면관리자 { get; set; }
        public I스크린 현재화면 { get; set; }
        public I서버인터페이스 서비스 { get; set; }
        public 상단메뉴모델 상단메뉴 { get; set; }
        public 하단메뉴모델 하단메뉴 { get; set; }
    #endregion [/상태 & 속성]

    #region [객체생성]

        public 앤츠네스트()
        {
            InitializeComponent();
            InitializeProperty();
            InitializeEvent();
        }

        private void InitializeProperty()
        {
            상단메뉴 = new 상단메뉴모델();
            상단메뉴.직원관리 = this.직원관리버튼;
            상단메뉴.업무관리 = this.업무관리버튼;
            상단메뉴.자금관리 = this.자금관리버튼;
            상단메뉴.시스템관리 = this.시스템관리버튼;

            하단메뉴 = new 하단메뉴모델();
            하단메뉴.서브메뉴 = this.서브메뉴;
            하단메뉴.컨텐츠뷰어 = this.컨텐츠뷰어;

            화면관리자 = new Dictionary<string, TabPage>();
        }

        private void InitializeEvent()
        {
            KeyDown += (object sender, KeyEventArgs e) =>{ if (e.KeyCode == Keys.Enter && 컨텐츠뷰어.TabPages.Count != 0) 현재화면.조회(); };
            상단메뉴.직원관리.Click += 직원관리_Click;
            상단메뉴.시스템관리.Click += 시스템관리_Click;
            상단메뉴.업무관리.Click += 업무관리_Click;
            상단메뉴.자금관리.Click += 자금관리_Click;
            하단메뉴.서브메뉴.NodeMouseClick += 서브메뉴_NodeMouseClick;

        }


        #endregion [객체생성]

        #region [이벤트]
        private void 서브메뉴_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch (e.Node.Text)
            {
                case "직원등록" : 화면생성(e.Node.Text, new 직원등록()); break;//화면생성
                case "사용자관리" : 화면생성(e.Node.Text, new 사용자관리()); break;//화면생성
                case "기준정보관리": 화면생성(e.Node.Text, new 기준정보()); break;//화면생성
                case "가상데이터생성": 화면생성(e.Node.Text, new 가상데이터생성()); break;//화면생성
                case "계약관리": 화면생성(e.Node.Text, new 계약관리()); break;//화면생성
                case "계좌관리": 화면생성(e.Node.Text, new 계좌관리화면()); break;//화면생성
                case "일정관리": 화면생성(e.Node.Text, new 일정관리화면()); break;//화면생성
                case "자재입고조회": 화면생성(e.Node.Text, new 자재입고조회()); break;
                case "자재등록": 화면생성(e.Node.Text, new 자재등록());break;
                case "제품등록": 화면생성(e.Node.Text, new 제품등록()); break;
                case "월생산계획조회": 화면생성(e.Node.Text, new 월생산계획조회()); break;//화면생성
                case "월생산계획추가": 화면생성(e.Node.Text, new 월생산계획추가()); break;//화면생성
                case "작업지시조회": 화면생성(e.Node.Text, new 작업지시조회()); break;//화면생성
                case "작업지시생성": 화면생성(e.Node.Text, new 작업지시생성()); break;//화면생성
                case "반제품생산이력조회": 화면생성(e.Node.Text, new 반제품생산이력조회()); break;
                case "완제품생산이력조회":화면생성(e.Node.Text, new 완제품생산이력조회());break;
                case "생산LOT추적공통": 화면생성(e.Node.Text, new 생산LOT추적공통());break;
                case "자재입고등록": 화면생성(e.Node.Text, new 자재입고등록()); break;
                case "자재이동":화면생성(e.Node.Text, new 자재이동()); break;
                case "자재이동취소": 화면생성(e.Node.Text, new 자재이동취소()); break;
                case "주제공정시작":화면생성(e.Node.Text, new 주제공정시작()); break;
                case "자재폐기":화면생성(e.Node.Text, new 자재폐기()); break;
                case "반제품_품질검사": 화면생성(e.Node.Text, new 반제품_품질검사()); break;
                default: break;
            }
        }


        private void 자금관리_Click(object sender, EventArgs e)
        {
            하단메뉴.서브메뉴.Nodes.Clear();
            하단메뉴.서브메뉴.Nodes.Add("계좌관리");
            하단메뉴.서브메뉴.Nodes.Add("급여관리");
            하단메뉴.서브메뉴.Nodes.Add("세무회계관리");
            하단메뉴.서브메뉴.Nodes.Add("지출관리");
        }

        private void 업무관리_Click(object sender, EventArgs e)
        {
            하단메뉴.서브메뉴.Nodes.Clear();
            TreeNode 가상시스템 = 하단메뉴.서브메뉴.Nodes.Add("가상시스템");
            TreeNode 공장관리 = 가상시스템.Nodes.Add("공장관리");
            TreeNode MES = 공장관리.Nodes.Add("MES");

            TreeNode 생산계획 = MES.Nodes.Add("생산계획");
            생산계획.Nodes.Add("월생산계획조회");
            생산계획.Nodes.Add("월생산계획추가");

            TreeNode 작업지시 = MES.Nodes.Add("작업지시");
            작업지시.Nodes.Add("작업지시생성");
            작업지시.Nodes.Add("작업지시조회");

            TreeNode 자재관리 = MES.Nodes.Add("자재관리");
            자재관리.Nodes.Add("자재입고조회");
            자재관리.Nodes.Add("자재등록");
            자재관리.Nodes.Add("제품등록");
            자재관리.Nodes.Add("자재입고등록");
            자재관리.Nodes.Add("자재이동");
            자재관리.Nodes.Add("자재이동취소");
            자재관리.Nodes.Add("자재폐기");
            TreeNode 공정관리_반제품 = MES.Nodes.Add("공정관리(반제품)");
            공정관리_반제품.Nodes.Add("공정관리(반제품)");
            공정관리_반제품.Nodes.Add("주제공정시작");
            TreeNode 공정관리_완제품 = MES.Nodes.Add("공정관리(완제품)");
            공정관리_완제품.Nodes.Add("공정관리(완제품)");
            TreeNode 품질관리 = MES.Nodes.Add("품질관리");
            품질관리.Nodes.Add("반제품_품질검사");

            //품질관리.Nodes.Add("품질관리");
            TreeNode 금형관리 = MES.Nodes.Add("금형관리");
            //금형관리.Nodes.Add("금형관리");
            TreeNode 실적리포트 = MES.Nodes.Add("실적리포트");
            실적리포트.Nodes.Add("반제품생산이력조회");
            실적리포트.Nodes.Add("완제품생산이력조회");
            실적리포트.Nodes.Add("생산LOT추적공통");
            실적리포트.Nodes.Add("보정");
        }
        private void 직원관리_Click(object sender, EventArgs e)
        {
            하단메뉴.서브메뉴.Nodes.Clear();
            하단메뉴.서브메뉴.Nodes.Add("교육관리");
            하단메뉴.서브메뉴.Nodes.Add("직원등록");
            하단메뉴.서브메뉴.Nodes.Add("직원정보");
            하단메뉴.서브메뉴.Nodes.Add("조직관리");
            하단메뉴.서브메뉴.Nodes.Add("기타인력관리");
            하단메뉴.서브메뉴.Nodes.Add("협력사");
        }

        private void 시스템관리_Click(object sender, EventArgs e)
        {
            하단메뉴.서브메뉴.Nodes.Clear();
            하단메뉴.서브메뉴.Nodes.Add("사용자관리");
            하단메뉴.서브메뉴.Nodes.Add("메뉴관리");
            하단메뉴.서브메뉴.Nodes.Add("테이블관리");
            하단메뉴.서브메뉴.Nodes.Add("기준정보관리");
            하단메뉴.서브메뉴.Nodes.Add("권한그룹관리");
        }
        #endregion [/이벤트]

        #region [메소드]


        private void 화면생성(string 아이디, 스크린 신규화면)
        {
            if (!화면관리자.ContainsKey(아이디))
            {
                스크린 화면 = 신규화면;
                화면.Dock = DockStyle.Fill;
                TabPage 신규탭 = new TabPage(아이디); //신규탭
                신규탭.Controls.Add(화면);
                신규탭.Name = 아이디;
                화면관리자.Add(아이디, 신규탭);
                하단메뉴.컨텐츠뷰어.TabPages.Add(화면관리자[아이디]);

            }
            if (!하단메뉴.컨텐츠뷰어.TabPages.ContainsKey(아이디))
                하단메뉴.컨텐츠뷰어.TabPages.Add(화면관리자[아이디]);

            컨텐츠뷰어.SelectedTab = 화면관리자[아이디];
            신규화면.서비스 = this.서비스;
            신규화면.컨텐츠뷰어 = this.컨텐츠뷰어;
            현재화면 = (I스크린)신규화면;
        }
        /*
        private void MES화면생성(string 아이디, Form 신규화면)
        {
            if (!화면관리자.ContainsKey(아이디))
            {
                Form 화면 = 신규화면;
                TabPage 신규탭 = new TabPage(아이디); //신규탭
                신규탭.Controls.Add(화면);
                신규탭.Name = 아이디;
                화면관리자.Add(아이디, 신규탭);
                하단메뉴.컨텐츠뷰어.TabPages.Add(화면관리자[아이디]);
            }
            if (!하단메뉴.컨텐츠뷰어.TabPages.ContainsKey(아이디))
            {
                하단메뉴.컨텐츠뷰어.TabPages.Add(화면관리자[아이디]);
            }
            컨텐츠뷰어.SelectedTab = 화면관리자[아이디];
            신규화면.서비스 = this.서비스;
            신규화면.컨텐츠뷰어 = this.컨텐츠뷰어;
            현재화면 = (I스크린)신규화면;
        }
        */

        #endregion [메소드]

    }
}
