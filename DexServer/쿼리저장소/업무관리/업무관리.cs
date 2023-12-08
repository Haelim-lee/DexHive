using System;

namespace DexServer
{
    public class 업무관리
    {
       
        public string 자재공급사조회()
        {
            return @"-----------------------------------
            SELECT   A.[MATERIALDEFINITIONID]
                    ,A.[MATERIALDEFINITIONNAME]
                    ,A.[MATERIALLOTID]
                    ,A.[PREVLOCATION]
                    ,A.[LOCATION]
                    ,A.[QTY]
                    ,A.[UNITID]
                    ,A.[CREATETIME]
                    ,B.[VENDORID]
                    ,A.[PRODUCTTIME]
                    ,A.[LIMIT]
                    ,A.[LIMITTIME]
                FROM [CIM_MATERIALLOT] A
                LEFT JOIN [CIM_VENDOR] B
                ON A.VENDORID =B.VENDORID";
        }
        public string 공급사조회()
        {
            return @"-----------------------------------
                  SELECT VENDORID, VENDORNAME FROM CIM_VENDOR
                   WHERE 1=1
                     {0}";

        }

        public string 자재조회()
       {
            return @"-----------------------------------------------------
                            SELECT * FROM 
                    (SELECT * FROM 기준정보 WHERE 코드그룹 = '자재코드') A 
                    LEFT JOIN CIM_MATERIALLOT B
                    ON A.코드 =  B.MATERIALDEFINITIONID
                    AND A.명칭 = B.MATERIALDEFINITIONNAME
                            WHERE 1=1
                                {0}";

       }
        public string 자재등록()
        {
            return @"-------------------------------------
                             INSERT INTO [CIM_MATERIALLOT]
                            ( [MATERIALLOTID]
                            ,[MATERIALTYPE]
                            ,[VENDORID]
                            ,[LOCATION])

                                VALUES
                               (@MATERIALTYPE
                               ,@LOCATION
                               ,@VENDORID
                               ,@MATERIALLOTID)";

        }

        public string 제품수정2()
        {

            return @"----------------------------
                        INSERT INTO CIM_PRODUCTDEFINITION
                        (
                        PRODUCTDEFINITIONID,
                        PRODUCTDEFINITIONNAME,
                        SITEID,
                        QTY,
                        UNITID,
                        PRODUCTDEFINITIONTYPE,
                        CUSTOMERID,
                        LOCATION,
                        MATERIALTYPE,
                        MODIFYTIME
                        )
                        VALUES
                        (
                        @PRODUCTDEFINITIONID,
                        @PRODUCTDEFINITIONNAME,
                        @SITEID,
                        @QTY,
                        @UNITID,
                        @PRODUCTDEFINITIONTYPE,
                        @CUSTOMERID,
                        @LOCATION,
                        @MATERIALTYPE,
                        @MODIFYTIME
                        )
                        ------------------------------";

        }

        public string 자재폐기조회()
        {
            return @"----------------------------------------------------
                            SELECT A.[MATERIALLOTID]
                            ,A.[LOCATION]
                            ,A.[MATERIALTYPE]
                            ,A.[MATERIALDEFINITIONID]
                            ,B.[MATERIALDEFINITIONNAME]
                            ,C.[LOTID]
                            ,A.[QTY]
                            ,A.[UNITID]
                            ,A.[CREATETIME]
                            ,A.[VENDORID]

                            FROM [CIM_MATERIALLOT] A
                            LEFT JOIN [CIM_MATERIALDEFINITION] B
                            ON A.MATERIALDEFINITIONID = B.MATERIALDEFINITIONID
                            LEFT JOIN [CIM_LOTMATERIALLOTREL] C
                            ON A.MATERIALLOTID =C.MATERIALLOTID
                            ";
        }

