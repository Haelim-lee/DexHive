using System.Data;

namespace DexCommonUtil.UI도구.사용자정의컨트롤
{
    public class DexGridColumn
    {
        public string 헤더명 { get; set; }
        public string 컬럼명 { get; set; }
        public 컬럼타입 컬럼타입 { get; set; }
        public DataTable 콤보박스데이터소스 { get; set; }
        public string 콤보박스디스플레이멤버 { get; set; }
        public string 콤보박스벨류멤버 { get; set; }
        public int 너비 { get; set; }
    }
}