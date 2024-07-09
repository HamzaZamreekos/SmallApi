using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SmallApi.Builders
{
    public class EndpointBuilder
    {
        List<string> endpoints = new List<string>();
        private StringBuilder template = new("http://");
        private string defaultIp = IPAddress.Any.ToString();

        public EndpointBuilder() 
        {
            
        }
        public EndpointBuilder WithIpAddress(IPAddress address)
        {
            template.Append(address.ToString());
            return this;
        }
        public EndpointBuilder WithPort(string port)
        {
            template.Append(port);
            return this;
        }
        public EndpointBuilder WithEndpoint(string endpoint)
        {
            endpoints.Add(template.ToString() + endpoint);
            return this;
        }
        public List<string> Build()
        {
            return endpoints;
        }

    }
}
