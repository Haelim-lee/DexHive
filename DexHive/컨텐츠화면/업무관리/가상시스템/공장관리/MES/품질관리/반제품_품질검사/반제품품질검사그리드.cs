using DexCommonUtil.UI도구.사용자정의컨트롤;

namespace DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.품질관리.반제품_품질검사
{
    public class 반제품품질검사그리드
    {
        public 반제품품질검사그리드()
        {
        }

        public DexGridView 메인그리드 { get; internal set; }
        public DexGridView 물성검사입력그리드 { get; internal set; }
        public DexGridView 물성검사이력그리드 { get; internal set; }
    }
}