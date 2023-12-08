using System.Windows.Forms;

namespace DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.실적리포트
{
    public class 생산LOT추적검색_모델
    {
        public DateTimePicker 날짜검색_시작 { get;  set; }
        public DateTimePicker 날짜검색_종료 { get;  set; }
        public ComboBox 제품 { get;  set; }
        public TextBox 생산LOT { get;  set; }
        public ComboBox 제품구분 { get;  set; }
        public ComboBox 제품군 { get;  set; }
    }
}