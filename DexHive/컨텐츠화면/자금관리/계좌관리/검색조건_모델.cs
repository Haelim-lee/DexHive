using System.Windows.Forms;

namespace DexHive.컨텐츠화면.자금관리.계좌관리
{
    public class 검색조건_모델
    {
        public 검색조건_모델()
        {
        }

        public TextBox 예금주 { get; internal set; }
        public ComboBox 은행명 { get; internal set; }
        public TextBox 계좌번호 { get; internal set; }
        public ComboBox 금융상품 { get; internal set; }
    }
}