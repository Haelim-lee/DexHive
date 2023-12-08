using System.Windows.Forms;

namespace DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.공정관리_반제품_
{
    public class 자재LOT검색모델
    {
        public TextBox 제품코드 { get; internal set; }
        public TextBox 제품명 { get; internal set; }
        public ComboBox 자재코드 { get; internal set; }
        public TextBox 자재LOT { get; internal set; }
    }
}