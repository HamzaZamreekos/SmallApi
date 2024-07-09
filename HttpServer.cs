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
        private HttpListener _listener;
        public HttpServer(List<string> endpoints) 
        {
            _listener = new HttpListener();
            endpoints.ForEach(endpoint => _listener.Prefixes.Add(endpoint));
        }

        public void Start()
        {
            _listener.Start();
        }
    }
}
