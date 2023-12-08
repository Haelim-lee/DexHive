using System.Collections;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DexCommonUtil.UI도구
{
    public class 공통기능
    {

        public Hashtable 조회_매개변수 { get; set; }
        public Hashtable 저장_매개변수 { get; set; }
        public Hashtable 삭제_매개변수 { get; set; }
        public Hashtable 수정_매개변수 { get; set; }
        public ToolStripButton 저장버튼 { get; set; }
        public ToolStripButton 조회버튼 { get; set; }
        public ToolStripButton 행추가버튼 { get; set; }
        public ToolStripButton 행제거버튼 { get; set; }
    }
}

