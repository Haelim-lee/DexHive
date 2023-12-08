using System.Windows.Forms;

namespace DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.실적리포트
{
    public class 완제품생산이력검색_모델
    {
        public DateTimePicker 날짜검색_시작 { get; internal set; }
        public DateTimePicker 날짜검색_종료 { get; internal set; }
        public ComboBox 제품군 { get; internal set; }
        public ComboBox 제품 { get; internal set; }
        public ComboBox 생산계획오더 { get; internal set; }
    }
}