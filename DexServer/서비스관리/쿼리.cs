using DexServer.쿼리저장소.계약관리그룹;
using DexServer.회원관리서비스;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DexServer
{
    public class 쿼리
    {
        public 사용자관리 사용자관리 { get; set; }
        public 도구관리 도구관리 { get; set; }
        public 시스템관리 시스템관리 { get; set; }
        public 직원관리 직원관리 { get; set; }
        public 계약관리 계약관리 { get; set; }
        public 업무관리 업무관리 { get; set; }

        public 쿼리()
        {
            사용자관리 = new 사용자관리();
            도구관리 = new 도구관리();
            시스템관리 = new 시스템관리();
            직원관리 = new 직원관리();
            계약관리 = new 계약관리();
            업무관리 = new 업무관리();
        }
        public string 조회(string 아이디)
        {
            switch (아이디)
            {
                case "사용자조회": return 사용자관리.사용자조회();
                case "기준정보조회": return 시스템관리.기준정보조회();
                case "코드그룹조회": return 시스템관리.코드그룹조회();
                case "도구조회": return 도구관리.도구조회();
                case "직원조회": return 직원관리.직원조회();
                case "가상데이터리스트": return 시스템관리.가상데이터();
                case "공통코드": return 시스템관리.공통코드조회();
                case "계약관리조회": return 계약관리.계약관리조회();
                case "테이블스키마": return 시스템관리.테이블정보();
                case "컬럼스키마": return 시스템관리.컬럼정보();
                case "자재공급사조회":return 업무관리.자재공급사조회();
                case "자재조회": return 업무관리.자재조회();
                case "자재등록": return 업무관리.자재등록();
                case "제품등록": return 업무관리.제품등록();
                case "제품수정2": return 업무관리.제품수정2();
                case "제품수정3": return 업무관리.제품수정3();
                case "월생산계획": return 업무관리.월생산계획();
                case "월생산계획추가": return 업무관리.월생산계획추가();
                case "생산계획오더조회": return 업무관리.생산계획오더조회();
                case "생산계획오더추가": return 업무관리.생산계획오더추가();
                case "작업지시조회": return 업무관리.작업지시조회();
                case "작업지시추가": return 업무관리.작업지시추가();
                case "제품생산이력조회": return 업무관리.제품생산이력조회(); 
                case "생산LOT추적":return 업무관리.생산LOT추적();
                case "LOT이력정보조회": return 업무관리.LOT이력정보조회();
                case "자재입고등록1": return 업무관리.자재입고등록1();
                case "고객사조회":return 업무관리.고객사조회();
                case "주제공정시작": return 업무관리.주제공정시작();
                case "자재이동": return 업무관리.자재이동();
                case "생산LOT등록": return 업무관리.생산LOT등록();
                case "자재이동취소":return 업무관리.자재이동취소();
                case "LOT추가팝업창": return 업무관리.LOT추가팝업창();
                case "자재폐기조회":return 업무관리.자재폐기조회();
                



                default: return "쿼리가 없습니다.";
            }
        }
    }
}
