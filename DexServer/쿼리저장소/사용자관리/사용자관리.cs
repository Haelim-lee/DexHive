using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DexServer.회원관리서비스
{
    public class 사용자관리
    {
        public string 사용자조회()
        {
            return @"-----------------------------------
                SELECT [아이디]
                      ,[이름]
                      ,[비밀번호]
                      ,[생년월일]
                      ,[이메일]
                      ,[연락처]
                  FROM [사용자정보]
                 WHERE 1=1
                   {0}";
        }
    }
}
