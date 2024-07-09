using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using SmallApi.Attributes;

namespace SmallApi.Helpers
{
    public class ControllerManager
    {
        List<string> endpoints = new();
        public List<string> GetEndpointsFromController<T>() where T : class
        {
            var controllerType = typeof(T);
            var methods = controllerType.GetMethods(BindingFlags.Public | BindingFlags.Instance);

            foreach (var method in methods)
            {
                var attribute = method.GetCustomAttribute<RouteAttribute>();
                if (attribute != null)
                {
                    Console.WriteLine($"Invoking method: {method.Name}, Description: {attribute.routeUrl}");
                    //method.Invoke(controllerType, null);
                    endpoints.Add(attribute.routeUrl);
                }
            }
            return endpoints;
        }
    }
}
