using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DexServer
{
    [ServiceContract]
    public interface I서버인터페이스
    {
        [OperationContract]
        DataTable GetDataTable(string 명령어);

        [OperationContract]
        void ExcuteQuery(string 명령어);

        [OperationContract]
        Hashtable 명령수행(string 아이디, Hashtable 매개변수);

        [OperationContract]
        DataTable 조회수행(string 아이디, Hashtable 매개변수);

        [OperationContract]
        void Flag처리(string 테이블명, Hashtable 매개변수 , Hashtable 기존값, DataRowState 상태);

        [OperationContract]
        DataSet 프로시저호출(string 프로시저명, Dictionary<string, Hashtable> 입력매개변수, Dictionary<string, Hashtable> 출력매개변수);
    }
}
