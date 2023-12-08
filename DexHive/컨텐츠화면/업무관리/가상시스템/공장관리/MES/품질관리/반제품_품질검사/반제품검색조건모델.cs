using System.Windows.Forms;

namespace DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.품질관리.반제품_품질검사
{
    public class 반제품검색조건모델
    {
        public 반제품검색조건모델()
        {
        }

        public ComboBox 제품구분 { get;  set; }
        public ComboBox 설비 { get;  set; }
        public ComboBox 반제품 { get;  set; }
        public TextBox LOT설비 { get;  set; }
        public TextBox 생산계획오더 { get;  set; }
        public TextBox 반제품명 { get;  set; }
        public TextBox LOTID { get;  set; }
        public TextBox 생산계획타입 { get;  set; }
        public TextBox 수량 { get;  set; }
        public TextBox 수량타입 { get;  set; }
    }
}