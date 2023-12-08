using System.Windows.Forms;

namespace DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.자재관리
{
    public class 자재폐기검색모델
    {
        internal TextBox QTY;

        public DateTimePicker 기간시작 { get;  set; }
        public DateTimePicker 기간종료 { get;  set; }
        public ComboBox 위치그룹 { get;  set; }
        public ComboBox 위치 { get;  set; }
        public TextBox 자재LOT { get;  set; }
        public TextBox 생산LOT { get;  set; }
        public TextBox 자재타입 { get;  set; }
        public TextBox 재고수량 { get;  set; }
        public TextBox 현위치 { get;  set; }
        public TextBox 자재명 { get;  set; }
        public ComboBox 폐기사유 { get;  set; }
        public TextBox 폐기사유2 { get;  set; }
        public ComboBox 특이사항 { get;  set; }
    }
}