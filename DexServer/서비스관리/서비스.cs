using DexHive.데이터베이스;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DexServer
{
    public class 서비스 : I서버인터페이스//서비스
    {
        public 데이터베이스관리자 데이터베이스 { get; set; }
        public 쿼리 쿼리저장소 { get; set; }

        public 서비스()
        {
            this.데이터베이스 = new 데이터베이스관리자();
            쿼리저장소 = new 쿼리();
        }

        public Hashtable 명령수행(string 아이디, Hashtable 매개변수)
        {
            Hashtable Result = new Hashtable();
            try
            {
                string 명령어 = 쿼리저장소.조회(아이디);
                ExcuteQuery(명령어, 매개변수);

                Result["Command"] = 명령어;
                Result["IsSuccess"] = true;
                return Result;
            }
            catch(Exception e)
            {

                Result["ErrorMsg"] = e.Message;
                Result["Action"] = "명령수행";
                Result["IsSuccess"] = false;
                return Result;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="아이디">쿼리 아이디</param>
        /// <param name="매개변수">쿼리 매개변수</param>
        /// <returns></returns>
        public DataTable 조회수행(string 아이디, Hashtable 매개변수)
        {
            string Param = string.Empty;
            foreach (DictionaryEntry item in 매개변수)
            {
                if (item.Value as string != string.Empty) 
                {
                    //if (item.Value is DateTime[] && (item.Value as DateTime[]).Length == 2)
                    //{
                    //    string 시작시간 = (item.Value as DateTime[])[0].ToShortDateString();
                    //    string 종료시간 = (item.Value as DateTime[])[1].ToShortDateString();
                    //    Param += "AND " + item.Key.ToString() + " BETWEEN " + 시작시간 + " AND " + 종료시간 + "\n";
                    //}
                    string[] Params = item.Value.ToString().Split(',');
                    if (Params.Length > 1)
                    {
                        if (Regex.IsMatch(Params[0], @"^(19|20)\d{2}-(0[1-9]|1[012])-(0[1-9]|[12][0-9]|3[0-1])$"))
                        {
                            string 시작시간 = Params[0];
                            string 종료시간 = Params[1];
                            Param += "AND " + item.Key.ToString() + " BETWEEN '" + 시작시간 + "' AND '" + 종료시간 + "'\n";
                        }
                        else
                        {
                            Param += "AND ";
                            for (int i = 0; i < Params.Length; i++)
                            {
                                if (i == 0) Param += item.Key.ToString() + " IN ( '" + Params[i] + "'";

                                else Param += ", '" + Params[i] + "'";

                                if (i == Params.Length - 1)
                                {
                                    Param += ")\n";
                                }
                            }
                        }
                    }
                    else
                    {
                        Param += "AND " + item.Key + " LIKE '%" + item.Value + "%'\n";
                    }
                }
            }
            string 명령어 = string.Format(쿼리저장소.조회(아이디),Param);
            return GetDataTable(명령어);
        }

        public DataTable 조회수행(string 아이디, Hashtable 매개변수, bool 쿼리파라미터여부)
        {
            if (쿼리파라미터여부 == true)
            {
                string Param = string.Empty;
                foreach (DictionaryEntry item in 매개변수)
                {
                    Param += item.Value.ToString() + "\n";
                }
                string 명령어 = string.Format(쿼리저장소.조회(아이디), Param);
                return GetDataTable(명령어);
            }
            else
            {
                return 조회수행(아이디, 매개변수);
            }
        }

        //테이블 조회 수행
        public DataTable GetDataTable(string 명령어)
        {
            DataTable DT = 데이터베이스.조회수행(명령어);
            DT.TableName = "Result";
            return DT;
        }

        //쿼리명령 수행
        public void ExcuteQuery(string 명령어)
        {
            this.데이터베이스.트렌젝션시작();
            this.데이터베이스.명령수행(명령어);
            this.데이터베이스.트렌젝션종료();
        }
        public void ExcuteQuery(string 명령어, Hashtable 매개변수)
        {
            try
            {
            데이터베이스.명령관리자.Parameters.Clear();
            foreach (DictionaryEntry item in 매개변수)
                데이터베이스.명령관리자.Parameters.Add(new SqlParameter() { ParameterName = item.Key.ToString(), Value = (item.Value as string == "#NULL#") ? DBNull.Value : item.Value });
            this.데이터베이스.명령관리자.CommandText = 명령어;
            this.데이터베이스.명령관리자.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //그리드 플래그 처리 도구
        public void Flag처리(string 테이블명, Hashtable 매개변수, Hashtable 기존값, DataRowState 상태)
        {
            string Query = string.Empty;
            string Column = string.Empty;
            string Param = string.Empty;
            string Where = string.Empty;
            //파라메타 셋팅
            데이터베이스.명령관리자.Parameters.Clear();

            foreach (DictionaryEntry item in 매개변수)
                데이터베이스.명령관리자.Parameters.Add(new SqlParameter() { ParameterName = item.Key.ToString(), Value = (item.Value as string == "#NULL#") ? DBNull.Value: item.Value });
            //쿼리생성
            if (상태 == DataRowState.Added)
            {
                Query = @"------------------------------
                            INSERT INTO {0}({1})
                                   VALUES({2});
                          ------------------------------";
                foreach (DictionaryEntry item in 매개변수)
                {
                    Column += item.Key + ",";
                    Param += "@" + item.Key + ",";
                }
                Query=string.Format(Query, 테이블명, Column.Substring(0, Column.Length - 1), Param.Substring(0, Param.Length - 1));
                ExcuteQuery(Query);
            }
            else if(상태 == DataRowState.Modified)
            {
                Query = @"------------------------------
                            UPDATE {0}
                               SET {1}
                             WHERE {2}
                          ------------------------------";


                foreach (DictionaryEntry item in 매개변수)
                    Param += item.Key + "=" + "@" + item.Key + ",";
                foreach (DictionaryEntry item in 기존값)
                {
                    if (item.Value as string == "#NULL#")
                    {
                        Where += item.Key + " IS NULL" + " AND ";
                    }
                    else
                    {
                        Where += item.Key + "=" + "'" + item.Value + "' AND ";
                    }
                }

                Query = string.Format(Query, 테이블명, Param.Substring(0, Param.Length - 1),Where.Substring(0,Where.Length-4));
                ExcuteQuery(Query);
            }
            else if (상태 == DataRowState.Deleted)
            {
                foreach (DictionaryEntry item in 기존값)
                {
                    데이터베이스.명령관리자.Parameters.Add(new SqlParameter() { ParameterName = item.Key.ToString(), Value = item.Value });
                    if (item.Value as string == "#NULL#")
                    {
                        Param += " AND " +item.Key + " IS NULL";
                    }
                    else
                    {
                        Param += " AND "+ item.Key + " = " + "'" + item.Value + "'";
                    }
                }
                Query = @"------------------------------
                            DELETE FROM {0}
                                  WHERE 1=1
                                        {1}
                          ------------------------------";
                Query = string.Format(Query, 테이블명,  Param);
                ExcuteQuery(Query);
            }
        }

        public DataSet 프로시저호출(string 프로시저명, Dictionary<string, Hashtable> 입력매개변수, Dictionary<string, Hashtable> 출력매개변수)
        {
            DataSet 출력결과 = new DataSet();
            데이터베이스.명령관리자.Parameters.Clear();
            데이터베이스.명령관리자.Connection = 데이터베이스.연결관리자;
            데이터베이스.명령관리자.CommandType = CommandType.StoredProcedure;
            데이터베이스.명령관리자.CommandText = 프로시저명;

            foreach (KeyValuePair<string, Hashtable> 입력변수 in 입력매개변수)
                매개변수생성(입력변수, false);
            foreach (KeyValuePair<string, Hashtable> 출력변수 in 출력매개변수)
                매개변수생성(출력변수, true);

            데이터베이스.명령관리자.ExecuteNonQuery();
            데이터베이스.연동관리자.Fill(출력결과);
            return 출력결과;
        }

        private void 매개변수생성(KeyValuePair<string, Hashtable> 입력변수, bool 방향)//매개변수생성
        {
            SqlParameter Param = new SqlParameter();
            Param.ParameterName = 입력변수.Key;
            Param.Value = 입력변수.Value["값"];
            Param.DbType = (DbType)GetDataType(입력변수.Value["자료형"] as string);
            Param.Direction = (방향 == true)? ParameterDirection.Output : ParameterDirection.Input;
            데이터베이스.명령관리자.Parameters.Add(Param);
        }

        private SqlDbType GetDataType(string 자료형)
        {
            switch (자료형)
            {
                case "NVARCHAR" :
                    return SqlDbType.NVarChar;
                case "VARCHAR":
                    return SqlDbType.VarChar;
                case "INT":
                    return SqlDbType.Int;
                default:
                    return SqlDbType.VarChar;
            }

        }
    }
}
 