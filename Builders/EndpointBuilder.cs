using SmallApi.Helpers;
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
        private ControllerManager manager;
        public EndpointBuilder() 
        {
            manager = new();
        }
        public EndpointBuilder WithIpAddress(IPAddress address)
        {
            template.Append(address.ToString());
            return this;
        }
        public EndpointBuilder WithPort(int port)
        {
            template.Append(":"+port);
            return this;
        }
        public EndpointBuilder WithEndpoint(string endpoint)
        {
            endpoints.Add(template.ToString() + endpoint);
            return this;
        }
        public EndpointBuilder WithController<T>() where T : class
        {
            var localEndpoints = manager.GetEndpointsFromControllerAndRegisterThem<T>();
            localEndpoints.ForEach(endpoint => endpoints.Add(template.ToString() + endpoint + "/"));
            return this;
        }
        public List<string> Build()
        {
            return endpoints;
        }

    }
}