        public string LOT추가팝업창()
        {
            return @"-------------------------------------------
                    SELECT A.[MATERIALDEFINITIONID]
                         , B.[MATERIALDEFINITIONNAME]
                         , A.[QTY]
                         , A.[UNITID]
,

                    FROM [CIM_MATERIALDEFINITION] A
                    LEFT JOIN [CIM_MATERIALLOT] B
                    ON A.MATERIALDEFINITIONID =B.MATERIALDEFINITIONID
                        ";
        }

        public string 자재이동취소()
        {
            return @"---------------------------------------
                        SELECT A.[MATERIALTYPE]
                        ,A.[MATERIALDEFINITIONID]
                        ,B.[MATERIALDEFINITIONNAME]
                        ,C.[LOTID]
                        ,A.[QTY]
                        ,A.[UNITID]
                        ,A.[CREATETIME]
                        ,A.[VENDORID]
                        FROM [CIM_MATERIALLOT] A
                        LEFT JOIN [CIM_MATERIALDEFINITION] B
                        ON A.MATERIALCLASSID = B.MATERIALCLASSID
                        LEFT JOIN [CIM_LOT] C
                        ON B.ACTIVITY = C.ACTIVITY
                        ";
        }

        public string 생산LOT등록()
        {
            return @"----------------------------------------
                        INSERT INTO [CIM_LOT]
                         ([PRODUCTORDERID]
                        ,[PRODUCTDEFINITIONID]
                        ,[LOTID]
                        ,[SITEID]
                        ,[CREATETIME]
                        ,[MODIFYTIME]
                        ,[VENDORID])
                        VALUES 
                        (@PRODUCTORDERID
                        ,@PRODUCTDEFINITIONID
                        ,@LOTID
                        ,@SITEID
                        ,@CREATETIME
                        ,@MODIFYTIME
                        ,@VENDORID 
                        )";
        }

        public string 자재이동()
        {
            return @"---------------------------------------
                        INSERT INTO [CIM_MATERIALLOT]
                                (MATERIALLOTID
                                ,MATERIALDEFINITIONID
                                ,LOCATION
                                ,ORIGINALQTY
                                ,QTY
                                ,PREVLOCATION
                                ,PREVQTY)
                                VALUES
                                (@MATERIALLOTID
                                ,@MATERIALDEFINITIONID
                                ,@LOCATION
                                ,@ORIGINALQTY
                                ,@QTY
                                ,@PREVLOCATION
                                ,@PREVQTY)";
        }

        public string 주제공정시작()
        {
            return @"---------------------------------------
                             SELECT 
                             A.[PRODUCTORDERID]
                            ,A.[PRODUCTORDERTYPE]
                            ,A.[PRODUCTDEFINITIONID]
                            ,C.[PRODUCTDEFINITIONNAME]
                            ,B.[ORIGINALQTY]
                            ,A.[QTY]
                            ,A.[UNITID]
                            ,A.[SCHEDULESTARTTIME]
                            ,A.[SCHEDULEENDTIME]
                            ,B.[LOTID]
                            ,A.[STATE]
                            FROM [CIM_PRODUCTORDER] A 
                            LEFT JOIN [CIM_LOT] B
                            ON A.PRODUCTORDERID = B.PRODUCTORDERID
                            LEFT JOIN [CIM_PRODUCTDEFINITION] C
                            ON A.PRODUCTDEFINITIONID = C.PRODUCTDEFINITIONID";
        }

        public string 고객사조회()
        {
            return @"-----------------------------------
                        SELECT  VENDORID AS  [코드]
                               ,VENDORNAME AS [명칭]
                            FROM CIM_VENDOR
                            WHERE 1=1
                            {0}";
        }

        public string 자재입고등록1()
        {
            return @"---------------------------------------------
                        INSERT INTO CIM_MATERIALLOT
                        ( MATERIALDEFINITIONID
                        ,MATERIALDEFINITIONNAME
                        ,LOCATION
                        ,VENDORID
                        ,QTY
                        ,UNITID
                        ,CREATETIME
                        ,MODIFYTIME
                        ,MATERIALLOTID)
                         VALUES
                        (@MATERIALDEFINITIONID
                        ,@MATERIALDEFINITIONNAME
                        ,@LOCATION
                        ,@VENDORID
                        ,@QTY
                        ,@UNITID
                        ,@CREATETIME
                        ,@MODIFYTIME
                        ,@MATERIALLOTID
                        )
                     ---------------------------------------------";
        }

