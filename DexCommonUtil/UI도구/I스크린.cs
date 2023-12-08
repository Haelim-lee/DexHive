using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DexCommonUtil.UI도구
{
    public interface I스크린
    {
        void 조회();
        void 저장();
        void 행제거();
        void 행추가();
        void 초기화();
    }
}
