using System;

namespace DexServer
{
    public class 직원관리
    {
        public string 직원조회()
        {
            return @"-----------------------------------
                SELECT [아이디]
                      ,[이름]
                      ,[입사일]
                      ,[생년월일]
                      ,[직급]
                  FROM [직원정보]
                 WHERE 1=1
                   {0}";
        }
    }
}