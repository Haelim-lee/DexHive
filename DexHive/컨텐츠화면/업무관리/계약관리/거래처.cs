using System.Windows.Forms;
using DexCommonUtil.UI도구.사용자정의컨트롤;

namespace DexHive.컨텐츠화면.업무관리.계약관리
{
    public class 거래처
    {
        public TextBox 텍스트1 { get; internal set; }
        public TextBox 텍스트2 { get; internal set; }
        public TextBox 텍스트3 { get; internal set; }
        public TextBox 텍스트4 { get; internal set; }
        public ComboBox 콤보박스1 { get; internal set; }
        public Button 버튼1 { get; internal set; }
        public DexGridView 거래처관리표 { get; internal set; }
    }
}