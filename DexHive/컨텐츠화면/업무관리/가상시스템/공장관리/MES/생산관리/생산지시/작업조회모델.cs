using System.Windows.Forms;

namespace DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.작업지시
{
    public class 작업조회모델
    {
        public ComboBox 제품명 { get; internal set; }
        public ComboBox 생산구분 { get; internal set; }
        public ComboBox LOT상태 { get; internal set; }
        public DateTimePicker 날짜검색시작 { get; internal set; }
        public DateTimePicker 날짜검색종료 { get; internal set; }
    }
}