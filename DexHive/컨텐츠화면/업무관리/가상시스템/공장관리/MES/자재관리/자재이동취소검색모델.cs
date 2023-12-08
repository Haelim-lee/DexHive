using System.Windows.Forms;

namespace DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.자재관리
{
    public class 자재이동취소검색모델
    {
        public ComboBox 위치 { get; internal set; }
        public ComboBox 위치그룹 { get; internal set; }
        public TextBox 자재LOT { get; internal set; }
        public DateTimePicker 검색날짜시작 { get; internal set; }
        public DateTimePicker 검색날짜종료 { get; internal set; }
    }
}