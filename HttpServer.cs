using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SmallApi
{
    public class HttpServer
    {
        public HttpServer() 
        {
            
        }
        private HttpListener _listener;

        public void Start()
        {
            _listener = new HttpListener();
            _listener.Prefixes.Add();
            _listener.Start();
        }
    }
}
