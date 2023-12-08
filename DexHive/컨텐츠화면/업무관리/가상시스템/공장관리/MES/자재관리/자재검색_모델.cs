using System.Windows.Forms;

namespace DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.자재관리
{
    public class 자재검색_모델
    {
        public ComboBox 공급사명 { get; set; }
        public TextBox 자재LOT { get;  set; }
        public ComboBox 자재명 { get; set; }
        public ComboBox 자재위치 { get; set; }
        public DateTimePicker 자재날짜검색_시작 { get;  set; }
        public DateTimePicker 자재날짜검색_종료 { get;  set; }
    }
}