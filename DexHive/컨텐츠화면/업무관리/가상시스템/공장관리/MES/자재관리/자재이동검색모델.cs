using System.Windows.Forms;

namespace DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.자재관리
{
    public class 자재이동검색모델
    {
        public TextBox 자재LOT { get;  set; }
        public ComboBox 이동위치그룹 { get;  set; }
        public ComboBox 이동위치 { get;  set; }
        public Button Popup { get;  set; }
    }
}