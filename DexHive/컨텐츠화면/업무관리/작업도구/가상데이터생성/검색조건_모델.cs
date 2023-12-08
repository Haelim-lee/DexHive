using System.Windows.Forms;

namespace DexHive.컨텐츠화면.업무관리.작업도구.가상데이터생성그룹
{
    public class 검색조건_모델
    {
        public ComboBox 테이블명 { get; set; }
        public ComboBox 컬럼명 { get; set; }
        public ComboBox 데이터종류 { get; set; }
        public RadioButton 데이터타입_시퀀스 { get; internal set; }
        public RadioButton 데이터타입_문자열 { get; internal set; }
    }
}