        public string 제품수정3()
        {

            return @"----------------------------
                       UPDATE CIM_PRODUCTDEFINITION
                       SET SITEID = @SITEID
	                      ,QTY = @QTY
	                      ,UNITID = @UNITID
	                      ,PRODUCTDEFINITIONTYPE = @PRODUCTDEFINITIONTYPE
	                      ,CUSTOMERID = @CUSTOMERID
	                      ,LOCATION = @LOCATION
	                      ,MATERIALTYPE = @MATERIALTYPE
	                      ,MODIFYTIME = @MODIFYTIME
                        WHERE PRODUCTDEFINITIONID = @PRODUCTDEFINITIONID
                        AND PRODUCTDEFINITIONNAME = @PRODUCTDEFINITIONNAME
            
                        ------------------------------";

        }

        public string 제품등록()
        {
            return @"------------------
                          INSERT INTO [기준정보]
                            ( 
                             [코드그룹]
                            ,[코드]
                            ,[명칭]
                            ,[코드설명]
                            )

                                VALUES
                               ('제품'
                               ,@PRODUCTDEFINITIONID
                               ,@PRODUCTDEFINITIONNAME
                               ,'제품정보'
                                )
            --------------------------";
        }

        public string 월생산계획()
        {
            return @"---------------------------------------
                           SELECT  A. [PLANID]
                                  ,A.[PRODUCTDEFINITIONID]
	                              ,B.[PRODUCTDEFINITIONNAME]
                                  ,A.[SITEID]
                                  ,A.[PRODUCTTYPE]
                                  ,A.[WEEKQTY1]
                                  ,A.[WEEKQTY2]
                                  ,A.[WEEKQTY3]
                                  ,A.[WEEKQTY4]
                                  ,A.[WEEKQTY5]
                                  ,TRY_CONVERT(INT,A.[WEEKQTY1]) + TRY_CONVERT(INT,A.[WEEKQTY2]) + TRY_CONVERT(INT,A.[WEEKQTY3]) + TRY_CONVERT(INT,A.[WEEKQTY4]) + TRY_CONVERT(INT,A.[WEEKQTY5]) as QTY
                                  ,A.[UNITID]
                                  ,A.[ACTIVITY]
                                  ,A.[PREACTIVITY]
                                  ,A.[CUSTOMACTIVITY]
                                  ,A.[PREVCUSTOMACTIVITY]
                                  ,A.[ISUSABLE]
                                  ,A.[DESCRIPTION]
                                  ,A.[REASONCODE]
                                  ,A.[COMMENTS]
                                  ,A.[CREATOR]
                                  ,A.[CREATETIME]
                                  ,A.[MODIFIER]
                                  ,A.[MODIFYTIME]
                                  ,A.[LASTEVENTTIME]
                                  ,A.[TID]
                              FROM [CST_MONTHLYPLAN] A
                              LEFT JOIN CIM_PRODUCTDEFINITION B
                              ON A.PRODUCTDEFINITIONID = B.PRODUCTDEFINITIONID
                            WHERE 1=1
                            {0}";
        }

        public string 월생산계획추가()
        {
            return @"---------------------------------------
                           INSERT INTO [CST_MONTHLYPLAN]
                                  (
                                   [PLANID]
                                  ,[PRODUCTDEFINITIONID]
                                  ,[SITEID]
                                  ,[WEEKQTY1]
                                  ,[WEEKQTY2]
                                  ,[WEEKQTY3]
                                  ,[WEEKQTY4]
                                  ,[WEEKQTY5]
                                  ,[UNITID]
                                  ,[MODIFYTIME]
                                    )
                            VALUES
                                  (
                                   @PLANID
                                  ,@PRODUCTDEFINITIONID
                                  ,@SITEID
                                  ,@WEEKQTY1
                                  ,@WEEKQTY2
                                  ,@WEEKQTY3
                                  ,@WEEKQTY4
                                  ,@WEEKQTY5
                                  ,@UNITID
                                  ,@MODIFYTIME
                                   )";
        }

