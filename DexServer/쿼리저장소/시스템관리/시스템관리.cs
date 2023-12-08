using System;

namespace DexServer
{
    public class 시스템관리
    {
        public string 기준정보조회()
        {
            return @"-----------------------------------
            SELECT   [명칭]
                    ,[코드]
                    ,[코드그룹]
                    ,[코드설명]
                FROM [기준정보]
                WHERE 1=1
                {0}";
        }
        public string 코드그룹조회()
        {
            return @"-----------------------------------
                    SELECT '전체' AS 명칭, '' AS 코드
                            UNION ALL
                    SELECT Distinct
                             [코드그룹] AS 명칭
                            ,[코드그룹] AS 코드
					     
                        FROM [기준정보]
                        WHERE 1=1
                        {0}";
        }
        public string 공통코드조회()
        {
            return @"-----------------------------------
                    SELECT Distinct
                             [명칭]
                            ,[코드]
                        FROM [기준정보]
                        WHERE 1=1
                        {0}";
        }

        public string 테이블정보()
        {
            return @"-----------------------------------
                  SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES";
        }

        public string 컬럼정보()
        {
            return @"-----------------------------------
                  SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS
                   WHERE 1=1
                     {0}";

        }

        public string 가상데이터()
        {
            return @"-----------------------------------
                    SELECT[데이터포멧1]
                         ,[데이터포멧2]
                         ,[데이터포멧3]
                         ,[데이터타입코드]
                         ,[데이터타입값]
                     FROM [가상데이터타입]
                    WHERE 1=1
                        {0}";
        }
    }
}