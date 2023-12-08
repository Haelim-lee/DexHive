using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DexServer
{
    class Program
    {
        static void Main(string[] args)
        {
            new 서비스_서버(new ServiceHost(typeof(서비스)));
        }
    }
}
