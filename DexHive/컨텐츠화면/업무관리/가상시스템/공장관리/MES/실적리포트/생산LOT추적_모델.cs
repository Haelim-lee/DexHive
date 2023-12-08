using DexCommonUtil.UI도구.사용자정의컨트롤;
using System;

namespace DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.실적리포트
{
    public class 생산LOT추적_모델
    {

        public DexGridView 완제품LOT이력그리드 { get; set; }
        public DexGridView 메인그리드 { get; set; }
        public DexGridView 반제품자재소진정보그리드 { get; set; }
        public DexGridView 공정별불량정보그리드 { get; set; }
        public DexGridView 완제품품질검사정보그리드 { get; set; }
        public DexGridView 반제품LOT이력그리드 { get; set; }
        public DexGridView 원자재소진정보그리드 { get; set; }
        public DexGridView 반제품음성검사정보그리드 { get; set; }
        public DexGridView 반응성검사이력그리드 { get; set; }
        public DexGridView WORKINGTANK물성검사이력그리드 { get; set; }
        public DexGridView 원자재LOT이력그리드 { get; set; }

       
    }
}