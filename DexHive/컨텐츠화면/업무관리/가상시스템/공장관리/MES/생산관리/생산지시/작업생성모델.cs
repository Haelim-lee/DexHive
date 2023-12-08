using System.Windows.Forms;

namespace DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.작업지시
{
    public class 작업생성모델
    {
        public 작업생성모델()
        {
        }

        public ComboBox 제품구분 { get; internal set; }
        public ComboBox 제품명 { get; internal set; }
        public ComboBox 생산계획타입 { get; internal set; }
        public ComboBox 단위 { get; internal set; }
    }
}