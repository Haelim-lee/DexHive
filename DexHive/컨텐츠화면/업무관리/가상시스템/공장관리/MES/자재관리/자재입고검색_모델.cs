using System.Windows.Forms;

namespace DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.자재관리
{
    public class 자재입고검색_모델
    {
        public ComboBox 자재코드 { get; internal set; }
        public ComboBox 공급사 { get; internal set; }
        public ComboBox 자재명 { get; internal set; }
        public ComboBox 자재위치 { get; internal set; }
        public DateTimePicker 자재날짜 { get; internal set; }
        public ComboBox 단위 { get; internal set; }
        public TextBox 입고수량 { get; internal set; }
    }
}