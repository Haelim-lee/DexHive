using DexHive.데이터베이스;
using System;
using System.ServiceModel;

namespace DexServer
{
    public class 서비스_서버
    {
        public 서비스_서버(ServiceHost host)//서비스
        {
                // Service Host 만들기
                string address = "net.tcp://localhost:8080/myAddress";
                NetTcpBinding binding = new NetTcpBinding();
                binding.ReliableSession.InactivityTimeout = new TimeSpan(3, 0, 0);
                binding.CloseTimeout = new TimeSpan(0, 10, 0); 
                binding.OpenTimeout = new TimeSpan(0, 10, 0);
                binding.ReceiveTimeout = new TimeSpan(0, 10, 0);
                binding.SendTimeout = new TimeSpan(0, 10, 0);
                binding.MaxBufferSize = 2147483647;
                binding.MaxBufferPoolSize = 2147483647;
                binding.MaxReceivedMessageSize = 2147483647;
                // End Point 추가
                host.AddServiceEndpoint(typeof(I서버인터페이스), binding, address);
                // Service Host 시작
                host.Open();
                Console.ReadLine();
        }
    }
}