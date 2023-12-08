using System.Windows.Forms;

namespace DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.생산계획
{
    public class 조회조건모델
    {
        public 조회조건모델()
        {

        }

        public ComboBox 제품콤보 { get; set; }
        public DateTimePicker 시작날짜 { get; set; }
        public DateTimePicker 종료날짜 { get; set; }
    }
}