            public string 생산계획오더추가()
        {
            return @"-------------------------------------
                             INSERT INTO [CST_MONTHLYPLAN]
                            ([PLANID]
                            ,[PRODUCTDEFINITIONID]
                            ,[PRODUCTDEFINITIONNAME]
                            ,[PRODUCTTYPE]
                            ,[UNITID]
                            ,[CREATOR]
                            ,[CREATETIME]
                            ,[MODIFIER]
                            ,[MODIFYTIME]
                            )

                                VALUES
                               (@MATERIALTYPE
                               ,@LOCATION
                               ,@VENDORID
                               ,@MATERIALLOTID)";

        }
        public string 생산계획오더조회()
        {
            return @"---------------------------------------
                           SELECT A.[PRODUCTORDERID]
                                ,A.[SITEID]
                                ,A.[PRODUCTORDERNAME]
                                ,A.[PRODUCTCLASSID]
                                ,A.[PRODUCTDEFINITIONID]
                                ,B.[PRODUCTDEFINITIONNAME]
                                ,A.[PRODUCTTYPE]
                                ,A.[SALESORDER]
                                ,A.[PRODUCTORDERTYPE]
                                ,A.[STATE]
                                ,A.[PREVSTATE]
                                ,A.[QTY]
                                ,A.[RESULTQTY]
                                ,A.[UNITID]
                                ,A.[REQUESTTIME]
                                ,A.[SCHEDULESTARTTIME]
                                ,A.[SCHEDULEENDTIME]
                                ,A.[STARTTIME]
                                ,A.[ENDTIME]
                                ,A.[CUSTOMERID]
                                ,A.[WORKCENTER]
                                ,A.[ACTIVITY]
                                ,A.[PREVACTIVITY]
                                ,A.[CUSTOMACTIVITY]
                                ,A.[PREVCUSTOMACTIVITY]
                                ,A.[ISUSABLE]
                                ,A.[DESCRIPTION]
                                ,A.[REASONCODE]
                                ,A.[COMMENTS]
                                ,A.[CREATOR]
                                ,A.[CREATETIME]
                                ,A.[MODIFIER]
                                ,A.[MODIFYTIME]
                                ,A.[LASTEVENTTIME]
                                ,A.[TID]
                                ,A.[VENDORID]
                            FROM [CIM_PRODUCTORDER] A
                            LEFT JOIN CIM_PRODUCTDEFINITION B
                            ON A.PRODUCTDEFINITIONID = B.PRODUCTDEFINITIONID
                            WHERE 1=1
                            {0}";
        }

        public string 작업지시조회()
        {
            return @"---------------------------------------
                            SELECT A.[PRODUCTORDERID]
                                  ,A.[SITEID]
                                  ,B.[LOTID]
                                  ,A.[PRODUCTTYPE]
                                  ,A.[QTY]
                                  ,A.[UNITID]
                                  ,A.[SCHEDULESTARTTIME]
                                  ,A.[SCHEDULEENDTIME]
                                  ,A.[CUSTOMERID]
                                  ,A.[MODIFYTIME]
                            FROM [앤츠네스트].[dbo].[CIM_PRODUCTORDER] A
                            LEFT JOIN [CIM_LOT] B
                            ON A.SITEID =B.SITEID
                            AND A.PRODUCTORDERID = B.PRODUCTORDERID
                                 ";
                            
        }

