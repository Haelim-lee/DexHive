using System.Windows.Forms;

namespace DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.공정관리_반제품_
{
    public class LOT목록검색_모델
    {
        public TextBox Productionorder { get; set; }
        public ComboBox Productiontype { get; set; }
        public ComboBox LOT진행상태 { get; set; }
        public TextBox LOTProgress { get; set; }
        public DateTimePicker dateTimeStart { get;  set; }
        public DateTimePicker dateTimeEnd { get;  set; }
        public ComboBox 제품 { get;  set; }
        public TextBox 생산LOT { get;  set; }
        public NumericUpDown 투입수량 { get;  set; }
        public ComboBox 투입설비 { get;  set; }
        public DateTimePicker 투입일시 { get; internal set; }
    }
}