using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DexServer.쿼리저장소.계약관리그룹
{
    public class 계약관리
    {
        public string 계약관리조회()
        {
            return @"----------------------
                SELECT [구분]
                      ,[최종_적용일자]
                      ,[마진율]
                      ,[공급가_BOX]
                      ,[부가세_BOX]
                      ,[소계_BOX]
                      ,[공급가_EA]
                      ,[부가세_EA]
                      ,[소계_EA]
                  FROM [거래처관리]
            ------------------------";
        }

        public string 매입매출원장()
        {
            return @"-----------------
               SELECT [일자]
                      ,[구분]
                      ,[거래처명]
                      ,[거래번호]
                      ,[적요]
                      ,[매입금액_매입]
                      ,[지불액_매입]
                      ,[잔액_매입]
                      ,[매출금액_매출]
                      ,[수금액_매출]
                      ,[잔액_매출]
                      ,[수입_결산]
                      ,[지출_결산]
                      ,[잔액_결산]
                  FROM [매입매출원장]
                  WHERE 1=1
                  {0}
                  ---------------------";
        }

    }
}
