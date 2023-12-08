using System.Windows.Forms;

namespace DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.자재관리
{
    public class 자재등록모델
    {
        public TextBox 자재코드ID { get;  set; }
        public TextBox 자재코드명 { get; set; }
        public TextBox 자재그룹ID { get; set; }
        public TextBox 자재코드타입 { get; set; }
        public TextBox 자재기준수량 { get; set; }
        public TextBox 자재기준단위 { get; set; }
        public ComboBox 이동위치 { get; internal set; }
    }
}