        public string 작업지시추가()
        {
            return @"-------------------------------------
                             INSERT INTO [CIM_PRODUCTORDER]
                            (
                               [PRODUCTORDERID]
                              ,[PRODUCTDEFINITIONID]
                              ,[SITEID]
                              ,[PRODUCTTYPE]
                              ,[QTY]
                              ,[UNITID]
                              ,[SCHEDULESTARTTIME]
                              ,[SCHEDULEENDTIME]
                              ,[MODIFYTIME]
                              ,[STATE]
                                )
                                VALUES
                               (
                               @PRODUCTORDERID
                              ,@PRODUCTDEFINITIONID
                              ,@SITEID
                              ,@PRODUCTTYPE
                              ,@QTY
                              ,@UNITID
                              ,@SCHEDULESTARTTIME
                              ,@SCHEDULEENDTIME
                              ,@MODIFYTIME
                              ,@STATE)";
        }

        public string 제품생산이력조회()
        {
            return @"----------------------------------------
                            SELECT B.[LOTID]
                            ,B.[PARENTLOTID]
                            ,A.[PRODUCTORDERID]
                            ,A.[PRODUCTDEFINITIONID]
                            ,C.[PRODUCTDEFINITIONNAME]
                            ,B.[ORIGINALQTY]
                            ,B.QTY+B.DEFECTQTY+B.LOSSQTY+B.SAMPLEQTY AS SUMQTY
                            ,A.[QTY]
                            ,B.DEFECTQTY+B.LOSSQTY AS SUMMQTY
                            ,B.[UNITID]
                            ,B.[EQUIPMENTID]
                            ,A.[STATE]
                             FROM [CIM_PRODUCTORDER] A
                             LEFT JOIN [CIM_LOT] B
                             ON A.PRODUCTDEFINITIONID = B.PRODUCTDEFINITIONID
                             LEFT JOIN [CIM_PRODUCTDEFINITION] C
                             ON A.PRODUCTDEFINITIONID = C.PRODUCTDEFINITIONID
                             WHERE 1=1
                             {0}";
        }
        public string 생산LOT추적()
        {
            return @"-----------------------------------------------
                            SELECT D.[STATE]
                            ,B.[PRODUCTDEFINITIONID]
                            ,C.[PRODUCTDEFINITIONNAME]
                            ,B.[ACTIVITY]
                            ,B.[STATE]
                            ,A.[QTY]
                            ,A.[UNITID]
                            ,B.[EQUIPMENTID]
                            ,A.[MODIFYTIME]
                            ,B.[EQUIPMENTNAME]
                            ,B.[TRACKINTIME]
                            ,B.[TRACKOUTTIME]

                            FROM [CIM_PRODUCTORDER] A
                            LEFT JOIN [CIM_LOT] B
                            ON A.PRODUCTDEFINITIONID = B.PRODUCTDEFINITIONID

                            LEFT JOIN [CIM_PRODUCTDEFINITION] C
                            ON A.PRODUCTDEFINITIONID = C.PRODUCTDEFINITIONID

                            LEFT JOIN [CIM_EQUIPMENT] D
                            ON B.EQUIPMENTID = D.EQUIPMENTID
                            WHERE 1=1
                            {0}";
        }
        public string LOT이력정보조회()
        {
            return @"-------------------------------------------------------
                            SELECT B.[LOTID]
                            ,B.[PRODUCTDEFINITIONID]
                            ,C.[MATERIALLOTNAME]
                            ,A.[ACTIVITY] 
                            ,A.[STATE] 
                            ,B.[QTY] 
                            ,A.[UNITID]
                            ,B.[EQUIPMENTID]
                            ,B.[MODIFYTIME] 

                            FROM [CIM_LOT] B
                            LEFT JOIN [CIM_PRODUCTORDER] A
                            ON A.PRODUCTDEFINITIONID = B.PRODUCTDEFINITIONID
                            LEFT JOIN [CIM_MATERIALLOT] C
                            ON A.PRODUCTORDERID = C.PRODUCTORDERID
                            WHERE 1=1
                            {0}";
        }
       // public string 소진정보조회()
       // {
          //  return @"--------------------------------------------------------";
//SELECT 


//FROM [] A
//LEFT JOIN []B
//WHERE 1=1
//{0}";
       // }

    }
}