using DexServer;
using System;
using System.Data;
using System.ServiceModel;
using System.Windows.Forms;

namespace DexHive
{
    public class 서비스_클라이언트
    {
        public ChannelFactory<I서버인터페이스> 통신서버 { get; set; }
        public I서버인터페이스 서비스 { get; set; }//서비스

        public 서비스_클라이언트()//클라이언트서비스
        {
            //클라이언트  설정
            통신서버 = new ChannelFactory<I서버인터페이스>();//통신서버

            // Address
            string address = "net.tcp://localhost:8080/myAddress";
            통신서버.Endpoint.Address = new EndpointAddress(address);

            // Binding : TCP 사용
            NetTcpBinding binding = new NetTcpBinding();
            binding.ReliableSession.InactivityTimeout = new TimeSpan(3, 0, 0);
            binding.CloseTimeout = new TimeSpan(0, 10, 0);
            binding.OpenTimeout = new TimeSpan(0, 10, 0);
            binding.ReceiveTimeout = new TimeSpan(0, 10, 0);
            binding.SendTimeout = new TimeSpan(0, 10, 0);
            binding.MaxBufferSize = 2147483647;
            binding.MaxBufferPoolSize = 2147483647;
            binding.MaxReceivedMessageSize = 2147483647;
            통신서버.Endpoint.Binding = binding;



            // Contract 설정
            통신서버.Endpoint.Contract.ContractType = typeof(I서버인터페이스);

            // Channel Factory 만들기
            서비스 = 통신서버.CreateChannel();//서버

            // Server 쪽 함수 호출
            DataTable result = 서비스.GetDataTable(@"SELECT [아이디],
                                                            [비밀번호],
                                                            [이름]
                                                       FROM [사용자정보]");
            // close Channel
            
        }


    }
}