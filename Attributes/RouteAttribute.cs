using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallApi.Attributes;

/// <summary>
/// Used to define the route of an endpoint.
/// </summary>
[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
public class RouteAttribute : Attribute
{
    public string routeUrl { get; }
    public RouteAttribute(string url)
    {
        routeUrl = url;
    }
}
